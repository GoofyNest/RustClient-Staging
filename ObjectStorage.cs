internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 4406
{	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x17D6AA0 Offset: 0x17D50A0 VA: 0x1817D6AA0
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x17D36B0 Offset: 0x17D1CB0 VA: 0x1817D36B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D3E30 Offset: 0x17D2430 VA: 0x1817D3E30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D3870 Offset: 0x17D1E70 VA: 0x1817D3870 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x17D3700 Offset: 0x17D1D00 VA: 0x1817D3700
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x17D3A00 Offset: 0x17D2000 VA: 0x1817D3A00
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x123FA90 Offset: 0x123E090 VA: 0x18123FA90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123FBC0 Offset: 0x123E1C0 VA: 0x18123FBC0 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x17D5300 Offset: 0x17D3900 VA: 0x1817D5300
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x123FC00 Offset: 0x123E200 VA: 0x18123FC00 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D5D20 Offset: 0x17D4320 VA: 0x1817D5D20 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x17D5A60 Offset: 0x17D4060 VA: 0x1817D5A60 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D4630 Offset: 0x17D2C30 VA: 0x1817D4630 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D4A20 Offset: 0x17D3020 VA: 0x1817D4A20 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x17D40C0 Offset: 0x17D26C0 VA: 0x1817D40C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D3FA0 Offset: 0x17D25A0 VA: 0x1817D3FA0 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x17D52C0 Offset: 0x17D38C0 VA: 0x1817D52C0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D5030 Offset: 0x17D3630 VA: 0x1817D5030 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D5B20 Offset: 0x17D4120 VA: 0x1817D5B20 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x17D68D0 Offset: 0x17D4ED0 VA: 0x1817D68D0
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x17D5450 Offset: 0x17D3A50 VA: 0x1817D5450
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x17D54D0 Offset: 0x17D3AD0 VA: 0x1817D54D0
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x17D69F0 Offset: 0x17D4FF0 VA: 0x1817D69F0
	private static void .cctor() { }

}

private enum ObjectStorage.Families // TypeDefIndex: 4407
{	// Fields
	public int value__; // 0x0
	public const ObjectStorage.Families DATETIME = 0;
	public const ObjectStorage.Families NUMBER = 1;
	public const ObjectStorage.Families STRING = 2;
	public const ObjectStorage.Families BOOLEAN = 3;
	public const ObjectStorage.Families ARRAY = 4;

}

private class ObjectStorage.TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> // TypeDefIndex: 4408
{	// Fields
	internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default; // 0x2B114C0

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x17ED700 Offset: 0x17EBD00 VA: 0x1817ED700 Slot: 4
	public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

	// RVA: 0x17ED830 Offset: 0x17EBE30 VA: 0x1817ED830 Slot: 5
	public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	// RVA: 0x17ED8B0 Offset: 0x17EBEB0 VA: 0x1817ED8B0
	private static void .cctor() { }

}

