internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 4418
{	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x17E84C0 Offset: 0x17E6AC0 VA: 0x1817E84C0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E6F20 Offset: 0x17E5520 VA: 0x1817E6F20 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E7CA0 Offset: 0x17E62A0 VA: 0x1817E7CA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E7BF0 Offset: 0x17E61F0 VA: 0x1817E7BF0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E7ED0 Offset: 0x17E64D0 VA: 0x1817E7ED0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123AF80 Offset: 0x1239580 VA: 0x18123AF80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E82A0 Offset: 0x17E68A0 VA: 0x1817E82A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123B0B0 Offset: 0x12396B0 VA: 0x18123B0B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E8460 Offset: 0x17E6A60 VA: 0x1817E8460 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E8320 Offset: 0x17E6920 VA: 0x1817E8320 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E7F50 Offset: 0x17E6550 VA: 0x1817E7F50 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E7D20 Offset: 0x17E6320 VA: 0x1817E7D20 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E8260 Offset: 0x17E6860 VA: 0x1817E8260 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E8110 Offset: 0x17E6710 VA: 0x1817E8110 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E83E0 Offset: 0x17E69E0 VA: 0x1817E83E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

