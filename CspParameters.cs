public sealed class CspParameters // TypeDefIndex: 947
{	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public CspProviderFlags get_Flags() { }

	// RVA: 0x16FA9C0 Offset: 0x16F8FC0 VA: 0x1816FA9C0
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x16FA890 Offset: 0x16F8E90 VA: 0x1816FA890
	public void .ctor() { }

	// RVA: 0x16FA8F0 Offset: 0x16F8EF0 VA: 0x1816FA8F0
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x16FA950 Offset: 0x16F8F50 VA: 0x1816FA950
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x16FA810 Offset: 0x16F8E10 VA: 0x1816FA810
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

}

