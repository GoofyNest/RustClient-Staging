public sealed class MathTimeSpan : ITimeSpan, IComparable // TypeDefIndex: 7491
{	// Fields
	private static readonly Dictionary<TimeSpanMode, Tuple<string, string>> ModeStrings; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ITimeSpan <TimeSpan1>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ITimeSpan <TimeSpan2>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly MathOperation <Operation>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly TimeSpanMode <Mode>k__BackingField; // 0x24

	// Properties
	public ITimeSpan TimeSpan1 { get; }
	public ITimeSpan TimeSpan2 { get; }
	public MathOperation Operation { get; }
	public TimeSpanMode Mode { get; }

	// Methods

	// RVA: 0x139B4F0 Offset: 0x1399AF0 VA: 0x18139B4F0
	internal void .ctor(ITimeSpan timeSpan1, ITimeSpan timeSpan2, MathOperation operation, TimeSpanMode mode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ITimeSpan get_TimeSpan1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ITimeSpan get_TimeSpan2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public MathOperation get_Operation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public TimeSpanMode get_Mode() { }

	// RVA: 0x139B560 Offset: 0x1399B60 VA: 0x18139B560
	public static bool op_Equality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	// RVA: 0x139B600 Offset: 0x1399C00 VA: 0x18139B600
	public static bool op_Inequality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	// RVA: 0x139B140 Offset: 0x1399740 VA: 0x18139B140 Slot: 3
	public override string ToString() { }

	// RVA: 0x139AE90 Offset: 0x1399490 VA: 0x18139AE90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139AFA0 Offset: 0x13995A0 VA: 0x18139AFA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x139B050 Offset: 0x1399650 VA: 0x18139B050 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x139AD50 Offset: 0x1399350 VA: 0x18139AD50 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x139AE30 Offset: 0x1399430 VA: 0x18139AE30 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x139B3F0 Offset: 0x13999F0 VA: 0x18139B3F0
	private static void .cctor() { }

}

