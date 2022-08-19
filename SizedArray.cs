internal sealed class SizedArray : ICloneable // TypeDefIndex: 1119
{	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x1203FA0 Offset: 0x12025A0 VA: 0x181203FA0
	internal void .ctor() { }

	// RVA: 0x1203F20 Offset: 0x1202520 VA: 0x181203F20
	internal void .ctor(int length) { }

	// RVA: 0x1204020 Offset: 0x1202620 VA: 0x181204020
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x1203C40 Offset: 0x1202240 VA: 0x181203C40 Slot: 4
	public object Clone() { }

	// RVA: 0x1204100 Offset: 0x1202700 VA: 0x181204100
	internal object get_Item(int index) { }

	// RVA: 0x1204180 Offset: 0x1202780 VA: 0x181204180
	internal void set_Item(int index, object value) { }

	// RVA: 0x1203D50 Offset: 0x1202350 VA: 0x181203D50
	internal void IncreaseCapacity(int index) { }

}

