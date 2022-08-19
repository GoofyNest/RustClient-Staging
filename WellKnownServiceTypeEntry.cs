public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 1156
{	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x12070C0 Offset: 0x12056C0 VA: 0x1812070C0
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_ObjectType() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_ObjectUri() { }

	// RVA: 0x1206E80 Offset: 0x1205480 VA: 0x181206E80 Slot: 3
	public override string ToString() { }

}

