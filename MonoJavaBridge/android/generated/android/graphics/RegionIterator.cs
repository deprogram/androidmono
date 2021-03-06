namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RegionIterator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RegionIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RegionIterator.staticClass, "finalize", "()V", ref global::android.graphics.RegionIterator._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool next(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RegionIterator.staticClass, "next", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.RegionIterator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public RegionIterator(android.graphics.Region arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.RegionIterator._m2.native == global::System.IntPtr.Zero)
				global::android.graphics.RegionIterator._m2 = @__env.GetMethodIDNoThrow(global::android.graphics.RegionIterator.staticClass, "<init>", "(Landroid/graphics/Region;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RegionIterator.staticClass, global::android.graphics.RegionIterator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RegionIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.RegionIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/RegionIterator"));
		}
	}
}
