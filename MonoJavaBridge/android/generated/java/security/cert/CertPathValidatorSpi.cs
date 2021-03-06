namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertPathValidatorSpi_))]
	public abstract partial class CertPathValidatorSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertPathValidatorSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.security.cert.CertPathValidatorResult engineValidate(java.security.cert.CertPath arg0, java.security.cert.CertPathParameters arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public CertPathValidatorSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidatorSpi._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidatorSpi._m1 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorSpi.staticClass, global::java.security.cert.CertPathValidatorSpi._m1);
			Init(@__env, handle);
		}
		static CertPathValidatorSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathValidatorSpi))]
	internal sealed partial class CertPathValidatorSpi_ : java.security.cert.CertPathValidatorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPathValidatorSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.security.cert.CertPathValidatorResult engineValidate(java.security.cert.CertPath arg0, java.security.cert.CertPathParameters arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.CertPathValidatorResult>(this, global::java.security.cert.CertPathValidatorSpi_.staticClass, "engineValidate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathValidatorResult;", ref global::java.security.cert.CertPathValidatorSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.cert.CertPathValidatorResult;
		}
		static CertPathValidatorSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorSpi"));
		}
	}
}
