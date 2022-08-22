public class ScrollRectEx : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutGroup, ILayoutController // TypeDefIndex: 11711
{	// Fields
	public PointerEventData.InputButton scrollButton; // 0x18
	public PointerEventData.InputButton altScrollButton; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_Content; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_Horizontal; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_Vertical; // 0x29
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRectEx.MovementType m_MovementType; // 0x2C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Elasticity; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_Inertia; // 0x34
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_DecelerationRate; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_ScrollSensitivity; // 0x3C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_Viewport; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Scrollbar m_HorizontalScrollbar; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Scrollbar m_VerticalScrollbar; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRectEx.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRectEx.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x5C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_HorizontalScrollbarSpacing; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_VerticalScrollbarSpacing; // 0x64
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRectEx.ScrollRectEvent m_OnValueChanged; // 0x68
	private Vector2 m_PointerStartLocalCursor; // 0x70
	private Vector2 m_ContentStartPosition; // 0x78
	private RectTransform m_ViewRect; // 0x80
	private Bounds m_ContentBounds; // 0x88
	private Bounds m_ViewBounds; // 0xA0
	private Vector2 m_Velocity; // 0xB8
	private bool m_Dragging; // 0xC0
	private Vector2 m_PrevPosition; // 0xC4
	private Bounds m_PrevContentBounds; // 0xCC
	private Bounds m_PrevViewBounds; // 0xE4
	private bool m_HasRebuiltLayout; // 0xFC
	private bool m_HSliderExpand; // 0xFD
	private bool m_VSliderExpand; // 0xFE
	private float m_HSliderHeight; // 0x100
	private float m_VSliderWidth; // 0x104
	private RectTransform m_Rect; // 0x108
	private RectTransform m_HorizontalScrollbarRect; // 0x110
	private RectTransform m_VerticalScrollbarRect; // 0x118
	private DrivenRectTransformTracker m_Tracker; // 0x120
	private readonly Vector3[] m_Corners; // 0x128

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRectEx.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRectEx.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRectEx.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRectEx.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }

	// Methods

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public RectTransform get_content() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_content(RectTransform value) { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	public bool get_horizontal() { }

	// RVA: 0x997600 Offset: 0x995C00 VA: 0x180997600
	public void set_horizontal(bool value) { }

	// RVA: 0x73AD00 Offset: 0x739300 VA: 0x18073AD00
	public bool get_vertical() { }

	// RVA: 0x1124780 Offset: 0x1122D80 VA: 0x181124780
	public void set_vertical(bool value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public ScrollRectEx.MovementType get_movementType() { }

	// RVA: 0x10B82E0 Offset: 0x10B68E0 VA: 0x1810B82E0
	public void set_movementType(ScrollRectEx.MovementType value) { }

	// RVA: 0x6BBA40 Offset: 0x6BA040 VA: 0x1806BBA40
	public float get_elasticity() { }

	// RVA: 0x4E63E0 Offset: 0x4E49E0 VA: 0x1804E63E0
	public void set_elasticity(float value) { }

	// RVA: 0xBA1D40 Offset: 0xBA0340 VA: 0x180BA1D40
	public bool get_inertia() { }

	// RVA: 0xE72F70 Offset: 0xE71570 VA: 0x180E72F70
	public void set_inertia(bool value) { }

	// RVA: 0x10B80E0 Offset: 0x10B66E0 VA: 0x1810B80E0
	public float get_decelerationRate() { }

	// RVA: 0x10B8180 Offset: 0x10B6780 VA: 0x1810B8180
	public void set_decelerationRate(float value) { }

	// RVA: 0xA21B80 Offset: 0xA20180 VA: 0x180A21B80
	public float get_scrollSensitivity() { }

	// RVA: 0x522390 Offset: 0x520990 VA: 0x180522390
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public RectTransform get_viewport() { }

	// RVA: 0x1124790 Offset: 0x1122D90 VA: 0x181124790
	public void set_viewport(RectTransform value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x1124410 Offset: 0x1122A10 VA: 0x181124410
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1124600 Offset: 0x1122C00 VA: 0x181124600
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	public ScrollRectEx.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x1124400 Offset: 0x1122A00 VA: 0x181124400
	public void set_horizontalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public ScrollRectEx.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x11245F0 Offset: 0x1122BF0 VA: 0x1811245F0
	public void set_verticalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	// RVA: 0x6C0B50 Offset: 0x6BF150 VA: 0x1806C0B50
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x11243F0 Offset: 0x11229F0 VA: 0x1811243F0
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x11242E0 Offset: 0x11228E0 VA: 0x1811242E0
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x11245E0 Offset: 0x1122BE0 VA: 0x1811245E0
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public ScrollRectEx.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	public void set_onValueChanged(ScrollRectEx.ScrollRectEvent value) { }

	// RVA: 0x11242F0 Offset: 0x11228F0 VA: 0x1811242F0
	protected RectTransform get_viewRect() { }

	// RVA: 0x1124150 Offset: 0x1122750 VA: 0x181124150
	public Vector2 get_velocity() { }

	// RVA: 0x11245D0 Offset: 0x1122BD0 VA: 0x1811245D0
	public void set_velocity(Vector2 value) { }

	// RVA: 0x1124030 Offset: 0x1122630 VA: 0x181124030
	private RectTransform get_rectTransform() { }

	// RVA: 0x1123CF0 Offset: 0x11222F0 VA: 0x181123CF0
	protected void .ctor() { }

	// RVA: 0x1121BE0 Offset: 0x11201E0 VA: 0x181121BE0 Slot: 29
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1122FE0 Offset: 0x11215E0 VA: 0x181122FE0
	private void UpdateCachedData() { }

	// RVA: 0x1121730 Offset: 0x111FD30 VA: 0x181121730 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1121250 Offset: 0x111F850 VA: 0x181121250 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1120850 Offset: 0x111EE50 VA: 0x181120850 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x1120480 Offset: 0x111EA80 VA: 0x181120480
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x1122B80 Offset: 0x1121180 VA: 0x181122B80 Slot: 30
	public virtual void StopMovement() { }

	// RVA: 0x1121990 Offset: 0x111FF90 VA: 0x181121990 Slot: 31
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x11218E0 Offset: 0x111FEE0 VA: 0x1811218E0 Slot: 32
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x11210D0 Offset: 0x111F6D0 VA: 0x1811210D0 Slot: 33
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x11218B0 Offset: 0x111FEB0 VA: 0x1811218B0 Slot: 34
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1121460 Offset: 0x111FA60 VA: 0x181121460 Slot: 35
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1121D20 Offset: 0x1120320 VA: 0x181121D20 Slot: 36
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x11208C0 Offset: 0x111EEC0 VA: 0x1811208C0 Slot: 37
	protected virtual void LateUpdate() { }

	// RVA: 0x11233F0 Offset: 0x11219F0 VA: 0x1811233F0
	private void UpdatePrevData() { }

	// RVA: 0x1123A50 Offset: 0x1122050 VA: 0x181123A50
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x1123FE0 Offset: 0x11225E0 VA: 0x181123FE0
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x1124590 Offset: 0x1122B90 VA: 0x181124590
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x1123EC0 Offset: 0x11224C0 VA: 0x181123EC0
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x1121F80 Offset: 0x1120580 VA: 0x181121F80
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x1124170 Offset: 0x1122770 VA: 0x181124170
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x1122B70 Offset: 0x1121170 VA: 0x181122B70
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x1121F80 Offset: 0x1120580 VA: 0x181121F80
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x1122B70 Offset: 0x1121170 VA: 0x181122B70
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x1122890 Offset: 0x1120E90 VA: 0x181122890
	private void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x1121C80 Offset: 0x1120280 VA: 0x181121C80
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x1121980 Offset: 0x111FF80 VA: 0x181121980 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1123E50 Offset: 0x1122450 VA: 0x181123E50
	private bool get_hScrollingNeeded() { }

	// RVA: 0x11240D0 Offset: 0x11226D0 VA: 0x1811240D0
	private bool get_vScrollingNeeded() { }

	// RVA: 0x1121F90 Offset: 0x1120590 VA: 0x181121F90 Slot: 38
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x11226F0 Offset: 0x1120CF0 VA: 0x1811226F0 Slot: 39
	public virtual void SetLayoutVertical() { }

	// RVA: 0x11238D0 Offset: 0x1121ED0 VA: 0x1811238D0
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x11234E0 Offset: 0x1121AE0 VA: 0x1811234E0
	private void UpdateScrollbarLayout() { }

	// RVA: 0x1122BF0 Offset: 0x11211F0 VA: 0x181122BF0
	private void UpdateBounds() { }

	// RVA: 0x11204F0 Offset: 0x111EAF0 VA: 0x1811204F0
	private Bounds GetBounds() { }

	// RVA: 0x111FF00 Offset: 0x111E500 VA: 0x18111FF00
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x1121F00 Offset: 0x1120500 VA: 0x181121F00
	protected void SetDirty() { }

	// RVA: 0x1121E50 Offset: 0x1120450 VA: 0x181121E50
	protected void SetDirtyCaching() { }

	// RVA: 0x1120170 Offset: 0x111E770 VA: 0x181120170
	public void CenterOnPosition(Vector2 pos) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 24
	public void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 25
	public void GraphicUpdateComplete() { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum ScrollRectEx.MovementType // TypeDefIndex: 11712
{	// Fields
	public int value__; // 0x0
	public const ScrollRectEx.MovementType Unrestricted = 0;
	public const ScrollRectEx.MovementType Elastic = 1;
	public const ScrollRectEx.MovementType Clamped = 2;

}

public enum ScrollRectEx.ScrollbarVisibility // TypeDefIndex: 11713
{	// Fields
	public int value__; // 0x0
	public const ScrollRectEx.ScrollbarVisibility Permanent = 0;
	public const ScrollRectEx.ScrollbarVisibility AutoHide = 1;
	public const ScrollRectEx.ScrollbarVisibility AutoHideAndExpandViewport = 2;

}

public class ScrollRectEx.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 11714
{	// Methods

	// RVA: 0x111FEC0 Offset: 0x111E4C0 VA: 0x18111FEC0
	public void .ctor() { }

}

