package md584fa36101ed90b29964df6b105ef0bd5;


public class CustomButton
	extends md58432a647068b097f9637064b8985a5e0.ButtonRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ShareDrive.Droid.CustomRender.CustomButton, ShareDrive.Android", CustomButton.class, __md_methods);
	}


	public CustomButton (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomButton.class)
			mono.android.TypeManager.Activate ("ShareDrive.Droid.CustomRender.CustomButton, ShareDrive.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomButton (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomButton.class)
			mono.android.TypeManager.Activate ("ShareDrive.Droid.CustomRender.CustomButton, ShareDrive.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomButton (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomButton.class)
			mono.android.TypeManager.Activate ("ShareDrive.Droid.CustomRender.CustomButton, ShareDrive.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
