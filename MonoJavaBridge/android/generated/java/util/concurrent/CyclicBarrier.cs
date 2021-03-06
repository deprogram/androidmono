namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CyclicBarrier : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CyclicBarrier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "reset", "()V", ref global::java.util.concurrent.CyclicBarrier._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int await()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "await", "()I", ref global::java.util.concurrent.CyclicBarrier._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int await(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)I", ref global::java.util.concurrent.CyclicBarrier._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Parties
		{
			get
			{
				return getParties();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getParties()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "getParties", "()I", ref global::java.util.concurrent.CyclicBarrier._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isBroken()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "isBroken", "()Z", ref global::java.util.concurrent.CyclicBarrier._m4);
		}
		public new int NumberWaiting
		{
			get
			{
				return getNumberWaiting();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getNumberWaiting()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "getNumberWaiting", "()I", ref global::java.util.concurrent.CyclicBarrier._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public CyclicBarrier(int arg0, java.lang.Runnable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CyclicBarrier._m6.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CyclicBarrier._m6 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "<init>", "(ILjava/lang/Runnable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public CyclicBarrier(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CyclicBarrier._m7.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CyclicBarrier._m7 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CyclicBarrier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CyclicBarrier.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CyclicBarrier"));
		}
	}
}
