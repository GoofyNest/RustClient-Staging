internal sealed class ByteStorage : DataStorage // TypeDefIndex: 4367
{	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x12729A0 Offset: 0x1270FA0 VA: 0x1812729A0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1271970 Offset: 0x126FF70 VA: 0x181271970 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x12721C0 Offset: 0x12707C0 VA: 0x1812721C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x12720A0 Offset: 0x12706A0 VA: 0x1812720A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x12722D0 Offset: 0x12708D0 VA: 0x1812722D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1272540 Offset: 0x1270B40 VA: 0x181272540 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1272620 Offset: 0x1270C20 VA: 0x181272620 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1272850 Offset: 0x1270E50 VA: 0x181272850 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x12726D0 Offset: 0x1270CD0 VA: 0x1812726D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x12723B0 Offset: 0x12709B0 VA: 0x1812723B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1272250 Offset: 0x1270850 VA: 0x181272250 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12725E0 Offset: 0x1270BE0 VA: 0x1812725E0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1272420 Offset: 0x1270A20 VA: 0x181272420 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12727B0 Offset: 0x1270DB0 VA: 0x1812727B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

