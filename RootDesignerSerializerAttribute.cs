public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 2788
{	// Fields
	private bool reloadable; // 0x10
	private string serializerTypeName; // 0x18
	private string serializerBaseTypeName; // 0x20
	private string typeId; // 0x28

	// Properties
	public override object TypeId { get; }

	// Methods

	// RVA: 0x15D6300 Offset: 0x15D4900 VA: 0x1815D6300
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x15D6360 Offset: 0x15D4960 VA: 0x1815D6360 Slot: 4
	public override object get_TypeId() { }

}

