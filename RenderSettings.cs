public sealed class RenderSettings : Object // TypeDefIndex: 3404
{	// Properties
	[NativePropertyAttribute] // RVA: 0x909B0 Offset: 0x8FDB0 VA: 0x1800909B0
	public static bool fog { get; }
	[NativePropertyAttribute] // RVA: 0x90A70 Offset: 0x8FE70 VA: 0x180090A70
	public static float fogStartDistance { get; }
	[NativePropertyAttribute] // RVA: 0x90D30 Offset: 0x90130 VA: 0x180090D30
	public static float fogEndDistance { get; }
	public static FogMode fogMode { get; }
	public static Color fogColor { get; set; }
	public static float fogDensity { get; }
	public static AmbientMode ambientMode { get; set; }
	public static Color ambientSkyColor { get; set; }
	public static Color ambientEquatorColor { get; set; }
	public static Color ambientGroundColor { get; set; }
	public static float ambientIntensity { get; set; }
	[NativePropertyAttribute] // RVA: 0x90E40 Offset: 0x90240 VA: 0x180090E40
	public static Color ambientLight { get; set; }
	[NativePropertyAttribute] // RVA: 0x90F50 Offset: 0x90350 VA: 0x180090F50
	public static Material skybox { get; set; }
	public static SphericalHarmonicsL2 ambientProbe { get; set; }
	public static Cubemap customReflection { get; }
	public static float reflectionIntensity { get; set; }
	public static DefaultReflectionMode defaultReflectionMode { get; set; }
	public static int defaultReflectionResolution { get; }

	// Methods

	// RVA: 0x199D360 Offset: 0x199B960 VA: 0x18199D360
	public static bool get_fog() { }

	// RVA: 0x199D330 Offset: 0x199B930 VA: 0x18199D330
	public static float get_fogStartDistance() { }

	// RVA: 0x199D2D0 Offset: 0x199B8D0 VA: 0x18199D2D0
	public static float get_fogEndDistance() { }

	// RVA: 0x199D300 Offset: 0x199B900 VA: 0x18199D300
	public static FogMode get_fogMode() { }

	// RVA: 0x199D260 Offset: 0x199B860 VA: 0x18199D260
	public static Color get_fogColor() { }

	// RVA: 0x199D770 Offset: 0x199BD70 VA: 0x18199D770
	public static void set_fogColor(Color value) { }

	// RVA: 0x199D2A0 Offset: 0x199B8A0 VA: 0x18199D2A0
	public static float get_fogDensity() { }

	// RVA: 0x199D040 Offset: 0x199B640 VA: 0x18199D040
	public static AmbientMode get_ambientMode() { }

	// RVA: 0x199D5B0 Offset: 0x199BBB0 VA: 0x18199D5B0
	public static void set_ambientMode(AmbientMode value) { }

	// RVA: 0x199D150 Offset: 0x199B750 VA: 0x18199D150
	public static Color get_ambientSkyColor() { }

	// RVA: 0x199D6B0 Offset: 0x199BCB0 VA: 0x18199D6B0
	public static void set_ambientSkyColor(Color value) { }

	// RVA: 0x199CED0 Offset: 0x199B4D0 VA: 0x18199CED0
	public static Color get_ambientEquatorColor() { }

	// RVA: 0x199D430 Offset: 0x199BA30 VA: 0x18199D430
	public static void set_ambientEquatorColor(Color value) { }

	// RVA: 0x199CF50 Offset: 0x199B550 VA: 0x18199CF50
	public static Color get_ambientGroundColor() { }

	// RVA: 0x199D4B0 Offset: 0x199BAB0 VA: 0x18199D4B0
	public static void set_ambientGroundColor(Color value) { }

	// RVA: 0x199CF90 Offset: 0x199B590 VA: 0x18199CF90
	public static float get_ambientIntensity() { }

	// RVA: 0x199D4F0 Offset: 0x199BAF0 VA: 0x18199D4F0
	public static void set_ambientIntensity(float value) { }

	// RVA: 0x199D000 Offset: 0x199B600 VA: 0x18199D000
	public static Color get_ambientLight() { }

	// RVA: 0x199D570 Offset: 0x199BB70 VA: 0x18199D570
	public static void set_ambientLight(Color value) { }

	// RVA: 0x199D3C0 Offset: 0x199B9C0 VA: 0x18199D3C0
	public static Material get_skybox() { }

	// RVA: 0x199D7F0 Offset: 0x199BDF0 VA: 0x18199D7F0
	public static void set_skybox(Material value) { }

	// RVA: 0x199D0B0 Offset: 0x199B6B0 VA: 0x18199D0B0
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	// RVA: 0x199D630 Offset: 0x199BC30 VA: 0x18199D630
	public static void set_ambientProbe(SphericalHarmonicsL2 value) { }

	// RVA: 0x199D190 Offset: 0x199B790 VA: 0x18199D190
	public static Cubemap get_customReflection() { }

	// RVA: 0x199D390 Offset: 0x199B990 VA: 0x18199D390
	public static float get_reflectionIntensity() { }

	// RVA: 0x199D7B0 Offset: 0x199BDB0 VA: 0x18199D7B0
	public static void set_reflectionIntensity(float value) { }

	// RVA: 0x199D1C0 Offset: 0x199B7C0 VA: 0x18199D1C0
	public static DefaultReflectionMode get_defaultReflectionMode() { }

	// RVA: 0x199D6F0 Offset: 0x199BCF0 VA: 0x18199D6F0
	public static void set_defaultReflectionMode(DefaultReflectionMode value) { }

	// RVA: 0x199D1F0 Offset: 0x199B7F0 VA: 0x18199D1F0
	public static int get_defaultReflectionResolution() { }

	// RVA: 0x199D220 Offset: 0x199B820 VA: 0x18199D220
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x199D730 Offset: 0x199BD30 VA: 0x18199D730
	private static void set_fogColor_Injected(ref Color value) { }

	// RVA: 0x199D110 Offset: 0x199B710 VA: 0x18199D110
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	// RVA: 0x199D670 Offset: 0x199BC70 VA: 0x18199D670
	private static void set_ambientSkyColor_Injected(ref Color value) { }

	// RVA: 0x199CE90 Offset: 0x199B490 VA: 0x18199CE90
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	// RVA: 0x199D3F0 Offset: 0x199B9F0 VA: 0x18199D3F0
	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	// RVA: 0x199CF10 Offset: 0x199B510 VA: 0x18199CF10
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	// RVA: 0x199D470 Offset: 0x199BA70 VA: 0x18199D470
	private static void set_ambientGroundColor_Injected(ref Color value) { }

	// RVA: 0x199CFC0 Offset: 0x199B5C0 VA: 0x18199CFC0
	private static void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0x199D530 Offset: 0x199BB30 VA: 0x18199D530
	private static void set_ambientLight_Injected(ref Color value) { }

	// RVA: 0x199D070 Offset: 0x199B670 VA: 0x18199D070
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	// RVA: 0x199D5F0 Offset: 0x199BBF0 VA: 0x18199D5F0
	private static void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) { }

}

