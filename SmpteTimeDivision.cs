public sealed class SmpteTimeDivision : TimeDivision // TypeDefIndex: 7611
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private readonly SmpteFormat <Format>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private readonly byte <Resolution>k__BackingField; // 0x11

	public SmpteFormat Format { get; }
	public byte Resolution { get; }


	public void .ctor(SmpteFormat format, byte resolution) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public SmpteFormat get_Format() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public byte get_Resolution() { }

	public static bool op_Equality(SmpteTimeDivision timeDivision1, SmpteTimeDivision timeDivision2) { }

	public override string ToString() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

