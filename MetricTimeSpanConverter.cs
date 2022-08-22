internal sealed class MetricTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7475
{	// Methods

	// RVA: 0x139B9B0 Offset: 0x1399FB0 VA: 0x18139B9B0 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139B760 Offset: 0x1399D60 VA: 0x18139B760 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139BC80 Offset: 0x139A280 VA: 0x18139BC80
	private static MetricTimeSpan TicksToMetricTimeSpan(long timeSpan, TempoMap tempoMap) { }

	// RVA: 0x139BAD0 Offset: 0x139A0D0 VA: 0x18139BAD0
	private static long MetricTimeSpanToTicks(MetricTimeSpan timeSpan, TempoMap tempoMap) { }

	// RVA: 0x139BAC0 Offset: 0x139A0C0 VA: 0x18139BAC0
	private static double GetMicroseconds(long time, double microsecondsPerTick) { }

	// RVA: 0x139A910 Offset: 0x1398F10 VA: 0x18139A910
	private static long RoundMicroseconds(double microseconds) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class MetricTimeSpanConverter.<>c // TypeDefIndex: 7476
{	// Fields
	public static readonly MetricTimeSpanConverter.<>c <>9; // 0x0
	public static Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x13A9DD0 Offset: 0x13A83D0 VA: 0x1813A9DD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690D30 Offset: 0x68F330 VA: 0x180690D30
	internal long <TicksToMetricTimeSpan>b__2_0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

private sealed class MetricTimeSpanConverter.<>c__DisplayClass3_0 // TypeDefIndex: 7477
{	// Fields
	public long timeMicroseconds; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13A9CE0 Offset: 0x13A82E0 VA: 0x1813A9CE0
	internal bool <MetricTimeSpanToTicks>b__0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

