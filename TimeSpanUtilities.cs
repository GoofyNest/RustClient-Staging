public static class TimeSpanUtilities // TypeDefIndex: 7499
{	// Fields
	private static readonly Dictionary<TimeSpanType, Parsing<ITimeSpan>> Parsers; // 0x0
	private static readonly Dictionary<TimeSpanType, ITimeSpan> MaximumTimeSpans; // 0x8
	private static readonly Dictionary<TimeSpanType, ITimeSpan> ZeroTimeSpans; // 0x10

	// Methods

	// RVA: 0x2202D40 Offset: 0x2201340 VA: 0x182202D40
	internal static ITimeSpan Subtract(ITimeSpan timeSpan1, ITimeSpan timeSpan2, TimeSpanMode mode) { }

	// RVA: -1 Offset: -1
	private static Parsing<ITimeSpan> GetParsing<TTimeSpan>(Parsing<TTimeSpan> parsing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F4B0 Offset: 0x125DAB0 VA: 0x18125F4B0
	|-TimeSpanUtilities.GetParsing<BarBeatFractionTimeSpan>
	|-TimeSpanUtilities.GetParsing<BarBeatTicksTimeSpan>
	|-TimeSpanUtilities.GetParsing<MetricTimeSpan>
	|-TimeSpanUtilities.GetParsing<MidiTimeSpan>
	|-TimeSpanUtilities.GetParsing<MusicalTimeSpan>
	|-TimeSpanUtilities.GetParsing<object>
	*/

	// RVA: 0x2202DE0 Offset: 0x22013E0 VA: 0x182202DE0
	private static void .cctor() { }

}

private sealed class TimeSpanUtilities.<>c__DisplayClass12_0<TTimeSpan> // TypeDefIndex: 7500
{	// Fields
	public Parsing<TTimeSpan> parsing; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal ParsingResult <GetParsing>b__0(string input, out ITimeSpan timeSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCB90 Offset: 0x17FB190 VA: 0x1817FCB90
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>.<GetParsing>b__0
	*/

}

