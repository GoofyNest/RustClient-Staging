internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 4421
{	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x17E9950 Offset: 0x17E7F50 VA: 0x1817E9950
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E83E0 Offset: 0x17E69E0 VA: 0x1817E83E0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E91C0 Offset: 0x17E77C0 VA: 0x1817E91C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E9110 Offset: 0x17E7710 VA: 0x1817E9110 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E93D0 Offset: 0x17E79D0 VA: 0x1817E93D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123CD80 Offset: 0x123B380 VA: 0x18123CD80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E9740 Offset: 0x17E7D40 VA: 0x1817E9740 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123CEA0 Offset: 0x123B4A0 VA: 0x18123CEA0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E9900 Offset: 0x17E7F00 VA: 0x1817E9900 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E97C0 Offset: 0x17E7DC0 VA: 0x1817E97C0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E9440 Offset: 0x17E7A40 VA: 0x1817E9440 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E9220 Offset: 0x17E7820 VA: 0x1817E9220 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E9700 Offset: 0x17E7D00 VA: 0x1817E9700 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E95E0 Offset: 0x17E7BE0 VA: 0x1817E95E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E9880 Offset: 0x17E7E80 VA: 0x1817E9880 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

