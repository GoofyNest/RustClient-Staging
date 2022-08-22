public class ToolboxItemAttribute : Attribute // TypeDefIndex: 2776
{	// Fields
	private string toolboxItemTypeName; // 0x10
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x1735F70 Offset: 0x1734570 VA: 0x181735F70 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x17361A0 Offset: 0x17347A0 VA: 0x1817361A0
	public void .ctor(bool defaultType) { }

	// RVA: 0x1736110 Offset: 0x1734710 VA: 0x181736110
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x1736200 Offset: 0x1734800 VA: 0x181736200
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x1735E10 Offset: 0x1734410 VA: 0x181735E10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1735F40 Offset: 0x1734540 VA: 0x181735F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1735FE0 Offset: 0x17345E0 VA: 0x181735FE0
	private static void .cctor() { }

}

