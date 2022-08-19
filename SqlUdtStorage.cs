internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 4430
{	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly Dictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x123EF60 Offset: 0x123D560 VA: 0x18123EF60
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x123EE00 Offset: 0x123D400 VA: 0x18123EE00
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x123E670 Offset: 0x123CC70 VA: 0x18123E670
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x123E940 Offset: 0x123CF40 VA: 0x18123E940 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123DA00 Offset: 0x123C000 VA: 0x18123DA00 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123DC60 Offset: 0x123C260 VA: 0x18123DC60 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123DA50 Offset: 0x123C050 VA: 0x18123DA50 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x123E580 Offset: 0x123CB80 VA: 0x18123E580 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123E900 Offset: 0x123CF00 VA: 0x18123E900 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x123EB60 Offset: 0x123D160 VA: 0x18123EB60 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x123EA00 Offset: 0x123D000 VA: 0x18123EA00 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123DFC0 Offset: 0x123C5C0 VA: 0x18123DFC0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123E1E0 Offset: 0x123C7E0 VA: 0x18123E1E0 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x123DDC0 Offset: 0x123C3C0 VA: 0x18123DDC0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123DCB0 Offset: 0x123C2B0 VA: 0x18123DCB0 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x123E630 Offset: 0x123CC30 VA: 0x18123E630 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123E3F0 Offset: 0x123C9F0 VA: 0x18123E3F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123EAE0 Offset: 0x123D0E0 VA: 0x18123EAE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x123EDA0 Offset: 0x123D3A0 VA: 0x18123EDA0
	private static void .cctor() { }

}

