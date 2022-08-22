internal sealed class MathTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7474
{	// Fields
	private static readonly Dictionary<TimeSpanMode, Func<MathTimeSpan, long, TempoMap, long>> Converters; // 0x1CBC

	// Methods

	// RVA: 0x1399CC0 Offset: 0x13982C0 VA: 0x181399CC0 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1399B40 Offset: 0x1398140 VA: 0x181399B40 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1399390 Offset: 0x1397990 VA: 0x181399390
	private static long ConvertFromLengthLength(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1399680 Offset: 0x1397C80 VA: 0x181399680
	private static long ConvertFromTimeLength(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x13998C0 Offset: 0x1397EC0 VA: 0x1813998C0
	private static long ConvertFromTimeTime(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1399D20 Offset: 0x1398320 VA: 0x181399D20
	private static void .cctor() { }

}

