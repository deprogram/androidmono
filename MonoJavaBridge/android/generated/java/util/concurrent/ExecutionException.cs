namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExecutionException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExecutionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected ExecutionException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ExecutionException._m0.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ExecutionException._m0 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutionException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutionException.staticClass, global::java.util.concurrent.ExecutionException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected ExecutionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ExecutionException._m1.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ExecutionException._m1 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutionException.staticClass, global::java.util.concurrent.ExecutionException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ExecutionException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ExecutionException._m2.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ExecutionException._m2 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutionException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutionException.staticClass, global::java.util.concurrent.ExecutionException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ExecutionException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ExecutionException._m3.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ExecutionException._m3 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutionException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutionException.staticClass, global::java.util.concurrent.ExecutionException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ExecutionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutionException"));
		}
	}
}
