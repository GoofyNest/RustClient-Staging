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

	// RVA: 0x1206D30 Offset: 0x1205330 VA: 0x181206D30
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_ApplicationUrl() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_ObjectType() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_ObjectUrl() { }

	// RVA: 0x1206CF0 Offset: 0x12052F0 VA: 0x181206CF0 Slot: 3
	public override string ToString() { }

}

