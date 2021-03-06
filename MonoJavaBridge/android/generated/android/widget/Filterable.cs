namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Filterable_))]
	public partial interface Filterable  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.widget.Filter getFilter();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filterable))]
	internal sealed partial class Filterable_ : java.lang.Object, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Filterable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.widget.Filter android.widget.Filterable.getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Filterable_.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.Filterable_._m0) as android.widget.Filter;
		}
		static Filterable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filterable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filterable"));
		}
	}

	public delegate android.widget.Filter FilterableDelegate();

	internal partial class FilterableDelegateWrapper : java.lang.Object, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterableDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public FilterableDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.FilterableDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.widget.FilterableDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.FilterableDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FilterableDelegateWrapper.staticClass, global::android.widget.FilterableDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static FilterableDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FilterableDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FilterableDelegateWrapper"));
		}
	}
	internal partial class FilterableDelegateWrapper
	{
		private FilterableDelegate myDelegate;
		public android.widget.Filter getFilter()
		{
			return myDelegate();
		}
		public static implicit operator FilterableDelegateWrapper(FilterableDelegate d)
		{
			global::android.widget.FilterableDelegateWrapper ret = new global::android.widget.FilterableDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
