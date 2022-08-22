internal sealed class SizedArray : ICloneable // TypeDefIndex: 1119
{	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x1204260 Offset: 0x1202860 VA: 0x181204260
	internal void .ctor() { }

	// RVA: 0x12041E0 Offset: 0x12027E0 VA: 0x1812041E0
	internal void .ctor(int length) { }

	// RVA: 0x12042E0 Offset: 0x12028E0 VA: 0x1812042E0
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x1203F00 Offset: 0x1202500 VA: 0x181203F00 Slot: 4
	public object Clone() { }

	// RVA: 0x12043C0 Offset: 0x12029C0 VA: 0x1812043C0
	internal object get_Item(int index) { }

	// RVA: 0x1204440 Offset: 0x1202A40 VA: 0x181204440
	internal void set_Item(int index, object value) { }

	// RVA: 0x1204010 Offset: 0x1202610 VA: 0x181204010
	internal void IncreaseCapacity(int index) { }

}

