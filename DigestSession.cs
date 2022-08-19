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

	// RVA: 0x152EB40 Offset: 0x152D140 VA: 0x18152EB40
	private static void .cctor() { }

	// RVA: 0x152EB90 Offset: 0x152D190 VA: 0x18152EB90
	public void .ctor() { }

	// RVA: 0x152EC00 Offset: 0x152D200 VA: 0x18152EC00
	public string get_Algorithm() { }

	// RVA: 0x152EE00 Offset: 0x152D400 VA: 0x18152EE00
	public string get_Realm() { }

	// RVA: 0x152ED40 Offset: 0x152D340 VA: 0x18152ED40
	public string get_Nonce() { }

	// RVA: 0x152ED80 Offset: 0x152D380 VA: 0x18152ED80
	public string get_Opaque() { }

	// RVA: 0x152EDC0 Offset: 0x152D3C0 VA: 0x18152EDC0
	public string get_QOP() { }

	// RVA: 0x152EC40 Offset: 0x152D240 VA: 0x18152EC40
	public string get_CNonce() { }

	// RVA: 0x152E600 Offset: 0x152CC00 VA: 0x18152E600
	public bool Parse(string challenge) { }

	// RVA: 0x152E4B0 Offset: 0x152CAB0 VA: 0x18152E4B0
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x152E250 Offset: 0x152C850 VA: 0x18152E250
	private string HA1(string username, string password) { }

	// RVA: 0x152E3C0 Offset: 0x152C9C0 VA: 0x18152E3C0
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x152E7A0 Offset: 0x152CDA0 VA: 0x18152E7A0
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x152DE20 Offset: 0x152C420 VA: 0x18152DE20
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public DateTime get_LastUse() { }

}

