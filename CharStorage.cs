internal sealed class CharStorage : DataStorage // TypeDefIndex: 4368
{	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x12739C0 Offset: 0x1271FC0 VA: 0x1812739C0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1272D40 Offset: 0x1271340 VA: 0x181272D40 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1273170 Offset: 0x1271770 VA: 0x181273170 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1273050 Offset: 0x1271650 VA: 0x181273050 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1273290 Offset: 0x1271890 VA: 0x181273290 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1273500 Offset: 0x1271B00 VA: 0x181273500 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x12735E0 Offset: 0x1271BE0 VA: 0x1812735E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1273810 Offset: 0x1271E10 VA: 0x181273810 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1273690 Offset: 0x1271C90 VA: 0x181273690 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1273370 Offset: 0x1271970 VA: 0x181273370 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1273210 Offset: 0x1271810 VA: 0x181273210 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12735A0 Offset: 0x1271BA0 VA: 0x1812735A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12733E0 Offset: 0x12719E0 VA: 0x1812733E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1273770 Offset: 0x1271D70 VA: 0x181273770 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

