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
	// RVA: 0x5743C0 Offset: 0x5729C0 VA: 0x1805743C0
	public float get_WeatherStateBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574450 Offset: 0x572A50 VA: 0x180574450
	private void set_WeatherStateBlend(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public uint get_WeatherSeedPrevious() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574430 Offset: 0x572A30 VA: 0x180574430
	private void set_WeatherSeedPrevious(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public uint get_WeatherSeedTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	private void set_WeatherSeedTarget(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public uint get_WeatherSeedNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574420 Offset: 0x572A20 VA: 0x180574420
	private void set_WeatherSeedNext(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public WeatherPreset get_WeatherStatePrevious() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	private void set_WeatherStatePrevious(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public WeatherPreset get_WeatherStateTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	private void set_WeatherStateTarget(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public WeatherPreset get_WeatherStateNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	private void set_WeatherStateNext(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public WeatherPreset get_WeatherState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	private void set_WeatherState(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public WeatherPreset get_WeatherClampsMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	private void set_WeatherClampsMin(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public WeatherPreset get_WeatherClampsMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	private void set_WeatherClampsMax(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public WeatherPreset get_WeatherOverrides() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	private void set_WeatherOverrides(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public LegacyWeatherState get_Overrides() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	private void set_Overrides(LegacyWeatherState value) { }

	// RVA: 0x571970 Offset: 0x56FF70 VA: 0x180571970 Slot: 6
	protected override void Awake() { }

	// RVA: 0x573570 Offset: 0x571B70 VA: 0x180573570 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x573780 Offset: 0x571D80 VA: 0x180573780
	protected void Start() { }

	// RVA: 0x573970 Offset: 0x571F70 VA: 0x180573970
	protected void Update() { }

	// RVA: 0x573240 Offset: 0x571840 VA: 0x180573240
	private static bool Initialized() { }

	// RVA: 0x572360 Offset: 0x570960 VA: 0x180572360
	public static float GetClouds(Vector3 position) { }

	// RVA: 0x5723F0 Offset: 0x5709F0 VA: 0x1805723F0
	public static float GetFog(Vector3 position) { }

	// RVA: 0x5731B0 Offset: 0x5717B0 VA: 0x1805731B0
	public static float GetWind(Vector3 position) { }

	// RVA: 0x572DD0 Offset: 0x5713D0 VA: 0x180572DD0
	public static float GetThunder(Vector3 position) { }

	// RVA: 0x572710 Offset: 0x570D10 VA: 0x180572710
	public static float GetRainbow(Vector3 position) { }

	// RVA: 0x572150 Offset: 0x570750 VA: 0x180572150
	public static float GetAurora(Vector3 position) { }

	// RVA: 0x572480 Offset: 0x570A80 VA: 0x180572480
	public static float GetRain(Vector3 position) { }

	// RVA: 0x572A50 Offset: 0x571050 VA: 0x180572A50
	public static float GetSnow(Vector3 position) { }

	// RVA: 0x572BC0 Offset: 0x5711C0 VA: 0x180572BC0
	public static float GetTemperature(Vector3 position) { }

	// RVA: 0x5729F0 Offset: 0x570FF0 VA: 0x1805729F0
	private uint GetSeedFromLong(long val) { }

	// RVA: 0x572F00 Offset: 0x571500 VA: 0x180572F00
	private WeatherPreset GetWeatherPreset(uint seed) { }

	// RVA: 0x573010 Offset: 0x571610 VA: 0x180573010
	private WeatherPreset GetWeatherPreset(uint seed, WeatherPresetType type) { }

	// RVA: 0x571C30 Offset: 0x570230 VA: 0x180571C30
	private WeatherPreset[] CacheWeatherPresets(WeatherPresetType type) { }

	// RVA: 0x571CF0 Offset: 0x5702F0 VA: 0x180571CF0
	private float FindBlendParameters(Vector3 pos, out Climate.ClimateParameters src, out Climate.ClimateParameters dst) { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
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

	// RVA: 0x58A260 Offset: 0x588860 VA: 0x18058A260
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
	|-RVA: 0x15EA470 Offset: 0x15E8A70 VA: 0x1815EA470
	|-Climate.Value4<object>.FindBlendParameters
	|
	|-RVA: 0x15EA6C0 Offset: 0x15E8CC0 VA: 0x1815EA6C0
	|-Climate.Value4<float>.FindBlendParameters
	|
	|-RVA: 0x15EA250 Offset: 0x15E8850 VA: 0x1815EA250
	|-Climate.Value4<Color>.FindBlendParameters
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-Climate.Value4<object>..ctor
	|-Climate.Value4<float>..ctor
	|-Climate.Value4<Color>..ctor
	|-Climate.Value4<Texture2D>..ctor
	*/

}

public class Climate.Float4 : Climate.Value4<float> // TypeDefIndex: 9833
{	// Methods

	// RVA: 0x584210 Offset: 0x582810 VA: 0x180584210
	public void .ctor() { }

}

public class Climate.Color4 : Climate.Value4<Color> // TypeDefIndex: 9834
{	// Methods

	// RVA: 0x57C8F0 Offset: 0x57AEF0 VA: 0x18057C8F0
	public void .ctor() { }

}

public class Climate.Texture2D4 : Climate.Value4<Texture2D> // TypeDefIndex: 9835
{	// Methods

	// RVA: 0x584250 Offset: 0x582850 VA: 0x180584250
	public void .ctor() { }

}

private sealed class Climate.<>c__DisplayClass87_0 // TypeDefIndex: 9836
{	// Fields
	public WeatherPresetType type; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589D00 Offset: 0x588300 VA: 0x180589D00
	internal bool <CacheWeatherPresets>b__0(WeatherPreset x) { }

}

