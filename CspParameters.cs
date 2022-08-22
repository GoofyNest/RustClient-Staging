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

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public CspProviderFlags get_Flags() { }

	// RVA: 0x16FCDD0 Offset: 0x16FB3D0 VA: 0x1816FCDD0
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x16FCCA0 Offset: 0x16FB2A0 VA: 0x1816FCCA0
	public void .ctor() { }

	// RVA: 0x16FCD00 Offset: 0x16FB300 VA: 0x1816FCD00
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x16FCD60 Offset: 0x16FB360 VA: 0x1816FCD60
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x16FCC20 Offset: 0x16FB220 VA: 0x1816FCC20
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

}

