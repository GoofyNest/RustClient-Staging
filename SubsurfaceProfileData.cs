public struct SubsurfaceProfileData // TypeDefIndex: 10666
{	[RangeAttribute] // RVA: 0xEEDE0 Offset: 0xEE1E0 VA: 0x1800EEDE0
	public float ScatterRadius; // 0x0
	[ColorUsageAttribute] // RVA: 0xEEEC0 Offset: 0xEE2C0 VA: 0x1800EEEC0
	public Color SubsurfaceColor; // 0x4
	[ColorUsageAttribute] // RVA: 0xEEEC0 Offset: 0xEE2C0 VA: 0x1800EEEC0
	public Color FalloffColor; // 0x14

	public static SubsurfaceProfileData Default { get; }
	public static SubsurfaceProfileData Invalid { get; }


	public static SubsurfaceProfileData get_Default() { }

	public static SubsurfaceProfileData get_Invalid() { }

}

