internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 4432
{	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x1241430 Offset: 0x123FA30 VA: 0x181241430
	public void .ctor(DataColumn column) { }

	// RVA: 0x123FC60 Offset: 0x123E260 VA: 0x18123FC60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1240910 Offset: 0x123EF10 VA: 0x181240910 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1240790 Offset: 0x123ED90 VA: 0x181240790 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1240B40 Offset: 0x123F140 VA: 0x181240B40
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x1240D40 Offset: 0x123F340 VA: 0x181240D40 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1240F60 Offset: 0x123F560 VA: 0x181240F60 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1241020 Offset: 0x123F620 VA: 0x181241020 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x12412B0 Offset: 0x123F8B0 VA: 0x1812412B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1241130 Offset: 0x123F730 VA: 0x181241130 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1240DD0 Offset: 0x123F3D0 VA: 0x181240DD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1240AC0 Offset: 0x123F0C0 VA: 0x181240AC0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1240FE0 Offset: 0x123F5E0 VA: 0x181240FE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1240E40 Offset: 0x123F440 VA: 0x181240E40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1241210 Offset: 0x123F810 VA: 0x181241210 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x12413C0 Offset: 0x123F9C0 VA: 0x1812413C0
	private static void .cctor() { }

}

