namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.microedition.khronos.egl.EGLSurface_))]
	public abstract partial class EGLSurface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EGLSurface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public EGLSurface() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.egl.EGLSurface._m0.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.egl.EGLSurface._m0 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLSurface.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.microedition.khronos.egl.EGLSurface.staticClass, global::javax.microedition.khronos.egl.EGLSurface._m0);
			Init(@__env, handle);
		}
		static EGLSurface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLSurface.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLSurface"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGLSurface))]
	internal sealed partial class EGLSurface_ : javax.microedition.khronos.egl.EGLSurface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EGLSurface_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static EGLSurface_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLSurface_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLSurface"));
		}
	}
}
