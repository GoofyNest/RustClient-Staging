public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 4986
{	// Fields
	protected bool m_ShouldRecalculateStencil; // 0x90
	protected Material m_MaskMaterial; // 0x98
	private RectMask2D m_ParentMask; // 0xA0
	private bool m_Maskable; // 0xA8
	[EditorBrowsableAttribute] // RVA: 0x75E40 Offset: 0x75240 VA: 0x180075E40
	[ObsoleteAttribute] // RVA: 0x75E40 Offset: 0x75240 VA: 0x180075E40
	protected bool m_IncludeForMasking; // 0xA9
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xB0
	[EditorBrowsableAttribute] // RVA: 0x76020 Offset: 0x75420 VA: 0x180076020
	[ObsoleteAttribute] // RVA: 0x76020 Offset: 0x75420 VA: 0x180076020
	protected bool m_ShouldRecalculate; // 0xB8
	protected int m_StencilValue; // 0xBC
	private readonly Vector3[] m_Corners; // 0xC0

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0xA4D220 Offset: 0xA4B820 VA: 0x180A4D220
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x8084F0 Offset: 0x806AF0 VA: 0x1808084F0
	public bool get_maskable() { }

	// RVA: 0x1716BC0 Offset: 0x17151C0 VA: 0x181716BC0
	public void set_maskable(bool value) { }

	// RVA: 0x1715E10 Offset: 0x1714410 VA: 0x181715E10 Slot: 57
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1715DA0 Offset: 0x17143A0 VA: 0x181715DA0 Slot: 58
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1716570 Offset: 0x1714B70 VA: 0x181716570
	private void UpdateCull(bool cull) { }

	// RVA: 0x17162B0 Offset: 0x17148B0 VA: 0x1817162B0 Slot: 59
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x1716100 Offset: 0x1714700 VA: 0x181716100 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1716000 Offset: 0x1714600 VA: 0x181716000 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17161B0 Offset: 0x17147B0 VA: 0x1817161B0 Slot: 12
	protected override void OnTransformParentChanged() { }

	[EditorBrowsableAttribute] // RVA: 0x75E40 Offset: 0x75240 VA: 0x180075E40
	[ObsoleteAttribute] // RVA: 0x75E40 Offset: 0x75240 VA: 0x180075E40
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 60
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x1715FB0 Offset: 0x17145B0 VA: 0x181715FB0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1716710 Offset: 0x1714D10 VA: 0x181716710
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1716310 Offset: 0x1714910 VA: 0x181716310
	private void UpdateClipParent() { }

	// RVA: 0x1716200 Offset: 0x1714800 VA: 0x181716200 Slot: 61
	public virtual void RecalculateClipping() { }

	// RVA: 0x1716210 Offset: 0x1714810 VA: 0x181716210 Slot: 62
	public virtual void RecalculateMasking() { }

	// RVA: 0x1716630 Offset: 0x1714C30 VA: 0x181716630
	protected void .ctor() { }

	// RVA: 0x4EFC70 Offset: 0x4EE270 VA: 0x1804EFC70 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 4987
{	// Methods

	// RVA: 0x170FD30 Offset: 0x170E330 VA: 0x18170FD30
	public void .ctor() { }

}

