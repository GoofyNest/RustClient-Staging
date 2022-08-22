public class AuthenticationManager // TypeDefIndex: 2987
{	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x151DF40 Offset: 0x151C540 VA: 0x18151DF40
	private static void EnsureModules() { }

	// RVA: 0x151DAF0 Offset: 0x151C0F0 VA: 0x18151DAF0
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x151DC10 Offset: 0x151C210 VA: 0x18151DC10
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x151E1B0 Offset: 0x151C7B0 VA: 0x18151E1B0
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x151E540 Offset: 0x151CB40 VA: 0x18151E540
	private static void .cctor() { }

}

