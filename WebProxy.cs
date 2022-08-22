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

	// RVA: 0x118D7A0 Offset: 0x118BDA0 VA: 0x18118D7A0
	public void .ctor() { }

	// RVA: 0x118D420 Offset: 0x118BA20 VA: 0x18118D420
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x118D800 Offset: 0x118BE00 VA: 0x18118D800
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x118D880 Offset: 0x118BE80 VA: 0x18118D880
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x118C5B0 Offset: 0x118ABB0 VA: 0x18118C5B0 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x118D250 Offset: 0x118B850 VA: 0x18118D250
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x118D020 Offset: 0x118B620 VA: 0x18118D020
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x118CEA0 Offset: 0x118B4A0 VA: 0x18118CEA0
	private bool IsLocal(Uri host) { }

	// RVA: 0x118CDA0 Offset: 0x118B3A0 VA: 0x18118CDA0
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x118CC60 Offset: 0x118B260 VA: 0x18118CC60 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x118C840 Offset: 0x118AE40 VA: 0x18118C840
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x118D520 Offset: 0x118BB20 VA: 0x18118D520
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118D220 Offset: 0x118B820 VA: 0x18118D220 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118C2C0 Offset: 0x118A8C0 VA: 0x18118C2C0 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x118C270 Offset: 0x118A870 VA: 0x18118C270
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x118D4F0 Offset: 0x118BAF0 VA: 0x18118D4F0
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x1020D30 Offset: 0x101F330 VA: 0x181020D30
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x118C3E0 Offset: 0x118A9E0 VA: 0x18118C3E0
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x118C770 Offset: 0x118AD70 VA: 0x18118C770
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x118C0C0 Offset: 0x118A6C0 VA: 0x18118C0C0
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x118D1A0 Offset: 0x118B7A0 VA: 0x18118D1A0
	private static Uri ProxyUri(string proxyName) { }

}

