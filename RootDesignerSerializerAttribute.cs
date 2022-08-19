public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 2788
{	// Fields
	private bool reloadable; // 0x10
	private string serializerTypeName; // 0x18
	private string serializerBaseTypeName; // 0x20
	private string typeId; // 0x28

	// Properties
	public override object TypeId { get; }

	// Methods

	// RVA: 0x15D6F70 Offset: 0x15D5570 VA: 0x1815D6F70
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x15D6FD0 Offset: 0x15D55D0 VA: 0x1815D6FD0 Slot: 4
	public override object get_TypeId() { }

}

