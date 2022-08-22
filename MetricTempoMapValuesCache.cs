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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public MetricTempoMapValuesCache.AccumulatedMicroseconds[] get_Microseconds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Microseconds(MetricTempoMapValuesCache.AccumulatedMicroseconds[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3B8A0 Offset: 0xB39EA0 VA: 0x180B3B8A0
	public double get_DefaultMicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3B8C0 Offset: 0xB39EC0 VA: 0x180B3B8C0
	private void set_DefaultMicrosecondsPerTick(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AF00 Offset: 0x1079500 VA: 0x18107AF00
	public double get_DefaultTicksPerMicrosecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107B130 Offset: 0x1079730 VA: 0x18107B130
	private void set_DefaultTicksPerMicrosecond(double value) { }

	// RVA: 0x139BEC0 Offset: 0x139A4C0 VA: 0x18139BEC0
	private static double GetMicroseconds(long time, Tempo tempo, short ticksPerQuarterNote) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 4
	public IEnumerable<TempoMapLine> get_InvalidateOnLines() { }

	// RVA: 0x139BF00 Offset: 0x139A500 VA: 0x18139BF00 Slot: 5
	public void Invalidate(TempoMap tempoMap) { }

	// RVA: 0x139C340 Offset: 0x139A940 VA: 0x18139C340
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

	// RVA: 0x1391BC0 Offset: 0x13901C0 VA: 0x181391BC0
	public void .ctor(long time, double microseconds, double microsecondsPerTick) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3B8A0 Offset: 0xB39EA0 VA: 0x180B3B8A0
	public double get_Microseconds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AF00 Offset: 0x1079500 VA: 0x18107AF00
	public double get_MicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF80 Offset: 0x499580 VA: 0x18049AF80
	public double get_TicksPerMicrosecond() { }

}

