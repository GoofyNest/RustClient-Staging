internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 4366
{	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x12721F0 Offset: 0x12707F0 VA: 0x1812721F0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x12715B0 Offset: 0x126FBB0 VA: 0x1812715B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x12719D0 Offset: 0x126FFD0 VA: 0x1812719D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x12718B0 Offset: 0x126FEB0 VA: 0x1812718B0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1271AF0 Offset: 0x12700F0 VA: 0x181271AF0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1271D70 Offset: 0x1270370 VA: 0x181271D70 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1271E60 Offset: 0x1270460 VA: 0x181271E60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x12720A0 Offset: 0x12706A0 VA: 0x1812720A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1271F20 Offset: 0x1270520 VA: 0x181271F20 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1271BD0 Offset: 0x12701D0 VA: 0x181271BD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1271A70 Offset: 0x1270070 VA: 0x181271A70 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1271E20 Offset: 0x1270420 VA: 0x181271E20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1271C40 Offset: 0x1270240 VA: 0x181271C40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1272000 Offset: 0x1270600 VA: 0x181272000 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

