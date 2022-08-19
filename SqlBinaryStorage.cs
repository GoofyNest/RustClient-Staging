internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 4412
{	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x17D9B00 Offset: 0x17D8100 VA: 0x1817D9B00
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D9020 Offset: 0x17D7620 VA: 0x1817D9020 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D9290 Offset: 0x17D7890 VA: 0x1817D9290 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D91E0 Offset: 0x17D77E0 VA: 0x1817D91E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D94A0 Offset: 0x17D7AA0 VA: 0x1817D94A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D97F0 Offset: 0x17D7DF0 VA: 0x1817D97F0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D98A0 Offset: 0x17D7EA0 VA: 0x1817D98A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D9920 Offset: 0x17D7F20 VA: 0x1817D9920 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D9AA0 Offset: 0x17D80A0 VA: 0x1817D9AA0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D9960 Offset: 0x17D7F60 VA: 0x1817D9960 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D9510 Offset: 0x17D7B10 VA: 0x1817D9510 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D92F0 Offset: 0x17D78F0 VA: 0x1817D92F0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D9860 Offset: 0x17D7E60 VA: 0x1817D9860 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D96B0 Offset: 0x17D7CB0 VA: 0x1817D96B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D9A20 Offset: 0x17D8020 VA: 0x1817D9A20 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

