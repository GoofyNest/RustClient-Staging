internal static class TimeSpanFormat // TypeDefIndex: 720
{	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x138A800 Offset: 0x1388E00 VA: 0x18138A800
	private static string IntToString(int n, int digits) { }

	// RVA: 0x138A5F0 Offset: 0x1388BF0 VA: 0x18138A5F0
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x1389FD0 Offset: 0x13885D0 VA: 0x181389FD0
	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x1389570 Offset: 0x1387B70 VA: 0x181389570
	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x138A830 Offset: 0x1388E30 VA: 0x18138A830
	private static void .cctor() { }

}

internal enum TimeSpanFormat.Pattern // TypeDefIndex: 721
{	// Fields
	public int value__; // 0x0
	public const TimeSpanFormat.Pattern None = 0;
	public const TimeSpanFormat.Pattern Minimum = 1;
	public const TimeSpanFormat.Pattern Full = 2;

}

internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 722
{	// Fields
	internal string AppCompatLiteral; // 0x0
	internal int dd; // 0x8
	internal int hh; // 0xC
	internal int mm; // 0x10
	internal int ss; // 0x14
	internal int ff; // 0x18
	private string[] literals; // 0x20

	// Properties
	internal string Start { get; }
	internal string DayHourSep { get; }
	internal string HourMinuteSep { get; }
	internal string MinuteSecondSep { get; }
	internal string SecondFractionSep { get; }
	internal string End { get; }

	// Methods

	// RVA: 0x1ECD30 Offset: 0x1EC130 VA: 0x1801ECD30
	internal string get_Start() { }

	// RVA: 0x1ECBF0 Offset: 0x1EBFF0 VA: 0x1801ECBF0
	internal string get_DayHourSep() { }

	// RVA: 0x1ECC70 Offset: 0x1EC070 VA: 0x1801ECC70
	internal string get_HourMinuteSep() { }

	// RVA: 0x1ECCB0 Offset: 0x1EC0B0 VA: 0x1801ECCB0
	internal string get_MinuteSecondSep() { }

	// RVA: 0x1ECCF0 Offset: 0x1EC0F0 VA: 0x1801ECCF0
	internal string get_SecondFractionSep() { }

	// RVA: 0x1ECC30 Offset: 0x1EC030 VA: 0x1801ECC30
	internal string get_End() { }

	// RVA: 0x137D390 Offset: 0x137B990 VA: 0x18137D390
	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	// RVA: 0x1ECBE0 Offset: 0x1EBFE0 VA: 0x1801ECBE0
	internal void Init(string format, bool useInvariantFieldLengths) { }

}

