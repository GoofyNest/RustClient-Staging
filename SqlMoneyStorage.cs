internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 4423
{	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x123B2A0 Offset: 0x12398A0 VA: 0x18123B2A0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1239B20 Offset: 0x1238120 VA: 0x181239B20 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123A9C0 Offset: 0x1238FC0 VA: 0x18123A9C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123A910 Offset: 0x1238F10 VA: 0x18123A910 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123ABF0 Offset: 0x12391F0 VA: 0x18123ABF0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123AF80 Offset: 0x1239580 VA: 0x18123AF80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123B030 Offset: 0x1239630 VA: 0x18123B030 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123B0B0 Offset: 0x12396B0 VA: 0x18123B0B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123B240 Offset: 0x1239840 VA: 0x18123B240 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123B100 Offset: 0x1239700 VA: 0x18123B100 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123AC70 Offset: 0x1239270 VA: 0x18123AC70 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123AA40 Offset: 0x1239040 VA: 0x18123AA40 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123AFF0 Offset: 0x12395F0 VA: 0x18123AFF0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123AE30 Offset: 0x1239430 VA: 0x18123AE30 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123B1C0 Offset: 0x12397C0 VA: 0x18123B1C0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

