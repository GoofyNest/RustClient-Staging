internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 4420
{	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x17EA760 Offset: 0x17E8D60 VA: 0x1817EA760
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E9160 Offset: 0x17E7760 VA: 0x1817E9160 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E9F40 Offset: 0x17E8540 VA: 0x1817E9F40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E9E90 Offset: 0x17E8490 VA: 0x1817E9E90 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17EA150 Offset: 0x17E8750 VA: 0x1817EA150 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17EA470 Offset: 0x17E8A70 VA: 0x1817EA470 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17EA510 Offset: 0x17E8B10 VA: 0x1817EA510 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17EA590 Offset: 0x17E8B90 VA: 0x1817EA590 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17EA710 Offset: 0x17E8D10 VA: 0x1817EA710 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17EA5D0 Offset: 0x17E8BD0 VA: 0x1817EA5D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17EA1C0 Offset: 0x17E87C0 VA: 0x1817EA1C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E9FA0 Offset: 0x17E85A0 VA: 0x1817E9FA0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17EA4D0 Offset: 0x17E8AD0 VA: 0x1817EA4D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17EA350 Offset: 0x17E8950 VA: 0x1817EA350 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17EA690 Offset: 0x17E8C90 VA: 0x1817EA690 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

