internal sealed class SByteStorage : DataStorage // TypeDefIndex: 4410
{	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x17D5850 Offset: 0x17D3E50 VA: 0x1817D5850
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D4820 Offset: 0x17D2E20 VA: 0x1817D4820 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D5080 Offset: 0x17D3680 VA: 0x1817D5080 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D4F60 Offset: 0x17D3560 VA: 0x1817D4F60 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D51D0 Offset: 0x17D37D0 VA: 0x1817D51D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D5430 Offset: 0x17D3A30 VA: 0x1817D5430 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D54F0 Offset: 0x17D3AF0 VA: 0x1817D54F0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D5720 Offset: 0x17D3D20 VA: 0x1817D5720 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D55A0 Offset: 0x17D3BA0 VA: 0x1817D55A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D52A0 Offset: 0x17D38A0 VA: 0x1817D52A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D5150 Offset: 0x17D3750 VA: 0x1817D5150 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D54B0 Offset: 0x17D3AB0 VA: 0x1817D54B0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D5310 Offset: 0x17D3910 VA: 0x1817D5310 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D5680 Offset: 0x17D3C80 VA: 0x1817D5680 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

