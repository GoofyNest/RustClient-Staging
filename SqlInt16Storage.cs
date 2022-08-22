internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 4420
{	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x17E82B0 Offset: 0x17E68B0 VA: 0x1817E82B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E6CB0 Offset: 0x17E52B0 VA: 0x1817E6CB0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E7A90 Offset: 0x17E6090 VA: 0x1817E7A90 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E79E0 Offset: 0x17E5FE0 VA: 0x1817E79E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E7CA0 Offset: 0x17E62A0 VA: 0x1817E7CA0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E7FC0 Offset: 0x17E65C0 VA: 0x1817E7FC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E8060 Offset: 0x17E6660 VA: 0x1817E8060 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E80E0 Offset: 0x17E66E0 VA: 0x1817E80E0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E8260 Offset: 0x17E6860 VA: 0x1817E8260 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E8120 Offset: 0x17E6720 VA: 0x1817E8120 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E7D10 Offset: 0x17E6310 VA: 0x1817E7D10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E7AF0 Offset: 0x17E60F0 VA: 0x1817E7AF0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E8020 Offset: 0x17E6620 VA: 0x1817E8020 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E7EA0 Offset: 0x17E64A0 VA: 0x1817E7EA0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E81E0 Offset: 0x17E67E0 VA: 0x1817E81E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

