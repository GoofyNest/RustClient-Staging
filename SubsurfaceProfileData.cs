public struct SubsurfaceProfileData // TypeDefIndex: 10666
{	[RangeAttribute] // RVA: 0xEF8B0 Offset: 0xEECB0 VA: 0x1800EF8B0
	public float ScatterRadius; // 0x0
	[ColorUsageAttribute] // RVA: 0xEF9E0 Offset: 0xEEDE0 VA: 0x1800EF9E0
	public Color SubsurfaceColor; // 0x4
	[ColorUsageAttribute] // RVA: 0xEF9E0 Offset: 0xEEDE0 VA: 0x1800EF9E0
	public Color FalloffColor; // 0x14

	public static SubsurfaceProfileData Default { get; }
	public static SubsurfaceProfileData Invalid { get; }


	public static SubsurfaceProfileData get_Default() { }

	public static SubsurfaceProfileData get_Invalid() { }

}

