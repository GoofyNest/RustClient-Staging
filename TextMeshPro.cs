public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 6866
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_hasFontAssetChanged; // 0xAD0
	private float m_previousLossyScaleY; // 0xAD4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer m_renderer; // 0xAD8
	private MeshFilter m_meshFilter; // 0xAE0
	private bool m_isFirstAllocation; // 0xAE8
	private int m_max_characters; // 0xAEC
	private int m_max_numberOfLines; // 0xAF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_SubMesh[] m_subTextObjects; // 0xAF8
	private bool m_isMaskingEnabled; // 0xB00
	private bool isMaskUpdateRequired; // 0xB01
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MaskingTypes m_maskType; // 0xB04
	private Matrix4x4 m_EnvMapMatrix; // 0xB08
	private Vector3[] m_RectTransformCorners; // 0xB48
	private bool m_isRegisteredForEvents; // 0xB50
	private int loopCountA; // 0xB54
	private bool m_currentAutoSizeMode; // 0xB58

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute] // RVA: 0xDDA20 Offset: 0xDCE20 VA: 0x1800DDA20
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x1161480 Offset: 0x115FA80 VA: 0x181161480 Slot: 4
	protected override void Awake() { }

	// RVA: 0x116EBA0 Offset: 0x116D1A0 VA: 0x18116EBA0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x116EB40 Offset: 0x116D140 VA: 0x18116EB40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x116E9F0 Offset: 0x116CFF0 VA: 0x18116E9F0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x116E430 Offset: 0x116CA30 VA: 0x18116E430 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x1172700 Offset: 0x1170D00 VA: 0x181172700
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x11715F0 Offset: 0x116FBF0 VA: 0x1811715F0
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x1171550 Offset: 0x116FB50 VA: 0x181171550
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x1171430 Offset: 0x116FA30 VA: 0x181171430
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x11623A0 Offset: 0x11609A0 VA: 0x1811623A0
	private void EnableMasking() { }

	// RVA: 0x1162250 Offset: 0x1160850 VA: 0x181162250
	private void DisableMasking() { }

	// RVA: 0x1172AA0 Offset: 0x11710A0 VA: 0x181172AA0
	private void UpdateMask() { }

	// RVA: 0x116DAD0 Offset: 0x116C0D0 VA: 0x18116DAD0 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x116DC20 Offset: 0x116C220 VA: 0x18116DC20 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1172110 Offset: 0x1170710 VA: 0x181172110 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x116E030 Offset: 0x116C630 VA: 0x18116E030 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1172160 Offset: 0x1170760 VA: 0x181172160 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1171D50 Offset: 0x1170350 VA: 0x181171D50 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1171250 Offset: 0x116F850 VA: 0x181171250 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1171C10 Offset: 0x1170210 VA: 0x181171C10 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1162180 Offset: 0x1160780 VA: 0x181162180
	private void CreateMaterialInstance() { }

	// RVA: 0x1171FB0 Offset: 0x11705B0 VA: 0x181171FB0 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x1170EA0 Offset: 0x116F4A0 VA: 0x181170EA0 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x1171EE0 Offset: 0x11704E0 VA: 0x181171EE0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x116DF50 Offset: 0x116C550 VA: 0x18116DF50 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x116DE00 Offset: 0x116C400 VA: 0x18116DE00 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x116F1F0 Offset: 0x116D7F0 VA: 0x18116F1F0 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x1162050 Offset: 0x1160650 VA: 0x181162050 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x116EB20 Offset: 0x116D120 VA: 0x18116EB20 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x116EF00 Offset: 0x116D500 VA: 0x18116EF00 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x116EEB0 Offset: 0x116D4B0 VA: 0x18116EEB0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x116E340 Offset: 0x116C940 VA: 0x18116E340 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x116ED00 Offset: 0x116D300 VA: 0x18116ED00
	private void OnPreRenderObject() { }

	// RVA: 0x1162520 Offset: 0x1160B20 VA: 0x181162520 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x116E1F0 Offset: 0x116C7F0 VA: 0x18116E1F0 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1171960 Offset: 0x116FF60 VA: 0x181171960
	private void SetMeshFilters(bool state) { }

	// RVA: 0x116F030 Offset: 0x116D630 VA: 0x18116F030 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1161EB0 Offset: 0x11604B0 VA: 0x181161EB0 Slot: 121
	protected override void ClearSubMeshObjects() { }

	// RVA: 0x116D5E0 Offset: 0x116BBE0 VA: 0x18116D5E0 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1172E90 Offset: 0x1171490 VA: 0x181172E90
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1160DE0 Offset: 0x115F3E0 VA: 0x181160DE0 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x11738F0 Offset: 0x1171EF0 VA: 0x1811738F0
	public int get_sortingLayerID() { }

	// RVA: 0x1173AE0 Offset: 0x11720E0 VA: 0x181173AE0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1173920 Offset: 0x1171F20 VA: 0x181173920
	public int get_sortingOrder() { }

	// RVA: 0x1173B10 Offset: 0x1172110 VA: 0x181173B10
	public void set_sortingOrder(int value) { }

	// RVA: 0x11736B0 Offset: 0x1171CB0 VA: 0x1811736B0 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x11739F0 Offset: 0x1171FF0 VA: 0x1811739F0 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public TextContainer get_textContainer() { }

	// RVA: 0x1173950 Offset: 0x1171F50 VA: 0x181173950
	public Transform get_transform() { }

	// RVA: 0x1173850 Offset: 0x1171E50 VA: 0x181173850
	public Renderer get_renderer() { }

	// RVA: 0x1173770 Offset: 0x1171D70 VA: 0x181173770 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x11736D0 Offset: 0x1171CD0 VA: 0x1811736D0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x11736C0 Offset: 0x1171CC0 VA: 0x1811736C0
	public MaskingTypes get_maskType() { }

	// RVA: 0x1173AD0 Offset: 0x11720D0 VA: 0x181173AD0
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x11717B0 Offset: 0x116FDB0 VA: 0x1811717B0
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x1171850 Offset: 0x116FE50 VA: 0x181171850
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x11725D0 Offset: 0x1170BD0 VA: 0x1811725D0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1171390 Offset: 0x116F990 VA: 0x181171390 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0xD9FE90 Offset: 0xD9E490 VA: 0x180D9FE90 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x116F1A0 Offset: 0x116D7A0 VA: 0x18116F1A0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x116EF40 Offset: 0x116D540 VA: 0x18116EF40 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1172BE0 Offset: 0x11711E0 VA: 0x181172BE0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1172D60 Offset: 0x1171360 VA: 0x181172D60 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x11624F0 Offset: 0x1160AF0 VA: 0x1811624F0 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x1162500 Offset: 0x1160B00 VA: 0x181162500 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x116E2B0 Offset: 0x116C8B0 VA: 0x18116E2B0 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1161D40 Offset: 0x1160340 VA: 0x181161D40 Slot: 123
	public override void ClearMesh(bool updateMesh) { }

	// RVA: 0x1172A80 Offset: 0x1171080 VA: 0x181172A80 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1173190 Offset: 0x1171790 VA: 0x181173190 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x11733C0 Offset: 0x11719C0 VA: 0x1811733C0 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x1172A60 Offset: 0x1171060 VA: 0x181172A60
	public void UpdateFontAsset() { }

	// RVA: 0x1161AC0 Offset: 0x11600C0 VA: 0x181161AC0 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1161C10 Offset: 0x1160210 VA: 0x181161C10 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x11735F0 Offset: 0x1171BF0 VA: 0x1811735F0
	public void .ctor() { }

}

