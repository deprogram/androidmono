namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DeadObjectException : android.os.RemoteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DeadObjectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public DeadObjectException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.DeadObjectException._m0.native == global::System.IntPtr.Zero)
				global::android.os.DeadObjectException._m0 = @__env.GetMethodIDNoThrow(global::android.os.DeadObjectException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DeadObjectException.staticClass, global::android.os.DeadObjectException._m0);
			Init(@__env, handle);
		}
		static DeadObjectException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.DeadObjectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/DeadObjectException"));
		}
	}
}
