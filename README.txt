---- Requirements ----

The Android NDK:
http://developer.android.com/sdk/ndk/index.html

Once you have the NDK downloaded, set environment variable NDK to point to the root of the NDK.

You must also create a standalone ndk environment. See $NDK/docs/STANDALONE-TOOLCHAIN.html for
details on how to create one with the android NDK. This project requires the --platform=android-14
option for the make-standalone-toolchain.sh script in the NDK.

Once you've created a standalone toolchain, set environment variable NDK_STANDALONE to point to
the root of the standalone toolchain you created.

---- Building Mono ----

This project is a work in progress. Currently the work has been in the get-mono.sh build script,
which downloads mono from git, builds the monodroid assemblies, and two sets of ARM runtime binaries.
You must first set the NDK and NDK_STANDALONE environment variables before calling ./get-mono.sh (see above).
These binaries have not yet been tested in an actual running application (as I said, work in progress).

./get-mono.sh

This will build the monodroid assemblies into ./mono_builds/assemblies/lib/monodroid, and the ARM runtime
binaries into ./mono_builds/armeabi-v7a and ./mono_builds/armeabi.

I am currently using my own fork of the mono repository at https://github.com/jeromiya/mono which
contains a small patch to ./mono/mono/mini/main.c, and ./mono/mono/mini/Makefile.am.in which fixes
a minor build issue. This is temporary until this build issue is resolved in the official repository.
