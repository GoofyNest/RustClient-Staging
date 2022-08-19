internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 4426
{	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x17DA8F0 Offset: 0x17D8EF0 VA: 0x1817DA8F0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D9C30 Offset: 0x17D8230 VA: 0x1817D9C30 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17DA0C0 Offset: 0x17D86C0 VA: 0x1817DA0C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17DA020 Offset: 0x17D8620 VA: 0x1817DA020 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17DA2D0 Offset: 0x17D88D0 VA: 0x1817DA2D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17DA600 Offset: 0x17D8C00 VA: 0x1817DA600 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17DA6A0 Offset: 0x17D8CA0 VA: 0x1817DA6A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DA720 Offset: 0x17D8D20 VA: 0x1817DA720 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DA8A0 Offset: 0x17D8EA0 VA: 0x1817DA8A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DA760 Offset: 0x17D8D60 VA: 0x1817DA760 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DA340 Offset: 0x17D8940 VA: 0x1817DA340 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DA120 Offset: 0x17D8720 VA: 0x1817DA120 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DA660 Offset: 0x17D8C60 VA: 0x1817DA660 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DA4E0 Offset: 0x17D8AE0 VA: 0x1817DA4E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DA820 Offset: 0x17D8E20 VA: 0x1817DA820 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

