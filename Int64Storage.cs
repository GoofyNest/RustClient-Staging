internal sealed class Int64Storage : DataStorage // TypeDefIndex: 4405
{	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x17D3310 Offset: 0x17D1910 VA: 0x1817D3310
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17D2370 Offset: 0x17D0970 VA: 0x1817D2370 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D2BE0 Offset: 0x17D11E0 VA: 0x1817D2BE0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D2AD0 Offset: 0x17D10D0 VA: 0x1817D2AD0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D2D00 Offset: 0x17D1300 VA: 0x1817D2D00 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1244560 Offset: 0x1242B60 VA: 0x181244560 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D2FB0 Offset: 0x17D15B0 VA: 0x1817D2FB0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D31D0 Offset: 0x17D17D0 VA: 0x1817D31D0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D3050 Offset: 0x17D1650 VA: 0x1817D3050 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D2DE0 Offset: 0x17D13E0 VA: 0x1817D2DE0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D2C80 Offset: 0x17D1280 VA: 0x1817D2C80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D2F70 Offset: 0x17D1570 VA: 0x1817D2F70 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D2E50 Offset: 0x17D1450 VA: 0x1817D2E50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D3130 Offset: 0x17D1730 VA: 0x1817D3130 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

