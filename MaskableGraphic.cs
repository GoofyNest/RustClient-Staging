public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 4986
{	// Fields
	protected bool m_ShouldRecalculateStencil; // 0x90
	protected Material m_MaskMaterial; // 0x98
	private RectMask2D m_ParentMask; // 0xA0
	private bool m_Maskable; // 0xA8
	[EditorBrowsableAttribute] // RVA: 0x75F10 Offset: 0x75310 VA: 0x180075F10
	[ObsoleteAttribute] // RVA: 0x75F10 Offset: 0x75310 VA: 0x180075F10
	protected bool m_IncludeForMasking; // 0xA9
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xB0
	[EditorBrowsableAttribute] // RVA: 0x760A0 Offset: 0x754A0 VA: 0x1800760A0
	[ObsoleteAttribute] // RVA: 0x760A0 Offset: 0x754A0 VA: 0x1800760A0
	protected bool m_ShouldRecalculate; // 0xB8
	protected int m_StencilValue; // 0xBC
	private readonly Vector3[] m_Corners; // 0xC0

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x79BE40 Offset: 0x79A440 VA: 0x18079BE40
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x808B90 Offset: 0x807190 VA: 0x180808B90
	public bool get_maskable() { }

	// RVA: 0x17102D0 Offset: 0x170E8D0 VA: 0x1817102D0
	public void set_maskable(bool value) { }

	// RVA: 0x170F520 Offset: 0x170DB20 VA: 0x18170F520 Slot: 57
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x170F4B0 Offset: 0x170DAB0 VA: 0x18170F4B0 Slot: 58
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x170FC80 Offset: 0x170E280 VA: 0x18170FC80
	private void UpdateCull(bool cull) { }

	// RVA: 0x170F9C0 Offset: 0x170DFC0 VA: 0x18170F9C0 Slot: 59
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x170F810 Offset: 0x170DE10 VA: 0x18170F810 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x170F710 Offset: 0x170DD10 VA: 0x18170F710 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x170F8C0 Offset: 0x170DEC0 VA: 0x18170F8C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	[EditorBrowsableAttribute] // RVA: 0x75F10 Offset: 0x75310 VA: 0x180075F10
	[ObsoleteAttribute] // RVA: 0x75F10 Offset: 0x75310 VA: 0x180075F10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 60
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x170F6C0 Offset: 0x170DCC0 VA: 0x18170F6C0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x170FE20 Offset: 0x170E420 VA: 0x18170FE20
	private Rect get_rootCanvasRect() { }

	// RVA: 0x170FA20 Offset: 0x170E020 VA: 0x18170FA20
	private void UpdateClipParent() { }

	// RVA: 0x170F910 Offset: 0x170DF10 VA: 0x18170F910 Slot: 61
	public virtual void RecalculateClipping() { }

	// RVA: 0x170F920 Offset: 0x170DF20 VA: 0x18170F920 Slot: 62
	public virtual void RecalculateMasking() { }

	// RVA: 0x170FD40 Offset: 0x170E340 VA: 0x18170FD40
	protected void .ctor() { }

	// RVA: 0x4EFC00 Offset: 0x4EE200 VA: 0x1804EFC00 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 4987
{	// Methods

	// RVA: 0x1709440 Offset: 0x1707A40 VA: 0x181709440
	public void .ctor() { }

}

