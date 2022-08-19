internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 4416
{	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x17E5240 Offset: 0x17E3840 VA: 0x1817E5240
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E4300 Offset: 0x17E2900 VA: 0x1817E4300 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E4940 Offset: 0x17E2F40 VA: 0x1817E4940 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E4880 Offset: 0x17E2E80 VA: 0x1817E4880 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E4B70 Offset: 0x17E3170 VA: 0x1817E4B70 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E4F00 Offset: 0x17E3500 VA: 0x1817E4F00 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E4FB0 Offset: 0x17E35B0 VA: 0x1817E4FB0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E5040 Offset: 0x17E3640 VA: 0x1817E5040 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E51D0 Offset: 0x17E37D0 VA: 0x1817E51D0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E5090 Offset: 0x17E3690 VA: 0x1817E5090 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E4BF0 Offset: 0x17E31F0 VA: 0x1817E4BF0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E49C0 Offset: 0x17E2FC0 VA: 0x1817E49C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E4F70 Offset: 0x17E3570 VA: 0x1817E4F70 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E4DB0 Offset: 0x17E33B0 VA: 0x1817E4DB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E5150 Offset: 0x17E3750 VA: 0x1817E5150 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

