#!/bin/bash

unset SYSROOT
unset CC
unset CXX
unset AR
unset AS
unset CPP
unset LD
unset RANLIB
unset STRIP

function checkresult
{
    RESULT=`echo $?`
    if [ "$RESULT" != 0 ]; then
        echo $1
        exit $RESULT
    fi
}

if [ -z "$NDK" ]
then
    echo "FAILED: You must specify the NDK variable to point to the android NDK."
    exit
fi

if [ -z "$NDK_STANDALONE" ]
then
    echo "FAILED:"
    echo "  You must specify the NDK_STANDALONE to point to your standalone environment. Someday this script will make it for you, but not today."
    echo "  for instance:"
    echo "    export SYSROOT=NDK/platforms/android-14/arch-arm"
    echo "    NDK/build/tools/make-standalone-toolchain-sh --platform=android-14 --install-dir=install/dir"
    echo "    export NDK_STANDALONE=install/dir"
    exit
fi

if [ -z "$1" ]
then
    echo "--> No local mono directory supplied. Defaulting to the official Mono github repository. You can provide a local mono checkout using: $0 \<path-to-mono-git-repository\>"
    MONO_GIT=https://github.com/mono/mono.git
else
    MONO_GIT=$1/.git
fi

echo "--> Using Mono git repository from: $MONO_GIT"
MONO_GIT_CHECKOUT=master
echo "--> Using Mono branch $MONO_GIT_CHECKOUT"

ROOT_DIR=$(basename $0)
pushd $(dirname $0)

echo
echo "--> Checking out Mono"

if [ -d mono ]
then
    echo "--> using existing mono checkout"
    pushd mono
    # MONO_SKIP_PATCH=true
    git fetch origin
    git checkout $MONO_GIT_CHECKOUT
    checkresult 'FAILED: Could not update ./mono from git'
    popd

else
    echo "--> Cloning Mono for the first time into /mono"
    git clone $MONO_GIT mono
    pushd mono
    git checkout $MONO_GIT_CHECKOUT
    checkresult 'FAILED: Could not clone mono into ./mono'
    popd
fi

# Disabling patching for now. May add it back if needed, but probably better to use a github fork instead?.

#if [ ! -f MonoActivity/jni/mono.patch ]
#then
#    echo "=====NO LOCAL MONO PATCH FOUND====="
#    MONO_SKIP_PATCH=true
#fi

#if [ -z $MONO_SKIP_PATCH ]
#then
#    pushd mono
#    echo
#    echo "=====APPLYING ANDROID PATCHES FOR ARM BUILD====="
#    git apply ../mono.patch
#    popd
#fi

if [ -d mono_builds/assemblies ]
then
    echo "--> Skipping MonoDroid assembly building. To rebuild, delete the ./mono_builds/assemblies directory."
else
    echo "--> Compiling Mono class libraries for MCS build"
    mkdir -p mono_builds/assemblies
    pushd mono_builds/assemblies
    INSTALL_PREFIX=$(pwd)
    echo INSTALL_PREFIX=$INSTALL_PREFIX
    popd

    pushd mono
    echo "--> Running ./mono/configure to build MonoDroid assemblies"
    ./autogen.sh --with-glib=embedded --prefix=$INSTALL_PREFIX --with-monodroid=yes
    make clean && make && make install
    checkresult "FAILED: MonoDroid assemblies did not build successfully"
    popd
    echo "--> copying mono/mcs/class/lib/monodroid -> mono_builds/assemblies/lib/mono because for some reason make install doesn't"
    cp -r mono/mcs/class/lib/monodroid mono_builds/assemblies/lib/mono
fi


# you can set $BUILD manually prior to running the script, if you like
if [ -z "$BUILD" ]
then
pushd mono
BUILD=`./config.guess`
popd
# not sure why the above fails on my machine sometimes
if [ -z "$BUILD" ]
then
echo "--> Couldn't run ./mono/config.guess for some reason. using default BUILD=i686-pc-linux-gnu"
sleep 6
BUILD=i686-pc-linux-gnu
fi
fi

echo "--> Using BUILD=$BUILD"


export SYSROOT=$NDK/platforms/android-14/arch-arm
export PATH=$NDK_STANDALONE/bin:$PATH
export CC=arm-linux-androideabi-gcc
export CXX=arm-linux-androideabi-g++
export AR=arm-linux-androideabi-ar
export AS=arm-linux-androideabi-as
export CPP=arm-linux-androideabi-cpp
export LD=arm-linux-androideabi-ld
export RANLIB=arm-linux-androideabi-ranlib
export STRIP=arm-linux-androideabi-strip

if [ -d mono_builds/armeabi ]
then
    echo "--> Skipping armeabi runtime building. To rebuild, delete the ./mono_builds/armeabi directory."
else
    mkdir -p mono_builds/armeabi
    pushd mono_builds/armeabi
    INSTALL_PREFIX=$(pwd)
    echo INSTALL_PREFIX=$INSTALL_PREFIX
    popd
    
    pushd mono
    echo "--> Running configure for armv7-a-linux-androideabi"
    ./autogen.sh --build=$BUILD --host=arm-linux-androideabi --target=arm-linux-androideabi --enable-nls=no --with-mcs-docs=no --with-mcs-build=no --prefix=$INSTALL_PREFIX
    make clean && make && make install
    checkresult "FAILED: building armeabi was not successful"
    popd
fi

if [ -d mono_builds/armeabi-v7a ]
then
    echo "--> Skipping armeabi-v7a runtime building. To rebuild, delete the ./mono_builds/armeabi-v7a directory."
else
    mkdir -p mono_builds/armeabi-v7a
    pushd mono_builds/armeabi-v7a
    INSTALL_PREFIX=$(pwd)
    echo INSTALL_PREFIX=$INSTALL_PREFIX
    popd
    
    pushd mono
    echo "--> Running configure for armeabi-v7a"
    ./autogen.sh --build=$BUILD --host=armv7-a-linux-androideabi --target=armv7-a-linux-androideabi --enable-nls=no --with-mcs-docs=no --with-mcs-build=no --prefix=$INSTALL_PREFIX
    make clean && make && make install
    checkresult "FAILED: building armeabi-v7a was not successful"
    popd
fi



popd

echo "--> Done!"
