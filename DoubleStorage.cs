internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 4402
{	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x17D01E0 Offset: 0x17CE7E0 VA: 0x1817D01E0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CF230 Offset: 0x17CD830 VA: 0x1817CF230 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CFA10 Offset: 0x17CE010 VA: 0x1817CFA10 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CF8E0 Offset: 0x17CDEE0 VA: 0x1817CF8E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CFB30 Offset: 0x17CE130 VA: 0x1817CFB30 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17CFDC0 Offset: 0x17CE3C0 VA: 0x1817CFDC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CFE80 Offset: 0x17CE480 VA: 0x1817CFE80 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D00A0 Offset: 0x17CE6A0 VA: 0x1817D00A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CFF20 Offset: 0x17CE520 VA: 0x1817CFF20 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CFC10 Offset: 0x17CE210 VA: 0x1817CFC10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CFAB0 Offset: 0x17CE0B0 VA: 0x1817CFAB0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CFE40 Offset: 0x17CE440 VA: 0x1817CFE40 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CFC80 Offset: 0x17CE280 VA: 0x1817CFC80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D0000 Offset: 0x17CE600 VA: 0x1817D0000 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

