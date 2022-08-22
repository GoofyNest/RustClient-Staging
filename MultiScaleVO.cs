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

	// RVA: 0x101F520 Offset: 0x101DB20 VA: 0x18101F520
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	public void SetResources(PostProcessResources resources) { }

	// RVA: 0x101B3E0 Offset: 0x10199E0 VA: 0x18101B3E0
	private void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

	// RVA: 0x101B270 Offset: 0x1019870 VA: 0x18101B270
	private void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

	// RVA: 0x8288C0 Offset: 0x826EC0 VA: 0x1808288C0
	private void Release(CommandBuffer cmd, int id) { }

	// RVA: 0x101B5C0 Offset: 0x1019BC0 VA: 0x18101B5C0
	private Vector4 CalculateZBufferParams(Camera camera) { }

	// RVA: 0x101B550 Offset: 0x1019B50 VA: 0x18101B550
	private float CalculateTanHalfFovHeight(Camera camera) { }

	// RVA: 0x101CB00 Offset: 0x101B100 VA: 0x18101CB00
	private Vector2 GetSize(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x101CA70 Offset: 0x101B070 VA: 0x18101CA70
	private Vector3 GetSizeArray(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x101BA70 Offset: 0x101A070 VA: 0x18101BA70
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA) { }

	// RVA: 0x101CD10 Offset: 0x101B310 VA: 0x18101CD10
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA) { }

	// RVA: 0x101D350 Offset: 0x101B950 VA: 0x18101D350
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA) { }

	// RVA: 0x101DEC0 Offset: 0x101C4C0 VA: 0x18101DEC0
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

	// RVA: 0x101E8D0 Offset: 0x101CED0 VA: 0x18101E8D0
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<int> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = False) { }

	// RVA: 0x101DCA0 Offset: 0x101C2A0 VA: 0x18101DCA0
	private void PushReleaseCommands(CommandBuffer cmd) { }

	// RVA: 0x101CB90 Offset: 0x101B190 VA: 0x18101CB90
	private void PreparePropertySheet(PostProcessRenderContext context) { }

	// RVA: 0x101B660 Offset: 0x1019C60 VA: 0x18101B660
	private void CheckAOTexture(PostProcessRenderContext context) { }

	// RVA: 0x101D2A0 Offset: 0x101B8A0 VA: 0x18101D2A0
	private void PushDebug(PostProcessRenderContext context) { }

	// RVA: 0x101EEC0 Offset: 0x101D4C0 VA: 0x18101EEC0 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x101F360 Offset: 0x101D960 VA: 0x18101F360 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x101B820 Offset: 0x1019E20 VA: 0x18101B820 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x101EE40 Offset: 0x101D440 VA: 0x18101EE40 Slot: 8
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

