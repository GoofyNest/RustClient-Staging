public sealed class BarBeatFractionTimeSpan : ITimeSpan, IComparable, IComparable<BarBeatFractionTimeSpan>, IEquatable<BarBeatFractionTimeSpan> // TypeDefIndex: 7489
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly long <Bars>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly double <Beats>k__BackingField; // 0x18

	// Properties
	public long Bars { get; }
	public double Beats { get; }

	// Methods

	// RVA: 0x1393A30 Offset: 0x1392030 VA: 0x181393A30
	public void .ctor() { }

	// RVA: 0x1393900 Offset: 0x1391F00 VA: 0x181393900
	public void .ctor(long bars, double beats) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_Bars() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xB3B8A0 Offset: 0xB39EA0 VA: 0x180B3B8A0
	public double get_Beats() { }

	// RVA: 0x1393A40 Offset: 0x1392040 VA: 0x181393A40
	public static bool op_Equality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1393A60 Offset: 0x1392060 VA: 0x181393A60
	public static bool op_Inequality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1393BF0 Offset: 0x13921F0 VA: 0x181393BF0
	public static BarBeatFractionTimeSpan op_Subtraction(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1393A90 Offset: 0x1392090 VA: 0x181393A90
	public static bool op_LessThan(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x13934B0 Offset: 0x1391AB0 VA: 0x1813934B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1393510 Offset: 0x1391B10 VA: 0x181393510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1393850 Offset: 0x1391E50 VA: 0x181393850 Slot: 3
	public override string ToString() { }

	// RVA: 0x1393570 Offset: 0x1391B70 VA: 0x181393570 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x13931C0 Offset: 0x13917C0 VA: 0x1813931C0 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x13932D0 Offset: 0x13918D0 VA: 0x1813932D0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x1393230 Offset: 0x1391830 VA: 0x181393230 Slot: 7
	public int CompareTo(BarBeatFractionTimeSpan other) { }

	// RVA: 0x13933F0 Offset: 0x13919F0 VA: 0x1813933F0 Slot: 8
	public bool Equals(BarBeatFractionTimeSpan other) { }

}

