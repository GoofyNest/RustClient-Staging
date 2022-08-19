internal class DigestClient : IAuthenticationModule // TypeDefIndex: 2994
{	// Fields
	private static readonly Hashtable cache; // 0x14610

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x152D280 Offset: 0x152B880 VA: 0x18152D280
	private static Hashtable get_Cache() { }

	// RVA: 0x152CAA0 Offset: 0x152B0A0 VA: 0x18152CAA0
	private static void CheckExpired(int count) { }

	// RVA: 0x152C770 Offset: 0x152AD70 VA: 0x18152C770 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x152D030 Offset: 0x152B630 VA: 0x18152D030 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x152D250 Offset: 0x152B850 VA: 0x18152D250 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x152D1E0 Offset: 0x152B7E0 VA: 0x18152D1E0
	private static void .cctor() { }

}

