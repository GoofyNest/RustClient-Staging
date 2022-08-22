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

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public WaterGerstner.PrecomputedWave[] get_PrecomputedWaves() { }

	// RVA: 0xC2C0A0 Offset: 0xC2A6A0 VA: 0x180C2C0A0
	public WaterGerstner.PrecomputedShoreWaves get_PrecomputedShoreWaves() { }

	// RVA: 0xC2BED0 Offset: 0xC2A4D0 VA: 0x180C2BED0
	public Vector4 get_Global0() { }

	// RVA: 0xC2BEE0 Offset: 0xC2A4E0 VA: 0x180C2BEE0
	public Vector4 get_Global1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC220 Offset: 0x6FA820 VA: 0x1806FC220
	public float get_ShoreWavesRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC610 Offset: 0x6FAC10 VA: 0x1806FC610
	private void set_ShoreWavesRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C180 Offset: 0xC2A780 VA: 0x180C2C180
	public float get_TerrainRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C620 Offset: 0xC2AC20 VA: 0x180C2C620
	private void set_TerrainRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C450 Offset: 0xC2AA50 VA: 0x180C2C450
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BF70 Offset: 0xC2A570 VA: 0x180C2BF70
	public bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BDB0 Offset: 0xC2A3B0 VA: 0x180C2BDB0
	public static WaterCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C310 Offset: 0xC2A910 VA: 0x180C2C310
	private static void set_Collision(WaterCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C3E0 Offset: 0xC2A9E0 VA: 0x180C2C3E0
	private static void set_Dynamics(WaterDynamics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BE70 Offset: 0xC2A470 VA: 0x180C2BE70
	public static WaterDynamics get_Dynamics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C540 Offset: 0xC2AB40 VA: 0x180C2C540
	private static void set_Ocean(WaterBody value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BFE0 Offset: 0xC2A5E0 VA: 0x180C2BFE0
	public static WaterBody get_Ocean() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C630 Offset: 0xC2AC30 VA: 0x180C2C630
	private static void set_WaterBodies(HashSet<WaterBody> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C190 Offset: 0xC2A790 VA: 0x180C2C190
	public static HashSet<WaterBody> get_WaterBodies() { }

	// RVA: 0xC2BF80 Offset: 0xC2A580 VA: 0x180C2BF80
	public static float get_OceanLevel() { }

	// RVA: 0xC2C460 Offset: 0xC2AA60 VA: 0x180C2C460
	public static void set_OceanLevel(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C250 Offset: 0xC2A850 VA: 0x180C2C250
	public static float get_WaveTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C6A0 Offset: 0xC2ACA0 VA: 0x180C2C6A0
	private static void set_WaveTime(float value) { }

	// RVA: 0xC2BEF0 Offset: 0xC2A4F0 VA: 0x180C2BEF0
	public bool get_HasCaustics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C5B0 Offset: 0xC2ABB0 VA: 0x180C2C5B0
	private static void set_Runtimes(Dictionary<WaterCamera, WaterRuntime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C0C0 Offset: 0xC2A6C0 VA: 0x180C2C0C0
	public static Dictionary<WaterCamera, WaterRuntime> get_Runtimes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C370 Offset: 0xC2A970 VA: 0x180C2C370
	private static void set_DepthMasks(HashSet<WaterDepthMask> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BE10 Offset: 0xC2A410 VA: 0x180C2BE10
	public static HashSet<WaterDepthMask> get_DepthMasks() { }

	// RVA: 0xC2BF10 Offset: 0xC2A510 VA: 0x180C2BF10
	public static WaterSystem get_Instance() { }

	// RVA: 0xC24420 Offset: 0xC22A20 VA: 0x180C24420
	private void CheckInstance() { }

	// RVA: 0xC243A0 Offset: 0xC229A0 VA: 0x180C243A0
	public void Awake() { }

	// RVA: 0xC272C0 Offset: 0xC258C0 VA: 0x180C272C0
	private static extern void SetBaseConstants_Native(int shoreMapSize, ref Vector3 shoreMap, int waterHeightMapSize, ref short waterHeightMap, Vector4 packedParams) { }

	// RVA: 0xC27DB0 Offset: 0xC263B0 VA: 0x180C27DB0
	private static extern void SetTerrainConstants_Native(int terrainHeightMapSize, ref short terrainHeightMap, Vector3 terrainPosition, Vector3 terrainSize) { }

	// RVA: 0xC27380 Offset: 0xC25980 VA: 0x180C27380
	private static extern void SetGerstnerConstants_Native(Vector4 globalParams0, Vector4 globalParams1, ref Vector4 openWaves, ref Vector4 shoreWaves) { }

	// RVA: 0xC29F30 Offset: 0xC28530 VA: 0x180C29F30
	private static extern void UpdateOceanLevel_Native(float oceanWaterLevel) { }

	// RVA: 0xC25BD0 Offset: 0xC241D0 VA: 0x180C25BD0
	private static extern float GetHeightArray_Native(int sampleCount, ref Vector2 pos, ref Vector2 posUV, ref Vector3 shore, ref float terrainHeight, ref float waterHeight) { }

	// RVA: 0xC264C0 Offset: 0xC24AC0 VA: 0x180C264C0
	private static extern float GetHeight_Native(Vector3 pos) { }

	// RVA: 0xC243B0 Offset: 0xC229B0 VA: 0x180C243B0
	private static extern bool CPU_SupportsSSE41() { }

	// RVA: 0xC27440 Offset: 0xC25A40 VA: 0x180C27440
	private static void SetNativeConstants(TerrainTexturing terrainTexturing, TerrainWaterMap terrainWaterMap, TerrainHeightMap terrainHeightMap, Vector4 globalParams0, Vector4 globalParams1, Vector4[] openWaves, Vector4[] shoreWaves) { }

	// RVA: -1 Offset: -1
	private static void PinObject<T>(T value, ref T currentValue, ref GCHandle currentValueHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA490 Offset: 0x5D8A90 VA: 0x1805DA490
	|-WaterSystem.PinObject<short[]>
	|-WaterSystem.PinObject<object>
	|-WaterSystem.PinObject<Vector3[]>
	|-WaterSystem.PinObject<Vector4[]>
	*/

	// RVA: 0xC25F30 Offset: 0xC24530 VA: 0x180C25F30
	private static float GetHeight_Managed(Vector3 pos) { }

	// RVA: 0xC25520 Offset: 0xC23B20 VA: 0x180C25520
	public static void GetHeightArray_Managed(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	// RVA: 0xC26550 Offset: 0xC24B50 VA: 0x180C26550
	public static float GetHeight(Vector3 pos) { }

	// RVA: 0xC25C90 Offset: 0xC24290 VA: 0x180C25C90
	public static void GetHeightArray(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	// RVA: 0xC26740 Offset: 0xC24D40 VA: 0x180C26740
	public static Vector3 GetNormal(Vector3 pos) { }

	// RVA: 0xC26C70 Offset: 0xC25270 VA: 0x180C26C70
	public static void RegisterBody(WaterBody body) { }

	// RVA: 0xC28600 Offset: 0xC26C00 VA: 0x180C28600
	public static void UnregisterBody(WaterBody body) { }

	// RVA: 0xC2B2F0 Offset: 0xC298F0 VA: 0x180C2B2F0
	private void UpdateWaves() { }

	// RVA: 0xC29FB0 Offset: 0xC285B0 VA: 0x180C29FB0
	private static void UpdateOceanLevel() { }

	// RVA: 0xC2ABF0 Offset: 0xC291F0 VA: 0x180C2ABF0
	public void UpdateWaveData() { }

	// RVA: 0xC2B5B0 Offset: 0xC29BB0 VA: 0x180C2B5B0
	private void Update() { }

	// RVA: 0xC28040 Offset: 0xC26640 VA: 0x180C28040
	private static void ShutdownRuntimes() { }

	// RVA: 0xC24E30 Offset: 0xC23430 VA: 0x180C24E30
	public static void Clear() { }

	// RVA: 0xC26F90 Offset: 0xC25590 VA: 0x180C26F90
	public static void RegisterCamera(WaterCamera camera) { }

	// RVA: 0xC286C0 Offset: 0xC26CC0 VA: 0x180C286C0
	public static void UnregisterCamera(WaterCamera camera) { }

	// RVA: 0xC271A0 Offset: 0xC257A0 VA: 0x180C271A0
	public static void RegisterDepthMask(WaterDepthMask mask) { }

	// RVA: 0xC28780 Offset: 0xC26D80 VA: 0x180C28780
	public static void UnregisterDepthMask(WaterDepthMask mask) { }

	// RVA: 0xC25110 Offset: 0xC23710 VA: 0x180C25110
	private void CreateReflectionProbe() { }

	// RVA: 0xC25420 Offset: 0xC23A20 VA: 0x180C25420
	private void DestroyReflectionProbe() { }

	// RVA: 0xC24810 Offset: 0xC22E10 VA: 0x180C24810
	private void CheckReflectionProbe() { }

	// RVA: 0xC24FA0 Offset: 0xC235A0 VA: 0x180C24FA0
	private void CreateDefaultHeightSlopeMap() { }

	// RVA: 0xC25360 Offset: 0xC23960 VA: 0x180C25360
	private void DestroyDefaultHeightSlopeMap() { }

	// RVA: 0xC26A30 Offset: 0xC25030 VA: 0x180C26A30
	private void OnEnable() { }

	// RVA: 0xC268B0 Offset: 0xC24EB0 VA: 0x180C268B0
	private void OnDisable() { }

	// RVA: 0xC28840 Offset: 0xC26E40 VA: 0x180C28840
	public void UpdateClient() { }

	// RVA: 0xC25320 Offset: 0xC23920 VA: 0x180C25320
	private void DestroyComputeBuffer(ref ComputeBuffer buffer) { }

	// RVA: 0xC2B190 Offset: 0xC29790 VA: 0x180C2B190
	private void UpdateWavesClient() { }

	// RVA: 0xC2A830 Offset: 0xC28E30 VA: 0x180C2A830
	private void UpdateRuntimes() { }

	// RVA: 0xC29C30 Offset: 0xC28230 VA: 0x180C29C30
	public void UpdateMaterial(Material material) { }

	// RVA: 0xC24C80 Offset: 0xC23280 VA: 0x180C24C80
	public void ClearUnderwaterScatterCoefficientOverride() { }

	// RVA: 0xC27E80 Offset: 0xC26480 VA: 0x180C27E80
	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	// RVA: 0xC2A780 Offset: 0xC28D80 VA: 0x180C2A780
	private void UpdateReflectionProbe() { }

	// RVA: 0xC27260 Offset: 0xC25860 VA: 0x180C27260
	public void ResetVisibility() { }

	// RVA: 0xC281E0 Offset: 0xC267E0 VA: 0x180C281E0
	public void ToggleVisibility(int mask) { }

	// RVA: 0xC28D40 Offset: 0xC27340 VA: 0x180C28D40
	private void UpdateGlobalShaderProperties() { }

	// RVA: 0xC2A490 Offset: 0xC28A90 VA: 0x180C2A490
	private bool UpdateQuality() { }

	// RVA: 0xC254F0 Offset: 0xC23AF0 VA: 0x180C254F0
	private void DisableFallbackPlane() { }

	// RVA: 0xC29B90 Offset: 0xC28190 VA: 0x180C29B90
	private void UpdateKeywords() { }

	// RVA: 0xC2BA40 Offset: 0xC2A040 VA: 0x180C2BA40
	public void .ctor() { }

	// RVA: 0xC2B7E0 Offset: 0xC29DE0 VA: 0x180C2B7E0
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

	// RVA: 0x8E9A30 Offset: 0x8E8030 VA: 0x1808E9A30
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings // TypeDefIndex: 10629
{	// Fields
	public float MaxDisplacementDistance; // 0x10
	public WaterSystem.RenderingSettings.SkyProbe SkyReflections; // 0x18
	public WaterSystem.RenderingSettings.SSR ScreenSpaceReflections; // 0x20
	public WaterSystem.RenderingSettings.Caustics CausticsAnimation; // 0x28

	// Methods

	// RVA: 0xC10610 Offset: 0xC0EC10 VA: 0x180C10610
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SkyProbe // TypeDefIndex: 10630
{	// Fields
	public float ProbeUpdateInterval; // 0x10
	public bool TimeSlicing; // 0x14

	// Methods

	// RVA: 0xC106F0 Offset: 0xC0ECF0 VA: 0x180C106F0
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

	// RVA: 0xC10620 Offset: 0xC0EC20 VA: 0x180C10620
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.Caustics // TypeDefIndex: 10632
{	// Fields
	public float FrameRate; // 0x10
	public Texture2D[] FramesShallow; // 0x18
	public Texture2D[] FramesDeep; // 0x20

	// Methods

	// RVA: 0xC10100 Offset: 0xC0E700 VA: 0x180C10100
	public void .ctor() { }

}

private enum WaterSystem.NativePathState // TypeDefIndex: 10633
{	// Fields
	public int value__; // 0x0
	public const WaterSystem.NativePathState Initializing = 0;
	public const WaterSystem.NativePathState Failed = 1;
	public const WaterSystem.NativePathState Ready = 2;

}

