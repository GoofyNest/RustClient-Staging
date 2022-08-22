public sealed class BarBeatTicksTimeSpan : ITimeSpan, IComparable, IComparable<BarBeatTicksTimeSpan>, IEquatable<BarBeatTicksTimeSpan> // TypeDefIndex: 7490
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <Bars>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <Beats>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <Ticks>k__BackingField; // 0x20

	// Properties
	public long Bars { get; }
	public long Beats { get; }
	public long Ticks { get; }

	// Methods

	// RVA: 0x1395A10 Offset: 0x1394010 VA: 0x181395A10
	public void .ctor() { }

	// RVA: 0x13959F0 Offset: 0x1393FF0 VA: 0x1813959F0
	public void .ctor(long bars, long beats) { }

	// RVA: 0x1395A30 Offset: 0x1394030 VA: 0x181395A30
	public void .ctor(long bars, long beats, long ticks) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_Bars() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public long get_Beats() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public long get_Ticks() { }

	// RVA: 0x1395B30 Offset: 0x1394130 VA: 0x181395B30
	public static bool op_Equality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1395B70 Offset: 0x1394170 VA: 0x181395B70
	public static bool op_Inequality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1395D10 Offset: 0x1394310 VA: 0x181395D10
	public static BarBeatTicksTimeSpan op_Subtraction(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1395BB0 Offset: 0x13941B0 VA: 0x181395BB0
	public static bool op_LessThan(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1395570 Offset: 0x1393B70 VA: 0x181395570 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1395600 Offset: 0x1393C00 VA: 0x181395600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1395950 Offset: 0x1393F50 VA: 0x181395950 Slot: 3
	public override string ToString() { }

	// RVA: 0x1395680 Offset: 0x1393C80 VA: 0x181395680 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x1395310 Offset: 0x1393910 VA: 0x181395310 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x1395430 Offset: 0x1393A30 VA: 0x181395430 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x1395390 Offset: 0x1393990 VA: 0x181395390 Slot: 7
	public int CompareTo(BarBeatTicksTimeSpan other) { }

	// RVA: 0x1395540 Offset: 0x1393B40 VA: 0x181395540 Slot: 8
	public bool Equals(BarBeatTicksTimeSpan other) { }

}

