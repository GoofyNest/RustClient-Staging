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

	// RVA: 0x1394DD0 Offset: 0x13933D0 VA: 0x181394DD0
	public void .ctor() { }

	// RVA: 0x1394DB0 Offset: 0x13933B0 VA: 0x181394DB0
	public void .ctor(long bars, long beats) { }

	// RVA: 0x1394DF0 Offset: 0x13933F0 VA: 0x181394DF0
	public void .ctor(long bars, long beats, long ticks) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public long get_Bars() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public long get_Beats() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public long get_Ticks() { }

	// RVA: 0x1394EF0 Offset: 0x13934F0 VA: 0x181394EF0
	public static bool op_Equality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1394F30 Offset: 0x1393530 VA: 0x181394F30
	public static bool op_Inequality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x13950D0 Offset: 0x13936D0 VA: 0x1813950D0
	public static BarBeatTicksTimeSpan op_Subtraction(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1394F70 Offset: 0x1393570 VA: 0x181394F70
	public static bool op_LessThan(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1394930 Offset: 0x1392F30 VA: 0x181394930 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13949C0 Offset: 0x1392FC0 VA: 0x1813949C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1394D10 Offset: 0x1393310 VA: 0x181394D10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1394A40 Offset: 0x1393040 VA: 0x181394A40 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x13946D0 Offset: 0x1392CD0 VA: 0x1813946D0 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x13947F0 Offset: 0x1392DF0 VA: 0x1813947F0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x1394750 Offset: 0x1392D50 VA: 0x181394750 Slot: 7
	public int CompareTo(BarBeatTicksTimeSpan other) { }

	// RVA: 0x1394900 Offset: 0x1392F00 VA: 0x181394900 Slot: 8
	public bool Equals(BarBeatTicksTimeSpan other) { }

}

