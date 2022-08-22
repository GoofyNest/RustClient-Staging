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

	// RVA: 0x13A7720 Offset: 0x13A5D20 VA: 0x1813A7720
	public void .ctor(SmpteFormat format, byte resolution) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SmpteFormat get_Format() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B670 Offset: 0xF89C70 VA: 0x180F8B670
	public byte get_Resolution() { }

	// RVA: 0x13A7790 Offset: 0x13A5D90 VA: 0x1813A7790
	public static bool op_Equality(SmpteTimeDivision timeDivision1, SmpteTimeDivision timeDivision2) { }

	// RVA: 0x13A76A0 Offset: 0x13A5CA0 VA: 0x1813A76A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A75C0 Offset: 0x13A5BC0 VA: 0x1813A75C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A7650 Offset: 0x13A5C50 VA: 0x1813A7650 Slot: 2
	public override int GetHashCode() { }

}

