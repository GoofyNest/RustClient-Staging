public class AuthenticationManager // TypeDefIndex: 2987
{	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x151EE70 Offset: 0x151D470 VA: 0x18151EE70
	private static void EnsureModules() { }

	// RVA: 0x151EA20 Offset: 0x151D020 VA: 0x18151EA20
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x151EB40 Offset: 0x151D140 VA: 0x18151EB40
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x151F0E0 Offset: 0x151D6E0 VA: 0x18151F0E0
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x151F470 Offset: 0x151DA70 VA: 0x18151F470
	private static void .cctor() { }

}

