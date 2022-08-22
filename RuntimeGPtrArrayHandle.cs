internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 10
{	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1F6820 Offset: 0x1F5C20 VA: 0x1801F6820
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F6970 Offset: 0x1F5D70 VA: 0x1801F6970
	internal int get_Length() { }

	// RVA: 0x1F6960 Offset: 0x1F5D60 VA: 0x1801F6960
	internal IntPtr get_Item(int i) { }

	// RVA: 0x1F6950 Offset: 0x1F5D50 VA: 0x1801F6950
	internal IntPtr Lookup(int i) { }

	// RVA: 0x164A2E0 Offset: 0x16488E0 VA: 0x18164A2E0
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x164A2C0 Offset: 0x16488C0 VA: 0x18164A2C0
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

}

