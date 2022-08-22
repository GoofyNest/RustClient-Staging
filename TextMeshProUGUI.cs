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

	// RVA: 0x1A04000 Offset: 0x1A02600 VA: 0x181A04000 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1A11BB0 Offset: 0x1A101B0 VA: 0x181A11BB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A119D0 Offset: 0x1A0FFD0 VA: 0x181A119D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A11820 Offset: 0x1A0FE20 VA: 0x181A11820 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1A110C0 Offset: 0x1A0F6C0 VA: 0x181A110C0 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x1A0FDE0 Offset: 0x1A0E3E0 VA: 0x181A0FDE0
	private Canvas GetCanvas() { }

	// RVA: 0x1A04970 Offset: 0x1A02F70 VA: 0x181A04970
	private void EnableMasking() { }

	// RVA: 0x1A04820 Offset: 0x1A02E20 VA: 0x181A04820
	private void DisableMasking() { }

	// RVA: 0x1A155F0 Offset: 0x1A13BF0 VA: 0x181A155F0
	private void UpdateMask() { }

	// RVA: 0x1A10410 Offset: 0x1A0EA10 VA: 0x181A10410 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x1A10590 Offset: 0x1A0EB90 VA: 0x181A10590 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1172110 Offset: 0x1170710 VA: 0x181172110 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x1A10A90 Offset: 0x1A0F090 VA: 0x181A10A90 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1A14EF0 Offset: 0x1A134F0 VA: 0x181A14EF0 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1A14A70 Offset: 0x1A13070 VA: 0x181A14A70 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1A14550 Offset: 0x1A12B50 VA: 0x181A14550 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1A14910 Offset: 0x1A12F10 VA: 0x181A14910 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1A14D80 Offset: 0x1A13380 VA: 0x181A14D80 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x1A14160 Offset: 0x1A12760 VA: 0x181A14160 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x1A14CB0 Offset: 0x1A132B0 VA: 0x181A14CB0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1A108E0 Offset: 0x1A0EEE0 VA: 0x181A108E0 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x1A109C0 Offset: 0x1A0EFC0 VA: 0x181A109C0 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x1A14880 Offset: 0x1A12E80 VA: 0x181A14880
	private void SetMeshArrays(int size) { }

	// RVA: 0x1A12470 Offset: 0x1A10A70 VA: 0x181A12470 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x1A046C0 Offset: 0x1A02CC0 VA: 0x181A046C0 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x1A11990 Offset: 0x1A0FF90 VA: 0x181A11990 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A117E0 Offset: 0x1A0FDE0 VA: 0x181A117E0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A121C0 Offset: 0x1A107C0 VA: 0x181A121C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A12020 Offset: 0x1A10620 VA: 0x181A12020 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A16990 Offset: 0x1A14F90 VA: 0x181A16990
	public bool get_blockRectTransformChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A16B50 Offset: 0x1A15150 VA: 0x181A16B50
	public void set_blockRectTransformChange(bool value) { }

	// RVA: 0x1A10FD0 Offset: 0x1A0F5D0 VA: 0x181A10FD0 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x1A11DF0 Offset: 0x1A103F0 VA: 0x181A11DF0
	private void OnPreRenderCanvas() { }

	// RVA: 0x1A04BF0 Offset: 0x1A031F0 VA: 0x181A04BF0 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x1A10C60 Offset: 0x1A0F260 VA: 0x181A10C60 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1A12300 Offset: 0x1A10900 VA: 0x181A12300 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1A0FF20 Offset: 0x1A0E520 VA: 0x181A0FF20 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1A15ED0 Offset: 0x1A144D0 VA: 0x181A15ED0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1A03960 Offset: 0x1A01F60 VA: 0x181A03960 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x1A16A50 Offset: 0x1A15050 VA: 0x181A16A50 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x11736B0 Offset: 0x1171CB0 VA: 0x1811736B0 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1A16AC0 Offset: 0x1A150C0 VA: 0x181A16AC0 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x79DA40 Offset: 0x79C040 VA: 0x18079DA40 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x1A169A0 Offset: 0x1A14FA0 VA: 0x181A169A0
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1A04470 Offset: 0x1A02A70 VA: 0x181A04470 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A044F0 Offset: 0x1A02AF0 VA: 0x181A044F0 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1A15460 Offset: 0x1A13A60 VA: 0x181A15460 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1A146B0 Offset: 0x1A12CB0 VA: 0x181A146B0 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1A147A0 Offset: 0x1A12DA0 VA: 0x181A147A0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x116F1A0 Offset: 0x116D7A0 VA: 0x18116F1A0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x1A12210 Offset: 0x1A10810 VA: 0x181A12210 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1A16280 Offset: 0x1A14880 VA: 0x181A16280
	private void UpdateSubObjectPivot() { }

	// RVA: 0x1A10780 Offset: 0x1A0ED80 VA: 0x181A10780 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1A15C30 Offset: 0x1A14230 VA: 0x181A15C30 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1A16A40 Offset: 0x1A15040 VA: 0x181A16A40
	public Vector4 get_maskOffset() { }

	// RVA: 0x1A16B60 Offset: 0x1A15160 VA: 0x181A16B60
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0xD9FE60 Offset: 0xD9E460 VA: 0x180D9FE60 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xD9FE70 Offset: 0xD9E470 VA: 0x180D9FE70 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0x1A047F0 Offset: 0x1A02DF0 VA: 0x181A047F0 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1A15DA0 Offset: 0x1A143A0 VA: 0x181A15DA0 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x1A10EF0 Offset: 0x1A0F4F0 VA: 0x181A10EF0 Slot: 106
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1A10E30 Offset: 0x1A0F430 VA: 0x181A10E30 Slot: 107
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1A04BE0 Offset: 0x1A031E0 VA: 0x181A04BE0 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x1A04BC0 Offset: 0x1A031C0 VA: 0x181A04BC0 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x1A10D20 Offset: 0x1A0F320 VA: 0x181A10D20 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1A04580 Offset: 0x1A02B80 VA: 0x181A04580 Slot: 122
	public override void ClearMesh() { }

	// RVA: 0x1A15550 Offset: 0x1A13B50 VA: 0x181A15550 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1A163B0 Offset: 0x1A149B0 VA: 0x181A163B0 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1A16640 Offset: 0x1A14C40 VA: 0x181A16640 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x1172A60 Offset: 0x1171060 VA: 0x181172A60
	public void UpdateFontAsset() { }

	// RVA: 0x1A168E0 Offset: 0x1A14EE0 VA: 0x181A168E0
	public void .ctor() { }

}

