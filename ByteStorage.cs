internal sealed class ByteStorage : DataStorage // TypeDefIndex: 4367
{	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x1272C60 Offset: 0x1271260 VA: 0x181272C60
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1271C30 Offset: 0x1270230 VA: 0x181271C30 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1272480 Offset: 0x1270A80 VA: 0x181272480 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1272360 Offset: 0x1270960 VA: 0x181272360 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1272590 Offset: 0x1270B90 VA: 0x181272590 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1272800 Offset: 0x1270E00 VA: 0x181272800 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x12728E0 Offset: 0x1270EE0 VA: 0x1812728E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1272B10 Offset: 0x1271110 VA: 0x181272B10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1272990 Offset: 0x1270F90 VA: 0x181272990 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1272670 Offset: 0x1270C70 VA: 0x181272670 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1272510 Offset: 0x1270B10 VA: 0x181272510 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12728A0 Offset: 0x1270EA0 VA: 0x1812728A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12726E0 Offset: 0x1270CE0 VA: 0x1812726E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1272A70 Offset: 0x1271070 VA: 0x181272A70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

