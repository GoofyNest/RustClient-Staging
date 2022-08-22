internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 4416
{	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x17E3050 Offset: 0x17E1650 VA: 0x1817E3050
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E2110 Offset: 0x17E0710 VA: 0x1817E2110 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E2750 Offset: 0x17E0D50 VA: 0x1817E2750 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E2690 Offset: 0x17E0C90 VA: 0x1817E2690 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E2980 Offset: 0x17E0F80 VA: 0x1817E2980 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E2D10 Offset: 0x17E1310 VA: 0x1817E2D10 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E2DC0 Offset: 0x17E13C0 VA: 0x1817E2DC0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E2E50 Offset: 0x17E1450 VA: 0x1817E2E50 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E2FE0 Offset: 0x17E15E0 VA: 0x1817E2FE0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E2EA0 Offset: 0x17E14A0 VA: 0x1817E2EA0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E2A00 Offset: 0x17E1000 VA: 0x1817E2A00 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E27D0 Offset: 0x17E0DD0 VA: 0x1817E27D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E2D80 Offset: 0x17E1380 VA: 0x1817E2D80 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E2BC0 Offset: 0x17E11C0 VA: 0x1817E2BC0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E2F60 Offset: 0x17E1560 VA: 0x1817E2F60 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

