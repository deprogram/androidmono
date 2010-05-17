namespace android.graphics.drawable.shapes 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ArcShape : android.graphics.drawable.shapes.RectShape
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ArcShape() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.shapes.ArcShape), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.shapes.ArcShape(@__env); 
			} 
		} 
		protected ArcShape(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3615; 
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.ArcShape)) 
				@__env.CallVoidMethod(this, _draw3615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.ArcShape.staticClass, _draw3615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArcShape3616; 
		public ArcShape(float arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.shapes.ArcShape.staticClass, _ArcShape3616, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.shapes.ArcShape.staticClass = @__class; 
			global::android.graphics.drawable.shapes.ArcShape._draw3615 = @__env.GetMethodID(global::android.graphics.drawable.shapes.ArcShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"); 
			global::android.graphics.drawable.shapes.ArcShape._ArcShape3616 = @__env.GetMethodID(global::android.graphics.drawable.shapes.ArcShape.staticClass, "<init>", "(FF)V"); 
		} 
	} 
} 