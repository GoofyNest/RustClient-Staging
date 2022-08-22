internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 4412
{	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x17D7910 Offset: 0x17D5F10 VA: 0x1817D7910
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D6E30 Offset: 0x17D5430 VA: 0x1817D6E30 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D70A0 Offset: 0x17D56A0 VA: 0x1817D70A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D6FF0 Offset: 0x17D55F0 VA: 0x1817D6FF0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D72B0 Offset: 0x17D58B0 VA: 0x1817D72B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D7600 Offset: 0x17D5C00 VA: 0x1817D7600 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D76B0 Offset: 0x17D5CB0 VA: 0x1817D76B0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D7730 Offset: 0x17D5D30 VA: 0x1817D7730 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D78B0 Offset: 0x17D5EB0 VA: 0x1817D78B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D7770 Offset: 0x17D5D70 VA: 0x1817D7770 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D7320 Offset: 0x17D5920 VA: 0x1817D7320 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D7100 Offset: 0x17D5700 VA: 0x1817D7100 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D7670 Offset: 0x17D5C70 VA: 0x1817D7670 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D74C0 Offset: 0x17D5AC0 VA: 0x1817D74C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D7830 Offset: 0x17D5E30 VA: 0x1817D7830 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

