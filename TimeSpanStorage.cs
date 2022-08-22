internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 4432
{	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x1241D90 Offset: 0x1240390 VA: 0x181241D90
	public void .ctor(DataColumn column) { }

	// RVA: 0x12405C0 Offset: 0x123EBC0 VA: 0x1812405C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1241270 Offset: 0x123F870 VA: 0x181241270 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x12410F0 Offset: 0x123F6F0 VA: 0x1812410F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x12414A0 Offset: 0x123FAA0 VA: 0x1812414A0
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x12416A0 Offset: 0x123FCA0 VA: 0x1812416A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x12418C0 Offset: 0x123FEC0 VA: 0x1812418C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1241980 Offset: 0x123FF80 VA: 0x181241980 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1241C10 Offset: 0x1240210 VA: 0x181241C10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1241A90 Offset: 0x1240090 VA: 0x181241A90 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1241730 Offset: 0x123FD30 VA: 0x181241730 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1241420 Offset: 0x123FA20 VA: 0x181241420 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1241940 Offset: 0x123FF40 VA: 0x181241940 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12417A0 Offset: 0x123FDA0 VA: 0x1812417A0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1241B70 Offset: 0x1240170 VA: 0x181241B70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1241D20 Offset: 0x1240320 VA: 0x181241D20
	private static void .cctor() { }

}

