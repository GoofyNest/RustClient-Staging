internal sealed class Int16Storage : DataStorage // TypeDefIndex: 4403
{	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x17D1240 Offset: 0x17CF840 VA: 0x1817D1240
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17D02C0 Offset: 0x17CE8C0 VA: 0x1817D02C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D0B30 Offset: 0x17CF130 VA: 0x1817D0B30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D0A20 Offset: 0x17CF020 VA: 0x1817D0A20 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D0C40 Offset: 0x17CF240 VA: 0x1817D0C40 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x12421B0 Offset: 0x12407B0 VA: 0x1812421B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D0EF0 Offset: 0x17CF4F0 VA: 0x1817D0EF0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D1110 Offset: 0x17CF710 VA: 0x1817D1110 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D0F90 Offset: 0x17CF590 VA: 0x1817D0F90 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D0D20 Offset: 0x17CF320 VA: 0x1817D0D20 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D0BC0 Offset: 0x17CF1C0 VA: 0x1817D0BC0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D0EB0 Offset: 0x17CF4B0 VA: 0x1817D0EB0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D0D90 Offset: 0x17CF390 VA: 0x1817D0D90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D1070 Offset: 0x17CF670 VA: 0x1817D1070 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

