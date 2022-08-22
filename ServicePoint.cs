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

	// RVA: 0xFFFD70 Offset: 0xFFE370 VA: 0x180FFFD70
	internal void .ctor(Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Uri get_Address() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_ConnectionLimit() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x5925D0 Offset: 0x590BD0 VA: 0x1805925D0
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0xE6A680 Offset: 0xE68C80 VA: 0x180E6A680
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x1000450 Offset: 0xFFEA50 VA: 0x181000450
	internal bool get_SendContinue() { }

	// RVA: 0x5925D0 Offset: 0x590BD0 VA: 0x1805925D0
	internal void set_SendContinue(bool value) { }

	// RVA: 0xFFFC00 Offset: 0xFFE200 VA: 0x180FFFC00
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0xFFF600 Offset: 0xFFDC00 VA: 0x180FFF600
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0xFFF7E0 Offset: 0xFFDDE0 VA: 0x180FFF7E0
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	internal bool get_UsesProxy() { }

	// RVA: 0x4BC570 Offset: 0x4BAB70 VA: 0x1804BC570
	internal void set_UsesProxy(bool value) { }

	// RVA: 0xAF6470 Offset: 0xAF4A70 VA: 0x180AF6470
	internal bool get_UseConnect() { }

	// RVA: 0x1000540 Offset: 0xFFEB40 VA: 0x181000540
	internal void set_UseConnect(bool value) { }

	// RVA: 0xFFF490 Offset: 0xFFDA90 VA: 0x180FFF490
	private WebConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0xFFF9A0 Offset: 0xFFDFA0 VA: 0x180FFF9A0
	private void RemoveConnectionGroup(WebConnectionGroup group) { }

	// RVA: 0xFFEDE0 Offset: 0xFFD3E0 VA: 0x180FFEDE0
	private bool CheckAvailableForRecycling(out DateTime outIdleSince) { }

	// RVA: 0xFFF5E0 Offset: 0xFFDBE0 VA: 0x180FFF5E0
	private void IdleTimerCallback(object obj) { }

	// RVA: 0xFFFE50 Offset: 0xFFE450 VA: 0x180FFFE50
	private bool get_HasTimedOut() { }

	// RVA: 0xFFFF90 Offset: 0xFFE590 VA: 0x180FFFF90
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	internal void SetVersion(Version version) { }

	// RVA: 0xFFFA40 Offset: 0xFFE040 VA: 0x180FFFA40
	internal EventHandler SendRequest(HttpWebRequest request, string groupName) { }

	// RVA: 0xFFF390 Offset: 0xFFD990 VA: 0x180FFF390
	public bool CloseConnectionGroup(string connectionGroupName) { }

	// RVA: 0xFFFD30 Offset: 0xFFE330 VA: 0x180FFFD30
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0xFFFCF0 Offset: 0xFFE2F0 VA: 0x180FFFCF0
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0xFFECD0 Offset: 0xFFD2D0 VA: 0x180FFECD0
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFFFCE0 Offset: 0xFFE2E0 VA: 0x180FFFCE0
	private void <GetConnectionGroup>b__66_0(object s, EventArgs e) { }

}

