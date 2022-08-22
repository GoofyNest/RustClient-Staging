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

	// RVA: 0x1395CD0 Offset: 0x13942D0 VA: 0x181395CD0
	public void .ctor() { }

	// RVA: 0x1395CB0 Offset: 0x13942B0 VA: 0x181395CB0
	public void .ctor(long bars, long beats) { }

	// RVA: 0x1395CF0 Offset: 0x13942F0 VA: 0x181395CF0
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

	// RVA: 0x1395DF0 Offset: 0x13943F0 VA: 0x181395DF0
	public static bool op_Equality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1395E30 Offset: 0x1394430 VA: 0x181395E30
	public static bool op_Inequality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1395FD0 Offset: 0x13945D0 VA: 0x181395FD0
	public static BarBeatTicksTimeSpan op_Subtraction(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1395E70 Offset: 0x1394470 VA: 0x181395E70
	public static bool op_LessThan(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1395830 Offset: 0x1393E30 VA: 0x181395830 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13958C0 Offset: 0x1393EC0 VA: 0x1813958C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1395C10 Offset: 0x1394210 VA: 0x181395C10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1395940 Offset: 0x1393F40 VA: 0x181395940 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x13955D0 Offset: 0x1393BD0 VA: 0x1813955D0 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x13956F0 Offset: 0x1393CF0 VA: 0x1813956F0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x1395650 Offset: 0x1393C50 VA: 0x181395650 Slot: 7
	public int CompareTo(BarBeatTicksTimeSpan other) { }

	// RVA: 0x1395800 Offset: 0x1393E00 VA: 0x181395800 Slot: 8
	public bool Equals(BarBeatTicksTimeSpan other) { }

}

