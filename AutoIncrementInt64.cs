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

	// RVA: 0x1267F90 Offset: 0x1266590 VA: 0x181267F90 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1268040 Offset: 0x1266640 VA: 0x181268040 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1267FE0 Offset: 0x12665E0 VA: 0x181267FE0 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x12680B0 Offset: 0x12666B0 VA: 0x1812680B0 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x12681F0 Offset: 0x12667F0 VA: 0x1812681F0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1267DB0 Offset: 0x12663B0 VA: 0x181267DB0 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1267F00 Offset: 0x1266500 VA: 0x181267F00 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1267DC0 Offset: 0x12663C0 VA: 0x181267DC0 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1267CD0 Offset: 0x12662D0 VA: 0x181267CD0
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1267F80 Offset: 0x1266580 VA: 0x181267F80
	public void .ctor() { }

}

