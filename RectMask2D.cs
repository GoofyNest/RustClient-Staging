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

	// RVA: 0x1712F60 Offset: 0x1711560 VA: 0x181712F60
	private Canvas get_Canvas() { }

	// RVA: 0x17130A0 Offset: 0x17116A0 VA: 0x1817130A0
	public Rect get_canvasRect() { }

	// RVA: 0x1713160 Offset: 0x1711760 VA: 0x181713160
	public RectTransform get_rectTransform() { }

	// RVA: 0x1712DF0 Offset: 0x17113F0 VA: 0x181712DF0
	protected void .ctor() { }

	// RVA: 0x17123E0 Offset: 0x17109E0 VA: 0x1817123E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1712350 Offset: 0x1710950 VA: 0x181712350 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1712220 Offset: 0x1710820 VA: 0x181712220 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x17131D0 Offset: 0x17117D0 VA: 0x1817131D0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1712430 Offset: 0x1710A30 VA: 0x181712430 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x1712130 Offset: 0x1710730 VA: 0x181712130
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x1712C70 Offset: 0x1711270 VA: 0x181712C70
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x1712410 Offset: 0x1710A10 VA: 0x181712410 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1712320 Offset: 0x1710920 VA: 0x181712320 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

}

