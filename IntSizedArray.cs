internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 1120
{	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x11F6570 Offset: 0x11F4B70 VA: 0x1811F6570
	public void .ctor() { }

	// RVA: 0x11F6440 Offset: 0x11F4A40 VA: 0x1811F6440
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x11F6110 Offset: 0x11F4710 VA: 0x1811F6110 Slot: 4
	public object Clone() { }

	// RVA: 0x11F65F0 Offset: 0x11F4BF0 VA: 0x1811F65F0
	internal int get_Item(int index) { }

	// RVA: 0x11F6670 Offset: 0x11F4C70 VA: 0x1811F6670
	internal void set_Item(int index, int value) { }

	// RVA: 0x11F6270 Offset: 0x11F4870 VA: 0x1811F6270
	internal void IncreaseCapacity(int index) { }

}

