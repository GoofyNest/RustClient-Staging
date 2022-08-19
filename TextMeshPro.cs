public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 6866
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_hasFontAssetChanged; // 0xAD0
	private float m_previousLossyScaleY; // 0xAD4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Renderer m_renderer; // 0xAD8
	private MeshFilter m_meshFilter; // 0xAE0
	private bool m_isFirstAllocation; // 0xAE8
	private int m_max_characters; // 0xAEC
	private int m_max_numberOfLines; // 0xAF0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_SubMesh[] m_subTextObjects; // 0xAF8
	private bool m_isMaskingEnabled; // 0xB00
	private bool isMaskUpdateRequired; // 0xB01
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[ObsoleteAttribute] // RVA: 0xDD9C0 Offset: 0xDCDC0 VA: 0x1800DD9C0
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x11611C0 Offset: 0x115F7C0 VA: 0x1811611C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x116E8E0 Offset: 0x116CEE0 VA: 0x18116E8E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x116E880 Offset: 0x116CE80 VA: 0x18116E880 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x116E730 Offset: 0x116CD30 VA: 0x18116E730 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x116E170 Offset: 0x116C770 VA: 0x18116E170 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x1172440 Offset: 0x1170A40 VA: 0x181172440
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x1171330 Offset: 0x116F930 VA: 0x181171330
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x1171290 Offset: 0x116F890 VA: 0x181171290
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x1171170 Offset: 0x116F770 VA: 0x181171170
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x11620E0 Offset: 0x11606E0 VA: 0x1811620E0
	private void EnableMasking() { }

	// RVA: 0x1161F90 Offset: 0x1160590 VA: 0x181161F90
	private void DisableMasking() { }

	// RVA: 0x11727E0 Offset: 0x1170DE0 VA: 0x1811727E0
	private void UpdateMask() { }

	// RVA: 0x116D810 Offset: 0x116BE10 VA: 0x18116D810 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x116D960 Offset: 0x116BF60 VA: 0x18116D960 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1171E50 Offset: 0x1170450 VA: 0x181171E50 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x116DD70 Offset: 0x116C370 VA: 0x18116DD70 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1171EA0 Offset: 0x11704A0 VA: 0x181171EA0 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1171A90 Offset: 0x1170090 VA: 0x181171A90 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1170F90 Offset: 0x116F590 VA: 0x181170F90 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1171950 Offset: 0x116FF50 VA: 0x181171950 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1161EC0 Offset: 0x11604C0 VA: 0x181161EC0
	private void CreateMaterialInstance() { }

	// RVA: 0x1171CF0 Offset: 0x11702F0 VA: 0x181171CF0 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x1170BE0 Offset: 0x116F1E0 VA: 0x181170BE0 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x1171C20 Offset: 0x1170220 VA: 0x181171C20
	private void SetPerspectiveCorrection() { }

	// RVA: 0x116DC90 Offset: 0x116C290 VA: 0x18116DC90 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x116DB40 Offset: 0x116C140 VA: 0x18116DB40 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x116EF30 Offset: 0x116D530 VA: 0x18116EF30 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x1161D90 Offset: 0x1160390 VA: 0x181161D90 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x116E860 Offset: 0x116CE60 VA: 0x18116E860 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x116EC40 Offset: 0x116D240 VA: 0x18116EC40 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x116EBF0 Offset: 0x116D1F0 VA: 0x18116EBF0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x116E080 Offset: 0x116C680 VA: 0x18116E080 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x116EA40 Offset: 0x116D040 VA: 0x18116EA40
	private void OnPreRenderObject() { }

	// RVA: 0x1162260 Offset: 0x1160860 VA: 0x181162260 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x116DF30 Offset: 0x116C530 VA: 0x18116DF30 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x11716A0 Offset: 0x116FCA0 VA: 0x1811716A0
	private void SetMeshFilters(bool state) { }

	// RVA: 0x116ED70 Offset: 0x116D370 VA: 0x18116ED70 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1161BF0 Offset: 0x11601F0 VA: 0x181161BF0 Slot: 121
	protected override void ClearSubMeshObjects() { }

	// RVA: 0x116D320 Offset: 0x116B920 VA: 0x18116D320 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1172BD0 Offset: 0x11711D0 VA: 0x181172BD0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1160B20 Offset: 0x115F120 VA: 0x181160B20 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x1173630 Offset: 0x1171C30 VA: 0x181173630
	public int get_sortingLayerID() { }

	// RVA: 0x1173820 Offset: 0x1171E20 VA: 0x181173820
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1173660 Offset: 0x1171C60 VA: 0x181173660
	public int get_sortingOrder() { }

	// RVA: 0x1173850 Offset: 0x1171E50 VA: 0x181173850
	public void set_sortingOrder(int value) { }

	// RVA: 0x11733F0 Offset: 0x11719F0 VA: 0x1811733F0 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1173730 Offset: 0x1171D30 VA: 0x181173730 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public TextContainer get_textContainer() { }

	// RVA: 0x1173690 Offset: 0x1171C90 VA: 0x181173690
	public Transform get_transform() { }

	// RVA: 0x1173590 Offset: 0x1171B90 VA: 0x181173590
	public Renderer get_renderer() { }

	// RVA: 0x11734B0 Offset: 0x1171AB0 VA: 0x1811734B0 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x1173410 Offset: 0x1171A10 VA: 0x181173410
	public MeshFilter get_meshFilter() { }

	// RVA: 0x1173400 Offset: 0x1171A00 VA: 0x181173400
	public MaskingTypes get_maskType() { }

	// RVA: 0x1173810 Offset: 0x1171E10 VA: 0x181173810
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x11714F0 Offset: 0x116FAF0 VA: 0x1811714F0
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x1171590 Offset: 0x116FB90 VA: 0x181171590
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x1172310 Offset: 0x1170910 VA: 0x181172310 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x11710D0 Offset: 0x116F6D0 VA: 0x1811710D0 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0xD9FBD0 Offset: 0xD9E1D0 VA: 0x180D9FBD0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x116EEE0 Offset: 0x116D4E0 VA: 0x18116EEE0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x116EC80 Offset: 0x116D280 VA: 0x18116EC80 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1172920 Offset: 0x1170F20 VA: 0x181172920 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1172AA0 Offset: 0x11710A0 VA: 0x181172AA0 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x1162230 Offset: 0x1160830 VA: 0x181162230 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x1162240 Offset: 0x1160840 VA: 0x181162240 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x116DFF0 Offset: 0x116C5F0 VA: 0x18116DFF0 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1161A80 Offset: 0x1160080 VA: 0x181161A80 Slot: 123
	public override void ClearMesh(bool updateMesh) { }

	// RVA: 0x11727C0 Offset: 0x1170DC0 VA: 0x1811727C0 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1172ED0 Offset: 0x11714D0 VA: 0x181172ED0 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1173100 Offset: 0x1171700 VA: 0x181173100 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x11727A0 Offset: 0x1170DA0 VA: 0x1811727A0
	public void UpdateFontAsset() { }

	// RVA: 0x1161800 Offset: 0x115FE00 VA: 0x181161800 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1161950 Offset: 0x115FF50 VA: 0x181161950 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1173330 Offset: 0x1171930 VA: 0x181173330
	public void .ctor() { }

}

