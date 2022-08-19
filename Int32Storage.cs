internal sealed class Int32Storage : DataStorage // TypeDefIndex: 4404
{	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x17D2290 Offset: 0x17D0890 VA: 0x1817D2290
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17D1320 Offset: 0x17CF920 VA: 0x1817D1320 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D1B90 Offset: 0x17D0190 VA: 0x1817D1B90 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D1A80 Offset: 0x17D0080 VA: 0x1817D1A80 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D1CB0 Offset: 0x17D02B0 VA: 0x1817D1CB0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1243330 Offset: 0x1241930 VA: 0x181243330 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D1F50 Offset: 0x17D0550 VA: 0x1817D1F50 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D2160 Offset: 0x17D0760 VA: 0x1817D2160 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D1FE0 Offset: 0x17D05E0 VA: 0x1817D1FE0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D1D80 Offset: 0x17D0380 VA: 0x1817D1D80 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D1C30 Offset: 0x17D0230 VA: 0x1817D1C30 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D1F10 Offset: 0x17D0510 VA: 0x1817D1F10 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D1DF0 Offset: 0x17D03F0 VA: 0x1817D1DF0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D20C0 Offset: 0x17D06C0 VA: 0x1817D20C0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

