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

	// RVA: 0x139FD20 Offset: 0x139E320 VA: 0x18139FD20
	public void .ctor() { }

	// RVA: 0x139FB60 Offset: 0x139E160 VA: 0x18139FB60
	public void .ctor(long totalMicroseconds) { }

	// RVA: 0x139FB30 Offset: 0x139E130 VA: 0x18139FB30
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x139FBE0 Offset: 0x139E1E0 VA: 0x18139FBE0
	public void .ctor(int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0x139FDB0 Offset: 0x139E3B0 VA: 0x18139FDB0
	public long get_TotalMicroseconds() { }

	// RVA: 0x139FD30 Offset: 0x139E330 VA: 0x18139FD30
	public int get_Hours() { }

	// RVA: 0x139FD70 Offset: 0x139E370 VA: 0x18139FD70
	public int get_Minutes() { }

	// RVA: 0x139FD90 Offset: 0x139E390 VA: 0x18139FD90
	public int get_Seconds() { }

	// RVA: 0x139FD50 Offset: 0x139E350 VA: 0x18139FD50
	public int get_Milliseconds() { }

	// RVA: 0x691E10 Offset: 0x690410 VA: 0x180691E10
	public static TimeSpan op_Implicit(MetricTimeSpan timeSpan) { }

	// RVA: 0x139FF20 Offset: 0x139E520 VA: 0x18139FF20
	public static bool op_Equality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139FFD0 Offset: 0x139E5D0 VA: 0x18139FFD0
	public static bool op_Inequality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139FDD0 Offset: 0x139E3D0 VA: 0x18139FDD0
	public static MetricTimeSpan op_Addition(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x13A0190 Offset: 0x139E790 VA: 0x1813A0190
	public static MetricTimeSpan op_Subtraction(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x13A0080 Offset: 0x139E680 VA: 0x1813A0080
	public static bool op_LessThan(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139F470 Offset: 0x139DA70 VA: 0x18139F470 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139F5E0 Offset: 0x139DBE0 VA: 0x18139F5E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x139F8C0 Offset: 0x139DEC0 VA: 0x18139F8C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x139F620 Offset: 0x139DC20 VA: 0x18139F620 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x139F310 Offset: 0x139D910 VA: 0x18139F310 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x139F3B0 Offset: 0x139D9B0 VA: 0x18139F3B0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x139F370 Offset: 0x139D970 VA: 0x18139F370 Slot: 7
	public int CompareTo(MetricTimeSpan other) { }

	// RVA: 0x139F550 Offset: 0x139DB50 VA: 0x18139F550 Slot: 8
	public bool Equals(MetricTimeSpan other) { }

}

