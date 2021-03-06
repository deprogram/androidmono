namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewManager_))]
	public partial interface ViewManager  : global::MonoJavaBridge.IJavaObject 
	{
		void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		void removeView(android.view.View arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewManager))]
	internal sealed partial class ViewManager_ : java.lang.Object, ViewManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ViewManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.view.ViewManager.addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewManager_.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.ViewManager_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.view.ViewManager.updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewManager_.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.ViewManager_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.view.ViewManager.removeView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewManager_.staticClass, "removeView", "(Landroid/view/View;)V", ref global::android.view.ViewManager_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ViewManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewManager"));
		}
	}
}
