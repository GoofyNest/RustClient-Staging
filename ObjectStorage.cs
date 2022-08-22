internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 4406
{	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x17D67E0 Offset: 0x17D4DE0 VA: 0x1817D67E0
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x17D33F0 Offset: 0x17D19F0 VA: 0x1817D33F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D3B70 Offset: 0x17D2170 VA: 0x1817D3B70 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D35B0 Offset: 0x17D1BB0 VA: 0x1817D35B0 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x17D3440 Offset: 0x17D1A40 VA: 0x1817D3440
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x17D3740 Offset: 0x17D1D40 VA: 0x1817D3740
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x123F7D0 Offset: 0x123DDD0 VA: 0x18123F7D0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123F900 Offset: 0x123DF00 VA: 0x18123F900 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x17D5040 Offset: 0x17D3640 VA: 0x1817D5040
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x123F940 Offset: 0x123DF40 VA: 0x18123F940 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D5A60 Offset: 0x17D4060 VA: 0x1817D5A60 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x17D57A0 Offset: 0x17D3DA0 VA: 0x1817D57A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D4370 Offset: 0x17D2970 VA: 0x1817D4370 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D4760 Offset: 0x17D2D60 VA: 0x1817D4760 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x17D3E00 Offset: 0x17D2400 VA: 0x1817D3E00 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D3CE0 Offset: 0x17D22E0 VA: 0x1817D3CE0 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x17D5000 Offset: 0x17D3600 VA: 0x1817D5000 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D4D70 Offset: 0x17D3370 VA: 0x1817D4D70 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D5860 Offset: 0x17D3E60 VA: 0x1817D5860 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x17D6610 Offset: 0x17D4C10 VA: 0x1817D6610
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x17D5190 Offset: 0x17D3790 VA: 0x1817D5190
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x17D5210 Offset: 0x17D3810 VA: 0x1817D5210
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x17D6730 Offset: 0x17D4D30 VA: 0x1817D6730
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
	internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default; // 0x2B10480

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x17ED440 Offset: 0x17EBA40 VA: 0x1817ED440 Slot: 4
	public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

	// RVA: 0x17ED570 Offset: 0x17EBB70 VA: 0x1817ED570 Slot: 5
	public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	// RVA: 0x17ED5F0 Offset: 0x17EBBF0 VA: 0x1817ED5F0
	private static void .cctor() { }

}

