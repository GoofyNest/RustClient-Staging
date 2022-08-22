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

	// RVA: 0x152DED0 Offset: 0x152C4D0 VA: 0x18152DED0
	private static void .cctor() { }

	// RVA: 0x152DF20 Offset: 0x152C520 VA: 0x18152DF20
	public void .ctor() { }

	// RVA: 0x152DF90 Offset: 0x152C590 VA: 0x18152DF90
	public string get_Algorithm() { }

	// RVA: 0x152E190 Offset: 0x152C790 VA: 0x18152E190
	public string get_Realm() { }

	// RVA: 0x152E0D0 Offset: 0x152C6D0 VA: 0x18152E0D0
	public string get_Nonce() { }

	// RVA: 0x152E110 Offset: 0x152C710 VA: 0x18152E110
	public string get_Opaque() { }

	// RVA: 0x152E150 Offset: 0x152C750 VA: 0x18152E150
	public string get_QOP() { }

	// RVA: 0x152DFD0 Offset: 0x152C5D0 VA: 0x18152DFD0
	public string get_CNonce() { }

	// RVA: 0x152D990 Offset: 0x152BF90 VA: 0x18152D990
	public bool Parse(string challenge) { }

	// RVA: 0x152D840 Offset: 0x152BE40 VA: 0x18152D840
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x152D5E0 Offset: 0x152BBE0 VA: 0x18152D5E0
	private string HA1(string username, string password) { }

	// RVA: 0x152D750 Offset: 0x152BD50 VA: 0x18152D750
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x152DB30 Offset: 0x152C130 VA: 0x18152DB30
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x152D1B0 Offset: 0x152B7B0 VA: 0x18152D1B0
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public DateTime get_LastUse() { }

}

