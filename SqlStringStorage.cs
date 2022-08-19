internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 4425
{	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x123D8A0 Offset: 0x123BEA0 VA: 0x18123D8A0
	public void .ctor(DataColumn column) { }

	// RVA: 0x123C840 Offset: 0x123AE40 VA: 0x18123C840 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x123CD60 Offset: 0x123B360 VA: 0x18123CD60 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123CEA0 Offset: 0x123B4A0 VA: 0x18123CEA0
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x123CBC0 Offset: 0x123B1C0 VA: 0x18123CBC0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123D130 Offset: 0x123B730 VA: 0x18123D130 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123D4E0 Offset: 0x123BAE0 VA: 0x18123D4E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123D620 Offset: 0x123BC20 VA: 0x18123D620 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123D5A0 Offset: 0x123BBA0 VA: 0x18123D5A0 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x123D6B0 Offset: 0x123BCB0 VA: 0x18123D6B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123D830 Offset: 0x123BE30 VA: 0x18123D830 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123D6F0 Offset: 0x123BCF0 VA: 0x18123D6F0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123D1B0 Offset: 0x123B7B0 VA: 0x18123D1B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123CF80 Offset: 0x123B580 VA: 0x18123CF80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123D560 Offset: 0x123BB60 VA: 0x18123D560 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123D370 Offset: 0x123B970 VA: 0x18123D370 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123D7B0 Offset: 0x123BDB0 VA: 0x18123D7B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

