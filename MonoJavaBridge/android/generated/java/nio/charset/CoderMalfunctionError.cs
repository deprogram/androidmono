namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CoderMalfunctionError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CoderMalfunctionError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CoderMalfunctionError(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderMalfunctionError._m0.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderMalfunctionError._m0 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderMalfunctionError.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CoderMalfunctionError.staticClass, global::java.nio.charset.CoderMalfunctionError._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CoderMalfunctionError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CoderMalfunctionError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CoderMalfunctionError"));
		}
	}
}
