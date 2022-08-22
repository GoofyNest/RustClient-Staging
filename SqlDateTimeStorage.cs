internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 4416
{	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x17E5500 Offset: 0x17E3B00 VA: 0x1817E5500
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E45C0 Offset: 0x17E2BC0 VA: 0x1817E45C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E4C00 Offset: 0x17E3200 VA: 0x1817E4C00 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E4B40 Offset: 0x17E3140 VA: 0x1817E4B40 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E4E30 Offset: 0x17E3430 VA: 0x1817E4E30 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E51C0 Offset: 0x17E37C0 VA: 0x1817E51C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E5270 Offset: 0x17E3870 VA: 0x1817E5270 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E5300 Offset: 0x17E3900 VA: 0x1817E5300 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E5490 Offset: 0x17E3A90 VA: 0x1817E5490 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E5350 Offset: 0x17E3950 VA: 0x1817E5350 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E4EB0 Offset: 0x17E34B0 VA: 0x1817E4EB0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E4C80 Offset: 0x17E3280 VA: 0x1817E4C80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E5230 Offset: 0x17E3830 VA: 0x1817E5230 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E5070 Offset: 0x17E3670 VA: 0x1817E5070 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E5410 Offset: 0x17E3A10 VA: 0x1817E5410 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

