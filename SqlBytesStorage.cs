internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 4414
{	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x17DA980 Offset: 0x17D8F80 VA: 0x1817DA980
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D9F90 Offset: 0x17D8590 VA: 0x1817D9F90 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1240130 Offset: 0x123E730 VA: 0x181240130 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123F260 Offset: 0x123D860 VA: 0x18123F260 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DA660 Offset: 0x17D8C60 VA: 0x1817DA660 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DA7F0 Offset: 0x17D8DF0 VA: 0x1817DA7F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DA6B0 Offset: 0x17D8CB0 VA: 0x1817DA6B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DA2F0 Offset: 0x17D88F0 VA: 0x1817DA2F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DA140 Offset: 0x17D8740 VA: 0x1817DA140 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DA620 Offset: 0x17D8C20 VA: 0x1817DA620 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DA490 Offset: 0x17D8A90 VA: 0x1817DA490 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DA770 Offset: 0x17D8D70 VA: 0x1817DA770 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

