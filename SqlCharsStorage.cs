internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 4415
{	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x17DD8E0 Offset: 0x17DBEE0 VA: 0x1817DD8E0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17DCF20 Offset: 0x17DB520 VA: 0x1817DCF20 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123FA90 Offset: 0x123E090 VA: 0x18123FA90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123EBC0 Offset: 0x123D1C0 VA: 0x18123EBC0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DCB10 Offset: 0x17DB110 VA: 0x1817DCB10 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DD750 Offset: 0x17DBD50 VA: 0x1817DD750 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DD610 Offset: 0x17DBC10 VA: 0x1817DD610 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DD280 Offset: 0x17DB880 VA: 0x1817DD280 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DD0D0 Offset: 0x17DB6D0 VA: 0x1817DD0D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DD5D0 Offset: 0x17DBBD0 VA: 0x1817DD5D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DD440 Offset: 0x17DBA40 VA: 0x1817DD440 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DD6D0 Offset: 0x17DBCD0 VA: 0x1817DD6D0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

