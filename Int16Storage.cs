internal sealed class Int16Storage : DataStorage // TypeDefIndex: 4403
{	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x17D1500 Offset: 0x17CFB00 VA: 0x1817D1500
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17D0580 Offset: 0x17CEB80 VA: 0x1817D0580 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D0DF0 Offset: 0x17CF3F0 VA: 0x1817D0DF0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D0CE0 Offset: 0x17CF2E0 VA: 0x1817D0CE0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D0F00 Offset: 0x17CF500 VA: 0x1817D0F00 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1242470 Offset: 0x1240A70 VA: 0x181242470 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D11B0 Offset: 0x17CF7B0 VA: 0x1817D11B0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D13D0 Offset: 0x17CF9D0 VA: 0x1817D13D0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D1250 Offset: 0x17CF850 VA: 0x1817D1250 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D0FE0 Offset: 0x17CF5E0 VA: 0x1817D0FE0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D0E80 Offset: 0x17CF480 VA: 0x1817D0E80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D1170 Offset: 0x17CF770 VA: 0x1817D1170 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D1050 Offset: 0x17CF650 VA: 0x1817D1050 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D1330 Offset: 0x17CF930 VA: 0x1817D1330 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

