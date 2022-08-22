internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 4422
{	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x17ED5C0 Offset: 0x17EBBC0 VA: 0x1817ED5C0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17EBF30 Offset: 0x17EA530 VA: 0x1817EBF30 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17ECDA0 Offset: 0x17EB3A0 VA: 0x1817ECDA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17ECCF0 Offset: 0x17EB2F0 VA: 0x1817ECCF0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17ECFD0 Offset: 0x17EB5D0 VA: 0x1817ECFD0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123AF80 Offset: 0x1239580 VA: 0x18123AF80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17ED3A0 Offset: 0x17EB9A0 VA: 0x1817ED3A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123B0B0 Offset: 0x12396B0 VA: 0x18123B0B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17ED560 Offset: 0x17EBB60 VA: 0x1817ED560 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17ED420 Offset: 0x17EBA20 VA: 0x1817ED420 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17ED050 Offset: 0x17EB650 VA: 0x1817ED050 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17ECE20 Offset: 0x17EB420 VA: 0x1817ECE20 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17ED360 Offset: 0x17EB960 VA: 0x1817ED360 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17ED210 Offset: 0x17EB810 VA: 0x1817ED210 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17ED4E0 Offset: 0x17EBAE0 VA: 0x1817ED4E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

