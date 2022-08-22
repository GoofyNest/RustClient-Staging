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

	// RVA: 0x1392DF0 Offset: 0x13913F0 VA: 0x181392DF0
	public void .ctor() { }

	// RVA: 0x1392CC0 Offset: 0x13912C0 VA: 0x181392CC0
	public void .ctor(long bars, double beats) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public long get_Bars() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB3C030 Offset: 0xB3A630 VA: 0x180B3C030
	public double get_Beats() { }

	// RVA: 0x1392E00 Offset: 0x1391400 VA: 0x181392E00
	public static bool op_Equality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1392E20 Offset: 0x1391420 VA: 0x181392E20
	public static bool op_Inequality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1392FB0 Offset: 0x13915B0 VA: 0x181392FB0
	public static BarBeatFractionTimeSpan op_Subtraction(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1392E50 Offset: 0x1391450 VA: 0x181392E50
	public static bool op_LessThan(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x1392870 Offset: 0x1390E70 VA: 0x181392870 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13928D0 Offset: 0x1390ED0 VA: 0x1813928D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1392C10 Offset: 0x1391210 VA: 0x181392C10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1392930 Offset: 0x1390F30 VA: 0x181392930 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x1392580 Offset: 0x1390B80 VA: 0x181392580 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x1392690 Offset: 0x1390C90 VA: 0x181392690 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x13925F0 Offset: 0x1390BF0 VA: 0x1813925F0 Slot: 7
	public int CompareTo(BarBeatFractionTimeSpan other) { }

	// RVA: 0x13927B0 Offset: 0x1390DB0 VA: 0x1813927B0 Slot: 8
	public bool Equals(BarBeatFractionTimeSpan other) { }

}

