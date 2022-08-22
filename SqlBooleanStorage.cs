internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 4426
{	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x17DABB0 Offset: 0x17D91B0 VA: 0x1817DABB0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D9EF0 Offset: 0x17D84F0 VA: 0x1817D9EF0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17DA380 Offset: 0x17D8980 VA: 0x1817DA380 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17DA2E0 Offset: 0x17D88E0 VA: 0x1817DA2E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17DA590 Offset: 0x17D8B90 VA: 0x1817DA590 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17DA8C0 Offset: 0x17D8EC0 VA: 0x1817DA8C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17DA960 Offset: 0x17D8F60 VA: 0x1817DA960 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DA9E0 Offset: 0x17D8FE0 VA: 0x1817DA9E0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DAB60 Offset: 0x17D9160 VA: 0x1817DAB60 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DAA20 Offset: 0x17D9020 VA: 0x1817DAA20 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DA600 Offset: 0x17D8C00 VA: 0x1817DA600 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DA3E0 Offset: 0x17D89E0 VA: 0x1817DA3E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DA920 Offset: 0x17D8F20 VA: 0x1817DA920 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DA7A0 Offset: 0x17D8DA0 VA: 0x1817DA7A0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DAAE0 Offset: 0x17D90E0 VA: 0x1817DAAE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

