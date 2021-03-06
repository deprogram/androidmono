namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitmapShader : android.graphics.Shader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BitmapShader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public BitmapShader(android.graphics.Bitmap arg0, android.graphics.Shader.TileMode arg1, android.graphics.Shader.TileMode arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapShader._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapShader._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapShader.staticClass, "<init>", "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapShader.staticClass, global::android.graphics.BitmapShader._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BitmapShader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BitmapShader.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapShader"));
		}
	}
}
