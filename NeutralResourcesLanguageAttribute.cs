public sealed class NeutralResourcesLanguageAttribute : Attribute // TypeDefIndex: 488
{	// Fields
	private string _culture; // 0x10
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x18

	// Properties
	public string CultureName { get; }
	public UltimateResourceFallbackLocation Location { get; }

	// Methods

	// RVA: 0xFEB200 Offset: 0xFE9800 VA: 0x180FEB200
	public void .ctor(string cultureName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_CultureName() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public UltimateResourceFallbackLocation get_Location() { }

}

