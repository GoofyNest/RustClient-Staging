internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 4417
{	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x17E6DC0 Offset: 0x17E53C0 VA: 0x1817E6DC0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E5660 Offset: 0x17E3C60 VA: 0x1817E5660 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E64C0 Offset: 0x17E4AC0 VA: 0x1817E64C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E6400 Offset: 0x17E4A00 VA: 0x1817E6400 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E66F0 Offset: 0x17E4CF0 VA: 0x1817E66F0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E6A80 Offset: 0x17E5080 VA: 0x1817E6A80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E6B30 Offset: 0x17E5130 VA: 0x1817E6B30 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E6BC0 Offset: 0x17E51C0 VA: 0x1817E6BC0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E6D50 Offset: 0x17E5350 VA: 0x1817E6D50 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E6C10 Offset: 0x17E5210 VA: 0x1817E6C10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E6770 Offset: 0x17E4D70 VA: 0x1817E6770 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E6540 Offset: 0x17E4B40 VA: 0x1817E6540 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E6AF0 Offset: 0x17E50F0 VA: 0x1817E6AF0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E6930 Offset: 0x17E4F30 VA: 0x1817E6930 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E6CD0 Offset: 0x17E52D0 VA: 0x1817E6CD0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

