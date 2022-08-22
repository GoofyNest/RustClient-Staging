internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 4414
{	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x17DCE30 Offset: 0x17DB430 VA: 0x1817DCE30
	public void .ctor(DataColumn column) { }

	// RVA: 0x17DC440 Offset: 0x17DAA40 VA: 0x1817DC440 Slot: 4
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

	// RVA: 0x17DCCA0 Offset: 0x17DB2A0 VA: 0x1817DCCA0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DCB60 Offset: 0x17DB160 VA: 0x1817DCB60 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DC7A0 Offset: 0x17DADA0 VA: 0x1817DC7A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DC5F0 Offset: 0x17DABF0 VA: 0x1817DC5F0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DCAD0 Offset: 0x17DB0D0 VA: 0x1817DCAD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DC940 Offset: 0x17DAF40 VA: 0x1817DC940 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DCC20 Offset: 0x17DB220 VA: 0x1817DCC20 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

