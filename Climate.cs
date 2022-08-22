public class Climate : SingletonComponent<Climate> // TypeDefIndex: 9829
{	// Fields
	private const float fadeAngle = 20;
	private const float defaultTemp = 15;
	private const int weatherDurationHours = 18;
	private const int weatherFadeHours = 6;
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float BlendingSpeed; // 0x18
	[RangeAttribute] // RVA: 0x9CA60 Offset: 0x9BE60 VA: 0x18009CA60
	public float FogMultiplier; // 0x1C
	public float FogDarknessDistance; // 0x20
	public bool DebugLUTBlending; // 0x24
	public Climate.WeatherParameters Weather; // 0x28
	public WeatherPreset[] WeatherPresets; // 0x30
	public Climate.ClimateParameters Arid; // 0x38
	public Climate.ClimateParameters Temperate; // 0x40
	public Climate.ClimateParameters Tundra; // 0x48
	public Climate.ClimateParameters Arctic; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <WeatherStateBlend>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <WeatherSeedPrevious>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <WeatherSeedTarget>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <WeatherSeedNext>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WeatherPreset <WeatherStatePrevious>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WeatherPreset <WeatherStateTarget>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WeatherPreset <WeatherStateNext>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WeatherPreset <WeatherState>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WeatherPreset <WeatherClampsMin>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WeatherPreset <WeatherClampsMax>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WeatherPreset <WeatherOverrides>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private LegacyWeatherState <Overrides>k__BackingField; // 0xA0
	private Camera cam; // 0xA8
	private TOD_Scattering scattering; // 0xB0
	private WindZone windZone; // 0xB8
	private Climate.ClimateParameters currentClimate; // 0xC0
	private Climate.ClimateParameters prevClimate; // 0xC8
	private Dictionary<WeatherPresetType, WeatherPreset[]> presetLookup; // 0xD0
	private Climate.ClimateParameters[] climateLookup; // 0xD8

	// Properties
	public float WeatherStateBlend { get; set; }
	public uint WeatherSeedPrevious { get; set; }
	public uint WeatherSeedTarget { get; set; }
	public uint WeatherSeedNext { get; set; }
	public WeatherPreset WeatherStatePrevious { get; set; }
	public WeatherPreset WeatherStateTarget { get; set; }
	public WeatherPreset WeatherStateNext { get; set; }
	public WeatherPreset WeatherState { get; set; }
	public WeatherPreset WeatherClampsMin { get; set; }
	public WeatherPreset WeatherClampsMax { get; set; }
	public WeatherPreset WeatherOverrides { get; set; }
	public LegacyWeatherState Overrides { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574350 Offset: 0x572950 VA: 0x180574350
	public float get_WeatherStateBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	private void set_WeatherStateBlend(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574330 Offset: 0x572930 VA: 0x180574330
	public uint get_WeatherSeedPrevious() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743C0 Offset: 0x5729C0 VA: 0x1805743C0
	private void set_WeatherSeedPrevious(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public uint get_WeatherSeedTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	private void set_WeatherSeedTarget(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574320 Offset: 0x572920 VA: 0x180574320
	public uint get_WeatherSeedNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	private void set_WeatherSeedNext(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public WeatherPreset get_WeatherStatePrevious() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	private void set_WeatherStatePrevious(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public WeatherPreset get_WeatherStateTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	private void set_WeatherStateTarget(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public WeatherPreset get_WeatherStateNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	private void set_WeatherStateNext(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public WeatherPreset get_WeatherState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	private void set_WeatherState(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public WeatherPreset get_WeatherClampsMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	private void set_WeatherClampsMin(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public WeatherPreset get_WeatherClampsMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	private void set_WeatherClampsMax(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public WeatherPreset get_WeatherOverrides() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	private void set_WeatherOverrides(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public LegacyWeatherState get_Overrides() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	private void set_Overrides(LegacyWeatherState value) { }

	// RVA: 0x571900 Offset: 0x56FF00 VA: 0x180571900 Slot: 6
	protected override void Awake() { }

	// RVA: 0x573500 Offset: 0x571B00 VA: 0x180573500 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x573710 Offset: 0x571D10 VA: 0x180573710
	protected void Start() { }

	// RVA: 0x573900 Offset: 0x571F00 VA: 0x180573900
	protected void Update() { }

	// RVA: 0x5731D0 Offset: 0x5717D0 VA: 0x1805731D0
	private static bool Initialized() { }

	// RVA: 0x5722F0 Offset: 0x5708F0 VA: 0x1805722F0
	public static float GetClouds(Vector3 position) { }

	// RVA: 0x572380 Offset: 0x570980 VA: 0x180572380
	public static float GetFog(Vector3 position) { }

	// RVA: 0x573140 Offset: 0x571740 VA: 0x180573140
	public static float GetWind(Vector3 position) { }

	// RVA: 0x572D60 Offset: 0x571360 VA: 0x180572D60
	public static float GetThunder(Vector3 position) { }

	// RVA: 0x5726A0 Offset: 0x570CA0 VA: 0x1805726A0
	public static float GetRainbow(Vector3 position) { }

	// RVA: 0x5720E0 Offset: 0x5706E0 VA: 0x1805720E0
	public static float GetAurora(Vector3 position) { }

	// RVA: 0x572410 Offset: 0x570A10 VA: 0x180572410
	public static float GetRain(Vector3 position) { }

	// RVA: 0x5729E0 Offset: 0x570FE0 VA: 0x1805729E0
	public static float GetSnow(Vector3 position) { }

	// RVA: 0x572B50 Offset: 0x571150 VA: 0x180572B50
	public static float GetTemperature(Vector3 position) { }

	// RVA: 0x572980 Offset: 0x570F80 VA: 0x180572980
	private uint GetSeedFromLong(long val) { }

	// RVA: 0x572E90 Offset: 0x571490 VA: 0x180572E90
	private WeatherPreset GetWeatherPreset(uint seed) { }

	// RVA: 0x572FA0 Offset: 0x5715A0 VA: 0x180572FA0
	private WeatherPreset GetWeatherPreset(uint seed, WeatherPresetType type) { }

	// RVA: 0x571BC0 Offset: 0x5701C0 VA: 0x180571BC0
	private WeatherPreset[] CacheWeatherPresets(WeatherPresetType type) { }

	// RVA: 0x571C80 Offset: 0x570280 VA: 0x180571C80
	private float FindBlendParameters(Vector3 pos, out Climate.ClimateParameters src, out Climate.ClimateParameters dst) { }

	// RVA: 0x574280 Offset: 0x572880 VA: 0x180574280
	public void .ctor() { }

}

public class Climate.ClimateParameters // TypeDefIndex: 9830
{	// Fields
	public AnimationCurve Temperature; // 0x10
	[HorizontalAttribute] // RVA: 0x9ECD0 Offset: 0x9E0D0 VA: 0x18009ECD0
	public Climate.Float4 AerialDensity; // 0x18
	[HorizontalAttribute] // RVA: 0x9ECD0 Offset: 0x9E0D0 VA: 0x18009ECD0
	public Climate.Float4 FogDensity; // 0x20
	[HorizontalAttribute] // RVA: 0x9ECD0 Offset: 0x9E0D0 VA: 0x18009ECD0
	public Climate.Texture2D4 LUT; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Climate.WeatherParameters // TypeDefIndex: 9831
{	// Fields
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float ClearChance; // 0x10
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float DustChance; // 0x14
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float FogChance; // 0x18
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float OvercastChance; // 0x1C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float StormChance; // 0x20
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float RainChance; // 0x24

	// Methods

	// RVA: 0x58A1F0 Offset: 0x5887F0 VA: 0x18058A1F0
	public void .ctor() { }

}

public class Climate.Value4<T> // TypeDefIndex: 9832
{	// Fields
	public T Dawn; // 0x0
	public T Noon; // 0x0
	public T Dusk; // 0x0
	public T Night; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public float FindBlendParameters(TOD_Sky sky, out T src, out T dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1896A70 Offset: 0x1895070 VA: 0x181896A70
	|-Climate.Value4<object>.FindBlendParameters
	|
	|-RVA: 0x1896CC0 Offset: 0x18952C0 VA: 0x181896CC0
	|-Climate.Value4<float>.FindBlendParameters
	|
	|-RVA: 0x1896850 Offset: 0x1894E50 VA: 0x181896850
	|-Climate.Value4<Color>.FindBlendParameters
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-Climate.Value4<object>..ctor
	|-Climate.Value4<float>..ctor
	|-Climate.Value4<Color>..ctor
	|-Climate.Value4<Texture2D>..ctor
	*/

}

public class Climate.Float4 : Climate.Value4<float> // TypeDefIndex: 9833
{	// Methods

	// RVA: 0x5841A0 Offset: 0x5827A0 VA: 0x1805841A0
	public void .ctor() { }

}

public class Climate.Color4 : Climate.Value4<Color> // TypeDefIndex: 9834
{	// Methods

	// RVA: 0x57C880 Offset: 0x57AE80 VA: 0x18057C880
	public void .ctor() { }

}

public class Climate.Texture2D4 : Climate.Value4<Texture2D> // TypeDefIndex: 9835
{	// Methods

	// RVA: 0x5841E0 Offset: 0x5827E0 VA: 0x1805841E0
	public void .ctor() { }

}

private sealed class Climate.<>c__DisplayClass87_0 // TypeDefIndex: 9836
{	// Fields
	public WeatherPresetType type; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589C90 Offset: 0x588290 VA: 0x180589C90
	internal bool <CacheWeatherPresets>b__0(WeatherPreset x) { }

}

