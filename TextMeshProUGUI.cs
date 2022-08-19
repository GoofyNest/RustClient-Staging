public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 6867
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_hasFontAssetChanged; // 0xAD0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_SubMeshUI[] m_subTextObjects; // 0xAD8
	private float m_previousLossyScaleY; // 0xAE0
	private Vector3[] m_RectTransformCorners; // 0xAE8
	private CanvasRenderer m_canvasRenderer; // 0xAF0
	private Canvas m_canvas; // 0xAF8
	private bool m_isFirstAllocation; // 0xB00
	private int m_max_characters; // 0xB04
	private bool m_isMaskingEnabled; // 0xB08
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Material m_baseMaterial; // 0xB10
	private bool m_isScrollRegionSet; // 0xB18
	private int m_stencilID; // 0xB1C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector4 m_maskOffset; // 0xB20
	private Matrix4x4 m_EnvMapMatrix; // 0xB30
	private bool m_isRegisteredForEvents; // 0xB70
	private int m_recursiveCountA; // 0xB74
	private int loopCountA; // 0xB78
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1A03D80 Offset: 0x1A02380 VA: 0x181A03D80 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1A11930 Offset: 0x1A0FF30 VA: 0x181A11930 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A11750 Offset: 0x1A0FD50 VA: 0x181A11750 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A115A0 Offset: 0x1A0FBA0 VA: 0x181A115A0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1A10E40 Offset: 0x1A0F440 VA: 0x181A10E40 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x1A0FB60 Offset: 0x1A0E160 VA: 0x181A0FB60
	private Canvas GetCanvas() { }

	// RVA: 0x1A046F0 Offset: 0x1A02CF0 VA: 0x181A046F0
	private void EnableMasking() { }

	// RVA: 0x1A045A0 Offset: 0x1A02BA0 VA: 0x181A045A0
	private void DisableMasking() { }

	// RVA: 0x1A15370 Offset: 0x1A13970 VA: 0x181A15370
	private void UpdateMask() { }

	// RVA: 0x1A10190 Offset: 0x1A0E790 VA: 0x181A10190 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x1A10310 Offset: 0x1A0E910 VA: 0x181A10310 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1171E50 Offset: 0x1170450 VA: 0x181171E50 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x1A10810 Offset: 0x1A0EE10 VA: 0x181A10810 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1A14C70 Offset: 0x1A13270 VA: 0x181A14C70 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1A147F0 Offset: 0x1A12DF0 VA: 0x181A147F0 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1A142D0 Offset: 0x1A128D0 VA: 0x181A142D0 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1A14690 Offset: 0x1A12C90 VA: 0x181A14690 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1A14B00 Offset: 0x1A13100 VA: 0x181A14B00 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x1A13EE0 Offset: 0x1A124E0 VA: 0x181A13EE0 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x1A14A30 Offset: 0x1A13030 VA: 0x181A14A30
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1A10660 Offset: 0x1A0EC60 VA: 0x181A10660 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x1A10740 Offset: 0x1A0ED40 VA: 0x181A10740 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x1A14600 Offset: 0x1A12C00 VA: 0x181A14600
	private void SetMeshArrays(int size) { }

	// RVA: 0x1A121F0 Offset: 0x1A107F0 VA: 0x181A121F0 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x1A04440 Offset: 0x1A02A40 VA: 0x181A04440 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x1A11710 Offset: 0x1A0FD10 VA: 0x181A11710 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A11560 Offset: 0x1A0FB60 VA: 0x181A11560 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A11F40 Offset: 0x1A10540 VA: 0x181A11F40 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A11DA0 Offset: 0x1A103A0 VA: 0x181A11DA0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A16710 Offset: 0x1A14D10 VA: 0x181A16710
	public bool get_blockRectTransformChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A168D0 Offset: 0x1A14ED0 VA: 0x181A168D0
	public void set_blockRectTransformChange(bool value) { }

	// RVA: 0x1A10D50 Offset: 0x1A0F350 VA: 0x181A10D50 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x1A11B70 Offset: 0x1A10170 VA: 0x181A11B70
	private void OnPreRenderCanvas() { }

	// RVA: 0x1A04970 Offset: 0x1A02F70 VA: 0x181A04970 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x1A109E0 Offset: 0x1A0EFE0 VA: 0x181A109E0 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1A12080 Offset: 0x1A10680 VA: 0x181A12080 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1A0FCA0 Offset: 0x1A0E2A0 VA: 0x181A0FCA0 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1A15C50 Offset: 0x1A14250 VA: 0x181A15C50
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1A036E0 Offset: 0x1A01CE0 VA: 0x181A036E0 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x1A167D0 Offset: 0x1A14DD0 VA: 0x181A167D0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x11733F0 Offset: 0x11719F0 VA: 0x1811733F0 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1A16840 Offset: 0x1A14E40 VA: 0x181A16840 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x79D930 Offset: 0x79BF30 VA: 0x18079D930 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x1A16720 Offset: 0x1A14D20 VA: 0x181A16720
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1A041F0 Offset: 0x1A027F0 VA: 0x181A041F0 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A04270 Offset: 0x1A02870 VA: 0x181A04270 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1A151E0 Offset: 0x1A137E0 VA: 0x181A151E0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1A14430 Offset: 0x1A12A30 VA: 0x181A14430 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1A14520 Offset: 0x1A12B20 VA: 0x181A14520 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x116EEE0 Offset: 0x116D4E0 VA: 0x18116EEE0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x1A11F90 Offset: 0x1A10590 VA: 0x181A11F90 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1A16000 Offset: 0x1A14600 VA: 0x181A16000
	private void UpdateSubObjectPivot() { }

	// RVA: 0x1A10500 Offset: 0x1A0EB00 VA: 0x181A10500 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1A159B0 Offset: 0x1A13FB0 VA: 0x181A159B0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1A167C0 Offset: 0x1A14DC0 VA: 0x181A167C0
	public Vector4 get_maskOffset() { }

	// RVA: 0x1A168E0 Offset: 0x1A14EE0 VA: 0x181A168E0
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0xD9FBA0 Offset: 0xD9E1A0 VA: 0x180D9FBA0 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xD9FBB0 Offset: 0xD9E1B0 VA: 0x180D9FBB0 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0x1A04570 Offset: 0x1A02B70 VA: 0x181A04570 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1A15B20 Offset: 0x1A14120 VA: 0x181A15B20 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x1A10C70 Offset: 0x1A0F270 VA: 0x181A10C70 Slot: 106
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1A10BB0 Offset: 0x1A0F1B0 VA: 0x181A10BB0 Slot: 107
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1A04960 Offset: 0x1A02F60 VA: 0x181A04960 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x1A04940 Offset: 0x1A02F40 VA: 0x181A04940 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x1A10AA0 Offset: 0x1A0F0A0 VA: 0x181A10AA0 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1A04300 Offset: 0x1A02900 VA: 0x181A04300 Slot: 122
	public override void ClearMesh() { }

	// RVA: 0x1A152D0 Offset: 0x1A138D0 VA: 0x181A152D0 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1A16130 Offset: 0x1A14730 VA: 0x181A16130 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1A163C0 Offset: 0x1A149C0 VA: 0x181A163C0 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x11727A0 Offset: 0x1170DA0 VA: 0x1811727A0
	public void UpdateFontAsset() { }

	// RVA: 0x1A16660 Offset: 0x1A14C60 VA: 0x181A16660
	public void .ctor() { }

}

