namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypeNotPresentException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypeNotPresentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String typeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.TypeNotPresentException.staticClass, "typeName", "()Ljava/lang/String;", ref global::java.lang.TypeNotPresentException._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public TypeNotPresentException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.TypeNotPresentException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.TypeNotPresentException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.TypeNotPresentException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.TypeNotPresentException.staticClass, global::java.lang.TypeNotPresentException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TypeNotPresentException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.TypeNotPresentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/TypeNotPresentException"));
		}
	}
}
