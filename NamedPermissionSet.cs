public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 901
{	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x17B4370 Offset: 0x17B2970 VA: 0x1817B4370
	internal void .ctor() { }

	// RVA: 0x17B4210 Offset: 0x17B2810 VA: 0x1817B4210
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x17B40C0 Offset: 0x17B26C0 VA: 0x1817B40C0
	public void .ctor(string name) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Name() { }

	// RVA: 0x17B4410 Offset: 0x17B2A10 VA: 0x1817B4410
	public void set_Name(string value) { }

	// RVA: 0x17B4030 Offset: 0x17B2630 VA: 0x1817B4030 Slot: 12
	public override SecurityElement ToXml() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x17B3F40 Offset: 0x17B2540 VA: 0x1817B3F40 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x17B3FC0 Offset: 0x17B25C0 VA: 0x1817B3FC0 Slot: 2
	public override int GetHashCode() { }

}

