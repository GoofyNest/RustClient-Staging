internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 2560
{	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x140B0

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x121BBA0 Offset: 0x121A1A0 VA: 0x18121BBA0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x121BFA0 Offset: 0x121A5A0 VA: 0x18121BFA0 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121BF40 Offset: 0x121A540 VA: 0x18121BF40
	private static void .cctor() { }

}

private sealed class NtlmClient.<>c // TypeDefIndex: 2561
{	// Fields
	public static readonly NtlmClient.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x121EAB0 Offset: 0x121D0B0 VA: 0x18121EAB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121E660 Offset: 0x121CC60 VA: 0x18121E660
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 3017
{	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1347A40 Offset: 0x1346040 VA: 0x181347A40
	public void .ctor() { }

	// RVA: 0x1347960 Offset: 0x1345F60 VA: 0x181347960 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1347AB0 Offset: 0x13460B0 VA: 0x181347AB0 Slot: 6
	public string get_AuthenticationType() { }

}

