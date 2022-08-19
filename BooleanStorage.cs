internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 4366
{	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x1271890 Offset: 0x126FE90 VA: 0x181271890
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1270C50 Offset: 0x126F250 VA: 0x181270C50 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1271070 Offset: 0x126F670 VA: 0x181271070 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1270F50 Offset: 0x126F550 VA: 0x181270F50 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1271190 Offset: 0x126F790 VA: 0x181271190 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1271410 Offset: 0x126FA10 VA: 0x181271410 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1271500 Offset: 0x126FB00 VA: 0x181271500 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1271740 Offset: 0x126FD40 VA: 0x181271740 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x12715C0 Offset: 0x126FBC0 VA: 0x1812715C0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1271270 Offset: 0x126F870 VA: 0x181271270 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1271110 Offset: 0x126F710 VA: 0x181271110 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12714C0 Offset: 0x126FAC0 VA: 0x1812714C0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12712E0 Offset: 0x126F8E0 VA: 0x1812712E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12716A0 Offset: 0x126FCA0 VA: 0x1812716A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

