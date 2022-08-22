internal sealed class EmptyWebProxy : IWebProxy // TypeDefIndex: 2932
{	// Fields
	private ICredentials m_credentials; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380 Slot: 4
	public Uri GetProxy(Uri uri) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 5
	public bool IsBypassed(Uri uri) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public ICredentials get_Credentials() { }

}

