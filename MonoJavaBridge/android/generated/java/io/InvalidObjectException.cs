namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidObjectException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidObjectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InvalidObjectException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InvalidObjectException._m0.native == global::System.IntPtr.Zero)
				global::java.io.InvalidObjectException._m0 = @__env.GetMethodIDNoThrow(global::java.io.InvalidObjectException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InvalidObjectException.staticClass, global::java.io.InvalidObjectException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidObjectException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InvalidObjectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InvalidObjectException"));
		}
	}
}
