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

	// RVA: 0x139A5F0 Offset: 0x1398BF0 VA: 0x18139A5F0
	internal void .ctor(ITimeSpan timeSpan1, ITimeSpan timeSpan2, MathOperation operation, TimeSpanMode mode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public ITimeSpan get_TimeSpan1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ITimeSpan get_TimeSpan2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public MathOperation get_Operation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public TimeSpanMode get_Mode() { }

	// RVA: 0x139A660 Offset: 0x1398C60 VA: 0x18139A660
	public static bool op_Equality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	// RVA: 0x139A700 Offset: 0x1398D00 VA: 0x18139A700
	public static bool op_Inequality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	// RVA: 0x139A240 Offset: 0x1398840 VA: 0x18139A240 Slot: 3
	public override string ToString() { }

	// RVA: 0x1399F90 Offset: 0x1398590 VA: 0x181399F90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139A0A0 Offset: 0x13986A0 VA: 0x18139A0A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x139A150 Offset: 0x1398750 VA: 0x18139A150 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x1399E50 Offset: 0x1398450 VA: 0x181399E50 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x1399F30 Offset: 0x1398530 VA: 0x181399F30 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x139A4F0 Offset: 0x1398AF0 VA: 0x18139A4F0
	private static void .cctor() { }

}

