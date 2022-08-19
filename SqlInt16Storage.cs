internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 4420
{	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x17EA4A0 Offset: 0x17E8AA0 VA: 0x1817EA4A0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E8EA0 Offset: 0x17E74A0 VA: 0x1817E8EA0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E9C80 Offset: 0x17E8280 VA: 0x1817E9C80 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E9BD0 Offset: 0x17E81D0 VA: 0x1817E9BD0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E9E90 Offset: 0x17E8490 VA: 0x1817E9E90 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17EA1B0 Offset: 0x17E87B0 VA: 0x1817EA1B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17EA250 Offset: 0x17E8850 VA: 0x1817EA250 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17EA2D0 Offset: 0x17E88D0 VA: 0x1817EA2D0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17EA450 Offset: 0x17E8A50 VA: 0x1817EA450 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17EA310 Offset: 0x17E8910 VA: 0x1817EA310 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E9F00 Offset: 0x17E8500 VA: 0x1817E9F00 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E9CE0 Offset: 0x17E82E0 VA: 0x1817E9CE0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17EA210 Offset: 0x17E8810 VA: 0x1817EA210 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17EA090 Offset: 0x17E8690 VA: 0x1817EA090 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17EA3D0 Offset: 0x17E89D0 VA: 0x1817EA3D0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

