internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 4417
{	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x17E4910 Offset: 0x17E2F10 VA: 0x1817E4910
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E31B0 Offset: 0x17E17B0 VA: 0x1817E31B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E4010 Offset: 0x17E2610 VA: 0x1817E4010 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E3F50 Offset: 0x17E2550 VA: 0x1817E3F50 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E4240 Offset: 0x17E2840 VA: 0x1817E4240 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E45D0 Offset: 0x17E2BD0 VA: 0x1817E45D0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E4680 Offset: 0x17E2C80 VA: 0x1817E4680 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E4710 Offset: 0x17E2D10 VA: 0x1817E4710 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E48A0 Offset: 0x17E2EA0 VA: 0x1817E48A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E4760 Offset: 0x17E2D60 VA: 0x1817E4760 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E42C0 Offset: 0x17E28C0 VA: 0x1817E42C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E4090 Offset: 0x17E2690 VA: 0x1817E4090 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E4640 Offset: 0x17E2C40 VA: 0x1817E4640 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E4480 Offset: 0x17E2A80 VA: 0x1817E4480 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E4820 Offset: 0x17E2E20 VA: 0x1817E4820 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

