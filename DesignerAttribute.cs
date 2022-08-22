public sealed class DesignerAttribute : Attribute // TypeDefIndex: 2692
{	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18
	private string typeId; // 0x20

	// Properties
	public override object TypeId { get; }

	// Methods

	// RVA: 0x15C18B0 Offset: 0x15BFEB0 VA: 0x1815C18B0
	public void .ctor(string designerTypeName) { }

	// RVA: 0x15C17F0 Offset: 0x15BFDF0 VA: 0x1815C17F0
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x15C19A0 Offset: 0x15BFFA0 VA: 0x1815C19A0 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x15C16E0 Offset: 0x15BFCE0 VA: 0x1815C16E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C1790 Offset: 0x15BFD90 VA: 0x1815C1790 Slot: 2
	public override int GetHashCode() { }

}

