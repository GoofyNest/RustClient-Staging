public struct SubsurfaceProfileData // TypeDefIndex: 10662
{	// Fields
	[RangeAttribute] // RVA: 0xEF490 Offset: 0xEE890 VA: 0x1800EF490
	public float ScatterRadius; // 0x0
	[ColorUsageAttribute] // RVA: 0xEF6E0 Offset: 0xEEAE0 VA: 0x1800EF6E0
	public Color SubsurfaceColor; // 0x4
	[ColorUsageAttribute] // RVA: 0xEF6E0 Offset: 0xEEAE0 VA: 0x1800EF6E0
	public Color FalloffColor; // 0x14

	// Properties
	public static SubsurfaceProfileData Default { get; }
	public static SubsurfaceProfileData Invalid { get; }

	// Methods

	// RVA: 0x7A4070 Offset: 0x7A2670 VA: 0x1807A4070
	public static SubsurfaceProfileData get_Default() { }

	// RVA: 0x7A4120 Offset: 0x7A2720 VA: 0x1807A4120
	public static SubsurfaceProfileData get_Invalid() { }

}

