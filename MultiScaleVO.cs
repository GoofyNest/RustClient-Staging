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

	// RVA: 0x101EA80 Offset: 0x101D080 VA: 0x18101EA80
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void SetResources(PostProcessResources resources) { }

	// RVA: 0x101A940 Offset: 0x1018F40 VA: 0x18101A940
	private void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

	// RVA: 0x101A7D0 Offset: 0x1018DD0 VA: 0x18101A7D0
	private void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

	// RVA: 0x828330 Offset: 0x826930 VA: 0x180828330
	private void Release(CommandBuffer cmd, int id) { }

	// RVA: 0x101AB20 Offset: 0x1019120 VA: 0x18101AB20
	private Vector4 CalculateZBufferParams(Camera camera) { }

	// RVA: 0x101AAB0 Offset: 0x10190B0 VA: 0x18101AAB0
	private float CalculateTanHalfFovHeight(Camera camera) { }

	// RVA: 0x101C060 Offset: 0x101A660 VA: 0x18101C060
	private Vector2 GetSize(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x101BFD0 Offset: 0x101A5D0 VA: 0x18101BFD0
	private Vector3 GetSizeArray(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x101AFD0 Offset: 0x10195D0 VA: 0x18101AFD0
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA) { }

	// RVA: 0x101C270 Offset: 0x101A870 VA: 0x18101C270
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA) { }

	// RVA: 0x101C8B0 Offset: 0x101AEB0 VA: 0x18101C8B0
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA) { }

	// RVA: 0x101D420 Offset: 0x101BA20 VA: 0x18101D420
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

	// RVA: 0x101DE30 Offset: 0x101C430 VA: 0x18101DE30
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<int> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = False) { }

	// RVA: 0x101D200 Offset: 0x101B800 VA: 0x18101D200
	private void PushReleaseCommands(CommandBuffer cmd) { }

	// RVA: 0x101C0F0 Offset: 0x101A6F0 VA: 0x18101C0F0
	private void PreparePropertySheet(PostProcessRenderContext context) { }

	// RVA: 0x101ABC0 Offset: 0x10191C0 VA: 0x18101ABC0
	private void CheckAOTexture(PostProcessRenderContext context) { }

	// RVA: 0x101C800 Offset: 0x101AE00 VA: 0x18101C800
	private void PushDebug(PostProcessRenderContext context) { }

	// RVA: 0x101E420 Offset: 0x101CA20 VA: 0x18101E420 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x101E8C0 Offset: 0x101CEC0 VA: 0x18101E8C0 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x101AD80 Offset: 0x1019380 VA: 0x18101AD80 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x101E3A0 Offset: 0x101C9A0 VA: 0x18101E3A0 Slot: 8
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

