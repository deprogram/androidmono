namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.prefs.PreferencesFactory_))]
	public partial interface PreferencesFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.prefs.Preferences userRoot();
		global::java.util.prefs.Preferences systemRoot();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.PreferencesFactory))]
	internal sealed partial class PreferencesFactory_ : java.lang.Object, PreferencesFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PreferencesFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.prefs.Preferences java.util.prefs.PreferencesFactory.userRoot()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.PreferencesFactory_.staticClass, "userRoot", "()Ljava/util/prefs/Preferences;", ref global::java.util.prefs.PreferencesFactory_._m0) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.util.prefs.Preferences java.util.prefs.PreferencesFactory.systemRoot()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.PreferencesFactory_.staticClass, "systemRoot", "()Ljava/util/prefs/Preferences;", ref global::java.util.prefs.PreferencesFactory_._m1) as java.util.prefs.Preferences;
		}
		static PreferencesFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.PreferencesFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/PreferencesFactory"));
		}
	}
}
