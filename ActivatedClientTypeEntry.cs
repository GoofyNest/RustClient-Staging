public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 1127
{	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0xFDA610 Offset: 0xFD8C10 VA: 0x180FDA610
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_ApplicationUrl() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Type get_ObjectType() { }

	// RVA: 0xFDA5F0 Offset: 0xFD8BF0 VA: 0x180FDA5F0 Slot: 3
	public override string ToString() { }

}

