namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateExpiredException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateExpiredException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CertificateExpiredException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateExpiredException._m0.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateExpiredException._m0 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateExpiredException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateExpiredException.staticClass, global::java.security.cert.CertificateExpiredException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public CertificateExpiredException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateExpiredException._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateExpiredException._m1 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateExpiredException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateExpiredException.staticClass, global::java.security.cert.CertificateExpiredException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateExpiredException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateExpiredException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateExpiredException"));
		}
	}
}
