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

	// RVA: 0xFFDE90 Offset: 0xFFC490 VA: 0x180FFDE90
	private static void .cctor() { }

	// RVA: 0xFFDE30 Offset: 0xFFC430 VA: 0x180FFDE30
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0xFFDF80 Offset: 0xFFC580 VA: 0x180FFDF80
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0xFFDFE0 Offset: 0xFFC5E0 VA: 0x180FFDFE0
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0xFFE040 Offset: 0xFFC640 VA: 0x180FFE040
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0xFFE0A0 Offset: 0xFFC6A0 VA: 0x180FFE0A0
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0xFFE100 Offset: 0xFFC700 VA: 0x180FFE100
	public static void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0xFFD650 Offset: 0xFFBC50 VA: 0x180FFD650
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0xFFD340 Offset: 0xFFB940 VA: 0x180FFD340
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

	// RVA: 0xFFC010 Offset: 0xFFA610 VA: 0x180FFC010
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0xFFC070 Offset: 0xFFA670 VA: 0x180FFC070
	public bool get_UsesProxy() { }

	// RVA: 0xFFBF30 Offset: 0xFFA530 VA: 0x180FFBF30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFFBE10 Offset: 0xFFA410 VA: 0x180FFBE10 Slot: 0
	public override bool Equals(object obj) { }

}

