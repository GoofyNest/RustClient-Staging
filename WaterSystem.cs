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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <ShoreWavesRcpFadeDistance>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <TerrainRcpFadeDistance>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsInitialized>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static WaterCollision <Collision>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static WaterDynamics <Dynamics>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static WaterBody <Ocean>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static HashSet<WaterBody> <WaterBodies>k__BackingField; // 0x18
	private static float oceanLevel; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static float <WaveTime>k__BackingField; // 0x24
	public static readonly int[] QualityToMaxVertices; // 0x28
	private WaterQuality prevQuality; // 0xA4
	private ReflectionProbeEx reflectionProbe; // 0xA8
	private float reflectionProbeUpdateTime; // 0xB0
	private bool reflectionProbeReady; // 0xB4
	private Texture2D defaultHeightSlopeMap; // 0xB8
	private bool hasValidCausticsAnims; // 0xC0
	private List<WaterRuntime> runtimeCleanup; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Dictionary<WaterCamera, WaterRuntime> <Runtimes>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0xC2BBD0 Offset: 0xC2A1D0 VA: 0x180C2BBD0
	public WaterGerstner.PrecomputedShoreWaves get_PrecomputedShoreWaves() { }

	// RVA: 0xC2BA00 Offset: 0xC2A000 VA: 0x180C2BA00
	public Vector4 get_Global0() { }

	// RVA: 0xC2BA10 Offset: 0xC2A010 VA: 0x180C2BA10
	public Vector4 get_Global1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC2D0 Offset: 0x6FA8D0 VA: 0x1806FC2D0
	public float get_ShoreWavesRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC6C0 Offset: 0x6FACC0 VA: 0x1806FC6C0
	private void set_ShoreWavesRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BCB0 Offset: 0xC2A2B0 VA: 0x180C2BCB0
	public float get_TerrainRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C150 Offset: 0xC2A750 VA: 0x180C2C150
	private void set_TerrainRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BF80 Offset: 0xC2A580 VA: 0x180C2BF80
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BAA0 Offset: 0xC2A0A0 VA: 0x180C2BAA0
	public bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2B8E0 Offset: 0xC29EE0 VA: 0x180C2B8E0
	public static WaterCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BE40 Offset: 0xC2A440 VA: 0x180C2BE40
	private static void set_Collision(WaterCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BF10 Offset: 0xC2A510 VA: 0x180C2BF10
	private static void set_Dynamics(WaterDynamics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2B9A0 Offset: 0xC29FA0 VA: 0x180C2B9A0
	public static WaterDynamics get_Dynamics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C070 Offset: 0xC2A670 VA: 0x180C2C070
	private static void set_Ocean(WaterBody value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BB10 Offset: 0xC2A110 VA: 0x180C2BB10
	public static WaterBody get_Ocean() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C160 Offset: 0xC2A760 VA: 0x180C2C160
	private static void set_WaterBodies(HashSet<WaterBody> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BCC0 Offset: 0xC2A2C0 VA: 0x180C2BCC0
	public static HashSet<WaterBody> get_WaterBodies() { }

	// RVA: 0xC2BAB0 Offset: 0xC2A0B0 VA: 0x180C2BAB0
	public static float get_OceanLevel() { }

	// RVA: 0xC2BF90 Offset: 0xC2A590 VA: 0x180C2BF90
	public static void set_OceanLevel(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BD80 Offset: 0xC2A380 VA: 0x180C2BD80
	public static float get_WaveTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C1D0 Offset: 0xC2A7D0 VA: 0x180C2C1D0
	private static void set_WaveTime(float value) { }

	// RVA: 0xC2BA20 Offset: 0xC2A020 VA: 0x180C2BA20
	public bool get_HasCaustics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C0E0 Offset: 0xC2A6E0 VA: 0x180C2C0E0
	private static void set_Runtimes(Dictionary<WaterCamera, WaterRuntime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BBF0 Offset: 0xC2A1F0 VA: 0x180C2BBF0
	public static Dictionary<WaterCamera, WaterRuntime> get_Runtimes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BEA0 Offset: 0xC2A4A0 VA: 0x180C2BEA0
	private static void set_DepthMasks(HashSet<WaterDepthMask> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2B940 Offset: 0xC29F40 VA: 0x180C2B940
	public static HashSet<WaterDepthMask> get_DepthMasks() { }

	// RVA: 0xC2BA40 Offset: 0xC2A040 VA: 0x180C2BA40
	public static WaterSystem get_Instance() { }

	// RVA: 0xC23F50 Offset: 0xC22550 VA: 0x180C23F50
	private void CheckInstance() { }

	// RVA: 0xC23ED0 Offset: 0xC224D0 VA: 0x180C23ED0
	public void Awake() { }

	// RVA: 0xC26DF0 Offset: 0xC253F0 VA: 0x180C26DF0
	private static extern void SetBaseConstants_Native(int shoreMapSize, ref Vector3 shoreMap, int waterHeightMapSize, ref short waterHeightMap, Vector4 packedParams) { }

	// RVA: 0xC278E0 Offset: 0xC25EE0 VA: 0x180C278E0
	private static extern void SetTerrainConstants_Native(int terrainHeightMapSize, ref short terrainHeightMap, Vector3 terrainPosition, Vector3 terrainSize) { }

	// RVA: 0xC26EB0 Offset: 0xC254B0 VA: 0x180C26EB0
	private static extern void SetGerstnerConstants_Native(Vector4 globalParams0, Vector4 globalParams1, ref Vector4 openWaves, ref Vector4 shoreWaves) { }

	// RVA: 0xC29A60 Offset: 0xC28060 VA: 0x180C29A60
	private static extern void UpdateOceanLevel_Native(float oceanWaterLevel) { }

	// RVA: 0xC25700 Offset: 0xC23D00 VA: 0x180C25700
	private static extern float GetHeightArray_Native(int sampleCount, ref Vector2 pos, ref Vector2 posUV, ref Vector3 shore, ref float terrainHeight, ref float waterHeight) { }

	// RVA: 0xC25FF0 Offset: 0xC245F0 VA: 0x180C25FF0
	private static extern float GetHeight_Native(Vector3 pos) { }

	// RVA: 0xC23EE0 Offset: 0xC224E0 VA: 0x180C23EE0
	private static extern bool CPU_SupportsSSE41() { }

	// RVA: 0xC26F70 Offset: 0xC25570 VA: 0x180C26F70
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

	// RVA: 0xC25A60 Offset: 0xC24060 VA: 0x180C25A60
	private static float GetHeight_Managed(Vector3 pos) { }

	// RVA: 0xC25050 Offset: 0xC23650 VA: 0x180C25050
	public static void GetHeightArray_Managed(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	// RVA: 0xC26080 Offset: 0xC24680 VA: 0x180C26080
	public static float GetHeight(Vector3 pos) { }

	// RVA: 0xC257C0 Offset: 0xC23DC0 VA: 0x180C257C0
	public static void GetHeightArray(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	// RVA: 0xC26270 Offset: 0xC24870 VA: 0x180C26270
	public static Vector3 GetNormal(Vector3 pos) { }

	// RVA: 0xC267A0 Offset: 0xC24DA0 VA: 0x180C267A0
	public static void RegisterBody(WaterBody body) { }

	// RVA: 0xC28130 Offset: 0xC26730 VA: 0x180C28130
	public static void UnregisterBody(WaterBody body) { }

	// RVA: 0xC2AE20 Offset: 0xC29420 VA: 0x180C2AE20
	private void UpdateWaves() { }

	// RVA: 0xC29AE0 Offset: 0xC280E0 VA: 0x180C29AE0
	private static void UpdateOceanLevel() { }

	// RVA: 0xC2A720 Offset: 0xC28D20 VA: 0x180C2A720
	public void UpdateWaveData() { }

	// RVA: 0xC2B0E0 Offset: 0xC296E0 VA: 0x180C2B0E0
	private void Update() { }

	// RVA: 0xC27B70 Offset: 0xC26170 VA: 0x180C27B70
	private static void ShutdownRuntimes() { }

	// RVA: 0xC24960 Offset: 0xC22F60 VA: 0x180C24960
	public static void Clear() { }

	// RVA: 0xC26AC0 Offset: 0xC250C0 VA: 0x180C26AC0
	public static void RegisterCamera(WaterCamera camera) { }

	// RVA: 0xC281F0 Offset: 0xC267F0 VA: 0x180C281F0
	public static void UnregisterCamera(WaterCamera camera) { }

	// RVA: 0xC26CD0 Offset: 0xC252D0 VA: 0x180C26CD0
	public static void RegisterDepthMask(WaterDepthMask mask) { }

	// RVA: 0xC282B0 Offset: 0xC268B0 VA: 0x180C282B0
	public static void UnregisterDepthMask(WaterDepthMask mask) { }

	// RVA: 0xC24C40 Offset: 0xC23240 VA: 0x180C24C40
	private void CreateReflectionProbe() { }

	// RVA: 0xC24F50 Offset: 0xC23550 VA: 0x180C24F50
	private void DestroyReflectionProbe() { }

	// RVA: 0xC24340 Offset: 0xC22940 VA: 0x180C24340
	private void CheckReflectionProbe() { }

	// RVA: 0xC24AD0 Offset: 0xC230D0 VA: 0x180C24AD0
	private void CreateDefaultHeightSlopeMap() { }

	// RVA: 0xC24E90 Offset: 0xC23490 VA: 0x180C24E90
	private void DestroyDefaultHeightSlopeMap() { }

	// RVA: 0xC26560 Offset: 0xC24B60 VA: 0x180C26560
	private void OnEnable() { }

	// RVA: 0xC263E0 Offset: 0xC249E0 VA: 0x180C263E0
	private void OnDisable() { }

	// RVA: 0xC28370 Offset: 0xC26970 VA: 0x180C28370
	public void UpdateClient() { }

	// RVA: 0xC24E50 Offset: 0xC23450 VA: 0x180C24E50
	private void DestroyComputeBuffer(ref ComputeBuffer buffer) { }

	// RVA: 0xC2ACC0 Offset: 0xC292C0 VA: 0x180C2ACC0
	private void UpdateWavesClient() { }

	// RVA: 0xC2A360 Offset: 0xC28960 VA: 0x180C2A360
	private void UpdateRuntimes() { }

	// RVA: 0xC29760 Offset: 0xC27D60 VA: 0x180C29760
	public void UpdateMaterial(Material material) { }

	// RVA: 0xC247B0 Offset: 0xC22DB0 VA: 0x180C247B0
	public void ClearUnderwaterScatterCoefficientOverride() { }

	// RVA: 0xC279B0 Offset: 0xC25FB0 VA: 0x180C279B0
	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	// RVA: 0xC2A2B0 Offset: 0xC288B0 VA: 0x180C2A2B0
	private void UpdateReflectionProbe() { }

	// RVA: 0xC26D90 Offset: 0xC25390 VA: 0x180C26D90
	public void ResetVisibility() { }

	// RVA: 0xC27D10 Offset: 0xC26310 VA: 0x180C27D10
	public void ToggleVisibility(int mask) { }

	// RVA: 0xC28870 Offset: 0xC26E70 VA: 0x180C28870
	private void UpdateGlobalShaderProperties() { }

	// RVA: 0xC29FC0 Offset: 0xC285C0 VA: 0x180C29FC0
	private bool UpdateQuality() { }

	// RVA: 0xC25020 Offset: 0xC23620 VA: 0x180C25020
	private void DisableFallbackPlane() { }

	// RVA: 0xC296C0 Offset: 0xC27CC0 VA: 0x180C296C0
	private void UpdateKeywords() { }

	// RVA: 0xC2B570 Offset: 0xC29B70 VA: 0x180C2B570
	public void .ctor() { }

	// RVA: 0xC2B310 Offset: 0xC29910 VA: 0x180C2B310
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
	[RangeAttribute] // RVA: 0xECE20 Offset: 0xEC220 VA: 0x1800ECE20
	public float ShoreWavesFadeDistance; // 0x48
	[RangeAttribute] // RVA: 0xECE20 Offset: 0xEC220 VA: 0x1800ECE20
	public float TerrainFadeDistance; // 0x4C
	[RangeAttribute] // RVA: 0xECEE0 Offset: 0xEC2E0 VA: 0x1800ECEE0
	public float OpenSeaCrestFoamThreshold; // 0x50
	[RangeAttribute] // RVA: 0xECEE0 Offset: 0xEC2E0 VA: 0x1800ECEE0
	public float ShoreCrestFoamThreshold; // 0x54
	[RangeAttribute] // RVA: 0xECEE0 Offset: 0xEC2E0 VA: 0x1800ECEE0
	public float ShoreCrestFoamFarThreshold; // 0x58
	[RangeAttribute] // RVA: 0xECE20 Offset: 0xEC220 VA: 0x1800ECE20
	public float ShoreCrestFoamFadeDistance; // 0x5C

	// Methods

	// RVA: 0x8E9520 Offset: 0x8E7B20 VA: 0x1808E9520
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings // TypeDefIndex: 10629
{	// Fields
	public float MaxDisplacementDistance; // 0x10
	public WaterSystem.RenderingSettings.SkyProbe SkyReflections; // 0x18
	public WaterSystem.RenderingSettings.SSR ScreenSpaceReflections; // 0x20
	public WaterSystem.RenderingSettings.Caustics CausticsAnimation; // 0x28

	// Methods

	// RVA: 0xC10140 Offset: 0xC0E740 VA: 0x180C10140
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SkyProbe // TypeDefIndex: 10630
{	// Fields
	public float ProbeUpdateInterval; // 0x10
	public bool TimeSlicing; // 0x14

	// Methods

	// RVA: 0xC10220 Offset: 0xC0E820 VA: 0x180C10220
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

	// RVA: 0xC10150 Offset: 0xC0E750 VA: 0x180C10150
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.Caustics // TypeDefIndex: 10632
{	// Fields
	public float FrameRate; // 0x10
	public Texture2D[] FramesShallow; // 0x18
	public Texture2D[] FramesDeep; // 0x20

	// Methods

	// RVA: 0xC0FC30 Offset: 0xC0E230 VA: 0x180C0FC30
	public void .ctor() { }

}

private enum WaterSystem.NativePathState // TypeDefIndex: 10633
{	// Fields
	public int value__; // 0x0
	public const WaterSystem.NativePathState Initializing = 0;
	public const WaterSystem.NativePathState Failed = 1;
	public const WaterSystem.NativePathState Ready = 2;

}

