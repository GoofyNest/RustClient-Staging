internal static class TimeSpanFormat // TypeDefIndex: 720
{	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x138B440 Offset: 0x1389A40 VA: 0x18138B440
	private static string IntToString(int n, int digits) { }

	// RVA: 0x138B230 Offset: 0x1389830 VA: 0x18138B230
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x138AC10 Offset: 0x1389210 VA: 0x18138AC10
	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x138A1B0 Offset: 0x13887B0 VA: 0x18138A1B0
	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x138B470 Offset: 0x1389A70 VA: 0x18138B470
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

	// RVA: 0x1EC910 Offset: 0x1EBD10 VA: 0x1801EC910
	internal string get_Start() { }

	// RVA: 0x1EC7D0 Offset: 0x1EBBD0 VA: 0x1801EC7D0
	internal string get_DayHourSep() { }

	// RVA: 0x1EC850 Offset: 0x1EBC50 VA: 0x1801EC850
	internal string get_HourMinuteSep() { }

	// RVA: 0x1EC890 Offset: 0x1EBC90 VA: 0x1801EC890
	internal string get_MinuteSecondSep() { }

	// RVA: 0x1EC8D0 Offset: 0x1EBCD0 VA: 0x1801EC8D0
	internal string get_SecondFractionSep() { }

	// RVA: 0x1EC810 Offset: 0x1EBC10 VA: 0x1801EC810
	internal string get_End() { }

	// RVA: 0x137DFD0 Offset: 0x137C5D0 VA: 0x18137DFD0
	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	// RVA: 0x1EC7C0 Offset: 0x1EBBC0 VA: 0x1801EC7C0
	internal void Init(string format, bool useInvariantFieldLengths) { }

}

