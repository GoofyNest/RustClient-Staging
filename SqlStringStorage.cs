internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 4425
{	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x123E200 Offset: 0x123C800 VA: 0x18123E200
	public void .ctor(DataColumn column) { }

	// RVA: 0x123D1A0 Offset: 0x123B7A0 VA: 0x18123D1A0 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x123D6C0 Offset: 0x123BCC0 VA: 0x18123D6C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123D800 Offset: 0x123BE00 VA: 0x18123D800
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x123D520 Offset: 0x123BB20 VA: 0x18123D520 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123DA90 Offset: 0x123C090 VA: 0x18123DA90 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123DE40 Offset: 0x123C440 VA: 0x18123DE40 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123DF80 Offset: 0x123C580 VA: 0x18123DF80 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123DF00 Offset: 0x123C500 VA: 0x18123DF00 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x123E010 Offset: 0x123C610 VA: 0x18123E010 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123E190 Offset: 0x123C790 VA: 0x18123E190 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123E050 Offset: 0x123C650 VA: 0x18123E050 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123DB10 Offset: 0x123C110 VA: 0x18123DB10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123D8E0 Offset: 0x123BEE0 VA: 0x18123D8E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123DEC0 Offset: 0x123C4C0 VA: 0x18123DEC0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123DCD0 Offset: 0x123C2D0 VA: 0x18123DCD0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123E110 Offset: 0x123C710 VA: 0x18123E110 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

