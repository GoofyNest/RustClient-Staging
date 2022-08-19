public sealed class MathTimeSpan : ITimeSpan, IComparable // TypeDefIndex: 7491
{	// Fields
	private static readonly Dictionary<TimeSpanMode, Tuple<string, string>> ModeStrings; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly ITimeSpan <TimeSpan1>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly ITimeSpan <TimeSpan2>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly MathOperation <Operation>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly TimeSpanMode <Mode>k__BackingField; // 0x24

	// Properties
	public ITimeSpan TimeSpan1 { get; }
	public ITimeSpan TimeSpan2 { get; }
	public MathOperation Operation { get; }
	public TimeSpanMode Mode { get; }

	// Methods

	// RVA: 0x139B230 Offset: 0x1399830 VA: 0x18139B230
	internal void .ctor(ITimeSpan timeSpan1, ITimeSpan timeSpan2, MathOperation operation, TimeSpanMode mode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ITimeSpan get_TimeSpan1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ITimeSpan get_TimeSpan2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public MathOperation get_Operation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public TimeSpanMode get_Mode() { }

	// RVA: 0x139B2A0 Offset: 0x13998A0 VA: 0x18139B2A0
	public static bool op_Equality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	// RVA: 0x139B340 Offset: 0x1399940 VA: 0x18139B340
	public static bool op_Inequality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	// RVA: 0x139AE80 Offset: 0x1399480 VA: 0x18139AE80 Slot: 3
	public override string ToString() { }

	// RVA: 0x139ABD0 Offset: 0x13991D0 VA: 0x18139ABD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139ACE0 Offset: 0x13992E0 VA: 0x18139ACE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x139AD90 Offset: 0x1399390 VA: 0x18139AD90 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x139AA90 Offset: 0x1399090 VA: 0x18139AA90 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x139AB70 Offset: 0x1399170 VA: 0x18139AB70 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x139B130 Offset: 0x1399730 VA: 0x18139B130
	private static void .cctor() { }

}

