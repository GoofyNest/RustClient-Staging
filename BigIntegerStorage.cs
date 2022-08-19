internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 4365
{	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x1269D70 Offset: 0x1268370 VA: 0x181269D70
	internal void .ctor(DataColumn column) { }

	// RVA: 0x12683F0 Offset: 0x12669F0 VA: 0x1812683F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1268580 Offset: 0x1266B80 VA: 0x181268580 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1268440 Offset: 0x1266A40 VA: 0x181268440 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1268E60 Offset: 0x1267460 VA: 0x181268E60
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1268670 Offset: 0x1266C70 VA: 0x181268670
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x12695B0 Offset: 0x1267BB0 VA: 0x1812695B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1269850 Offset: 0x1267E50 VA: 0x181269850 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1269960 Offset: 0x1267F60 VA: 0x181269960 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1269BC0 Offset: 0x12681C0 VA: 0x181269BC0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1269A40 Offset: 0x1268040 VA: 0x181269A40 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1269640 Offset: 0x1267C40 VA: 0x181269640 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1268DC0 Offset: 0x12673C0 VA: 0x181268DC0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1269920 Offset: 0x1267F20 VA: 0x181269920 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12696F0 Offset: 0x1267CF0 VA: 0x1812696F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1269B20 Offset: 0x1268120 VA: 0x181269B20 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

