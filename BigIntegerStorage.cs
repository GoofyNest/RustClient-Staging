internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 4365
{	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x126A030 Offset: 0x1268630 VA: 0x18126A030
	internal void .ctor(DataColumn column) { }

	// RVA: 0x12686B0 Offset: 0x1266CB0 VA: 0x1812686B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1268840 Offset: 0x1266E40 VA: 0x181268840 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1268700 Offset: 0x1266D00 VA: 0x181268700 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1269120 Offset: 0x1267720 VA: 0x181269120
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1268930 Offset: 0x1266F30 VA: 0x181268930
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1269870 Offset: 0x1267E70 VA: 0x181269870 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1269B10 Offset: 0x1268110 VA: 0x181269B10 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1269C20 Offset: 0x1268220 VA: 0x181269C20 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1269E80 Offset: 0x1268480 VA: 0x181269E80 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1269D00 Offset: 0x1268300 VA: 0x181269D00 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1269900 Offset: 0x1267F00 VA: 0x181269900 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1269080 Offset: 0x1267680 VA: 0x181269080 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1269BE0 Offset: 0x12681E0 VA: 0x181269BE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12699B0 Offset: 0x1267FB0 VA: 0x1812699B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1269DE0 Offset: 0x12683E0 VA: 0x181269DE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

