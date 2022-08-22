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

	// RVA: 0x15DD050 Offset: 0x15DB650 VA: 0x1815DD050
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0xD680B0 Offset: 0xD666B0 VA: 0x180D680B0 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x15DD6D0 Offset: 0x15DBCD0 VA: 0x1815DD6D0 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x15DD4F0 Offset: 0x15DBAF0 VA: 0x1815DD4F0 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x15DD7D0 Offset: 0x15DBDD0 VA: 0x1815DD7D0 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6A0 Offset: 0x69BCA0 VA: 0x18069D6A0
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6B0 Offset: 0x69BCB0 VA: 0x18069D6B0
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x15DCEA0 Offset: 0x15DB4A0 VA: 0x1815DCEA0
	protected void .ctor() { }

	// RVA: 0x15DC880 Offset: 0x15DAE80 VA: 0x1815DC880 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x15DC8E0 Offset: 0x15DAEE0 VA: 0x1815DC8E0 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x15DCA50 Offset: 0x15DB050 VA: 0x1815DCA50 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x15DC9C0 Offset: 0x15DAFC0 VA: 0x1815DC9C0 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x15DBFC0 Offset: 0x15DA5C0 VA: 0x1815DBFC0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15DB530 Offset: 0x15D9B30 VA: 0x1815DB530 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x15DC070 Offset: 0x15DA670 VA: 0x1815DC070 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15DD1A0 Offset: 0x15DB7A0 VA: 0x1815DD1A0
	public int get_depth() { }

	// RVA: 0x15DD500 Offset: 0x15DBB00 VA: 0x1815DD500 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x15DCFD0 Offset: 0x15DB5D0 VA: 0x1815DCFD0
	public Canvas get_canvas() { }

	// RVA: 0x15DA590 Offset: 0x15D8B90 VA: 0x1815DA590
	private void CacheCanvas() { }

	// RVA: 0x15DCF70 Offset: 0x15DB570 VA: 0x1815DCF70
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x15DD150 Offset: 0x15DB750 VA: 0x1815DD150 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x15DD460 Offset: 0x15DBA60 VA: 0x1815DD460 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x15DD720 Offset: 0x15DBD20 VA: 0x1815DD720 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x15DD270 Offset: 0x15DB870 VA: 0x1815DD270 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x15DD210 Offset: 0x15DB810 VA: 0x1815DD210 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x15DBAD0 Offset: 0x15DA0D0 VA: 0x1815DBAD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15DB8E0 Offset: 0x15D9EE0 VA: 0x1815DB8E0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15DB820 Offset: 0x15D9E20 VA: 0x1815DB820 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15DB620 Offset: 0x15D9C20 VA: 0x1815DB620 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x15DB750 Offset: 0x15D9D50 VA: 0x1815DB750 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x15DC5A0 Offset: 0x15DABA0 VA: 0x1815DC5A0 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x15DCC80 Offset: 0x15DB280 VA: 0x1815DCC80 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x15DCC60 Offset: 0x15DB260 VA: 0x1815DCC60 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x15DAF10 Offset: 0x15D9510 VA: 0x1815DAF10
	private void DoMeshGeneration() { }

	// RVA: 0x15DAAF0 Offset: 0x15D90F0 VA: 0x1815DAAF0
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x15DD560 Offset: 0x15DBB60 VA: 0x1815DD560
	protected static Mesh get_workerMesh() { }

	[EditorBrowsableAttribute] // RVA: 0xEAA30 Offset: 0xE9E30 VA: 0x1800EAA30
	[ObsoleteAttribute] // RVA: 0xEAA30 Offset: 0xE9E30 VA: 0x1800EAA30
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[ObsoleteAttribute] // RVA: 0xEABD0 Offset: 0xE9FD0 VA: 0x1800EABD0
	// RVA: 0x15DBC10 Offset: 0x15DA210 VA: 0x1815DBC10 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x15DBCC0 Offset: 0x15DA2C0 VA: 0x1815DBCC0 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xFCC080 Offset: 0xFCA680 VA: 0x180FCC080 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x15DC280 Offset: 0x15DA880 VA: 0x1815DC280 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x15DC130 Offset: 0x15DA730 VA: 0x1815DC130
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x15DB380 Offset: 0x15D9980 VA: 0x1815DB380
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x15DA7F0 Offset: 0x15D8DF0 VA: 0x1815DA7F0 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x15DA830 Offset: 0x15D8E30 VA: 0x1815DA830 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x15DA6E0 Offset: 0x15D8CE0 VA: 0x1815DA6E0
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x15DA720 Offset: 0x15D8D20 VA: 0x1815DA720 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x15DC700 Offset: 0x15DAD00 VA: 0x1815DC700
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x15DCAE0 Offset: 0x15DB0E0 VA: 0x1815DCAE0
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x15DC800 Offset: 0x15DAE00 VA: 0x1815DC800
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x15DCBE0 Offset: 0x15DB1E0 VA: 0x1815DCBE0
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x15DC780 Offset: 0x15DAD80 VA: 0x1815DC780
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x15DCB60 Offset: 0x15DB160 VA: 0x1815DCB60
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x15DCE00 Offset: 0x15DB400 VA: 0x1815DCE00
	private static void .cctor() { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

