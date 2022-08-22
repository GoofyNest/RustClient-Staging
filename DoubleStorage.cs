internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 4402
{	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x17CDFF0 Offset: 0x17CC5F0 VA: 0x1817CDFF0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CD040 Offset: 0x17CB640 VA: 0x1817CD040 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CD820 Offset: 0x17CBE20 VA: 0x1817CD820 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CD6F0 Offset: 0x17CBCF0 VA: 0x1817CD6F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CD940 Offset: 0x17CBF40 VA: 0x1817CD940 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17CDBD0 Offset: 0x17CC1D0 VA: 0x1817CDBD0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CDC90 Offset: 0x17CC290 VA: 0x1817CDC90 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CDEB0 Offset: 0x17CC4B0 VA: 0x1817CDEB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CDD30 Offset: 0x17CC330 VA: 0x1817CDD30 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CDA20 Offset: 0x17CC020 VA: 0x1817CDA20 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CD8C0 Offset: 0x17CBEC0 VA: 0x1817CD8C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CDC50 Offset: 0x17CC250 VA: 0x1817CDC50 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CDA90 Offset: 0x17CC090 VA: 0x1817CDA90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CDE10 Offset: 0x17CC410 VA: 0x1817CDE10 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

