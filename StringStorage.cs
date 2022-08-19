internal sealed class StringStorage : DataStorage // TypeDefIndex: 4431
{	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x123FB90 Offset: 0x123E190 VA: 0x18123FB90
	public void .ctor(DataColumn column) { }

	// RVA: 0x123F100 Offset: 0x123D700 VA: 0x18123F100 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x123F530 Offset: 0x123DB30 VA: 0x18123F530 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123F440 Offset: 0x123DA40 VA: 0x18123F440 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123F610 Offset: 0x123DC10 VA: 0x18123F610 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123F7D0 Offset: 0x123DDD0 VA: 0x18123F7D0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123F900 Offset: 0x123DF00 VA: 0x18123F900 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x123F8B0 Offset: 0x123DEB0 VA: 0x18123F8B0 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x123F940 Offset: 0x123DF40 VA: 0x18123F940 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123FAC0 Offset: 0x123E0C0 VA: 0x18123FAC0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123F980 Offset: 0x123DF80 VA: 0x18123F980 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123F5C0 Offset: 0x123DBC0 VA: 0x18123F5C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123F870 Offset: 0x123DE70 VA: 0x18123F870 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123F640 Offset: 0x123DC40 VA: 0x18123F640 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123FA40 Offset: 0x123E040 VA: 0x18123FA40 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

