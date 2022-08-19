public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1307
{	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public string AssemblyName { get; }
	public bool AllInternalsVisible { get; set; }

	// Methods

	// RVA: 0xFE7A00 Offset: 0xFE6000 VA: 0x180FE7A00
	public void .ctor(string assemblyName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_AssemblyName() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_AllInternalsVisible() { }

	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	public void set_AllInternalsVisible(bool value) { }

}

