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

	// RVA: 0xFFE930 Offset: 0xFFCF30 VA: 0x180FFE930
	private static void .cctor() { }

	// RVA: 0xFFE8D0 Offset: 0xFFCED0 VA: 0x180FFE8D0
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0xFFEA20 Offset: 0xFFD020 VA: 0x180FFEA20
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0xFFEA80 Offset: 0xFFD080 VA: 0x180FFEA80
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0xFFEAE0 Offset: 0xFFD0E0 VA: 0x180FFEAE0
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0xFFEB40 Offset: 0xFFD140 VA: 0x180FFEB40
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0xFFEBA0 Offset: 0xFFD1A0 VA: 0x180FFEBA0
	public static void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0xFFE0F0 Offset: 0xFFC6F0 VA: 0x180FFE0F0
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0xFFDDE0 Offset: 0xFFC3E0 VA: 0x180FFDDE0
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

	// RVA: 0xFFCAB0 Offset: 0xFFB0B0 VA: 0x180FFCAB0
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0xFFCB10 Offset: 0xFFB110 VA: 0x180FFCB10
	public bool get_UsesProxy() { }

	// RVA: 0xFFC9D0 Offset: 0xFFAFD0 VA: 0x180FFC9D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFFC8B0 Offset: 0xFFAEB0 VA: 0x180FFC8B0 Slot: 0
	public override bool Equals(object obj) { }

}

