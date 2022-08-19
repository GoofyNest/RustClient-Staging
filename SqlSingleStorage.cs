internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 4424
{	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x123C710 Offset: 0x123AD10 VA: 0x18123C710
	public void .ctor(DataColumn column) { }

	// RVA: 0x123B120 Offset: 0x1239720 VA: 0x18123B120 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123BEE0 Offset: 0x123A4E0 VA: 0x18123BEE0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123BE30 Offset: 0x123A430 VA: 0x18123BE30 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123C0F0 Offset: 0x123A6F0 VA: 0x18123C0F0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123C420 Offset: 0x123AA20 VA: 0x18123C420 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123C4C0 Offset: 0x123AAC0 VA: 0x18123C4C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123C540 Offset: 0x123AB40 VA: 0x18123C540 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123C6C0 Offset: 0x123ACC0 VA: 0x18123C6C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123C580 Offset: 0x123AB80 VA: 0x18123C580 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123C160 Offset: 0x123A760 VA: 0x18123C160 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123BF40 Offset: 0x123A540 VA: 0x18123BF40 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123C480 Offset: 0x123AA80 VA: 0x18123C480 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123C300 Offset: 0x123A900 VA: 0x18123C300 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123C640 Offset: 0x123AC40 VA: 0x18123C640 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

