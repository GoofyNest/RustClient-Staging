internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 4430
{	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly Dictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x123F8C0 Offset: 0x123DEC0 VA: 0x18123F8C0
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x123F760 Offset: 0x123DD60 VA: 0x18123F760
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x123EFD0 Offset: 0x123D5D0 VA: 0x18123EFD0
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x123F2A0 Offset: 0x123D8A0 VA: 0x18123F2A0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123E360 Offset: 0x123C960 VA: 0x18123E360 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123E5C0 Offset: 0x123CBC0 VA: 0x18123E5C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123E3B0 Offset: 0x123C9B0 VA: 0x18123E3B0 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x123EEE0 Offset: 0x123D4E0 VA: 0x18123EEE0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123F260 Offset: 0x123D860 VA: 0x18123F260 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x123F4C0 Offset: 0x123DAC0 VA: 0x18123F4C0 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x123F360 Offset: 0x123D960 VA: 0x18123F360 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123E920 Offset: 0x123CF20 VA: 0x18123E920 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123EB40 Offset: 0x123D140 VA: 0x18123EB40 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x123E720 Offset: 0x123CD20 VA: 0x18123E720 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123E610 Offset: 0x123CC10 VA: 0x18123E610 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x123EF90 Offset: 0x123D590 VA: 0x18123EF90 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123ED50 Offset: 0x123D350 VA: 0x18123ED50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123F440 Offset: 0x123DA40 VA: 0x18123F440 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x123F700 Offset: 0x123DD00 VA: 0x18123F700
	private static void .cctor() { }

}

