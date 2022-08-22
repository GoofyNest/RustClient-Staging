internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 4415
{	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x17DB430 Offset: 0x17D9A30 VA: 0x1817DB430
	public void .ctor(DataColumn column) { }

	// RVA: 0x17DAA70 Offset: 0x17D9070 VA: 0x1817DAA70 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1240130 Offset: 0x123E730 VA: 0x181240130 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123F260 Offset: 0x123D860 VA: 0x18123F260 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DA660 Offset: 0x17D8C60 VA: 0x1817DA660 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DB2A0 Offset: 0x17D98A0 VA: 0x1817DB2A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DB160 Offset: 0x17D9760 VA: 0x1817DB160 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DADD0 Offset: 0x17D93D0 VA: 0x1817DADD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DAC20 Offset: 0x17D9220 VA: 0x1817DAC20 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DB120 Offset: 0x17D9720 VA: 0x1817DB120 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DAF90 Offset: 0x17D9590 VA: 0x1817DAF90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DB220 Offset: 0x17D9820 VA: 0x1817DB220 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

