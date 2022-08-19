public class ServicePointManager // TypeDefIndex: 3019
{	// Fields
	private static HybridDictionary servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties
	[MonoTODOAttribute] // RVA: 0xB8B70 Offset: 0xB7F70 VA: 0x1800B8B70
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { set; }

	// Methods

	// RVA: 0xFFDBD0 Offset: 0xFFC1D0 VA: 0x180FFDBD0
	private static void .cctor() { }

	// RVA: 0xFFDB70 Offset: 0xFFC170 VA: 0x180FFDB70
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0xFFDCC0 Offset: 0xFFC2C0 VA: 0x180FFDCC0
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0xFFDD20 Offset: 0xFFC320 VA: 0x180FFDD20
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0xFFDD80 Offset: 0xFFC380 VA: 0x180FFDD80
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0xFFDDE0 Offset: 0xFFC3E0 VA: 0x180FFDDE0
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0xFFDE40 Offset: 0xFFC440 VA: 0x180FFDE40
	public static void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0xFFD390 Offset: 0xFFB990 VA: 0x180FFD390
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0xFFD080 Offset: 0xFFB680 VA: 0x180FFD080
	internal static void CloseConnectionGroup(string connectionGroupName) { }

}

private class ServicePointManager.SPKey // TypeDefIndex: 3020
{	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Properties
	public bool UsesProxy { get; }

	// Methods

	// RVA: 0xFFBD50 Offset: 0xFFA350 VA: 0x180FFBD50
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0xFFBDB0 Offset: 0xFFA3B0 VA: 0x180FFBDB0
	public bool get_UsesProxy() { }

	// RVA: 0xFFBC70 Offset: 0xFFA270 VA: 0x180FFBC70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFFBB50 Offset: 0xFFA150 VA: 0x180FFBB50 Slot: 0
	public override bool Equals(object obj) { }

}

