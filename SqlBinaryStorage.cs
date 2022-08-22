internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 4412
{	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x17D9DC0 Offset: 0x17D83C0 VA: 0x1817D9DC0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D92E0 Offset: 0x17D78E0 VA: 0x1817D92E0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D9550 Offset: 0x17D7B50 VA: 0x1817D9550 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D94A0 Offset: 0x17D7AA0 VA: 0x1817D94A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D9760 Offset: 0x17D7D60 VA: 0x1817D9760 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D9AB0 Offset: 0x17D80B0 VA: 0x1817D9AB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D9B60 Offset: 0x17D8160 VA: 0x1817D9B60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D9BE0 Offset: 0x17D81E0 VA: 0x1817D9BE0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D9D60 Offset: 0x17D8360 VA: 0x1817D9D60 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D9C20 Offset: 0x17D8220 VA: 0x1817D9C20 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D97D0 Offset: 0x17D7DD0 VA: 0x1817D97D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D95B0 Offset: 0x17D7BB0 VA: 0x1817D95B0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D9B20 Offset: 0x17D8120 VA: 0x1817D9B20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D9970 Offset: 0x17D7F70 VA: 0x1817D9970 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D9CE0 Offset: 0x17D82E0 VA: 0x1817D9CE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

