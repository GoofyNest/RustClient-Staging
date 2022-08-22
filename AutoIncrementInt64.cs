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

	// RVA: 0x12688F0 Offset: 0x1266EF0 VA: 0x1812688F0 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x12689A0 Offset: 0x1266FA0 VA: 0x1812689A0 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1268940 Offset: 0x1266F40 VA: 0x181268940 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1268A10 Offset: 0x1267010 VA: 0x181268A10 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1268B50 Offset: 0x1267150 VA: 0x181268B50 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1268710 Offset: 0x1266D10 VA: 0x181268710 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1268860 Offset: 0x1266E60 VA: 0x181268860 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1268720 Offset: 0x1266D20 VA: 0x181268720 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1268630 Offset: 0x1266C30 VA: 0x181268630
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x12688E0 Offset: 0x1266EE0 VA: 0x1812688E0
	public void .ctor() { }

}

