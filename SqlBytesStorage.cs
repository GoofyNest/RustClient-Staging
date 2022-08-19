internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 4414
{	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x17DCB70 Offset: 0x17DB170 VA: 0x1817DCB70
	public void .ctor(DataColumn column) { }

	// RVA: 0x17DC180 Offset: 0x17DA780 VA: 0x1817DC180 Slot: 4
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

	// RVA: 0x17DC9E0 Offset: 0x17DAFE0 VA: 0x1817DC9E0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DC8A0 Offset: 0x17DAEA0 VA: 0x1817DC8A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DC4E0 Offset: 0x17DAAE0 VA: 0x1817DC4E0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DC330 Offset: 0x17DA930 VA: 0x1817DC330 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DC810 Offset: 0x17DAE10 VA: 0x1817DC810 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DC680 Offset: 0x17DAC80 VA: 0x1817DC680 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DC960 Offset: 0x17DAF60 VA: 0x1817DC960 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

