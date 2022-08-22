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

	// RVA: 0x1161EF0 Offset: 0x11604F0 VA: 0x181161EF0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x116F610 Offset: 0x116DC10 VA: 0x18116F610 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x116F5B0 Offset: 0x116DBB0 VA: 0x18116F5B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x116F460 Offset: 0x116DA60 VA: 0x18116F460 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x116EEA0 Offset: 0x116D4A0 VA: 0x18116EEA0 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x1173170 Offset: 0x1171770 VA: 0x181173170
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x1172060 Offset: 0x1170660 VA: 0x181172060
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x1171FC0 Offset: 0x11705C0 VA: 0x181171FC0
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x1171EA0 Offset: 0x11704A0 VA: 0x181171EA0
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x1162E10 Offset: 0x1161410 VA: 0x181162E10
	private void EnableMasking() { }

	// RVA: 0x1162CC0 Offset: 0x11612C0 VA: 0x181162CC0
	private void DisableMasking() { }

	// RVA: 0x1173510 Offset: 0x1171B10 VA: 0x181173510
	private void UpdateMask() { }

	// RVA: 0x116E540 Offset: 0x116CB40 VA: 0x18116E540 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x116E690 Offset: 0x116CC90 VA: 0x18116E690 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1172B80 Offset: 0x1171180 VA: 0x181172B80 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x116EAA0 Offset: 0x116D0A0 VA: 0x18116EAA0 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1172BD0 Offset: 0x11711D0 VA: 0x181172BD0 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x11727C0 Offset: 0x1170DC0 VA: 0x1811727C0 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1171CC0 Offset: 0x11702C0 VA: 0x181171CC0 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1172680 Offset: 0x1170C80 VA: 0x181172680 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1162BF0 Offset: 0x11611F0 VA: 0x181162BF0
	private void CreateMaterialInstance() { }

	// RVA: 0x1172A20 Offset: 0x1171020 VA: 0x181172A20 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x1171910 Offset: 0x116FF10 VA: 0x181171910 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x1172950 Offset: 0x1170F50 VA: 0x181172950
	private void SetPerspectiveCorrection() { }

	// RVA: 0x116E9C0 Offset: 0x116CFC0 VA: 0x18116E9C0 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x116E870 Offset: 0x116CE70 VA: 0x18116E870 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x116FC60 Offset: 0x116E260 VA: 0x18116FC60 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x1162AC0 Offset: 0x11610C0 VA: 0x181162AC0 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x116F590 Offset: 0x116DB90 VA: 0x18116F590 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x116F970 Offset: 0x116DF70 VA: 0x18116F970 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x116F920 Offset: 0x116DF20 VA: 0x18116F920 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x116EDB0 Offset: 0x116D3B0 VA: 0x18116EDB0 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x116F770 Offset: 0x116DD70 VA: 0x18116F770
	private void OnPreRenderObject() { }

	// RVA: 0x1162F90 Offset: 0x1161590 VA: 0x181162F90 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x116EC60 Offset: 0x116D260 VA: 0x18116EC60 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x11723D0 Offset: 0x11709D0 VA: 0x1811723D0
	private void SetMeshFilters(bool state) { }

	// RVA: 0x116FAA0 Offset: 0x116E0A0 VA: 0x18116FAA0 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1162920 Offset: 0x1160F20 VA: 0x181162920 Slot: 121
	protected override void ClearSubMeshObjects() { }

	// RVA: 0x116E050 Offset: 0x116C650 VA: 0x18116E050 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1173900 Offset: 0x1171F00 VA: 0x181173900
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1161850 Offset: 0x115FE50 VA: 0x181161850 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x1174360 Offset: 0x1172960 VA: 0x181174360
	public int get_sortingLayerID() { }

	// RVA: 0x1174550 Offset: 0x1172B50 VA: 0x181174550
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1174390 Offset: 0x1172990 VA: 0x181174390
	public int get_sortingOrder() { }

	// RVA: 0x1174580 Offset: 0x1172B80 VA: 0x181174580
	public void set_sortingOrder(int value) { }

	// RVA: 0x1174120 Offset: 0x1172720 VA: 0x181174120 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1174460 Offset: 0x1172A60 VA: 0x181174460 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	public TextContainer get_textContainer() { }

	// RVA: 0x11743C0 Offset: 0x11729C0 VA: 0x1811743C0
	public Transform get_transform() { }

	// RVA: 0x11742C0 Offset: 0x11728C0 VA: 0x1811742C0
	public Renderer get_renderer() { }

	// RVA: 0x11741E0 Offset: 0x11727E0 VA: 0x1811741E0 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x1174140 Offset: 0x1172740 VA: 0x181174140
	public MeshFilter get_meshFilter() { }

	// RVA: 0x1174130 Offset: 0x1172730 VA: 0x181174130
	public MaskingTypes get_maskType() { }

	// RVA: 0x1174540 Offset: 0x1172B40 VA: 0x181174540
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x1172220 Offset: 0x1170820 VA: 0x181172220
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x11722C0 Offset: 0x11708C0 VA: 0x1811722C0
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x1173040 Offset: 0x1171640 VA: 0x181173040 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1171E00 Offset: 0x1170400 VA: 0x181171E00 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0xDA0940 Offset: 0xD9EF40 VA: 0x180DA0940 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x116FC10 Offset: 0x116E210 VA: 0x18116FC10 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x116F9B0 Offset: 0x116DFB0 VA: 0x18116F9B0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1173650 Offset: 0x1171C50 VA: 0x181173650 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x11737D0 Offset: 0x1171DD0 VA: 0x1811737D0 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x1162F60 Offset: 0x1161560 VA: 0x181162F60 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x1162F70 Offset: 0x1161570 VA: 0x181162F70 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x116ED20 Offset: 0x116D320 VA: 0x18116ED20 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x11627B0 Offset: 0x1160DB0 VA: 0x1811627B0 Slot: 123
	public override void ClearMesh(bool updateMesh) { }

	// RVA: 0x11734F0 Offset: 0x1171AF0 VA: 0x1811734F0 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1173C00 Offset: 0x1172200 VA: 0x181173C00 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1173E30 Offset: 0x1172430 VA: 0x181173E30 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x11734D0 Offset: 0x1171AD0 VA: 0x1811734D0
	public void UpdateFontAsset() { }

	// RVA: 0x1162530 Offset: 0x1160B30 VA: 0x181162530 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1162680 Offset: 0x1160C80 VA: 0x181162680 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1174060 Offset: 0x1172660 VA: 0x181174060
	public void .ctor() { }

}

