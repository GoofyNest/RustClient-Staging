internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 4401
{	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x17CCF50 Offset: 0x17CB550 VA: 0x1817CCF50
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CBA70 Offset: 0x17CA070 VA: 0x1817CBA70 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CC590 Offset: 0x17CAB90 VA: 0x1817CC590 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CC3E0 Offset: 0x17CA9E0 VA: 0x1817CC3E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CC7F0 Offset: 0x17CADF0 VA: 0x1817CC7F0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17CCA90 Offset: 0x17CB090 VA: 0x1817CCA90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CCB60 Offset: 0x17CB160 VA: 0x1817CCB60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CCD80 Offset: 0x17CB380 VA: 0x1817CCD80 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CCC00 Offset: 0x17CB200 VA: 0x1817CCC00 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CC8D0 Offset: 0x17CAED0 VA: 0x1817CC8D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CC760 Offset: 0x17CAD60 VA: 0x1817CC760 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CCB20 Offset: 0x17CB120 VA: 0x1817CCB20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CC950 Offset: 0x17CAF50 VA: 0x1817CC950 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CCCE0 Offset: 0x17CB2E0 VA: 0x1817CCCE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

