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

	// RVA: 0x13A7460 Offset: 0x13A5A60 VA: 0x1813A7460
	public void .ctor(SmpteFormat format, byte resolution) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SmpteFormat get_Format() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0
	public byte get_Resolution() { }

	// RVA: 0x13A74D0 Offset: 0x13A5AD0 VA: 0x1813A74D0
	public static bool op_Equality(SmpteTimeDivision timeDivision1, SmpteTimeDivision timeDivision2) { }

	// RVA: 0x13A73E0 Offset: 0x13A59E0 VA: 0x1813A73E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A7300 Offset: 0x13A5900 VA: 0x1813A7300 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A7390 Offset: 0x13A5990 VA: 0x1813A7390 Slot: 2
	public override int GetHashCode() { }

}

