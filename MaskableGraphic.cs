public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 4986
{	protected bool m_ShouldRecalculateStencil; // 0x90
	protected Material m_MaskMaterial; // 0x98
	private RectMask2D m_ParentMask; // 0xA0
	private bool m_Maskable; // 0xA8
	[EditorBrowsableAttribute] // RVA: 0x75FC0 Offset: 0x753C0 VA: 0x180075FC0
	[ObsoleteAttribute] // RVA: 0x75FC0 Offset: 0x753C0 VA: 0x180075FC0
	protected bool m_IncludeForMasking; // 0xA9
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xB0
	[EditorBrowsableAttribute] // RVA: 0x76160 Offset: 0x75560 VA: 0x180076160
	[ObsoleteAttribute] // RVA: 0x76160 Offset: 0x75560 VA: 0x180076160
	protected bool m_ShouldRecalculate; // 0xB8
	protected int m_StencilValue; // 0xBC
	private readonly Vector3[] m_Corners; // 0xC0

	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	private Rect rootCanvasRect { get; }


	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	public bool get_maskable() { }

	public void set_maskable(bool value) { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	public virtual void Cull(Rect clipRect, bool validRect) { }

	private void UpdateCull(bool cull) { }

	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnTransformParentChanged() { }

	[EditorBrowsableAttribute] // RVA: 0x75FC0 Offset: 0x753C0 VA: 0x180075FC0
	[ObsoleteAttribute] // RVA: 0x75FC0 Offset: 0x753C0 VA: 0x180075FC0
	public virtual void ParentMaskStateChanged() { }

	protected override void OnCanvasHierarchyChanged() { }

	private Rect get_rootCanvasRect() { }

	private void UpdateClipParent() { }

	public virtual void RecalculateClipping() { }

	public virtual void RecalculateMasking() { }

	protected void .ctor() { }

	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 4987
{
	public void .ctor() { }

}

