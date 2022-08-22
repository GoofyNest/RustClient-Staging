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

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_horizontal() { }

	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_horizontal(bool value) { }

	// RVA: 0xB106C0 Offset: 0xB0ECC0 VA: 0x180B106C0
	public bool get_vertical() { }

	// RVA: 0x13A3A40 Offset: 0x13A2040 VA: 0x1813A3A40
	public void set_vertical(bool value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x862B30 Offset: 0x861130 VA: 0x180862B30
	public float get_elasticity() { }

	// RVA: 0x862BA0 Offset: 0x8611A0 VA: 0x180862BA0
	public void set_elasticity(float value) { }

	// RVA: 0x171F7F0 Offset: 0x171DDF0 VA: 0x18171F7F0
	public bool get_inertia() { }

	// RVA: 0xC42D40 Offset: 0xC41340 VA: 0x180C42D40
	public void set_inertia(bool value) { }

	// RVA: 0x6BBA40 Offset: 0x6BA040 VA: 0x1806BBA40
	public float get_decelerationRate() { }

	// RVA: 0x4E63E0 Offset: 0x4E49E0 VA: 0x1804E63E0
	public void set_decelerationRate(float value) { }

	// RVA: 0xA34630 Offset: 0xA32C30 VA: 0x180A34630
	public float get_scrollSensitivity() { }

	// RVA: 0x171FE80 Offset: 0x171E480 VA: 0x18171FE80
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public RectTransform get_viewport() { }

	// RVA: 0x1720030 Offset: 0x171E630 VA: 0x181720030
	public void set_viewport(RectTransform value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x171FCB0 Offset: 0x171E2B0 VA: 0x18171FCB0
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x171FEB0 Offset: 0x171E4B0 VA: 0x18171FEB0
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x171FCA0 Offset: 0x171E2A0 VA: 0x18171FCA0
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x171FEA0 Offset: 0x171E4A0 VA: 0x18171FEA0
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x5743C0 Offset: 0x5729C0 VA: 0x1805743C0
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x171FC90 Offset: 0x171E290 VA: 0x18171FC90
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x171FB80 Offset: 0x171E180 VA: 0x18171FB80
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x171FE90 Offset: 0x171E490 VA: 0x18171FE90
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x171FB90 Offset: 0x171E190 VA: 0x18171FB90
	protected RectTransform get_viewRect() { }

	// RVA: 0x171F970 Offset: 0x171DF70 VA: 0x18171F970
	public Vector2 get_velocity() { }

	// RVA: 0x13F5300 Offset: 0x13F3900 VA: 0x1813F5300
	public void set_velocity(Vector2 value) { }

	// RVA: 0x171F850 Offset: 0x171DE50 VA: 0x18171F850
	private RectTransform get_rectTransform() { }

	// RVA: 0x171F490 Offset: 0x171DA90 VA: 0x18171F490
	protected void .ctor() { }

	// RVA: 0x171CFA0 Offset: 0x171B5A0 VA: 0x18171CFA0 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x171E750 Offset: 0x171CD50 VA: 0x18171E750
	private void UpdateCachedData() { }

	// RVA: 0x171CA90 Offset: 0x171B090 VA: 0x18171CA90 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x171C5A0 Offset: 0x171ABA0 VA: 0x18171C5A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x171BAA0 Offset: 0x171A0A0 VA: 0x18171BAA0 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x171B450 Offset: 0x1719A50 VA: 0x18171B450
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x171DF60 Offset: 0x171C560 VA: 0x18171DF60 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x171CCF0 Offset: 0x171B2F0 VA: 0x18171CCF0 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x171CC50 Offset: 0x171B250 VA: 0x18171CC50 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x171C430 Offset: 0x171AA30 VA: 0x18171C430 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x171CC20 Offset: 0x171B220 VA: 0x18171CC20 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x171C7C0 Offset: 0x171ADC0 VA: 0x18171C7C0 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x171D0E0 Offset: 0x171B6E0 VA: 0x18171D0E0 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x171BB10 Offset: 0x171A110 VA: 0x18171BB10 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x171EC60 Offset: 0x171D260 VA: 0x18171EC60
	protected void UpdatePrevData() { }

	// RVA: 0x171F1F0 Offset: 0x171D7F0 VA: 0x18171F1F0
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x171F800 Offset: 0x171DE00 VA: 0x18171F800
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x171FE30 Offset: 0x171E430 VA: 0x18171FE30
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x171F660 Offset: 0x171DC60 VA: 0x18171F660
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x171D340 Offset: 0x171B940 VA: 0x18171D340
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x171F990 Offset: 0x171DF90 VA: 0x18171F990
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x171DF40 Offset: 0x171C540 VA: 0x18171DF40
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x171D340 Offset: 0x171B940 VA: 0x18171D340
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x171DF40 Offset: 0x171C540 VA: 0x18171DF40
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x171DC60 Offset: 0x171C260 VA: 0x18171DC60 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x171D040 Offset: 0x171B640 VA: 0x18171D040
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x171CCE0 Offset: 0x171B2E0 VA: 0x18171CCE0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x171F5F0 Offset: 0x171DBF0 VA: 0x18171F5F0
	private bool get_hScrollingNeeded() { }

	// RVA: 0x171F8F0 Offset: 0x171DEF0 VA: 0x18171F8F0
	private bool get_vScrollingNeeded() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x171D360 Offset: 0x171B960 VA: 0x18171D360 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x171DAC0 Offset: 0x171C0C0 VA: 0x18171DAC0 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x171F140 Offset: 0x171D740 VA: 0x18171F140
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x171EB60 Offset: 0x171D160 VA: 0x18171EB60
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x171ED50 Offset: 0x171D350 VA: 0x18171ED50
	private void UpdateScrollbarLayout() { }

	// RVA: 0x171DFD0 Offset: 0x171C5D0 VA: 0x18171DFD0
	protected void UpdateBounds() { }

	// RVA: 0x171B2A0 Offset: 0x17198A0 VA: 0x18171B2A0
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x171B4C0 Offset: 0x1719AC0 VA: 0x18171B4C0
	private Bounds GetBounds() { }

	// RVA: 0x171B830 Offset: 0x1719E30 VA: 0x18171B830
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x171B400 Offset: 0x1719A00 VA: 0x18171B400
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x171B5F0 Offset: 0x1719BF0 VA: 0x18171B5F0
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x171D2C0 Offset: 0x171B8C0 VA: 0x18171D2C0
	protected void SetDirty() { }

	// RVA: 0x171D210 Offset: 0x171B810 VA: 0x18171D210
	protected void SetDirtyCaching() { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 23
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

	// RVA: 0x171B260 Offset: 0x1719860 VA: 0x18171B260
	public void .ctor() { }

}

