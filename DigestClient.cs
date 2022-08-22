internal class DigestClient : IAuthenticationModule // TypeDefIndex: 2994
{	// Fields
	private static readonly Hashtable cache; // 0x14610

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x152D540 Offset: 0x152BB40 VA: 0x18152D540
	private static Hashtable get_Cache() { }

	// RVA: 0x152CD60 Offset: 0x152B360 VA: 0x18152CD60
	private static void CheckExpired(int count) { }

	// RVA: 0x152CA30 Offset: 0x152B030 VA: 0x18152CA30 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x152D2F0 Offset: 0x152B8F0 VA: 0x18152D2F0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x152D510 Offset: 0x152BB10 VA: 0x18152D510 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x152D4A0 Offset: 0x152BAA0 VA: 0x18152D4A0
	private static void .cctor() { }

}

