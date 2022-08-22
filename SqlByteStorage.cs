internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 4413
{	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x17D9E60 Offset: 0x17D8460 VA: 0x1817D9E60
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D8830 Offset: 0x17D6E30 VA: 0x1817D8830 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D9620 Offset: 0x17D7C20 VA: 0x1817D9620 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D9570 Offset: 0x17D7B70 VA: 0x1817D9570 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D9830 Offset: 0x17D7E30 VA: 0x1817D9830 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D9B70 Offset: 0x17D8170 VA: 0x1817D9B70 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D9C10 Offset: 0x17D8210 VA: 0x1817D9C10 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D9C90 Offset: 0x17D8290 VA: 0x1817D9C90 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D9E10 Offset: 0x17D8410 VA: 0x1817D9E10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D9CD0 Offset: 0x17D82D0 VA: 0x1817D9CD0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D98A0 Offset: 0x17D7EA0 VA: 0x1817D98A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D9680 Offset: 0x17D7C80 VA: 0x1817D9680 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D9BD0 Offset: 0x17D81D0 VA: 0x1817D9BD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D9A40 Offset: 0x17D8040 VA: 0x1817D9A40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D9D90 Offset: 0x17D8390 VA: 0x1817D9D90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

