namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DrawFilter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DrawFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.DrawFilter.staticClass, "finalize", "()V", ref global::android.graphics.DrawFilter._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DrawFilter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.DrawFilter._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.DrawFilter._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.DrawFilter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.DrawFilter.staticClass, global::android.graphics.DrawFilter._m1);
			Init(@__env, handle);
		}
		static DrawFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.DrawFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/DrawFilter"));
		}
	}
}
