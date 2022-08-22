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

	// RVA: 0x21FF140 Offset: 0x21FD740 VA: 0x1821FF140
	public void .ctor() { }

	// RVA: 0x21FF040 Offset: 0x21FD640 VA: 0x1821FF040
	public void .ctor(long fraction) { }

	// RVA: 0x21FF070 Offset: 0x21FD670 VA: 0x1821FF070
	public void .ctor(long numerator, long denominator, bool simplify = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public long get_Denominator() { }

	// RVA: 0x21FE3D0 Offset: 0x21FC9D0 VA: 0x1821FE3D0
	public MusicalTimeSpan Dotted(int dotsCount) { }

	// RVA: 0x21FEA20 Offset: 0x21FD020 VA: 0x1821FEA20
	public MusicalTimeSpan Tuplet(int tupletNotesCount, int tupletSpaceSize) { }

	// RVA: 0x21FE6A0 Offset: 0x21FCCA0 VA: 0x1821FE6A0
	private static void ReduceToCommonDenominator(MusicalTimeSpan fraction1, MusicalTimeSpan fraction2, out long numerator1, out long numerator2, out long denominator) { }

	// RVA: 0x21FF1D0 Offset: 0x21FD7D0 VA: 0x1821FF1D0
	public static bool op_Equality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FF2A0 Offset: 0x21FD8A0 VA: 0x1821FF2A0
	public static bool op_Inequality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FF3B0 Offset: 0x21FD9B0 VA: 0x1821FF3B0
	public static MusicalTimeSpan op_Subtraction(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21FE490 Offset: 0x21FCA90 VA: 0x1821FE490 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FE650 Offset: 0x21FCC50 VA: 0x1821FE650 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FE9A0 Offset: 0x21FCFA0 VA: 0x1821FE9A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FE730 Offset: 0x21FCD30 VA: 0x1821FE730 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21FE140 Offset: 0x21FC740 VA: 0x1821FE140 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21FE1C0 Offset: 0x21FC7C0 VA: 0x1821FE1C0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21FE300 Offset: 0x21FC900 VA: 0x1821FE300 Slot: 7
	public int CompareTo(MusicalTimeSpan other) { }

	// RVA: 0x21FE590 Offset: 0x21FCB90 VA: 0x1821FE590 Slot: 8
	public bool Equals(MusicalTimeSpan other) { }

	// RVA: 0x21FEAF0 Offset: 0x21FD0F0 VA: 0x1821FEAF0
	private static void .cctor() { }

}

