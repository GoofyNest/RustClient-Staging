internal sealed class SByteStorage : DataStorage // TypeDefIndex: 4410
{	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x17D7D00 Offset: 0x17D6300 VA: 0x1817D7D00
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D6CD0 Offset: 0x17D52D0 VA: 0x1817D6CD0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D7530 Offset: 0x17D5B30 VA: 0x1817D7530 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D7410 Offset: 0x17D5A10 VA: 0x1817D7410 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D7680 Offset: 0x17D5C80 VA: 0x1817D7680 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D78E0 Offset: 0x17D5EE0 VA: 0x1817D78E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D79A0 Offset: 0x17D5FA0 VA: 0x1817D79A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D7BD0 Offset: 0x17D61D0 VA: 0x1817D7BD0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D7A50 Offset: 0x17D6050 VA: 0x1817D7A50 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D7750 Offset: 0x17D5D50 VA: 0x1817D7750 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D7600 Offset: 0x17D5C00 VA: 0x1817D7600 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D7960 Offset: 0x17D5F60 VA: 0x1817D7960 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D77C0 Offset: 0x17D5DC0 VA: 0x1817D77C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D7B30 Offset: 0x17D6130 VA: 0x1817D7B30 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

