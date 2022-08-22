internal sealed class MetricTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7475
{	// Methods

	// RVA: 0x139C8B0 Offset: 0x139AEB0 VA: 0x18139C8B0 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139C660 Offset: 0x139AC60 VA: 0x18139C660 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139CB80 Offset: 0x139B180 VA: 0x18139CB80
	private static MetricTimeSpan TicksToMetricTimeSpan(long timeSpan, TempoMap tempoMap) { }

	// RVA: 0x139C9D0 Offset: 0x139AFD0 VA: 0x18139C9D0
	private static long MetricTimeSpanToTicks(MetricTimeSpan timeSpan, TempoMap tempoMap) { }

	// RVA: 0x139C9C0 Offset: 0x139AFC0 VA: 0x18139C9C0
	private static double GetMicroseconds(long time, double microsecondsPerTick) { }

	// RVA: 0x139B810 Offset: 0x1399E10 VA: 0x18139B810
	private static long RoundMicroseconds(double microseconds) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class MetricTimeSpanConverter.<>c // TypeDefIndex: 7476
{	// Fields
	public static readonly MetricTimeSpanConverter.<>c <>9; // 0x0
	public static Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x13AACD0 Offset: 0x13A92D0 VA: 0x1813AACD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
	internal long <TicksToMetricTimeSpan>b__2_0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

private sealed class MetricTimeSpanConverter.<>c__DisplayClass3_0 // TypeDefIndex: 7477
{	// Fields
	public long timeMicroseconds; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AABE0 Offset: 0x13A91E0 VA: 0x1813AABE0
	internal bool <MetricTimeSpanToTicks>b__0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

