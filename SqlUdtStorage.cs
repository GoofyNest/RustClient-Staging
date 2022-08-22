internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 4430
{	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly Dictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x123F220 Offset: 0x123D820 VA: 0x18123F220
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x123F0C0 Offset: 0x123D6C0 VA: 0x18123F0C0
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x123E930 Offset: 0x123CF30 VA: 0x18123E930
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x123EC00 Offset: 0x123D200 VA: 0x18123EC00 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123DCC0 Offset: 0x123C2C0 VA: 0x18123DCC0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123DF20 Offset: 0x123C520 VA: 0x18123DF20 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123DD10 Offset: 0x123C310 VA: 0x18123DD10 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x123E840 Offset: 0x123CE40 VA: 0x18123E840 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123EBC0 Offset: 0x123D1C0 VA: 0x18123EBC0 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x123EE20 Offset: 0x123D420 VA: 0x18123EE20 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x123ECC0 Offset: 0x123D2C0 VA: 0x18123ECC0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123E280 Offset: 0x123C880 VA: 0x18123E280 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123E4A0 Offset: 0x123CAA0 VA: 0x18123E4A0 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x123E080 Offset: 0x123C680 VA: 0x18123E080 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123DF70 Offset: 0x123C570 VA: 0x18123DF70 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x123E8F0 Offset: 0x123CEF0 VA: 0x18123E8F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123E6B0 Offset: 0x123CCB0 VA: 0x18123E6B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123EDA0 Offset: 0x123D3A0 VA: 0x18123EDA0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x123F060 Offset: 0x123D660 VA: 0x18123F060
	private static void .cctor() { }

}

