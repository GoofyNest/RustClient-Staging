public class AmplifyOcclusionBase : MonoBehaviour // TypeDefIndex: 11472
{	[HeaderAttribute] // RVA: 0xB0BC0 Offset: 0xAFFC0 VA: 0x1800B0BC0
	public AmplifyOcclusionBase.ApplicationMethod ApplyMethod; // 0x18
	[TooltipAttribute] // RVA: 0xB0C90 Offset: 0xB0090 VA: 0x1800B0C90
	public AmplifyOcclusionBase.SampleCountLevel SampleCount; // 0x1C
	public AmplifyOcclusionBase.PerPixelNormalSource PerPixelNormals; // 0x20
	[TooltipAttribute] // RVA: 0xB0D30 Offset: 0xB0130 VA: 0x1800B0D30
	[RangeAttribute] // RVA: 0xB0D30 Offset: 0xB0130 VA: 0x1800B0D30
	public float Intensity; // 0x24
	public Color Tint; // 0x28
	[TooltipAttribute] // RVA: 0xB20F0 Offset: 0xB14F0 VA: 0x1800B20F0
	[RangeAttribute] // RVA: 0xB20F0 Offset: 0xB14F0 VA: 0x1800B20F0
	public float Radius; // 0x38
	[TooltipAttribute] // RVA: 0xB22D0 Offset: 0xB16D0 VA: 0x1800B22D0
	[RangeAttribute] // RVA: 0xB22D0 Offset: 0xB16D0 VA: 0x1800B22D0
	public int PixelRadiusLimit; // 0x3C
	[TooltipAttribute] // RVA: 0xB2570 Offset: 0xB1970 VA: 0x1800B2570
	[RangeAttribute] // RVA: 0xB2570 Offset: 0xB1970 VA: 0x1800B2570
	public float RadiusIntensity; // 0x40
	[TooltipAttribute] // RVA: 0xB2690 Offset: 0xB1A90 VA: 0x1800B2690
	[RangeAttribute] // RVA: 0xB2690 Offset: 0xB1A90 VA: 0x1800B2690
	public float PowerExponent; // 0x44
	[TooltipAttribute] // RVA: 0xB2830 Offset: 0xB1C30 VA: 0x1800B2830
	[RangeAttribute] // RVA: 0xB2830 Offset: 0xB1C30 VA: 0x1800B2830
	public float Bias; // 0x48
	[TooltipAttribute] // RVA: 0xB2A80 Offset: 0xB1E80 VA: 0x1800B2A80
	[RangeAttribute] // RVA: 0xB2A80 Offset: 0xB1E80 VA: 0x1800B2A80
	public float Thickness; // 0x4C
	[TooltipAttribute] // RVA: 0xB2C80 Offset: 0xB2080 VA: 0x1800B2C80
	public bool Downsample; // 0x50
	[HeaderAttribute] // RVA: 0xB2E10 Offset: 0xB2210 VA: 0x1800B2E10
	[TooltipAttribute] // RVA: 0xB2E10 Offset: 0xB2210 VA: 0x1800B2E10
	public bool FadeEnabled; // 0x51
	[TooltipAttribute] // RVA: 0xB2F30 Offset: 0xB2330 VA: 0x1800B2F30
	public float FadeStart; // 0x54
	[TooltipAttribute] // RVA: 0xB3070 Offset: 0xB2470 VA: 0x1800B3070
	public float FadeLength; // 0x58
	[TooltipAttribute] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	[RangeAttribute] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	public float FadeToIntensity; // 0x5C
	public Color FadeToTint; // 0x60
	[TooltipAttribute] // RVA: 0xB3190 Offset: 0xB2590 VA: 0x1800B3190
	[RangeAttribute] // RVA: 0xB3190 Offset: 0xB2590 VA: 0x1800B3190
	public float FadeToRadius; // 0x70
	[TooltipAttribute] // RVA: 0xB3350 Offset: 0xB2750 VA: 0x1800B3350
	[RangeAttribute] // RVA: 0xB3350 Offset: 0xB2750 VA: 0x1800B3350
	public float FadeToPowerExponent; // 0x74
	[TooltipAttribute] // RVA: 0xB34B0 Offset: 0xB28B0 VA: 0x1800B34B0
	[RangeAttribute] // RVA: 0xB34B0 Offset: 0xB28B0 VA: 0x1800B34B0
	public float FadeToThickness; // 0x78
	[HeaderAttribute] // RVA: 0xB36A0 Offset: 0xB2AA0 VA: 0x1800B36A0
	public bool BlurEnabled; // 0x7C
	[TooltipAttribute] // RVA: 0xB3700 Offset: 0xB2B00 VA: 0x1800B3700
	[RangeAttribute] // RVA: 0xB3700 Offset: 0xB2B00 VA: 0x1800B3700
	public int BlurRadius; // 0x80
	[TooltipAttribute] // RVA: 0xB3900 Offset: 0xB2D00 VA: 0x1800B3900
	[RangeAttribute] // RVA: 0xB3900 Offset: 0xB2D00 VA: 0x1800B3900
	public int BlurPasses; // 0x84
	[TooltipAttribute] // RVA: 0xB39C0 Offset: 0xB2DC0 VA: 0x1800B39C0
	[RangeAttribute] // RVA: 0xB39C0 Offset: 0xB2DC0 VA: 0x1800B39C0
	public float BlurSharpness; // 0x88
	[HeaderAttribute] // RVA: 0xB3B90 Offset: 0xB2F90 VA: 0x1800B3B90
	[TooltipAttribute] // RVA: 0xB3B90 Offset: 0xB2F90 VA: 0x1800B3B90
	public bool FilterEnabled; // 0x8C
	[TooltipAttribute] // RVA: 0xB3D90 Offset: 0xB3190 VA: 0x1800B3D90
	[RangeAttribute] // RVA: 0xB3D90 Offset: 0xB3190 VA: 0x1800B3D90
	public float FilterBlending; // 0x90
	[TooltipAttribute] // RVA: 0xB4060 Offset: 0xB3460 VA: 0x1800B4060
	[RangeAttribute] // RVA: 0xB4060 Offset: 0xB3460 VA: 0x1800B4060
	public float FilterResponse; // 0x94
	[TooltipAttribute] // RVA: 0xB4180 Offset: 0xB3580 VA: 0x1800B4180
	public bool TemporalDirections; // 0x98
	[TooltipAttribute] // RVA: 0xB4260 Offset: 0xB3660 VA: 0x1800B4260
	public bool TemporalOffsets; // 0x99
	[TooltipAttribute] // RVA: 0xB42E0 Offset: 0xB36E0 VA: 0x1800B42E0
	public bool TemporalDilation; // 0x9A
	[TooltipAttribute] // RVA: 0xB43A0 Offset: 0xB37A0 VA: 0x1800B43A0
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


	private void createCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent) { }

	private void cleanupCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer) { }

	private void createQuadMesh() { }

	private void PerformBlit(CommandBuffer cb, Material mat, int pass) { }

	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg) { }

	private void checkMaterials(bool aThroughErrorMsg) { }

	private bool checkRenderTextureFormats() { }

	private void OnEnable() { }

	private void Reset() { }

	private void OnDisable() { }

	private void releaseRT() { }

	private bool checkParamsChanged() { }

	private void updateParams() { }

	private void Update() { }

	private void OnPreRender() { }

	private void OnPostRender() { }

	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = 7, RenderTextureReadWrite readWrite = 0, FilterMode filterMode = 0) { }

	private void safeReleaseTemporaryRT(CommandBuffer cb, int id) { }

	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = 0) { }

	private void safeReleaseRT(ref RenderTexture rt) { }

	private void BeginSample(CommandBuffer cb, string name) { }

	private void EndSample(CommandBuffer cb, string name) { }

	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb) { }

	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight) { }

	private int getTemporalPass() { }

	private void commandBuffer_TemporalFilter(CommandBuffer cb) { }

	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget) { }

	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb) { }

	private void commandBuffer_FillApplyDebug(CommandBuffer cb) { }

	private bool isStereoSinglePassEnabled() { }

	private void UpdateGlobalShaderConstants() { }

	private void UpdateGlobalShaderConstants_AmbientOcclusion() { }

	private void UpdateGlobalShaderConstants_Matrices() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum AmplifyOcclusionBase.ApplicationMethod // TypeDefIndex: 11473
{	public int value__; // 0x0
	public const AmplifyOcclusionBase.ApplicationMethod PostEffect = 0;
	public const AmplifyOcclusionBase.ApplicationMethod Deferred = 1;
	public const AmplifyOcclusionBase.ApplicationMethod Debug = 2;

}

public enum AmplifyOcclusionBase.PerPixelNormalSource // TypeDefIndex: 11474
{	public int value__; // 0x0
	public const AmplifyOcclusionBase.PerPixelNormalSource None = 0;
	public const AmplifyOcclusionBase.PerPixelNormalSource Camera = 1;
	public const AmplifyOcclusionBase.PerPixelNormalSource GBuffer = 2;
	public const AmplifyOcclusionBase.PerPixelNormalSource GBufferOctaEncoded = 3;

}

public enum AmplifyOcclusionBase.SampleCountLevel // TypeDefIndex: 11475
{	public int value__; // 0x0
	public const AmplifyOcclusionBase.SampleCountLevel Low = 0;
	public const AmplifyOcclusionBase.SampleCountLevel Medium = 1;
	public const AmplifyOcclusionBase.SampleCountLevel High = 2;
	public const AmplifyOcclusionBase.SampleCountLevel VeryHigh = 3;

}

private struct AmplifyOcclusionBase.CmdBuffer // TypeDefIndex: 11476
{	public CommandBuffer cmdBuffer; // 0x0
	public CameraEvent cmdBufferEvent; // 0x8
	public string cmdBufferName; // 0x10

}

private struct AmplifyOcclusionBase.TargetDesc // TypeDefIndex: 11477
{	public int fullWidth; // 0x0
	public int fullHeight; // 0x4
	public RenderTextureFormat format; // 0x8
	public int width; // 0xC
	public int height; // 0x10
	public float oneOverWidth; // 0x14
	public float oneOverHeight; // 0x18

}

private static class AmplifyOcclusionBase.ShaderPass // TypeDefIndex: 11478
{	public const int CombineDownsampledOcclusionDepth = 16;
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

private static class AmplifyOcclusionBase.PropertyID // TypeDefIndex: 11479
{	public static readonly int _AO_Radius; // 0x0
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


	private static void .cctor() { }

}

