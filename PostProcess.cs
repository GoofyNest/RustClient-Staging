public class PostProcessVolumeLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 10277
{	// Fields
	public float distance; // 0x18
	private LODCell cell; // 0x20
	private PostProcessVolume postProcessVolume; // 0x28
	private LODEnvironmentMode environmentMode; // 0x30

	// Methods

	// RVA: 0x99C110 Offset: 0x99A710 VA: 0x18099C110
	private void Awake() { }

	// RVA: 0x99C330 Offset: 0x99A930 VA: 0x18099C330
	private void OnEnable() { }

	// RVA: 0x99C280 Offset: 0x99A880 VA: 0x18099C280
	private void OnDisable() { }

	// RVA: 0x99C200 Offset: 0x99A800 VA: 0x18099C200
	private float GetDistance() { }

	// RVA: 0x99C160 Offset: 0x99A760 VA: 0x18099C160 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x99C3D0 Offset: 0x99A9D0 VA: 0x18099C3D0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class PostProcessLayer : MonoBehaviour // TypeDefIndex: 11738
{	// Fields
	private const float updateRate = 0,1;
	private RenderTexture colorBuffer; // 0x18
	private RenderTexture depthBuffer; // 0x20
	private RenderTexture motionBuffer; // 0x28
	private RenderTexture colorOutput; // 0x30
	private Camera renderingCamera; // 0x38
	private Material renderScaleMaterial; // 0x40
	private HashSet<Shader> mipmapShaders; // 0x48
	private Nullable<PostProcessLayer.ScalingMode> scalingMode; // 0x50
	private float prevRenderScale; // 0x58
	private NVSDK_NGX_PerfQuality_Value prevPerfQuality; // 0x5C
	private uint prevScreenWidth; // 0x60
	private uint prevScreenHeight; // 0x64
	private float prevUpdateTime; // 0x68
	private bool screenshotMode; // 0x6C
	private bool firstDLSSPass; // 0x6D
	private DlSSRecommendedSettings dlssRecommendedSettings; // 0x70
	private GCHandle dlssDataHandle; // 0x8C
	private CommandBuffer afterEverythingCommandBuffer; // 0x90
	public Transform volumeTrigger; // 0x98
	public LayerMask volumeLayer; // 0xA0
	public bool stopNaNPropagation; // 0xA4
	public bool finalBlitToCameraTarget; // 0xA5
	public PostProcessLayer.Antialiasing antialiasingMode; // 0xA8
	public TemporalAntialiasing temporalAntialiasing; // 0xB0
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; // 0xB8
	public FastApproximateAntialiasing fastApproximateAntialiasing; // 0xC0
	public Fog fog; // 0xC8
	private Dithering dithering; // 0xD0
	public PostProcessDebugLayer debugLayer; // 0xD8
	public RenderTextureFormat intermediateFormat; // 0xE0
	private RenderTextureFormat prevIntermediateFormat; // 0xE4
	private bool supportsIntermediateFormat; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PostProcessResources m_Resources; // 0xF0
	[PreserveAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private bool m_ShowToolkit; // 0xF8
	[PreserveAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private bool m_ShowCustomSorter; // 0xF9
	public bool breakBeforeColorGrading; // 0xFA
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeTransparentBundles; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeStackBundles; // 0x108
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<PostProcessLayer.SerializedBundleRef> m_AfterStackBundles; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> <sortedBundles>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <haveBundlesBeenInited>k__BackingField; // 0x120
	private Dictionary<Type, PostProcessBundle> m_Bundles; // 0x128
	private PropertySheetFactory m_PropertySheetFactory; // 0x130
	private CommandBuffer m_LegacyCmdBufferBeforeReflections; // 0x138
	private CommandBuffer m_LegacyCmdBufferBeforeLighting; // 0x140
	private CommandBuffer m_LegacyCmdBufferOpaque; // 0x148
	private CommandBuffer m_LegacyCmdBuffer; // 0x150
	private Camera m_Camera; // 0x158
	private PostProcessRenderContext m_CurrentContext; // 0x160
	private LogHistogram m_LogHistogram; // 0x168
	private bool m_SettingsUpdateNeeded; // 0x170
	private bool m_IsRenderingInSceneView; // 0x171
	private TargetPool m_TargetPool; // 0x178
	private bool m_NaNKilled; // 0x180
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects; // 0x188
	private readonly List<RenderTargetIdentifier> m_Targets; // 0x190

	// Properties
	public bool ScreenshotMode { get; set; }
	public uint ScreenWidth { get; }
	public uint ScreenHeight { get; }
	public uint ScaledScreenWidth { get; }
	public uint ScaledScreenHeight { get; }
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> sortedBundles { get; set; }
	public bool haveBundlesBeenInited { get; set; }

	// Methods

	// RVA: 0x102A4B0 Offset: 0x1028AB0 VA: 0x18102A4B0
	public bool get_ScreenshotMode() { }

	// RVA: 0x102A4D0 Offset: 0x1028AD0 VA: 0x18102A4D0
	public void set_ScreenshotMode(bool value) { }

	// RVA: 0x102A450 Offset: 0x1028A50 VA: 0x18102A450
	public uint get_ScreenWidth() { }

	// RVA: 0x102A3F0 Offset: 0x10289F0 VA: 0x18102A3F0
	public uint get_ScreenHeight() { }

	// RVA: 0x102A330 Offset: 0x1028930 VA: 0x18102A330
	public uint get_ScaledScreenWidth() { }

	// RVA: 0x102A270 Offset: 0x1028870 VA: 0x18102A270
	public uint get_ScaledScreenHeight() { }

	// RVA: 0x1024930 Offset: 0x1022F30 VA: 0x181024930
	private void OnEnableRenderScale() { }

	// RVA: 0x1024230 Offset: 0x1022830 VA: 0x181024230
	private void OnDisableRenderScale() { }

	// RVA: 0x1029B10 Offset: 0x1028110 VA: 0x181029B10
	private void Update() { }

	// RVA: 0x1023420 Offset: 0x1021A20 VA: 0x181023420
	private PostProcessLayer.ScalingMode GetDesiredScalingMode(NVSDK_NGX_PerfQuality_Value dlssMode) { }

	// RVA: 0x1023F20 Offset: 0x1022520 VA: 0x181023F20
	private bool NeedsRebuild(PostProcessLayer.ScalingMode desiredScalingMode, NVSDK_NGX_PerfQuality_Value dlssMode) { }

	// RVA: 0x10287B0 Offset: 0x1026DB0 VA: 0x1810287B0
	public void SetMipMapBias(float bias) { }

	// RVA: 0x1023130 Offset: 0x1021730 VA: 0x181023130
	private float CalculateMipMapBias() { }

	// RVA: 0x1022270 Offset: 0x1020870 VA: 0x181022270
	private void BuildPostEffectsNew(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	// RVA: 0x1025CA0 Offset: 0x10242A0 VA: 0x181025CA0
	private void RebuildRenderTargets() { }

	// RVA: 0x10232B0 Offset: 0x10218B0 VA: 0x1810232B0
	private void FreeRenderTargets() { }

	// RVA: 0x1025B40 Offset: 0x1024140 VA: 0x181025B40
	private void RebuildColorOutput() { }

	// RVA: 0x1023230 Offset: 0x1021830 VA: 0x181023230
	private void FreeRenderColorOutput() { }

	// RVA: 0x1028F90 Offset: 0x1027590 VA: 0x181028F90
	private bool StartDLSS() { }

	// RVA: 0x10295D0 Offset: 0x1027BD0 VA: 0x1810295D0
	private bool UpdateDLSSQualitySettings(NVSDK_NGX_PerfQuality_Value perfQuality) { }

	// RVA: 0x1029040 Offset: 0x1027640 VA: 0x181029040
	private void StopDLSS() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE66340 Offset: 0xE64940 VA: 0x180E66340
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> get_sortedBundles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE65A00 Offset: 0xE64000 VA: 0x180E65A00
	private void set_sortedBundles(Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x102A4C0 Offset: 0x1028AC0 VA: 0x18102A4C0
	public bool get_haveBundlesBeenInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x102A4E0 Offset: 0x1028AE0 VA: 0x18102A4E0
	private void set_haveBundlesBeenInited(bool value) { }

	// RVA: 0x1025080 Offset: 0x1023680 VA: 0x181025080
	private void OnEnable() { }

	// RVA: 0x1023BC0 Offset: 0x10221C0 VA: 0x181023BC0
	private void InitLegacy() { }

	[ImageEffectUsesCommandBuffer] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1025860 Offset: 0x1023E60 VA: 0x181025860
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x1023E10 Offset: 0x1022410 VA: 0x181023E10
	public void Init(PostProcessResources resources) { }

	// RVA: 0x1023780 Offset: 0x1021D80 VA: 0x181023780
	public void InitBundles() { }

	// RVA: 0x1029080 Offset: 0x1027680 VA: 0x181029080
	private void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	// RVA: 0x10243B0 Offset: 0x10229B0 VA: 0x1810243B0
	private void OnDisable() { }

	// RVA: 0x1028500 Offset: 0x1026B00 VA: 0x181028500
	private void Reset() { }

	// RVA: 0x10254C0 Offset: 0x1023AC0 VA: 0x1810254C0
	private void OnPreCull() { }

	// RVA: 0x10257E0 Offset: 0x1023DE0 VA: 0x1810257E0
	private void OnPreRender() { }

	// RVA: 0x10234F0 Offset: 0x1021AF0 VA: 0x1810234F0
	private RenderTextureFormat GetIntermediateFormat() { }

	// RVA: 0x1028330 Offset: 0x1026930 VA: 0x181028330
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	// RVA: 0x10298A0 Offset: 0x1027EA0 VA: 0x1810298A0
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	// RVA: 0x1021800 Offset: 0x101FE00 VA: 0x181021800
	private void BuildCommandBuffers() { }

	// RVA: 0x1022CC0 Offset: 0x10212C0 VA: 0x181022CC0
	private void BuildPostEffectsOld(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	// RVA: 0x10252A0 Offset: 0x10238A0 VA: 0x1810252A0
	private void OnPostRender() { }

	// RVA: -1 Offset: -1
	public PostProcessBundle GetBundle<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B6C0 Offset: 0x1A39CC0 VA: 0x181A3B6C0
	|-PostProcessLayer.GetBundle<object>
	|-PostProcessLayer.GetBundle<AmbientOcclusion>
	|-PostProcessLayer.GetBundle<AutoExposure>
	|-PostProcessLayer.GetBundle<ScreenSpaceReflections>
	*/

	// RVA: 0x1023370 Offset: 0x1021970 VA: 0x181023370
	public PostProcessBundle GetBundle(Type settingsType) { }

	// RVA: -1 Offset: -1
	public T GetSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA520 Offset: 0x15B8B20 VA: 0x1815BA520
	|-PostProcessLayer.GetSettings<object>
	*/

	// RVA: 0x10216B0 Offset: 0x101FCB0 VA: 0x1810216B0
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = False) { }

	// RVA: 0x10258F0 Offset: 0x1023EF0 VA: 0x1810258F0
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	// RVA: 0x1028530 Offset: 0x1026B30 VA: 0x181028530
	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	// RVA: 0x10283B0 Offset: 0x10269B0 VA: 0x1810283B0
	public void ResetHistory() { }

	// RVA: 0x1023770 Offset: 0x1021D70 VA: 0x181023770
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	// RVA: 0x1023540 Offset: 0x1021B40 VA: 0x181023540
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	// RVA: 0x1028D60 Offset: 0x1027360 VA: 0x181028D60
	private void SetupContext(PostProcessRenderContext context) { }

	// RVA: 0x10299E0 Offset: 0x1027FE0 VA: 0x1810299E0
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

	// RVA: 0x10276C0 Offset: 0x1025CC0 VA: 0x1810276C0
	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	// RVA: 0x10277A0 Offset: 0x1025DA0 VA: 0x1810277A0
	public void Render(PostProcessRenderContext context) { }

	// RVA: 0x1026FE0 Offset: 0x10255E0 VA: 0x181026FE0
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	// RVA: 0x10271A0 Offset: 0x10257A0 VA: 0x1810271A0
	private void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	// RVA: 0x1021590 Offset: 0x101FB90 VA: 0x181021590
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	// RVA: 0x10214B0 Offset: 0x101FAB0 VA: 0x1810214B0
	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	// RVA: 0x1025F40 Offset: 0x1024540 VA: 0x181025F40
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: 0x1026760 Offset: 0x1024D60 VA: 0x181026760
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: -1 Offset: -1
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6FC0 Offset: 0xED55C0 VA: 0x180ED6FC0
	|-PostProcessLayer.RenderEffect<DepthOfFieldEffect>
	|-PostProcessLayer.RenderEffect<object>
	|-PostProcessLayer.RenderEffect<AutoExposure>
	|-PostProcessLayer.RenderEffect<Bloom>
	|-PostProcessLayer.RenderEffect<ChromaticAberration>
	|-PostProcessLayer.RenderEffect<ColorGrading>
	|-PostProcessLayer.RenderEffect<Grain>
	|-PostProcessLayer.RenderEffect<LensDistortion>
	|-PostProcessLayer.RenderEffect<MotionBlur>
	|-PostProcessLayer.RenderEffect<Vignette>
	*/

	// RVA: 0x1028EF0 Offset: 0x10274F0 VA: 0x181028EF0
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	// RVA: 0x102A1A0 Offset: 0x10287A0 VA: 0x18102A1A0
	public void .ctor() { }

}

private enum PostProcessLayer.ScalingMode // TypeDefIndex: 11739
{	// Fields
	public int value__; // 0x0
	public const PostProcessLayer.ScalingMode NATIVE = 0;
	public const PostProcessLayer.ScalingMode BILINEAR = 1;
	public const PostProcessLayer.ScalingMode DLSS = 2;

}

public enum PostProcessLayer.Antialiasing // TypeDefIndex: 11740
{	// Fields
	public int value__; // 0x0
	public const PostProcessLayer.Antialiasing None = 0;
	public const PostProcessLayer.Antialiasing FastApproximateAntialiasing = 1;
	public const PostProcessLayer.Antialiasing SubpixelMorphologicalAntialiasing = 2;
	public const PostProcessLayer.Antialiasing TemporalAntialiasing = 3;

}

public sealed class PostProcessLayer.SerializedBundleRef // TypeDefIndex: 11741
{	// Fields
	public string assemblyQualifiedName; // 0x10
	public PostProcessBundle bundle; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class PostProcessLayer.<>c // TypeDefIndex: 11742
{	// Fields
	public static readonly PostProcessLayer.<>c <>9; // 0x0
	public static Predicate<Shader> <>9__31_0; // 0x8
	public static Predicate<Shader> <>9__31_1; // 0x10
	public static Predicate<Shader> <>9__31_2; // 0x18
	public static Predicate<Shader> <>9__31_3; // 0x20
	public static Predicate<Shader> <>9__31_4; // 0x28
	public static Predicate<Shader> <>9__31_5; // 0x30
	public static Predicate<Shader> <>9__31_6; // 0x38
	public static Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle> <>9__97_1; // 0x40

	// Methods

	// RVA: 0x102D540 Offset: 0x102BB40 VA: 0x18102D540
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102CE20 Offset: 0x102B420 VA: 0x18102CE20
	internal bool <OnEnableRenderScale>b__31_0(Shader x) { }

	// RVA: 0x102CE90 Offset: 0x102B490 VA: 0x18102CE90
	internal bool <OnEnableRenderScale>b__31_1(Shader x) { }

	// RVA: 0x102CF00 Offset: 0x102B500 VA: 0x18102CF00
	internal bool <OnEnableRenderScale>b__31_2(Shader x) { }

	// RVA: 0x102CF70 Offset: 0x102B570 VA: 0x18102CF70
	internal bool <OnEnableRenderScale>b__31_3(Shader x) { }

	// RVA: 0x102CFE0 Offset: 0x102B5E0 VA: 0x18102CFE0
	internal bool <OnEnableRenderScale>b__31_4(Shader x) { }

	// RVA: 0x102D050 Offset: 0x102B650 VA: 0x18102D050
	internal bool <OnEnableRenderScale>b__31_5(Shader x) { }

	// RVA: 0x102D0C0 Offset: 0x102B6C0 VA: 0x18102D0C0
	internal bool <OnEnableRenderScale>b__31_6(Shader x) { }

	// RVA: 0x102D300 Offset: 0x102B900 VA: 0x18102D300
	internal PostProcessBundle <UpdateBundleSortList>b__97_1(KeyValuePair<Type, PostProcessBundle> kvp) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_0 // TypeDefIndex: 11743
{	// Fields
	public PostProcessEvent evt; // 0x10
	public List<PostProcessBundle> effects; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D340 Offset: 0x102B940 VA: 0x18102D340
	internal bool <UpdateBundleSortList>b__0(KeyValuePair<Type, PostProcessBundle> kvp) { }

	// RVA: 0x102D3B0 Offset: 0x102B9B0 VA: 0x18102D3B0
	internal bool <UpdateBundleSortList>b__2(PostProcessLayer.SerializedBundleRef x) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_1 // TypeDefIndex: 11744
{	// Fields
	public string searchStr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D480 Offset: 0x102BA80 VA: 0x18102D480
	internal bool <UpdateBundleSortList>b__3(PostProcessBundle b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_2 // TypeDefIndex: 11745
{	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C300 Offset: 0x98A900 VA: 0x18098C300
	internal bool <UpdateBundleSortList>b__4(PostProcessLayer.SerializedBundleRef b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_3 // TypeDefIndex: 11746
{	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D480 Offset: 0x102BA80 VA: 0x18102D480
	internal bool <UpdateBundleSortList>b__5(PostProcessBundle b) { }

}

public class PostProcessRenderContext // TypeDefIndex: 11747
{	// Fields
	public bool dlssEnabled; // 0x10
	private Camera m_Camera; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CommandBuffer <command>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RenderTargetIdentifier <source>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RenderTargetIdentifier <destination>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RenderTextureFormat <sourceFormat>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <flip>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PostProcessResources <resources>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertySheetFactory <propertySheets>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Dictionary<string, object> <userData>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PostProcessDebugLayer <debugLayer>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <width>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <height>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <stereoActive>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <xrActiveEye>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <numberOfEyes>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PostProcessRenderContext.StereoRenderingMode <stereoRenderingMode>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <screenWidth>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <screenHeight>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <isSceneView>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PostProcessLayer.Antialiasing <antialiasing>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TemporalAntialiasing <temporalAntialiasing>k__BackingField; // 0xC8
	internal PropertySheet uberSheet; // 0xD0
	internal Texture autoExposureTexture; // 0xD8
	internal LogHistogram logHistogram; // 0xE0
	internal Texture logLut; // 0xE8
	internal AutoExposure autoExposure; // 0xF0
	internal int bloomBufferNameID; // 0xF8
	internal bool physicalCamera; // 0xFC
	private RenderTextureDescriptor m_sourceDescriptor; // 0x100

	// Properties
	public Camera camera { get; set; }
	public CommandBuffer command { get; set; }
	public RenderTargetIdentifier source { get; set; }
	public RenderTargetIdentifier destination { get; set; }
	public RenderTextureFormat sourceFormat { get; set; }
	public bool flip { get; set; }
	public PostProcessResources resources { get; set; }
	public PropertySheetFactory propertySheets { get; set; }
	public Dictionary<string, object> userData { get; set; }
	public PostProcessDebugLayer debugLayer { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public bool stereoActive { get; set; }
	public int xrActiveEye { get; set; }
	public int numberOfEyes { get; set; }
	public PostProcessRenderContext.StereoRenderingMode stereoRenderingMode { get; set; }
	public int screenWidth { get; set; }
	public int screenHeight { get; set; }
	public bool isSceneView { get; set; }
	public PostProcessLayer.Antialiasing antialiasing { get; set; }
	public TemporalAntialiasing temporalAntialiasing { get; set; }

	// Methods

	// RVA: 0x11D5ED0 Offset: 0x11D44D0 VA: 0x1811D5ED0
	public void Resize(int width, int height, bool dlssEnabled) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Camera get_camera() { }

	// RVA: 0x11D5F40 Offset: 0x11D4540 VA: 0x1811D5F40
	public void set_camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public CommandBuffer get_command() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_command(CommandBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D5F20 Offset: 0x11D4520 VA: 0x1811D5F20
	public RenderTargetIdentifier get_source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D6000 Offset: 0x11D4600 VA: 0x1811D6000
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D5F00 Offset: 0x11D4500 VA: 0x1811D5F00
	public RenderTargetIdentifier get_destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D5FE0 Offset: 0x11D45E0 VA: 0x1811D5FE0
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAF5D60 Offset: 0xAF4360 VA: 0x180AF5D60
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB28CD0 Offset: 0xB272D0 VA: 0x180B28CD0
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9660F0 Offset: 0x9646F0 VA: 0x1809660F0
	public bool get_flip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x966100 Offset: 0x964700 VA: 0x180966100
	public void set_flip(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public PostProcessResources get_resources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_resources(PostProcessResources value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public Dictionary<string, object> get_userData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	private void set_userData(Dictionary<string, object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1051760 Offset: 0x104FD60 VA: 0x181051760
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F80 Offset: 0x1078580 VA: 0x181079F80
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1051770 Offset: 0x104FD70 VA: 0x181051770
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F90 Offset: 0x1078590 VA: 0x181079F90
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8084F0 Offset: 0x806AF0 VA: 0x1808084F0
	public bool get_stereoActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808500 Offset: 0x806B00 VA: 0x180808500
	private void set_stereoActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D020 Offset: 0xA4B620 VA: 0x180A4D020
	public int get_xrActiveEye() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A040 Offset: 0x1078640 VA: 0x18107A040
	private void set_xrActiveEye(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public int get_numberOfEyes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_numberOfEyes(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E30 Offset: 0x1078430 VA: 0x181079E30
	public PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FA0 Offset: 0x10785A0 VA: 0x181079FA0
	private void set_stereoRenderingMode(PostProcessRenderContext.StereoRenderingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E60 Offset: 0x1078460 VA: 0x181079E60
	public int get_screenWidth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FD0 Offset: 0x10785D0 VA: 0x181079FD0
	public void set_screenWidth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E50 Offset: 0x1078450 VA: 0x181079E50
	public int get_screenHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FC0 Offset: 0x10785C0 VA: 0x181079FC0
	public void set_screenHeight(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	public bool get_isSceneView() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	internal void set_isSceneView(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE2A20 Offset: 0xAE1020 VA: 0x180AE2A20
	public PostProcessLayer.Antialiasing get_antialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F70 Offset: 0x1078570 VA: 0x181079F70
	internal void set_antialiasing(PostProcessLayer.Antialiasing value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA04C0 Offset: 0xD9EAC0 VA: 0x180DA04C0
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	// RVA: 0x11D5CA0 Offset: 0x11D42A0 VA: 0x1811D5CA0
	public void Reset() { }

	// RVA: 0x11D5BE0 Offset: 0x11D41E0 VA: 0x1811D5BE0
	public bool IsTemporalAntialiasingActive() { }

	// RVA: 0x11D5BB0 Offset: 0x11D41B0 VA: 0x1811D5BB0
	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	// RVA: 0x11D5C40 Offset: 0x11D4240 VA: 0x1811D5C40
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x11D58A0 Offset: 0x11D3EA0 VA: 0x1811D58A0
	private RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	// RVA: 0x11D5A10 Offset: 0x11D4010 VA: 0x1811D5A10
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x11D5B20 Offset: 0x11D4120 VA: 0x1811D5B20
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum PostProcessRenderContext.StereoRenderingMode // TypeDefIndex: 11748
{	// Fields
	public int value__; // 0x0
	public const PostProcessRenderContext.StereoRenderingMode MultiPass = 0;
	public const PostProcessRenderContext.StereoRenderingMode SinglePass = 1;
	public const PostProcessRenderContext.StereoRenderingMode SinglePassInstanced = 2;
	public const PostProcessRenderContext.StereoRenderingMode SinglePassMultiview = 3;

}

public sealed class PostProcessAttribute : Attribute // TypeDefIndex: 11753
{	// Fields
	public readonly Type renderer; // 0x10
	public readonly PostProcessEvent eventType; // 0x18
	public readonly string menuItem; // 0x20
	public readonly bool allowInSceneView; // 0x28
	internal readonly bool builtinEffect; // 0x29

	// Methods

	// RVA: 0x101EBD0 Offset: 0x101D1D0 VA: 0x18101EBD0
	public void .ctor(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = True) { }

	// RVA: 0x101EC40 Offset: 0x101D240 VA: 0x18101EC40
	internal void .ctor(Type renderer, string menuItem, bool allowInSceneView = True) { }

}

public sealed class PostProcessBundle // TypeDefIndex: 11836
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PostProcessAttribute <attribute>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PostProcessEffectSettings <settings>k__BackingField; // 0x18
	private PostProcessEffectRenderer m_Renderer; // 0x20

	// Properties
	public PostProcessAttribute attribute { get; set; }
	public PostProcessEffectSettings settings { get; set; }
	internal PostProcessEffectRenderer renderer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public PostProcessAttribute get_attribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_attribute(PostProcessAttribute value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public PostProcessEffectSettings get_settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_settings(PostProcessEffectSettings value) { }

	// RVA: 0x101EE10 Offset: 0x101D410 VA: 0x18101EE10
	internal PostProcessEffectRenderer get_renderer() { }

	// RVA: 0x101ED40 Offset: 0x101D340 VA: 0x18101ED40
	internal void .ctor(PostProcessEffectSettings settings) { }

	// RVA: 0x101ECB0 Offset: 0x101D2B0 VA: 0x18101ECB0
	internal void Release() { }

	// RVA: 0x101ED20 Offset: 0x101D320 VA: 0x18101ED20
	internal void ResetHistory() { }

	// RVA: -1 Offset: -1
	internal T CastSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA4B0 Offset: 0x15B8AB0 VA: 0x1815BA4B0
	|-PostProcessBundle.CastSettings<object>
	|-PostProcessBundle.CastSettings<AmbientOcclusion>
	*/

	// RVA: -1 Offset: -1
	internal T CastRenderer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA440 Offset: 0x15B8A40 VA: 0x1815BA440
	|-PostProcessBundle.CastRenderer<object>
	|-PostProcessBundle.CastRenderer<AmbientOcclusionRenderer>
	*/

}

public sealed class PostProcessDebug : MonoBehaviour // TypeDefIndex: 11837
{	// Fields
	public PostProcessLayer postProcessLayer; // 0x18
	private PostProcessLayer m_PreviousPostProcessLayer; // 0x20
	public bool lightMeter; // 0x28
	public bool histogram; // 0x29
	public bool waveform; // 0x2A
	public bool vectorscope; // 0x2B
	public DebugOverlay debugOverlay; // 0x2C
	private Camera m_CurrentCamera; // 0x30
	private CommandBuffer m_CmdAfterEverything; // 0x38

	// Methods

	// RVA: 0x1020480 Offset: 0x101EA80 VA: 0x181020480
	private void OnEnable() { }

	// RVA: 0x10203D0 Offset: 0x101E9D0 VA: 0x1810203D0
	private void OnDisable() { }

	// RVA: 0x1020A60 Offset: 0x101F060 VA: 0x181020A60
	private void Update() { }

	// RVA: 0x1020780 Offset: 0x101ED80 VA: 0x181020780
	private void Reset() { }

	// RVA: 0x10207D0 Offset: 0x101EDD0 VA: 0x1810207D0
	private void UpdateStates() { }

	// RVA: 0x1020660 Offset: 0x101EC60 VA: 0x181020660
	private void OnPostRender() { }

	// RVA: 0x1020500 Offset: 0x101EB00 VA: 0x181020500
	private void OnGUI() { }

	// RVA: 0x1020250 Offset: 0x101E850 VA: 0x181020250
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public sealed class PostProcessDebugLayer // TypeDefIndex: 11840
{	// Fields
	public LightMeterMonitor lightMeter; // 0x10
	public HistogramMonitor histogram; // 0x18
	public WaveformMonitor waveform; // 0x20
	public VectorscopeMonitor vectorscope; // 0x28
	private Dictionary<MonitorType, Monitor> m_Monitors; // 0x30
	private int frameWidth; // 0x38
	private int frameHeight; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RenderTexture <debugOverlayTarget>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <debugOverlayActive>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DebugOverlay <debugOverlay>k__BackingField; // 0x4C
	public PostProcessDebugLayer.OverlaySettings overlaySettings; // 0x50

	// Properties
	public RenderTexture debugOverlayTarget { get; set; }
	public bool debugOverlayActive { get; set; }
	public DebugOverlay debugOverlay { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public RenderTexture get_debugOverlayTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	private void set_debugOverlayTarget(RenderTexture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_debugOverlayActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	private void set_debugOverlayActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	public DebugOverlay get_debugOverlay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	private void set_debugOverlay(DebugOverlay value) { }

	// RVA: 0x101F320 Offset: 0x101D920 VA: 0x18101F320
	internal void OnEnable() { }

	// RVA: 0x101F190 Offset: 0x101D790 VA: 0x18101F190
	internal void OnDisable() { }

	// RVA: 0x101EF50 Offset: 0x101D550 VA: 0x18101EF50
	private void DestroyDebugOverlayTarget() { }

	// RVA: 0x10201E0 Offset: 0x101E7E0 VA: 0x1810201E0
	public void RequestMonitorPass(MonitorType monitor) { }

	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	public void RequestDebugOverlay(DebugOverlay mode) { }

	// RVA: 0x1020240 Offset: 0x101E840 VA: 0x181020240
	internal void SetFrameSize(int width, int height) { }

	// RVA: 0x101F570 Offset: 0x101DB70 VA: 0x18101F570
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x101F160 Offset: 0x101D760 VA: 0x18101F160
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x101F840 Offset: 0x101DE40 VA: 0x18101F840
	internal void RenderMonitors(PostProcessRenderContext context) { }

	// RVA: 0x101FCB0 Offset: 0x101E2B0 VA: 0x18101FCB0
	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	// RVA: 0x101EFD0 Offset: 0x101D5D0 VA: 0x18101EFD0
	internal void EndFrame() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class PostProcessDebugLayer.OverlaySettings // TypeDefIndex: 11841
{	// Fields
	public bool linearDepth; // 0x10
	[RangeAttribute] // RVA: 0x7B740 Offset: 0x7AB40 VA: 0x18007B740
	public float motionColorIntensity; // 0x14
	[RangeAttribute] // RVA: 0x7B840 Offset: 0x7AC40 VA: 0x18007B840
	public int motionGridSize; // 0x18
	public ColorBlindnessType colorBlindnessType; // 0x1C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float colorBlindnessStrength; // 0x20

	// Methods

	// RVA: 0x101EBB0 Offset: 0x101D1B0 VA: 0x18101EBB0
	public void .ctor() { }

}

public abstract class PostProcessEffectRenderer // TypeDefIndex: 11842
{	// Fields
	protected bool m_ResetHistory; // 0x10

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void Init() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public virtual DepthTextureMode GetCameraFlags() { }

	// RVA: 0x1020A70 Offset: 0x101F070 VA: 0x181020A70 Slot: 6
	public virtual void ResetHistory() { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920 Slot: 7
	public virtual void Release() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Render(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	protected void .ctor() { }

}

public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer // TypeDefIndex: 11843
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T <settings>k__BackingField; // 0x0

	// Properties
	public T settings { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public T get_settings() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-PostProcessEffectRenderer<BlurOptimized>.get_settings
	|-PostProcessEffectRenderer<DepthOfFieldEffect>.get_settings
	|-PostProcessEffectRenderer<DoubleVision>.get_settings
	|-PostProcessEffectRenderer<FlashbangEffect>.get_settings
	|-PostProcessEffectRenderer<Frost>.get_settings
	|-PostProcessEffectRenderer<GodRays>.get_settings
	|-PostProcessEffectRenderer<GreyScale>.get_settings
	|-PostProcessEffectRenderer<LensDirtinessEffect>.get_settings
	|-PostProcessEffectRenderer<PhotoFilter>.get_settings
	|-PostProcessEffectRenderer<ScreenOverlay>.get_settings
	|-PostProcessEffectRenderer<SharpenAndVignette>.get_settings
	|-PostProcessEffectRenderer<object>.get_settings
	|-PostProcessEffectRenderer<AmbientOcclusion>.get_settings
	|-PostProcessEffectRenderer<AutoExposure>.get_settings
	|-PostProcessEffectRenderer<Bloom>.get_settings
	|-PostProcessEffectRenderer<ChromaticAberration>.get_settings
	|-PostProcessEffectRenderer<ColorGrading>.get_settings
	|-PostProcessEffectRenderer<DepthOfField>.get_settings
	|-PostProcessEffectRenderer<Grain>.get_settings
	|-PostProcessEffectRenderer<LensDistortion>.get_settings
	|-PostProcessEffectRenderer<MotionBlur>.get_settings
	|-PostProcessEffectRenderer<ScreenSpaceReflections>.get_settings
	|-PostProcessEffectRenderer<Vignette>.get_settings
	|-PostProcessEffectRenderer<Wiggle>.get_settings
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void set_settings(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	|-PostProcessEffectRenderer<object>.set_settings
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal override void SetSettings(PostProcessEffectSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C5870 Offset: 0x19C3E70 VA: 0x1819C5870
	|-PostProcessEffectRenderer<BlurOptimized>.SetSettings
	|-PostProcessEffectRenderer<DepthOfFieldEffect>.SetSettings
	|-PostProcessEffectRenderer<DoubleVision>.SetSettings
	|-PostProcessEffectRenderer<FlashbangEffect>.SetSettings
	|-PostProcessEffectRenderer<Frost>.SetSettings
	|-PostProcessEffectRenderer<GodRays>.SetSettings
	|-PostProcessEffectRenderer<GreyScale>.SetSettings
	|-PostProcessEffectRenderer<LensDirtinessEffect>.SetSettings
	|-PostProcessEffectRenderer<PhotoFilter>.SetSettings
	|-PostProcessEffectRenderer<ScreenOverlay>.SetSettings
	|-PostProcessEffectRenderer<SharpenAndVignette>.SetSettings
	|-PostProcessEffectRenderer<object>.SetSettings
	|-PostProcessEffectRenderer<AmbientOcclusion>.SetSettings
	|-PostProcessEffectRenderer<AutoExposure>.SetSettings
	|-PostProcessEffectRenderer<Bloom>.SetSettings
	|-PostProcessEffectRenderer<ChromaticAberration>.SetSettings
	|-PostProcessEffectRenderer<ColorGrading>.SetSettings
	|-PostProcessEffectRenderer<DepthOfField>.SetSettings
	|-PostProcessEffectRenderer<Grain>.SetSettings
	|-PostProcessEffectRenderer<LensDistortion>.SetSettings
	|-PostProcessEffectRenderer<MotionBlur>.SetSettings
	|-PostProcessEffectRenderer<ScreenSpaceReflections>.SetSettings
	|-PostProcessEffectRenderer<Vignette>.SetSettings
	|-PostProcessEffectRenderer<Wiggle>.SetSettings
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C5910 Offset: 0x19C3F10 VA: 0x1819C5910
	|-PostProcessEffectRenderer<BlurOptimized>..ctor
	|-PostProcessEffectRenderer<DepthOfFieldEffect>..ctor
	|-PostProcessEffectRenderer<DoubleVision>..ctor
	|-PostProcessEffectRenderer<FlashbangEffect>..ctor
	|-PostProcessEffectRenderer<Frost>..ctor
	|-PostProcessEffectRenderer<GodRays>..ctor
	|-PostProcessEffectRenderer<GreyScale>..ctor
	|-PostProcessEffectRenderer<LensDirtinessEffect>..ctor
	|-PostProcessEffectRenderer<PhotoFilter>..ctor
	|-PostProcessEffectRenderer<ScreenOverlay>..ctor
	|-PostProcessEffectRenderer<SharpenAndVignette>..ctor
	|-PostProcessEffectRenderer<object>..ctor
	|-PostProcessEffectRenderer<AmbientOcclusion>..ctor
	|-PostProcessEffectRenderer<AutoExposure>..ctor
	|-PostProcessEffectRenderer<Bloom>..ctor
	|-PostProcessEffectRenderer<ChromaticAberration>..ctor
	|-PostProcessEffectRenderer<ColorGrading>..ctor
	|-PostProcessEffectRenderer<DepthOfField>..ctor
	|-PostProcessEffectRenderer<Grain>..ctor
	|-PostProcessEffectRenderer<LensDistortion>..ctor
	|-PostProcessEffectRenderer<MotionBlur>..ctor
	|-PostProcessEffectRenderer<ScreenSpaceReflections>..ctor
	|-PostProcessEffectRenderer<Vignette>..ctor
	|-PostProcessEffectRenderer<Wiggle>..ctor
	*/

}

public class PostProcessEffectSettings : ScriptableObject // TypeDefIndex: 11844
{	// Fields
	public bool active; // 0x18
	public BoolParameter enabled; // 0x20
	internal ReadOnlyCollection<ParameterOverride> parameters; // 0x28

	// Methods

	// RVA: 0x1020E00 Offset: 0x101F400 VA: 0x181020E00
	private void OnEnable() { }

	// RVA: 0x1020C70 Offset: 0x101F270 VA: 0x181020C70
	private void OnDisable() { }

	// RVA: 0x10211D0 Offset: 0x101F7D0 VA: 0x1810211D0
	public void SetAllOverridesTo(bool state, bool excludeEnabled = True) { }

	// RVA: 0x1020C50 Offset: 0x101F250 VA: 0x181020C50 Slot: 4
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x1020A90 Offset: 0x101F090 VA: 0x181020A90
	public int GetHash() { }

	// RVA: 0x1021430 Offset: 0x101FA30 VA: 0x181021430
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1021380 Offset: 0x101F980 VA: 0x181021380
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }

}

private sealed class PostProcessEffectSettings.<>c // TypeDefIndex: 11845
{	// Fields
	public static readonly PostProcessEffectSettings.<>c <>9; // 0x0
	public static Func<FieldInfo, bool> <>9__3_0; // 0x8
	public static Func<FieldInfo, int> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x102D4E0 Offset: 0x102BAE0 VA: 0x18102D4E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D130 Offset: 0x102B730 VA: 0x18102D130
	internal bool <OnEnable>b__3_0(FieldInfo t) { }

	// RVA: 0x102D1D0 Offset: 0x102B7D0 VA: 0x18102D1D0
	internal int <OnEnable>b__3_1(FieldInfo t) { }

}

public enum PostProcessEvent // TypeDefIndex: 11846
{	// Fields
	public int value__; // 0x0
	public const PostProcessEvent BeforeTransparent = 0;
	public const PostProcessEvent BeforeStack = 1;
	public const PostProcessEvent AfterStack = 2;

}

internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent> // TypeDefIndex: 11847
{	// Methods

	// RVA: 0x16B510 Offset: 0x16A910 VA: 0x18016B510 Slot: 4
	public bool Equals(PostProcessEvent x, PostProcessEvent y) { }

	// RVA: 0x16B520 Offset: 0x16A920 VA: 0x18016B520 Slot: 5
	public int GetHashCode(PostProcessEvent obj) { }

}

public sealed class PostProcessManager // TypeDefIndex: 11848
{	// Fields
	private static PostProcessManager s_Instance; // 0x0
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes; // 0x10
	private readonly List<PostProcessVolume> m_Volumes; // 0x18
	private readonly Dictionary<int, bool> m_SortNeeded; // 0x20
	private readonly List<PostProcessEffectSettings> m_BaseSettings; // 0x28
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes; // 0x30

	// Properties
	public static PostProcessManager instance { get; }

	// Methods

	// RVA: 0x102C580 Offset: 0x102AB80 VA: 0x18102C580
	public static PostProcessManager get_instance() { }

	// RVA: 0x102C450 Offset: 0x102AA50 VA: 0x18102C450
	private void .ctor() { }

	// RVA: 0x102A4F0 Offset: 0x1028AF0 VA: 0x18102A4F0
	private void CleanBaseTypes() { }

	// RVA: 0x102B430 Offset: 0x1029A30 VA: 0x18102B430
	private void ReloadBaseTypes() { }

	// RVA: 0x102A650 Offset: 0x1028C50 VA: 0x18102A650
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = True, bool skipZeroWeight = True) { }

	// RVA: 0x102AC50 Offset: 0x1029250 VA: 0x18102AC50
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	// RVA: 0x102AAB0 Offset: 0x10290B0 VA: 0x18102AAB0
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	// RVA: 0x102B0E0 Offset: 0x10296E0 VA: 0x18102B0E0
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	// RVA: 0x102BA20 Offset: 0x102A020 VA: 0x18102BA20
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x102C390 Offset: 0x102A990 VA: 0x18102C390
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

	// RVA: 0x102B250 Offset: 0x1029850 VA: 0x18102B250
	private void Register(PostProcessVolume volume, int layer) { }

	// RVA: 0x102B3E0 Offset: 0x10299E0 VA: 0x18102B3E0
	internal void Register(PostProcessVolume volume) { }

	// RVA: 0x102BD50 Offset: 0x102A350 VA: 0x18102BD50
	private void Unregister(PostProcessVolume volume, int layer) { }

	// RVA: 0x102BD00 Offset: 0x102A300 VA: 0x18102BD00
	internal void Unregister(PostProcessVolume volume) { }

	// RVA: 0x102B800 Offset: 0x1029E00 VA: 0x18102B800
	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	// RVA: 0x102BEB0 Offset: 0x102A4B0 VA: 0x18102BEB0
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	// RVA: 0x102AD10 Offset: 0x1029310 VA: 0x18102AD10
	private List<PostProcessVolume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x102BBB0 Offset: 0x102A1B0 VA: 0x18102BBB0
	private static void SortByPriority(List<PostProcessVolume> volumes) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }

}

private sealed class PostProcessManager.<>c // TypeDefIndex: 11849
{	// Fields
	public static readonly PostProcessManager.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x102D5A0 Offset: 0x102BBA0 VA: 0x18102D5A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D200 Offset: 0x102B800 VA: 0x18102D200
	internal bool <ReloadBaseTypes>b__11_0(Type t) { }

}

public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 11850
{	// Fields
	[TooltipAttribute] // RVA: 0x7BFB0 Offset: 0x7B3B0 VA: 0x18007BFB0
	public List<PostProcessEffectSettings> settings; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x102CAB0 Offset: 0x102B0B0 VA: 0x18102CAB0
	private void OnEnable() { }

	// RVA: -1 Offset: -1
	public T AddSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA560 Offset: 0x15B8B60 VA: 0x1815BA560
	|-PostProcessProfile.AddSettings<object>
	*/

	// RVA: 0x102C720 Offset: 0x102AD20 VA: 0x18102C720
	public PostProcessEffectSettings AddSettings(Type type) { }

	// RVA: 0x102C870 Offset: 0x102AE70 VA: 0x18102C870
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) { }

	// RVA: -1 Offset: -1
	public void RemoveSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3A20 Offset: 0x5D2020 VA: 0x1805D3A20
	|-PostProcessProfile.RemoveSettings<object>
	*/

	// RVA: 0x102CBB0 Offset: 0x102B1B0 VA: 0x18102CBB0
	public void RemoveSettings(Type type) { }

	// RVA: -1 Offset: -1
	public bool HasSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2A60 Offset: 0xBF1060 VA: 0x180BF2A60
	|-PostProcessProfile.HasSettings<object>
	*/

	// RVA: 0x102C920 Offset: 0x102AF20 VA: 0x18102C920
	public bool HasSettings(Type type) { }

	// RVA: -1 Offset: -1
	public T GetSetting<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA630 Offset: 0x15B8C30 VA: 0x1815BA630
	|-PostProcessProfile.GetSetting<BlurOptimized>
	|-PostProcessProfile.GetSetting<DepthOfFieldEffect>
	|-PostProcessProfile.GetSetting<FlashbangEffect>
	|-PostProcessProfile.GetSetting<GodRays>
	|-PostProcessProfile.GetSetting<SharpenAndVignette>
	|-PostProcessProfile.GetSetting<object>
	|-PostProcessProfile.GetSetting<ChromaticAberration>
	|-PostProcessProfile.GetSetting<ColorGrading>
	|-PostProcessProfile.GetSetting<MotionBlur>
	|-PostProcessProfile.GetSetting<Wiggle>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetSettings<T>(out T outSetting) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2AE0 Offset: 0xBF10E0 VA: 0x180BF2AE0
	|-PostProcessProfile.TryGetSettings<object>
	*/

	// RVA: 0x102CD00 Offset: 0x102B300 VA: 0x18102CD00
	public void .ctor() { }

}

private sealed class PostProcessProfile.<>c // TypeDefIndex: 11851
{	// Fields
	public static readonly PostProcessProfile.<>c <>9; // 0x0
	public static Predicate<PostProcessEffectSettings> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x11E7850 Offset: 0x11E5E50 VA: 0x1811E7850
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11E77C0 Offset: 0x11E5DC0 VA: 0x1811E77C0
	internal bool <OnEnable>b__2_0(PostProcessEffectSettings x) { }

}

public sealed class PostProcessResources : ScriptableObject // TypeDefIndex: 11852
{	// Fields
	public Texture2D[] blueNoise64; // 0x18
	public Texture2D[] blueNoise256; // 0x20
	public PostProcessResources.SMAALuts smaaLuts; // 0x28
	public PostProcessResources.Shaders shaders; // 0x30
	public PostProcessResources.ComputeShaders computeShaders; // 0x38

	// Methods

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public sealed class PostProcessResources.Shaders // TypeDefIndex: 11853
{	// Fields
	public Shader bloom; // 0x10
	public Shader copy; // 0x18
	public Shader copyStd; // 0x20
	public Shader copyStdFromTexArray; // 0x28
	public Shader copyStdFromDoubleWide; // 0x30
	public Shader discardAlpha; // 0x38
	public Shader depthOfField; // 0x40
	public Shader finalPass; // 0x48
	public Shader grainBaker; // 0x50
	public Shader motionBlur; // 0x58
	public Shader temporalAntialiasing; // 0x60
	public Shader subpixelMorphologicalAntialiasing; // 0x68
	public Shader texture2dLerp; // 0x70
	public Shader uber; // 0x78
	public Shader lut2DBaker; // 0x80
	public Shader lightMeter; // 0x88
	public Shader gammaHistogram; // 0x90
	public Shader waveform; // 0x98
	public Shader vectorscope; // 0xA0
	public Shader debugOverlays; // 0xA8
	public Shader deferredFog; // 0xB0
	public Shader scalableAO; // 0xB8
	public Shader multiScaleAO; // 0xC0
	public Shader screenSpaceReflections; // 0xC8

	// Methods

	// RVA: 0x11DFE10 Offset: 0x11DE410 VA: 0x1811DFE10
	public PostProcessResources.Shaders Clone() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public sealed class PostProcessResources.ComputeShaders // TypeDefIndex: 11854
{	// Fields
	public ComputeShader autoExposure; // 0x10
	public ComputeShader exposureHistogram; // 0x18
	public ComputeShader lut3DBaker; // 0x20
	public ComputeShader texture3dLerp; // 0x28
	public ComputeShader gammaHistogram; // 0x30
	public ComputeShader waveform; // 0x38
	public ComputeShader vectorscope; // 0x40
	public ComputeShader multiScaleAODownsample1; // 0x48
	public ComputeShader multiScaleAODownsample2; // 0x50
	public ComputeShader multiScaleAORender; // 0x58
	public ComputeShader multiScaleAOUpsample; // 0x60
	public ComputeShader gaussianDownsample; // 0x68

	// Methods

	// RVA: 0x11D53C0 Offset: 0x11D39C0 VA: 0x1811D53C0
	public PostProcessResources.ComputeShaders Clone() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public sealed class PostProcessResources.SMAALuts // TypeDefIndex: 11855
{	// Fields
	public Texture2D area; // 0x10
	public Texture2D search; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public sealed class PostProcessVolume : MonoBehaviour // TypeDefIndex: 11856
{	// Fields
	public PostProcessProfile sharedProfile; // 0x18
	[TooltipAttribute] // RVA: 0x7C390 Offset: 0x7B790 VA: 0x18007C390
	public bool isGlobal; // 0x20
	public Bounds bounds; // 0x24
	[MinAttribute] // RVA: 0x7C430 Offset: 0x7B830 VA: 0x18007C430
	[TooltipAttribute] // RVA: 0x7C430 Offset: 0x7B830 VA: 0x18007C430
	public float blendDistance; // 0x3C
	[RangeAttribute] // RVA: 0x7C620 Offset: 0x7BA20 VA: 0x18007C620
	[TooltipAttribute] // RVA: 0x7C620 Offset: 0x7BA20 VA: 0x18007C620
	public float weight; // 0x40
	[TooltipAttribute] // RVA: 0x7C7A0 Offset: 0x7BBA0 VA: 0x18007C7A0
	public float priority; // 0x44
	private int m_PreviousLayer; // 0x48
	private float m_PreviousPriority; // 0x4C
	private PostProcessProfile m_InternalProfile; // 0x50

	// Properties
	public PostProcessProfile profile { get; set; }
	internal PostProcessProfile profileRef { get; }

	// Methods

	// RVA: 0x11D65E0 Offset: 0x11D4BE0 VA: 0x1811D65E0
	public PostProcessProfile get_profile() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_profile(PostProcessProfile value) { }

	// RVA: 0x11D6560 Offset: 0x11D4B60 VA: 0x1811D6560
	internal PostProcessProfile get_profileRef() { }

	// RVA: 0x11D6020 Offset: 0x11D4620 VA: 0x1811D6020
	public bool HasInstantiatedProfile() { }

	// RVA: 0x11D6470 Offset: 0x11D4A70 VA: 0x1811D6470
	private void OnEnable() { }

	// RVA: 0x11D6080 Offset: 0x11D4680 VA: 0x1811D6080
	private void OnDisable() { }

	// RVA: 0x11D64C0 Offset: 0x11D4AC0 VA: 0x1811D64C0
	private void Update() { }

	// RVA: 0x11D60B0 Offset: 0x11D46B0 VA: 0x1811D60B0
	private void OnDrawGizmos() { }

	// RVA: 0xA0BCB0 Offset: 0xA0A2B0 VA: 0x180A0BCB0
	public void .ctor() { }

}

