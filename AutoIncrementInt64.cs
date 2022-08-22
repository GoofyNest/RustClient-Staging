internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 4183
{	// Fields
	private long _current; // 0x18
	private long _seed; // 0x20
	private long _step; // 0x28

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1268250 Offset: 0x1266850 VA: 0x181268250 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1268300 Offset: 0x1266900 VA: 0x181268300 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x12682A0 Offset: 0x12668A0 VA: 0x1812682A0 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1268370 Offset: 0x1266970 VA: 0x181268370 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x12684B0 Offset: 0x1266AB0 VA: 0x1812684B0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1268070 Offset: 0x1266670 VA: 0x181268070 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x12681C0 Offset: 0x12667C0 VA: 0x1812681C0 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1268080 Offset: 0x1266680 VA: 0x181268080 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1267F90 Offset: 0x1266590 VA: 0x181267F90
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1268240 Offset: 0x1266840 VA: 0x181268240
	public void .ctor() { }

}

