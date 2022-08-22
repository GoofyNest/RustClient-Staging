internal sealed class Int16Storage : DataStorage // TypeDefIndex: 4403
{	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x17CF050 Offset: 0x17CD650 VA: 0x1817CF050
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CE0D0 Offset: 0x17CC6D0 VA: 0x1817CE0D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CE940 Offset: 0x17CCF40 VA: 0x1817CE940 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CE830 Offset: 0x17CCE30 VA: 0x1817CE830 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CEA50 Offset: 0x17CD050 VA: 0x1817CEA50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1242B10 Offset: 0x1241110 VA: 0x181242B10 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CED00 Offset: 0x17CD300 VA: 0x1817CED00 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CEF20 Offset: 0x17CD520 VA: 0x1817CEF20 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CEDA0 Offset: 0x17CD3A0 VA: 0x1817CEDA0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CEB30 Offset: 0x17CD130 VA: 0x1817CEB30 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CE9D0 Offset: 0x17CCFD0 VA: 0x1817CE9D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CECC0 Offset: 0x17CD2C0 VA: 0x1817CECC0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CEBA0 Offset: 0x17CD1A0 VA: 0x1817CEBA0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CEE80 Offset: 0x17CD480 VA: 0x1817CEE80 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

