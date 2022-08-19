public sealed class DesignerAttribute : Attribute // TypeDefIndex: 2692
{	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18
	private string typeId; // 0x20

	// Properties
	public override object TypeId { get; }

	// Methods

	// RVA: 0x15C15F0 Offset: 0x15BFBF0 VA: 0x1815C15F0
	public void .ctor(string designerTypeName) { }

	// RVA: 0x15C1530 Offset: 0x15BFB30 VA: 0x1815C1530
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x15C16E0 Offset: 0x15BFCE0 VA: 0x1815C16E0 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x15C1420 Offset: 0x15BFA20 VA: 0x1815C1420 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C14D0 Offset: 0x15BFAD0 VA: 0x1815C14D0 Slot: 2
	public override int GetHashCode() { }

}

