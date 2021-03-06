namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ErrorManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ErrorManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void error(java.lang.String arg0, java.lang.Exception arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.ErrorManager.staticClass, "error", "(Ljava/lang/String;Ljava/lang/Exception;I)V", ref global::java.util.logging.ErrorManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ErrorManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.ErrorManager._m1.native == global::System.IntPtr.Zero)
				global::java.util.logging.ErrorManager._m1 = @__env.GetMethodIDNoThrow(global::java.util.logging.ErrorManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.ErrorManager.staticClass, global::java.util.logging.ErrorManager._m1);
			Init(@__env, handle);
		}
		public static int GENERIC_FAILURE
		{
			get
			{
				return 0;
			}
		}
		public static int WRITE_FAILURE
		{
			get
			{
				return 1;
			}
		}
		public static int FLUSH_FAILURE
		{
			get
			{
				return 2;
			}
		}
		public static int CLOSE_FAILURE
		{
			get
			{
				return 3;
			}
		}
		public static int OPEN_FAILURE
		{
			get
			{
				return 4;
			}
		}
		public static int FORMAT_FAILURE
		{
			get
			{
				return 5;
			}
		}
		static ErrorManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.ErrorManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/ErrorManager"));
		}
	}
}
