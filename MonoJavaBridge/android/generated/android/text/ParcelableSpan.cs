namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.ParcelableSpan_))]
	public partial interface ParcelableSpan : android.os.Parcelable
	{
		int getSpanTypeId();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.ParcelableSpan))]
	internal sealed partial class ParcelableSpan_ : java.lang.Object, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParcelableSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int android.text.ParcelableSpan.getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.ParcelableSpan_.staticClass, "getSpanTypeId", "()I", ref global::android.text.ParcelableSpan_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.os.Parcelable.writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.ParcelableSpan_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.ParcelableSpan_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int android.os.Parcelable.describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.ParcelableSpan_.staticClass, "describeContents", "()I", ref global::android.text.ParcelableSpan_._m2);
		}
		static ParcelableSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.ParcelableSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/ParcelableSpan"));
		}
	}
}
