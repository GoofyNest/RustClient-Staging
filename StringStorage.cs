internal sealed class StringStorage : DataStorage // TypeDefIndex: 4431
{	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x123FE50 Offset: 0x123E450 VA: 0x18123FE50
	public void .ctor(DataColumn column) { }

	// RVA: 0x123F3C0 Offset: 0x123D9C0 VA: 0x18123F3C0 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x123F7F0 Offset: 0x123DDF0 VA: 0x18123F7F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123F700 Offset: 0x123DD00 VA: 0x18123F700 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123F8D0 Offset: 0x123DED0 VA: 0x18123F8D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123FA90 Offset: 0x123E090 VA: 0x18123FA90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123FBC0 Offset: 0x123E1C0 VA: 0x18123FBC0 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x123FB70 Offset: 0x123E170 VA: 0x18123FB70 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x123FC00 Offset: 0x123E200 VA: 0x18123FC00 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123FD80 Offset: 0x123E380 VA: 0x18123FD80 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123FC40 Offset: 0x123E240 VA: 0x18123FC40 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123F880 Offset: 0x123DE80 VA: 0x18123F880 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123FB30 Offset: 0x123E130 VA: 0x18123FB30 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123F900 Offset: 0x123DF00 VA: 0x18123F900 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123FD00 Offset: 0x123E300 VA: 0x18123FD00 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

