public sealed class MidiTimeSpan : ITimeSpan, IComparable, IComparable<MidiTimeSpan>, IEquatable<MidiTimeSpan> // TypeDefIndex: 7493
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly long <TimeSpan>k__BackingField; // 0x10

	// Properties
	public long TimeSpan { get; }

	// Methods

	// RVA: 0x21FCAE0 Offset: 0x21FB0E0 VA: 0x1821FCAE0
	public void .ctor() { }

	// RVA: 0x21FCA50 Offset: 0x21FB050 VA: 0x1821FCA50
	public void .ctor(long timeSpan) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_TimeSpan() { }

	// RVA: 0x21FCB20 Offset: 0x21FB120 VA: 0x1821FCB20
	public static MidiTimeSpan op_Explicit(long timeSpan) { }

	// RVA: 0x21FCAF0 Offset: 0x21FB0F0 VA: 0x1821FCAF0
	public static bool op_Equality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FCB80 Offset: 0x21FB180 VA: 0x1821FCB80
	public static bool op_Inequality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FCBB0 Offset: 0x21FB1B0 VA: 0x1821FCBB0
	public static MidiTimeSpan op_Subtraction(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21FCA30 Offset: 0x21FB030 VA: 0x1821FCA30 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FC810 Offset: 0x21FAE10 VA: 0x1821FC810 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FC890 Offset: 0x21FAE90 VA: 0x1821FC890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FC8B0 Offset: 0x21FAEB0 VA: 0x1821FC8B0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21FC620 Offset: 0x21FAC20 VA: 0x1821FC620 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21FC700 Offset: 0x21FAD00 VA: 0x1821FC700 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21FC680 Offset: 0x21FAC80 VA: 0x1821FC680 Slot: 7
	public int CompareTo(MidiTimeSpan other) { }

	// RVA: 0x21FC7F0 Offset: 0x21FADF0 VA: 0x1821FC7F0 Slot: 8
	public bool Equals(MidiTimeSpan other) { }

}

