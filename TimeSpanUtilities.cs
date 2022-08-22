public static class TimeSpanUtilities // TypeDefIndex: 7499
{	private static readonly Dictionary<TimeSpanType, Parsing<ITimeSpan>> Parsers; // 0x0
	private static readonly Dictionary<TimeSpanType, ITimeSpan> MaximumTimeSpans; // 0x8
	private static readonly Dictionary<TimeSpanType, ITimeSpan> ZeroTimeSpans; // 0x10


	internal static ITimeSpan Subtract(ITimeSpan timeSpan1, ITimeSpan timeSpan2, TimeSpanMode mode) { }

	private static Parsing<ITimeSpan> GetParsing<TTimeSpan>(Parsing<TTimeSpan> parsing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125FB50 Offset: 0x125E150 VA: 0x18125FB50
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
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>..ctor
	*/

	internal ParsingResult <GetParsing>b__0(string input, out ITimeSpan timeSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650A90 Offset: 0x164F090 VA: 0x181650A90
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>.<GetParsing>b__0
	*/

}

