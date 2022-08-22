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

	// RVA: 0x1268180 Offset: 0x1266780 VA: 0x181268180 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x12682A0 Offset: 0x12668A0 VA: 0x1812682A0 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x12681D0 Offset: 0x12667D0 VA: 0x1812681D0 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1268320 Offset: 0x1266920 VA: 0x181268320 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x1268230 Offset: 0x1266830 VA: 0x181268230 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1268440 Offset: 0x1266A40 VA: 0x181268440 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1267F30 Offset: 0x1266530 VA: 0x181267F30 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x12680D0 Offset: 0x12666D0 VA: 0x1812680D0 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1267FD0 Offset: 0x12665D0 VA: 0x181267FD0 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1267DD0 Offset: 0x12663D0 VA: 0x181267DD0
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1268100 Offset: 0x1266700 VA: 0x181268100
	public void .ctor() { }

}

