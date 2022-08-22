internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 4422
{	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x17EB110 Offset: 0x17E9710 VA: 0x1817EB110
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E9A80 Offset: 0x17E8080 VA: 0x1817E9A80 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17EA8F0 Offset: 0x17E8EF0 VA: 0x1817EA8F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17EA840 Offset: 0x17E8E40 VA: 0x1817EA840 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17EAB20 Offset: 0x17E9120 VA: 0x1817EAB20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123B620 Offset: 0x1239C20 VA: 0x18123B620 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17EAEF0 Offset: 0x17E94F0 VA: 0x1817EAEF0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123B750 Offset: 0x1239D50 VA: 0x18123B750 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17EB0B0 Offset: 0x17E96B0 VA: 0x1817EB0B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17EAF70 Offset: 0x17E9570 VA: 0x1817EAF70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17EABA0 Offset: 0x17E91A0 VA: 0x1817EABA0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17EA970 Offset: 0x17E8F70 VA: 0x1817EA970 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17EAEB0 Offset: 0x17E94B0 VA: 0x1817EAEB0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17EAD60 Offset: 0x17E9360 VA: 0x1817EAD60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17EB030 Offset: 0x17E9630 VA: 0x1817EB030 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

