public sealed class ContextMenu : Attribute // TypeDefIndex: 3497
{	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x1826910 Offset: 0x1824F10 VA: 0x181826910
	public void .ctor(string itemName) { }

	// RVA: 0x1826950 Offset: 0x1824F50 VA: 0x181826950
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x18269A0 Offset: 0x1824FA0 VA: 0x1818269A0
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

