
LOCAL_PATH := $(call my-dir)

# prebuilt libmonosgen-2.0.so
include $(CLEAR_VARS)
LOCAL_MODULE := monosgen-2.0
LOCAL_SRC_FILES := $(MONO_INSTALL)/$(TARGET_ARCH_ABI)/lib/libmonosgen-2.0.so
LOCAL_EXPORT_C_INCLUDES := $(MONO_INSTALL)/$(TARGET_ARCH_ABI)/include/mono-2.0
include $(PREBUILT_SHARED_LIBRARY)

include $(CLEAR_VARS)

LOCAL_MODULE    := hello-mono
LOCAL_SRC_FILES := HelloMono.c
LOCAL_SHARED_LIBRARIES := monosgen-2.0

include $(BUILD_SHARED_LIBRARY)
