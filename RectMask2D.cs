public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 4993
{	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x18
	private RectTransform m_RectTransform; // 0x20
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x28
	private HashSet<IClippable> m_ClipTargets; // 0x30
	private bool m_ShouldRecalculateClipRects; // 0x38
	private List<RectMask2D> m_Clippers; // 0x40
	private Rect m_LastClipRectCanvasSpace; // 0x48
	private bool m_ForceClip; // 0x58
	private Canvas m_Canvas; // 0x60
	private Vector3[] m_Corners; // 0x68

	// Properties
	private Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x1719B10 Offset: 0x1718110 VA: 0x181719B10
	private Canvas get_Canvas() { }

	// RVA: 0x1719C50 Offset: 0x1718250 VA: 0x181719C50
	public Rect get_canvasRect() { }

	// RVA: 0x1719D10 Offset: 0x1718310 VA: 0x181719D10
	public RectTransform get_rectTransform() { }

	// RVA: 0x17199A0 Offset: 0x1717FA0 VA: 0x1817199A0
	protected void .ctor() { }

	// RVA: 0x1718F90 Offset: 0x1717590 VA: 0x181718F90 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1718F00 Offset: 0x1717500 VA: 0x181718F00 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1718DD0 Offset: 0x17173D0 VA: 0x181718DD0 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1719D80 Offset: 0x1718380 VA: 0x181719D80
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1718FE0 Offset: 0x17175E0 VA: 0x181718FE0 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x1718CE0 Offset: 0x17172E0 VA: 0x181718CE0
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x1719820 Offset: 0x1717E20 VA: 0x181719820
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x1718FC0 Offset: 0x17175C0 VA: 0x181718FC0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1718ED0 Offset: 0x17174D0 VA: 0x181718ED0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

}

