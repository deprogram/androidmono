namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamCorruptedException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StreamCorruptedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public StreamCorruptedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamCorruptedException._m0.native == global::System.IntPtr.Zero)
				global::java.io.StreamCorruptedException._m0 = @__env.GetMethodIDNoThrow(global::java.io.StreamCorruptedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamCorruptedException.staticClass, global::java.io.StreamCorruptedException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public StreamCorruptedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamCorruptedException._m1.native == global::System.IntPtr.Zero)
				global::java.io.StreamCorruptedException._m1 = @__env.GetMethodIDNoThrow(global::java.io.StreamCorruptedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamCorruptedException.staticClass, global::java.io.StreamCorruptedException._m1);
			Init(@__env, handle);
		}
		static StreamCorruptedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StreamCorruptedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StreamCorruptedException"));
		}
	}
}
