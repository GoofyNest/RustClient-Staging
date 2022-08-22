public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 2788
{	// Fields
	private bool reloadable; // 0x10
	private string serializerTypeName; // 0x18
	private string serializerBaseTypeName; // 0x20
	private string typeId; // 0x28

	// Properties
	public override object TypeId { get; }

	// Methods

	// RVA: 0x15D7230 Offset: 0x15D5830 VA: 0x1815D7230
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x15D7290 Offset: 0x15D5890 VA: 0x1815D7290 Slot: 4
	public override object get_TypeId() { }

}

