public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1307
{	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public string AssemblyName { get; }
	public bool AllInternalsVisible { get; set; }

	// Methods

	// RVA: 0xFE8760 Offset: 0xFE6D60 VA: 0x180FE8760
	public void .ctor(string assemblyName) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_AssemblyName() { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_AllInternalsVisible() { }

	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	public void set_AllInternalsVisible(bool value) { }

}

