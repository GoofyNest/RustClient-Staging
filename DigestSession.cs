internal class DigestSession // TypeDefIndex: 2993
{	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x152EE00 Offset: 0x152D400 VA: 0x18152EE00
	private static void .cctor() { }

	// RVA: 0x152EE50 Offset: 0x152D450 VA: 0x18152EE50
	public void .ctor() { }

	// RVA: 0x152EEC0 Offset: 0x152D4C0 VA: 0x18152EEC0
	public string get_Algorithm() { }

	// RVA: 0x152F0C0 Offset: 0x152D6C0 VA: 0x18152F0C0
	public string get_Realm() { }

	// RVA: 0x152F000 Offset: 0x152D600 VA: 0x18152F000
	public string get_Nonce() { }

	// RVA: 0x152F040 Offset: 0x152D640 VA: 0x18152F040
	public string get_Opaque() { }

	// RVA: 0x152F080 Offset: 0x152D680 VA: 0x18152F080
	public string get_QOP() { }

	// RVA: 0x152EF00 Offset: 0x152D500 VA: 0x18152EF00
	public string get_CNonce() { }

	// RVA: 0x152E8C0 Offset: 0x152CEC0 VA: 0x18152E8C0
	public bool Parse(string challenge) { }

	// RVA: 0x152E770 Offset: 0x152CD70 VA: 0x18152E770
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x152E510 Offset: 0x152CB10 VA: 0x18152E510
	private string HA1(string username, string password) { }

	// RVA: 0x152E680 Offset: 0x152CC80 VA: 0x18152E680
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x152EA60 Offset: 0x152D060 VA: 0x18152EA60
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x152E0E0 Offset: 0x152C6E0 VA: 0x18152E0E0
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public DateTime get_LastUse() { }

}

