public static class TimeSpanUtilities // TypeDefIndex: 7499
{	private static readonly Dictionary<TimeSpanType, Parsing<ITimeSpan>> Parsers; // 0x0
	private static readonly Dictionary<TimeSpanType, ITimeSpan> MaximumTimeSpans; // 0x8
	private static readonly Dictionary<TimeSpanType, ITimeSpan> ZeroTimeSpans; // 0x10


	internal static ITimeSpan Subtract(ITimeSpan timeSpan1, ITimeSpan timeSpan2, TimeSpanMode mode) { }

	private static Parsing<ITimeSpan> GetParsing<TTimeSpan>(Parsing<TTimeSpan> parsing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125FB90 Offset: 0x125E190 VA: 0x18125FB90
	|-TimeSpanUtilities.GetParsing<BarBeatFractionTimeSpan>
	|-TimeSpanUtilities.GetParsing<BarBeatTicksTimeSpan>
	|-TimeSpanUtilities.GetParsing<MetricTimeSpan>
	|-TimeSpanUtilities.GetParsing<MidiTimeSpan>
	|-TimeSpanUtilities.GetParsing<MusicalTimeSpan>
	|-TimeSpanUtilities.GetParsing<object>
	*/

	private static void .cctor() { }

}

private sealed class TimeSpanUtilities.<>c__DisplayClass12_0<TTimeSpan> // TypeDefIndex: 7500
{	public Parsing<TTimeSpan> parsing; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>..ctor
	*/

	internal ParsingResult <GetParsing>b__0(string input, out ITimeSpan timeSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650AD0 Offset: 0x164F0D0 VA: 0x181650AD0
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>.<GetParsing>b__0
	*/

}

