internal sealed class EmptyWebProxy : IWebProxy // TypeDefIndex: 2932
{	// Fields
	private ICredentials m_credentials; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90 Slot: 4
	public Uri GetProxy(Uri uri) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 5
	public bool IsBypassed(Uri uri) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public ICredentials get_Credentials() { }

}

