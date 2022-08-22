internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 4419
{	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x17E6B80 Offset: 0x17E5180 VA: 0x1817E6B80
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E6150 Offset: 0x17E4750 VA: 0x1817E6150 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E63C0 Offset: 0x17E49C0 VA: 0x1817E63C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E6310 Offset: 0x17E4910 VA: 0x1817E6310 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E65D0 Offset: 0x17E4BD0 VA: 0x1817E65D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D7600 Offset: 0x17D5C00 VA: 0x1817D7600 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E6960 Offset: 0x17E4F60 VA: 0x1817E6960 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D7730 Offset: 0x17D5D30 VA: 0x1817D7730 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E6B20 Offset: 0x17E5120 VA: 0x1817E6B20 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E69E0 Offset: 0x17E4FE0 VA: 0x1817E69E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E6640 Offset: 0x17E4C40 VA: 0x1817E6640 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E6420 Offset: 0x17E4A20 VA: 0x1817E6420 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E6920 Offset: 0x17E4F20 VA: 0x1817E6920 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E67E0 Offset: 0x17E4DE0 VA: 0x1817E67E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E6AA0 Offset: 0x17E50A0 VA: 0x1817E6AA0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

