public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 2693
{	// Fields
	private string category; // 0x10
	private string typeId; // 0x18
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18

	// Properties
	public string Category { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x15C1A10 Offset: 0x15C0010 VA: 0x1815C1A10
	public void .ctor() { }

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string category) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Category() { }

	// RVA: 0x15C1A60 Offset: 0x15C0060 VA: 0x1815C1A60 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x15C1790 Offset: 0x15BFD90 VA: 0x1815C1790 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE1FA0 Offset: 0xDE05A0 VA: 0x180DE1FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C1810 Offset: 0x15BFE10 VA: 0x1815C1810 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C1890 Offset: 0x15BFE90 VA: 0x1815C1890
	private static void .cctor() { }

}

