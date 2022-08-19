public sealed class MusicalTimeSpan : ITimeSpan, IComparable, IComparable<MusicalTimeSpan>, IEquatable<MusicalTimeSpan> // TypeDefIndex: 7494
{	// Fields
	public static readonly MusicalTimeSpan Whole; // 0x0
	public static readonly MusicalTimeSpan Half; // 0x8
	public static readonly MusicalTimeSpan Quarter; // 0x10
	public static readonly MusicalTimeSpan Eighth; // 0x18
	public static readonly MusicalTimeSpan Sixteenth; // 0x20
	public static readonly MusicalTimeSpan ThirtySecond; // 0x28
	public static readonly MusicalTimeSpan SixtyFourth; // 0x30
	private static readonly int FractionPartMultiplier; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly long <Numerator>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly long <Denominator>k__BackingField; // 0x18

	// Properties
	public long Numerator { get; }
	public long Denominator { get; }

	// Methods

	// RVA: 0x21FF040 Offset: 0x21FD640 VA: 0x1821FF040
	public void .ctor() { }

	// RVA: 0x21FEF40 Offset: 0x21FD540 VA: 0x1821FEF40
	public void .ctor(long fraction) { }

	// RVA: 0x21FEF70 Offset: 0x21FD570 VA: 0x1821FEF70
	public void .ctor(long numerator, long denominator, bool simplify = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public long get_Denominator() { }

	// RVA: 0x21FE2D0 Offset: 0x21FC8D0 VA: 0x1821FE2D0
	public MusicalTimeSpan Dotted(int dotsCount) { }

	// RVA: 0x21FE920 Offset: 0x21FCF20 VA: 0x1821FE920
	public MusicalTimeSpan Tuplet(int tupletNotesCount, int tupletSpaceSize) { }

	// RVA: 0x21FE5A0 Offset: 0x21FCBA0 VA: 0x1821FE5A0
	private static void ReduceToCommonDenominator(MusicalTimeSpan fraction1, MusicalTimeSpan fraction2, out long numerator1, out long numerator2, out long denominator) { }

	// RVA: 0x21FF0D0 Offset: 0x21FD6D0 VA: 0x1821FF0D0
	public static bool op_Equality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FF1A0 Offset: 0x21FD7A0 VA: 0x1821FF1A0
	public static bool op_Inequality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FF2B0 Offset: 0x21FD8B0 VA: 0x1821FF2B0
	public static MusicalTimeSpan op_Subtraction(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FE390 Offset: 0x21FC990 VA: 0x1821FE390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FE550 Offset: 0x21FCB50 VA: 0x1821FE550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FE8A0 Offset: 0x21FCEA0 VA: 0x1821FE8A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FE630 Offset: 0x21FCC30 VA: 0x1821FE630 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21FE040 Offset: 0x21FC640 VA: 0x1821FE040 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21FE0C0 Offset: 0x21FC6C0 VA: 0x1821FE0C0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21FE200 Offset: 0x21FC800 VA: 0x1821FE200 Slot: 7
	public int CompareTo(MusicalTimeSpan other) { }

	// RVA: 0x21FE490 Offset: 0x21FCA90 VA: 0x1821FE490 Slot: 8
	public bool Equals(MusicalTimeSpan other) { }

	// RVA: 0x21FE9F0 Offset: 0x21FCFF0 VA: 0x1821FE9F0
	private static void .cctor() { }

}
