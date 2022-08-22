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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <Numerator>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <Denominator>k__BackingField; // 0x18

	// Properties
	public long Numerator { get; }
	public long Denominator { get; }

	// Methods

	// RVA: 0x21FEE80 Offset: 0x21FD480 VA: 0x1821FEE80
	public void .ctor() { }

	// RVA: 0x21FED80 Offset: 0x21FD380 VA: 0x1821FED80
	public void .ctor(long fraction) { }

	// RVA: 0x21FEDB0 Offset: 0x21FD3B0 VA: 0x1821FEDB0
	public void .ctor(long numerator, long denominator, bool simplify = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public long get_Denominator() { }

	// RVA: 0x21FE110 Offset: 0x21FC710 VA: 0x1821FE110
	public MusicalTimeSpan Dotted(int dotsCount) { }

	// RVA: 0x21FE760 Offset: 0x21FCD60 VA: 0x1821FE760
	public MusicalTimeSpan Tuplet(int tupletNotesCount, int tupletSpaceSize) { }

	// RVA: 0x21FE3E0 Offset: 0x21FC9E0 VA: 0x1821FE3E0
	private static void ReduceToCommonDenominator(MusicalTimeSpan fraction1, MusicalTimeSpan fraction2, out long numerator1, out long numerator2, out long denominator) { }

	// RVA: 0x21FEF10 Offset: 0x21FD510 VA: 0x1821FEF10
	public static bool op_Equality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FEFE0 Offset: 0x21FD5E0 VA: 0x1821FEFE0
	public static bool op_Inequality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FF0F0 Offset: 0x21FD6F0 VA: 0x1821FF0F0
	public static MusicalTimeSpan op_Subtraction(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FE1D0 Offset: 0x21FC7D0 VA: 0x1821FE1D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FE390 Offset: 0x21FC990 VA: 0x1821FE390 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FE6E0 Offset: 0x21FCCE0 VA: 0x1821FE6E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FE470 Offset: 0x21FCA70 VA: 0x1821FE470 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21FDE80 Offset: 0x21FC480 VA: 0x1821FDE80 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21FDF00 Offset: 0x21FC500 VA: 0x1821FDF00 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21FE040 Offset: 0x21FC640 VA: 0x1821FE040 Slot: 7
	public int CompareTo(MusicalTimeSpan other) { }

	// RVA: 0x21FE2D0 Offset: 0x21FC8D0 VA: 0x1821FE2D0 Slot: 8
	public bool Equals(MusicalTimeSpan other) { }

	// RVA: 0x21FE830 Offset: 0x21FCE30 VA: 0x1821FE830
	private static void .cctor() { }

}

