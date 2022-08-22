public class PostProcessVolumeLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 10277
{	// Fields
	public float distance; // 0x18
	private LODCell cell; // 0x20
	private PostProcessVolume postProcessVolume; // 0x28
	private LODEnvironmentMode environmentMode; // 0x30

	// Methods

	// RVA: 0x99C710 Offset: 0x99AD10 VA: 0x18099C710
	private void Awake() { }

	// RVA: 0x99C930 Offset: 0x99AF30 VA: 0x18099C930
	private void OnEnable() { }

	// RVA: 0x99C880 Offset: 0x99AE80 VA: 0x18099C880
	private void OnDisable() { }

	// RVA: 0x99C800 Offset: 0x99AE00 VA: 0x18099C800
	private float GetDistance() { }

	// RVA: 0x99C760 Offset: 0x99AD60 VA: 0x18099C760 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x99C9D0 Offset: 0x99AFD0 VA: 0x18099C9D0 Slot: 5
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

	// RVA: 0x102B210 Offset: 0x1029810 VA: 0x18102B210
	public bool get_ScreenshotMode() { }

	// RVA: 0x102B230 Offset: 0x1029830 VA: 0x18102B230
	public void set_ScreenshotMode(bool value) { }

	// RVA: 0x102B1B0 Offset: 0x10297B0 VA: 0x18102B1B0
	public uint get_ScreenWidth() { }

	// RVA: 0x102B150 Offset: 0x1029750 VA: 0x18102B150
	public uint get_ScreenHeight() { }

	// RVA: 0x102B090 Offset: 0x1029690 VA: 0x18102B090
	public uint get_ScaledScreenWidth() { }

	// RVA: 0x102AFD0 Offset: 0x10295D0 VA: 0x18102AFD0
	public uint get_ScaledScreenHeight() { }

	// RVA: 0x1025690 Offset: 0x1023C90 VA: 0x181025690
	private void OnEnableRenderScale() { }

	// RVA: 0x1024F90 Offset: 0x1023590 VA: 0x181024F90
	private void OnDisableRenderScale() { }

	// RVA: 0x102A870 Offset: 0x1028E70 VA: 0x18102A870
	private void Update() { }

	// RVA: 0x1024180 Offset: 0x1022780 VA: 0x181024180
	private PostProcessLayer.ScalingMode GetDesiredScalingMode(NVSDK_NGX_PerfQuality_Value dlssMode) { }

	// RVA: 0x1024C80 Offset: 0x1023280 VA: 0x181024C80
	private bool NeedsRebuild(PostProcessLayer.ScalingMode desiredScalingMode, NVSDK_NGX_PerfQuality_Value dlssMode) { }

	// RVA: 0x1029510 Offset: 0x1027B10 VA: 0x181029510
	public void SetMipMapBias(float bias) { }

	// RVA: 0x1023E90 Offset: 0x1022490 VA: 0x181023E90
	private float CalculateMipMapBias() { }

	// RVA: 0x1022FD0 Offset: 0x10215D0 VA: 0x181022FD0
	private void BuildPostEffectsNew(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	// RVA: 0x1026A00 Offset: 0x1025000 VA: 0x181026A00
	private void RebuildRenderTargets() { }

	// RVA: 0x1024010 Offset: 0x1022610 VA: 0x181024010
	private void FreeRenderTargets() { }

	// RVA: 0x10268A0 Offset: 0x1024EA0 VA: 0x1810268A0
	private void RebuildColorOutput() { }

	// RVA: 0x1023F90 Offset: 0x1022590 VA: 0x181023F90
	private void FreeRenderColorOutput() { }

	// RVA: 0x1029CF0 Offset: 0x10282F0 VA: 0x181029CF0
	private bool StartDLSS() { }

	// RVA: 0x102A330 Offset: 0x1028930 VA: 0x18102A330
	private bool UpdateDLSSQualitySettings(NVSDK_NGX_PerfQuality_Value perfQuality) { }

	// RVA: 0x1029DA0 Offset: 0x10283A0 VA: 0x181029DA0
	private void StopDLSS() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE670B0 Offset: 0xE656B0 VA: 0x180E670B0
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> get_sortedBundles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE66770 Offset: 0xE64D70 VA: 0x180E66770
	private void set_sortedBundles(Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x102B220 Offset: 0x1029820 VA: 0x18102B220
	public bool get_haveBundlesBeenInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x102B240 Offset: 0x1029840 VA: 0x18102B240
	private void set_haveBundlesBeenInited(bool value) { }

	// RVA: 0x1025DE0 Offset: 0x10243E0 VA: 0x181025DE0
	private void OnEnable() { }

	// RVA: 0x1024920 Offset: 0x1022F20 VA: 0x181024920
	private void InitLegacy() { }

	[ImageEffectUsesCommandBuffer] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10265C0 Offset: 0x1024BC0 VA: 0x1810265C0
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x1024B70 Offset: 0x1023170 VA: 0x181024B70
	public void Init(PostProcessResources resources) { }

	// RVA: 0x10244E0 Offset: 0x1022AE0 VA: 0x1810244E0
	public void InitBundles() { }

	// RVA: 0x1029DE0 Offset: 0x10283E0 VA: 0x181029DE0
	private void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	// RVA: 0x1025110 Offset: 0x1023710 VA: 0x181025110
	private void OnDisable() { }

	// RVA: 0x1029260 Offset: 0x1027860 VA: 0x181029260
	private void Reset() { }

	// RVA: 0x1026220 Offset: 0x1024820 VA: 0x181026220
	private void OnPreCull() { }

	// RVA: 0x1026540 Offset: 0x1024B40 VA: 0x181026540
	private void OnPreRender() { }

	// RVA: 0x1024250 Offset: 0x1022850 VA: 0x181024250
	private RenderTextureFormat GetIntermediateFormat() { }

	// RVA: 0x1029090 Offset: 0x1027690 VA: 0x181029090
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	// RVA: 0x102A600 Offset: 0x1028C00 VA: 0x18102A600
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	// RVA: 0x1022560 Offset: 0x1020B60 VA: 0x181022560
	private void BuildCommandBuffers() { }

	// RVA: 0x1023A20 Offset: 0x1022020 VA: 0x181023A20
	private void BuildPostEffectsOld(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	// RVA: 0x1026000 Offset: 0x1024600 VA: 0x181026000
	private void OnPostRender() { }

	// RVA: -1 Offset: -1
	public PostProcessBundle GetBundle<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B0A0 Offset: 0x1A396A0 VA: 0x181A3B0A0
	|-PostProcessLayer.GetBundle<object>
	|-PostProcessLayer.GetBundle<AmbientOcclusion>
	|-PostProcessLayer.GetBundle<AutoExposure>
	|-PostProcessLayer.GetBundle<ScreenSpaceReflections>
	*/

	// RVA: 0x10240D0 Offset: 0x10226D0 VA: 0x1810240D0
	public PostProcessBundle GetBundle(Type settingsType) { }

	// RVA: -1 Offset: -1
	public T GetSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B98B0 Offset: 0x15B7EB0 VA: 0x1815B98B0
	|-PostProcessLayer.GetSettings<object>
	*/

	// RVA: 0x1022410 Offset: 0x1020A10 VA: 0x181022410
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = False) { }

	// RVA: 0x1026650 Offset: 0x1024C50 VA: 0x181026650
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	// RVA: 0x1029290 Offset: 0x1027890 VA: 0x181029290
	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	// RVA: 0x1029110 Offset: 0x1027710 VA: 0x181029110
	public void ResetHistory() { }

	// RVA: 0x10244D0 Offset: 0x1022AD0 VA: 0x1810244D0
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	// RVA: 0x10242A0 Offset: 0x10228A0 VA: 0x1810242A0
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	// RVA: 0x1029AC0 Offset: 0x10280C0 VA: 0x181029AC0
	private void SetupContext(PostProcessRenderContext context) { }

	// RVA: 0x102A740 Offset: 0x1028D40 VA: 0x18102A740
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

	// RVA: 0x1028420 Offset: 0x1026A20 VA: 0x181028420
	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	// RVA: 0x1028500 Offset: 0x1026B00 VA: 0x181028500
	public void Render(PostProcessRenderContext context) { }

	// RVA: 0x1027D40 Offset: 0x1026340 VA: 0x181027D40
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	// RVA: 0x1027F00 Offset: 0x1026500 VA: 0x181027F00
	private void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	// RVA: 0x10222F0 Offset: 0x10208F0 VA: 0x1810222F0
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	// RVA: 0x1022210 Offset: 0x1020810 VA: 0x181022210
	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	// RVA: 0x1026CA0 Offset: 0x10252A0 VA: 0x181026CA0
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: 0x10274C0 Offset: 0x1025AC0 VA: 0x1810274C0
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: -1 Offset: -1
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7D30 Offset: 0xED6330 VA: 0x180ED7D30
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

	// RVA: 0x1029C50 Offset: 0x1028250 VA: 0x181029C50
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	// RVA: 0x102AF00 Offset: 0x1029500 VA: 0x18102AF00
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

	// RVA: 0x102E2A0 Offset: 0x102C8A0 VA: 0x18102E2A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102DB80 Offset: 0x102C180 VA: 0x18102DB80
	internal bool <OnEnableRenderScale>b__31_0(Shader x) { }

	// RVA: 0x102DBF0 Offset: 0x102C1F0 VA: 0x18102DBF0
	internal bool <OnEnableRenderScale>b__31_1(Shader x) { }

	// RVA: 0x102DC60 Offset: 0x102C260 VA: 0x18102DC60
	internal bool <OnEnableRenderScale>b__31_2(Shader x) { }

	// RVA: 0x102DCD0 Offset: 0x102C2D0 VA: 0x18102DCD0
	internal bool <OnEnableRenderScale>b__31_3(Shader x) { }

	// RVA: 0x102DD40 Offset: 0x102C340 VA: 0x18102DD40
	internal bool <OnEnableRenderScale>b__31_4(Shader x) { }

	// RVA: 0x102DDB0 Offset: 0x102C3B0 VA: 0x18102DDB0
	internal bool <OnEnableRenderScale>b__31_5(Shader x) { }

	// RVA: 0x102DE20 Offset: 0x102C420 VA: 0x18102DE20
	internal bool <OnEnableRenderScale>b__31_6(Shader x) { }

	// RVA: 0x102E060 Offset: 0x102C660 VA: 0x18102E060
	internal PostProcessBundle <UpdateBundleSortList>b__97_1(KeyValuePair<Type, PostProcessBundle> kvp) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_0 // TypeDefIndex: 11743
{	// Fields
	public PostProcessEvent evt; // 0x10
	public List<PostProcessBundle> effects; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102E0A0 Offset: 0x102C6A0 VA: 0x18102E0A0
	internal bool <UpdateBundleSortList>b__0(KeyValuePair<Type, PostProcessBundle> kvp) { }

	// RVA: 0x102E110 Offset: 0x102C710 VA: 0x18102E110
	internal bool <UpdateBundleSortList>b__2(PostProcessLayer.SerializedBundleRef x) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_1 // TypeDefIndex: 11744
{	// Fields
	public string searchStr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102E1E0 Offset: 0x102C7E0 VA: 0x18102E1E0
	internal bool <UpdateBundleSortList>b__3(PostProcessBundle b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_2 // TypeDefIndex: 11745
{	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C910 Offset: 0x98AF10 VA: 0x18098C910
	internal bool <UpdateBundleSortList>b__4(PostProcessLayer.SerializedBundleRef b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_3 // TypeDefIndex: 11746
{	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102E1E0 Offset: 0x102C7E0 VA: 0x18102E1E0
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

	// RVA: 0x11D6830 Offset: 0x11D4E30 VA: 0x1811D6830
	public void Resize(int width, int height, bool dlssEnabled) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Camera get_camera() { }

	// RVA: 0x11D68A0 Offset: 0x11D4EA0 VA: 0x1811D68A0
	public void set_camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public CommandBuffer get_command() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_command(CommandBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D6880 Offset: 0x11D4E80 VA: 0x1811D6880
	public RenderTargetIdentifier get_source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D6960 Offset: 0x11D4F60 VA: 0x1811D6960
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D6860 Offset: 0x11D4E60 VA: 0x1811D6860
	public RenderTargetIdentifier get_destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D6940 Offset: 0x11D4F40 VA: 0x1811D6940
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAF64F0 Offset: 0xAF4AF0 VA: 0x180AF64F0
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB29460 Offset: 0xB27A60 VA: 0x180B29460
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x966700 Offset: 0x964D00 VA: 0x180966700
	public bool get_flip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x966710 Offset: 0x964D10 VA: 0x180966710
	public void set_flip(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public PostProcessResources get_resources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_resources(PostProcessResources value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public Dictionary<string, object> get_userData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	private void set_userData(Dictionary<string, object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1052490 Offset: 0x1050A90 VA: 0x181052490
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACB0 Offset: 0x10792B0 VA: 0x18107ACB0
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10524A0 Offset: 0x1050AA0 VA: 0x1810524A0
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACC0 Offset: 0x10792C0 VA: 0x18107ACC0
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808B90 Offset: 0x807190 VA: 0x180808B90
	public bool get_stereoActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808BA0 Offset: 0x8071A0 VA: 0x180808BA0
	private void set_stereoActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D7D0 Offset: 0xA4BDD0 VA: 0x180A4D7D0
	public int get_xrActiveEye() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD70 Offset: 0x1079370 VA: 0x18107AD70
	private void set_xrActiveEye(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public int get_numberOfEyes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_numberOfEyes(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB60 Offset: 0x1079160 VA: 0x18107AB60
	public PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACD0 Offset: 0x10792D0 VA: 0x18107ACD0
	private void set_stereoRenderingMode(PostProcessRenderContext.StereoRenderingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB90 Offset: 0x1079190 VA: 0x18107AB90
	public int get_screenWidth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD00 Offset: 0x1079300 VA: 0x18107AD00
	public void set_screenWidth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB80 Offset: 0x1079180 VA: 0x18107AB80
	public int get_screenHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACF0 Offset: 0x10792F0 VA: 0x18107ACF0
	public void set_screenHeight(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EA80 Offset: 0x56D080 VA: 0x18056EA80
	public bool get_isSceneView() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EA90 Offset: 0x56D090 VA: 0x18056EA90
	internal void set_isSceneView(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE31B0 Offset: 0xAE17B0 VA: 0x180AE31B0
	public PostProcessLayer.Antialiasing get_antialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACA0 Offset: 0x10792A0 VA: 0x18107ACA0
	internal void set_antialiasing(PostProcessLayer.Antialiasing value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA1230 Offset: 0xD9F830 VA: 0x180DA1230
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	// RVA: 0x11D6600 Offset: 0x11D4C00 VA: 0x1811D6600
	public void Reset() { }

	// RVA: 0x11D6540 Offset: 0x11D4B40 VA: 0x1811D6540
	public bool IsTemporalAntialiasingActive() { }

	// RVA: 0x11D6510 Offset: 0x11D4B10 VA: 0x1811D6510
	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	// RVA: 0x11D65A0 Offset: 0x11D4BA0 VA: 0x1811D65A0
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x11D6200 Offset: 0x11D4800 VA: 0x1811D6200
	private RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	// RVA: 0x11D6370 Offset: 0x11D4970 VA: 0x1811D6370
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x11D6480 Offset: 0x11D4A80 VA: 0x1811D6480
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

	// RVA: 0x101F930 Offset: 0x101DF30 VA: 0x18101F930
	public void .ctor(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = True) { }

	// RVA: 0x101F9A0 Offset: 0x101DFA0 VA: 0x18101F9A0
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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public PostProcessAttribute get_attribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_attribute(PostProcessAttribute value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public PostProcessEffectSettings get_settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_settings(PostProcessEffectSettings value) { }

	// RVA: 0x101FB70 Offset: 0x101E170 VA: 0x18101FB70
	internal PostProcessEffectRenderer get_renderer() { }

	// RVA: 0x101FAA0 Offset: 0x101E0A0 VA: 0x18101FAA0
	internal void .ctor(PostProcessEffectSettings settings) { }

	// RVA: 0x101FA10 Offset: 0x101E010 VA: 0x18101FA10
	internal void Release() { }

	// RVA: 0x101FA80 Offset: 0x101E080 VA: 0x18101FA80
	internal void ResetHistory() { }

	// RVA: -1 Offset: -1
	internal T CastSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9840 Offset: 0x15B7E40 VA: 0x1815B9840
	|-PostProcessBundle.CastSettings<object>
	|-PostProcessBundle.CastSettings<AmbientOcclusion>
	*/

	// RVA: -1 Offset: -1
	internal T CastRenderer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B97D0 Offset: 0x15B7DD0 VA: 0x1815B97D0
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

	// RVA: 0x10211E0 Offset: 0x101F7E0 VA: 0x1810211E0
	private void OnEnable() { }

	// RVA: 0x1021130 Offset: 0x101F730 VA: 0x181021130
	private void OnDisable() { }

	// RVA: 0x10217C0 Offset: 0x101FDC0 VA: 0x1810217C0
	private void Update() { }

	// RVA: 0x10214E0 Offset: 0x101FAE0 VA: 0x1810214E0
	private void Reset() { }

	// RVA: 0x1021530 Offset: 0x101FB30 VA: 0x181021530
	private void UpdateStates() { }

	// RVA: 0x10213C0 Offset: 0x101F9C0 VA: 0x1810213C0
	private void OnPostRender() { }

	// RVA: 0x1021260 Offset: 0x101F860 VA: 0x181021260
	private void OnGUI() { }

	// RVA: 0x1020FB0 Offset: 0x101F5B0 VA: 0x181020FB0
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
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public RenderTexture get_debugOverlayTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	private void set_debugOverlayTarget(RenderTexture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	public bool get_debugOverlayActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC570 Offset: 0x4BAB70 VA: 0x1804BC570
	private void set_debugOverlayActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0
	public DebugOverlay get_debugOverlay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59A080 Offset: 0x598680 VA: 0x18059A080
	private void set_debugOverlay(DebugOverlay value) { }

	// RVA: 0x1020080 Offset: 0x101E680 VA: 0x181020080
	internal void OnEnable() { }

	// RVA: 0x101FEF0 Offset: 0x101E4F0 VA: 0x18101FEF0
	internal void OnDisable() { }

	// RVA: 0x101FCB0 Offset: 0x101E2B0 VA: 0x18101FCB0
	private void DestroyDebugOverlayTarget() { }

	// RVA: 0x1020F40 Offset: 0x101F540 VA: 0x181020F40
	public void RequestMonitorPass(MonitorType monitor) { }

	// RVA: 0x59A080 Offset: 0x598680 VA: 0x18059A080
	public void RequestDebugOverlay(DebugOverlay mode) { }

	// RVA: 0x1020FA0 Offset: 0x101F5A0 VA: 0x181020FA0
	internal void SetFrameSize(int width, int height) { }

	// RVA: 0x10202D0 Offset: 0x101E8D0 VA: 0x1810202D0
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x101FEC0 Offset: 0x101E4C0 VA: 0x18101FEC0
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x10205A0 Offset: 0x101EBA0 VA: 0x1810205A0
	internal void RenderMonitors(PostProcessRenderContext context) { }

	// RVA: 0x1020A10 Offset: 0x101F010 VA: 0x181020A10
	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	// RVA: 0x101FD30 Offset: 0x101E330 VA: 0x18101FD30
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

	// RVA: 0x101F910 Offset: 0x101DF10 VA: 0x18101F910
	public void .ctor() { }

}

public abstract class PostProcessEffectRenderer // TypeDefIndex: 11842
{	// Fields
	protected bool m_ResetHistory; // 0x10

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void Init() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public virtual DepthTextureMode GetCameraFlags() { }

	// RVA: 0x10217D0 Offset: 0x101FDD0 VA: 0x1810217D0 Slot: 6
	public virtual void ResetHistory() { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30 Slot: 7
	public virtual void Release() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Render(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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
	|-RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	|-PostProcessEffectRenderer<object>.set_settings
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal override void SetSettings(PostProcessEffectSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B2F30 Offset: 0x19B1530 VA: 0x1819B2F30
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
	|-RVA: 0x19B2FD0 Offset: 0x19B15D0 VA: 0x1819B2FD0
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

	// RVA: 0x1021B60 Offset: 0x1020160 VA: 0x181021B60
	private void OnEnable() { }

	// RVA: 0x10219D0 Offset: 0x101FFD0 VA: 0x1810219D0
	private void OnDisable() { }

	// RVA: 0x1021F30 Offset: 0x1020530 VA: 0x181021F30
	public void SetAllOverridesTo(bool state, bool excludeEnabled = True) { }

	// RVA: 0x10219B0 Offset: 0x101FFB0 VA: 0x1810219B0 Slot: 4
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x10217F0 Offset: 0x101FDF0 VA: 0x1810217F0
	public int GetHash() { }

	// RVA: 0x1022190 Offset: 0x1020790 VA: 0x181022190
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10220E0 Offset: 0x10206E0 VA: 0x1810220E0
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }

}

private sealed class PostProcessEffectSettings.<>c // TypeDefIndex: 11845
{	// Fields
	public static readonly PostProcessEffectSettings.<>c <>9; // 0x0
	public static Func<FieldInfo, bool> <>9__3_0; // 0x8
	public static Func<FieldInfo, int> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x102E240 Offset: 0x102C840 VA: 0x18102E240
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102DE90 Offset: 0x102C490 VA: 0x18102DE90
	internal bool <OnEnable>b__3_0(FieldInfo t) { }

	// RVA: 0x102DF30 Offset: 0x102C530 VA: 0x18102DF30
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

	// RVA: 0x15BED0 Offset: 0x15B2D0 VA: 0x18015BED0 Slot: 4
	public bool Equals(PostProcessEvent x, PostProcessEvent y) { }

	// RVA: 0x15BEE0 Offset: 0x15B2E0 VA: 0x18015BEE0 Slot: 5
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

	// RVA: 0x102D2E0 Offset: 0x102B8E0 VA: 0x18102D2E0
	public static PostProcessManager get_instance() { }

	// RVA: 0x102D1B0 Offset: 0x102B7B0 VA: 0x18102D1B0
	private void .ctor() { }

	// RVA: 0x102B250 Offset: 0x1029850 VA: 0x18102B250
	private void CleanBaseTypes() { }

	// RVA: 0x102C190 Offset: 0x102A790 VA: 0x18102C190
	private void ReloadBaseTypes() { }

	// RVA: 0x102B3B0 Offset: 0x10299B0 VA: 0x18102B3B0
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = True, bool skipZeroWeight = True) { }

	// RVA: 0x102B9B0 Offset: 0x1029FB0 VA: 0x18102B9B0
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	// RVA: 0x102B810 Offset: 0x1029E10 VA: 0x18102B810
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	// RVA: 0x102BE40 Offset: 0x102A440 VA: 0x18102BE40
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	// RVA: 0x102C780 Offset: 0x102AD80 VA: 0x18102C780
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x102D0F0 Offset: 0x102B6F0 VA: 0x18102D0F0
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

	// RVA: 0x102BFB0 Offset: 0x102A5B0 VA: 0x18102BFB0
	private void Register(PostProcessVolume volume, int layer) { }

	// RVA: 0x102C140 Offset: 0x102A740 VA: 0x18102C140
	internal void Register(PostProcessVolume volume) { }

	// RVA: 0x102CAB0 Offset: 0x102B0B0 VA: 0x18102CAB0
	private void Unregister(PostProcessVolume volume, int layer) { }

	// RVA: 0x102CA60 Offset: 0x102B060 VA: 0x18102CA60
	internal void Unregister(PostProcessVolume volume) { }

	// RVA: 0x102C560 Offset: 0x102AB60 VA: 0x18102C560
	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	// RVA: 0x102CC10 Offset: 0x102B210 VA: 0x18102CC10
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	// RVA: 0x102BA70 Offset: 0x102A070 VA: 0x18102BA70
	private List<PostProcessVolume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x102C910 Offset: 0x102AF10 VA: 0x18102C910
	private static void SortByPriority(List<PostProcessVolume> volumes) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }

}

private sealed class PostProcessManager.<>c // TypeDefIndex: 11849
{	// Fields
	public static readonly PostProcessManager.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x102E300 Offset: 0x102C900 VA: 0x18102E300
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x102DF60 Offset: 0x102C560 VA: 0x18102DF60
	internal bool <ReloadBaseTypes>b__11_0(Type t) { }

}

public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 11850
{	// Fields
	[TooltipAttribute] // RVA: 0x7BFB0 Offset: 0x7B3B0 VA: 0x18007BFB0
	public List<PostProcessEffectSettings> settings; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x102D810 Offset: 0x102BE10 VA: 0x18102D810
	private void OnEnable() { }

	// RVA: -1 Offset: -1
	public T AddSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B98F0 Offset: 0x15B7EF0 VA: 0x1815B98F0
	|-PostProcessProfile.AddSettings<object>
	*/

	// RVA: 0x102D480 Offset: 0x102BA80 VA: 0x18102D480
	public PostProcessEffectSettings AddSettings(Type type) { }

	// RVA: 0x102D5D0 Offset: 0x102BBD0 VA: 0x18102D5D0
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) { }

	// RVA: -1 Offset: -1
	public void RemoveSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D39B0 Offset: 0x5D1FB0 VA: 0x1805D39B0
	|-PostProcessProfile.RemoveSettings<object>
	*/

	// RVA: 0x102D910 Offset: 0x102BF10 VA: 0x18102D910
	public void RemoveSettings(Type type) { }

	// RVA: -1 Offset: -1
	public bool HasSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF31F0 Offset: 0xBF17F0 VA: 0x180BF31F0
	|-PostProcessProfile.HasSettings<object>
	*/

	// RVA: 0x102D680 Offset: 0x102BC80 VA: 0x18102D680
	public bool HasSettings(Type type) { }

	// RVA: -1 Offset: -1
	public T GetSetting<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B99C0 Offset: 0x15B7FC0 VA: 0x1815B99C0
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
	|-RVA: 0xBF3270 Offset: 0xBF1870 VA: 0x180BF3270
	|-PostProcessProfile.TryGetSettings<object>
	*/

	// RVA: 0x102DA60 Offset: 0x102C060 VA: 0x18102DA60
	public void .ctor() { }

}

private sealed class PostProcessProfile.<>c // TypeDefIndex: 11851
{	// Fields
	public static readonly PostProcessProfile.<>c <>9; // 0x0
	public static Predicate<PostProcessEffectSettings> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x11E81B0 Offset: 0x11E67B0 VA: 0x1811E81B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11E8120 Offset: 0x11E6720 VA: 0x1811E8120
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

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
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

	// RVA: 0x11E0770 Offset: 0x11DED70 VA: 0x1811E0770
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

	// RVA: 0x11D5D20 Offset: 0x11D4320 VA: 0x1811D5D20
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

	// RVA: 0x11D6F40 Offset: 0x11D5540 VA: 0x1811D6F40
	public PostProcessProfile get_profile() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_profile(PostProcessProfile value) { }

	// RVA: 0x11D6EC0 Offset: 0x11D54C0 VA: 0x1811D6EC0
	internal PostProcessProfile get_profileRef() { }

	// RVA: 0x11D6980 Offset: 0x11D4F80 VA: 0x1811D6980
	public bool HasInstantiatedProfile() { }

	// RVA: 0x11D6DD0 Offset: 0x11D53D0 VA: 0x1811D6DD0
	private void OnEnable() { }

	// RVA: 0x11D69E0 Offset: 0x11D4FE0 VA: 0x1811D69E0
	private void OnDisable() { }

	// RVA: 0x11D6E20 Offset: 0x11D5420 VA: 0x1811D6E20
	private void Update() { }

	// RVA: 0x11D6A10 Offset: 0x11D5010 VA: 0x1811D6A10
	private void OnDrawGizmos() { }

	// RVA: 0xA0C460 Offset: 0xA0AA60 VA: 0x180A0C460
	public void .ctor() { }

}

