internal sealed class MetricTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7475
{	// Methods

	// RVA: 0x139C5F0 Offset: 0x139ABF0 VA: 0x18139C5F0 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139C3A0 Offset: 0x139A9A0 VA: 0x18139C3A0 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139C8C0 Offset: 0x139AEC0 VA: 0x18139C8C0
	private static MetricTimeSpan TicksToMetricTimeSpan(long timeSpan, TempoMap tempoMap) { }

	// RVA: 0x139C710 Offset: 0x139AD10 VA: 0x18139C710
	private static long MetricTimeSpanToTicks(MetricTimeSpan timeSpan, TempoMap tempoMap) { }

	// RVA: 0x139C700 Offset: 0x139AD00 VA: 0x18139C700
	private static double GetMicroseconds(long time, double microsecondsPerTick) { }

	// RVA: 0x139B550 Offset: 0x1399B50 VA: 0x18139B550
	private static long RoundMicroseconds(double microseconds) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class MetricTimeSpanConverter.<>c // TypeDefIndex: 7476
{	// Fields
	public static readonly MetricTimeSpanConverter.<>c <>9; // 0x0
	public static Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x13AAA10 Offset: 0x13A9010 VA: 0x1813AAA10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal long <TicksToMetricTimeSpan>b__2_0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

private sealed class MetricTimeSpanConverter.<>c__DisplayClass3_0 // TypeDefIndex: 7477
{	// Fields
	public long timeMicroseconds; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AA920 Offset: 0x13A8F20 VA: 0x1813AA920
	internal bool <MetricTimeSpanToTicks>b__0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

