public sealed class ContextMenu : Attribute // TypeDefIndex: 3497
{	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x1814010 Offset: 0x1812610 VA: 0x181814010
	public void .ctor(string itemName) { }

	// RVA: 0x1814050 Offset: 0x1812650 VA: 0x181814050
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x18140A0 Offset: 0x18126A0 VA: 0x1818140A0
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

