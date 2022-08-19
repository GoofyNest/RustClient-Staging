internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 4421
{	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x17EBB40 Offset: 0x17EA140 VA: 0x1817EBB40
	public void .ctor(DataColumn column) { }

	// RVA: 0x17EA5D0 Offset: 0x17E8BD0 VA: 0x1817EA5D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17EB3B0 Offset: 0x17E99B0 VA: 0x1817EB3B0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17EB300 Offset: 0x17E9900 VA: 0x1817EB300 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17EB5C0 Offset: 0x17E9BC0 VA: 0x1817EB5C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123C420 Offset: 0x123AA20 VA: 0x18123C420 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17EB930 Offset: 0x17E9F30 VA: 0x1817EB930 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123C540 Offset: 0x123AB40 VA: 0x18123C540 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17EBAF0 Offset: 0x17EA0F0 VA: 0x1817EBAF0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17EB9B0 Offset: 0x17E9FB0 VA: 0x1817EB9B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17EB630 Offset: 0x17E9C30 VA: 0x1817EB630 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17EB410 Offset: 0x17E9A10 VA: 0x1817EB410 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17EB8F0 Offset: 0x17E9EF0 VA: 0x1817EB8F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17EB7D0 Offset: 0x17E9DD0 VA: 0x1817EB7D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17EBA70 Offset: 0x17EA070 VA: 0x1817EBA70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

