internal sealed class MultiScaleVO : IAmbientOcclusionMethod // TypeDefIndex: 11795
{	// Fields
	private readonly float[] m_SampleThickness; // 0x10
	private readonly float[] m_InvThicknessTable; // 0x18
	private readonly float[] m_SampleWeightTable; // 0x20
	private readonly int[] m_Widths; // 0x28
	private readonly int[] m_Heights; // 0x30
	private AmbientOcclusion m_Settings; // 0x38
	private PropertySheet m_PropertySheet; // 0x40
	private PostProcessResources m_Resources; // 0x48
	private RenderTexture m_AmbientOnlyAO; // 0x50
	private readonly RenderTargetIdentifier[] m_MRT; // 0x58

	// Methods

	// RVA: 0x101E7C0 Offset: 0x101CDC0 VA: 0x18101E7C0
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void SetResources(PostProcessResources resources) { }

	// RVA: 0x101A680 Offset: 0x1018C80 VA: 0x18101A680
	private void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

	// RVA: 0x101A510 Offset: 0x1018B10 VA: 0x18101A510
	private void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

	// RVA: 0x828220 Offset: 0x826820 VA: 0x180828220
	private void Release(CommandBuffer cmd, int id) { }

	// RVA: 0x101A860 Offset: 0x1018E60 VA: 0x18101A860
	private Vector4 CalculateZBufferParams(Camera camera) { }

	// RVA: 0x101A7F0 Offset: 0x1018DF0 VA: 0x18101A7F0
	private float CalculateTanHalfFovHeight(Camera camera) { }

	// RVA: 0x101BDA0 Offset: 0x101A3A0 VA: 0x18101BDA0
	private Vector2 GetSize(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x101BD10 Offset: 0x101A310 VA: 0x18101BD10
	private Vector3 GetSizeArray(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x101AD10 Offset: 0x1019310 VA: 0x18101AD10
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA) { }

	// RVA: 0x101BFB0 Offset: 0x101A5B0 VA: 0x18101BFB0
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA) { }

	// RVA: 0x101C5F0 Offset: 0x101ABF0 VA: 0x18101C5F0
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA) { }

	// RVA: 0x101D160 Offset: 0x101B760 VA: 0x18101D160
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

	// RVA: 0x101DB70 Offset: 0x101C170 VA: 0x18101DB70
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<int> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = False) { }

	// RVA: 0x101CF40 Offset: 0x101B540 VA: 0x18101CF40
	private void PushReleaseCommands(CommandBuffer cmd) { }

	// RVA: 0x101BE30 Offset: 0x101A430 VA: 0x18101BE30
	private void PreparePropertySheet(PostProcessRenderContext context) { }

	// RVA: 0x101A900 Offset: 0x1018F00 VA: 0x18101A900
	private void CheckAOTexture(PostProcessRenderContext context) { }

	// RVA: 0x101C540 Offset: 0x101AB40 VA: 0x18101C540
	private void PushDebug(PostProcessRenderContext context) { }

	// RVA: 0x101E160 Offset: 0x101C760 VA: 0x18101E160 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x101E600 Offset: 0x101CC00 VA: 0x18101E600 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x101AAC0 Offset: 0x10190C0 VA: 0x18101AAC0 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x101E0E0 Offset: 0x101C6E0 VA: 0x18101E0E0 Slot: 8
	public void Release() { }

}

internal enum MultiScaleVO.MipLevel // TypeDefIndex: 11796
{	// Fields
	public int value__; // 0x0
	public const MultiScaleVO.MipLevel Original = 0;
	public const MultiScaleVO.MipLevel L1 = 1;
	public const MultiScaleVO.MipLevel L2 = 2;
	public const MultiScaleVO.MipLevel L3 = 3;
	public const MultiScaleVO.MipLevel L4 = 4;
	public const MultiScaleVO.MipLevel L5 = 5;
	public const MultiScaleVO.MipLevel L6 = 6;

}

private enum MultiScaleVO.Pass // TypeDefIndex: 11797
{	// Fields
	public int value__; // 0x0
	public const MultiScaleVO.Pass DepthCopy = 0;
	public const MultiScaleVO.Pass CompositionDeferred = 1;
	public const MultiScaleVO.Pass CompositionForward = 2;
	public const MultiScaleVO.Pass DebugOverlay = 3;

}

