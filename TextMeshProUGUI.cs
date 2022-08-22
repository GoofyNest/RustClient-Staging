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

	// RVA: 0x1A03D40 Offset: 0x1A02340 VA: 0x181A03D40 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1A118F0 Offset: 0x1A0FEF0 VA: 0x181A118F0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A11710 Offset: 0x1A0FD10 VA: 0x181A11710 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A11560 Offset: 0x1A0FB60 VA: 0x181A11560 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1A10E00 Offset: 0x1A0F400 VA: 0x181A10E00 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x1A0FB20 Offset: 0x1A0E120 VA: 0x181A0FB20
	private Canvas GetCanvas() { }

	// RVA: 0x1A046B0 Offset: 0x1A02CB0 VA: 0x181A046B0
	private void EnableMasking() { }

	// RVA: 0x1A04560 Offset: 0x1A02B60 VA: 0x181A04560
	private void DisableMasking() { }

	// RVA: 0x1A15330 Offset: 0x1A13930 VA: 0x181A15330
	private void UpdateMask() { }

	// RVA: 0x1A10150 Offset: 0x1A0E750 VA: 0x181A10150 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x1A102D0 Offset: 0x1A0E8D0 VA: 0x181A102D0 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1171E50 Offset: 0x1170450 VA: 0x181171E50 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x1A107D0 Offset: 0x1A0EDD0 VA: 0x181A107D0 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1A14C30 Offset: 0x1A13230 VA: 0x181A14C30 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1A147B0 Offset: 0x1A12DB0 VA: 0x181A147B0 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1A14290 Offset: 0x1A12890 VA: 0x181A14290 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1A14650 Offset: 0x1A12C50 VA: 0x181A14650 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1A14AC0 Offset: 0x1A130C0 VA: 0x181A14AC0 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x1A13EA0 Offset: 0x1A124A0 VA: 0x181A13EA0 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x1A149F0 Offset: 0x1A12FF0 VA: 0x181A149F0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1A10620 Offset: 0x1A0EC20 VA: 0x181A10620 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x1A10700 Offset: 0x1A0ED00 VA: 0x181A10700 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x1A145C0 Offset: 0x1A12BC0 VA: 0x181A145C0
	private void SetMeshArrays(int size) { }

	// RVA: 0x1A121B0 Offset: 0x1A107B0 VA: 0x181A121B0 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x1A04400 Offset: 0x1A02A00 VA: 0x181A04400 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x1A116D0 Offset: 0x1A0FCD0 VA: 0x181A116D0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A11520 Offset: 0x1A0FB20 VA: 0x181A11520 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A11F00 Offset: 0x1A10500 VA: 0x181A11F00 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A11D60 Offset: 0x1A10360 VA: 0x181A11D60 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A166D0 Offset: 0x1A14CD0 VA: 0x181A166D0
	public bool get_blockRectTransformChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A16890 Offset: 0x1A14E90 VA: 0x181A16890
	public void set_blockRectTransformChange(bool value) { }

	// RVA: 0x1A10D10 Offset: 0x1A0F310 VA: 0x181A10D10 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x1A11B30 Offset: 0x1A10130 VA: 0x181A11B30
	private void OnPreRenderCanvas() { }

	// RVA: 0x1A04930 Offset: 0x1A02F30 VA: 0x181A04930 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x1A109A0 Offset: 0x1A0EFA0 VA: 0x181A109A0 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1A12040 Offset: 0x1A10640 VA: 0x181A12040 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1A0FC60 Offset: 0x1A0E260 VA: 0x181A0FC60 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1A15C10 Offset: 0x1A14210 VA: 0x181A15C10
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1A036A0 Offset: 0x1A01CA0 VA: 0x181A036A0 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x1A16790 Offset: 0x1A14D90 VA: 0x181A16790 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x11733F0 Offset: 0x11719F0 VA: 0x1811733F0 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1A16800 Offset: 0x1A14E00 VA: 0x181A16800 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x79D930 Offset: 0x79BF30 VA: 0x18079D930 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x1A166E0 Offset: 0x1A14CE0 VA: 0x181A166E0
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1A041B0 Offset: 0x1A027B0 VA: 0x181A041B0 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A04230 Offset: 0x1A02830 VA: 0x181A04230 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1A151A0 Offset: 0x1A137A0 VA: 0x181A151A0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1A143F0 Offset: 0x1A129F0 VA: 0x181A143F0 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1A144E0 Offset: 0x1A12AE0 VA: 0x181A144E0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x116EEE0 Offset: 0x116D4E0 VA: 0x18116EEE0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x1A11F50 Offset: 0x1A10550 VA: 0x181A11F50 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1A15FC0 Offset: 0x1A145C0 VA: 0x181A15FC0
	private void UpdateSubObjectPivot() { }

	// RVA: 0x1A104C0 Offset: 0x1A0EAC0 VA: 0x181A104C0 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1A15970 Offset: 0x1A13F70 VA: 0x181A15970 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1A16780 Offset: 0x1A14D80 VA: 0x181A16780
	public Vector4 get_maskOffset() { }

	// RVA: 0x1A168A0 Offset: 0x1A14EA0 VA: 0x181A168A0
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0xD9FBA0 Offset: 0xD9E1A0 VA: 0x180D9FBA0 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xD9FBB0 Offset: 0xD9E1B0 VA: 0x180D9FBB0 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0x1A04530 Offset: 0x1A02B30 VA: 0x181A04530 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1A15AE0 Offset: 0x1A140E0 VA: 0x181A15AE0 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x1A10C30 Offset: 0x1A0F230 VA: 0x181A10C30 Slot: 106
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1A10B70 Offset: 0x1A0F170 VA: 0x181A10B70 Slot: 107
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1A04920 Offset: 0x1A02F20 VA: 0x181A04920 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x1A04900 Offset: 0x1A02F00 VA: 0x181A04900 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x1A10A60 Offset: 0x1A0F060 VA: 0x181A10A60 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1A042C0 Offset: 0x1A028C0 VA: 0x181A042C0 Slot: 122
	public override void ClearMesh() { }

	// RVA: 0x1A15290 Offset: 0x1A13890 VA: 0x181A15290 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1A160F0 Offset: 0x1A146F0 VA: 0x181A160F0 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1A16380 Offset: 0x1A14980 VA: 0x181A16380 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x11727A0 Offset: 0x1170DA0 VA: 0x1811727A0
	public void UpdateFontAsset() { }

	// RVA: 0x1A16620 Offset: 0x1A14C20 VA: 0x181A16620
	public void .ctor() { }

}

