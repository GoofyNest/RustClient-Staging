internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 10
{	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1F68A0 Offset: 0x1F5CA0 VA: 0x1801F68A0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F69F0 Offset: 0x1F5DF0 VA: 0x1801F69F0
	internal int get_Length() { }

	// RVA: 0x1F69E0 Offset: 0x1F5DE0 VA: 0x1801F69E0
	internal IntPtr get_Item(int i) { }

	// RVA: 0x1F69D0 Offset: 0x1F5DD0 VA: 0x1801F69D0
	internal IntPtr Lookup(int i) { }

	// RVA: 0x164A020 Offset: 0x1648620 VA: 0x18164A020
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x164A000 Offset: 0x1648600 VA: 0x18164A000
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

}

