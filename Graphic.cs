public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 4930
{	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0xEA540 Offset: 0xE9940 VA: 0x1800EA540
	[SerializeField] // RVA: 0xEA540 Offset: 0xE9940 VA: 0x1800EA540
	protected Material m_Material; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_Color; // 0x20
	protected bool m_SkipLayoutUpdate; // 0x30
	protected bool m_SkipMaterialUpdate; // 0x31
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x15EFD30 Offset: 0x15EE330 VA: 0x1815EFD30
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0xD67600 Offset: 0xD65C00 VA: 0x180D67600 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x15F03B0 Offset: 0x15EE9B0 VA: 0x1815F03B0 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x15F01D0 Offset: 0x15EE7D0 VA: 0x1815F01D0 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x15F04B0 Offset: 0x15EEAB0 VA: 0x1815F04B0 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D710 Offset: 0x69BD10 VA: 0x18069D710
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D720 Offset: 0x69BD20 VA: 0x18069D720
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x15EFB80 Offset: 0x15EE180 VA: 0x1815EFB80
	protected void .ctor() { }

	// RVA: 0x15EF560 Offset: 0x15EDB60 VA: 0x1815EF560 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x15EF5C0 Offset: 0x15EDBC0 VA: 0x1815EF5C0 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x15EF730 Offset: 0x15EDD30 VA: 0x1815EF730 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x15EF6A0 Offset: 0x15EDCA0 VA: 0x1815EF6A0 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x15EECA0 Offset: 0x15ED2A0 VA: 0x1815EECA0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15EE210 Offset: 0x15EC810 VA: 0x1815EE210 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x15EED50 Offset: 0x15ED350 VA: 0x1815EED50 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15EFE80 Offset: 0x15EE480 VA: 0x1815EFE80
	public int get_depth() { }

	// RVA: 0x15F01E0 Offset: 0x15EE7E0 VA: 0x1815F01E0 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x15EFCB0 Offset: 0x15EE2B0 VA: 0x1815EFCB0
	public Canvas get_canvas() { }

	// RVA: 0x15ED270 Offset: 0x15EB870 VA: 0x1815ED270
	private void CacheCanvas() { }

	// RVA: 0x15EFC50 Offset: 0x15EE250 VA: 0x1815EFC50
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x15EFE30 Offset: 0x15EE430 VA: 0x1815EFE30 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x15F0140 Offset: 0x15EE740 VA: 0x1815F0140 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x15F0400 Offset: 0x15EEA00 VA: 0x1815F0400 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x15EFF50 Offset: 0x15EE550 VA: 0x1815EFF50 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x15EFEF0 Offset: 0x15EE4F0 VA: 0x1815EFEF0 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x15EE7B0 Offset: 0x15ECDB0 VA: 0x1815EE7B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15EE5C0 Offset: 0x15ECBC0 VA: 0x1815EE5C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15EE500 Offset: 0x15ECB00 VA: 0x1815EE500 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15EE300 Offset: 0x15EC900 VA: 0x1815EE300 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x15EE430 Offset: 0x15ECA30 VA: 0x1815EE430 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x15EF280 Offset: 0x15ED880 VA: 0x1815EF280 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x15EF960 Offset: 0x15EDF60 VA: 0x1815EF960 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x15EF940 Offset: 0x15EDF40 VA: 0x1815EF940 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x15EDBF0 Offset: 0x15EC1F0 VA: 0x1815EDBF0
	private void DoMeshGeneration() { }

	// RVA: 0x15ED7D0 Offset: 0x15EBDD0 VA: 0x1815ED7D0
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x15F0240 Offset: 0x15EE840 VA: 0x1815F0240
	protected static Mesh get_workerMesh() { }

	[EditorBrowsableAttribute] // RVA: 0xEAA30 Offset: 0xE9E30 VA: 0x1800EAA30
	[ObsoleteAttribute] // RVA: 0xEAA30 Offset: 0xE9E30 VA: 0x1800EAA30
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[ObsoleteAttribute] // RVA: 0xEABD0 Offset: 0xE9FD0 VA: 0x1800EABD0
	// RVA: 0x15EE8F0 Offset: 0x15ECEF0 VA: 0x1815EE8F0 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x15EE9A0 Offset: 0x15ECFA0 VA: 0x1815EE9A0 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xFCB5E0 Offset: 0xFC9BE0 VA: 0x180FCB5E0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x15EEF60 Offset: 0x15ED560 VA: 0x1815EEF60 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x15EEE10 Offset: 0x15ED410 VA: 0x1815EEE10
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x15EE060 Offset: 0x15EC660 VA: 0x1815EE060
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x15ED4D0 Offset: 0x15EBAD0 VA: 0x1815ED4D0 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x15ED510 Offset: 0x15EBB10 VA: 0x1815ED510 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x15ED3C0 Offset: 0x15EB9C0 VA: 0x1815ED3C0
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x15ED400 Offset: 0x15EBA00 VA: 0x1815ED400 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x15EF3E0 Offset: 0x15ED9E0 VA: 0x1815EF3E0
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x15EF7C0 Offset: 0x15EDDC0 VA: 0x1815EF7C0
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x15EF4E0 Offset: 0x15EDAE0 VA: 0x1815EF4E0
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x15EF8C0 Offset: 0x15EDEC0 VA: 0x1815EF8C0
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x15EF460 Offset: 0x15EDA60 VA: 0x1815EF460
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x15EF840 Offset: 0x15EDE40 VA: 0x1815EF840
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x15EFAE0 Offset: 0x15EE0E0 VA: 0x1815EFAE0
	private static void .cctor() { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

