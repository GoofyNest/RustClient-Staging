public struct SubsurfaceProfileData // TypeDefIndex: 10662
{	// Fields
	[RangeAttribute] // RVA: 0xEF390 Offset: 0xEE790 VA: 0x1800EF390
	public float ScatterRadius; // 0x0
	[ColorUsageAttribute] // RVA: 0xEF610 Offset: 0xEEA10 VA: 0x1800EF610
	public Color SubsurfaceColor; // 0x4
	[ColorUsageAttribute] // RVA: 0xEF610 Offset: 0xEEA10 VA: 0x1800EF610
	public Color FalloffColor; // 0x14

	// Properties
	public static SubsurfaceProfileData Default { get; }
	public static SubsurfaceProfileData Invalid { get; }

	// Methods

	// RVA: 0x7A3F60 Offset: 0x7A2560 VA: 0x1807A3F60
	public static SubsurfaceProfileData get_Default() { }

	// RVA: 0x7A4010 Offset: 0x7A2610 VA: 0x1807A4010
	public static SubsurfaceProfileData get_Invalid() { }

}

