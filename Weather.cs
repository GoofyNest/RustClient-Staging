public class Weather : ConsoleSystem // TypeDefIndex: 11980
{	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static float wetness_rain; // 0x0
	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static float wetness_snow; // 0x4

	[ReplicatedVar] // RVA: 0xC5800 Offset: 0xC4C00 VA: 0x1800C5800
	public static float clear_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A6B0 Offset: 0x99AB0 VA: 0x18009A6B0
	public static float dust_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A6B0 Offset: 0x99AB0 VA: 0x18009A6B0
	public static float fog_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A6B0 Offset: 0x99AB0 VA: 0x18009A6B0
	public static float overcast_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A6B0 Offset: 0x99AB0 VA: 0x18009A6B0
	public static float storm_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A6B0 Offset: 0x99AB0 VA: 0x18009A6B0
	public static float rain_chance { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float rain { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float wind { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float thunder { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float rainbow { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float fog { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float atmosphere_rayleigh { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float atmosphere_mie { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float atmosphere_brightness { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float atmosphere_contrast { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float atmosphere_directionality { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_size { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_opacity { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_coverage { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_sharpness { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_coloring { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_attenuation { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_saturation { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_scattering { get; set; }
	[ReplicatedVar] // RVA: 0xC5D50 Offset: 0xC5150 VA: 0x1800C5D50
	public static float cloud_brightness { get; set; }


	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static void load(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static void reset(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static void report(ConsoleSystem.Arg args) { }

	public static float get_clear_chance() { }

	public static void set_clear_chance(float value) { }

	public static float get_dust_chance() { }

	public static void set_dust_chance(float value) { }

	public static float get_fog_chance() { }

	public static void set_fog_chance(float value) { }

	public static float get_overcast_chance() { }

	public static void set_overcast_chance(float value) { }

	public static float get_storm_chance() { }

	public static void set_storm_chance(float value) { }

	public static float get_rain_chance() { }

	public static void set_rain_chance(float value) { }

	public static float get_rain() { }

	public static void set_rain(float value) { }

	public static float get_wind() { }

	public static void set_wind(float value) { }

	public static float get_thunder() { }

	public static void set_thunder(float value) { }

	public static float get_rainbow() { }

	public static void set_rainbow(float value) { }

	public static float get_fog() { }

	public static void set_fog(float value) { }

	public static float get_atmosphere_rayleigh() { }

	public static void set_atmosphere_rayleigh(float value) { }

	public static float get_atmosphere_mie() { }

	public static void set_atmosphere_mie(float value) { }

	public static float get_atmosphere_brightness() { }

	public static void set_atmosphere_brightness(float value) { }

	public static float get_atmosphere_contrast() { }

	public static void set_atmosphere_contrast(float value) { }

	public static float get_atmosphere_directionality() { }

	public static void set_atmosphere_directionality(float value) { }

	public static float get_cloud_size() { }

	public static void set_cloud_size(float value) { }

	public static float get_cloud_opacity() { }

	public static void set_cloud_opacity(float value) { }

	public static float get_cloud_coverage() { }

	public static void set_cloud_coverage(float value) { }

	public static float get_cloud_sharpness() { }

	public static void set_cloud_sharpness(float value) { }

	public static float get_cloud_coloring() { }

	public static void set_cloud_coloring(float value) { }

	public static float get_cloud_attenuation() { }

	public static void set_cloud_attenuation(float value) { }

	public static float get_cloud_saturation() { }

	public static void set_cloud_saturation(float value) { }

	public static float get_cloud_scattering() { }

	public static void set_cloud_scattering(float value) { }

	public static float get_cloud_brightness() { }

	public static void set_cloud_brightness(float value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Weather.<>c__DisplayClass0_0 // TypeDefIndex: 11981
{	public string name; // 0x10


	public void .ctor() { }

	internal bool <load>b__0(WeatherPreset x) { }

}

