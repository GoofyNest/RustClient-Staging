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

	// RVA: 0x1207A20 Offset: 0x1206020 VA: 0x181207A20
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_ObjectType() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_ObjectUri() { }

	// RVA: 0x12077E0 Offset: 0x1205DE0 VA: 0x1812077E0 Slot: 3
	public override string ToString() { }

}

