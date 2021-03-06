package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class LayoutInflater_FactoryDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.LayoutInflater.Factory
{
	static
	{
		MonoBridge.link(LayoutInflater_FactoryDelegateWrapper.class, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", "java.lang.String,android.content.Context,android.util.AttributeSet");

	}

	public native android.view.View onCreateView(java.lang.String arg0,android.content.Context arg1,android.util.AttributeSet arg2);



}
