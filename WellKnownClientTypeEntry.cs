public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 1154
{	// Fields
	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	// Properties
	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }

	// Methods

	// RVA: 0x1207690 Offset: 0x1205C90 VA: 0x181207690
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_ApplicationUrl() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_ObjectType() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_ObjectUrl() { }

	// RVA: 0x1207650 Offset: 0x1205C50 VA: 0x181207650 Slot: 3
	public override string ToString() { }

}

