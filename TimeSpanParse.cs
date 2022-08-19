internal static class TimeSpanParse // TypeDefIndex: 723
{	// Fields
	private static readonly TimeSpanParse.TimeSpanToken zero; // 0x13E10

	// Methods

	// RVA: 0x138FA00 Offset: 0x138E000 VA: 0x18138FA00
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x138B510 Offset: 0x1389B10 VA: 0x18138B510
	internal static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x138F3D0 Offset: 0x138D9D0 VA: 0x18138F3D0
	private static bool TryParseTimeSpan(string input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138B5D0 Offset: 0x1389BD0 VA: 0x18138B5D0
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138B7C0 Offset: 0x1389DC0 VA: 0x18138B7C0
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138C0C0 Offset: 0x138A6C0 VA: 0x18138C0C0
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138D9B0 Offset: 0x138BFB0 VA: 0x18138D9B0
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138EFB0 Offset: 0x138D5B0 VA: 0x18138EFB0
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138BCA0 Offset: 0x138A2A0 VA: 0x18138BCA0
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138FC40 Offset: 0x138E240 VA: 0x18138FC40
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

	// RVA: 0x1EDA20 Offset: 0x1ECE20 VA: 0x1801EDA20
	public void .ctor(int number) { }

	// RVA: 0x1EDA10 Offset: 0x1ECE10 VA: 0x1801EDA10
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

	// RVA: 0x1EDAE0 Offset: 0x1ECEE0 VA: 0x1801EDAE0
	internal void Init(string input) { }

	// RVA: 0x1EDAD0 Offset: 0x1ECED0 VA: 0x1801EDAD0
	internal void Init(string input, int startPosition) { }

	// RVA: 0x1EDAB0 Offset: 0x1ECEB0 VA: 0x1801EDAB0
	internal TimeSpanParse.TimeSpanToken GetNextToken() { }

	// RVA: 0x1EDB40 Offset: 0x1ECF40 VA: 0x1801EDB40
	internal bool get_EOL() { }

	// RVA: 0x1EDB70 Offset: 0x1ECF70 VA: 0x1801EDB70
	internal char get_NextChar() { }

	// RVA: 0x1EDB00 Offset: 0x1ECF00 VA: 0x1801EDB00
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

	// RVA: 0x1ED720 Offset: 0x1ECB20 VA: 0x1801ED720
	internal TimeSpanFormat.FormatLiterals get_PositiveInvariant() { }

	// RVA: 0x1ED690 Offset: 0x1ECA90 VA: 0x1801ED690
	internal TimeSpanFormat.FormatLiterals get_NegativeInvariant() { }

	// RVA: 0x1ED740 Offset: 0x1ECB40 VA: 0x1801ED740
	internal TimeSpanFormat.FormatLiterals get_PositiveLocalized() { }

	// RVA: 0x1ED6B0 Offset: 0x1ECAB0 VA: 0x1801ED6B0
	internal TimeSpanFormat.FormatLiterals get_NegativeLocalized() { }

	// RVA: 0x1ED430 Offset: 0x1EC830 VA: 0x1801ED430
	internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED640 Offset: 0x1ECA40 VA: 0x1801ED640
	internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED5F0 Offset: 0x1EC9F0 VA: 0x1801ED5F0
	internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED4F0 Offset: 0x1EC8F0 VA: 0x1801ED4F0
	internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED530 Offset: 0x1EC930 VA: 0x1801ED530
	internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED470 Offset: 0x1EC870 VA: 0x1801ED470
	internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED5B0 Offset: 0x1EC9B0 VA: 0x1801ED5B0
	internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED4B0 Offset: 0x1EC8B0 VA: 0x1801ED4B0
	internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED570 Offset: 0x1EC970 VA: 0x1801ED570
	internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED630 Offset: 0x1ECA30 VA: 0x1801ED630
	internal void Init(DateTimeFormatInfo dtfi) { }

	// RVA: 0x1ED680 Offset: 0x1ECA80 VA: 0x1801ED680
	internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1ED420 Offset: 0x1EC820 VA: 0x1801ED420
	private bool AddSep(string sep, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1ED3F0 Offset: 0x1EC7F0 VA: 0x1801ED3F0
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

	// RVA: 0x1ED7E0 Offset: 0x1ECBE0 VA: 0x1801ED7E0
	internal void Init(TimeSpanParse.TimeSpanThrowStyle canThrow) { }

	// RVA: 0x1ED810 Offset: 0x1ECC10 VA: 0x1801ED810
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1ED7F0 Offset: 0x1ECBF0 VA: 0x1801ED7F0
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1ED840 Offset: 0x1ECC40 VA: 0x1801ED840
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

	// RVA: 0x1ED7D0 Offset: 0x1ECBD0 VA: 0x1801ED7D0
	internal Exception GetTimeSpanParseException() { }

}

