internal class BasicClient : IAuthenticationModule // TypeDefIndex: 2988
{	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x151F620 Offset: 0x151DC20 VA: 0x18151F620 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151F6D0 Offset: 0x151DCD0 VA: 0x18151F6D0
	private static byte[] GetBytes(string str) { }

	// RVA: 0x151F770 Offset: 0x151DD70 VA: 0x18151F770
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151FB50 Offset: 0x151E150 VA: 0x18151FB50 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151FB70 Offset: 0x151E170 VA: 0x18151FB70 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

