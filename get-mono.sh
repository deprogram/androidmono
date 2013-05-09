function checkresult
{
    RESULT=`echo $?`
    if [ "$RESULT" != 0 ]; then
        echo $1
        exit $RESULT
    fi
}

if [ -z "$1" ]
then
    echo "No local mono directory supplied. Cloning mono from Github. This may take a while..."
    echo "You can provide a local mono checkout using: $0 \<path-to-mono-git-repository\>"
    MONO_GIT=git://github.com/mono/mono.git
else
    MONO_GIT=$1/.git
fi

echo "=====CHECKING OUT MONO FROM $MONO_GIT====="
MONO_GIT_CHECKOUT=mono-2-10-8
echo $MONO_GIT_CHECKOUT

ROOT_DIR=$(basename $0)
pushd $(dirname $0)

echo
echo "=====CHECKING OUT MONO====="
if [ -d MonoActivity/jni/mono ]
then
    echo "=====UPDATING EXISTING MONO CHECKOUT====="
    echo "=====If you get errors, you may want to delete mono and hostbuild to force a clean build====="
    pushd MonoActivity/jni/mono
    MONO_SKIP_PATCH=true
    git fetch origin
    git checkout $MONO_GIT_CHECKOUT
    popd
    checkresult 'Error while updating ./mono'
    pushd hostbuild/mono
    git fetch origin
    git checkout $MONO_GIT_CHECKOUT
    popd
    checkresult 'Error while updating ./hostbuild/mono'
else
    pushd MonoActivity/jni
    git clone $MONO_GIT mono
    pushd mono
    git checkout $MONO_GIT_CHECKOUT
    popd
    popd
    
    rm -rf hostbuild
    mkdir -p hostbuild
    pushd hostbuild
    git clone $MONO_GIT mono
    pushd mono
    git checkout $MONO_GIT_CHECKOUT
    popd
    popd
fi

echo
echo "=====COMPILING MONO CLASS LIBRARIES FOR MCS BUILD====="
sleep 2

mkdir -p hostbuild/install
pushd hostbuild/install
INSTALL_PREFIX=$(pwd)
echo INSTALL_PREFIX=$INSTALL_PREFIX
popd

pushd hostbuild/mono
UNAME=$(uname -a | grep Darwin | grep x86_64)
if [ ! -z "$UNAME" ]
then
    echo "Using gcc-4.0 on Darwin x86_64!"
    export CC=gcc-4.0
fi
echo "Running configure for mcs monodroid class library build..."

./autogen.sh --with-glib=embedded --with-moonlight=no --prefix=$INSTALL_PREFIX --with-monodroid=yes
make && make install
popd

if [ ! -f MonoActivity/jni/mono.patch ]
then
    echo "=====NO LOCAL MONO PATCH FOUND====="
    MONO_SKIP_PATCH=true
fi

if [ -z $MONO_SKIP_PATCH ]
then
    pushd MonoActivity/jni/mono
    echo
    echo "=====APPLYING ANDROID PATCHES FOR ARM BUILD====="
    git apply ../mono.patch
    popd
fi

if [ -z "$NDK" ]
then
    echo "You must specify the NDK variable to point to the android NDK."
else
    if [ -z "$NDK_STANDALONE" ]
    then
        echo "You must specify the NDK_STANDALONE to point to your standalone environment. Someday this script will make it for you, but not today."
        echo "for instance:"
        echo "export SYSROOT=NDK/platforms/android-14/arch-arm"
        echo "NDK/build/tools/make-standalone-toolchain-sh --platform=android-14 --install-dir=install/dir"
        echo "export NDK_STANDALONE=install/dir"
    else
        pushd MonoActivity/jni
        mkdir -p mono_arm
        pushd mono_arm
        INSTALL_PREFIX=$(pwd)
        popd
        popd
        
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
    
        pushd MonoActivity/jni/mono
        echo "Running configure..."
        ./autogen.sh --build="i686-pc-linux-gnu" --host=armv7-a-linux-androideabi --target=armv7-a-linux-androideabi --enable-nls=no --with-mcs-docs=no --with-mcs-build=no --with-moonlight=no --with-gc=none CFLAGS="-DARM_FPU_VFP=1" CXXFLAGS="-DARM_FPU_VFP" --prefix=$INSTALL_PREFIX
        make && make install
        popd
        
        echo "=====Done! That's all for now - the MonoDroid assemblies are in hostbuild/install and the android mono ARM binaries are in MonoActivity/jni/mono_arm but this wont actually work for now ====="
    fi
fi
