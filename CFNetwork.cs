internal static class CFNetwork // TypeDefIndex: 2525
{	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x1211200 Offset: 0x120F800 VA: 0x181211200
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x1211AC0 Offset: 0x12100C0 VA: 0x181211AC0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x12112A0 Offset: 0x120F8A0 VA: 0x1812112A0
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x12115E0 Offset: 0x120FBE0 VA: 0x1812115E0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x1211B70 Offset: 0x1210170 VA: 0x181211B70
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x1212350 Offset: 0x1210950 VA: 0x181212350
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x1212200 Offset: 0x1210800 VA: 0x181212200
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x1211D70 Offset: 0x1210370 VA: 0x181211D70
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x12119C0 Offset: 0x120FFC0 VA: 0x1812119C0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x1211C40 Offset: 0x1210240 VA: 0x181211C40
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x12126D0 Offset: 0x1210CD0 VA: 0x1812126D0
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x1212AB0 Offset: 0x12110B0 VA: 0x181212AB0
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x1211A50 Offset: 0x1210050 VA: 0x181211A50
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x1212BD0 Offset: 0x12111D0 VA: 0x181212BD0
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x12121B0 Offset: 0x12107B0 VA: 0x1812121B0
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x1212CE0 Offset: 0x12112E0 VA: 0x181212CE0
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

	// RVA: 0x1217690 Offset: 0x1215C90 VA: 0x181217690 Slot: 4
	public void Dispose() { }

	// RVA: 0x12176C0 Offset: 0x1215CC0 VA: 0x1812176C0
	public void .ctor() { }

}

private sealed class CFNetwork.CFProxyAutoConfigurationResultCallback : MulticastDelegate // TypeDefIndex: 2527
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12135B0 Offset: 0x1211BB0 VA: 0x1812135B0 Slot: 12
	public virtual void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	// RVA: 0x1213510 Offset: 0x1211B10 VA: 0x181213510 Slot: 13
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

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x12155B0 Offset: 0x1213BB0 VA: 0x1812155B0
	private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

	// RVA: 0x1215400 Offset: 0x1213A00 VA: 0x181215400
	private static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1215380 Offset: 0x1213980 VA: 0x181215380
	private static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1215F60 Offset: 0x1214560 VA: 0x181215F60
	private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1215AB0 Offset: 0x12140B0 VA: 0x181215AB0 Slot: 4
	public Uri GetProxy(Uri targetUri) { }

	// RVA: 0x1215E80 Offset: 0x1214480 VA: 0x181215E80 Slot: 5
	public bool IsBypassed(Uri targetUri) { }

}

private sealed class CFNetwork.<>c__DisplayClass13_0 // TypeDefIndex: 2529
{	// Fields
	public CFProxy[] proxies; // 0x10
	public CFRunLoop runLoop; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121E6B0 Offset: 0x121CCB0 VA: 0x18121E6B0
	internal void <ExecuteProxyAutoConfigurationURL>b__0(IntPtr client, IntPtr proxyList, IntPtr error) { }

}

