namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConcurrentModificationException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConcurrentModificationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ConcurrentModificationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ConcurrentModificationException._m0.native == global::System.IntPtr.Zero)
				global::java.util.ConcurrentModificationException._m0 = @__env.GetMethodIDNoThrow(global::java.util.ConcurrentModificationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ConcurrentModificationException.staticClass, global::java.util.ConcurrentModificationException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ConcurrentModificationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ConcurrentModificationException._m1.native == global::System.IntPtr.Zero)
				global::java.util.ConcurrentModificationException._m1 = @__env.GetMethodIDNoThrow(global::java.util.ConcurrentModificationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ConcurrentModificationException.staticClass, global::java.util.ConcurrentModificationException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConcurrentModificationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ConcurrentModificationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ConcurrentModificationException"));
		}
	}
}
