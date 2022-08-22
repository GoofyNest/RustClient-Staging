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

	// RVA: 0x7C2470 Offset: 0x7C0A70 VA: 0x1807C2470
	public static SubsurfaceProfileData get_Default() { }

	// RVA: 0x7C2520 Offset: 0x7C0B20 VA: 0x1807C2520
	public static SubsurfaceProfileData get_Invalid() { }

}

