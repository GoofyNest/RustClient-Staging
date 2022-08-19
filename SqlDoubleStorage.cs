internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 4418
{	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x17E8200 Offset: 0x17E6800 VA: 0x1817E8200
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E6C60 Offset: 0x17E5260 VA: 0x1817E6C60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E79E0 Offset: 0x17E5FE0 VA: 0x1817E79E0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E7930 Offset: 0x17E5F30 VA: 0x1817E7930 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E7C10 Offset: 0x17E6210 VA: 0x1817E7C10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123ACC0 Offset: 0x12392C0 VA: 0x18123ACC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E7FE0 Offset: 0x17E65E0 VA: 0x1817E7FE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123ADF0 Offset: 0x12393F0 VA: 0x18123ADF0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E81A0 Offset: 0x17E67A0 VA: 0x1817E81A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E8060 Offset: 0x17E6660 VA: 0x1817E8060 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E7C90 Offset: 0x17E6290 VA: 0x1817E7C90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E7A60 Offset: 0x17E6060 VA: 0x1817E7A60 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E7FA0 Offset: 0x17E65A0 VA: 0x1817E7FA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E7E50 Offset: 0x17E6450 VA: 0x1817E7E50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E8120 Offset: 0x17E6720 VA: 0x1817E8120 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

