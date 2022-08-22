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

	// RVA: 0x1207380 Offset: 0x1205980 VA: 0x181207380
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_ObjectType() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_ObjectUri() { }

	// RVA: 0x1207140 Offset: 0x1205740 VA: 0x181207140 Slot: 3
	public override string ToString() { }

}

