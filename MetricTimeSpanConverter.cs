internal sealed class MetricTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7475
{
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	private static MetricTimeSpan TicksToMetricTimeSpan(long timeSpan, TempoMap tempoMap) { }

	private static long MetricTimeSpanToTicks(MetricTimeSpan timeSpan, TempoMap tempoMap) { }

	private static double GetMicroseconds(long time, double microsecondsPerTick) { }

	private static long RoundMicroseconds(double microseconds) { }

	public void .ctor() { }

}

private sealed class MetricTimeSpanConverter.<>c // TypeDefIndex: 7476
{	public static readonly MetricTimeSpanConverter.<>c <>9; // 0x0
	public static Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long> <>9__2_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal long <TicksToMetricTimeSpan>b__2_0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

private sealed class MetricTimeSpanConverter.<>c__DisplayClass3_0 // TypeDefIndex: 7477
{	public long timeMicroseconds; // 0x10


	public void .ctor() { }

	internal bool <MetricTimeSpanToTicks>b__0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

