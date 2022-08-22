public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 901
{	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x17B2180 Offset: 0x17B0780 VA: 0x1817B2180
	internal void .ctor() { }

	// RVA: 0x17B2020 Offset: 0x17B0620 VA: 0x1817B2020
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x17B1ED0 Offset: 0x17B04D0 VA: 0x1817B1ED0
	public void .ctor(string name) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Name() { }

	// RVA: 0x17B2220 Offset: 0x17B0820 VA: 0x1817B2220
	public void set_Name(string value) { }

	// RVA: 0x17B1E40 Offset: 0x17B0440 VA: 0x1817B1E40 Slot: 12
	public override SecurityElement ToXml() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17B1D50 Offset: 0x17B0350 VA: 0x1817B1D50 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17B1DD0 Offset: 0x17B03D0 VA: 0x1817B1DD0 Slot: 2
	public override int GetHashCode() { }

}

