internal class HWStack : ICloneable // TypeDefIndex: 1984
{	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Properties
	internal object Item { get; set; }
	internal int Length { get; }

	// Methods

	// RVA: 0x12F7270 Offset: 0x12F5870 VA: 0x1812F7270
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x12F7190 Offset: 0x12F5790 VA: 0x1812F7190
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x12F7070 Offset: 0x12F5670 VA: 0x1812F7070
	internal object Push() { }

	// RVA: 0x12F7020 Offset: 0x12F5620 VA: 0x1812F7020
	internal object Pop() { }

	// RVA: 0x12F6FD0 Offset: 0x12F55D0 VA: 0x1812F6FD0
	internal object Peek() { }

	// RVA: 0x12F6E40 Offset: 0x12F5440 VA: 0x1812F6E40
	internal void AddToTop(object o) { }

	// RVA: 0x12F72E0 Offset: 0x12F58E0 VA: 0x1812F72E0
	internal object get_Item(int index) { }

	// RVA: 0x12F7380 Offset: 0x12F5980 VA: 0x1812F7380
	internal void set_Item(int index, object value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	internal int get_Length() { }

	// RVA: 0x12F7210 Offset: 0x12F5810 VA: 0x1812F7210
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x12F6ED0 Offset: 0x12F54D0 VA: 0x1812F6ED0 Slot: 4
	public object Clone() { }

}

