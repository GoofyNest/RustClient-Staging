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
	// RVA: 0xB3BB60 Offset: 0xB3A160 VA: 0x180B3BB60
	public double get_DefaultMicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3BB80 Offset: 0xB3A180 VA: 0x180B3BB80
	private void set_DefaultMicrosecondsPerTick(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107B1C0 Offset: 0x10797C0 VA: 0x18107B1C0
	public double get_DefaultTicksPerMicrosecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107B3F0 Offset: 0x10799F0 VA: 0x18107B3F0
	private void set_DefaultTicksPerMicrosecond(double value) { }

	// RVA: 0x139C180 Offset: 0x139A780 VA: 0x18139C180
	private static double GetMicroseconds(long time, Tempo tempo, short ticksPerQuarterNote) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 4
	public IEnumerable<TempoMapLine> get_InvalidateOnLines() { }

	// RVA: 0x139C1C0 Offset: 0x139A7C0 VA: 0x18139C1C0 Slot: 5
	public void Invalidate(TempoMap tempoMap) { }

	// RVA: 0x139C600 Offset: 0x139AC00 VA: 0x18139C600
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

	// RVA: 0x1391E80 Offset: 0x1390480 VA: 0x181391E80
	public void .ctor(long time, double microseconds, double microsecondsPerTick) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3BB60 Offset: 0xB3A160 VA: 0x180B3BB60
	public double get_Microseconds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107B1C0 Offset: 0x10797C0 VA: 0x18107B1C0
	public double get_MicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF80 Offset: 0x499580 VA: 0x18049AF80
	public double get_TicksPerMicrosecond() { }

}

