internal sealed class ByteStorage : DataStorage // TypeDefIndex: 4367
{	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x1273300 Offset: 0x1271900 VA: 0x181273300
	internal void .ctor(DataColumn column) { }

	// RVA: 0x12722D0 Offset: 0x12708D0 VA: 0x1812722D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1272B20 Offset: 0x1271120 VA: 0x181272B20 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1272A00 Offset: 0x1271000 VA: 0x181272A00 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1272C30 Offset: 0x1271230 VA: 0x181272C30 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1272EA0 Offset: 0x12714A0 VA: 0x181272EA0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1272F80 Offset: 0x1271580 VA: 0x181272F80 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x12731B0 Offset: 0x12717B0 VA: 0x1812731B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1273030 Offset: 0x1271630 VA: 0x181273030 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1272D10 Offset: 0x1271310 VA: 0x181272D10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1272BB0 Offset: 0x12711B0 VA: 0x181272BB0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1272F40 Offset: 0x1271540 VA: 0x181272F40 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1272D80 Offset: 0x1271380 VA: 0x181272D80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1273110 Offset: 0x1271710 VA: 0x181273110 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

