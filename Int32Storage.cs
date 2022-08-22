internal sealed class Int32Storage : DataStorage // TypeDefIndex: 4404
{	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x17D2550 Offset: 0x17D0B50 VA: 0x1817D2550
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17D15E0 Offset: 0x17CFBE0 VA: 0x1817D15E0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D1E50 Offset: 0x17D0450 VA: 0x1817D1E50 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D1D40 Offset: 0x17D0340 VA: 0x1817D1D40 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D1F70 Offset: 0x17D0570 VA: 0x1817D1F70 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x12435F0 Offset: 0x1241BF0 VA: 0x1812435F0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D2210 Offset: 0x17D0810 VA: 0x1817D2210 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D2420 Offset: 0x17D0A20 VA: 0x1817D2420 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D22A0 Offset: 0x17D08A0 VA: 0x1817D22A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D2040 Offset: 0x17D0640 VA: 0x1817D2040 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D1EF0 Offset: 0x17D04F0 VA: 0x1817D1EF0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D21D0 Offset: 0x17D07D0 VA: 0x1817D21D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D20B0 Offset: 0x17D06B0 VA: 0x1817D20B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D2380 Offset: 0x17D0980 VA: 0x1817D2380 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

