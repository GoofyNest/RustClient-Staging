internal sealed class SingleStorage : DataStorage // TypeDefIndex: 4429
{	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x17D9200 Offset: 0x17D7800 VA: 0x1817D9200
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D8220 Offset: 0x17D6820 VA: 0x1817D8220 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D8A30 Offset: 0x17D7030 VA: 0x1817D8A30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D8900 Offset: 0x17D6F00 VA: 0x1817D8900 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D8B50 Offset: 0x17D7150 VA: 0x1817D8B50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D8DE0 Offset: 0x17D73E0 VA: 0x1817D8DE0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D8EA0 Offset: 0x17D74A0 VA: 0x1817D8EA0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D90C0 Offset: 0x17D76C0 VA: 0x1817D90C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D8F40 Offset: 0x17D7540 VA: 0x1817D8F40 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D8C30 Offset: 0x17D7230 VA: 0x1817D8C30 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D8AD0 Offset: 0x17D70D0 VA: 0x1817D8AD0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D8E60 Offset: 0x17D7460 VA: 0x1817D8E60 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D8CA0 Offset: 0x17D72A0 VA: 0x1817D8CA0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D9020 Offset: 0x17D7620 VA: 0x1817D9020 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

