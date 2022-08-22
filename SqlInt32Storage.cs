internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 4421
{	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x17EBE00 Offset: 0x17EA400 VA: 0x1817EBE00
	public void .ctor(DataColumn column) { }

	// RVA: 0x17EA890 Offset: 0x17E8E90 VA: 0x1817EA890 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17EB670 Offset: 0x17E9C70 VA: 0x1817EB670 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17EB5C0 Offset: 0x17E9BC0 VA: 0x1817EB5C0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17EB880 Offset: 0x17E9E80 VA: 0x1817EB880 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123C6E0 Offset: 0x123ACE0 VA: 0x18123C6E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17EBBF0 Offset: 0x17EA1F0 VA: 0x1817EBBF0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123C800 Offset: 0x123AE00 VA: 0x18123C800 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17EBDB0 Offset: 0x17EA3B0 VA: 0x1817EBDB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17EBC70 Offset: 0x17EA270 VA: 0x1817EBC70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17EB8F0 Offset: 0x17E9EF0 VA: 0x1817EB8F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17EB6D0 Offset: 0x17E9CD0 VA: 0x1817EB6D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17EBBB0 Offset: 0x17EA1B0 VA: 0x1817EBBB0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17EBA90 Offset: 0x17EA090 VA: 0x1817EBA90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17EBD30 Offset: 0x17EA330 VA: 0x1817EBD30 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

