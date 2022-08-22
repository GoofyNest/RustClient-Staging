public class AmplifyOcclusionBase : MonoBehaviour // TypeDefIndex: 11468
{	// Fields
	[HeaderAttribute] // RVA: 0xB2210 Offset: 0xB1610 VA: 0x1800B2210
	public AmplifyOcclusionBase.ApplicationMethod ApplyMethod; // 0x18
	[TooltipAttribute] // RVA: 0xB2330 Offset: 0xB1730 VA: 0x1800B2330
	public AmplifyOcclusionBase.SampleCountLevel SampleCount; // 0x1C
	public AmplifyOcclusionBase.PerPixelNormalSource PerPixelNormals; // 0x20
	[TooltipAttribute] // RVA: 0xB2400 Offset: 0xB1800 VA: 0x1800B2400
	[RangeAttribute] // RVA: 0xB2400 Offset: 0xB1800 VA: 0x1800B2400
	public float Intensity; // 0x24
	public Color Tint; // 0x28
	[TooltipAttribute] // RVA: 0xB2570 Offset: 0xB1970 VA: 0x1800B2570
	[RangeAttribute] // RVA: 0xB2570 Offset: 0xB1970 VA: 0x1800B2570
	public float Radius; // 0x38
	[TooltipAttribute] // RVA: 0xB2800 Offset: 0xB1C00 VA: 0x1800B2800
	[RangeAttribute] // RVA: 0xB2800 Offset: 0xB1C00 VA: 0x1800B2800
	public int PixelRadiusLimit; // 0x3C
	[TooltipAttribute] // RVA: 0xB2A30 Offset: 0xB1E30 VA: 0x1800B2A30
	[RangeAttribute] // RVA: 0xB2A30 Offset: 0xB1E30 VA: 0x1800B2A30
	public float RadiusIntensity; // 0x40
	[TooltipAttribute] // RVA: 0xB2C50 Offset: 0xB2050 VA: 0x1800B2C50
	[RangeAttribute] // RVA: 0xB2C50 Offset: 0xB2050 VA: 0x1800B2C50
	public float PowerExponent; // 0x44
	[TooltipAttribute] // RVA: 0xB2D40 Offset: 0xB2140 VA: 0x1800B2D40
	[RangeAttribute] // RVA: 0xB2D40 Offset: 0xB2140 VA: 0x1800B2D40
	public float Bias; // 0x48
	[TooltipAttribute] // RVA: 0xB2F70 Offset: 0xB2370 VA: 0x1800B2F70
	[RangeAttribute] // RVA: 0xB2F70 Offset: 0xB2370 VA: 0x1800B2F70
	public float Thickness; // 0x4C
	[TooltipAttribute] // RVA: 0xB2FD0 Offset: 0xB23D0 VA: 0x1800B2FD0
	public bool Downsample; // 0x50
	[HeaderAttribute] // RVA: 0xB3110 Offset: 0xB2510 VA: 0x1800B3110
	[TooltipAttribute] // RVA: 0xB3110 Offset: 0xB2510 VA: 0x1800B3110
	public bool FadeEnabled; // 0x51
	[TooltipAttribute] // RVA: 0xB31C0 Offset: 0xB25C0 VA: 0x1800B31C0
	public float FadeStart; // 0x54
	[TooltipAttribute] // RVA: 0xB3300 Offset: 0xB2700 VA: 0x1800B3300
	public float FadeLength; // 0x58
	[TooltipAttribute] // RVA: 0xB3490 Offset: 0xB2890 VA: 0x1800B3490
	[RangeAttribute] // RVA: 0xB3490 Offset: 0xB2890 VA: 0x1800B3490
	public float FadeToIntensity; // 0x5C
	public Color FadeToTint; // 0x60
	[TooltipAttribute] // RVA: 0xB3550 Offset: 0xB2950 VA: 0x1800B3550
	[RangeAttribute] // RVA: 0xB3550 Offset: 0xB2950 VA: 0x1800B3550
	public float FadeToRadius; // 0x70
	[TooltipAttribute] // RVA: 0xB36C0 Offset: 0xB2AC0 VA: 0x1800B36C0
	[RangeAttribute] // RVA: 0xB36C0 Offset: 0xB2AC0 VA: 0x1800B36C0
	public float FadeToPowerExponent; // 0x74
	[TooltipAttribute] // RVA: 0xB37B0 Offset: 0xB2BB0 VA: 0x1800B37B0
	[RangeAttribute] // RVA: 0xB37B0 Offset: 0xB2BB0 VA: 0x1800B37B0
	public float FadeToThickness; // 0x78
	[HeaderAttribute] // RVA: 0xB39E0 Offset: 0xB2DE0 VA: 0x1800B39E0
	public bool BlurEnabled; // 0x7C
	[TooltipAttribute] // RVA: 0xB3B00 Offset: 0xB2F00 VA: 0x1800B3B00
	[RangeAttribute] // RVA: 0xB3B00 Offset: 0xB2F00 VA: 0x1800B3B00
	public int BlurRadius; // 0x80
	[TooltipAttribute] // RVA: 0xB3DD0 Offset: 0xB31D0 VA: 0x1800B3DD0
	[RangeAttribute] // RVA: 0xB3DD0 Offset: 0xB31D0 VA: 0x1800B3DD0
	public int BlurPasses; // 0x84
	[TooltipAttribute] // RVA: 0xB3EC0 Offset: 0xB32C0 VA: 0x1800B3EC0
	[RangeAttribute] // RVA: 0xB3EC0 Offset: 0xB32C0 VA: 0x1800B3EC0
	public float BlurSharpness; // 0x88
	[HeaderAttribute] // RVA: 0xB3FA0 Offset: 0xB33A0 VA: 0x1800B3FA0
	[TooltipAttribute] // RVA: 0xB3FA0 Offset: 0xB33A0 VA: 0x1800B3FA0
	public bool FilterEnabled; // 0x8C
	[TooltipAttribute] // RVA: 0xB40A0 Offset: 0xB34A0 VA: 0x1800B40A0
	[RangeAttribute] // RVA: 0xB40A0 Offset: 0xB34A0 VA: 0x1800B40A0
	public float FilterBlending; // 0x90
	[TooltipAttribute] // RVA: 0xB4270 Offset: 0xB3670 VA: 0x1800B4270
	[RangeAttribute] // RVA: 0xB4270 Offset: 0xB3670 VA: 0x1800B4270
	public float FilterResponse; // 0x94
	[TooltipAttribute] // RVA: 0xB4430 Offset: 0xB3830 VA: 0x1800B4430
	public bool TemporalDirections; // 0x98
	[TooltipAttribute] // RVA: 0xB44F0 Offset: 0xB38F0 VA: 0x1800B44F0
	public bool TemporalOffsets; // 0x99
	[TooltipAttribute] // RVA: 0xB4540 Offset: 0xB3940 VA: 0x1800B4540
	public bool TemporalDilation; // 0x9A
	[TooltipAttribute] // RVA: 0xB4570 Offset: 0xB3970 VA: 0x1800B4570
	public bool UseMotionVectors; // 0x9B
	private AmplifyOcclusionBase.PerPixelNormalSource m_prevPerPixelNormals; // 0x9C
	private AmplifyOcclusionBase.ApplicationMethod m_prevApplyMethod; // 0xA0
	private bool m_prevDeferredReflections; // 0xA4
	private AmplifyOcclusionBase.SampleCountLevel m_prevSampleCount; // 0xA8
	private bool m_prevDownsample; // 0xAC
	private bool m_prevBlurEnabled; // 0xAD
	private int m_prevBlurRadius; // 0xB0
	private int m_prevBlurPasses; // 0xB4
	private Camera m_targetCamera; // 0xB8
	private RenderTargetIdentifier[] applyDebugTargetsTemporal; // 0xC0
	private RenderTargetIdentifier[] applyPostEffectTargetsTemporal; // 0xC8
	private RenderTargetIdentifier[] applyDeferredTargets_Log_Temporal; // 0xD0
	private RenderTargetIdentifier[] applyDeferredTargetsTemporal; // 0xD8
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Occlusion; // 0xE0
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Apply; // 0xF8
	private static Mesh m_quadMesh; // 0x0
	private static Material m_occlusionMat; // 0x8
	private static Material m_blurMat; // 0x10
	private static Material m_applyOcclusionMat; // 0x18
	private RenderTextureFormat m_occlusionRTFormat; // 0x110
	private RenderTextureFormat m_accumTemporalRTFormat; // 0x114
	private RenderTextureFormat m_temporaryEmissionRTFormat; // 0x118
	private bool m_paramsChanged; // 0x11C
	private RenderTexture m_occlusionDepthRT; // 0x120
	private RenderTexture[] m_temporalAccumRT; // 0x128
	private uint m_sampleStep; // 0x130
	private uint m_curStepIdx; // 0x134
	private static readonly uint m_maxSampleSteps; // 0x20
	private static readonly int PerPixelNormalSourceCount; // 0x24
	private Matrix4x4 m_prevViewProjMatrixLeft; // 0x138
	private Matrix4x4 m_prevInvViewProjMatrixLeft; // 0x178
	private Matrix4x4 m_prevViewProjMatrixRight; // 0x1B8
	private Matrix4x4 m_prevInvViewProjMatrixRight; // 0x1F8
	private static readonly float[] m_temporalRotations; // 0x28
	private static readonly float[] m_spatialOffsets; // 0x30
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets; // 0x238
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets_Log; // 0x240
	private AmplifyOcclusionBase.TargetDesc m_target; // 0x248

	// Methods

	// RVA: 0x827760 Offset: 0x825D60 VA: 0x180827760
	private void createCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent) { }

	// RVA: 0x825710 Offset: 0x823D10 VA: 0x180825710
	private void cleanupCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer) { }

	// RVA: 0x8279B0 Offset: 0x825FB0 VA: 0x1808279B0
	private void createQuadMesh() { }

	// RVA: 0x823D30 Offset: 0x822330 VA: 0x180823D30
	private void PerformBlit(CommandBuffer cb, Material mat, int pass) { }

	// RVA: 0x827840 Offset: 0x825E40 VA: 0x180827840
	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg) { }

	// RVA: 0x8250C0 Offset: 0x8236C0 VA: 0x1808250C0
	private void checkMaterials(bool aThroughErrorMsg) { }

	// RVA: 0x825690 Offset: 0x823C90 VA: 0x180825690
	private bool checkRenderTextureFormats() { }

	// RVA: 0x823740 Offset: 0x821D40 VA: 0x180823740
	private void OnEnable() { }

	// RVA: 0x8236F0 Offset: 0x821CF0 VA: 0x1808236F0
	private void Reset() { }

	// RVA: 0x8236F0 Offset: 0x821CF0 VA: 0x1808236F0
	private void OnDisable() { }

	// RVA: 0x827EE0 Offset: 0x8264E0 VA: 0x180827EE0
	private void releaseRT() { }

	// RVA: 0x825330 Offset: 0x823930 VA: 0x180825330
	private bool checkParamsChanged() { }

	// RVA: 0x828250 Offset: 0x826850 VA: 0x180828250
	private void updateParams() { }

	// RVA: 0x824920 Offset: 0x822F20 VA: 0x180824920
	private void Update() { }

	// RVA: 0x8238E0 Offset: 0x821EE0 VA: 0x1808238E0
	private void OnPreRender() { }

	// RVA: 0x823850 Offset: 0x821E50 VA: 0x180823850
	private void OnPostRender() { }

	// RVA: 0x8280E0 Offset: 0x8266E0 VA: 0x1808280E0
	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = 7, RenderTextureReadWrite readWrite = 0, FilterMode filterMode = 0) { }

	// RVA: 0x828220 Offset: 0x826820 VA: 0x180828220
	private void safeReleaseTemporaryRT(CommandBuffer cb, int id) { }

	// RVA: 0x827FB0 Offset: 0x8265B0 VA: 0x180827FB0
	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = 0) { }

	// RVA: 0x828160 Offset: 0x826760 VA: 0x180828160
	private void safeReleaseRT(ref RenderTexture rt) { }

	// RVA: 0x823690 Offset: 0x821C90 VA: 0x180823690
	private void BeginSample(CommandBuffer cb, string name) { }

	// RVA: 0x8236C0 Offset: 0x821CC0 VA: 0x1808236C0
	private void EndSample(CommandBuffer cb, string name) { }

	// RVA: 0x826C10 Offset: 0x825210 VA: 0x180826C10
	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb) { }

	// RVA: 0x825830 Offset: 0x823E30 VA: 0x180825830
	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight) { }

	// RVA: 0x827EC0 Offset: 0x8264C0 VA: 0x180827EC0
	private int getTemporalPass() { }

	// RVA: 0x827320 Offset: 0x825920 VA: 0x180827320
	private void commandBuffer_TemporalFilter(CommandBuffer cb) { }

	// RVA: 0x825EA0 Offset: 0x8244A0 VA: 0x180825EA0
	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget) { }

	// RVA: 0x8268A0 Offset: 0x824EA0 VA: 0x1808268A0
	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb) { }

	// RVA: 0x825B30 Offset: 0x824130 VA: 0x180825B30
	private void commandBuffer_FillApplyDebug(CommandBuffer cb) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool isStereoSinglePassEnabled() { }

	// RVA: 0x8243D0 Offset: 0x8229D0 VA: 0x1808243D0
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0x823E40 Offset: 0x822440 VA: 0x180823E40
	private void UpdateGlobalShaderConstants_AmbientOcclusion() { }

	// RVA: 0x824020 Offset: 0x822620 VA: 0x180824020
	private void UpdateGlobalShaderConstants_Matrices() { }

	// RVA: 0x824CA0 Offset: 0x8232A0 VA: 0x180824CA0
	public void .ctor() { }

	// RVA: 0x824B50 Offset: 0x823150 VA: 0x180824B50
	private static void .cctor() { }

}

public enum AmplifyOcclusionBase.ApplicationMethod // TypeDefIndex: 11469
{	// Fields
	public int value__; // 0x0
	public const AmplifyOcclusionBase.ApplicationMethod PostEffect = 0;
	public const AmplifyOcclusionBase.ApplicationMethod Deferred = 1;
	public const AmplifyOcclusionBase.ApplicationMethod Debug = 2;

}

public enum AmplifyOcclusionBase.PerPixelNormalSource // TypeDefIndex: 11470
{	// Fields
	public int value__; // 0x0
	public const AmplifyOcclusionBase.PerPixelNormalSource None = 0;
	public const AmplifyOcclusionBase.PerPixelNormalSource Camera = 1;
	public const AmplifyOcclusionBase.PerPixelNormalSource GBuffer = 2;
	public const AmplifyOcclusionBase.PerPixelNormalSource GBufferOctaEncoded = 3;

}

public enum AmplifyOcclusionBase.SampleCountLevel // TypeDefIndex: 11471
{	// Fields
	public int value__; // 0x0
	public const AmplifyOcclusionBase.SampleCountLevel Low = 0;
	public const AmplifyOcclusionBase.SampleCountLevel Medium = 1;
	public const AmplifyOcclusionBase.SampleCountLevel High = 2;
	public const AmplifyOcclusionBase.SampleCountLevel VeryHigh = 3;

}

private struct AmplifyOcclusionBase.CmdBuffer // TypeDefIndex: 11472
{	// Fields
	public CommandBuffer cmdBuffer; // 0x0
	public CameraEvent cmdBufferEvent; // 0x8
	public string cmdBufferName; // 0x10

}

private struct AmplifyOcclusionBase.TargetDesc // TypeDefIndex: 11473
{	// Fields
	public int fullWidth; // 0x0
	public int fullHeight; // 0x4
	public RenderTextureFormat format; // 0x8
	public int width; // 0xC
	public int height; // 0x10
	public float oneOverWidth; // 0x14
	public float oneOverHeight; // 0x18

}

private static class AmplifyOcclusionBase.ShaderPass // TypeDefIndex: 11474
{	// Fields
	public const int CombineDownsampledOcclusionDepth = 16;
	public const int CombineEmission = 17;
	public const int CombineEmissionLog = 18;
	public const int BlurHorizontal1 = 0;
	public const int BlurVertical1 = 1;
	public const int BlurHorizontal2 = 2;
	public const int BlurVertical2 = 3;
	public const int BlurHorizontal3 = 4;
	public const int BlurVertical3 = 5;
	public const int BlurHorizontal4 = 6;
	public const int BlurVertical4 = 7;
	public const int ApplyDebug = 0;
	public const int ApplyDebugTemporal = 1;
	public const int ApplyDeferred = 5;
	public const int ApplyDeferredTemporal = 6;
	public const int ApplyDeferredLog = 10;
	public const int ApplyDeferredLogTemporal = 11;
	public const int ApplyPostEffect = 15;
	public const int ApplyPostEffectTemporal = 16;
	public const int ApplyPostEffectTemporalMultiply = 20;
	public const int OcclusionLow_None = 0;
	public const int OcclusionLow_Camera = 1;
	public const int OcclusionLow_GBuffer = 2;
	public const int OcclusionLow_GBufferOctaEncoded = 3;

}

private static class AmplifyOcclusionBase.PropertyID // TypeDefIndex: 11475
{	// Fields
	public static readonly int _AO_Radius; // 0x0
	public static readonly int _AO_PixelRadiusLimit; // 0x4
	public static readonly int _AO_RadiusIntensity; // 0x8
	public static readonly int _AO_PowExponent; // 0xC
	public static readonly int _AO_Bias; // 0x10
	public static readonly int _AO_Levels; // 0x14
	public static readonly int _AO_ThicknessDecay; // 0x18
	public static readonly int _AO_BlurSharpness; // 0x1C
	public static readonly int _AO_CameraViewLeft; // 0x20
	public static readonly int _AO_CameraViewRight; // 0x24
	public static readonly int _AO_ProjMatrixLeft; // 0x28
	public static readonly int _AO_ProjMatrixRight; // 0x2C
	public static readonly int _AO_InvViewProjMatrixLeft; // 0x30
	public static readonly int _AO_PrevViewProjMatrixLeft; // 0x34
	public static readonly int _AO_PrevInvViewProjMatrixLeft; // 0x38
	public static readonly int _AO_InvViewProjMatrixRight; // 0x3C
	public static readonly int _AO_PrevViewProjMatrixRight; // 0x40
	public static readonly int _AO_PrevInvViewProjMatrixRight; // 0x44
	public static readonly int _AO_GBufferNormals; // 0x48
	public static readonly int _AO_Target_TexelSize; // 0x4C
	public static readonly int _AO_TemporalCurveAdj; // 0x50
	public static readonly int _AO_TemporalMotionSensibility; // 0x54
	public static readonly int _AO_CurrOcclusionDepth; // 0x58
	public static readonly int _AO_TemporalAccumm; // 0x5C
	public static readonly int _AO_TemporalDirections; // 0x60
	public static readonly int _AO_TemporalOffsets; // 0x64
	public static readonly int _AO_OcclusionTexture; // 0x68
	public static readonly int _AO_GBufferAlbedo; // 0x6C
	public static readonly int _AO_GBufferEmission; // 0x70
	public static readonly int _AO_UVToView; // 0x74
	public static readonly int _AO_HalfProjScale; // 0x78
	public static readonly int _AO_FadeParams; // 0x7C
	public static readonly int _AO_FadeValues; // 0x80
	public static readonly int _AO_FadeToTint; // 0x84
	public static readonly int _AO_Source_TexelSize; // 0x88
	public static readonly int _AO_Source; // 0x8C

	// Methods

	// RVA: 0x83C870 Offset: 0x83AE70 VA: 0x18083C870
	private static void .cctor() { }

}

