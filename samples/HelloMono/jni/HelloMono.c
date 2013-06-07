/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2012 Koushik Dutta, Jeremy Bell, various contributors
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

#include <string.h>
#include <jni.h>
#include <mono/metadata/metadata.h>
#include <mono/metadata/debug-helpers.h>
#include <mono/metadata/class.h>
#include <mono/metadata/object.h>
#include <mono/utils/mono-error.h>

#define HELLOMONO_DLL "/data/data/com.androidmono.HelloMono/HelloMono.dll"
#define DATA_DIR "/data/data/com.androidmono.HelloMono/"

#ifndef FALSE
#define FALSE 0
#endif

#ifndef NULL
#define NULL 0
#endif

typedef void* pointer;

MonoDomain *g_Domain;
MonoAssembly *g_Assembly;
MonoImage *g_Image;
MonoMethod *g_Link;
MonoMethod *g_LoadAssembly;
MonoMethod *g_ReleaseGCHandle;
JavaVM *g_JavaVM;
MonoAssembly* g_Assembly;
MonoDomain* g_Domain;

jint JNI_OnLoad(JavaVM* vm, void* reserved) {
	g_JavaVM = vm;
	return JNI_VERSION_1_4;
}

//pointer *mono_objectpointer_conversion(pointer p)
//{
//    return p;
//}

//void JavaVMThreadCleanup(MonoProfiler *prof, uintptr_t tid)
//{
//    (*g_JavaVM)->DetachCurrentThread(g_JavaVM);
//}

/* This is a trivial JNI example where we use a native method
 * to return a new VM String. See the corresponding Java source
 * file located at:
 *
 *   apps/samples/hello-jni/project/src/com/example/hellojni/HelloJni.java
 */
jstring Java_com_androidmono_HelloMono_MainActivity_stringFromJNI(JNIEnv* env,
		jobject thiz) {

	//#ifdef PLATFORM_ANDROID
	//    if (debuggerAgentOptions != NULL)
	//    {
	//        LOGI("Debugger enabled...");
	//        int length = (*env)->GetStringLength(end, debuggerAgentOptions);
	//        const jbyte *str = (*env)->GetStringUTFChars(env, debuggerAgentOptions, NULL);
	//        char *copy = (char*)malloc(length + 1);
	//        copy[length] = NULL;
	//        memcpy(copy, str, length);
	//        mono_debugger_agent_parse_options(copy);
	//        free(copy);
	//        (*env)->ReleaseStringUTFChars(env, debuggerAgentOptions, str);
	//        mono_debug_init (MONO_DEBUG_FORMAT_MONO);
	//    }
	//#endif

	//setenv("MONO_PATH", DATA_DIR, 0);

	//#ifdef PLATFORM_ANDROID
	//    LOGI("mono_jit_init...");
	//#endif

	mono_set_dirs("/data/data/com.androidmono.HelloMono", 0);

	//mono_config_parse((void*)NULL);

	g_Domain = mono_jit_init(HELLOMONO_DLL);

	//#ifdef PLATFORM_ANDROID
	//    LOGI("mono_domain_assembly_open...", NULL);
	//#endif
	g_Assembly = mono_domain_assembly_open(g_Domain, HELLOMONO_DLL);
	if (!g_Assembly) {
		printf("Unable to load %s", HELLOMONO_DLL);
		return FALSE;
	}

	//mono_add_internal_call("MonoJavaBridge.JavaBridge::mono_object_to_pointer(object)", mono_objectpointer_conversion);
	//mono_add_internal_call("MonoJavaBridge.JavaBridge::mono_pointer_to_object(intptr)", mono_objectpointer_conversion);
	//mono_add_internal_call("MonoJavaBridge.JavaBridge::log(intptr)", logcat_print);

	//mono_profiler_install(NULL, NULL);
	//mono_profiler_set_events(MONO_PROFILE_THREADS);
	//mono_profiler_install_thread(NULL, JavaVMThreadCleanup);

	MonoImage *image = mono_assembly_get_image(g_Assembly);
	MonoMethodDesc* desc = mono_method_desc_new("HelloMono.HelloMono:Hello()",
			1);
	MonoMethod* method = mono_method_desc_search_in_image(desc, image);
	mono_method_desc_free(desc);
	pointer args[1];
	args[0] = &g_JavaVM;
	MonoString* result = (MonoString*) mono_runtime_invoke(method, NULL, args,
			NULL);

	//desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:Link(intptr,intptr,intptr,intptr)", 1);
	//g_Link = mono_method_desc_search_in_image (desc, image);
	//mono_method_desc_free(desc);

	//desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:LoadAssembly(intptr)", 1);
	//g_LoadAssembly = mono_method_desc_search_in_image (desc, image);
	//mono_method_desc_free(desc);

	//desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:ReleaseGCHandle(long)", 1);
	//g_ReleaseGCHandle = mono_method_desc_search_in_image (desc, image);
	//mono_method_desc_free(desc);

	//return (*env)->NewStringUTF(env, "Hello from JNI !");
	MonoError* error = NULL;
	char* resultAsRawString = mono_string_to_utf8(result);
	if (error != NULL) {
		return (*env)->NewStringUTF(env, "Mono ERROR'D");
	} else {
		return (*env)->NewStringUTF(env, resultAsRawString);
	}
}
