namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.SpanWatcher_))]
	public partial interface SpanWatcher : NoCopySpan
	{
		void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3);
		void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3);
		void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.SpanWatcher))]
	internal sealed partial class SpanWatcher_ : java.lang.Object, SpanWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SpanWatcher_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.text.SpanWatcher.onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpanWatcher_.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", ref global::android.text.SpanWatcher_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.text.SpanWatcher.onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpanWatcher_.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", ref global::android.text.SpanWatcher_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.text.SpanWatcher.onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpanWatcher_.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V", ref global::android.text.SpanWatcher_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		static SpanWatcher_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpanWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpanWatcher"));
		}
	}
}
