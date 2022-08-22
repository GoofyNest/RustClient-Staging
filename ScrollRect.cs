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

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_content(RectTransform value) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_horizontal() { }

	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_horizontal(bool value) { }

	// RVA: 0xB10B90 Offset: 0xB0F190 VA: 0x180B10B90
	public bool get_vertical() { }

	// RVA: 0x13A2B40 Offset: 0x13A1140 VA: 0x1813A2B40
	public void set_vertical(bool value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x87E290 Offset: 0x87C890 VA: 0x18087E290
	public float get_elasticity() { }

	// RVA: 0x87E300 Offset: 0x87C900 VA: 0x18087E300
	public void set_elasticity(float value) { }

	// RVA: 0x1645210 Offset: 0x1643810 VA: 0x181645210
	public bool get_inertia() { }

	// RVA: 0xC43210 Offset: 0xC41810 VA: 0x180C43210
	public void set_inertia(bool value) { }

	// RVA: 0x6BB9D0 Offset: 0x6B9FD0 VA: 0x1806BB9D0
	public float get_decelerationRate() { }

	// RVA: 0x4E6370 Offset: 0x4E4970 VA: 0x1804E6370
	public void set_decelerationRate(float value) { }

	// RVA: 0xA34B20 Offset: 0xA33120 VA: 0x180A34B20
	public float get_scrollSensitivity() { }

	// RVA: 0x17192C0 Offset: 0x17178C0 VA: 0x1817192C0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public RectTransform get_viewport() { }

	// RVA: 0x1719470 Offset: 0x1717A70 VA: 0x181719470
	public void set_viewport(RectTransform value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x17190F0 Offset: 0x17176F0 VA: 0x1817190F0
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x17192F0 Offset: 0x17178F0 VA: 0x1817192F0
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x17190E0 Offset: 0x17176E0 VA: 0x1817190E0
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x17192E0 Offset: 0x17178E0 VA: 0x1817192E0
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x574350 Offset: 0x572950 VA: 0x180574350
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x17190D0 Offset: 0x17176D0 VA: 0x1817190D0
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x1718FC0 Offset: 0x17175C0 VA: 0x181718FC0
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x17192D0 Offset: 0x17178D0 VA: 0x1817192D0
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x1718FD0 Offset: 0x17175D0 VA: 0x181718FD0
	protected RectTransform get_viewRect() { }

	// RVA: 0x1718DB0 Offset: 0x17173B0 VA: 0x181718DB0
	public Vector2 get_velocity() { }

	// RVA: 0x13F43E0 Offset: 0x13F29E0 VA: 0x1813F43E0
	public void set_velocity(Vector2 value) { }

	// RVA: 0x1718C90 Offset: 0x1717290 VA: 0x181718C90
	private RectTransform get_rectTransform() { }

	// RVA: 0x17188E0 Offset: 0x1716EE0 VA: 0x1817188E0
	protected void .ctor() { }

	// RVA: 0x17163F0 Offset: 0x17149F0 VA: 0x1817163F0 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1717BA0 Offset: 0x17161A0 VA: 0x181717BA0
	private void UpdateCachedData() { }

	// RVA: 0x1715EE0 Offset: 0x17144E0 VA: 0x181715EE0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x17159F0 Offset: 0x1713FF0 VA: 0x1817159F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1714EF0 Offset: 0x17134F0 VA: 0x181714EF0 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x17148A0 Offset: 0x1712EA0 VA: 0x1817148A0
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x17173B0 Offset: 0x17159B0 VA: 0x1817173B0 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x1716140 Offset: 0x1714740 VA: 0x181716140 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x17160A0 Offset: 0x17146A0 VA: 0x1817160A0 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1715880 Offset: 0x1713E80 VA: 0x181715880 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1716070 Offset: 0x1714670 VA: 0x181716070 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1715C10 Offset: 0x1714210 VA: 0x181715C10 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1716530 Offset: 0x1714B30 VA: 0x181716530 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x1714F60 Offset: 0x1713560 VA: 0x181714F60 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x17180B0 Offset: 0x17166B0 VA: 0x1817180B0
	protected void UpdatePrevData() { }

	// RVA: 0x1718640 Offset: 0x1716C40 VA: 0x181718640
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x1718C40 Offset: 0x1717240 VA: 0x181718C40
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x1719270 Offset: 0x1717870 VA: 0x181719270
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x1718AB0 Offset: 0x17170B0 VA: 0x181718AB0
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x1716790 Offset: 0x1714D90 VA: 0x181716790
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x1718DD0 Offset: 0x17173D0 VA: 0x181718DD0
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x1717390 Offset: 0x1715990 VA: 0x181717390
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x1716790 Offset: 0x1714D90 VA: 0x181716790
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x1717390 Offset: 0x1715990 VA: 0x181717390
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x17170B0 Offset: 0x17156B0 VA: 0x1817170B0 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x1716490 Offset: 0x1714A90 VA: 0x181716490
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x1716130 Offset: 0x1714730 VA: 0x181716130 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1718A40 Offset: 0x1717040 VA: 0x181718A40
	private bool get_hScrollingNeeded() { }

	// RVA: 0x1718D30 Offset: 0x1717330 VA: 0x181718D30
	private bool get_vScrollingNeeded() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x17167B0 Offset: 0x1714DB0 VA: 0x1817167B0 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1716F10 Offset: 0x1715510 VA: 0x181716F10 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1718590 Offset: 0x1716B90 VA: 0x181718590
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x1717FB0 Offset: 0x17165B0 VA: 0x181717FB0
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x17181A0 Offset: 0x17167A0 VA: 0x1817181A0
	private void UpdateScrollbarLayout() { }

	// RVA: 0x1717420 Offset: 0x1715A20 VA: 0x181717420
	protected void UpdateBounds() { }

	// RVA: 0x17146F0 Offset: 0x1712CF0 VA: 0x1817146F0
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x1714910 Offset: 0x1712F10 VA: 0x181714910
	private Bounds GetBounds() { }

	// RVA: 0x1714C80 Offset: 0x1713280 VA: 0x181714C80
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x1714850 Offset: 0x1712E50 VA: 0x181714850
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x1714A40 Offset: 0x1713040 VA: 0x181714A40
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x1716710 Offset: 0x1714D10 VA: 0x181716710
	protected void SetDirty() { }

	// RVA: 0x1716660 Offset: 0x1714C60 VA: 0x181716660
	protected void SetDirtyCaching() { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 23
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

	// RVA: 0x17146B0 Offset: 0x1712CB0 VA: 0x1817146B0
	public void .ctor() { }

}

