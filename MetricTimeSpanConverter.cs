internal sealed class MetricTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7479
{

	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	private static MetricTimeSpan TicksToMetricTimeSpan(long timeSpan, TempoMap tempoMap) { }

	private static long MetricTimeSpanToTicks(MetricTimeSpan timeSpan, TempoMap tempoMap) { }

	private static double GetMicroseconds(long time, double microsecondsPerTick) { }

	private static long RoundMicroseconds(double microseconds) { }

	public void .ctor() { }

}

private sealed class MetricTimeSpanConverter.<>c // TypeDefIndex: 7480
{
	public static readonly MetricTimeSpanConverter.<>c <>9; 
	public static Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long> <>9__2_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal long <TicksToMetricTimeSpan>b__2_0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

private sealed class MetricTimeSpanConverter.<>c__DisplayClass3_0 // TypeDefIndex: 7481
{
	public long timeMicroseconds; 


	public void .ctor() { }

	internal bool <MetricTimeSpanToTicks>b__0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

