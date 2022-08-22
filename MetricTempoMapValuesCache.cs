internal sealed class MetricTempoMapValuesCache : ITempoMapValuesCache // TypeDefIndex: 7495
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MetricTempoMapValuesCache.AccumulatedMicroseconds[] <Microseconds>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private double <DefaultMicrosecondsPerTick>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private double <DefaultTicksPerMicrosecond>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IEnumerable<TempoMapLine> <InvalidateOnLines>k__BackingField; // 0x28

	// Properties
	public MetricTempoMapValuesCache.AccumulatedMicroseconds[] Microseconds { get; set; }
	public double DefaultMicrosecondsPerTick { get; set; }
	public double DefaultTicksPerMicrosecond { get; set; }
	public IEnumerable<TempoMapLine> InvalidateOnLines { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public MetricTempoMapValuesCache.AccumulatedMicroseconds[] get_Microseconds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Microseconds(MetricTempoMapValuesCache.AccumulatedMicroseconds[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3C030 Offset: 0xB3A630 VA: 0x180B3C030
	public double get_DefaultMicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3C050 Offset: 0xB3A650 VA: 0x180B3C050
	private void set_DefaultMicrosecondsPerTick(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107BC30 Offset: 0x107A230 VA: 0x18107BC30
	public double get_DefaultTicksPerMicrosecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107BE60 Offset: 0x107A460 VA: 0x18107BE60
	private void set_DefaultTicksPerMicrosecond(double value) { }

	// RVA: 0x139B280 Offset: 0x1399880 VA: 0x18139B280
	private static double GetMicroseconds(long time, Tempo tempo, short ticksPerQuarterNote) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 4
	public IEnumerable<TempoMapLine> get_InvalidateOnLines() { }

	// RVA: 0x139B2C0 Offset: 0x13998C0 VA: 0x18139B2C0 Slot: 5
	public void Invalidate(TempoMap tempoMap) { }

	// RVA: 0x139B700 Offset: 0x1399D00 VA: 0x18139B700
	public void .ctor() { }

}

internal sealed class MetricTempoMapValuesCache.AccumulatedMicroseconds // TypeDefIndex: 7496
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <Time>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly double <Microseconds>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly double <MicrosecondsPerTick>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly double <TicksPerMicrosecond>k__BackingField; // 0x28

	// Properties
	public long Time { get; }
	public double Microseconds { get; }
	public double MicrosecondsPerTick { get; }
	public double TicksPerMicrosecond { get; }

	// Methods

	// RVA: 0x1390F80 Offset: 0x138F580 VA: 0x181390F80
	public void .ctor(long time, double microseconds, double microsecondsPerTick) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public long get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3C030 Offset: 0xB3A630 VA: 0x180B3C030
	public double get_Microseconds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107BC30 Offset: 0x107A230 VA: 0x18107BC30
	public double get_MicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF80 Offset: 0x499580 VA: 0x18049AF80
	public double get_TicksPerMicrosecond() { }

}

