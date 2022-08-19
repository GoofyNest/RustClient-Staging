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

	// RVA: 0x1719850 Offset: 0x1717E50 VA: 0x181719850
	private Canvas get_Canvas() { }

	// RVA: 0x1719990 Offset: 0x1717F90 VA: 0x181719990
	public Rect get_canvasRect() { }

	// RVA: 0x1719A50 Offset: 0x1718050 VA: 0x181719A50
	public RectTransform get_rectTransform() { }

	// RVA: 0x17196E0 Offset: 0x1717CE0 VA: 0x1817196E0
	protected void .ctor() { }

	// RVA: 0x1718CD0 Offset: 0x17172D0 VA: 0x181718CD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1718C40 Offset: 0x1717240 VA: 0x181718C40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1718B10 Offset: 0x1717110 VA: 0x181718B10 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1719AC0 Offset: 0x17180C0 VA: 0x181719AC0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1718D20 Offset: 0x1717320 VA: 0x181718D20 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x1718A20 Offset: 0x1717020 VA: 0x181718A20
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x1719560 Offset: 0x1717B60 VA: 0x181719560
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x1718D00 Offset: 0x1717300 VA: 0x181718D00 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1718C10 Offset: 0x1717210 VA: 0x181718C10 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

}

