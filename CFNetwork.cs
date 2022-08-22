internal static class CFNetwork // TypeDefIndex: 2525
{	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x1210B60 Offset: 0x120F160 VA: 0x181210B60
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x1211420 Offset: 0x120FA20 VA: 0x181211420
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x1210C00 Offset: 0x120F200 VA: 0x181210C00
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x1210F40 Offset: 0x120F540 VA: 0x181210F40
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x12114D0 Offset: 0x120FAD0 VA: 0x1812114D0
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x1211CB0 Offset: 0x12102B0 VA: 0x181211CB0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x1211B60 Offset: 0x1210160 VA: 0x181211B60
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x12116D0 Offset: 0x120FCD0 VA: 0x1812116D0
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x1211320 Offset: 0x120F920 VA: 0x181211320
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x12115A0 Offset: 0x120FBA0 VA: 0x1812115A0
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x1212030 Offset: 0x1210630 VA: 0x181212030
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x1212410 Offset: 0x1210A10 VA: 0x181212410
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x12113B0 Offset: 0x120F9B0 VA: 0x1812113B0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x1212530 Offset: 0x1210B30 VA: 0x181212530
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x1211B10 Offset: 0x1210110 VA: 0x181211B10
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x1212640 Offset: 0x1210C40 VA: 0x181212640
	private static void .cctor() { }

}

private class CFNetwork.GetProxyData : IDisposable // TypeDefIndex: 2526
{	// Fields
	public IntPtr script; // 0x10
	public IntPtr targetUri; // 0x18
	public IntPtr error; // 0x20
	public IntPtr result; // 0x28
	public ManualResetEvent evt; // 0x30

	// Methods

	// RVA: 0x1216FF0 Offset: 0x12155F0 VA: 0x181216FF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1217020 Offset: 0x1215620 VA: 0x181217020
	public void .ctor() { }

}

private sealed class CFNetwork.CFProxyAutoConfigurationResultCallback : MulticastDelegate // TypeDefIndex: 2527
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1212F10 Offset: 0x1211510 VA: 0x181212F10 Slot: 12
	public virtual void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	// RVA: 0x1212E70 Offset: 0x1211470 VA: 0x181212E70 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr client, IntPtr proxyList, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private class CFNetwork.CFWebProxy : IWebProxy // TypeDefIndex: 2528
{	// Fields
	private ICredentials credentials; // 0x10
	private bool userSpecified; // 0x18

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x1214F10 Offset: 0x1213510 VA: 0x181214F10
	private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

	// RVA: 0x1214D60 Offset: 0x1213360 VA: 0x181214D60
	private static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1214CE0 Offset: 0x12132E0 VA: 0x181214CE0
	private static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x12158C0 Offset: 0x1213EC0 VA: 0x1812158C0
	private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1215410 Offset: 0x1213A10 VA: 0x181215410 Slot: 4
	public Uri GetProxy(Uri targetUri) { }

	// RVA: 0x12157E0 Offset: 0x1213DE0 VA: 0x1812157E0 Slot: 5
	public bool IsBypassed(Uri targetUri) { }

}

private sealed class CFNetwork.<>c__DisplayClass13_0 // TypeDefIndex: 2529
{	// Fields
	public CFProxy[] proxies; // 0x10
	public CFRunLoop runLoop; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121E010 Offset: 0x121C610 VA: 0x18121E010
	internal void <ExecuteProxyAutoConfigurationURL>b__0(IntPtr client, IntPtr proxyList, IntPtr error) { }

}

