namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PaintFlagsDrawFilter : android.graphics.DrawFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PaintFlagsDrawFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public PaintFlagsDrawFilter(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PaintFlagsDrawFilter._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.PaintFlagsDrawFilter._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.PaintFlagsDrawFilter.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PaintFlagsDrawFilter.staticClass, global::android.graphics.PaintFlagsDrawFilter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PaintFlagsDrawFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PaintFlagsDrawFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PaintFlagsDrawFilter"));
		}
	}
}
