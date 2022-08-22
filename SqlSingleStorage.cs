internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 4424
{	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x123C9D0 Offset: 0x123AFD0 VA: 0x18123C9D0
	public void .ctor(DataColumn column) { }

	// RVA: 0x123B3E0 Offset: 0x12399E0 VA: 0x18123B3E0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123C1A0 Offset: 0x123A7A0 VA: 0x18123C1A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123C0F0 Offset: 0x123A6F0 VA: 0x18123C0F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123C3B0 Offset: 0x123A9B0 VA: 0x18123C3B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123C6E0 Offset: 0x123ACE0 VA: 0x18123C6E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123C780 Offset: 0x123AD80 VA: 0x18123C780 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123C800 Offset: 0x123AE00 VA: 0x18123C800 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123C980 Offset: 0x123AF80 VA: 0x18123C980 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123C840 Offset: 0x123AE40 VA: 0x18123C840 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123C420 Offset: 0x123AA20 VA: 0x18123C420 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123C200 Offset: 0x123A800 VA: 0x18123C200 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123C740 Offset: 0x123AD40 VA: 0x18123C740 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123C5C0 Offset: 0x123ABC0 VA: 0x18123C5C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123C900 Offset: 0x123AF00 VA: 0x18123C900 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

