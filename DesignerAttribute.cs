public sealed class DesignerAttribute : Attribute // TypeDefIndex: 2692
{	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18
	private string typeId; // 0x20

	// Properties
	public override object TypeId { get; }

	// Methods

	// RVA: 0x15C0980 Offset: 0x15BEF80 VA: 0x1815C0980
	public void .ctor(string designerTypeName) { }

	// RVA: 0x15C08C0 Offset: 0x15BEEC0 VA: 0x1815C08C0
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x15C0A70 Offset: 0x15BF070 VA: 0x1815C0A70 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x15C07B0 Offset: 0x15BEDB0 VA: 0x1815C07B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0860 Offset: 0x15BEE60 VA: 0x1815C0860 Slot: 2
	public override int GetHashCode() { }

}

