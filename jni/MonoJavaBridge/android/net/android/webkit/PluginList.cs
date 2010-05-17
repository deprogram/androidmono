namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PluginList : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PluginList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.PluginList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.PluginList(@__env); 
			} 
		} 
		protected PluginList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear8641; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginList)) 
				@__env.CallVoidMethod(this, _clear8641); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.PluginList.staticClass, _clear8641); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getList8642; 
		public virtual java.util.List getList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getList8642)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.PluginList.staticClass, _getList8642)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPlugin8643; 
		public virtual void addPlugin(android.webkit.Plugin arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginList)) 
				@__env.CallVoidMethod(this, _addPlugin8643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.PluginList.staticClass, _addPlugin8643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removePlugin8644; 
		public virtual void removePlugin(android.webkit.Plugin arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginList)) 
				@__env.CallVoidMethod(this, _removePlugin8644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.PluginList.staticClass, _removePlugin8644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pluginClicked8645; 
		public virtual void pluginClicked(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginList)) 
				@__env.CallVoidMethod(this, _pluginClicked8645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.PluginList.staticClass, _pluginClicked8645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PluginList8646; 
		public PluginList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.PluginList.staticClass, _PluginList8646, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.PluginList.staticClass = @__class; 
			global::android.webkit.PluginList._clear8641 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "clear", "()V"); 
			global::android.webkit.PluginList._getList8642 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "getList", "()Ljava/util/List;"); 
			global::android.webkit.PluginList._addPlugin8643 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "addPlugin", "(Landroid/webkit/Plugin;)V"); 
			global::android.webkit.PluginList._removePlugin8644 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "removePlugin", "(Landroid/webkit/Plugin;)V"); 
			global::android.webkit.PluginList._pluginClicked8645 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "pluginClicked", "(Landroid/content/Context;I)V"); 
			global::android.webkit.PluginList._PluginList8646 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "<init>", "()V"); 
		} 
	} 
} 