public sealed class MidiTimeSpan : ITimeSpan, IComparable, IComparable<MidiTimeSpan>, IEquatable<MidiTimeSpan> // TypeDefIndex: 7493
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <TimeSpan>k__BackingField; // 0x10

	// Properties
	public long TimeSpan { get; }

	// Methods

	// RVA: 0x21FC920 Offset: 0x21FAF20 VA: 0x1821FC920
	public void .ctor() { }

	// RVA: 0x21FC890 Offset: 0x21FAE90 VA: 0x1821FC890
	public void .ctor(long timeSpan) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_TimeSpan() { }

	// RVA: 0x21FC960 Offset: 0x21FAF60 VA: 0x1821FC960
	public static MidiTimeSpan op_Explicit(long timeSpan) { }

	// RVA: 0x21FC930 Offset: 0x21FAF30 VA: 0x1821FC930
	public static bool op_Equality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FC9C0 Offset: 0x21FAFC0 VA: 0x1821FC9C0
	public static bool op_Inequality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FC9F0 Offset: 0x21FAFF0 VA: 0x1821FC9F0
	public static MidiTimeSpan op_Subtraction(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FC870 Offset: 0x21FAE70 VA: 0x1821FC870 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FC650 Offset: 0x21FAC50 VA: 0x1821FC650 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FC6D0 Offset: 0x21FACD0 VA: 0x1821FC6D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FC6F0 Offset: 0x21FACF0 VA: 0x1821FC6F0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21FC460 Offset: 0x21FAA60 VA: 0x1821FC460 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21FC540 Offset: 0x21FAB40 VA: 0x1821FC540 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21FC4C0 Offset: 0x21FAAC0 VA: 0x1821FC4C0 Slot: 7
	public int CompareTo(MidiTimeSpan other) { }

	// RVA: 0x21FC630 Offset: 0x21FAC30 VA: 0x1821FC630 Slot: 8
	public bool Equals(MidiTimeSpan other) { }

}

