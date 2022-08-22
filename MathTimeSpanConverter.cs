internal sealed class MathTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7474
{	// Fields
	private static readonly Dictionary<TimeSpanMode, Func<MathTimeSpan, long, TempoMap, long>> Converters; // 0x2B113C8

	// Methods

	// RVA: 0x139ABC0 Offset: 0x13991C0 VA: 0x18139ABC0 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139AA40 Offset: 0x1399040 VA: 0x18139AA40 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139A290 Offset: 0x1398890 VA: 0x18139A290
	private static long ConvertFromLengthLength(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139A580 Offset: 0x1398B80 VA: 0x18139A580
	private static long ConvertFromTimeLength(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139A7C0 Offset: 0x1398DC0 VA: 0x18139A7C0
	private static long ConvertFromTimeTime(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x139AC20 Offset: 0x1399220 VA: 0x18139AC20
	private static void .cctor() { }

}

