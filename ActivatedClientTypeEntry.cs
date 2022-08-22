public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 1127
{	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0xFDB0B0 Offset: 0xFD96B0 VA: 0x180FDB0B0
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_ApplicationUrl() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Type get_ObjectType() { }

	// RVA: 0xFDB090 Offset: 0xFD9690 VA: 0x180FDB090 Slot: 3
	public override string ToString() { }

}

