internal sealed class SingleStorage : DataStorage // TypeDefIndex: 4429
{	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x17D8F40 Offset: 0x17D7540 VA: 0x1817D8F40
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D7F60 Offset: 0x17D6560 VA: 0x1817D7F60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D8770 Offset: 0x17D6D70 VA: 0x1817D8770 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D8640 Offset: 0x17D6C40 VA: 0x1817D8640 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D8890 Offset: 0x17D6E90 VA: 0x1817D8890 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D8B20 Offset: 0x17D7120 VA: 0x1817D8B20 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D8BE0 Offset: 0x17D71E0 VA: 0x1817D8BE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D8E00 Offset: 0x17D7400 VA: 0x1817D8E00 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D8C80 Offset: 0x17D7280 VA: 0x1817D8C80 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D8970 Offset: 0x17D6F70 VA: 0x1817D8970 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D8810 Offset: 0x17D6E10 VA: 0x1817D8810 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D8BA0 Offset: 0x17D71A0 VA: 0x1817D8BA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D89E0 Offset: 0x17D6FE0 VA: 0x1817D89E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D8D60 Offset: 0x17D7360 VA: 0x1817D8D60 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

