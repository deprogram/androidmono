namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAPrivateCrtKeySpec : java.security.spec.RSAPrivateKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RSAPrivateCrtKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger PublicExponent
		{
			get
			{
				return getPublicExponent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.math.BigInteger getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAPrivateCrtKeySpec._m0) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeP
		{
			get
			{
				return getPrimeP();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.math.BigInteger getPrimeP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPrimeP", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAPrivateCrtKeySpec._m1) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeQ
		{
			get
			{
				return getPrimeQ();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.math.BigInteger getPrimeQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAPrivateCrtKeySpec._m2) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeExponentP
		{
			get
			{
				return getPrimeExponentP();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.math.BigInteger getPrimeExponentP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAPrivateCrtKeySpec._m3) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeExponentQ
		{
			get
			{
				return getPrimeExponentQ();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.math.BigInteger getPrimeExponentQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAPrivateCrtKeySpec._m4) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger CrtCoefficient
		{
			get
			{
				return getCrtCoefficient();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.math.BigInteger getCrtCoefficient()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAPrivateCrtKeySpec._m5) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public RSAPrivateCrtKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigInteger arg6, java.math.BigInteger arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.RSAPrivateCrtKeySpec._m6.native == global::System.IntPtr.Zero)
				global::java.security.spec.RSAPrivateCrtKeySpec._m6 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAPrivateCrtKeySpec.staticClass, global::java.security.spec.RSAPrivateCrtKeySpec._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		static RSAPrivateCrtKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAPrivateCrtKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAPrivateCrtKeySpec"));
		}
	}
}
