internal static class CFNetwork // TypeDefIndex: 2525
{	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x12108A0 Offset: 0x120EEA0 VA: 0x1812108A0
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x1211160 Offset: 0x120F760 VA: 0x181211160
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x1210940 Offset: 0x120EF40 VA: 0x181210940
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x1210C80 Offset: 0x120F280 VA: 0x181210C80
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x1211210 Offset: 0x120F810 VA: 0x181211210
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x12119F0 Offset: 0x120FFF0 VA: 0x1812119F0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x12118A0 Offset: 0x120FEA0 VA: 0x1812118A0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x1211410 Offset: 0x120FA10 VA: 0x181211410
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x1211060 Offset: 0x120F660 VA: 0x181211060
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x12112E0 Offset: 0x120F8E0 VA: 0x1812112E0
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x1211D70 Offset: 0x1210370 VA: 0x181211D70
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x1212150 Offset: 0x1210750 VA: 0x181212150
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x12110F0 Offset: 0x120F6F0 VA: 0x1812110F0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x1212270 Offset: 0x1210870 VA: 0x181212270
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x1211850 Offset: 0x120FE50 VA: 0x181211850
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x1212380 Offset: 0x1210980 VA: 0x181212380
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

	// RVA: 0x1216D30 Offset: 0x1215330 VA: 0x181216D30 Slot: 4
	public void Dispose() { }

	// RVA: 0x1216D60 Offset: 0x1215360 VA: 0x181216D60
	public void .ctor() { }

}

private sealed class CFNetwork.CFProxyAutoConfigurationResultCallback : MulticastDelegate // TypeDefIndex: 2527
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1212C50 Offset: 0x1211250 VA: 0x181212C50 Slot: 12
	public virtual void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	// RVA: 0x1212BB0 Offset: 0x12111B0 VA: 0x181212BB0 Slot: 13
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

	// RVA: 0x1214C50 Offset: 0x1213250 VA: 0x181214C50
	private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

	// RVA: 0x1214AA0 Offset: 0x12130A0 VA: 0x181214AA0
	private static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1214A20 Offset: 0x1213020 VA: 0x181214A20
	private static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1215600 Offset: 0x1213C00 VA: 0x181215600
	private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1215150 Offset: 0x1213750 VA: 0x181215150 Slot: 4
	public Uri GetProxy(Uri targetUri) { }

	// RVA: 0x1215520 Offset: 0x1213B20 VA: 0x181215520 Slot: 5
	public bool IsBypassed(Uri targetUri) { }

}

private sealed class CFNetwork.<>c__DisplayClass13_0 // TypeDefIndex: 2529
{	// Fields
	public CFProxy[] proxies; // 0x10
	public CFRunLoop runLoop; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121DD50 Offset: 0x121C350 VA: 0x18121DD50
	internal void <ExecuteProxyAutoConfigurationURL>b__0(IntPtr client, IntPtr proxyList, IntPtr error) { }

}

