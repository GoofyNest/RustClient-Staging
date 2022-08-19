internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 4415
{	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x17DD620 Offset: 0x17DBC20 VA: 0x1817DD620
	public void .ctor(DataColumn column) { }

	// RVA: 0x17DCC60 Offset: 0x17DB260 VA: 0x1817DCC60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123F7D0 Offset: 0x123DDD0 VA: 0x18123F7D0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123E900 Offset: 0x123CF00 VA: 0x18123E900 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DC850 Offset: 0x17DAE50 VA: 0x1817DC850 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DD490 Offset: 0x17DBA90 VA: 0x1817DD490 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DD350 Offset: 0x17DB950 VA: 0x1817DD350 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DCFC0 Offset: 0x17DB5C0 VA: 0x1817DCFC0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DCE10 Offset: 0x17DB410 VA: 0x1817DCE10 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DD310 Offset: 0x17DB910 VA: 0x1817DD310 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DD180 Offset: 0x17DB780 VA: 0x1817DD180 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DD410 Offset: 0x17DBA10 VA: 0x1817DD410 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

