internal sealed class CharStorage : DataStorage // TypeDefIndex: 4368
{	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x1273700 Offset: 0x1271D00 VA: 0x181273700
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1272A80 Offset: 0x1271080 VA: 0x181272A80 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1272EB0 Offset: 0x12714B0 VA: 0x181272EB0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1272D90 Offset: 0x1271390 VA: 0x181272D90 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1272FD0 Offset: 0x12715D0 VA: 0x181272FD0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1273240 Offset: 0x1271840 VA: 0x181273240 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1273320 Offset: 0x1271920 VA: 0x181273320 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1273550 Offset: 0x1271B50 VA: 0x181273550 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x12733D0 Offset: 0x12719D0 VA: 0x1812733D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x12730B0 Offset: 0x12716B0 VA: 0x1812730B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1272F50 Offset: 0x1271550 VA: 0x181272F50 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12732E0 Offset: 0x12718E0 VA: 0x1812732E0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1273120 Offset: 0x1271720 VA: 0x181273120 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12734B0 Offset: 0x1271AB0 VA: 0x1812734B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

