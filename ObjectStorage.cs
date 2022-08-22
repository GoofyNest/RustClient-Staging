internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 4406
{	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x17D45F0 Offset: 0x17D2BF0 VA: 0x1817D45F0
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x17D1200 Offset: 0x17CF800 VA: 0x1817D1200 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D1980 Offset: 0x17CFF80 VA: 0x1817D1980 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D13C0 Offset: 0x17CF9C0 VA: 0x1817D13C0 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x17D1250 Offset: 0x17CF850 VA: 0x1817D1250
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x17D1550 Offset: 0x17CFB50 VA: 0x1817D1550
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x1240130 Offset: 0x123E730 VA: 0x181240130 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1240260 Offset: 0x123E860 VA: 0x181240260 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x17D2E50 Offset: 0x17D1450 VA: 0x1817D2E50
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x12402A0 Offset: 0x123E8A0 VA: 0x1812402A0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D3870 Offset: 0x17D1E70 VA: 0x1817D3870 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x17D35B0 Offset: 0x17D1BB0 VA: 0x1817D35B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D2180 Offset: 0x17D0780 VA: 0x1817D2180 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D2570 Offset: 0x17D0B70 VA: 0x1817D2570 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x17D1C10 Offset: 0x17D0210 VA: 0x1817D1C10 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D1AF0 Offset: 0x17D00F0 VA: 0x1817D1AF0 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x17D2E10 Offset: 0x17D1410 VA: 0x1817D2E10 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D2B80 Offset: 0x17D1180 VA: 0x1817D2B80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D3670 Offset: 0x17D1C70 VA: 0x1817D3670 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x17D4420 Offset: 0x17D2A20 VA: 0x1817D4420
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x17D2FA0 Offset: 0x17D15A0 VA: 0x1817D2FA0
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x17D3020 Offset: 0x17D1620 VA: 0x1817D3020
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x17D4540 Offset: 0x17D2B40 VA: 0x1817D4540
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
	internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default; // 0x133B1

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x17EB250 Offset: 0x17E9850 VA: 0x1817EB250 Slot: 4
	public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

	// RVA: 0x17EB380 Offset: 0x17E9980 VA: 0x1817EB380 Slot: 5
	public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	// RVA: 0x17EB400 Offset: 0x17E9A00 VA: 0x1817EB400
	private static void .cctor() { }

}

