namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAMultiPrimePrivateCrtKeySpec : java.security.spec.RSAPrivateKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RSAMultiPrimePrivateCrtKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m0) as java.math.BigInteger;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPrimeP", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m1) as java.math.BigInteger;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m2) as java.math.BigInteger;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m3) as java.math.BigInteger;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m4) as java.math.BigInteger;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m5) as java.math.BigInteger;
		}
		public new global::java.security.spec.RSAOtherPrimeInfo[] OtherPrimeInfo
		{
			get
			{
				return getOtherPrimeInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.spec.RSAOtherPrimeInfo[] getOtherPrimeInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.spec.RSAOtherPrimeInfo>(this, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;", ref global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m6) as java.security.spec.RSAOtherPrimeInfo[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public RSAMultiPrimePrivateCrtKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigInteger arg6, java.math.BigInteger arg7, java.security.spec.RSAOtherPrimeInfo[] arg8) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m7.native == global::System.IntPtr.Zero)
				global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m7 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;[Ljava/security/spec/RSAOtherPrimeInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		static RSAMultiPrimePrivateCrtKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAMultiPrimePrivateCrtKeySpec"));
		}
	}
}
