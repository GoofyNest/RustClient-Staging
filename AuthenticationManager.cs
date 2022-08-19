public class AuthenticationManager // TypeDefIndex: 2987
{	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x151EBB0 Offset: 0x151D1B0 VA: 0x18151EBB0
	private static void EnsureModules() { }

	// RVA: 0x151E760 Offset: 0x151CD60 VA: 0x18151E760
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x151E880 Offset: 0x151CE80 VA: 0x18151E880
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x151EE20 Offset: 0x151D420 VA: 0x18151EE20
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x151F1B0 Offset: 0x151D7B0 VA: 0x18151F1B0
	private static void .cctor() { }

}

