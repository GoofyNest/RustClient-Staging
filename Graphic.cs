public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 4930
{	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0xEA540 Offset: 0xE9940 VA: 0x1800EA540
	[SerializeField] // RVA: 0xEA540 Offset: 0xE9940 VA: 0x1800EA540
	protected Material m_Material; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_Color; // 0x20
	protected bool m_SkipLayoutUpdate; // 0x30
	protected bool m_SkipMaterialUpdate; // 0x31
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_RaycastTarget; // 0x32
	private RectTransform m_RectTransform; // 0x38
	private CanvasRenderer m_CanvasRenderer; // 0x40
	private Canvas m_Canvas; // 0x48
	private bool m_VertsDirty; // 0x50
	private bool m_MaterialDirty; // 0x51
	protected UnityAction m_OnDirtyLayoutCallback; // 0x58
	protected UnityAction m_OnDirtyVertsCallback; // 0x60
	protected UnityAction m_OnDirtyMaterialCallback; // 0x68
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x70
	protected Vector2[] m_CachedUvs; // 0x78
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <useLegacyMeshGeneration>k__BackingField; // 0x88

	// Properties
	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }

	// Methods

	// RVA: 0x15EFA70 Offset: 0x15EE070 VA: 0x1815EFA70
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0xD67340 Offset: 0xD65940 VA: 0x180D67340 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x15F00F0 Offset: 0x15EE6F0 VA: 0x1815F00F0 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x15EFF10 Offset: 0x15EE510 VA: 0x1815EFF10 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x15F01F0 Offset: 0x15EE7F0 VA: 0x1815F01F0 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x69D600 Offset: 0x69BC00 VA: 0x18069D600
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x69D610 Offset: 0x69BC10 VA: 0x18069D610
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x15EF8C0 Offset: 0x15EDEC0 VA: 0x1815EF8C0
	protected void .ctor() { }

	// RVA: 0x15EF2A0 Offset: 0x15ED8A0 VA: 0x1815EF2A0 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x15EF300 Offset: 0x15ED900 VA: 0x1815EF300 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x15EF470 Offset: 0x15EDA70 VA: 0x1815EF470 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x15EF3E0 Offset: 0x15ED9E0 VA: 0x1815EF3E0 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x15EE9E0 Offset: 0x15ECFE0 VA: 0x1815EE9E0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15EDF50 Offset: 0x15EC550 VA: 0x1815EDF50 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x15EEA90 Offset: 0x15ED090 VA: 0x1815EEA90 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15EFBC0 Offset: 0x15EE1C0 VA: 0x1815EFBC0
	public int get_depth() { }

	// RVA: 0x15EFF20 Offset: 0x15EE520 VA: 0x1815EFF20 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x15EF9F0 Offset: 0x15EDFF0 VA: 0x1815EF9F0
	public Canvas get_canvas() { }

	// RVA: 0x15ECFB0 Offset: 0x15EB5B0 VA: 0x1815ECFB0
	private void CacheCanvas() { }

	// RVA: 0x15EF990 Offset: 0x15EDF90 VA: 0x1815EF990
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x15EFB70 Offset: 0x15EE170 VA: 0x1815EFB70 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x15EFE80 Offset: 0x15EE480 VA: 0x1815EFE80 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x15F0140 Offset: 0x15EE740 VA: 0x1815F0140 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x15EFC90 Offset: 0x15EE290 VA: 0x1815EFC90 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x15EFC30 Offset: 0x15EE230 VA: 0x1815EFC30 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x15EE4F0 Offset: 0x15ECAF0 VA: 0x1815EE4F0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15EE300 Offset: 0x15EC900 VA: 0x1815EE300 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15EE240 Offset: 0x15EC840 VA: 0x1815EE240 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15EE040 Offset: 0x15EC640 VA: 0x1815EE040 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x15EE170 Offset: 0x15EC770 VA: 0x1815EE170 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x15EEFC0 Offset: 0x15ED5C0 VA: 0x1815EEFC0 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x15EF6A0 Offset: 0x15EDCA0 VA: 0x1815EF6A0 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x15EF680 Offset: 0x15EDC80 VA: 0x1815EF680 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x15ED930 Offset: 0x15EBF30 VA: 0x1815ED930
	private void DoMeshGeneration() { }

	// RVA: 0x15ED510 Offset: 0x15EBB10 VA: 0x1815ED510
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x15EFF80 Offset: 0x15EE580 VA: 0x1815EFF80
	protected static Mesh get_workerMesh() { }

	[EditorBrowsableAttribute] // RVA: 0xEA9B0 Offset: 0xE9DB0 VA: 0x1800EA9B0
	[ObsoleteAttribute] // RVA: 0xEA9B0 Offset: 0xE9DB0 VA: 0x1800EA9B0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[ObsoleteAttribute] // RVA: 0xEAB50 Offset: 0xE9F50 VA: 0x1800EAB50
	// RVA: 0x15EE630 Offset: 0x15ECC30 VA: 0x1815EE630 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x15EE6E0 Offset: 0x15ECCE0 VA: 0x1815EE6E0 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xFCB320 Offset: 0xFC9920 VA: 0x180FCB320 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x15EECA0 Offset: 0x15ED2A0 VA: 0x1815EECA0 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x15EEB50 Offset: 0x15ED150 VA: 0x1815EEB50
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x15EDDA0 Offset: 0x15EC3A0 VA: 0x1815EDDA0
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x15ED210 Offset: 0x15EB810 VA: 0x1815ED210 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x15ED250 Offset: 0x15EB850 VA: 0x1815ED250 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x15ED100 Offset: 0x15EB700 VA: 0x1815ED100
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x15ED140 Offset: 0x15EB740 VA: 0x1815ED140 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x15EF120 Offset: 0x15ED720 VA: 0x1815EF120
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x15EF500 Offset: 0x15EDB00 VA: 0x1815EF500
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x15EF220 Offset: 0x15ED820 VA: 0x1815EF220
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x15EF600 Offset: 0x15EDC00 VA: 0x1815EF600
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x15EF1A0 Offset: 0x15ED7A0 VA: 0x1815EF1A0
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x15EF580 Offset: 0x15EDB80 VA: 0x1815EF580
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x15EF820 Offset: 0x15EDE20 VA: 0x1815EF820
	private static void .cctor() { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

