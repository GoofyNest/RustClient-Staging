public sealed class BarBeatFractionTimeSpan : ITimeSpan, IComparable, IComparable<BarBeatFractionTimeSpan>, IEquatable<BarBeatFractionTimeSpan> // TypeDefIndex: 7489
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <Bars>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly double <Beats>k__BackingField; // 0x18

	// Properties
	public long Bars { get; }
	public double Beats { get; }

	// Methods

	// RVA: 0x1393CF0 Offset: 0x13922F0 VA: 0x181393CF0
	public void .ctor() { }

	// RVA: 0x1393BC0 Offset: 0x13921C0 VA: 0x181393BC0
	public void .ctor(long bars, double beats) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_Bars() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3BB60 Offset: 0xB3A160 VA: 0x180B3BB60
	public double get_Beats() { }

	// RVA: 0x1393D00 Offset: 0x1392300 VA: 0x181393D00
	public static bool op_Equality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1393D20 Offset: 0x1392320 VA: 0x181393D20
	public static bool op_Inequality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1393EB0 Offset: 0x13924B0 VA: 0x181393EB0
	public static BarBeatFractionTimeSpan op_Subtraction(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1393D50 Offset: 0x1392350 VA: 0x181393D50
	public static bool op_LessThan(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1393770 Offset: 0x1391D70 VA: 0x181393770 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13937D0 Offset: 0x1391DD0 VA: 0x1813937D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1393B10 Offset: 0x1392110 VA: 0x181393B10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1393830 Offset: 0x1391E30 VA: 0x181393830 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x1393480 Offset: 0x1391A80 VA: 0x181393480 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x1393590 Offset: 0x1391B90 VA: 0x181393590 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x13934F0 Offset: 0x1391AF0 VA: 0x1813934F0 Slot: 7
	public int CompareTo(BarBeatFractionTimeSpan other) { }

	// RVA: 0x13936B0 Offset: 0x1391CB0 VA: 0x1813936B0 Slot: 8
	public bool Equals(BarBeatFractionTimeSpan other) { }

}

