internal sealed class Int64Storage : DataStorage // TypeDefIndex: 4405
{	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x17D1120 Offset: 0x17CF720 VA: 0x1817D1120
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17D0180 Offset: 0x17CE780 VA: 0x1817D0180 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D09F0 Offset: 0x17CEFF0 VA: 0x1817D09F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D08E0 Offset: 0x17CEEE0 VA: 0x1817D08E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D0B10 Offset: 0x17CF110 VA: 0x1817D0B10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1244EC0 Offset: 0x12434C0 VA: 0x181244EC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D0DC0 Offset: 0x17CF3C0 VA: 0x1817D0DC0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D0FE0 Offset: 0x17CF5E0 VA: 0x1817D0FE0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D0E60 Offset: 0x17CF460 VA: 0x1817D0E60 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D0BF0 Offset: 0x17CF1F0 VA: 0x1817D0BF0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D0A90 Offset: 0x17CF090 VA: 0x1817D0A90 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D0D80 Offset: 0x17CF380 VA: 0x1817D0D80 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D0C60 Offset: 0x17CF260 VA: 0x1817D0C60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D0F40 Offset: 0x17CF540 VA: 0x1817D0F40 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

