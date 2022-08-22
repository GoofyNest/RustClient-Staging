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

	// RVA: 0x15283F0 Offset: 0x15269F0 VA: 0x1815283F0
	public void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Comment() { }

	// RVA: 0x15288F0 Offset: 0x1526EF0 VA: 0x1815288F0
	public void set_Comment(string value) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_CommentUri(Uri value) { }

	// RVA: 0xE75870 Offset: 0xE73E70 VA: 0x180E75870
	public void set_HttpOnly(bool value) { }

	// RVA: 0x7746D0 Offset: 0x772CD0 VA: 0x1807746D0
	public void set_Discard(bool value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Domain() { }

	// RVA: 0x1528950 Offset: 0x1526F50 VA: 0x181528950
	public void set_Domain(string value) { }

	// RVA: 0x1528640 Offset: 0x1526C40 VA: 0x181528640
	private string get__Domain() { }

	// RVA: 0x1528570 Offset: 0x1526B70 VA: 0x181528570
	public bool get_Expired() { }

	// RVA: 0xC15040 Offset: 0xC13640 VA: 0x180C15040
	public void set_Expires(DateTime value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_Name() { }

	// RVA: 0x1526C30 Offset: 0x1525230 VA: 0x181526C30
	internal bool InternalSetName(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_Path() { }

	// RVA: 0x15289E0 Offset: 0x1526FE0 VA: 0x1815289E0
	public void set_Path(string value) { }

	// RVA: 0x15286E0 Offset: 0x1526CE0 VA: 0x1815286E0
	private string get__Path() { }

	// RVA: 0x11CE8D0 Offset: 0x11CCED0 VA: 0x1811CE8D0
	internal bool get_Plain() { }

	// RVA: 0x1526D40 Offset: 0x1525340 VA: 0x181526D40
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x15273E0 Offset: 0x15259E0 VA: 0x1815273E0
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x1526630 Offset: 0x1524C30 VA: 0x181526630
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x1528A50 Offset: 0x1527050 VA: 0x181528A50
	public void set_Port(string value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal int[] get_PortList() { }

	// RVA: 0x1528750 Offset: 0x1526D50 VA: 0x181528750
	private string get__Port() { }

	// RVA: 0xC312F0 Offset: 0xC2F8F0 VA: 0x180C312F0
	public bool get_Secure() { }

	// RVA: 0xC32410 Offset: 0xC30A10 VA: 0x180C32410
	public void set_Secure(bool value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public string get_Value() { }

	// RVA: 0x1528E60 Offset: 0x1527460 VA: 0x181528E60
	public void set_Value(string value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal CookieVariant get_Variant() { }

	// RVA: 0x1528550 Offset: 0x1526B50 VA: 0x181528550
	internal string get_DomainKey() { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public int get_Version() { }

	// RVA: 0x1528ED0 Offset: 0x15274D0 VA: 0x181528ED0
	public void set_Version(int value) { }

	// RVA: 0x1528800 Offset: 0x1526E00 VA: 0x181528800
	private string get__Version() { }

	// RVA: 0x15267D0 Offset: 0x1524DD0 VA: 0x1815267D0
	internal static IComparer GetComparer() { }

	// RVA: 0x15266C0 Offset: 0x1524CC0 VA: 0x1815266C0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1526830 Offset: 0x1524E30 VA: 0x181526830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1526DA0 Offset: 0x15253A0 VA: 0x181526DA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1528290 Offset: 0x1526890 VA: 0x181528290
	private static void .cctor() { }

}

