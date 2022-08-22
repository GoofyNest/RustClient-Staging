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

	// RVA: 0x21FF960 Offset: 0x21FDF60 VA: 0x1821FF960
	public void .ctor() { }

	// RVA: 0x21FF860 Offset: 0x21FDE60 VA: 0x1821FF860
	public void .ctor(long fraction) { }

	// RVA: 0x21FF890 Offset: 0x21FDE90 VA: 0x1821FF890
	public void .ctor(long numerator, long denominator, bool simplify = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public long get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public long get_Denominator() { }

	// RVA: 0x21FEBF0 Offset: 0x21FD1F0 VA: 0x1821FEBF0
	public MusicalTimeSpan Dotted(int dotsCount) { }

	// RVA: 0x21FF240 Offset: 0x21FD840 VA: 0x1821FF240
	public MusicalTimeSpan Tuplet(int tupletNotesCount, int tupletSpaceSize) { }

	// RVA: 0x21FEEC0 Offset: 0x21FD4C0 VA: 0x1821FEEC0
	private static void ReduceToCommonDenominator(MusicalTimeSpan fraction1, MusicalTimeSpan fraction2, out long numerator1, out long numerator2, out long denominator) { }

	// RVA: 0x21FF9F0 Offset: 0x21FDFF0 VA: 0x1821FF9F0
	public static bool op_Equality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FFAC0 Offset: 0x21FE0C0 VA: 0x1821FFAC0
	public static bool op_Inequality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FFBD0 Offset: 0x21FE1D0 VA: 0x1821FFBD0
	public static MusicalTimeSpan op_Subtraction(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FECB0 Offset: 0x21FD2B0 VA: 0x1821FECB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FEE70 Offset: 0x21FD470 VA: 0x1821FEE70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FF1C0 Offset: 0x21FD7C0 VA: 0x1821FF1C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FEF50 Offset: 0x21FD550 VA: 0x1821FEF50 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21FE960 Offset: 0x21FCF60 VA: 0x1821FE960 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21FE9E0 Offset: 0x21FCFE0 VA: 0x1821FE9E0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21FEB20 Offset: 0x21FD120 VA: 0x1821FEB20 Slot: 7
	public int CompareTo(MusicalTimeSpan other) { }

	// RVA: 0x21FEDB0 Offset: 0x21FD3B0 VA: 0x1821FEDB0 Slot: 8
	public bool Equals(MusicalTimeSpan other) { }

	// RVA: 0x21FF310 Offset: 0x21FD910 VA: 0x1821FF310
	private static void .cctor() { }

}

