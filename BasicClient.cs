internal class BasicClient : IAuthenticationModule // TypeDefIndex: 2988
{	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x151F360 Offset: 0x151D960 VA: 0x18151F360 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151F410 Offset: 0x151DA10 VA: 0x18151F410
	private static byte[] GetBytes(string str) { }

	// RVA: 0x151F4B0 Offset: 0x151DAB0 VA: 0x18151F4B0
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151F890 Offset: 0x151DE90 VA: 0x18151F890 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151F8B0 Offset: 0x151DEB0 VA: 0x18151F8B0 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

