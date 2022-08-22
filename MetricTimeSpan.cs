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

	// RVA: 0x139F0E0 Offset: 0x139D6E0 VA: 0x18139F0E0
	public void .ctor() { }

	// RVA: 0x139EF20 Offset: 0x139D520 VA: 0x18139EF20
	public void .ctor(long totalMicroseconds) { }

	// RVA: 0x139EEF0 Offset: 0x139D4F0 VA: 0x18139EEF0
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x139EFA0 Offset: 0x139D5A0 VA: 0x18139EFA0
	public void .ctor(int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0x139F170 Offset: 0x139D770 VA: 0x18139F170
	public long get_TotalMicroseconds() { }

	// RVA: 0x139F0F0 Offset: 0x139D6F0 VA: 0x18139F0F0
	public int get_Hours() { }

	// RVA: 0x139F130 Offset: 0x139D730 VA: 0x18139F130
	public int get_Minutes() { }

	// RVA: 0x139F150 Offset: 0x139D750 VA: 0x18139F150
	public int get_Seconds() { }

	// RVA: 0x139F110 Offset: 0x139D710 VA: 0x18139F110
	public int get_Milliseconds() { }

	// RVA: 0x691EB0 Offset: 0x6904B0 VA: 0x180691EB0
	public static TimeSpan op_Implicit(MetricTimeSpan timeSpan) { }

	// RVA: 0x139F2E0 Offset: 0x139D8E0 VA: 0x18139F2E0
	public static bool op_Equality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139F390 Offset: 0x139D990 VA: 0x18139F390
	public static bool op_Inequality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139F190 Offset: 0x139D790 VA: 0x18139F190
	public static MetricTimeSpan op_Addition(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139F550 Offset: 0x139DB50 VA: 0x18139F550
	public static MetricTimeSpan op_Subtraction(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139F440 Offset: 0x139DA40 VA: 0x18139F440
	public static bool op_LessThan(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139E830 Offset: 0x139CE30 VA: 0x18139E830 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139E9A0 Offset: 0x139CFA0 VA: 0x18139E9A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x139EC80 Offset: 0x139D280 VA: 0x18139EC80 Slot: 3
	public override string ToString() { }

	// RVA: 0x139E9E0 Offset: 0x139CFE0 VA: 0x18139E9E0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x139E6D0 Offset: 0x139CCD0 VA: 0x18139E6D0 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x139E770 Offset: 0x139CD70 VA: 0x18139E770 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x139E730 Offset: 0x139CD30 VA: 0x18139E730 Slot: 7
	public int CompareTo(MetricTimeSpan other) { }

	// RVA: 0x139E910 Offset: 0x139CF10 VA: 0x18139E910 Slot: 8
	public bool Equals(MetricTimeSpan other) { }

}

