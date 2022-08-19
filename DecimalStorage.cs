internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 4401
{	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x17CF140 Offset: 0x17CD740 VA: 0x1817CF140
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CDC60 Offset: 0x17CC260 VA: 0x1817CDC60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CE780 Offset: 0x17CCD80 VA: 0x1817CE780 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CE5D0 Offset: 0x17CCBD0 VA: 0x1817CE5D0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CE9E0 Offset: 0x17CCFE0 VA: 0x1817CE9E0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17CEC80 Offset: 0x17CD280 VA: 0x1817CEC80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CED50 Offset: 0x17CD350 VA: 0x1817CED50 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CEF70 Offset: 0x17CD570 VA: 0x1817CEF70 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CEDF0 Offset: 0x17CD3F0 VA: 0x1817CEDF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CEAC0 Offset: 0x17CD0C0 VA: 0x1817CEAC0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CE950 Offset: 0x17CCF50 VA: 0x1817CE950 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CED10 Offset: 0x17CD310 VA: 0x1817CED10 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CEB40 Offset: 0x17CD140 VA: 0x1817CEB40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CEED0 Offset: 0x17CD4D0 VA: 0x1817CEED0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

