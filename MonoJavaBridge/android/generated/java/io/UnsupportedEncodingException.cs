namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedEncodingException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsupportedEncodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnsupportedEncodingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.UnsupportedEncodingException._m0.native == global::System.IntPtr.Zero)
				global::java.io.UnsupportedEncodingException._m0 = @__env.GetMethodIDNoThrow(global::java.io.UnsupportedEncodingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UnsupportedEncodingException.staticClass, global::java.io.UnsupportedEncodingException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnsupportedEncodingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.UnsupportedEncodingException._m1.native == global::System.IntPtr.Zero)
				global::java.io.UnsupportedEncodingException._m1 = @__env.GetMethodIDNoThrow(global::java.io.UnsupportedEncodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UnsupportedEncodingException.staticClass, global::java.io.UnsupportedEncodingException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnsupportedEncodingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.UnsupportedEncodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/UnsupportedEncodingException"));
		}
	}
}
