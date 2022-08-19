public static class TimeSpanUtilities // TypeDefIndex: 7499
{	// Fields
	private static readonly Dictionary<TimeSpanType, Parsing<ITimeSpan>> Parsers; // 0x0
	private static readonly Dictionary<TimeSpanType, ITimeSpan> MaximumTimeSpans; // 0x8
	private static readonly Dictionary<TimeSpanType, ITimeSpan> ZeroTimeSpans; // 0x10

	// Methods

	// RVA: 0x2202C40 Offset: 0x2201240 VA: 0x182202C40
	internal static ITimeSpan Subtract(ITimeSpan timeSpan1, ITimeSpan timeSpan2, TimeSpanMode mode) { }

	// RVA: -1 Offset: -1
	private static Parsing<ITimeSpan> GetParsing<TTimeSpan>(Parsing<TTimeSpan> parsing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F1F0 Offset: 0x125D7F0 VA: 0x18125F1F0
	|-TimeSpanUtilities.GetParsing<BarBeatFractionTimeSpan>
	|-TimeSpanUtilities.GetParsing<BarBeatTicksTimeSpan>
	|-TimeSpanUtilities.GetParsing<MetricTimeSpan>
	|-TimeSpanUtilities.GetParsing<MidiTimeSpan>
	|-TimeSpanUtilities.GetParsing<MusicalTimeSpan>
	|-TimeSpanUtilities.GetParsing<object>
	*/

	// RVA: 0x2202CE0 Offset: 0x22012E0 VA: 0x182202CE0
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
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal ParsingResult <GetParsing>b__0(string input, out ITimeSpan timeSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FC8D0 Offset: 0x17FAED0 VA: 0x1817FC8D0
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>.<GetParsing>b__0
	*/

}

