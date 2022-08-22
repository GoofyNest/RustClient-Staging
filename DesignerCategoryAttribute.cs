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

	// RVA: 0x15C1CD0 Offset: 0x15C02D0 VA: 0x1815C1CD0
	public void .ctor() { }

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string category) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Category() { }

	// RVA: 0x15C1D20 Offset: 0x15C0320 VA: 0x1815C1D20 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x15C1A50 Offset: 0x15C0050 VA: 0x1815C1A50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2260 Offset: 0xDE0860 VA: 0x180DE2260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C1AD0 Offset: 0x15C00D0 VA: 0x1815C1AD0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C1B50 Offset: 0x15C0150 VA: 0x1815C1B50
	private static void .cctor() { }

}

