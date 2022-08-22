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

	// RVA: 0x19AFCA0 Offset: 0x19AE2A0 VA: 0x1819AFCA0
	public static bool get_fog() { }

	// RVA: 0x19AFC70 Offset: 0x19AE270 VA: 0x1819AFC70
	public static float get_fogStartDistance() { }

	// RVA: 0x19AFC10 Offset: 0x19AE210 VA: 0x1819AFC10
	public static float get_fogEndDistance() { }

	// RVA: 0x19AFC40 Offset: 0x19AE240 VA: 0x1819AFC40
	public static FogMode get_fogMode() { }

	// RVA: 0x19AFBA0 Offset: 0x19AE1A0 VA: 0x1819AFBA0
	public static Color get_fogColor() { }

	// RVA: 0x19B00B0 Offset: 0x19AE6B0 VA: 0x1819B00B0
	public static void set_fogColor(Color value) { }

	// RVA: 0x19AFBE0 Offset: 0x19AE1E0 VA: 0x1819AFBE0
	public static float get_fogDensity() { }

	// RVA: 0x19AF980 Offset: 0x19ADF80 VA: 0x1819AF980
	public static AmbientMode get_ambientMode() { }

	// RVA: 0x19AFEF0 Offset: 0x19AE4F0 VA: 0x1819AFEF0
	public static void set_ambientMode(AmbientMode value) { }

	// RVA: 0x19AFA90 Offset: 0x19AE090 VA: 0x1819AFA90
	public static Color get_ambientSkyColor() { }

	// RVA: 0x19AFFF0 Offset: 0x19AE5F0 VA: 0x1819AFFF0
	public static void set_ambientSkyColor(Color value) { }

	// RVA: 0x19AF810 Offset: 0x19ADE10 VA: 0x1819AF810
	public static Color get_ambientEquatorColor() { }

	// RVA: 0x19AFD70 Offset: 0x19AE370 VA: 0x1819AFD70
	public static void set_ambientEquatorColor(Color value) { }

	// RVA: 0x19AF890 Offset: 0x19ADE90 VA: 0x1819AF890
	public static Color get_ambientGroundColor() { }

	// RVA: 0x19AFDF0 Offset: 0x19AE3F0 VA: 0x1819AFDF0
	public static void set_ambientGroundColor(Color value) { }

	// RVA: 0x19AF8D0 Offset: 0x19ADED0 VA: 0x1819AF8D0
	public static float get_ambientIntensity() { }

	// RVA: 0x19AFE30 Offset: 0x19AE430 VA: 0x1819AFE30
	public static void set_ambientIntensity(float value) { }

	// RVA: 0x19AF940 Offset: 0x19ADF40 VA: 0x1819AF940
	public static Color get_ambientLight() { }

	// RVA: 0x19AFEB0 Offset: 0x19AE4B0 VA: 0x1819AFEB0
	public static void set_ambientLight(Color value) { }

	// RVA: 0x19AFD00 Offset: 0x19AE300 VA: 0x1819AFD00
	public static Material get_skybox() { }

	// RVA: 0x19B0130 Offset: 0x19AE730 VA: 0x1819B0130
	public static void set_skybox(Material value) { }

	// RVA: 0x19AF9F0 Offset: 0x19ADFF0 VA: 0x1819AF9F0
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	// RVA: 0x19AFF70 Offset: 0x19AE570 VA: 0x1819AFF70
	public static void set_ambientProbe(SphericalHarmonicsL2 value) { }

	// RVA: 0x19AFAD0 Offset: 0x19AE0D0 VA: 0x1819AFAD0
	public static Cubemap get_customReflection() { }

	// RVA: 0x19AFCD0 Offset: 0x19AE2D0 VA: 0x1819AFCD0
	public static float get_reflectionIntensity() { }

	// RVA: 0x19B00F0 Offset: 0x19AE6F0 VA: 0x1819B00F0
	public static void set_reflectionIntensity(float value) { }

	// RVA: 0x19AFB00 Offset: 0x19AE100 VA: 0x1819AFB00
	public static DefaultReflectionMode get_defaultReflectionMode() { }

	// RVA: 0x19B0030 Offset: 0x19AE630 VA: 0x1819B0030
	public static void set_defaultReflectionMode(DefaultReflectionMode value) { }

	// RVA: 0x19AFB30 Offset: 0x19AE130 VA: 0x1819AFB30
	public static int get_defaultReflectionResolution() { }

	// RVA: 0x19AFB60 Offset: 0x19AE160 VA: 0x1819AFB60
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x19B0070 Offset: 0x19AE670 VA: 0x1819B0070
	private static void set_fogColor_Injected(ref Color value) { }

	// RVA: 0x19AFA50 Offset: 0x19AE050 VA: 0x1819AFA50
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	// RVA: 0x19AFFB0 Offset: 0x19AE5B0 VA: 0x1819AFFB0
	private static void set_ambientSkyColor_Injected(ref Color value) { }

	// RVA: 0x19AF7D0 Offset: 0x19ADDD0 VA: 0x1819AF7D0
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	// RVA: 0x19AFD30 Offset: 0x19AE330 VA: 0x1819AFD30
	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	// RVA: 0x19AF850 Offset: 0x19ADE50 VA: 0x1819AF850
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	// RVA: 0x19AFDB0 Offset: 0x19AE3B0 VA: 0x1819AFDB0
	private static void set_ambientGroundColor_Injected(ref Color value) { }

	// RVA: 0x19AF900 Offset: 0x19ADF00 VA: 0x1819AF900
	private static void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0x19AFE70 Offset: 0x19AE470 VA: 0x1819AFE70
	private static void set_ambientLight_Injected(ref Color value) { }

	// RVA: 0x19AF9B0 Offset: 0x19ADFB0 VA: 0x1819AF9B0
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	// RVA: 0x19AFF30 Offset: 0x19AE530 VA: 0x1819AFF30
	private static void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) { }

}

