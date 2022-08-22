internal class BasicClient : IAuthenticationModule // TypeDefIndex: 2988
{	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x151E6F0 Offset: 0x151CCF0 VA: 0x18151E6F0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151E7A0 Offset: 0x151CDA0 VA: 0x18151E7A0
	private static byte[] GetBytes(string str) { }

	// RVA: 0x151E840 Offset: 0x151CE40 VA: 0x18151E840
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151EC20 Offset: 0x151D220 VA: 0x18151EC20 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x151EC40 Offset: 0x151D240 VA: 0x18151EC40 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

