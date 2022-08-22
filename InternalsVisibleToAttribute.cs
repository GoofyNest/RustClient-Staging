public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1307
{	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public string AssemblyName { get; }
	public bool AllInternalsVisible { get; set; }

	// Methods

	// RVA: 0xFE7CC0 Offset: 0xFE62C0 VA: 0x180FE7CC0
	public void .ctor(string assemblyName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_AssemblyName() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_AllInternalsVisible() { }

	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	public void set_AllInternalsVisible(bool value) { }

}

