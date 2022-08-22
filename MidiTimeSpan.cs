public sealed class MidiTimeSpan : ITimeSpan, IComparable, IComparable<MidiTimeSpan>, IEquatable<MidiTimeSpan> // TypeDefIndex: 7493
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <TimeSpan>k__BackingField; // 0x10

	// Properties
	public long TimeSpan { get; }

	// Methods

	// RVA: 0x21FD400 Offset: 0x21FBA00 VA: 0x1821FD400
	public void .ctor() { }

	// RVA: 0x21FD370 Offset: 0x21FB970 VA: 0x1821FD370
	public void .ctor(long timeSpan) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public long get_TimeSpan() { }

	// RVA: 0x21FD440 Offset: 0x21FBA40 VA: 0x1821FD440
	public static MidiTimeSpan op_Explicit(long timeSpan) { }

	// RVA: 0x21FD410 Offset: 0x21FBA10 VA: 0x1821FD410
	public static bool op_Equality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FD4A0 Offset: 0x21FBAA0 VA: 0x1821FD4A0
	public static bool op_Inequality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FD4D0 Offset: 0x21FBAD0 VA: 0x1821FD4D0
	public static MidiTimeSpan op_Subtraction(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FD350 Offset: 0x21FB950 VA: 0x1821FD350 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FD130 Offset: 0x21FB730 VA: 0x1821FD130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FD1B0 Offset: 0x21FB7B0 VA: 0x1821FD1B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FD1D0 Offset: 0x21FB7D0 VA: 0x1821FD1D0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21FCF40 Offset: 0x21FB540 VA: 0x1821FCF40 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21FD020 Offset: 0x21FB620 VA: 0x1821FD020 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21FCFA0 Offset: 0x21FB5A0 VA: 0x1821FCFA0 Slot: 7
	public int CompareTo(MidiTimeSpan other) { }

	// RVA: 0x21FD110 Offset: 0x21FB710 VA: 0x1821FD110 Slot: 8
	public bool Equals(MidiTimeSpan other) { }

}

