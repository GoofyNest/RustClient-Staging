public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 6867
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_hasFontAssetChanged; // 0xAD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_SubMeshUI[] m_subTextObjects; // 0xAD8
	private float m_previousLossyScaleY; // 0xAE0
	private Vector3[] m_RectTransformCorners; // 0xAE8
	private CanvasRenderer m_canvasRenderer; // 0xAF0
	private Canvas m_canvas; // 0xAF8
	private bool m_isFirstAllocation; // 0xB00
	private int m_max_characters; // 0xB04
	private bool m_isMaskingEnabled; // 0xB08
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material m_baseMaterial; // 0xB10
	private bool m_isScrollRegionSet; // 0xB18
	private int m_stencilID; // 0xB1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector4 m_maskOffset; // 0xB20
	private Matrix4x4 m_EnvMapMatrix; // 0xB30
	private bool m_isRegisteredForEvents; // 0xB70
	private int m_recursiveCountA; // 0xB74
	private int loopCountA; // 0xB78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <blockRectTransformChange>k__BackingField; // 0xB7C
	private bool m_isRebuildingLayout; // 0xB7D

	// Properties
	public bool blockRectTransformChange { get; set; }
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }

	// Methods

	// RVA: 0x19F1400 Offset: 0x19EFA00 VA: 0x1819F1400 Slot: 4
	protected override void Awake() { }

	// RVA: 0x19FEFB0 Offset: 0x19FD5B0 VA: 0x1819FEFB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x19FEDD0 Offset: 0x19FD3D0 VA: 0x1819FEDD0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x19FEC20 Offset: 0x19FD220 VA: 0x1819FEC20 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x19FE4C0 Offset: 0x19FCAC0 VA: 0x1819FE4C0 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x19FD1E0 Offset: 0x19FB7E0 VA: 0x1819FD1E0
	private Canvas GetCanvas() { }

	// RVA: 0x19F1D70 Offset: 0x19F0370 VA: 0x1819F1D70
	private void EnableMasking() { }

	// RVA: 0x19F1C20 Offset: 0x19F0220 VA: 0x1819F1C20
	private void DisableMasking() { }

	// RVA: 0x1A029F0 Offset: 0x1A00FF0 VA: 0x181A029F0
	private void UpdateMask() { }

	// RVA: 0x19FD810 Offset: 0x19FBE10 VA: 0x1819FD810 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x19FD990 Offset: 0x19FBF90 VA: 0x1819FD990 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1172B80 Offset: 0x1171180 VA: 0x181172B80 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x19FDE90 Offset: 0x19FC490 VA: 0x1819FDE90 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1A022F0 Offset: 0x1A008F0 VA: 0x181A022F0 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1A01E70 Offset: 0x1A00470 VA: 0x181A01E70 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1A01950 Offset: 0x19FFF50 VA: 0x181A01950 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1A01D10 Offset: 0x1A00310 VA: 0x181A01D10 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1A02180 Offset: 0x1A00780 VA: 0x181A02180 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x1A01560 Offset: 0x19FFB60 VA: 0x181A01560 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x1A020B0 Offset: 0x1A006B0 VA: 0x181A020B0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x19FDCE0 Offset: 0x19FC2E0 VA: 0x1819FDCE0 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x19FDDC0 Offset: 0x19FC3C0 VA: 0x1819FDDC0 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x1A01C80 Offset: 0x1A00280 VA: 0x181A01C80
	private void SetMeshArrays(int size) { }

	// RVA: 0x19FF870 Offset: 0x19FDE70 VA: 0x1819FF870 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x19F1AC0 Offset: 0x19F00C0 VA: 0x1819F1AC0 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x19FED90 Offset: 0x19FD390 VA: 0x1819FED90 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x19FEBE0 Offset: 0x19FD1E0 VA: 0x1819FEBE0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x19FF5C0 Offset: 0x19FDBC0 VA: 0x1819FF5C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x19FF420 Offset: 0x19FDA20 VA: 0x1819FF420 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A03D90 Offset: 0x1A02390 VA: 0x181A03D90
	public bool get_blockRectTransformChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A03F50 Offset: 0x1A02550 VA: 0x181A03F50
	public void set_blockRectTransformChange(bool value) { }

	// RVA: 0x19FE3D0 Offset: 0x19FC9D0 VA: 0x1819FE3D0 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x19FF1F0 Offset: 0x19FD7F0 VA: 0x1819FF1F0
	private void OnPreRenderCanvas() { }

	// RVA: 0x19F1FF0 Offset: 0x19F05F0 VA: 0x1819F1FF0 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x19FE060 Offset: 0x19FC660 VA: 0x1819FE060 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x19FF700 Offset: 0x19FDD00 VA: 0x1819FF700 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x19FD320 Offset: 0x19FB920 VA: 0x1819FD320 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1A032D0 Offset: 0x1A018D0 VA: 0x181A032D0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x19F0D60 Offset: 0x19EF360 VA: 0x1819F0D60 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x1A03E50 Offset: 0x1A02450 VA: 0x181A03E50 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x1174120 Offset: 0x1172720 VA: 0x181174120 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1A03EC0 Offset: 0x1A024C0 VA: 0x181A03EC0 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x7BBE40 Offset: 0x7BA440 VA: 0x1807BBE40 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x1A03DA0 Offset: 0x1A023A0 VA: 0x181A03DA0
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x19F1870 Offset: 0x19EFE70 VA: 0x1819F1870 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x19F18F0 Offset: 0x19EFEF0 VA: 0x1819F18F0 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1A02860 Offset: 0x1A00E60 VA: 0x181A02860 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1A01AB0 Offset: 0x1A000B0 VA: 0x181A01AB0 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1A01BA0 Offset: 0x1A001A0 VA: 0x181A01BA0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x116FC10 Offset: 0x116E210 VA: 0x18116FC10 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x19FF610 Offset: 0x19FDC10 VA: 0x1819FF610 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1A03680 Offset: 0x1A01C80 VA: 0x181A03680
	private void UpdateSubObjectPivot() { }

	// RVA: 0x19FDB80 Offset: 0x19FC180 VA: 0x1819FDB80 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1A03030 Offset: 0x1A01630 VA: 0x181A03030 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1A03E40 Offset: 0x1A02440 VA: 0x181A03E40
	public Vector4 get_maskOffset() { }

	// RVA: 0x1A03F60 Offset: 0x1A02560 VA: 0x181A03F60
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0xDA0910 Offset: 0xD9EF10 VA: 0x180DA0910 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xDA0920 Offset: 0xD9EF20 VA: 0x180DA0920 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0x19F1BF0 Offset: 0x19F01F0 VA: 0x1819F1BF0 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1A031A0 Offset: 0x1A017A0 VA: 0x181A031A0 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x19FE2F0 Offset: 0x19FC8F0 VA: 0x1819FE2F0 Slot: 106
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x19FE230 Offset: 0x19FC830 VA: 0x1819FE230 Slot: 107
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x19F1FE0 Offset: 0x19F05E0 VA: 0x1819F1FE0 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x19F1FC0 Offset: 0x19F05C0 VA: 0x1819F1FC0 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x19FE120 Offset: 0x19FC720 VA: 0x1819FE120 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x19F1980 Offset: 0x19EFF80 VA: 0x1819F1980 Slot: 122
	public override void ClearMesh() { }

	// RVA: 0x1A02950 Offset: 0x1A00F50 VA: 0x181A02950 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1A037B0 Offset: 0x1A01DB0 VA: 0x181A037B0 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1A03A40 Offset: 0x1A02040 VA: 0x181A03A40 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x11734D0 Offset: 0x1171AD0 VA: 0x1811734D0
	public void UpdateFontAsset() { }

	// RVA: 0x1A03CE0 Offset: 0x1A022E0 VA: 0x181A03CE0
	public void .ctor() { }

}

