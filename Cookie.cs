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

	// RVA: 0x15286B0 Offset: 0x1526CB0 VA: 0x1815286B0
	public void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Comment() { }

	// RVA: 0x1528BB0 Offset: 0x15271B0 VA: 0x181528BB0
	public void set_Comment(string value) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_CommentUri(Uri value) { }

	// RVA: 0xE75B30 Offset: 0xE74130 VA: 0x180E75B30
	public void set_HttpOnly(bool value) { }

	// RVA: 0x7747E0 Offset: 0x772DE0 VA: 0x1807747E0
	public void set_Discard(bool value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Domain() { }

	// RVA: 0x1528C10 Offset: 0x1527210 VA: 0x181528C10
	public void set_Domain(string value) { }

	// RVA: 0x1528900 Offset: 0x1526F00 VA: 0x181528900
	private string get__Domain() { }

	// RVA: 0x1528830 Offset: 0x1526E30 VA: 0x181528830
	public bool get_Expired() { }

	// RVA: 0xC15300 Offset: 0xC13900 VA: 0x180C15300
	public void set_Expires(DateTime value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_Name() { }

	// RVA: 0x1526EF0 Offset: 0x15254F0 VA: 0x181526EF0
	internal bool InternalSetName(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_Path() { }

	// RVA: 0x1528CA0 Offset: 0x15272A0 VA: 0x181528CA0
	public void set_Path(string value) { }

	// RVA: 0x15289A0 Offset: 0x1526FA0 VA: 0x1815289A0
	private string get__Path() { }

	// RVA: 0x11CEB90 Offset: 0x11CD190 VA: 0x1811CEB90
	internal bool get_Plain() { }

	// RVA: 0x1527000 Offset: 0x1525600 VA: 0x181527000
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x15276A0 Offset: 0x1525CA0 VA: 0x1815276A0
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x15268F0 Offset: 0x1524EF0 VA: 0x1815268F0
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x1528D10 Offset: 0x1527310 VA: 0x181528D10
	public void set_Port(string value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal int[] get_PortList() { }

	// RVA: 0x1528A10 Offset: 0x1527010 VA: 0x181528A10
	private string get__Port() { }

	// RVA: 0xC315B0 Offset: 0xC2FBB0 VA: 0x180C315B0
	public bool get_Secure() { }

	// RVA: 0xC326D0 Offset: 0xC30CD0 VA: 0x180C326D0
	public void set_Secure(bool value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public string get_Value() { }

	// RVA: 0x1529120 Offset: 0x1527720 VA: 0x181529120
	public void set_Value(string value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal CookieVariant get_Variant() { }

	// RVA: 0x1528810 Offset: 0x1526E10 VA: 0x181528810
	internal string get_DomainKey() { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public int get_Version() { }

	// RVA: 0x1529190 Offset: 0x1527790 VA: 0x181529190
	public void set_Version(int value) { }

	// RVA: 0x1528AC0 Offset: 0x15270C0 VA: 0x181528AC0
	private string get__Version() { }

	// RVA: 0x1526A90 Offset: 0x1525090 VA: 0x181526A90
	internal static IComparer GetComparer() { }

	// RVA: 0x1526980 Offset: 0x1524F80 VA: 0x181526980 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1526AF0 Offset: 0x15250F0 VA: 0x181526AF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1527060 Offset: 0x1525660 VA: 0x181527060 Slot: 3
	public override string ToString() { }

	// RVA: 0x1528550 Offset: 0x1526B50 VA: 0x181528550
	private static void .cctor() { }

}

