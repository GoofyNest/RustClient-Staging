internal static class TimeSpanParse // TypeDefIndex: 723
{	// Fields
	private static readonly TimeSpanParse.TimeSpanToken zero; // 0x2B10378

	// Methods

	// RVA: 0x138EDC0 Offset: 0x138D3C0 VA: 0x18138EDC0
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x138A8D0 Offset: 0x1388ED0 VA: 0x18138A8D0
	internal static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x138E790 Offset: 0x138CD90 VA: 0x18138E790
	private static bool TryParseTimeSpan(string input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138A990 Offset: 0x1388F90 VA: 0x18138A990
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138AB80 Offset: 0x1389180 VA: 0x18138AB80
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138B480 Offset: 0x1389A80 VA: 0x18138B480
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138CD70 Offset: 0x138B370 VA: 0x18138CD70
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138E370 Offset: 0x138C970 VA: 0x18138E370
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138B060 Offset: 0x1389660 VA: 0x18138B060
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138F000 Offset: 0x138D600 VA: 0x18138F000
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

	// RVA: 0x1EDDC0 Offset: 0x1ED1C0 VA: 0x1801EDDC0
	public void .ctor(int number) { }

	// RVA: 0x1EDDB0 Offset: 0x1ED1B0 VA: 0x1801EDDB0
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

	// RVA: 0x1EDE80 Offset: 0x1ED280 VA: 0x1801EDE80
	internal void Init(string input) { }

	// RVA: 0x1EDE70 Offset: 0x1ED270 VA: 0x1801EDE70
	internal void Init(string input, int startPosition) { }

	// RVA: 0x1EDE50 Offset: 0x1ED250 VA: 0x1801EDE50
	internal TimeSpanParse.TimeSpanToken GetNextToken() { }

	// RVA: 0x1EDEE0 Offset: 0x1ED2E0 VA: 0x1801EDEE0
	internal bool get_EOL() { }

	// RVA: 0x1EDF10 Offset: 0x1ED310 VA: 0x1801EDF10
	internal char get_NextChar() { }

	// RVA: 0x1EDEA0 Offset: 0x1ED2A0 VA: 0x1801EDEA0
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

	// RVA: 0x1EDAC0 Offset: 0x1ECEC0 VA: 0x1801EDAC0
	internal TimeSpanFormat.FormatLiterals get_PositiveInvariant() { }

	// RVA: 0x1EDA30 Offset: 0x1ECE30 VA: 0x1801EDA30
	internal TimeSpanFormat.FormatLiterals get_NegativeInvariant() { }

	// RVA: 0x1EDAE0 Offset: 0x1ECEE0 VA: 0x1801EDAE0
	internal TimeSpanFormat.FormatLiterals get_PositiveLocalized() { }

	// RVA: 0x1EDA50 Offset: 0x1ECE50 VA: 0x1801EDA50
	internal TimeSpanFormat.FormatLiterals get_NegativeLocalized() { }

	// RVA: 0x1ED7D0 Offset: 0x1ECBD0 VA: 0x1801ED7D0
	internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED9E0 Offset: 0x1ECDE0 VA: 0x1801ED9E0
	internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED990 Offset: 0x1ECD90 VA: 0x1801ED990
	internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED890 Offset: 0x1ECC90 VA: 0x1801ED890
	internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED8D0 Offset: 0x1ECCD0 VA: 0x1801ED8D0
	internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED810 Offset: 0x1ECC10 VA: 0x1801ED810
	internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED950 Offset: 0x1ECD50 VA: 0x1801ED950
	internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED850 Offset: 0x1ECC50 VA: 0x1801ED850
	internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED910 Offset: 0x1ECD10 VA: 0x1801ED910
	internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED9D0 Offset: 0x1ECDD0 VA: 0x1801ED9D0
	internal void Init(DateTimeFormatInfo dtfi) { }

	// RVA: 0x1EDA20 Offset: 0x1ECE20 VA: 0x1801EDA20
	internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1ED7C0 Offset: 0x1ECBC0 VA: 0x1801ED7C0
	private bool AddSep(string sep, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1ED790 Offset: 0x1ECB90 VA: 0x1801ED790
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

	// RVA: 0x1EDB80 Offset: 0x1ECF80 VA: 0x1801EDB80
	internal void Init(TimeSpanParse.TimeSpanThrowStyle canThrow) { }

	// RVA: 0x1EDBB0 Offset: 0x1ECFB0 VA: 0x1801EDBB0
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1EDB90 Offset: 0x1ECF90 VA: 0x1801EDB90
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1EDBE0 Offset: 0x1ECFE0 VA: 0x1801EDBE0
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

	// RVA: 0x1EDB70 Offset: 0x1ECF70 VA: 0x1801EDB70
	internal Exception GetTimeSpanParseException() { }

}

