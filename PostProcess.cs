public class PostProcessVolumeLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 10277
{	// Fields
	public float distance; // 0x18
	private LODCell cell; // 0x20
	private PostProcessVolume postProcessVolume; // 0x28
	private LODEnvironmentMode environmentMode; // 0x30

	// Methods

	// RVA: 0x99C220 Offset: 0x99A820 VA: 0x18099C220
	private void Awake() { }

	// RVA: 0x99C440 Offset: 0x99AA40 VA: 0x18099C440
	private void OnEnable() { }

	// RVA: 0x99C390 Offset: 0x99A990 VA: 0x18099C390
	private void OnDisable() { }

	// RVA: 0x99C310 Offset: 0x99A910 VA: 0x18099C310
	private float GetDistance() { }

	// RVA: 0x99C270 Offset: 0x99A870 VA: 0x18099C270 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x99C4E0 Offset: 0x99AAE0 VA: 0x18099C4E0 Slot: 5
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

	// RVA: 0x102A770 Offset: 0x1028D70 VA: 0x18102A770
	public bool get_ScreenshotMode() { }

	// RVA: 0x102A790 Offset: 0x1028D90 VA: 0x18102A790
	public void set_ScreenshotMode(bool value) { }

	// RVA: 0x102A710 Offset: 0x1028D10 VA: 0x18102A710
	public uint get_ScreenWidth() { }

	// RVA: 0x102A6B0 Offset: 0x1028CB0 VA: 0x18102A6B0
	public uint get_ScreenHeight() { }

	// RVA: 0x102A5F0 Offset: 0x1028BF0 VA: 0x18102A5F0
	public uint get_ScaledScreenWidth() { }

	// RVA: 0x102A530 Offset: 0x1028B30 VA: 0x18102A530
	public uint get_ScaledScreenHeight() { }

	// RVA: 0x1024BF0 Offset: 0x10231F0 VA: 0x181024BF0
	private void OnEnableRenderScale() { }

	// RVA: 0x10244F0 Offset: 0x1022AF0 VA: 0x1810244F0
	private void OnDisableRenderScale() { }

	// RVA: 0x1029DD0 Offset: 0x10283D0 VA: 0x181029DD0
	private void Update() { }

	// RVA: 0x10236E0 Offset: 0x1021CE0 VA: 0x1810236E0
	private PostProcessLayer.ScalingMode GetDesiredScalingMode(NVSDK_NGX_PerfQuality_Value dlssMode) { }

	// RVA: 0x10241E0 Offset: 0x10227E0 VA: 0x1810241E0
	private bool NeedsRebuild(PostProcessLayer.ScalingMode desiredScalingMode, NVSDK_NGX_PerfQuality_Value dlssMode) { }

	// RVA: 0x1028A70 Offset: 0x1027070 VA: 0x181028A70
	public void SetMipMapBias(float bias) { }

	// RVA: 0x10233F0 Offset: 0x10219F0 VA: 0x1810233F0
	private float CalculateMipMapBias() { }

	// RVA: 0x1022530 Offset: 0x1020B30 VA: 0x181022530
	private void BuildPostEffectsNew(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	// RVA: 0x1025F60 Offset: 0x1024560 VA: 0x181025F60
	private void RebuildRenderTargets() { }

	// RVA: 0x1023570 Offset: 0x1021B70 VA: 0x181023570
	private void FreeRenderTargets() { }

	// RVA: 0x1025E00 Offset: 0x1024400 VA: 0x181025E00
	private void RebuildColorOutput() { }

	// RVA: 0x10234F0 Offset: 0x1021AF0 VA: 0x1810234F0
	private void FreeRenderColorOutput() { }

	// RVA: 0x1029250 Offset: 0x1027850 VA: 0x181029250
	private bool StartDLSS() { }

	// RVA: 0x1029890 Offset: 0x1027E90 VA: 0x181029890
	private bool UpdateDLSSQualitySettings(NVSDK_NGX_PerfQuality_Value perfQuality) { }

	// RVA: 0x1029300 Offset: 0x1027900 VA: 0x181029300
	private void StopDLSS() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE66600 Offset: 0xE64C00 VA: 0x180E66600
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> get_sortedBundles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE65CC0 Offset: 0xE642C0 VA: 0x180E65CC0
	private void set_sortedBundles(Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x102A780 Offset: 0x1028D80 VA: 0x18102A780
	public bool get_haveBundlesBeenInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x102A7A0 Offset: 0x1028DA0 VA: 0x18102A7A0
	private void set_haveBundlesBeenInited(bool value) { }

	// RVA: 0x1025340 Offset: 0x1023940 VA: 0x181025340
	private void OnEnable() { }

	// RVA: 0x1023E80 Offset: 0x1022480 VA: 0x181023E80
	private void InitLegacy() { }

	[ImageEffectUsesCommandBuffer] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1025B20 Offset: 0x1024120 VA: 0x181025B20
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x10240D0 Offset: 0x10226D0 VA: 0x1810240D0
	public void Init(PostProcessResources resources) { }

	// RVA: 0x1023A40 Offset: 0x1022040 VA: 0x181023A40
	public void InitBundles() { }

	// RVA: 0x1029340 Offset: 0x1027940 VA: 0x181029340
	private void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	// RVA: 0x1024670 Offset: 0x1022C70 VA: 0x181024670
	private void OnDisable() { }

	// RVA: 0x10287C0 Offset: 0x1026DC0 VA: 0x1810287C0
	private void Reset() { }

	// RVA: 0x1025780 Offset: 0x1023D80 VA: 0x181025780
	private void OnPreCull() { }

	// RVA: 0x1025AA0 Offset: 0x10240A0 VA: 0x181025AA0
	private void OnPreRender() { }

	// RVA: 0x10237B0 Offset: 0x1021DB0 VA: 0x1810237B0
	private RenderTextureFormat GetIntermediateFormat() { }

	// RVA: 0x10285F0 Offset: 0x1026BF0 VA: 0x1810285F0
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	// RVA: 0x1029B60 Offset: 0x1028160 VA: 0x181029B60
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	// RVA: 0x1021AC0 Offset: 0x10200C0 VA: 0x181021AC0
	private void BuildCommandBuffers() { }

	// RVA: 0x1022F80 Offset: 0x1021580 VA: 0x181022F80
	private void BuildPostEffectsOld(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	// RVA: 0x1025560 Offset: 0x1023B60 VA: 0x181025560
	private void OnPostRender() { }

	// RVA: -1 Offset: -1
	public PostProcessBundle GetBundle<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B980 Offset: 0x1A39F80 VA: 0x181A3B980
	|-PostProcessLayer.GetBundle<object>
	|-PostProcessLayer.GetBundle<AmbientOcclusion>
	|-PostProcessLayer.GetBundle<AutoExposure>
	|-PostProcessLayer.GetBundle<ScreenSpaceReflections>
	*/

	// RVA: 0x1023630 Offset: 0x1021C30 VA: 0x181023630
	public PostProcessBundle GetBundle(Type settingsType) { }

	// RVA: -1 Offset: -1
	public T GetSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA7E0 Offset: 0x15B8DE0 VA: 0x1815BA7E0
	|-PostProcessLayer.GetSettings<object>
	*/

	// RVA: 0x1021970 Offset: 0x101FF70 VA: 0x181021970
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = False) { }

	// RVA: 0x1025BB0 Offset: 0x10241B0 VA: 0x181025BB0
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	// RVA: 0x10287F0 Offset: 0x1026DF0 VA: 0x1810287F0
	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	// RVA: 0x1028670 Offset: 0x1026C70 VA: 0x181028670
	public void ResetHistory() { }

	// RVA: 0x1023A30 Offset: 0x1022030 VA: 0x181023A30
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	// RVA: 0x1023800 Offset: 0x1021E00 VA: 0x181023800
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	// RVA: 0x1029020 Offset: 0x1027620 VA: 0x181029020
	private void SetupContext(PostProcessRenderContext context) { }

	// RVA: 0x1029CA0 Offset: 0x10282A0 VA: 0x181029CA0
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

	// RVA: 0x1027980 Offset: 0x1025F80 VA: 0x181027980
	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	// RVA: 0x1027A60 Offset: 0x1026060 VA: 0x181027A60
	public void Render(PostProcessRenderContext context) { }

	// RVA: 0x10272A0 Offset: 0x10258A0 VA: 0x1810272A0
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	// RVA: 0x1027460 Offset: 0x1025A60 VA: 0x181027460
	private void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	// RVA: 0x1021850 Offset: 0x101FE50 VA: 0x181021850
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	// RVA: 0x1021770 Offset: 0x101FD70 VA: 0x181021770
	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	// RVA: 0x1026200 Offset: 0x1024800 VA: 0x181026200
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: 0x1026A20 Offset: 0x1025020 VA: 0x181026A20
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: -1 Offset: -1
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7280 Offset: 0xED5880 VA: 0x180ED7280
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

	// RVA: 0x10291B0 Offset: 0x10277B0 VA: 0x1810291B0
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	// RVA: 0x102A460 Offset: 0x1028A60 VA: 0x18102A460
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

	// RVA: 0x102D800 Offset: 0x102BE00 VA: 0x18102D800
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D0E0 Offset: 0x102B6E0 VA: 0x18102D0E0
	internal bool <OnEnableRenderScale>b__31_0(Shader x) { }

	// RVA: 0x102D150 Offset: 0x102B750 VA: 0x18102D150
	internal bool <OnEnableRenderScale>b__31_1(Shader x) { }

	// RVA: 0x102D1C0 Offset: 0x102B7C0 VA: 0x18102D1C0
	internal bool <OnEnableRenderScale>b__31_2(Shader x) { }

	// RVA: 0x102D230 Offset: 0x102B830 VA: 0x18102D230
	internal bool <OnEnableRenderScale>b__31_3(Shader x) { }

	// RVA: 0x102D2A0 Offset: 0x102B8A0 VA: 0x18102D2A0
	internal bool <OnEnableRenderScale>b__31_4(Shader x) { }

	// RVA: 0x102D310 Offset: 0x102B910 VA: 0x18102D310
	internal bool <OnEnableRenderScale>b__31_5(Shader x) { }

	// RVA: 0x102D380 Offset: 0x102B980 VA: 0x18102D380
	internal bool <OnEnableRenderScale>b__31_6(Shader x) { }

	// RVA: 0x102D5C0 Offset: 0x102BBC0 VA: 0x18102D5C0
	internal PostProcessBundle <UpdateBundleSortList>b__97_1(KeyValuePair<Type, PostProcessBundle> kvp) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_0 // TypeDefIndex: 11743
{	// Fields
	public PostProcessEvent evt; // 0x10
	public List<PostProcessBundle> effects; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D600 Offset: 0x102BC00 VA: 0x18102D600
	internal bool <UpdateBundleSortList>b__0(KeyValuePair<Type, PostProcessBundle> kvp) { }

	// RVA: 0x102D670 Offset: 0x102BC70 VA: 0x18102D670
	internal bool <UpdateBundleSortList>b__2(PostProcessLayer.SerializedBundleRef x) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_1 // TypeDefIndex: 11744
{	// Fields
	public string searchStr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D740 Offset: 0x102BD40 VA: 0x18102D740
	internal bool <UpdateBundleSortList>b__3(PostProcessBundle b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_2 // TypeDefIndex: 11745
{	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C410 Offset: 0x98AA10 VA: 0x18098C410
	internal bool <UpdateBundleSortList>b__4(PostProcessLayer.SerializedBundleRef b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_3 // TypeDefIndex: 11746
{	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D740 Offset: 0x102BD40 VA: 0x18102D740
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

	// RVA: 0x11D6190 Offset: 0x11D4790 VA: 0x1811D6190
	public void Resize(int width, int height, bool dlssEnabled) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Camera get_camera() { }

	// RVA: 0x11D6200 Offset: 0x11D4800 VA: 0x1811D6200
	public void set_camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public CommandBuffer get_command() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_command(CommandBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D61E0 Offset: 0x11D47E0 VA: 0x1811D61E0
	public RenderTargetIdentifier get_source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D62C0 Offset: 0x11D48C0 VA: 0x1811D62C0
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D61C0 Offset: 0x11D47C0 VA: 0x1811D61C0
	public RenderTargetIdentifier get_destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D62A0 Offset: 0x11D48A0 VA: 0x1811D62A0
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAF6020 Offset: 0xAF4620 VA: 0x180AF6020
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB28F90 Offset: 0xB27590 VA: 0x180B28F90
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x966200 Offset: 0x964800 VA: 0x180966200
	public bool get_flip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x966210 Offset: 0x964810 VA: 0x180966210
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
	// RVA: 0x1051A20 Offset: 0x1050020 VA: 0x181051A20
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A240 Offset: 0x1078840 VA: 0x18107A240
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1051A30 Offset: 0x1050030 VA: 0x181051A30
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A250 Offset: 0x1078850 VA: 0x18107A250
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808600 Offset: 0x806C00 VA: 0x180808600
	public bool get_stereoActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808610 Offset: 0x806C10 VA: 0x180808610
	private void set_stereoActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D2E0 Offset: 0xA4B8E0 VA: 0x180A4D2E0
	public int get_xrActiveEye() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A300 Offset: 0x1078900 VA: 0x18107A300
	private void set_xrActiveEye(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public int get_numberOfEyes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_numberOfEyes(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A0F0 Offset: 0x10786F0 VA: 0x18107A0F0
	public PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A260 Offset: 0x1078860 VA: 0x18107A260
	private void set_stereoRenderingMode(PostProcessRenderContext.StereoRenderingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A120 Offset: 0x1078720 VA: 0x18107A120
	public int get_screenWidth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A290 Offset: 0x1078890 VA: 0x18107A290
	public void set_screenWidth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A110 Offset: 0x1078710 VA: 0x18107A110
	public int get_screenHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A280 Offset: 0x1078880 VA: 0x18107A280
	public void set_screenHeight(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	public bool get_isSceneView() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	internal void set_isSceneView(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE2CE0 Offset: 0xAE12E0 VA: 0x180AE2CE0
	public PostProcessLayer.Antialiasing get_antialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A230 Offset: 0x1078830 VA: 0x18107A230
	internal void set_antialiasing(PostProcessLayer.Antialiasing value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA03A0 Offset: 0xD9E9A0 VA: 0x180DA03A0
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA0780 Offset: 0xD9ED80 VA: 0x180DA0780
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	// RVA: 0x11D5F60 Offset: 0x11D4560 VA: 0x1811D5F60
	public void Reset() { }

	// RVA: 0x11D5EA0 Offset: 0x11D44A0 VA: 0x1811D5EA0
	public bool IsTemporalAntialiasingActive() { }

	// RVA: 0x11D5E70 Offset: 0x11D4470 VA: 0x1811D5E70
	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	// RVA: 0x11D5F00 Offset: 0x11D4500 VA: 0x1811D5F00
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x11D5B60 Offset: 0x11D4160 VA: 0x1811D5B60
	private RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	// RVA: 0x11D5CD0 Offset: 0x11D42D0 VA: 0x1811D5CD0
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x11D5DE0 Offset: 0x11D43E0 VA: 0x1811D5DE0
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

	// RVA: 0x101EE90 Offset: 0x101D490 VA: 0x18101EE90
	public void .ctor(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = True) { }

	// RVA: 0x101EF00 Offset: 0x101D500 VA: 0x18101EF00
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

	// RVA: 0x101F0D0 Offset: 0x101D6D0 VA: 0x18101F0D0
	internal PostProcessEffectRenderer get_renderer() { }

	// RVA: 0x101F000 Offset: 0x101D600 VA: 0x18101F000
	internal void .ctor(PostProcessEffectSettings settings) { }

	// RVA: 0x101EF70 Offset: 0x101D570 VA: 0x18101EF70
	internal void Release() { }

	// RVA: 0x101EFE0 Offset: 0x101D5E0 VA: 0x18101EFE0
	internal void ResetHistory() { }

	// RVA: -1 Offset: -1
	internal T CastSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA770 Offset: 0x15B8D70 VA: 0x1815BA770
	|-PostProcessBundle.CastSettings<object>
	|-PostProcessBundle.CastSettings<AmbientOcclusion>
	*/

	// RVA: -1 Offset: -1
	internal T CastRenderer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA700 Offset: 0x15B8D00 VA: 0x1815BA700
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

	// RVA: 0x1020740 Offset: 0x101ED40 VA: 0x181020740
	private void OnEnable() { }

	// RVA: 0x1020690 Offset: 0x101EC90 VA: 0x181020690
	private void OnDisable() { }

	// RVA: 0x1020D20 Offset: 0x101F320 VA: 0x181020D20
	private void Update() { }

	// RVA: 0x1020A40 Offset: 0x101F040 VA: 0x181020A40
	private void Reset() { }

	// RVA: 0x1020A90 Offset: 0x101F090 VA: 0x181020A90
	private void UpdateStates() { }

	// RVA: 0x1020920 Offset: 0x101EF20 VA: 0x181020920
	private void OnPostRender() { }

	// RVA: 0x10207C0 Offset: 0x101EDC0 VA: 0x1810207C0
	private void OnGUI() { }

	// RVA: 0x1020510 Offset: 0x101EB10 VA: 0x181020510
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

	// RVA: 0x101F5E0 Offset: 0x101DBE0 VA: 0x18101F5E0
	internal void OnEnable() { }

	// RVA: 0x101F450 Offset: 0x101DA50 VA: 0x18101F450
	internal void OnDisable() { }

	// RVA: 0x101F210 Offset: 0x101D810 VA: 0x18101F210
	private void DestroyDebugOverlayTarget() { }

	// RVA: 0x10204A0 Offset: 0x101EAA0 VA: 0x1810204A0
	public void RequestMonitorPass(MonitorType monitor) { }

	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	public void RequestDebugOverlay(DebugOverlay mode) { }

	// RVA: 0x1020500 Offset: 0x101EB00 VA: 0x181020500
	internal void SetFrameSize(int width, int height) { }

	// RVA: 0x101F830 Offset: 0x101DE30 VA: 0x18101F830
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x101F420 Offset: 0x101DA20 VA: 0x18101F420
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x101FB00 Offset: 0x101E100 VA: 0x18101FB00
	internal void RenderMonitors(PostProcessRenderContext context) { }

	// RVA: 0x101FF70 Offset: 0x101E570 VA: 0x18101FF70
	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	// RVA: 0x101F290 Offset: 0x101D890 VA: 0x18101F290
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

	// RVA: 0x101EE70 Offset: 0x101D470 VA: 0x18101EE70
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

	// RVA: 0x1020D30 Offset: 0x101F330 VA: 0x181020D30 Slot: 6
	public virtual void ResetHistory() { }

	// RVA: 0x95FA30 Offset: 0x95E030 VA: 0x18095FA30 Slot: 7
	public virtual void Release() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Render(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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
	|-RVA: 0x19C5B30 Offset: 0x19C4130 VA: 0x1819C5B30
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
	|-RVA: 0x19C5BD0 Offset: 0x19C41D0 VA: 0x1819C5BD0
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

	// RVA: 0x10210C0 Offset: 0x101F6C0 VA: 0x1810210C0
	private void OnEnable() { }

	// RVA: 0x1020F30 Offset: 0x101F530 VA: 0x181020F30
	private void OnDisable() { }

	// RVA: 0x1021490 Offset: 0x101FA90 VA: 0x181021490
	public void SetAllOverridesTo(bool state, bool excludeEnabled = True) { }

	// RVA: 0x1020F10 Offset: 0x101F510 VA: 0x181020F10 Slot: 4
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x1020D50 Offset: 0x101F350 VA: 0x181020D50
	public int GetHash() { }

	// RVA: 0x10216F0 Offset: 0x101FCF0 VA: 0x1810216F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1021640 Offset: 0x101FC40 VA: 0x181021640
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }

}

private sealed class PostProcessEffectSettings.<>c // TypeDefIndex: 11845
{	// Fields
	public static readonly PostProcessEffectSettings.<>c <>9; // 0x0
	public static Func<FieldInfo, bool> <>9__3_0; // 0x8
	public static Func<FieldInfo, int> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x102D7A0 Offset: 0x102BDA0 VA: 0x18102D7A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D3F0 Offset: 0x102B9F0 VA: 0x18102D3F0
	internal bool <OnEnable>b__3_0(FieldInfo t) { }

	// RVA: 0x102D490 Offset: 0x102BA90 VA: 0x18102D490
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

	// RVA: 0x102C840 Offset: 0x102AE40 VA: 0x18102C840
	public static PostProcessManager get_instance() { }

	// RVA: 0x102C710 Offset: 0x102AD10 VA: 0x18102C710
	private void .ctor() { }

	// RVA: 0x102A7B0 Offset: 0x1028DB0 VA: 0x18102A7B0
	private void CleanBaseTypes() { }

	// RVA: 0x102B6F0 Offset: 0x1029CF0 VA: 0x18102B6F0
	private void ReloadBaseTypes() { }

	// RVA: 0x102A910 Offset: 0x1028F10 VA: 0x18102A910
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = True, bool skipZeroWeight = True) { }

	// RVA: 0x102AF10 Offset: 0x1029510 VA: 0x18102AF10
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	// RVA: 0x102AD70 Offset: 0x1029370 VA: 0x18102AD70
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	// RVA: 0x102B3A0 Offset: 0x10299A0 VA: 0x18102B3A0
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	// RVA: 0x102BCE0 Offset: 0x102A2E0 VA: 0x18102BCE0
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x102C650 Offset: 0x102AC50 VA: 0x18102C650
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

	// RVA: 0x102B510 Offset: 0x1029B10 VA: 0x18102B510
	private void Register(PostProcessVolume volume, int layer) { }

	// RVA: 0x102B6A0 Offset: 0x1029CA0 VA: 0x18102B6A0
	internal void Register(PostProcessVolume volume) { }

	// RVA: 0x102C010 Offset: 0x102A610 VA: 0x18102C010
	private void Unregister(PostProcessVolume volume, int layer) { }

	// RVA: 0x102BFC0 Offset: 0x102A5C0 VA: 0x18102BFC0
	internal void Unregister(PostProcessVolume volume) { }

	// RVA: 0x102BAC0 Offset: 0x102A0C0 VA: 0x18102BAC0
	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	// RVA: 0x102C170 Offset: 0x102A770 VA: 0x18102C170
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	// RVA: 0x102AFD0 Offset: 0x10295D0 VA: 0x18102AFD0
	private List<PostProcessVolume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x102BE70 Offset: 0x102A470 VA: 0x18102BE70
	private static void SortByPriority(List<PostProcessVolume> volumes) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }

}

private sealed class PostProcessManager.<>c // TypeDefIndex: 11849
{	// Fields
	public static readonly PostProcessManager.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x102D860 Offset: 0x102BE60 VA: 0x18102D860
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102D4C0 Offset: 0x102BAC0 VA: 0x18102D4C0
	internal bool <ReloadBaseTypes>b__11_0(Type t) { }

}

public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 11850
{	// Fields
	[TooltipAttribute] // RVA: 0x7BFB0 Offset: 0x7B3B0 VA: 0x18007BFB0
	public List<PostProcessEffectSettings> settings; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x102CD70 Offset: 0x102B370 VA: 0x18102CD70
	private void OnEnable() { }

	// RVA: -1 Offset: -1
	public T AddSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA820 Offset: 0x15B8E20 VA: 0x1815BA820
	|-PostProcessProfile.AddSettings<object>
	*/

	// RVA: 0x102C9E0 Offset: 0x102AFE0 VA: 0x18102C9E0
	public PostProcessEffectSettings AddSettings(Type type) { }

	// RVA: 0x102CB30 Offset: 0x102B130 VA: 0x18102CB30
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) { }

	// RVA: -1 Offset: -1
	public void RemoveSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3A20 Offset: 0x5D2020 VA: 0x1805D3A20
	|-PostProcessProfile.RemoveSettings<object>
	*/

	// RVA: 0x102CE70 Offset: 0x102B470 VA: 0x18102CE70
	public void RemoveSettings(Type type) { }

	// RVA: -1 Offset: -1
	public bool HasSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2D20 Offset: 0xBF1320 VA: 0x180BF2D20
	|-PostProcessProfile.HasSettings<object>
	*/

	// RVA: 0x102CBE0 Offset: 0x102B1E0 VA: 0x18102CBE0
	public bool HasSettings(Type type) { }

	// RVA: -1 Offset: -1
	public T GetSetting<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA8F0 Offset: 0x15B8EF0 VA: 0x1815BA8F0
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
	|-RVA: 0xBF2DA0 Offset: 0xBF13A0 VA: 0x180BF2DA0
	|-PostProcessProfile.TryGetSettings<object>
	*/

	// RVA: 0x102CFC0 Offset: 0x102B5C0 VA: 0x18102CFC0
	public void .ctor() { }

}

private sealed class PostProcessProfile.<>c // TypeDefIndex: 11851
{	// Fields
	public static readonly PostProcessProfile.<>c <>9; // 0x0
	public static Predicate<PostProcessEffectSettings> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x11E7B10 Offset: 0x11E6110 VA: 0x1811E7B10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11E7A80 Offset: 0x11E6080 VA: 0x1811E7A80
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

	// RVA: 0x11E00D0 Offset: 0x11DE6D0 VA: 0x1811E00D0
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

	// RVA: 0x11D5680 Offset: 0x11D3C80 VA: 0x1811D5680
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

	// RVA: 0x11D68A0 Offset: 0x11D4EA0 VA: 0x1811D68A0
	public PostProcessProfile get_profile() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_profile(PostProcessProfile value) { }

	// RVA: 0x11D6820 Offset: 0x11D4E20 VA: 0x1811D6820
	internal PostProcessProfile get_profileRef() { }

	// RVA: 0x11D62E0 Offset: 0x11D48E0 VA: 0x1811D62E0
	public bool HasInstantiatedProfile() { }

	// RVA: 0x11D6730 Offset: 0x11D4D30 VA: 0x1811D6730
	private void OnEnable() { }

	// RVA: 0x11D6340 Offset: 0x11D4940 VA: 0x1811D6340
	private void OnDisable() { }

	// RVA: 0x11D6780 Offset: 0x11D4D80 VA: 0x1811D6780
	private void Update() { }

	// RVA: 0x11D6370 Offset: 0x11D4970 VA: 0x1811D6370
	private void OnDrawGizmos() { }

	// RVA: 0xA0BF70 Offset: 0xA0A570 VA: 0x180A0BF70
	public void .ctor() { }

}

