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

	// RVA: 0x12F0B00 Offset: 0x12EF100 VA: 0x1812F0B00
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x12F0A20 Offset: 0x12EF020 VA: 0x1812F0A20
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x12F0900 Offset: 0x12EEF00 VA: 0x1812F0900
	internal object Push() { }

	// RVA: 0x12F08B0 Offset: 0x12EEEB0 VA: 0x1812F08B0
	internal object Pop() { }

	// RVA: 0x12F0860 Offset: 0x12EEE60 VA: 0x1812F0860
	internal object Peek() { }

	// RVA: 0x12F06D0 Offset: 0x12EECD0 VA: 0x1812F06D0
	internal void AddToTop(object o) { }

	// RVA: 0x12F0B70 Offset: 0x12EF170 VA: 0x1812F0B70
	internal object get_Item(int index) { }

	// RVA: 0x12F0C10 Offset: 0x12EF210 VA: 0x1812F0C10
	internal void set_Item(int index, object value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	internal int get_Length() { }

	// RVA: 0x12F0AA0 Offset: 0x12EF0A0 VA: 0x1812F0AA0
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x12F0760 Offset: 0x12EED60 VA: 0x1812F0760 Slot: 4
	public object Clone() { }

}

