public struct SubsurfaceProfileData // TypeDefIndex: 10662
{	[RangeAttribute] // RVA: 0xEF490 Offset: 0xEE890 VA: 0x1800EF490
	public float ScatterRadius; // 0x0
	[ColorUsageAttribute] // RVA: 0xEF6E0 Offset: 0xEEAE0 VA: 0x1800EF6E0
	public Color SubsurfaceColor; // 0x4
	[ColorUsageAttribute] // RVA: 0xEF6E0 Offset: 0xEEAE0 VA: 0x1800EF6E0
	public Color FalloffColor; // 0x14

	public static SubsurfaceProfileData Default { get; }
	public static SubsurfaceProfileData Invalid { get; }


	public static SubsurfaceProfileData get_Default() { }

	public static SubsurfaceProfileData get_Invalid() { }

}

