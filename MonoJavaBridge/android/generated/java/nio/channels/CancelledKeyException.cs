namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CancelledKeyException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CancelledKeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CancelledKeyException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.CancelledKeyException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.channels.CancelledKeyException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.channels.CancelledKeyException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.CancelledKeyException.staticClass, global::java.nio.channels.CancelledKeyException._m0);
			Init(@__env, handle);
		}
		static CancelledKeyException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.CancelledKeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/CancelledKeyException"));
		}
	}
}
