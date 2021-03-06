namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputMethodSession_EventCallback_))]
	public partial interface InputMethodSession_EventCallback  : global::MonoJavaBridge.IJavaObject 
	{
		void finishedEvent(int arg0, bool arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.inputmethod.InputMethodSession_EventCallback))]
	internal sealed partial class InputMethodSession_EventCallback_ : java.lang.Object, InputMethodSession_EventCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputMethodSession_EventCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.view.inputmethod.InputMethodSession_EventCallback.finishedEvent(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_EventCallback_.staticClass, "finishedEvent", "(IZ)V", ref global::android.view.inputmethod.InputMethodSession_EventCallback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static InputMethodSession_EventCallback_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodSession_EventCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodSession$EventCallback"));
		}
	}

	public delegate void InputMethodSession_EventCallbackDelegate(int arg0, bool arg1);

	internal partial class InputMethodSession_EventCallbackDelegateWrapper : java.lang.Object, InputMethodSession_EventCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputMethodSession_EventCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InputMethodSession_EventCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper.staticClass, global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static InputMethodSession_EventCallbackDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodSession_EventCallbackDelegateWrapper"));
		}
	}
	internal partial class InputMethodSession_EventCallbackDelegateWrapper
	{
		private InputMethodSession_EventCallbackDelegate myDelegate;
		public void finishedEvent(int arg0, bool arg1)
		{
			myDelegate(arg0, arg1);
		}
		public static implicit operator InputMethodSession_EventCallbackDelegateWrapper(InputMethodSession_EventCallbackDelegate d)
		{
			global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper ret = new global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
