internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 4423
{	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x123AFE0 Offset: 0x12395E0 VA: 0x18123AFE0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1239860 Offset: 0x1237E60 VA: 0x181239860 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123A700 Offset: 0x1238D00 VA: 0x18123A700 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123A650 Offset: 0x1238C50 VA: 0x18123A650 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123A930 Offset: 0x1238F30 VA: 0x18123A930 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123ACC0 Offset: 0x12392C0 VA: 0x18123ACC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123AD70 Offset: 0x1239370 VA: 0x18123AD70 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123ADF0 Offset: 0x12393F0 VA: 0x18123ADF0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123AF80 Offset: 0x1239580 VA: 0x18123AF80 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123AE40 Offset: 0x1239440 VA: 0x18123AE40 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123A9B0 Offset: 0x1238FB0 VA: 0x18123A9B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123A780 Offset: 0x1238D80 VA: 0x18123A780 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123AD30 Offset: 0x1239330 VA: 0x18123AD30 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123AB70 Offset: 0x1239170 VA: 0x18123AB70 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123AF00 Offset: 0x1239500 VA: 0x18123AF00 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

