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

	// RVA: 0xFFF2D0 Offset: 0xFFD8D0 VA: 0x180FFF2D0
	internal void .ctor(Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Uri get_Address() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_ConnectionLimit() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0xE69BD0 Offset: 0xE681D0 VA: 0x180E69BD0
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0xFFF9B0 Offset: 0xFFDFB0 VA: 0x180FFF9B0
	internal bool get_SendContinue() { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	internal void set_SendContinue(bool value) { }

	// RVA: 0xFFF160 Offset: 0xFFD760 VA: 0x180FFF160
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0xFFEB60 Offset: 0xFFD160 VA: 0x180FFEB60
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0xFFED40 Offset: 0xFFD340 VA: 0x180FFED40
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	internal bool get_UsesProxy() { }

	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	internal void set_UsesProxy(bool value) { }

	// RVA: 0xAF5FA0 Offset: 0xAF45A0 VA: 0x180AF5FA0
	internal bool get_UseConnect() { }

	// RVA: 0xFFFAA0 Offset: 0xFFE0A0 VA: 0x180FFFAA0
	internal void set_UseConnect(bool value) { }

	// RVA: 0xFFE9F0 Offset: 0xFFCFF0 VA: 0x180FFE9F0
	private WebConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0xFFEF00 Offset: 0xFFD500 VA: 0x180FFEF00
	private void RemoveConnectionGroup(WebConnectionGroup group) { }

	// RVA: 0xFFE340 Offset: 0xFFC940 VA: 0x180FFE340
	private bool CheckAvailableForRecycling(out DateTime outIdleSince) { }

	// RVA: 0xFFEB40 Offset: 0xFFD140 VA: 0x180FFEB40
	private void IdleTimerCallback(object obj) { }

	// RVA: 0xFFF3B0 Offset: 0xFFD9B0 VA: 0x180FFF3B0
	private bool get_HasTimedOut() { }

	// RVA: 0xFFF4F0 Offset: 0xFFDAF0 VA: 0x180FFF4F0
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	internal void SetVersion(Version version) { }

	// RVA: 0xFFEFA0 Offset: 0xFFD5A0 VA: 0x180FFEFA0
	internal EventHandler SendRequest(HttpWebRequest request, string groupName) { }

	// RVA: 0xFFE8F0 Offset: 0xFFCEF0 VA: 0x180FFE8F0
	public bool CloseConnectionGroup(string connectionGroupName) { }

	// RVA: 0xFFF290 Offset: 0xFFD890 VA: 0x180FFF290
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0xFFF250 Offset: 0xFFD850 VA: 0x180FFF250
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0xFFE230 Offset: 0xFFC830 VA: 0x180FFE230
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFFF240 Offset: 0xFFD840 VA: 0x180FFF240
	private void <GetConnectionGroup>b__66_0(object s, EventArgs e) { }

}

