public sealed class ContextMenu : Attribute // TypeDefIndex: 3497
{	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x1826BD0 Offset: 0x18251D0 VA: 0x181826BD0
	public void .ctor(string itemName) { }

	// RVA: 0x1826C10 Offset: 0x1825210 VA: 0x181826C10
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x1826C60 Offset: 0x1825260 VA: 0x181826C60
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

