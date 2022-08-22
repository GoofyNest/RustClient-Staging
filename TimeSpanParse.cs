internal static class TimeSpanParse // TypeDefIndex: 723
{	// Fields
	private static readonly TimeSpanParse.TimeSpanToken zero; // 0x13E10

	// Methods

	// RVA: 0x138FCC0 Offset: 0x138E2C0 VA: 0x18138FCC0
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x138B7D0 Offset: 0x1389DD0 VA: 0x18138B7D0
	internal static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x138F690 Offset: 0x138DC90 VA: 0x18138F690
	private static bool TryParseTimeSpan(string input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138B890 Offset: 0x1389E90 VA: 0x18138B890
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138BA80 Offset: 0x138A080 VA: 0x18138BA80
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138C380 Offset: 0x138A980 VA: 0x18138C380
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138DC70 Offset: 0x138C270 VA: 0x18138DC70
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138F270 Offset: 0x138D870 VA: 0x18138F270
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138BF60 Offset: 0x138A560 VA: 0x18138BF60
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138FF00 Offset: 0x138E500 VA: 0x18138FF00
	private static void .cctor() { }

}

private enum TimeSpanParse.TimeSpanThrowStyle // TypeDefIndex: 724
{	// Fields
	public int value__; // 0x0
	public const TimeSpanParse.TimeSpanThrowStyle None = 0;
	public const TimeSpanParse.TimeSpanThrowStyle All = 1;

}

private enum TimeSpanParse.ParseFailureKind // TypeDefIndex: 725
{	// Fields
	public int value__; // 0x0
	public const TimeSpanParse.ParseFailureKind None = 0;
	public const TimeSpanParse.ParseFailureKind ArgumentNull = 1;
	public const TimeSpanParse.ParseFailureKind Format = 2;
	public const TimeSpanParse.ParseFailureKind FormatWithParameter = 3;
	public const TimeSpanParse.ParseFailureKind Overflow = 4;

}

private enum TimeSpanParse.TimeSpanStandardStyles // TypeDefIndex: 726
{	// Fields
	public int value__; // 0x0
	public const TimeSpanParse.TimeSpanStandardStyles None = 0;
	public const TimeSpanParse.TimeSpanStandardStyles Invariant = 1;
	public const TimeSpanParse.TimeSpanStandardStyles Localized = 2;
	public const TimeSpanParse.TimeSpanStandardStyles RequireFull = 4;
	public const TimeSpanParse.TimeSpanStandardStyles Any = 3;

}

private enum TimeSpanParse.TTT // TypeDefIndex: 727
{	// Fields
	public int value__; // 0x0
	public const TimeSpanParse.TTT None = 0;
	public const TimeSpanParse.TTT End = 1;
	public const TimeSpanParse.TTT Num = 2;
	public const TimeSpanParse.TTT Sep = 3;
	public const TimeSpanParse.TTT NumOverflow = 4;

}

private struct TimeSpanParse.TimeSpanToken // TypeDefIndex: 728
{	// Fields
	internal TimeSpanParse.TTT ttt; // 0x0
	internal int num; // 0x4
	internal int zeroes; // 0x8
	internal string sep; // 0x10

	// Methods

	// RVA: 0x1ED9A0 Offset: 0x1ECDA0 VA: 0x1801ED9A0
	public void .ctor(int number) { }

	// RVA: 0x1ED990 Offset: 0x1ECD90 VA: 0x1801ED990
	public bool IsInvalidNumber(int maxValue, int maxPrecision) { }

}

private struct TimeSpanParse.TimeSpanTokenizer // TypeDefIndex: 729
{	// Fields
	private int m_pos; // 0x0
	private string m_value; // 0x8

	// Properties
	internal bool EOL { get; }
	internal char NextChar { get; }
	internal char CurrentChar { get; }

	// Methods

	// RVA: 0x1EDA60 Offset: 0x1ECE60 VA: 0x1801EDA60
	internal void Init(string input) { }

	// RVA: 0x1EDA50 Offset: 0x1ECE50 VA: 0x1801EDA50
	internal void Init(string input, int startPosition) { }

	// RVA: 0x1EDA30 Offset: 0x1ECE30 VA: 0x1801EDA30
	internal TimeSpanParse.TimeSpanToken GetNextToken() { }

	// RVA: 0x1EDAC0 Offset: 0x1ECEC0 VA: 0x1801EDAC0
	internal bool get_EOL() { }

	// RVA: 0x1EDAF0 Offset: 0x1ECEF0 VA: 0x1801EDAF0
	internal char get_NextChar() { }

	// RVA: 0x1EDA80 Offset: 0x1ECE80 VA: 0x1801EDA80
	internal char get_CurrentChar() { }

}

private struct TimeSpanParse.TimeSpanRawInfo // TypeDefIndex: 730
{	// Fields
	internal TimeSpanParse.TTT lastSeenTTT; // 0x0
	internal int tokenCount; // 0x4
	internal int SepCount; // 0x8
	internal int NumCount; // 0xC
	internal string[] literals; // 0x10
	internal TimeSpanParse.TimeSpanToken[] numbers; // 0x18
	private TimeSpanFormat.FormatLiterals m_posLoc; // 0x20
	private TimeSpanFormat.FormatLiterals m_negLoc; // 0x48
	private bool m_posLocInit; // 0x70
	private bool m_negLocInit; // 0x71
	private string m_fullPosPattern; // 0x78
	private string m_fullNegPattern; // 0x80

	// Properties
	internal TimeSpanFormat.FormatLiterals PositiveInvariant { get; }
	internal TimeSpanFormat.FormatLiterals NegativeInvariant { get; }
	internal TimeSpanFormat.FormatLiterals PositiveLocalized { get; }
	internal TimeSpanFormat.FormatLiterals NegativeLocalized { get; }

	// Methods

	// RVA: 0x1ED6A0 Offset: 0x1ECAA0 VA: 0x1801ED6A0
	internal TimeSpanFormat.FormatLiterals get_PositiveInvariant() { }

	// RVA: 0x1ED610 Offset: 0x1ECA10 VA: 0x1801ED610
	internal TimeSpanFormat.FormatLiterals get_NegativeInvariant() { }

	// RVA: 0x1ED6C0 Offset: 0x1ECAC0 VA: 0x1801ED6C0
	internal TimeSpanFormat.FormatLiterals get_PositiveLocalized() { }

	// RVA: 0x1ED630 Offset: 0x1ECA30 VA: 0x1801ED630
	internal TimeSpanFormat.FormatLiterals get_NegativeLocalized() { }

	// RVA: 0x1ED3B0 Offset: 0x1EC7B0 VA: 0x1801ED3B0
	internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED5C0 Offset: 0x1EC9C0 VA: 0x1801ED5C0
	internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED570 Offset: 0x1EC970 VA: 0x1801ED570
	internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED470 Offset: 0x1EC870 VA: 0x1801ED470
	internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED4B0 Offset: 0x1EC8B0 VA: 0x1801ED4B0
	internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED3F0 Offset: 0x1EC7F0 VA: 0x1801ED3F0
	internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED530 Offset: 0x1EC930 VA: 0x1801ED530
	internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED430 Offset: 0x1EC830 VA: 0x1801ED430
	internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED4F0 Offset: 0x1EC8F0 VA: 0x1801ED4F0
	internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED5B0 Offset: 0x1EC9B0 VA: 0x1801ED5B0
	internal void Init(DateTimeFormatInfo dtfi) { }

	// RVA: 0x1ED600 Offset: 0x1ECA00 VA: 0x1801ED600
	internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1ED3A0 Offset: 0x1EC7A0 VA: 0x1801ED3A0
	private bool AddSep(string sep, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1ED370 Offset: 0x1EC770 VA: 0x1801ED370
	private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result) { }

}

private struct TimeSpanParse.TimeSpanResult // TypeDefIndex: 731
{	// Fields
	internal TimeSpan parsedTimeSpan; // 0x0
	internal TimeSpanParse.TimeSpanThrowStyle throwStyle; // 0x8
	internal TimeSpanParse.ParseFailureKind m_failure; // 0xC
	internal string m_failureMessageID; // 0x10
	internal object m_failureMessageFormatArgument; // 0x18
	internal string m_failureArgumentName; // 0x20

	// Methods

	// RVA: 0x1ED760 Offset: 0x1ECB60 VA: 0x1801ED760
	internal void Init(TimeSpanParse.TimeSpanThrowStyle canThrow) { }

	// RVA: 0x1ED790 Offset: 0x1ECB90 VA: 0x1801ED790
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1ED770 Offset: 0x1ECB70 VA: 0x1801ED770
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1ED7C0 Offset: 0x1ECBC0 VA: 0x1801ED7C0
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

	// RVA: 0x1ED750 Offset: 0x1ECB50 VA: 0x1801ED750
	internal Exception GetTimeSpanParseException() { }

}

