public sealed class MetricTimeSpan : ITimeSpan, IComparable, IComparable<MetricTimeSpan>, IEquatable<MetricTimeSpan> // TypeDefIndex: 7492
{	// Fields
	private readonly TimeSpan _timeSpan; // 0x10

	// Properties
	public long TotalMicroseconds { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Milliseconds { get; }

	// Methods

	// RVA: 0x139FFE0 Offset: 0x139E5E0 VA: 0x18139FFE0
	public void .ctor() { }

	// RVA: 0x139FE20 Offset: 0x139E420 VA: 0x18139FE20
	public void .ctor(long totalMicroseconds) { }

	// RVA: 0x139FDF0 Offset: 0x139E3F0 VA: 0x18139FDF0
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x139FEA0 Offset: 0x139E4A0 VA: 0x18139FEA0
	public void .ctor(int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0x13A0070 Offset: 0x139E670 VA: 0x1813A0070
	public long get_TotalMicroseconds() { }

	// RVA: 0x139FFF0 Offset: 0x139E5F0 VA: 0x18139FFF0
	public int get_Hours() { }

	// RVA: 0x13A0030 Offset: 0x139E630 VA: 0x1813A0030
	public int get_Minutes() { }

	// RVA: 0x13A0050 Offset: 0x139E650 VA: 0x1813A0050
	public int get_Seconds() { }

	// RVA: 0x13A0010 Offset: 0x139E610 VA: 0x1813A0010
	public int get_Milliseconds() { }

	// RVA: 0x691F20 Offset: 0x690520 VA: 0x180691F20
	public static TimeSpan op_Implicit(MetricTimeSpan timeSpan) { }

	// RVA: 0x13A01E0 Offset: 0x139E7E0 VA: 0x1813A01E0
	public static bool op_Equality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x13A0290 Offset: 0x139E890 VA: 0x1813A0290
	public static bool op_Inequality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x13A0090 Offset: 0x139E690 VA: 0x1813A0090
	public static MetricTimeSpan op_Addition(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x13A0450 Offset: 0x139EA50 VA: 0x1813A0450
	public static MetricTimeSpan op_Subtraction(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x13A0340 Offset: 0x139E940 VA: 0x1813A0340
	public static bool op_LessThan(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139F730 Offset: 0x139DD30 VA: 0x18139F730 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139F8A0 Offset: 0x139DEA0 VA: 0x18139F8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x139FB80 Offset: 0x139E180 VA: 0x18139FB80 Slot: 3
	public override string ToString() { }

	// RVA: 0x139F8E0 Offset: 0x139DEE0 VA: 0x18139F8E0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x139F5D0 Offset: 0x139DBD0 VA: 0x18139F5D0 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x139F670 Offset: 0x139DC70 VA: 0x18139F670 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x139F630 Offset: 0x139DC30 VA: 0x18139F630 Slot: 7
	public int CompareTo(MetricTimeSpan other) { }

	// RVA: 0x139F810 Offset: 0x139DE10 VA: 0x18139F810 Slot: 8
	public bool Equals(MetricTimeSpan other) { }

}

