internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 4419
{	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x17E8D70 Offset: 0x17E7370 VA: 0x1817E8D70
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E8340 Offset: 0x17E6940 VA: 0x1817E8340 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E85B0 Offset: 0x17E6BB0 VA: 0x1817E85B0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E8500 Offset: 0x17E6B00 VA: 0x1817E8500 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E87C0 Offset: 0x17E6DC0 VA: 0x1817E87C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D97F0 Offset: 0x17D7DF0 VA: 0x1817D97F0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E8B50 Offset: 0x17E7150 VA: 0x1817E8B50 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D9920 Offset: 0x17D7F20 VA: 0x1817D9920 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E8D10 Offset: 0x17E7310 VA: 0x1817E8D10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E8BD0 Offset: 0x17E71D0 VA: 0x1817E8BD0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E8830 Offset: 0x17E6E30 VA: 0x1817E8830 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E8610 Offset: 0x17E6C10 VA: 0x1817E8610 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E8B10 Offset: 0x17E7110 VA: 0x1817E8B10 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E89D0 Offset: 0x17E6FD0 VA: 0x1817E89D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E8C90 Offset: 0x17E7290 VA: 0x1817E8C90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

