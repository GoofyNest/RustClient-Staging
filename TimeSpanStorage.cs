internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 4432
{	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x12416F0 Offset: 0x123FCF0 VA: 0x1812416F0
	public void .ctor(DataColumn column) { }

	// RVA: 0x123FF20 Offset: 0x123E520 VA: 0x18123FF20 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1240BD0 Offset: 0x123F1D0 VA: 0x181240BD0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1240A50 Offset: 0x123F050 VA: 0x181240A50 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1240E00 Offset: 0x123F400 VA: 0x181240E00
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x1241000 Offset: 0x123F600 VA: 0x181241000 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1241220 Offset: 0x123F820 VA: 0x181241220 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x12412E0 Offset: 0x123F8E0 VA: 0x1812412E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1241570 Offset: 0x123FB70 VA: 0x181241570 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x12413F0 Offset: 0x123F9F0 VA: 0x1812413F0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1241090 Offset: 0x123F690 VA: 0x181241090 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1240D80 Offset: 0x123F380 VA: 0x181240D80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12412A0 Offset: 0x123F8A0 VA: 0x1812412A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1241100 Offset: 0x123F700 VA: 0x181241100 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12414D0 Offset: 0x123FAD0 VA: 0x1812414D0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1241680 Offset: 0x123FC80 VA: 0x181241680
	private static void .cctor() { }

}

