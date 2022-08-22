internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 4424
{	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x123D070 Offset: 0x123B670 VA: 0x18123D070
	public void .ctor(DataColumn column) { }

	// RVA: 0x123BA80 Offset: 0x123A080 VA: 0x18123BA80 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123C840 Offset: 0x123AE40 VA: 0x18123C840 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123C790 Offset: 0x123AD90 VA: 0x18123C790 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123CA50 Offset: 0x123B050 VA: 0x18123CA50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123CD80 Offset: 0x123B380 VA: 0x18123CD80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123CE20 Offset: 0x123B420 VA: 0x18123CE20 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123CEA0 Offset: 0x123B4A0 VA: 0x18123CEA0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123D020 Offset: 0x123B620 VA: 0x18123D020 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123CEE0 Offset: 0x123B4E0 VA: 0x18123CEE0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123CAC0 Offset: 0x123B0C0 VA: 0x18123CAC0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123C8A0 Offset: 0x123AEA0 VA: 0x18123C8A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123CDE0 Offset: 0x123B3E0 VA: 0x18123CDE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123CC60 Offset: 0x123B260 VA: 0x18123CC60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123CFA0 Offset: 0x123B5A0 VA: 0x18123CFA0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

