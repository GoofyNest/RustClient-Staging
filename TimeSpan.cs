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

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	public void .ctor(long ticks) { }

	// RVA: 0x1F4DE0 Offset: 0x1F41E0 VA: 0x1801F4DE0
	public void .ctor(int hours, int minutes, int seconds) { }

	// RVA: 0x1F4DD0 Offset: 0x1F41D0 VA: 0x1801F4DD0
	public void .ctor(int days, int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public long get_Ticks() { }

	// RVA: 0x1F4DF0 Offset: 0x1F41F0 VA: 0x1801F4DF0
	public int get_Days() { }

	// RVA: 0x1F4E10 Offset: 0x1F4210 VA: 0x1801F4E10
	public int get_Hours() { }

	// RVA: 0x1F4E50 Offset: 0x1F4250 VA: 0x1801F4E50
	public int get_Milliseconds() { }

	// RVA: 0x1F4EA0 Offset: 0x1F42A0 VA: 0x1801F4EA0
	public int get_Minutes() { }

	// RVA: 0x1F4EF0 Offset: 0x1F42F0 VA: 0x1801F4EF0
	public int get_Seconds() { }

	// RVA: 0x1F4F40 Offset: 0x1F4340 VA: 0x1801F4F40
	public double get_TotalHours() { }

	// RVA: 0x1F4F60 Offset: 0x1F4360 VA: 0x1801F4F60
	public double get_TotalMilliseconds() { }

	// RVA: 0x1F4FA0 Offset: 0x1F43A0 VA: 0x1801F4FA0
	public double get_TotalMinutes() { }

	// RVA: 0x1F4FC0 Offset: 0x1F43C0 VA: 0x1801F4FC0
	public double get_TotalSeconds() { }

	// RVA: 0x1F4890 Offset: 0x1F3C90 VA: 0x1801F4890
	public TimeSpan Add(TimeSpan ts) { }

	// RVA: 0x15FC310 Offset: 0x15FA910 VA: 0x1815FC310
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1F48C0 Offset: 0x1F3CC0 VA: 0x1801F48C0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F48A0 Offset: 0x1F3CA0 VA: 0x1801F48A0 Slot: 5
	public int CompareTo(TimeSpan value) { }

	// RVA: 0x15FC3D0 Offset: 0x15FA9D0 VA: 0x1815FC3D0
	public static TimeSpan FromDays(double value) { }

	// RVA: 0x1F49B0 Offset: 0x1F3DB0 VA: 0x1801F49B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1F49A0 Offset: 0x1F3DA0 VA: 0x1801F49A0 Slot: 6
	public bool Equals(TimeSpan obj) { }

	// RVA: 0x1F4A40 Offset: 0x1F3E40 VA: 0x1801F4A40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15FC430 Offset: 0x15FAA30 VA: 0x1815FC430
	public static TimeSpan FromHours(double value) { }

	// RVA: 0x15FC600 Offset: 0x15FAC00 VA: 0x1815FC600
	private static TimeSpan Interval(double value, int scale) { }

	// RVA: 0x15FC490 Offset: 0x15FAA90 VA: 0x1815FC490
	public static TimeSpan FromMilliseconds(double value) { }

	// RVA: 0x15FC4F0 Offset: 0x15FAAF0 VA: 0x1815FC4F0
	public static TimeSpan FromMinutes(double value) { }

	// RVA: 0x1F4A50 Offset: 0x1F3E50 VA: 0x1801F4A50
	public TimeSpan Negate() { }

	// RVA: 0x15FC550 Offset: 0x15FAB50 VA: 0x1815FC550
	public static TimeSpan FromSeconds(double value) { }

	// RVA: 0x1F4B10 Offset: 0x1F3F10 VA: 0x1801F4B10
	public TimeSpan Subtract(TimeSpan ts) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static TimeSpan FromTicks(long value) { }

	// RVA: 0x15FC960 Offset: 0x15FAF60 VA: 0x1815FC960
	internal static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x15FC860 Offset: 0x15FAE60 VA: 0x1815FC860
	public static TimeSpan Parse(string s) { }

	// RVA: 0x15FC7F0 Offset: 0x15FADF0 VA: 0x1815FC7F0
	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1F4B20 Offset: 0x1F3F20 VA: 0x1801F4B20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F4B80 Offset: 0x1F3F80 VA: 0x1801F4B80
	public string ToString(string format) { }

	// RVA: 0x1F4BF0 Offset: 0x1F3FF0 VA: 0x1801F4BF0 Slot: 7
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15FD0C0 Offset: 0x15FB6C0 VA: 0x1815FD0C0
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x15FD060 Offset: 0x15FB660 VA: 0x1815FD060
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x12A4AF0 Offset: 0x12A30F0 VA: 0x1812A4AF0
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x15FD0B0 Offset: 0x15FB6B0 VA: 0x1815FD0B0
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x15FD0A0 Offset: 0x15FB6A0 VA: 0x1815FD0A0
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x15FD090 Offset: 0x15FB690 VA: 0x1815FD090
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x15FD080 Offset: 0x15FB680 VA: 0x1815FD080
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x15FC5C0 Offset: 0x15FABC0 VA: 0x1815FC5C0
	private static bool GetLegacyFormatMode() { }

	// RVA: 0x15FCDC0 Offset: 0x15FB3C0 VA: 0x1815FCDC0
	private static bool get_LegacyMode() { }

	// RVA: 0x15FCAF0 Offset: 0x15FB0F0 VA: 0x1815FCAF0
	private static void .cctor() { }

}

