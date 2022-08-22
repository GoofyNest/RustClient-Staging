public class ToolboxItemAttribute : Attribute // TypeDefIndex: 2776
{	// Fields
	private string toolboxItemTypeName; // 0x10
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x1733B30 Offset: 0x1732130 VA: 0x181733B30 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1733D60 Offset: 0x1732360 VA: 0x181733D60
	public void .ctor(bool defaultType) { }

	// RVA: 0x1733CD0 Offset: 0x17322D0 VA: 0x181733CD0
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x1733DC0 Offset: 0x17323C0 VA: 0x181733DC0
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x17339D0 Offset: 0x1731FD0 VA: 0x1817339D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1733B00 Offset: 0x1732100 VA: 0x181733B00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1733BA0 Offset: 0x17321A0 VA: 0x181733BA0
	private static void .cctor() { }

}

