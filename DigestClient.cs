internal class DigestClient : IAuthenticationModule // TypeDefIndex: 2994
{	// Fields
	private static readonly Hashtable cache; // 0x2B1047C

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x152C610 Offset: 0x152AC10 VA: 0x18152C610
	private static Hashtable get_Cache() { }

	// RVA: 0x152BE30 Offset: 0x152A430 VA: 0x18152BE30
	private static void CheckExpired(int count) { }

	// RVA: 0x152BB00 Offset: 0x152A100 VA: 0x18152BB00 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x152C3C0 Offset: 0x152A9C0 VA: 0x18152C3C0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x152C5E0 Offset: 0x152ABE0 VA: 0x18152C5E0 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x152C570 Offset: 0x152AB70 VA: 0x18152C570
	private static void .cctor() { }

}

