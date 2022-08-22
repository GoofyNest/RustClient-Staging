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

	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0xA4D4E0 Offset: 0xA4BAE0 VA: 0x180A4D4E0
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x808600 Offset: 0x806C00 VA: 0x180808600
	public bool get_maskable() { }

	// RVA: 0x1716E80 Offset: 0x1715480 VA: 0x181716E80
	public void set_maskable(bool value) { }

	// RVA: 0x17160D0 Offset: 0x17146D0 VA: 0x1817160D0 Slot: 57
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1716060 Offset: 0x1714660 VA: 0x181716060 Slot: 58
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1716830 Offset: 0x1714E30 VA: 0x181716830
	private void UpdateCull(bool cull) { }

	// RVA: 0x1716570 Offset: 0x1714B70 VA: 0x181716570 Slot: 59
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x17163C0 Offset: 0x17149C0 VA: 0x1817163C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x17162C0 Offset: 0x17148C0 VA: 0x1817162C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1716470 Offset: 0x1714A70 VA: 0x181716470 Slot: 12
	protected override void OnTransformParentChanged() { }

	[EditorBrowsableAttribute] // RVA: 0x75F10 Offset: 0x75310 VA: 0x180075F10
	[ObsoleteAttribute] // RVA: 0x75F10 Offset: 0x75310 VA: 0x180075F10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 60
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x1716270 Offset: 0x1714870 VA: 0x181716270 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x17169D0 Offset: 0x1714FD0 VA: 0x1817169D0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x17165D0 Offset: 0x1714BD0 VA: 0x1817165D0
	private void UpdateClipParent() { }

	// RVA: 0x17164C0 Offset: 0x1714AC0 VA: 0x1817164C0 Slot: 61
	public virtual void RecalculateClipping() { }

	// RVA: 0x17164D0 Offset: 0x1714AD0 VA: 0x1817164D0 Slot: 62
	public virtual void RecalculateMasking() { }

	// RVA: 0x17168F0 Offset: 0x1714EF0 VA: 0x1817168F0
	protected void .ctor() { }

	// RVA: 0x4EFC70 Offset: 0x4EE270 VA: 0x1804EFC70 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 4987
{	// Methods

	// RVA: 0x170FFF0 Offset: 0x170E5F0 VA: 0x18170FFF0
	public void .ctor() { }

}

