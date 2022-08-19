internal sealed class SByteStorage : DataStorage // TypeDefIndex: 4410
{	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x17D7A40 Offset: 0x17D6040 VA: 0x1817D7A40
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D6A10 Offset: 0x17D5010 VA: 0x1817D6A10 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D7270 Offset: 0x17D5870 VA: 0x1817D7270 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D7150 Offset: 0x17D5750 VA: 0x1817D7150 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D73C0 Offset: 0x17D59C0 VA: 0x1817D73C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D7620 Offset: 0x17D5C20 VA: 0x1817D7620 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D76E0 Offset: 0x17D5CE0 VA: 0x1817D76E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D7910 Offset: 0x17D5F10 VA: 0x1817D7910 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D7790 Offset: 0x17D5D90 VA: 0x1817D7790 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D7490 Offset: 0x17D5A90 VA: 0x1817D7490 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D7340 Offset: 0x17D5940 VA: 0x1817D7340 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D76A0 Offset: 0x17D5CA0 VA: 0x1817D76A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D7500 Offset: 0x17D5B00 VA: 0x1817D7500 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D7870 Offset: 0x17D5E70 VA: 0x1817D7870 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

