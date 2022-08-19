internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 1120
{	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x11F5C10 Offset: 0x11F4210 VA: 0x1811F5C10
	public void .ctor() { }

	// RVA: 0x11F5AE0 Offset: 0x11F40E0 VA: 0x1811F5AE0
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x11F57B0 Offset: 0x11F3DB0 VA: 0x1811F57B0 Slot: 4
	public object Clone() { }

	// RVA: 0x11F5C90 Offset: 0x11F4290 VA: 0x1811F5C90
	internal int get_Item(int index) { }

	// RVA: 0x11F5D10 Offset: 0x11F4310 VA: 0x1811F5D10
	internal void set_Item(int index, int value) { }

	// RVA: 0x11F5910 Offset: 0x11F3F10 VA: 0x1811F5910
	internal void IncreaseCapacity(int index) { }

}

