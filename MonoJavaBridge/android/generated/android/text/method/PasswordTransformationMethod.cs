namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PasswordTransformationMethod : java.lang.Object, TransformationMethod, TextWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PasswordTransformationMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.PasswordTransformationMethod Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.PasswordTransformationMethod getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.PasswordTransformationMethod._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.PasswordTransformationMethod._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/PasswordTransformationMethod;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._m0)) as android.text.method.PasswordTransformationMethod;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.PasswordTransformationMethod.staticClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", ref global::android.text.method.PasswordTransformationMethod._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public void onFocusChanged(android.view.View arg0, string arg1, bool arg2, int arg3, android.graphics.Rect arg4)
		{
			onFocusChanged(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.PasswordTransformationMethod.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.text.method.PasswordTransformationMethod._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.PasswordTransformationMethod.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.text.method.PasswordTransformationMethod._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void afterTextChanged(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.PasswordTransformationMethod.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V", ref global::android.text.method.PasswordTransformationMethod._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.method.PasswordTransformationMethod.staticClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", ref global::android.text.method.PasswordTransformationMethod._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getTransformation(string arg0, android.view.View arg1)
		{
			return getTransformation((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PasswordTransformationMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.PasswordTransformationMethod._m6.native == global::System.IntPtr.Zero)
				global::android.text.method.PasswordTransformationMethod._m6 = @__env.GetMethodIDNoThrow(global::android.text.method.PasswordTransformationMethod.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._m6);
			Init(@__env, handle);
		}
		static PasswordTransformationMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.PasswordTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/PasswordTransformationMethod"));
		}
	}
}
