public class ToolboxItemAttribute : Attribute // TypeDefIndex: 2776
{	// Fields
	private string toolboxItemTypeName; // 0x10
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x1735CB0 Offset: 0x17342B0 VA: 0x181735CB0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1735EE0 Offset: 0x17344E0 VA: 0x181735EE0
	public void .ctor(bool defaultType) { }

	// RVA: 0x1735E50 Offset: 0x1734450 VA: 0x181735E50
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x1735F40 Offset: 0x1734540 VA: 0x181735F40
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x1735B50 Offset: 0x1734150 VA: 0x181735B50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1735C80 Offset: 0x1734280 VA: 0x181735C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1735D20 Offset: 0x1734320 VA: 0x181735D20
	private static void .cctor() { }

}

