internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 4426
{	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x17D8700 Offset: 0x17D6D00 VA: 0x1817D8700
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D7A40 Offset: 0x17D6040 VA: 0x1817D7A40 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D7ED0 Offset: 0x17D64D0 VA: 0x1817D7ED0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D7E30 Offset: 0x17D6430 VA: 0x1817D7E30 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D80E0 Offset: 0x17D66E0 VA: 0x1817D80E0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D8410 Offset: 0x17D6A10 VA: 0x1817D8410 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D84B0 Offset: 0x17D6AB0 VA: 0x1817D84B0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D8530 Offset: 0x17D6B30 VA: 0x1817D8530 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D86B0 Offset: 0x17D6CB0 VA: 0x1817D86B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D8570 Offset: 0x17D6B70 VA: 0x1817D8570 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D8150 Offset: 0x17D6750 VA: 0x1817D8150 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D7F30 Offset: 0x17D6530 VA: 0x1817D7F30 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D8470 Offset: 0x17D6A70 VA: 0x1817D8470 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D82F0 Offset: 0x17D68F0 VA: 0x1817D82F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D8630 Offset: 0x17D6C30 VA: 0x1817D8630 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

