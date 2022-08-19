internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 4417
{	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x17E6B00 Offset: 0x17E5100 VA: 0x1817E6B00
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E53A0 Offset: 0x17E39A0 VA: 0x1817E53A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E6200 Offset: 0x17E4800 VA: 0x1817E6200 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E6140 Offset: 0x17E4740 VA: 0x1817E6140 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E6430 Offset: 0x17E4A30 VA: 0x1817E6430 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E67C0 Offset: 0x17E4DC0 VA: 0x1817E67C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E6870 Offset: 0x17E4E70 VA: 0x1817E6870 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E6900 Offset: 0x17E4F00 VA: 0x1817E6900 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E6A90 Offset: 0x17E5090 VA: 0x1817E6A90 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E6950 Offset: 0x17E4F50 VA: 0x1817E6950 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E64B0 Offset: 0x17E4AB0 VA: 0x1817E64B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E6280 Offset: 0x17E4880 VA: 0x1817E6280 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E6830 Offset: 0x17E4E30 VA: 0x1817E6830 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E6670 Offset: 0x17E4C70 VA: 0x1817E6670 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E6A10 Offset: 0x17E5010 VA: 0x1817E6A10 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

