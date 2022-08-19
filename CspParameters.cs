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

	// RVA: 0x16FCB10 Offset: 0x16FB110 VA: 0x1816FCB10
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x16FC9E0 Offset: 0x16FAFE0 VA: 0x1816FC9E0
	public void .ctor() { }

	// RVA: 0x16FCA40 Offset: 0x16FB040 VA: 0x1816FCA40
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x16FCAA0 Offset: 0x16FB0A0 VA: 0x1816FCAA0
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x16FC960 Offset: 0x16FAF60 VA: 0x1816FC960
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

}

