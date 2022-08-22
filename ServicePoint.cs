public class ServicePoint // TypeDefIndex: 3018
{	// Fields
	private readonly Uri uri; // 0x10
	private int connectionLimit; // 0x18
	private int maxIdleTime; // 0x1C
	private int currentConnections; // 0x20
	private DateTime idleSince; // 0x28
	private DateTime lastDnsResolve; // 0x30
	private Version protocolVersion; // 0x38
	private IPHostEntry host; // 0x40
	private bool usesProxy; // 0x48
	private Dictionary<string, WebConnectionGroup> groups; // 0x50
	private bool sendContinue; // 0x58
	private bool useConnect; // 0x59
	private object hostE; // 0x60
	private bool useNagle; // 0x68
	private BindIPEndPoint endPointCallback; // 0x70
	private bool tcp_keepalive; // 0x78
	private int tcp_keepalive_time; // 0x7C
	private int tcp_keepalive_interval; // 0x80
	private Timer idleTimer; // 0x88
	private object m_ServerCertificateOrBytes; // 0x90
	private object m_ClientCertificateOrBytes; // 0x98

	// Properties
	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0xFFF010 Offset: 0xFFD610 VA: 0x180FFF010
	internal void .ctor(Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Uri get_Address() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_ConnectionLimit() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0xE69910 Offset: 0xE67F10 VA: 0x180E69910
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0xFFF6F0 Offset: 0xFFDCF0 VA: 0x180FFF6F0
	internal bool get_SendContinue() { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	internal void set_SendContinue(bool value) { }

	// RVA: 0xFFEEA0 Offset: 0xFFD4A0 VA: 0x180FFEEA0
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0xFFE8A0 Offset: 0xFFCEA0 VA: 0x180FFE8A0
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0xFFEA80 Offset: 0xFFD080 VA: 0x180FFEA80
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	internal bool get_UsesProxy() { }

	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	internal void set_UsesProxy(bool value) { }

	// RVA: 0xAF5CE0 Offset: 0xAF42E0 VA: 0x180AF5CE0
	internal bool get_UseConnect() { }

	// RVA: 0xFFF7E0 Offset: 0xFFDDE0 VA: 0x180FFF7E0
	internal void set_UseConnect(bool value) { }

	// RVA: 0xFFE730 Offset: 0xFFCD30 VA: 0x180FFE730
	private WebConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0xFFEC40 Offset: 0xFFD240 VA: 0x180FFEC40
	private void RemoveConnectionGroup(WebConnectionGroup group) { }

	// RVA: 0xFFE080 Offset: 0xFFC680 VA: 0x180FFE080
	private bool CheckAvailableForRecycling(out DateTime outIdleSince) { }

	// RVA: 0xFFE880 Offset: 0xFFCE80 VA: 0x180FFE880
	private void IdleTimerCallback(object obj) { }

	// RVA: 0xFFF0F0 Offset: 0xFFD6F0 VA: 0x180FFF0F0
	private bool get_HasTimedOut() { }

	// RVA: 0xFFF230 Offset: 0xFFD830 VA: 0x180FFF230
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	internal void SetVersion(Version version) { }

	// RVA: 0xFFECE0 Offset: 0xFFD2E0 VA: 0x180FFECE0
	internal EventHandler SendRequest(HttpWebRequest request, string groupName) { }

	// RVA: 0xFFE630 Offset: 0xFFCC30 VA: 0x180FFE630
	public bool CloseConnectionGroup(string connectionGroupName) { }

	// RVA: 0xFFEFD0 Offset: 0xFFD5D0 VA: 0x180FFEFD0
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0xFFEF90 Offset: 0xFFD590 VA: 0x180FFEF90
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0xFFDF70 Offset: 0xFFC570 VA: 0x180FFDF70
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFFEF80 Offset: 0xFFD580 VA: 0x180FFEF80
	private void <GetConnectionGroup>b__66_0(object s, EventArgs e) { }

}

