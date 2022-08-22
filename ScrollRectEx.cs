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

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	public bool get_horizontal() { }

	// RVA: 0x9974F0 Offset: 0x995AF0 VA: 0x1809974F0
	public void set_horizontal(bool value) { }

	// RVA: 0x73ABF0 Offset: 0x7391F0 VA: 0x18073ABF0
	public bool get_vertical() { }

	// RVA: 0x11244C0 Offset: 0x1122AC0 VA: 0x1811244C0
	public void set_vertical(bool value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public ScrollRectEx.MovementType get_movementType() { }

	// RVA: 0x10B8020 Offset: 0x10B6620 VA: 0x1810B8020
	public void set_movementType(ScrollRectEx.MovementType value) { }

	// RVA: 0x6BB930 Offset: 0x6B9F30 VA: 0x1806BB930
	public float get_elasticity() { }

	// RVA: 0x4E63E0 Offset: 0x4E49E0 VA: 0x1804E63E0
	public void set_elasticity(float value) { }

	// RVA: 0xBA1A80 Offset: 0xBA0080 VA: 0x180BA1A80
	public bool get_inertia() { }

	// RVA: 0xE72CB0 Offset: 0xE712B0 VA: 0x180E72CB0
	public void set_inertia(bool value) { }

	// RVA: 0x10B7E20 Offset: 0x10B6420 VA: 0x1810B7E20
	public float get_decelerationRate() { }

	// RVA: 0x10B7EC0 Offset: 0x10B64C0 VA: 0x1810B7EC0
	public void set_decelerationRate(float value) { }

	// RVA: 0xA218C0 Offset: 0xA1FEC0 VA: 0x180A218C0
	public float get_scrollSensitivity() { }

	// RVA: 0x522390 Offset: 0x520990 VA: 0x180522390
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public RectTransform get_viewport() { }

	// RVA: 0x11244D0 Offset: 0x1122AD0 VA: 0x1811244D0
	public void set_viewport(RectTransform value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x1124150 Offset: 0x1122750 VA: 0x181124150
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1124340 Offset: 0x1122940 VA: 0x181124340
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0xAE97E0 Offset: 0xAE7DE0 VA: 0x180AE97E0
	public ScrollRectEx.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x1124140 Offset: 0x1122740 VA: 0x181124140
	public void set_horizontalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public ScrollRectEx.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x1124330 Offset: 0x1122930 VA: 0x181124330
	public void set_verticalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	// RVA: 0x6C0A40 Offset: 0x6BF040 VA: 0x1806C0A40
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x1124130 Offset: 0x1122730 VA: 0x181124130
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x1124020 Offset: 0x1122620 VA: 0x181124020
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x1124320 Offset: 0x1122920 VA: 0x181124320
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public ScrollRectEx.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	public void set_onValueChanged(ScrollRectEx.ScrollRectEvent value) { }

	// RVA: 0x1124030 Offset: 0x1122630 VA: 0x181124030
	protected RectTransform get_viewRect() { }

	// RVA: 0x1123E90 Offset: 0x1122490 VA: 0x181123E90
	public Vector2 get_velocity() { }

	// RVA: 0x1124310 Offset: 0x1122910 VA: 0x181124310
	public void set_velocity(Vector2 value) { }

	// RVA: 0x1123D70 Offset: 0x1122370 VA: 0x181123D70
	private RectTransform get_rectTransform() { }

	// RVA: 0x1123A30 Offset: 0x1122030 VA: 0x181123A30
	protected void .ctor() { }

	// RVA: 0x1121920 Offset: 0x111FF20 VA: 0x181121920 Slot: 29
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1122D20 Offset: 0x1121320 VA: 0x181122D20
	private void UpdateCachedData() { }

	// RVA: 0x1121470 Offset: 0x111FA70 VA: 0x181121470 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1120F90 Offset: 0x111F590 VA: 0x181120F90 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1120590 Offset: 0x111EB90 VA: 0x181120590 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x11201C0 Offset: 0x111E7C0 VA: 0x1811201C0
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x11228C0 Offset: 0x1120EC0 VA: 0x1811228C0 Slot: 30
	public virtual void StopMovement() { }

	// RVA: 0x11216D0 Offset: 0x111FCD0 VA: 0x1811216D0 Slot: 31
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x1121620 Offset: 0x111FC20 VA: 0x181121620 Slot: 32
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1120E10 Offset: 0x111F410 VA: 0x181120E10 Slot: 33
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x11215F0 Offset: 0x111FBF0 VA: 0x1811215F0 Slot: 34
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x11211A0 Offset: 0x111F7A0 VA: 0x1811211A0 Slot: 35
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1121A60 Offset: 0x1120060 VA: 0x181121A60 Slot: 36
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x1120600 Offset: 0x111EC00 VA: 0x181120600 Slot: 37
	protected virtual void LateUpdate() { }

	// RVA: 0x1123130 Offset: 0x1121730 VA: 0x181123130
	private void UpdatePrevData() { }

	// RVA: 0x1123790 Offset: 0x1121D90 VA: 0x181123790
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x1123D20 Offset: 0x1122320 VA: 0x181123D20
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x11242D0 Offset: 0x11228D0 VA: 0x1811242D0
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x1123C00 Offset: 0x1122200 VA: 0x181123C00
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x1121CC0 Offset: 0x11202C0 VA: 0x181121CC0
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x1123EB0 Offset: 0x11224B0 VA: 0x181123EB0
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x11228B0 Offset: 0x1120EB0 VA: 0x1811228B0
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x1121CC0 Offset: 0x11202C0 VA: 0x181121CC0
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x11228B0 Offset: 0x1120EB0 VA: 0x1811228B0
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x11225D0 Offset: 0x1120BD0 VA: 0x1811225D0
	private void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x11219C0 Offset: 0x111FFC0 VA: 0x1811219C0
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x11216C0 Offset: 0x111FCC0 VA: 0x1811216C0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1123B90 Offset: 0x1122190 VA: 0x181123B90
	private bool get_hScrollingNeeded() { }

	// RVA: 0x1123E10 Offset: 0x1122410 VA: 0x181123E10
	private bool get_vScrollingNeeded() { }

	// RVA: 0x1121CD0 Offset: 0x11202D0 VA: 0x181121CD0 Slot: 38
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1122430 Offset: 0x1120A30 VA: 0x181122430 Slot: 39
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1123610 Offset: 0x1121C10 VA: 0x181123610
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x1123220 Offset: 0x1121820 VA: 0x181123220
	private void UpdateScrollbarLayout() { }

	// RVA: 0x1122930 Offset: 0x1120F30 VA: 0x181122930
	private void UpdateBounds() { }

	// RVA: 0x1120230 Offset: 0x111E830 VA: 0x181120230
	private Bounds GetBounds() { }

	// RVA: 0x111FC40 Offset: 0x111E240 VA: 0x18111FC40
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x1121C40 Offset: 0x1120240 VA: 0x181121C40
	protected void SetDirty() { }

	// RVA: 0x1121B90 Offset: 0x1120190 VA: 0x181121B90
	protected void SetDirtyCaching() { }

	// RVA: 0x111FEB0 Offset: 0x111E4B0 VA: 0x18111FEB0
	public void CenterOnPosition(Vector2 pos) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 24
	public void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 25
	public void GraphicUpdateComplete() { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 23
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

	// RVA: 0x111FC00 Offset: 0x111E200 VA: 0x18111FC00
	public void .ctor() { }

}

