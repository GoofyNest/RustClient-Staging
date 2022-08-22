public sealed class Cookie // TypeDefIndex: 2934
{	// Fields
	internal static readonly char[] PortSplitDelimiters; // 0x0
	internal static readonly char[] Reserved2Name; // 0x8
	internal static readonly char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Properties
	public string Comment { get; set; }
	public Uri CommentUri { set; }
	public bool HttpOnly { set; }
	public bool Discard { set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	public bool Expired { get; }
	public DateTime Expires { set; }
	public string Name { get; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { set; }
	internal int[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }

	// Methods

	// RVA: 0x1527780 Offset: 0x1525D80 VA: 0x181527780
	public void .ctor() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Comment() { }

	// RVA: 0x1527C80 Offset: 0x1526280 VA: 0x181527C80
	public void set_Comment(string value) { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_CommentUri(Uri value) { }

	// RVA: 0xE765E0 Offset: 0xE74BE0 VA: 0x180E765E0
	public void set_HttpOnly(bool value) { }

	// RVA: 0x774730 Offset: 0x772D30 VA: 0x180774730
	public void set_Discard(bool value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Domain() { }

	// RVA: 0x1527CE0 Offset: 0x15262E0 VA: 0x181527CE0
	public void set_Domain(string value) { }

	// RVA: 0x15279D0 Offset: 0x1525FD0 VA: 0x1815279D0
	private string get__Domain() { }

	// RVA: 0x1527900 Offset: 0x1525F00 VA: 0x181527900
	public bool get_Expired() { }

	// RVA: 0xC157D0 Offset: 0xC13DD0 VA: 0x180C157D0
	public void set_Expires(DateTime value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_Name() { }

	// RVA: 0x1525FC0 Offset: 0x15245C0 VA: 0x181525FC0
	internal bool InternalSetName(string value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public string get_Path() { }

	// RVA: 0x1527D70 Offset: 0x1526370 VA: 0x181527D70
	public void set_Path(string value) { }

	// RVA: 0x1527A70 Offset: 0x1526070 VA: 0x181527A70
	private string get__Path() { }

	// RVA: 0x11CF230 Offset: 0x11CD830 VA: 0x1811CF230
	internal bool get_Plain() { }

	// RVA: 0x15260D0 Offset: 0x15246D0 VA: 0x1815260D0
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x1526770 Offset: 0x1524D70 VA: 0x181526770
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x15259C0 Offset: 0x1523FC0 VA: 0x1815259C0
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x1527DE0 Offset: 0x15263E0 VA: 0x181527DE0
	public void set_Port(string value) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	internal int[] get_PortList() { }

	// RVA: 0x1527AE0 Offset: 0x15260E0 VA: 0x181527AE0
	private string get__Port() { }

	// RVA: 0xC31A80 Offset: 0xC30080 VA: 0x180C31A80
	public bool get_Secure() { }

	// RVA: 0xC32BA0 Offset: 0xC311A0 VA: 0x180C32BA0
	public void set_Secure(bool value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public string get_Value() { }

	// RVA: 0x15281F0 Offset: 0x15267F0 VA: 0x1815281F0
	public void set_Value(string value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal CookieVariant get_Variant() { }

	// RVA: 0x15278E0 Offset: 0x1525EE0 VA: 0x1815278E0
	internal string get_DomainKey() { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
	public int get_Version() { }

	// RVA: 0x1528260 Offset: 0x1526860 VA: 0x181528260
	public void set_Version(int value) { }

	// RVA: 0x1527B90 Offset: 0x1526190 VA: 0x181527B90
	private string get__Version() { }

	// RVA: 0x1525B60 Offset: 0x1524160 VA: 0x181525B60
	internal static IComparer GetComparer() { }

	// RVA: 0x1525A50 Offset: 0x1524050 VA: 0x181525A50 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1525BC0 Offset: 0x15241C0 VA: 0x181525BC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1526130 Offset: 0x1524730 VA: 0x181526130 Slot: 3
	public override string ToString() { }

	// RVA: 0x1527620 Offset: 0x1525C20 VA: 0x181527620
	private static void .cctor() { }

}

