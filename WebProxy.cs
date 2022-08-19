public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 2978
{	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x118D4E0 Offset: 0x118BAE0 VA: 0x18118D4E0
	public void .ctor() { }

	// RVA: 0x118D160 Offset: 0x118B760 VA: 0x18118D160
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x118D540 Offset: 0x118BB40 VA: 0x18118D540
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x118D5C0 Offset: 0x118BBC0 VA: 0x18118D5C0
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x118C2F0 Offset: 0x118A8F0 VA: 0x18118C2F0 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x118CF90 Offset: 0x118B590 VA: 0x18118CF90
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x118CD60 Offset: 0x118B360 VA: 0x18118CD60
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x118CBE0 Offset: 0x118B1E0 VA: 0x18118CBE0
	private bool IsLocal(Uri host) { }

	// RVA: 0x118CAE0 Offset: 0x118B0E0 VA: 0x18118CAE0
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x118C9A0 Offset: 0x118AFA0 VA: 0x18118C9A0 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x118C580 Offset: 0x118AB80 VA: 0x18118C580
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x118D260 Offset: 0x118B860 VA: 0x18118D260
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118CF60 Offset: 0x118B560 VA: 0x18118CF60 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118C000 Offset: 0x118A600 VA: 0x18118C000 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x118BFB0 Offset: 0x118A5B0 VA: 0x18118BFB0
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x118D230 Offset: 0x118B830 VA: 0x18118D230
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x1020A70 Offset: 0x101F070 VA: 0x181020A70
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x118C120 Offset: 0x118A720 VA: 0x18118C120
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x118C4B0 Offset: 0x118AAB0 VA: 0x18118C4B0
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x118BE00 Offset: 0x118A400 VA: 0x18118BE00
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x118CEE0 Offset: 0x118B4E0 VA: 0x18118CEE0
	private static Uri ProxyUri(string proxyName) { }

}

