internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 4413
{	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x17DC050 Offset: 0x17DA650 VA: 0x1817DC050
	public void .ctor(DataColumn column) { }

	// RVA: 0x17DAA20 Offset: 0x17D9020 VA: 0x1817DAA20 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17DB810 Offset: 0x17D9E10 VA: 0x1817DB810 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17DB760 Offset: 0x17D9D60 VA: 0x1817DB760 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17DBA20 Offset: 0x17DA020 VA: 0x1817DBA20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17DBD60 Offset: 0x17DA360 VA: 0x1817DBD60 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17DBE00 Offset: 0x17DA400 VA: 0x1817DBE00 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DBE80 Offset: 0x17DA480 VA: 0x1817DBE80 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DC000 Offset: 0x17DA600 VA: 0x1817DC000 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DBEC0 Offset: 0x17DA4C0 VA: 0x1817DBEC0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DBA90 Offset: 0x17DA090 VA: 0x1817DBA90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DB870 Offset: 0x17D9E70 VA: 0x1817DB870 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DBDC0 Offset: 0x17DA3C0 VA: 0x1817DBDC0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DBC30 Offset: 0x17DA230 VA: 0x1817DBC30 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DBF80 Offset: 0x17DA580 VA: 0x1817DBF80 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

