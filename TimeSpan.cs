public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable // TypeDefIndex: 312
{	// Fields
	public const long TicksPerMillisecond = 10000;
	private const double MillisecondsPerTick = 0,0001;
	public const long TicksPerSecond = 10000000;
	private const double SecondsPerTick = 1E-07;
	public const long TicksPerMinute = 600000000;
	private const double MinutesPerTick = 1,66666666666667E-09;
	public const long TicksPerHour = 36000000000;
	private const double HoursPerTick = 2,77777777777778E-11;
	public const long TicksPerDay = 864000000000;
	private const double DaysPerTick = 1,15740740740741E-12;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	internal const long MaxSeconds = 922337203685;
	internal const long MinSeconds = -922337203685;
	internal const long MaxMilliSeconds = 922337203685477;
	internal const long MinMilliSeconds = -922337203685477;
	internal const long TicksPerTenthSecond = 1000000;
	public static readonly TimeSpan Zero; // 0x0
	public static readonly TimeSpan MaxValue; // 0x8
	public static readonly TimeSpan MinValue; // 0x10
	internal long _ticks; // 0x0
	private static bool _legacyConfigChecked; // 0x18
	private static bool _legacyMode; // 0x19

	// Properties
	public long Ticks { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Milliseconds { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public double TotalHours { get; }
	public double TotalMilliseconds { get; }
	public double TotalMinutes { get; }
	public double TotalSeconds { get; }
	private static bool LegacyMode { get; }

	// Methods

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	public void .ctor(long ticks) { }

	// RVA: 0x1F5F90 Offset: 0x1F5390 VA: 0x1801F5F90
	public void .ctor(int hours, int minutes, int seconds) { }

	// RVA: 0x1F5F80 Offset: 0x1F5380 VA: 0x1801F5F80
	public void .ctor(int days, int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public long get_Ticks() { }

	// RVA: 0x1F5FA0 Offset: 0x1F53A0 VA: 0x1801F5FA0
	public int get_Days() { }

	// RVA: 0x1F5FC0 Offset: 0x1F53C0 VA: 0x1801F5FC0
	public int get_Hours() { }

	// RVA: 0x1F6000 Offset: 0x1F5400 VA: 0x1801F6000
	public int get_Milliseconds() { }

	// RVA: 0x1F6050 Offset: 0x1F5450 VA: 0x1801F6050
	public int get_Minutes() { }

	// RVA: 0x1F60A0 Offset: 0x1F54A0 VA: 0x1801F60A0
	public int get_Seconds() { }

	// RVA: 0x1F60F0 Offset: 0x1F54F0 VA: 0x1801F60F0
	public double get_TotalHours() { }

	// RVA: 0x1F6110 Offset: 0x1F5510 VA: 0x1801F6110
	public double get_TotalMilliseconds() { }

	// RVA: 0x1F6150 Offset: 0x1F5550 VA: 0x1801F6150
	public double get_TotalMinutes() { }

	// RVA: 0x1F6170 Offset: 0x1F5570 VA: 0x1801F6170
	public double get_TotalSeconds() { }

	// RVA: 0x1F5A40 Offset: 0x1F4E40 VA: 0x1801F5A40
	public TimeSpan Add(TimeSpan ts) { }

	// RVA: 0x160ED30 Offset: 0x160D330 VA: 0x18160ED30
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1F5A70 Offset: 0x1F4E70 VA: 0x1801F5A70 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F5A50 Offset: 0x1F4E50 VA: 0x1801F5A50 Slot: 5
	public int CompareTo(TimeSpan value) { }

	// RVA: 0x160EDF0 Offset: 0x160D3F0 VA: 0x18160EDF0
	public static TimeSpan FromDays(double value) { }

	// RVA: 0x1F5B60 Offset: 0x1F4F60 VA: 0x1801F5B60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1F5B50 Offset: 0x1F4F50 VA: 0x1801F5B50 Slot: 6
	public bool Equals(TimeSpan obj) { }

	// RVA: 0x1F5BF0 Offset: 0x1F4FF0 VA: 0x1801F5BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x160EE50 Offset: 0x160D450 VA: 0x18160EE50
	public static TimeSpan FromHours(double value) { }

	// RVA: 0x160F020 Offset: 0x160D620 VA: 0x18160F020
	private static TimeSpan Interval(double value, int scale) { }

	// RVA: 0x160EEB0 Offset: 0x160D4B0 VA: 0x18160EEB0
	public static TimeSpan FromMilliseconds(double value) { }

	// RVA: 0x160EF10 Offset: 0x160D510 VA: 0x18160EF10
	public static TimeSpan FromMinutes(double value) { }

	// RVA: 0x1F5C00 Offset: 0x1F5000 VA: 0x1801F5C00
	public TimeSpan Negate() { }

	// RVA: 0x160EF70 Offset: 0x160D570 VA: 0x18160EF70
	public static TimeSpan FromSeconds(double value) { }

	// RVA: 0x1F5CC0 Offset: 0x1F50C0 VA: 0x1801F5CC0
	public TimeSpan Subtract(TimeSpan ts) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static TimeSpan FromTicks(long value) { }

	// RVA: 0x160F380 Offset: 0x160D980 VA: 0x18160F380
	internal static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x160F280 Offset: 0x160D880 VA: 0x18160F280
	public static TimeSpan Parse(string s) { }

	// RVA: 0x160F210 Offset: 0x160D810 VA: 0x18160F210
	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1F5CD0 Offset: 0x1F50D0 VA: 0x1801F5CD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F5D30 Offset: 0x1F5130 VA: 0x1801F5D30
	public string ToString(string format) { }

	// RVA: 0x1F5DA0 Offset: 0x1F51A0 VA: 0x1801F5DA0 Slot: 7
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x160FAE0 Offset: 0x160E0E0 VA: 0x18160FAE0
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160FA80 Offset: 0x160E080 VA: 0x18160FA80
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x12A4190 Offset: 0x12A2790 VA: 0x1812A4190
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160FAD0 Offset: 0x160E0D0 VA: 0x18160FAD0
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160FAC0 Offset: 0x160E0C0 VA: 0x18160FAC0
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160FAB0 Offset: 0x160E0B0 VA: 0x18160FAB0
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160FAA0 Offset: 0x160E0A0 VA: 0x18160FAA0
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160EFE0 Offset: 0x160D5E0 VA: 0x18160EFE0
	private static bool GetLegacyFormatMode() { }

	// RVA: 0x160F7E0 Offset: 0x160DDE0 VA: 0x18160F7E0
	private static bool get_LegacyMode() { }

	// RVA: 0x160F510 Offset: 0x160DB10 VA: 0x18160F510
	private static void .cctor() { }

}

