BASE_PATH := $(call my-dir)

include $(BUILD_EXECUTABLE)

# Disable all warnings
# NOTE/WARNING: At one point, this needed to be -O0 or floating point errors ensued
MONO_CFLAGS := -O3 -w
# Eglib stuff
MONO_CFLAGS += -DHAVE_PWD_H -DHAVE_UNISTD_H
# Libgc stuff
MONO_CFLAGS +=	-DGC_LINUX_THREADS=1 -D_REENTRANT=1 -DSTDC_HEADERS=1 -DHAVE_SYS_TYPES_H=1 -DHAVE_SYS_STAT_H=1 -DHAVE_STDLIB_H=1 -DHAVE_STRING_H=1 -DHAVE_MEMORY_H=1 -DHAVE_STRINGS_H=1 -DHAVE_INTTYPES_H=1 -DHAVE_STDINT_H=1 -DHAVE_UNISTD_H=1 -DHAVE_DLFCN_H=1 -DSILENT=1 -DNO_SIGNALS=1 -DNO_EXECUTE_PERMISSION=1 -DJAVA_FINALIZATION=1 -DGC_GCJ_SUPPORT=1 -DATOMIC_UNCOLLECTABLE=1 -D_IN_LIBGC=1  -DGC_LINUX_THREADS -D_GNU_SOURCE -D_REENTRANT -DUSE_MMAP -DUSE_MUNMAP -D_FILE_OFFSET_BITS=64 -DNO_UNALIGNED_ACCESS
# Mono specific defines
MONO_CFLAGS += -DGC_GCJ_SUPPORT=1 -DHAVE_CONFIG_H -DARM_FPU_VFP -DPLATFORM_ANDROID -DMONO_ASSEMBLIES=\"/data/data/com.koushikdutta.mono/assets/lib/\" -DMONO_BINDIR=\"/data/data/com.koushikdutta.mono/assets/bin/\" -DMONO_CFG_DIR=\"/data/data/com.koushikdutta.mono/assets/bin/\"
# libc holes
MONO_CFLAGS += -DS_IWRITE=0200 -D__linux__

MONO_CFLAGS += \
	-I $(BASE_PATH)/mono/ \
	-I $(BASE_PATH)/mono/mono/ \
	-I $(BASE_PATH)/mono/eglib/src/ \
	-I $(BASE_PATH)/mono/mono/mini/ \
	-I $(BASE_PATH)/mono/libgc/include/ \
	-I $(JNI_H_INCLUDE)

include $(CLEAR_VARS)
LOCAL_MODULE := mono
LOCAL_ARM_MODE := arm
LOCAL_PATH := $(BASE_PATH)
LOCAL_SRC_FILES := MonoJavaInterop/MonoJavaInterop.c PlatformPatches/missing.c
LOCAL_PRELINK_MODULE := false
LOCAL_CFLAGS += $(MONO_CFLAGS)
LOCAL_STATIC_LIBRARIES := monoutils eglib monoruntime gc wapi monoruntimearm gcarm wapiarm mini miniarm
LOCAL_LDFLAGS := -Wall -L$(TARGET_OUT) -lwapiarm -lgcarm -lmonoruntimearm -lmonoutils -leglib -lmonoruntime -lgc -lwapi -lmini -lminiarm
LOCAL_LDLIBS := -L$(SYSROOT)/usr/lib -llog -ldl -lm -lc
include $(BUILD_SHARED_LIBRARY)
