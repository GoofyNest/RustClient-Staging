internal sealed class SingleStorage : DataStorage // TypeDefIndex: 4429
{	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x17D6D50 Offset: 0x17D5350 VA: 0x1817D6D50
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D5D70 Offset: 0x17D4370 VA: 0x1817D5D70 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D6580 Offset: 0x17D4B80 VA: 0x1817D6580 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D6450 Offset: 0x17D4A50 VA: 0x1817D6450 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D66A0 Offset: 0x17D4CA0 VA: 0x1817D66A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D6930 Offset: 0x17D4F30 VA: 0x1817D6930 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D69F0 Offset: 0x17D4FF0 VA: 0x1817D69F0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D6C10 Offset: 0x17D5210 VA: 0x1817D6C10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D6A90 Offset: 0x17D5090 VA: 0x1817D6A90 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D6780 Offset: 0x17D4D80 VA: 0x1817D6780 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D6620 Offset: 0x17D4C20 VA: 0x1817D6620 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D69B0 Offset: 0x17D4FB0 VA: 0x1817D69B0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D67F0 Offset: 0x17D4DF0 VA: 0x1817D67F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D6B70 Offset: 0x17D5170 VA: 0x1817D6B70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

