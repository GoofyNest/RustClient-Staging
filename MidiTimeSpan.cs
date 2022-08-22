public sealed class MidiTimeSpan : ITimeSpan, IComparable, IComparable<MidiTimeSpan>, IEquatable<MidiTimeSpan> // TypeDefIndex: 7493
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <TimeSpan>k__BackingField; // 0x10

	// Properties
	public long TimeSpan { get; }

	// Methods

	// RVA: 0x21FCBE0 Offset: 0x21FB1E0 VA: 0x1821FCBE0
	public void .ctor() { }

	// RVA: 0x21FCB50 Offset: 0x21FB150 VA: 0x1821FCB50
	public void .ctor(long timeSpan) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_TimeSpan() { }

	// RVA: 0x21FCC20 Offset: 0x21FB220 VA: 0x1821FCC20
	public static MidiTimeSpan op_Explicit(long timeSpan) { }

	// RVA: 0x21FCBF0 Offset: 0x21FB1F0 VA: 0x1821FCBF0
	public static bool op_Equality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FCC80 Offset: 0x21FB280 VA: 0x1821FCC80
	public static bool op_Inequality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FCCB0 Offset: 0x21FB2B0 VA: 0x1821FCCB0
	public static MidiTimeSpan op_Subtraction(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FCB30 Offset: 0x21FB130 VA: 0x1821FCB30 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FC910 Offset: 0x21FAF10 VA: 0x1821FC910 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FC990 Offset: 0x21FAF90 VA: 0x1821FC990 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FC9B0 Offset: 0x21FAFB0 VA: 0x1821FC9B0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21FC720 Offset: 0x21FAD20 VA: 0x1821FC720 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21FC800 Offset: 0x21FAE00 VA: 0x1821FC800 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21FC780 Offset: 0x21FAD80 VA: 0x1821FC780 Slot: 7
	public int CompareTo(MidiTimeSpan other) { }

	// RVA: 0x21FC8F0 Offset: 0x21FAEF0 VA: 0x1821FC8F0 Slot: 8
	public bool Equals(MidiTimeSpan other) { }

}

