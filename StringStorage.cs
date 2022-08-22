internal sealed class StringStorage : DataStorage // TypeDefIndex: 4431
{	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x12404F0 Offset: 0x123EAF0 VA: 0x1812404F0
	public void .ctor(DataColumn column) { }

	// RVA: 0x123FA60 Offset: 0x123E060 VA: 0x18123FA60 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x123FE90 Offset: 0x123E490 VA: 0x18123FE90 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123FDA0 Offset: 0x123E3A0 VA: 0x18123FDA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123FF70 Offset: 0x123E570 VA: 0x18123FF70 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1240130 Offset: 0x123E730 VA: 0x181240130 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1240260 Offset: 0x123E860 VA: 0x181240260 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1240210 Offset: 0x123E810 VA: 0x181240210 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x12402A0 Offset: 0x123E8A0 VA: 0x1812402A0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1240420 Offset: 0x123EA20 VA: 0x181240420 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x12402E0 Offset: 0x123E8E0 VA: 0x1812402E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123FF20 Offset: 0x123E520 VA: 0x18123FF20 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12401D0 Offset: 0x123E7D0 VA: 0x1812401D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123FFA0 Offset: 0x123E5A0 VA: 0x18123FFA0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12403A0 Offset: 0x123E9A0 VA: 0x1812403A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

