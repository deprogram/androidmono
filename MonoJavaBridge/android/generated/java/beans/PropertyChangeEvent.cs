namespace java.beans
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PropertyChangeEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PropertyChangeEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String PropertyName
		{
			get
			{
				return getPropertyName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getPropertyName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.beans.PropertyChangeEvent.staticClass, "getPropertyName", "()Ljava/lang/String;", ref global::java.beans.PropertyChangeEvent._m0) as java.lang.String;
		}
		public new global::java.lang.Object NewValue
		{
			get
			{
				return getNewValue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object getNewValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.beans.PropertyChangeEvent.staticClass, "getNewValue", "()Ljava/lang/Object;", ref global::java.beans.PropertyChangeEvent._m1) as java.lang.Object;
		}
		public new global::java.lang.Object OldValue
		{
			get
			{
				return getOldValue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object getOldValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.beans.PropertyChangeEvent.staticClass, "getOldValue", "()Ljava/lang/Object;", ref global::java.beans.PropertyChangeEvent._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setPropagationId(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeEvent.staticClass, "setPropagationId", "(Ljava/lang/Object;)V", ref global::java.beans.PropertyChangeEvent._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Object PropagationId
		{
			get
			{
				return getPropagationId();
			}
			set
			{
				setPropagationId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.Object getPropagationId()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.beans.PropertyChangeEvent.staticClass, "getPropagationId", "()Ljava/lang/Object;", ref global::java.beans.PropertyChangeEvent._m4) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PropertyChangeEvent(java.lang.Object arg0, java.lang.String arg1, java.lang.Object arg2, java.lang.Object arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.beans.PropertyChangeEvent._m5.native == global::System.IntPtr.Zero)
				global::java.beans.PropertyChangeEvent._m5 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeEvent.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.PropertyChangeEvent.staticClass, global::java.beans.PropertyChangeEvent._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static PropertyChangeEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeEvent"));
		}
	}
}
