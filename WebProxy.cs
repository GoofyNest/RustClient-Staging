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

	// RVA: 0x11920C0 Offset: 0x11906C0 VA: 0x1811920C0
	public void .ctor() { }

	// RVA: 0x1191D40 Offset: 0x1190340 VA: 0x181191D40
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x1192120 Offset: 0x1190720 VA: 0x181192120
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x11921A0 Offset: 0x11907A0 VA: 0x1811921A0
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1190ED0 Offset: 0x118F4D0 VA: 0x181190ED0 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x1191B70 Offset: 0x1190170 VA: 0x181191B70
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x1191940 Offset: 0x118FF40 VA: 0x181191940
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x11917C0 Offset: 0x118FDC0 VA: 0x1811917C0
	private bool IsLocal(Uri host) { }

	// RVA: 0x11916C0 Offset: 0x118FCC0 VA: 0x1811916C0
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x1191580 Offset: 0x118FB80 VA: 0x181191580 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x1191160 Offset: 0x118F760 VA: 0x181191160
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x1191E40 Offset: 0x1190440 VA: 0x181191E40
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1191B40 Offset: 0x1190140 VA: 0x181191B40 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1190BE0 Offset: 0x118F1E0 VA: 0x181190BE0 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x1190B90 Offset: 0x118F190 VA: 0x181190B90
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x1191E10 Offset: 0x1190410 VA: 0x181191E10
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x10217D0 Offset: 0x101FDD0 VA: 0x1810217D0
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x1190D00 Offset: 0x118F300 VA: 0x181190D00
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x1191090 Offset: 0x118F690 VA: 0x181191090
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x11909E0 Offset: 0x118EFE0 VA: 0x1811909E0
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x1191AC0 Offset: 0x11900C0 VA: 0x181191AC0
	private static Uri ProxyUri(string proxyName) { }

}

