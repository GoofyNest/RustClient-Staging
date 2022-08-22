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

	// RVA: 0x12F0DC0 Offset: 0x12EF3C0 VA: 0x1812F0DC0
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x12F0CE0 Offset: 0x12EF2E0 VA: 0x1812F0CE0
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x12F0BC0 Offset: 0x12EF1C0 VA: 0x1812F0BC0
	internal object Push() { }

	// RVA: 0x12F0B70 Offset: 0x12EF170 VA: 0x1812F0B70
	internal object Pop() { }

	// RVA: 0x12F0B20 Offset: 0x12EF120 VA: 0x1812F0B20
	internal object Peek() { }

	// RVA: 0x12F0990 Offset: 0x12EEF90 VA: 0x1812F0990
	internal void AddToTop(object o) { }

	// RVA: 0x12F0E30 Offset: 0x12EF430 VA: 0x1812F0E30
	internal object get_Item(int index) { }

	// RVA: 0x12F0ED0 Offset: 0x12EF4D0 VA: 0x1812F0ED0
	internal void set_Item(int index, object value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	internal int get_Length() { }

	// RVA: 0x12F0D60 Offset: 0x12EF360 VA: 0x1812F0D60
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x12F0A20 Offset: 0x12EF020 VA: 0x1812F0A20 Slot: 4
	public object Clone() { }

}

