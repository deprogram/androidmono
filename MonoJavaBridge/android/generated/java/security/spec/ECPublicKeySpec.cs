namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECPublicKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ECPublicKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.security.spec.ECParameterSpec Params
		{
			get
			{
				return getParams();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.security.spec.ECParameterSpec getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECPublicKeySpec.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;", ref global::java.security.spec.ECPublicKeySpec._m0) as java.security.spec.ECParameterSpec;
		}
		public new global::java.security.spec.ECPoint W
		{
			get
			{
				return getW();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.security.spec.ECPoint getW()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECPublicKeySpec.staticClass, "getW", "()Ljava/security/spec/ECPoint;", ref global::java.security.spec.ECPublicKeySpec._m1) as java.security.spec.ECPoint;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ECPublicKeySpec(java.security.spec.ECPoint arg0, java.security.spec.ECParameterSpec arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECPublicKeySpec._m2.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECPublicKeySpec._m2 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPublicKeySpec.staticClass, "<init>", "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECPublicKeySpec.staticClass, global::java.security.spec.ECPublicKeySpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ECPublicKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECPublicKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECPublicKeySpec"));
		}
	}
}
