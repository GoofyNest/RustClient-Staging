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

	// RVA: 0x15C0DA0 Offset: 0x15BF3A0 VA: 0x1815C0DA0
	public void .ctor() { }

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string category) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Category() { }

	// RVA: 0x15C0DF0 Offset: 0x15BF3F0 VA: 0x1815C0DF0 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x15C0B20 Offset: 0x15BF120 VA: 0x1815C0B20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2D10 Offset: 0xDE1310 VA: 0x180DE2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C0BA0 Offset: 0x15BF1A0 VA: 0x1815C0BA0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C0C20 Offset: 0x15BF220 VA: 0x1815C0C20
	private static void .cctor() { }

}

