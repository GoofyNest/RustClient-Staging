public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 1127
{	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0xFDA350 Offset: 0xFD8950 VA: 0x180FDA350
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_ApplicationUrl() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Type get_ObjectType() { }

	// RVA: 0xFDA330 Offset: 0xFD8930 VA: 0x180FDA330 Slot: 3
	public override string ToString() { }

}

