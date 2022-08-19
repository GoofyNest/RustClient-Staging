public class Weather : ConsoleSystem // TypeDefIndex: 11976
{	// Fields
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float wetness_rain; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float wetness_snow; // 0x4

	// Properties
	[ReplicatedVar] // RVA: 0xC5B70 Offset: 0xC4F70 VA: 0x1800C5B70
	public static float clear_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9AB90 Offset: 0x99F90 VA: 0x18009AB90
	public static float dust_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9AB90 Offset: 0x99F90 VA: 0x18009AB90
	public static float fog_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9AB90 Offset: 0x99F90 VA: 0x18009AB90
	public static float overcast_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9AB90 Offset: 0x99F90 VA: 0x18009AB90
	public static float storm_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9AB90 Offset: 0x99F90 VA: 0x18009AB90
	public static float rain_chance { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float rain { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float wind { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float thunder { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float rainbow { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float fog { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float atmosphere_rayleigh { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float atmosphere_mie { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float atmosphere_brightness { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float atmosphere_contrast { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float atmosphere_directionality { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_size { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_opacity { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_coverage { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_sharpness { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_coloring { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_attenuation { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_saturation { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_scattering { get; set; }
	[ReplicatedVar] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	public static float cloud_brightness { get; set; }

	// Methods

	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	// RVA: 0x36F110 Offset: 0x36D710 VA: 0x18036F110
	public static void load(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	// RVA: 0x36FC20 Offset: 0x36E220 VA: 0x18036FC20
	public static void reset(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	// RVA: 0x36F420 Offset: 0x36DA20 VA: 0x18036F420
	public static void report(ConsoleSystem.Arg args) { }

	// RVA: 0x36DEB0 Offset: 0x36C4B0 VA: 0x18036DEB0
	public static float get_clear_chance() { }

	// RVA: 0x370280 Offset: 0x36E880 VA: 0x180370280
	public static void set_clear_chance(float value) { }

	// RVA: 0x36E800 Offset: 0x36CE00 VA: 0x18036E800
	public static float get_dust_chance() { }

	// RVA: 0x370C00 Offset: 0x36F200 VA: 0x180370C00
	public static void set_dust_chance(float value) { }

	// RVA: 0x36E8E0 Offset: 0x36CEE0 VA: 0x18036E8E0
	public static float get_fog_chance() { }

	// RVA: 0x370D10 Offset: 0x36F310 VA: 0x180370D10
	public static void set_fog_chance(float value) { }

	// RVA: 0x36EAB0 Offset: 0x36D0B0 VA: 0x18036EAB0
	public static float get_overcast_chance() { }

	// RVA: 0x370F10 Offset: 0x36F510 VA: 0x180370F10
	public static void set_overcast_chance(float value) { }

	// RVA: 0x36EE50 Offset: 0x36D450 VA: 0x18036EE50
	public static float get_storm_chance() { }

	// RVA: 0x3712F0 Offset: 0x36F8F0 VA: 0x1803712F0
	public static void set_storm_chance(float value) { }

	// RVA: 0x36EB90 Offset: 0x36D190 VA: 0x18036EB90
	public static float get_rain_chance() { }

	// RVA: 0x371020 Offset: 0x36F620 VA: 0x180371020
	public static void set_rain_chance(float value) { }

	// RVA: 0x36EC70 Offset: 0x36D270 VA: 0x18036EC70
	public static float get_rain() { }

	// RVA: 0x371130 Offset: 0x36F730 VA: 0x180371130
	public static void set_rain(float value) { }

	// RVA: 0x36F020 Offset: 0x36D620 VA: 0x18036F020
	public static float get_wind() { }

	// RVA: 0x3714E0 Offset: 0x36FAE0 VA: 0x1803714E0
	public static void set_wind(float value) { }

	// RVA: 0x36EF30 Offset: 0x36D530 VA: 0x18036EF30
	public static float get_thunder() { }

	// RVA: 0x371400 Offset: 0x36FA00 VA: 0x180371400
	public static void set_thunder(float value) { }

	// RVA: 0x36ED60 Offset: 0x36D360 VA: 0x18036ED60
	public static float get_rainbow() { }

	// RVA: 0x371210 Offset: 0x36F810 VA: 0x180371210
	public static void set_rainbow(float value) { }

	// RVA: 0x36E9C0 Offset: 0x36CFC0 VA: 0x18036E9C0
	public static float get_fog() { }

	// RVA: 0x370E20 Offset: 0x36F420 VA: 0x180370E20
	public static void set_fog(float value) { }

	// RVA: 0x36DDC0 Offset: 0x36C3C0 VA: 0x18036DDC0
	public static float get_atmosphere_rayleigh() { }

	// RVA: 0x370190 Offset: 0x36E790 VA: 0x180370190
	public static void set_atmosphere_rayleigh(float value) { }

	// RVA: 0x36DCD0 Offset: 0x36C2D0 VA: 0x18036DCD0
	public static float get_atmosphere_mie() { }

	// RVA: 0x3700A0 Offset: 0x36E6A0 VA: 0x1803700A0
	public static void set_atmosphere_mie(float value) { }

	// RVA: 0x36DA00 Offset: 0x36C000 VA: 0x18036DA00
	public static float get_atmosphere_brightness() { }

	// RVA: 0x36FDD0 Offset: 0x36E3D0 VA: 0x18036FDD0
	public static void set_atmosphere_brightness(float value) { }

	// RVA: 0x36DAF0 Offset: 0x36C0F0 VA: 0x18036DAF0
	public static float get_atmosphere_contrast() { }

	// RVA: 0x36FEC0 Offset: 0x36E4C0 VA: 0x18036FEC0
	public static void set_atmosphere_contrast(float value) { }

	// RVA: 0x36DBE0 Offset: 0x36C1E0 VA: 0x18036DBE0
	public static float get_atmosphere_directionality() { }

	// RVA: 0x36FFB0 Offset: 0x36E5B0 VA: 0x18036FFB0
	public static void set_atmosphere_directionality(float value) { }

	// RVA: 0x36E710 Offset: 0x36CD10 VA: 0x18036E710
	public static float get_cloud_size() { }

	// RVA: 0x370B10 Offset: 0x36F110 VA: 0x180370B10
	public static void set_cloud_size(float value) { }

	// RVA: 0x36E350 Offset: 0x36C950 VA: 0x18036E350
	public static float get_cloud_opacity() { }

	// RVA: 0x370750 Offset: 0x36ED50 VA: 0x180370750
	public static void set_cloud_opacity(float value) { }

	// RVA: 0x36E260 Offset: 0x36C860 VA: 0x18036E260
	public static float get_cloud_coverage() { }

	// RVA: 0x370660 Offset: 0x36EC60 VA: 0x180370660
	public static void set_cloud_coverage(float value) { }

	// RVA: 0x36E620 Offset: 0x36CC20 VA: 0x18036E620
	public static float get_cloud_sharpness() { }

	// RVA: 0x370A20 Offset: 0x36F020 VA: 0x180370A20
	public static void set_cloud_sharpness(float value) { }

	// RVA: 0x36E170 Offset: 0x36C770 VA: 0x18036E170
	public static float get_cloud_coloring() { }

	// RVA: 0x370570 Offset: 0x36EB70 VA: 0x180370570
	public static void set_cloud_coloring(float value) { }

	// RVA: 0x36DF90 Offset: 0x36C590 VA: 0x18036DF90
	public static float get_cloud_attenuation() { }

	// RVA: 0x370390 Offset: 0x36E990 VA: 0x180370390
	public static void set_cloud_attenuation(float value) { }

	// RVA: 0x36E440 Offset: 0x36CA40 VA: 0x18036E440
	public static float get_cloud_saturation() { }

	// RVA: 0x370840 Offset: 0x36EE40 VA: 0x180370840
	public static void set_cloud_saturation(float value) { }

	// RVA: 0x36E530 Offset: 0x36CB30 VA: 0x18036E530
	public static float get_cloud_scattering() { }

	// RVA: 0x370930 Offset: 0x36EF30 VA: 0x180370930
	public static void set_cloud_scattering(float value) { }

	// RVA: 0x36E080 Offset: 0x36C680 VA: 0x18036E080
	public static float get_cloud_brightness() { }

	// RVA: 0x370480 Offset: 0x36EA80 VA: 0x180370480
	public static void set_cloud_brightness(float value) { }

	// RVA: 0x36D9A0 Offset: 0x36BFA0 VA: 0x18036D9A0
	public void .ctor() { }

	// RVA: 0x36D950 Offset: 0x36BF50 VA: 0x18036D950
	private static void .cctor() { }

}

private sealed class Weather.<>c__DisplayClass0_0 // TypeDefIndex: 11977
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x36D4D0 Offset: 0x36BAD0 VA: 0x18036D4D0
	internal bool <load>b__0(WeatherPreset x) { }

}

