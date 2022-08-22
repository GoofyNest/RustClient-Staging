public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4994
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_Content; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_Horizontal; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_Vertical; // 0x21
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRect.MovementType m_MovementType; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Elasticity; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_Inertia; // 0x2C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_DecelerationRate; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_ScrollSensitivity; // 0x34
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_Viewport; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Scrollbar m_HorizontalScrollbar; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Scrollbar m_VerticalScrollbar; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x54
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_HorizontalScrollbarSpacing; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_VerticalScrollbarSpacing; // 0x5C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x60
	private Vector2 m_PointerStartLocalCursor; // 0x68
	protected Vector2 m_ContentStartPosition; // 0x70
	private RectTransform m_ViewRect; // 0x78
	protected Bounds m_ContentBounds; // 0x80
	private Bounds m_ViewBounds; // 0x98
	private Vector2 m_Velocity; // 0xB0
	private bool m_Dragging; // 0xB8
	private bool m_Scrolling; // 0xB9
	private Vector2 m_PrevPosition; // 0xBC
	private Bounds m_PrevContentBounds; // 0xC4
	private Bounds m_PrevViewBounds; // 0xDC
	private bool m_HasRebuiltLayout; // 0xF4
	private bool m_HSliderExpand; // 0xF5
	private bool m_VSliderExpand; // 0xF6
	private float m_HSliderHeight; // 0xF8
	private float m_VSliderWidth; // 0xFC
	private RectTransform m_Rect; // 0x100
	private RectTransform m_HorizontalScrollbarRect; // 0x108
	private RectTransform m_VerticalScrollbarRect; // 0x110
	private DrivenRectTransformTracker m_Tracker; // 0x118
	private readonly Vector3[] m_Corners; // 0x120

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public RectTransform get_content() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_content(RectTransform value) { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_horizontal() { }

	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_horizontal(bool value) { }

	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	public bool get_vertical() { }

	// RVA: 0x13A3780 Offset: 0x13A1D80 VA: 0x1813A3780
	public void set_vertical(bool value) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x862A20 Offset: 0x861020 VA: 0x180862A20
	public float get_elasticity() { }

	// RVA: 0x862A90 Offset: 0x861090 VA: 0x180862A90
	public void set_elasticity(float value) { }

	// RVA: 0x171F530 Offset: 0x171DB30 VA: 0x18171F530
	public bool get_inertia() { }

	// RVA: 0xC42A80 Offset: 0xC41080 VA: 0x180C42A80
	public void set_inertia(bool value) { }

	// RVA: 0x6BB930 Offset: 0x6B9F30 VA: 0x1806BB930
	public float get_decelerationRate() { }

	// RVA: 0x4E63E0 Offset: 0x4E49E0 VA: 0x1804E63E0
	public void set_decelerationRate(float value) { }

	// RVA: 0xA34370 Offset: 0xA32970 VA: 0x180A34370
	public float get_scrollSensitivity() { }

	// RVA: 0x171FBC0 Offset: 0x171E1C0 VA: 0x18171FBC0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public RectTransform get_viewport() { }

	// RVA: 0x171FD70 Offset: 0x171E370 VA: 0x18171FD70
	public void set_viewport(RectTransform value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x171F9F0 Offset: 0x171DFF0 VA: 0x18171F9F0
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x171FBF0 Offset: 0x171E1F0 VA: 0x18171FBF0
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x171F9E0 Offset: 0x171DFE0 VA: 0x18171F9E0
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x171FBE0 Offset: 0x171E1E0 VA: 0x18171FBE0
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x5743C0 Offset: 0x5729C0 VA: 0x1805743C0
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x171F9D0 Offset: 0x171DFD0 VA: 0x18171F9D0
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x171F8C0 Offset: 0x171DEC0 VA: 0x18171F8C0
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x171FBD0 Offset: 0x171E1D0 VA: 0x18171FBD0
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x171F8D0 Offset: 0x171DED0 VA: 0x18171F8D0
	protected RectTransform get_viewRect() { }

	// RVA: 0x171F6B0 Offset: 0x171DCB0 VA: 0x18171F6B0
	public Vector2 get_velocity() { }

	// RVA: 0x13F5040 Offset: 0x13F3640 VA: 0x1813F5040
	public void set_velocity(Vector2 value) { }

	// RVA: 0x171F590 Offset: 0x171DB90 VA: 0x18171F590
	private RectTransform get_rectTransform() { }

	// RVA: 0x171F1D0 Offset: 0x171D7D0 VA: 0x18171F1D0
	protected void .ctor() { }

	// RVA: 0x171CCE0 Offset: 0x171B2E0 VA: 0x18171CCE0 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x171E490 Offset: 0x171CA90 VA: 0x18171E490
	private void UpdateCachedData() { }

	// RVA: 0x171C7D0 Offset: 0x171ADD0 VA: 0x18171C7D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x171C2E0 Offset: 0x171A8E0 VA: 0x18171C2E0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x171B7E0 Offset: 0x1719DE0 VA: 0x18171B7E0 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x171B190 Offset: 0x1719790 VA: 0x18171B190
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x171DCA0 Offset: 0x171C2A0 VA: 0x18171DCA0 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x171CA30 Offset: 0x171B030 VA: 0x18171CA30 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x171C990 Offset: 0x171AF90 VA: 0x18171C990 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x171C170 Offset: 0x171A770 VA: 0x18171C170 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x171C960 Offset: 0x171AF60 VA: 0x18171C960 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x171C500 Offset: 0x171AB00 VA: 0x18171C500 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x171CE20 Offset: 0x171B420 VA: 0x18171CE20 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x171B850 Offset: 0x1719E50 VA: 0x18171B850 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x171E9A0 Offset: 0x171CFA0 VA: 0x18171E9A0
	protected void UpdatePrevData() { }

	// RVA: 0x171EF30 Offset: 0x171D530 VA: 0x18171EF30
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x171F540 Offset: 0x171DB40 VA: 0x18171F540
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x171FB70 Offset: 0x171E170 VA: 0x18171FB70
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x171F3A0 Offset: 0x171D9A0 VA: 0x18171F3A0
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x171D080 Offset: 0x171B680 VA: 0x18171D080
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x171F6D0 Offset: 0x171DCD0 VA: 0x18171F6D0
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x171DC80 Offset: 0x171C280 VA: 0x18171DC80
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x171D080 Offset: 0x171B680 VA: 0x18171D080
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x171DC80 Offset: 0x171C280 VA: 0x18171DC80
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x171D9A0 Offset: 0x171BFA0 VA: 0x18171D9A0 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x171CD80 Offset: 0x171B380 VA: 0x18171CD80
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x171CA20 Offset: 0x171B020 VA: 0x18171CA20 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x171F330 Offset: 0x171D930 VA: 0x18171F330
	private bool get_hScrollingNeeded() { }

	// RVA: 0x171F630 Offset: 0x171DC30 VA: 0x18171F630
	private bool get_vScrollingNeeded() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x171D0A0 Offset: 0x171B6A0 VA: 0x18171D0A0 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x171D800 Offset: 0x171BE00 VA: 0x18171D800 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x171EE80 Offset: 0x171D480 VA: 0x18171EE80
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x171E8A0 Offset: 0x171CEA0 VA: 0x18171E8A0
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x171EA90 Offset: 0x171D090 VA: 0x18171EA90
	private void UpdateScrollbarLayout() { }

	// RVA: 0x171DD10 Offset: 0x171C310 VA: 0x18171DD10
	protected void UpdateBounds() { }

	// RVA: 0x171AFE0 Offset: 0x17195E0 VA: 0x18171AFE0
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x171B200 Offset: 0x1719800 VA: 0x18171B200
	private Bounds GetBounds() { }

	// RVA: 0x171B570 Offset: 0x1719B70 VA: 0x18171B570
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x171B140 Offset: 0x1719740 VA: 0x18171B140
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x171B330 Offset: 0x1719930 VA: 0x18171B330
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x171D000 Offset: 0x171B600 VA: 0x18171D000
	protected void SetDirty() { }

	// RVA: 0x171CF50 Offset: 0x171B550 VA: 0x18171CF50
	protected void SetDirtyCaching() { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum ScrollRect.MovementType // TypeDefIndex: 4995
{	// Fields
	public int value__; // 0x0
	public const ScrollRect.MovementType Unrestricted = 0;
	public const ScrollRect.MovementType Elastic = 1;
	public const ScrollRect.MovementType Clamped = 2;

}

public enum ScrollRect.ScrollbarVisibility // TypeDefIndex: 4996
{	// Fields
	public int value__; // 0x0
	public const ScrollRect.ScrollbarVisibility Permanent = 0;
	public const ScrollRect.ScrollbarVisibility AutoHide = 1;
	public const ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport = 2;

}

public class ScrollRect.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 4997
{	// Methods

	// RVA: 0x171AFA0 Offset: 0x17195A0 VA: 0x18171AFA0
	public void .ctor() { }

}

