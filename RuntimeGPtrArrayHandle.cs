internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 10
{	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1F5670 Offset: 0x1F4A70 VA: 0x1801F5670
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F57C0 Offset: 0x1F4BC0 VA: 0x1801F57C0
	internal int get_Length() { }

	// RVA: 0x1F57B0 Offset: 0x1F4BB0 VA: 0x1801F57B0
	internal IntPtr get_Item(int i) { }

	// RVA: 0x1F57A0 Offset: 0x1F4BA0 VA: 0x1801F57A0
	internal IntPtr Lookup(int i) { }

	// RVA: 0x1637600 Offset: 0x1635C00 VA: 0x181637600
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x16375E0 Offset: 0x1635BE0 VA: 0x1816375E0
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

}

