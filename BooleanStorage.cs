internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 4366
{	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x1271B50 Offset: 0x1270150 VA: 0x181271B50
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1270F10 Offset: 0x126F510 VA: 0x181270F10 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1271330 Offset: 0x126F930 VA: 0x181271330 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1271210 Offset: 0x126F810 VA: 0x181271210 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1271450 Offset: 0x126FA50 VA: 0x181271450 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x12716D0 Offset: 0x126FCD0 VA: 0x1812716D0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x12717C0 Offset: 0x126FDC0 VA: 0x1812717C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1271A00 Offset: 0x1270000 VA: 0x181271A00 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1271880 Offset: 0x126FE80 VA: 0x181271880 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1271530 Offset: 0x126FB30 VA: 0x181271530 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x12713D0 Offset: 0x126F9D0 VA: 0x1812713D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1271780 Offset: 0x126FD80 VA: 0x181271780 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12715A0 Offset: 0x126FBA0 VA: 0x1812715A0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1271960 Offset: 0x126FF60 VA: 0x181271960 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

