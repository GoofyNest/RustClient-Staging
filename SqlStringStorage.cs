internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 4425
{	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x123DB60 Offset: 0x123C160 VA: 0x18123DB60
	public void .ctor(DataColumn column) { }

	// RVA: 0x123CB00 Offset: 0x123B100 VA: 0x18123CB00 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x123D020 Offset: 0x123B620 VA: 0x18123D020 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123D160 Offset: 0x123B760 VA: 0x18123D160
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x123CE80 Offset: 0x123B480 VA: 0x18123CE80 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123D3F0 Offset: 0x123B9F0 VA: 0x18123D3F0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123D7A0 Offset: 0x123BDA0 VA: 0x18123D7A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123D8E0 Offset: 0x123BEE0 VA: 0x18123D8E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123D860 Offset: 0x123BE60 VA: 0x18123D860 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x123D970 Offset: 0x123BF70 VA: 0x18123D970 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123DAF0 Offset: 0x123C0F0 VA: 0x18123DAF0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123D9B0 Offset: 0x123BFB0 VA: 0x18123D9B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123D470 Offset: 0x123BA70 VA: 0x18123D470 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123D240 Offset: 0x123B840 VA: 0x18123D240 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123D820 Offset: 0x123BE20 VA: 0x18123D820 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123D630 Offset: 0x123BC30 VA: 0x18123D630 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123DA70 Offset: 0x123C070 VA: 0x18123DA70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

