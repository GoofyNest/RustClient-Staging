public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 901
{	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x17B4630 Offset: 0x17B2C30 VA: 0x1817B4630
	internal void .ctor() { }

	// RVA: 0x17B44D0 Offset: 0x17B2AD0 VA: 0x1817B44D0
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x17B4380 Offset: 0x17B2980 VA: 0x1817B4380
	public void .ctor(string name) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Name() { }

	// RVA: 0x17B46D0 Offset: 0x17B2CD0 VA: 0x1817B46D0
	public void set_Name(string value) { }

	// RVA: 0x17B42F0 Offset: 0x17B28F0 VA: 0x1817B42F0 Slot: 12
	public override SecurityElement ToXml() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17B4200 Offset: 0x17B2800 VA: 0x1817B4200 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17B4280 Offset: 0x17B2880 VA: 0x1817B4280 Slot: 2
	public override int GetHashCode() { }

}

