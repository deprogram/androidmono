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
    echo "You must specify the NDK variable to point to the android NDK."
    exit
fi

if [ -z "$NDK_STANDALONE" ]
then
    echo "You must specify the NDK_STANDALONE to point to your standalone environment. Someday this script will make it for you, but not today."
    echo "for instance:"
    echo "export SYSROOT=NDK/platforms/android-14/arch-arm"
    echo "NDK/build/tools/make-standalone-toolchain-sh --platform=android-14 --install-dir=install/dir"
    echo "export NDK_STANDALONE=install/dir"
    exit
fi

if [ -z "$1" ]
then
    echo "No local mono directory supplied. Cloning mono from Github. This may take a while..."
    echo "You can provide a local mono checkout using: $0 \<path-to-mono-git-repository\>"
    MONO_GIT=git://github.com/mono/mono.git
    sleep 4
else
    MONO_GIT=$1/.git
fi

echo "=====CHECKING OUT MONO FROM $MONO_GIT====="
MONO_GIT_CHECKOUT=mono-2-10-9
echo using branch $MONO_GIT_CHECKOUT
sleep 4

ROOT_DIR=$(basename $0)
pushd $(dirname $0)

echo
echo "=====CHECKING OUT MONO====="

if [ -d mono ]
then
    echo "=====UPDATING EXISTING MONO CHECKOUT====="
    echo "=====If you get errors, you may want to delete mono and mono_builds to force a clean build====="
    pushd mono
    # MONO_SKIP_PATCH=true
    git fetch origin
    git checkout $MONO_GIT_CHECKOUT
    checkresult 'Error while updating ./mono'
    popd
else
    echo "====CLONING MONO FOR THE FIRST TIME INTO /mono===="
    git clone $MONO_GIT mono
    pushd mono
    git checkout $MONO_GIT_CHECKOUT
    checkresult 'Error while cloning ./mono'
    popd
fi

echo "====CLEANING UP MONO BUILD DIRECTORIES UNDER mono_build===="
rm -rf mono_builds
mkdir -p mono_builds

#echo "=====COMPILING MONO CLASS LIBRARIES FOR MCS BUILD====="
mkdir -p mono_builds/assemblies
pushd mono_builds/assemblies
INSTALL_PREFIX=$(pwd)
echo INSTALL_PREFIX=$INSTALL_PREFIX
popd

pushd mono
echo "===== RUNNING CONFIGURE FOR MONODROID ASSEMBLIES"
./autogen.sh --with-glib=embedded --prefix=$INSTALL_PREFIX --with-monodroid=yes
make clean && make && make install
checkresult "FAILED: MONODROID ASSEMBLIES DID NOT BUILD SUCCESSFULLY"
popd


# you can set $BUILD manually prior to running the script, if you like
if [ -z "$BUILD" ]
then
pushd mono
BUILD=`./config.guess`
popd
# not sure why the above fails on my machine sometimes
if [ -z "$BUILD" ]
then
echo "Couldn't run ./config.guess for some reason. using default BUILD=i686-pc-linux-gnu"
sleep 6
BUILD=i686-pc-linux-gnu
fi
fi

echo "USING BUILD: $BUILD"
sleep 6

# Disabling patching for now. May add it back if needed.

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

mkdir -p mono_builds/armeabi-v7a
pushd mono_builds/armeabi-v7a
INSTALL_PREFIX=$(pwd)
echo INSTALL_PREFIX=$INSTALL_PREFIX
popd

pushd mono
echo "Running configure for armeabi-v7a"
./autogen.sh --build=$BUILD --host=armv7-a-linux-androideabi --target=armv7-a-linux-androideabi --enable-nls=no --with-mcs-docs=no --with-mcs-build=no --with-moonlight=no --with-gc=none CFLAGS="-DARM_FPU_VFP=1" CXXFLAGS="-DARM_FPU_VFP" --prefix=$INSTALL_PREFIX
make clean && make && make install
checkresult "ERROR: building armeabi-v7a was not successful"
popd

mkdir -p mono_builds/armeabi
pushd mono_builds/armeabi
INSTALL_PREFIX=$(pwd)
echo INSTALL_PREFIX=$INSTALL_PREFIX
popd

pushd mono
echo "Running configure for armv7-a-linux-androideabi"
./autogen.sh --build=$BUILD --host=arm-linux-androideabi --target=arm-linux-androideabi --enable-nls=no --with-mcs-docs=no --with-mcs-build=no --with-moonlight=no --with-gc=none CFLAGS="-DARM_FPU_NONE=1" CXXFLAGS="-DARM_FPU_NONE=1" --prefix=$INSTALL_PREFIX
make clean && make && make install
checkresult "ERROR: building armeabi was not successful"
popd

popd

echo "===== Done! ====="
