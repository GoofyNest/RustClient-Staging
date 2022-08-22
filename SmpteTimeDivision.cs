public sealed class SmpteTimeDivision : TimeDivision // TypeDefIndex: 7611
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly SmpteFormat <Format>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly byte <Resolution>k__BackingField; // 0x11

	// Properties
	public SmpteFormat Format { get; }
	public byte Resolution { get; }

	// Methods

	// RVA: 0x13A6820 Offset: 0x13A4E20 VA: 0x1813A6820
	public void .ctor(SmpteFormat format, byte resolution) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SmpteFormat get_Format() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C110 Offset: 0xF8A710 VA: 0x180F8C110
	public byte get_Resolution() { }

	// RVA: 0x13A6890 Offset: 0x13A4E90 VA: 0x1813A6890
	public static bool op_Equality(SmpteTimeDivision timeDivision1, SmpteTimeDivision timeDivision2) { }

	// RVA: 0x13A67A0 Offset: 0x13A4DA0 VA: 0x1813A67A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A66C0 Offset: 0x13A4CC0 VA: 0x1813A66C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A6750 Offset: 0x13A4D50 VA: 0x1813A6750 Slot: 2
	public override int GetHashCode() { }

}

