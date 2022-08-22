internal sealed class CharStorage : DataStorage // TypeDefIndex: 4368
{	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x1274060 Offset: 0x1272660 VA: 0x181274060
	internal void .ctor(DataColumn column) { }

	// RVA: 0x12733E0 Offset: 0x12719E0 VA: 0x1812733E0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1273810 Offset: 0x1271E10 VA: 0x181273810 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x12736F0 Offset: 0x1271CF0 VA: 0x1812736F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1273930 Offset: 0x1271F30 VA: 0x181273930 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1273BA0 Offset: 0x12721A0 VA: 0x181273BA0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1273C80 Offset: 0x1272280 VA: 0x181273C80 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1273EB0 Offset: 0x12724B0 VA: 0x181273EB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1273D30 Offset: 0x1272330 VA: 0x181273D30 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1273A10 Offset: 0x1272010 VA: 0x181273A10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x12738B0 Offset: 0x1271EB0 VA: 0x1812738B0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1273C40 Offset: 0x1272240 VA: 0x181273C40 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1273A80 Offset: 0x1272080 VA: 0x181273A80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1273E10 Offset: 0x1272410 VA: 0x181273E10 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

