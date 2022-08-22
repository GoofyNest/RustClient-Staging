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

	// RVA: 0x19AFF60 Offset: 0x19AE560 VA: 0x1819AFF60
	public static bool get_fog() { }

	// RVA: 0x19AFF30 Offset: 0x19AE530 VA: 0x1819AFF30
	public static float get_fogStartDistance() { }

	// RVA: 0x19AFED0 Offset: 0x19AE4D0 VA: 0x1819AFED0
	public static float get_fogEndDistance() { }

	// RVA: 0x19AFF00 Offset: 0x19AE500 VA: 0x1819AFF00
	public static FogMode get_fogMode() { }

	// RVA: 0x19AFE60 Offset: 0x19AE460 VA: 0x1819AFE60
	public static Color get_fogColor() { }

	// RVA: 0x19B0370 Offset: 0x19AE970 VA: 0x1819B0370
	public static void set_fogColor(Color value) { }

	// RVA: 0x19AFEA0 Offset: 0x19AE4A0 VA: 0x1819AFEA0
	public static float get_fogDensity() { }

	// RVA: 0x19AFC40 Offset: 0x19AE240 VA: 0x1819AFC40
	public static AmbientMode get_ambientMode() { }

	// RVA: 0x19B01B0 Offset: 0x19AE7B0 VA: 0x1819B01B0
	public static void set_ambientMode(AmbientMode value) { }

	// RVA: 0x19AFD50 Offset: 0x19AE350 VA: 0x1819AFD50
	public static Color get_ambientSkyColor() { }

	// RVA: 0x19B02B0 Offset: 0x19AE8B0 VA: 0x1819B02B0
	public static void set_ambientSkyColor(Color value) { }

	// RVA: 0x19AFAD0 Offset: 0x19AE0D0 VA: 0x1819AFAD0
	public static Color get_ambientEquatorColor() { }

	// RVA: 0x19B0030 Offset: 0x19AE630 VA: 0x1819B0030
	public static void set_ambientEquatorColor(Color value) { }

	// RVA: 0x19AFB50 Offset: 0x19AE150 VA: 0x1819AFB50
	public static Color get_ambientGroundColor() { }

	// RVA: 0x19B00B0 Offset: 0x19AE6B0 VA: 0x1819B00B0
	public static void set_ambientGroundColor(Color value) { }

	// RVA: 0x19AFB90 Offset: 0x19AE190 VA: 0x1819AFB90
	public static float get_ambientIntensity() { }

	// RVA: 0x19B00F0 Offset: 0x19AE6F0 VA: 0x1819B00F0
	public static void set_ambientIntensity(float value) { }

	// RVA: 0x19AFC00 Offset: 0x19AE200 VA: 0x1819AFC00
	public static Color get_ambientLight() { }

	// RVA: 0x19B0170 Offset: 0x19AE770 VA: 0x1819B0170
	public static void set_ambientLight(Color value) { }

	// RVA: 0x19AFFC0 Offset: 0x19AE5C0 VA: 0x1819AFFC0
	public static Material get_skybox() { }

	// RVA: 0x19B03F0 Offset: 0x19AE9F0 VA: 0x1819B03F0
	public static void set_skybox(Material value) { }

	// RVA: 0x19AFCB0 Offset: 0x19AE2B0 VA: 0x1819AFCB0
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	// RVA: 0x19B0230 Offset: 0x19AE830 VA: 0x1819B0230
	public static void set_ambientProbe(SphericalHarmonicsL2 value) { }

	// RVA: 0x19AFD90 Offset: 0x19AE390 VA: 0x1819AFD90
	public static Cubemap get_customReflection() { }

	// RVA: 0x19AFF90 Offset: 0x19AE590 VA: 0x1819AFF90
	public static float get_reflectionIntensity() { }

	// RVA: 0x19B03B0 Offset: 0x19AE9B0 VA: 0x1819B03B0
	public static void set_reflectionIntensity(float value) { }

	// RVA: 0x19AFDC0 Offset: 0x19AE3C0 VA: 0x1819AFDC0
	public static DefaultReflectionMode get_defaultReflectionMode() { }

	// RVA: 0x19B02F0 Offset: 0x19AE8F0 VA: 0x1819B02F0
	public static void set_defaultReflectionMode(DefaultReflectionMode value) { }

	// RVA: 0x19AFDF0 Offset: 0x19AE3F0 VA: 0x1819AFDF0
	public static int get_defaultReflectionResolution() { }

	// RVA: 0x19AFE20 Offset: 0x19AE420 VA: 0x1819AFE20
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x19B0330 Offset: 0x19AE930 VA: 0x1819B0330
	private static void set_fogColor_Injected(ref Color value) { }

	// RVA: 0x19AFD10 Offset: 0x19AE310 VA: 0x1819AFD10
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	// RVA: 0x19B0270 Offset: 0x19AE870 VA: 0x1819B0270
	private static void set_ambientSkyColor_Injected(ref Color value) { }

	// RVA: 0x19AFA90 Offset: 0x19AE090 VA: 0x1819AFA90
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	// RVA: 0x19AFFF0 Offset: 0x19AE5F0 VA: 0x1819AFFF0
	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	// RVA: 0x19AFB10 Offset: 0x19AE110 VA: 0x1819AFB10
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	// RVA: 0x19B0070 Offset: 0x19AE670 VA: 0x1819B0070
	private static void set_ambientGroundColor_Injected(ref Color value) { }

	// RVA: 0x19AFBC0 Offset: 0x19AE1C0 VA: 0x1819AFBC0
	private static void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0x19B0130 Offset: 0x19AE730 VA: 0x1819B0130
	private static void set_ambientLight_Injected(ref Color value) { }

	// RVA: 0x19AFC70 Offset: 0x19AE270 VA: 0x1819AFC70
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	// RVA: 0x19B01F0 Offset: 0x19AE7F0 VA: 0x1819B01F0
	private static void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) { }

}

