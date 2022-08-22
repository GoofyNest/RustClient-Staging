internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 4418
{	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x17E6010 Offset: 0x17E4610 VA: 0x1817E6010
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E4A70 Offset: 0x17E3070 VA: 0x1817E4A70 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E57F0 Offset: 0x17E3DF0 VA: 0x1817E57F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E5740 Offset: 0x17E3D40 VA: 0x1817E5740 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E5A20 Offset: 0x17E4020 VA: 0x1817E5A20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123B620 Offset: 0x1239C20 VA: 0x18123B620 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E5DF0 Offset: 0x17E43F0 VA: 0x1817E5DF0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123B750 Offset: 0x1239D50 VA: 0x18123B750 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E5FB0 Offset: 0x17E45B0 VA: 0x1817E5FB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E5E70 Offset: 0x17E4470 VA: 0x1817E5E70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E5AA0 Offset: 0x17E40A0 VA: 0x1817E5AA0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E5870 Offset: 0x17E3E70 VA: 0x1817E5870 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E5DB0 Offset: 0x17E43B0 VA: 0x1817E5DB0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E5C60 Offset: 0x17E4260 VA: 0x1817E5C60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E5F30 Offset: 0x17E4530 VA: 0x1817E5F30 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

