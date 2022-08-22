internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 4401
{	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x17CF400 Offset: 0x17CDA00 VA: 0x1817CF400
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CDF20 Offset: 0x17CC520 VA: 0x1817CDF20 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CEA40 Offset: 0x17CD040 VA: 0x1817CEA40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CE890 Offset: 0x17CCE90 VA: 0x1817CE890 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CECA0 Offset: 0x17CD2A0 VA: 0x1817CECA0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17CEF40 Offset: 0x17CD540 VA: 0x1817CEF40 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CF010 Offset: 0x17CD610 VA: 0x1817CF010 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CF230 Offset: 0x17CD830 VA: 0x1817CF230 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CF0B0 Offset: 0x17CD6B0 VA: 0x1817CF0B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CED80 Offset: 0x17CD380 VA: 0x1817CED80 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CEC10 Offset: 0x17CD210 VA: 0x1817CEC10 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CEFD0 Offset: 0x17CD5D0 VA: 0x1817CEFD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CEE00 Offset: 0x17CD400 VA: 0x1817CEE00 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CF190 Offset: 0x17CD790 VA: 0x1817CF190 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

