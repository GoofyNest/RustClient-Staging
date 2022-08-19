internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 4422
{	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x17ED300 Offset: 0x17EB900 VA: 0x1817ED300
	public void .ctor(DataColumn column) { }

	// RVA: 0x17EBC70 Offset: 0x17EA270 VA: 0x1817EBC70 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17ECAE0 Offset: 0x17EB0E0 VA: 0x1817ECAE0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17ECA30 Offset: 0x17EB030 VA: 0x1817ECA30 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17ECD10 Offset: 0x17EB310 VA: 0x1817ECD10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123ACC0 Offset: 0x12392C0 VA: 0x18123ACC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17ED0E0 Offset: 0x17EB6E0 VA: 0x1817ED0E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123ADF0 Offset: 0x12393F0 VA: 0x18123ADF0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17ED2A0 Offset: 0x17EB8A0 VA: 0x1817ED2A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17ED160 Offset: 0x17EB760 VA: 0x1817ED160 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17ECD90 Offset: 0x17EB390 VA: 0x1817ECD90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17ECB60 Offset: 0x17EB160 VA: 0x1817ECB60 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17ED0A0 Offset: 0x17EB6A0 VA: 0x1817ED0A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17ECF50 Offset: 0x17EB550 VA: 0x1817ECF50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17ED220 Offset: 0x17EB820 VA: 0x1817ED220 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

