internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 4184
{	// Fields
	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1267820 Offset: 0x1265E20 VA: 0x181267820 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1267940 Offset: 0x1265F40 VA: 0x181267940 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1267870 Offset: 0x1265E70 VA: 0x181267870 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x12679C0 Offset: 0x1265FC0 VA: 0x1812679C0 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x12678D0 Offset: 0x1265ED0 VA: 0x1812678D0 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1267AE0 Offset: 0x12660E0 VA: 0x181267AE0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x12675D0 Offset: 0x1265BD0 VA: 0x1812675D0 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1267770 Offset: 0x1265D70 VA: 0x181267770 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1267670 Offset: 0x1265C70 VA: 0x181267670 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1267470 Offset: 0x1265A70 VA: 0x181267470
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x12677A0 Offset: 0x1265DA0 VA: 0x1812677A0
	public void .ctor() { }

}

