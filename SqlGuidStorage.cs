internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 4419
{	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x17E9030 Offset: 0x17E7630 VA: 0x1817E9030
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E8600 Offset: 0x17E6C00 VA: 0x1817E8600 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E8870 Offset: 0x17E6E70 VA: 0x1817E8870 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E87C0 Offset: 0x17E6DC0 VA: 0x1817E87C0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E8A80 Offset: 0x17E7080 VA: 0x1817E8A80 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D9AB0 Offset: 0x17D80B0 VA: 0x1817D9AB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E8E10 Offset: 0x17E7410 VA: 0x1817E8E10 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D9BE0 Offset: 0x17D81E0 VA: 0x1817D9BE0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E8FD0 Offset: 0x17E75D0 VA: 0x1817E8FD0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E8E90 Offset: 0x17E7490 VA: 0x1817E8E90 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E8AF0 Offset: 0x17E70F0 VA: 0x1817E8AF0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E88D0 Offset: 0x17E6ED0 VA: 0x1817E88D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E8DD0 Offset: 0x17E73D0 VA: 0x1817E8DD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E8C90 Offset: 0x17E7290 VA: 0x1817E8C90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E8F50 Offset: 0x17E7550 VA: 0x1817E8F50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

