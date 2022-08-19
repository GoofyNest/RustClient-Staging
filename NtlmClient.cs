internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 2560
{	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x1437D

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x121B240 Offset: 0x1219840 VA: 0x18121B240 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x121B640 Offset: 0x1219C40 VA: 0x18121B640 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121B5E0 Offset: 0x1219BE0 VA: 0x18121B5E0
	private static void .cctor() { }

}

private sealed class NtlmClient.<>c // TypeDefIndex: 2561
{	// Fields
	public static readonly NtlmClient.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x121E150 Offset: 0x121C750 VA: 0x18121E150
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121DD00 Offset: 0x121C300 VA: 0x18121DD00
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 3017
{	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1348680 Offset: 0x1346C80 VA: 0x181348680
	public void .ctor() { }

	// RVA: 0x13485A0 Offset: 0x1346BA0 VA: 0x1813485A0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x13486F0 Offset: 0x1346CF0 VA: 0x1813486F0 Slot: 6
	public string get_AuthenticationType() { }

}

