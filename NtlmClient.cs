internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 2560
{	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x1437D

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x121B500 Offset: 0x1219B00 VA: 0x18121B500 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x121B900 Offset: 0x1219F00 VA: 0x18121B900 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121B8A0 Offset: 0x1219EA0 VA: 0x18121B8A0
	private static void .cctor() { }

}

private sealed class NtlmClient.<>c // TypeDefIndex: 2561
{	// Fields
	public static readonly NtlmClient.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x121E410 Offset: 0x121CA10 VA: 0x18121E410
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121DFC0 Offset: 0x121C5C0 VA: 0x18121DFC0
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 3017
{	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1348940 Offset: 0x1346F40 VA: 0x181348940
	public void .ctor() { }

	// RVA: 0x1348860 Offset: 0x1346E60 VA: 0x181348860 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x13489B0 Offset: 0x1346FB0 VA: 0x1813489B0 Slot: 6
	public string get_AuthenticationType() { }

}

