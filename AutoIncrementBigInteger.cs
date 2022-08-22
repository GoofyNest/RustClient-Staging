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

	// RVA: 0x1267AE0 Offset: 0x12660E0 VA: 0x181267AE0 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1267C00 Offset: 0x1266200 VA: 0x181267C00 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1267B30 Offset: 0x1266130 VA: 0x181267B30 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1267C80 Offset: 0x1266280 VA: 0x181267C80 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x1267B90 Offset: 0x1266190 VA: 0x181267B90 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1267DA0 Offset: 0x12663A0 VA: 0x181267DA0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1267890 Offset: 0x1265E90 VA: 0x181267890 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1267A30 Offset: 0x1266030 VA: 0x181267A30 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1267930 Offset: 0x1265F30 VA: 0x181267930 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1267730 Offset: 0x1265D30 VA: 0x181267730
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1267A60 Offset: 0x1266060 VA: 0x181267A60
	public void .ctor() { }

}

