internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 4402
{	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x17D04A0 Offset: 0x17CEAA0 VA: 0x1817D04A0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CF4F0 Offset: 0x17CDAF0 VA: 0x1817CF4F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CFCD0 Offset: 0x17CE2D0 VA: 0x1817CFCD0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CFBA0 Offset: 0x17CE1A0 VA: 0x1817CFBA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CFDF0 Offset: 0x17CE3F0 VA: 0x1817CFDF0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D0080 Offset: 0x17CE680 VA: 0x1817D0080 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D0140 Offset: 0x17CE740 VA: 0x1817D0140 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D0360 Offset: 0x17CE960 VA: 0x1817D0360 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D01E0 Offset: 0x17CE7E0 VA: 0x1817D01E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CFED0 Offset: 0x17CE4D0 VA: 0x1817CFED0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CFD70 Offset: 0x17CE370 VA: 0x1817CFD70 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D0100 Offset: 0x17CE700 VA: 0x1817D0100 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CFF40 Offset: 0x17CE540 VA: 0x1817CFF40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D02C0 Offset: 0x17CE8C0 VA: 0x1817D02C0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

