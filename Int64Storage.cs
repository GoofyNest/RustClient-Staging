internal sealed class Int64Storage : DataStorage // TypeDefIndex: 4405
{	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x17D35D0 Offset: 0x17D1BD0 VA: 0x1817D35D0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17D2630 Offset: 0x17D0C30 VA: 0x1817D2630 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D2EA0 Offset: 0x17D14A0 VA: 0x1817D2EA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D2D90 Offset: 0x17D1390 VA: 0x1817D2D90 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D2FC0 Offset: 0x17D15C0 VA: 0x1817D2FC0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1244820 Offset: 0x1242E20 VA: 0x181244820 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D3270 Offset: 0x17D1870 VA: 0x1817D3270 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D3490 Offset: 0x17D1A90 VA: 0x1817D3490 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D3310 Offset: 0x17D1910 VA: 0x1817D3310 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D30A0 Offset: 0x17D16A0 VA: 0x1817D30A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D2F40 Offset: 0x17D1540 VA: 0x1817D2F40 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D3230 Offset: 0x17D1830 VA: 0x1817D3230 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D3110 Offset: 0x17D1710 VA: 0x1817D3110 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D33F0 Offset: 0x17D19F0 VA: 0x1817D33F0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

