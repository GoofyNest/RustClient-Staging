public class WaterSystem : MonoBehaviour // TypeDefIndex: 10627
{	// Fields
	public WaterQuality Quality; // 0x18
	public bool ShowDebug; // 0x1C
	public bool ShowGizmos; // 0x1D
	public bool ProgressTime; // 0x1E
	public GameObject FallbackPlane; // 0x20
	public WaterSystem.SimulationSettings Simulation; // 0x28
	public WaterSystem.RenderingSettings Rendering; // 0x30
	private WaterGerstner.PrecomputedWave[] precomputedWaves; // 0x38
	private WaterGerstner.PrecomputedShoreWaves precomputedShoreWaves; // 0x40
	private Vector4[] waveArray; // 0x68
	private Vector4[] shoreWaveArray; // 0x70
	private Vector4 global0; // 0x78
	private Vector4 global1; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <ShoreWavesRcpFadeDistance>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <TerrainRcpFadeDistance>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsInitialized>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static WaterCollision <Collision>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static WaterDynamics <Dynamics>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static WaterBody <Ocean>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static HashSet<WaterBody> <WaterBodies>k__BackingField; // 0x18
	private static float oceanLevel; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static float <WaveTime>k__BackingField; // 0x24
	public static readonly int[] QualityToMaxVertices; // 0x28
	private WaterQuality prevQuality; // 0xA4
	private ReflectionProbeEx reflectionProbe; // 0xA8
	private float reflectionProbeUpdateTime; // 0xB0
	private bool reflectionProbeReady; // 0xB4
	private Texture2D defaultHeightSlopeMap; // 0xB8
	private bool hasValidCausticsAnims; // 0xC0
	private List<WaterRuntime> runtimeCleanup; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Dictionary<WaterCamera, WaterRuntime> <Runtimes>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static HashSet<WaterDepthMask> <DepthMasks>k__BackingField; // 0x38
	private static WaterSystem instance; // 0x40
	private static Vector3[] emptyShoreMap; // 0x48
	private static short[] emptyWaterMap; // 0x50
	private static short[] emptyHeightMap; // 0x58
	private static WaterSystem.NativePathState nativePathState; // 0x60
	private static Vector3[] currentShoreMap; // 0x68
	private static GCHandle currentShoreMapHandle; // 0x70
	private static short[] currentWaterMap; // 0x78
	private static GCHandle currentWaterMapHandle; // 0x80
	private static short[] currentHeightMap; // 0x88
	private static GCHandle currentHeightMapHandle; // 0x90
	private static Vector4[] currentOpenWaves; // 0x98
	private static GCHandle currentOpenWavesHandle; // 0xA0
	private static Vector4[] currentShoreWaves; // 0xA8
	private static GCHandle currentShoreWavesHandle; // 0xB0
	private float lastQualityChange; // 0xD0

	// Properties
	public WaterGerstner.PrecomputedWave[] PrecomputedWaves { get; }
	public WaterGerstner.PrecomputedShoreWaves PrecomputedShoreWaves { get; }
	public Vector4 Global0 { get; }
	public Vector4 Global1 { get; }
	public float ShoreWavesRcpFadeDistance { get; set; }
	public float TerrainRcpFadeDistance { get; set; }
	public bool IsInitialized { get; set; }
	public static WaterCollision Collision { get; set; }
	public static WaterDynamics Dynamics { get; set; }
	public static WaterBody Ocean { get; set; }
	public static HashSet<WaterBody> WaterBodies { get; set; }
	public static float OceanLevel { get; set; }
	public static float WaveTime { get; set; }
	public bool HasCaustics { get; }
	public static Dictionary<WaterCamera, WaterRuntime> Runtimes { get; set; }
	public static HashSet<WaterDepthMask> DepthMasks { get; set; }
	public static WaterSystem Instance { get; }

	// Methods

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public WaterGerstner.PrecomputedWave[] get_PrecomputedWaves() { }

	// RVA: 0xC2B910 Offset: 0xC29F10 VA: 0x180C2B910
	public WaterGerstner.PrecomputedShoreWaves get_PrecomputedShoreWaves() { }

	// RVA: 0xC2B740 Offset: 0xC29D40 VA: 0x180C2B740
	public Vector4 get_Global0() { }

	// RVA: 0xC2B750 Offset: 0xC29D50 VA: 0x180C2B750
	public Vector4 get_Global1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6FC1C0 Offset: 0x6FA7C0 VA: 0x1806FC1C0
	public float get_ShoreWavesRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6FC5B0 Offset: 0x6FABB0 VA: 0x1806FC5B0
	private void set_ShoreWavesRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2B9F0 Offset: 0xC29FF0 VA: 0x180C2B9F0
	public float get_TerrainRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BE90 Offset: 0xC2A490 VA: 0x180C2BE90
	private void set_TerrainRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BCC0 Offset: 0xC2A2C0 VA: 0x180C2BCC0
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2B7E0 Offset: 0xC29DE0 VA: 0x180C2B7E0
	public bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2B620 Offset: 0xC29C20 VA: 0x180C2B620
	public static WaterCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BB80 Offset: 0xC2A180 VA: 0x180C2BB80
	private static void set_Collision(WaterCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BC50 Offset: 0xC2A250 VA: 0x180C2BC50
	private static void set_Dynamics(WaterDynamics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2B6E0 Offset: 0xC29CE0 VA: 0x180C2B6E0
	public static WaterDynamics get_Dynamics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BDB0 Offset: 0xC2A3B0 VA: 0x180C2BDB0
	private static void set_Ocean(WaterBody value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2B850 Offset: 0xC29E50 VA: 0x180C2B850
	public static WaterBody get_Ocean() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BEA0 Offset: 0xC2A4A0 VA: 0x180C2BEA0
	private static void set_WaterBodies(HashSet<WaterBody> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BA00 Offset: 0xC2A000 VA: 0x180C2BA00
	public static HashSet<WaterBody> get_WaterBodies() { }

	// RVA: 0xC2B7F0 Offset: 0xC29DF0 VA: 0x180C2B7F0
	public static float get_OceanLevel() { }

	// RVA: 0xC2BCD0 Offset: 0xC2A2D0 VA: 0x180C2BCD0
	public static void set_OceanLevel(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BAC0 Offset: 0xC2A0C0 VA: 0x180C2BAC0
	public static float get_WaveTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BF10 Offset: 0xC2A510 VA: 0x180C2BF10
	private static void set_WaveTime(float value) { }

	// RVA: 0xC2B760 Offset: 0xC29D60 VA: 0x180C2B760
	public bool get_HasCaustics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BE20 Offset: 0xC2A420 VA: 0x180C2BE20
	private static void set_Runtimes(Dictionary<WaterCamera, WaterRuntime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2B930 Offset: 0xC29F30 VA: 0x180C2B930
	public static Dictionary<WaterCamera, WaterRuntime> get_Runtimes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2BBE0 Offset: 0xC2A1E0 VA: 0x180C2BBE0
	private static void set_DepthMasks(HashSet<WaterDepthMask> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC2B680 Offset: 0xC29C80 VA: 0x180C2B680
	public static HashSet<WaterDepthMask> get_DepthMasks() { }

	// RVA: 0xC2B780 Offset: 0xC29D80 VA: 0x180C2B780
	public static WaterSystem get_Instance() { }

	// RVA: 0xC23C90 Offset: 0xC22290 VA: 0x180C23C90
	private void CheckInstance() { }

	// RVA: 0xC23C10 Offset: 0xC22210 VA: 0x180C23C10
	public void Awake() { }

	// RVA: 0xC26B30 Offset: 0xC25130 VA: 0x180C26B30
	private static extern void SetBaseConstants_Native(int shoreMapSize, ref Vector3 shoreMap, int waterHeightMapSize, ref short waterHeightMap, Vector4 packedParams) { }

	// RVA: 0xC27620 Offset: 0xC25C20 VA: 0x180C27620
	private static extern void SetTerrainConstants_Native(int terrainHeightMapSize, ref short terrainHeightMap, Vector3 terrainPosition, Vector3 terrainSize) { }

	// RVA: 0xC26BF0 Offset: 0xC251F0 VA: 0x180C26BF0
	private static extern void SetGerstnerConstants_Native(Vector4 globalParams0, Vector4 globalParams1, ref Vector4 openWaves, ref Vector4 shoreWaves) { }

	// RVA: 0xC297A0 Offset: 0xC27DA0 VA: 0x180C297A0
	private static extern void UpdateOceanLevel_Native(float oceanWaterLevel) { }

	// RVA: 0xC25440 Offset: 0xC23A40 VA: 0x180C25440
	private static extern float GetHeightArray_Native(int sampleCount, ref Vector2 pos, ref Vector2 posUV, ref Vector3 shore, ref float terrainHeight, ref float waterHeight) { }

	// RVA: 0xC25D30 Offset: 0xC24330 VA: 0x180C25D30
	private static extern float GetHeight_Native(Vector3 pos) { }

	// RVA: 0xC23C20 Offset: 0xC22220 VA: 0x180C23C20
	private static extern bool CPU_SupportsSSE41() { }

	// RVA: 0xC26CB0 Offset: 0xC252B0 VA: 0x180C26CB0
	private static void SetNativeConstants(TerrainTexturing terrainTexturing, TerrainWaterMap terrainWaterMap, TerrainHeightMap terrainHeightMap, Vector4 globalParams0, Vector4 globalParams1, Vector4[] openWaves, Vector4[] shoreWaves) { }

	// RVA: -1 Offset: -1
	private static void PinObject<T>(T value, ref T currentValue, ref GCHandle currentValueHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA500 Offset: 0x5D8B00 VA: 0x1805DA500
	|-WaterSystem.PinObject<short[]>
	|-WaterSystem.PinObject<object>
	|-WaterSystem.PinObject<Vector3[]>
	|-WaterSystem.PinObject<Vector4[]>
	*/

	// RVA: 0xC257A0 Offset: 0xC23DA0 VA: 0x180C257A0
	private static float GetHeight_Managed(Vector3 pos) { }

	// RVA: 0xC24D90 Offset: 0xC23390 VA: 0x180C24D90
	public static void GetHeightArray_Managed(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	// RVA: 0xC25DC0 Offset: 0xC243C0 VA: 0x180C25DC0
	public static float GetHeight(Vector3 pos) { }

	// RVA: 0xC25500 Offset: 0xC23B00 VA: 0x180C25500
	public static void GetHeightArray(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	// RVA: 0xC25FB0 Offset: 0xC245B0 VA: 0x180C25FB0
	public static Vector3 GetNormal(Vector3 pos) { }

	// RVA: 0xC264E0 Offset: 0xC24AE0 VA: 0x180C264E0
	public static void RegisterBody(WaterBody body) { }

	// RVA: 0xC27E70 Offset: 0xC26470 VA: 0x180C27E70
	public static void UnregisterBody(WaterBody body) { }

	// RVA: 0xC2AB60 Offset: 0xC29160 VA: 0x180C2AB60
	private void UpdateWaves() { }

	// RVA: 0xC29820 Offset: 0xC27E20 VA: 0x180C29820
	private static void UpdateOceanLevel() { }

	// RVA: 0xC2A460 Offset: 0xC28A60 VA: 0x180C2A460
	public void UpdateWaveData() { }

	// RVA: 0xC2AE20 Offset: 0xC29420 VA: 0x180C2AE20
	private void Update() { }

	// RVA: 0xC278B0 Offset: 0xC25EB0 VA: 0x180C278B0
	private static void ShutdownRuntimes() { }

	// RVA: 0xC246A0 Offset: 0xC22CA0 VA: 0x180C246A0
	public static void Clear() { }

	// RVA: 0xC26800 Offset: 0xC24E00 VA: 0x180C26800
	public static void RegisterCamera(WaterCamera camera) { }

	// RVA: 0xC27F30 Offset: 0xC26530 VA: 0x180C27F30
	public static void UnregisterCamera(WaterCamera camera) { }

	// RVA: 0xC26A10 Offset: 0xC25010 VA: 0x180C26A10
	public static void RegisterDepthMask(WaterDepthMask mask) { }

	// RVA: 0xC27FF0 Offset: 0xC265F0 VA: 0x180C27FF0
	public static void UnregisterDepthMask(WaterDepthMask mask) { }

	// RVA: 0xC24980 Offset: 0xC22F80 VA: 0x180C24980
	private void CreateReflectionProbe() { }

	// RVA: 0xC24C90 Offset: 0xC23290 VA: 0x180C24C90
	private void DestroyReflectionProbe() { }

	// RVA: 0xC24080 Offset: 0xC22680 VA: 0x180C24080
	private void CheckReflectionProbe() { }

	// RVA: 0xC24810 Offset: 0xC22E10 VA: 0x180C24810
	private void CreateDefaultHeightSlopeMap() { }

	// RVA: 0xC24BD0 Offset: 0xC231D0 VA: 0x180C24BD0
	private void DestroyDefaultHeightSlopeMap() { }

	// RVA: 0xC262A0 Offset: 0xC248A0 VA: 0x180C262A0
	private void OnEnable() { }

	// RVA: 0xC26120 Offset: 0xC24720 VA: 0x180C26120
	private void OnDisable() { }

	// RVA: 0xC280B0 Offset: 0xC266B0 VA: 0x180C280B0
	public void UpdateClient() { }

	// RVA: 0xC24B90 Offset: 0xC23190 VA: 0x180C24B90
	private void DestroyComputeBuffer(ref ComputeBuffer buffer) { }

	// RVA: 0xC2AA00 Offset: 0xC29000 VA: 0x180C2AA00
	private void UpdateWavesClient() { }

	// RVA: 0xC2A0A0 Offset: 0xC286A0 VA: 0x180C2A0A0
	private void UpdateRuntimes() { }

	// RVA: 0xC294A0 Offset: 0xC27AA0 VA: 0x180C294A0
	public void UpdateMaterial(Material material) { }

	// RVA: 0xC244F0 Offset: 0xC22AF0 VA: 0x180C244F0
	public void ClearUnderwaterScatterCoefficientOverride() { }

	// RVA: 0xC276F0 Offset: 0xC25CF0 VA: 0x180C276F0
	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	// RVA: 0xC29FF0 Offset: 0xC285F0 VA: 0x180C29FF0
	private void UpdateReflectionProbe() { }

	// RVA: 0xC26AD0 Offset: 0xC250D0 VA: 0x180C26AD0
	public void ResetVisibility() { }

	// RVA: 0xC27A50 Offset: 0xC26050 VA: 0x180C27A50
	public void ToggleVisibility(int mask) { }

	// RVA: 0xC285B0 Offset: 0xC26BB0 VA: 0x180C285B0
	private void UpdateGlobalShaderProperties() { }

	// RVA: 0xC29D00 Offset: 0xC28300 VA: 0x180C29D00
	private bool UpdateQuality() { }

	// RVA: 0xC24D60 Offset: 0xC23360 VA: 0x180C24D60
	private void DisableFallbackPlane() { }

	// RVA: 0xC29400 Offset: 0xC27A00 VA: 0x180C29400
	private void UpdateKeywords() { }

	// RVA: 0xC2B2B0 Offset: 0xC298B0 VA: 0x180C2B2B0
	public void .ctor() { }

	// RVA: 0xC2B050 Offset: 0xC29650 VA: 0x180C2B050
	private static void .cctor() { }

}

public class WaterSystem.SimulationSettings // TypeDefIndex: 10628
{	// Fields
	public Vector3 Wind; // 0x10
	public int SolverResolution; // 0x1C
	public float SolverSizeInWorld; // 0x20
	public float Gravity; // 0x24
	public float Amplitude; // 0x28
	public Texture2D PerlinNoise; // 0x30
	public WaterGerstner.WaveParams[] OpenSeaWaves; // 0x38
	public WaterGerstner.ShoreWaveParams ShoreWaves; // 0x40
	[RangeAttribute] // RVA: 0xECD00 Offset: 0xEC100 VA: 0x1800ECD00
	public float ShoreWavesFadeDistance; // 0x48
	[RangeAttribute] // RVA: 0xECD00 Offset: 0xEC100 VA: 0x1800ECD00
	public float TerrainFadeDistance; // 0x4C
	[RangeAttribute] // RVA: 0xECE60 Offset: 0xEC260 VA: 0x1800ECE60
	public float OpenSeaCrestFoamThreshold; // 0x50
	[RangeAttribute] // RVA: 0xECE60 Offset: 0xEC260 VA: 0x1800ECE60
	public float ShoreCrestFoamThreshold; // 0x54
	[RangeAttribute] // RVA: 0xECE60 Offset: 0xEC260 VA: 0x1800ECE60
	public float ShoreCrestFoamFarThreshold; // 0x58
	[RangeAttribute] // RVA: 0xECD00 Offset: 0xEC100 VA: 0x1800ECD00
	public float ShoreCrestFoamFadeDistance; // 0x5C

	// Methods

	// RVA: 0x8E9410 Offset: 0x8E7A10 VA: 0x1808E9410
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings // TypeDefIndex: 10629
{	// Fields
	public float MaxDisplacementDistance; // 0x10
	public WaterSystem.RenderingSettings.SkyProbe SkyReflections; // 0x18
	public WaterSystem.RenderingSettings.SSR ScreenSpaceReflections; // 0x20
	public WaterSystem.RenderingSettings.Caustics CausticsAnimation; // 0x28

	// Methods

	// RVA: 0xC0FE80 Offset: 0xC0E480 VA: 0x180C0FE80
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SkyProbe // TypeDefIndex: 10630
{	// Fields
	public float ProbeUpdateInterval; // 0x10
	public bool TimeSlicing; // 0x14

	// Methods

	// RVA: 0xC0FF60 Offset: 0xC0E560 VA: 0x180C0FF60
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SSR // TypeDefIndex: 10631
{	// Fields
	public float FresnelCutoff; // 0x10
	public float ThicknessMin; // 0x14
	public float ThicknessMax; // 0x18
	public float ThicknessStartDist; // 0x1C
	public float ThicknessEndDist; // 0x20

	// Methods

	// RVA: 0xC0FE90 Offset: 0xC0E490 VA: 0x180C0FE90
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.Caustics // TypeDefIndex: 10632
{	// Fields
	public float FrameRate; // 0x10
	public Texture2D[] FramesShallow; // 0x18
	public Texture2D[] FramesDeep; // 0x20

	// Methods

	// RVA: 0xC0F970 Offset: 0xC0DF70 VA: 0x180C0F970
	public void .ctor() { }

}

private enum WaterSystem.NativePathState // TypeDefIndex: 10633
{	// Fields
	public int value__; // 0x0
	public const WaterSystem.NativePathState Initializing = 0;
	public const WaterSystem.NativePathState Failed = 1;
	public const WaterSystem.NativePathState Ready = 2;

}

