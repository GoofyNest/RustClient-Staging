internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 4365
{	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x126A6D0 Offset: 0x1268CD0 VA: 0x18126A6D0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1268D50 Offset: 0x1267350 VA: 0x181268D50 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1268EE0 Offset: 0x12674E0 VA: 0x181268EE0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1268DA0 Offset: 0x12673A0 VA: 0x181268DA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x12697C0 Offset: 0x1267DC0 VA: 0x1812697C0
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1268FD0 Offset: 0x12675D0 VA: 0x181268FD0
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1269F10 Offset: 0x1268510 VA: 0x181269F10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x126A1B0 Offset: 0x12687B0 VA: 0x18126A1B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x126A2C0 Offset: 0x12688C0 VA: 0x18126A2C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x126A520 Offset: 0x1268B20 VA: 0x18126A520 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x126A3A0 Offset: 0x12689A0 VA: 0x18126A3A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1269FA0 Offset: 0x12685A0 VA: 0x181269FA0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1269720 Offset: 0x1267D20 VA: 0x181269720 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x126A280 Offset: 0x1268880 VA: 0x18126A280 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x126A050 Offset: 0x1268650 VA: 0x18126A050 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x126A480 Offset: 0x1268A80 VA: 0x18126A480 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

