internal sealed class Int32Storage : DataStorage // TypeDefIndex: 4404
{	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x17D00A0 Offset: 0x17CE6A0 VA: 0x1817D00A0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CF130 Offset: 0x17CD730 VA: 0x1817CF130 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CF9A0 Offset: 0x17CDFA0 VA: 0x1817CF9A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CF890 Offset: 0x17CDE90 VA: 0x1817CF890 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CFAC0 Offset: 0x17CE0C0 VA: 0x1817CFAC0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1243C90 Offset: 0x1242290 VA: 0x181243C90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CFD60 Offset: 0x17CE360 VA: 0x1817CFD60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CFF70 Offset: 0x17CE570 VA: 0x1817CFF70 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CFDF0 Offset: 0x17CE3F0 VA: 0x1817CFDF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CFB90 Offset: 0x17CE190 VA: 0x1817CFB90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CFA40 Offset: 0x17CE040 VA: 0x1817CFA40 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CFD20 Offset: 0x17CE320 VA: 0x1817CFD20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CFC00 Offset: 0x17CE200 VA: 0x1817CFC00 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CFED0 Offset: 0x17CE4D0 VA: 0x1817CFED0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

