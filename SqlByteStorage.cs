internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 4413
{	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x17DC310 Offset: 0x17DA910 VA: 0x1817DC310
	public void .ctor(DataColumn column) { }

	// RVA: 0x17DACE0 Offset: 0x17D92E0 VA: 0x1817DACE0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17DBAD0 Offset: 0x17DA0D0 VA: 0x1817DBAD0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17DBA20 Offset: 0x17DA020 VA: 0x1817DBA20 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17DBCE0 Offset: 0x17DA2E0 VA: 0x1817DBCE0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17DC020 Offset: 0x17DA620 VA: 0x1817DC020 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17DC0C0 Offset: 0x17DA6C0 VA: 0x1817DC0C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DC140 Offset: 0x17DA740 VA: 0x1817DC140 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DC2C0 Offset: 0x17DA8C0 VA: 0x1817DC2C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DC180 Offset: 0x17DA780 VA: 0x1817DC180 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DBD50 Offset: 0x17DA350 VA: 0x1817DBD50 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DBB30 Offset: 0x17DA130 VA: 0x1817DBB30 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DC080 Offset: 0x17DA680 VA: 0x1817DC080 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DBEF0 Offset: 0x17DA4F0 VA: 0x1817DBEF0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DC240 Offset: 0x17DA840 VA: 0x1817DC240 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

