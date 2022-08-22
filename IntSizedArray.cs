internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 1120
{	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x11F5ED0 Offset: 0x11F44D0 VA: 0x1811F5ED0
	public void .ctor() { }

	// RVA: 0x11F5DA0 Offset: 0x11F43A0 VA: 0x1811F5DA0
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x11F5A70 Offset: 0x11F4070 VA: 0x1811F5A70 Slot: 4
	public object Clone() { }

	// RVA: 0x11F5F50 Offset: 0x11F4550 VA: 0x1811F5F50
	internal int get_Item(int index) { }

	// RVA: 0x11F5FD0 Offset: 0x11F45D0 VA: 0x1811F5FD0
	internal void set_Item(int index, int value) { }

	// RVA: 0x11F5BD0 Offset: 0x11F41D0 VA: 0x1811F5BD0
	internal void IncreaseCapacity(int index) { }

}

