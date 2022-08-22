internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 4423
{	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x123B940 Offset: 0x1239F40 VA: 0x18123B940
	public void .ctor(DataColumn column) { }

	// RVA: 0x123A1C0 Offset: 0x12387C0 VA: 0x18123A1C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123B060 Offset: 0x1239660 VA: 0x18123B060 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123AFB0 Offset: 0x12395B0 VA: 0x18123AFB0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123B290 Offset: 0x1239890 VA: 0x18123B290 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123B620 Offset: 0x1239C20 VA: 0x18123B620 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123B6D0 Offset: 0x1239CD0 VA: 0x18123B6D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123B750 Offset: 0x1239D50 VA: 0x18123B750 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123B8E0 Offset: 0x1239EE0 VA: 0x18123B8E0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123B7A0 Offset: 0x1239DA0 VA: 0x18123B7A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123B310 Offset: 0x1239910 VA: 0x18123B310 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123B0E0 Offset: 0x12396E0 VA: 0x18123B0E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123B690 Offset: 0x1239C90 VA: 0x18123B690 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123B4D0 Offset: 0x1239AD0 VA: 0x18123B4D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123B860 Offset: 0x1239E60 VA: 0x18123B860 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

