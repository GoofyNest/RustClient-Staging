internal sealed class SizedArray : ICloneable // TypeDefIndex: 1119
{	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x1204900 Offset: 0x1202F00 VA: 0x181204900
	internal void .ctor() { }

	// RVA: 0x1204880 Offset: 0x1202E80 VA: 0x181204880
	internal void .ctor(int length) { }

	// RVA: 0x1204980 Offset: 0x1202F80 VA: 0x181204980
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x12045A0 Offset: 0x1202BA0 VA: 0x1812045A0 Slot: 4
	public object Clone() { }

	// RVA: 0x1204A60 Offset: 0x1203060 VA: 0x181204A60
	internal object get_Item(int index) { }

	// RVA: 0x1204AE0 Offset: 0x12030E0 VA: 0x181204AE0
	internal void set_Item(int index, object value) { }

	// RVA: 0x12046B0 Offset: 0x1202CB0 VA: 0x1812046B0
	internal void IncreaseCapacity(int index) { }

}

