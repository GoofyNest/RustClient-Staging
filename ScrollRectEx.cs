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

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	public bool get_horizontal() { }

	// RVA: 0x997AF0 Offset: 0x9960F0 VA: 0x180997AF0
	public void set_horizontal(bool value) { }

	// RVA: 0x73AC50 Offset: 0x739250 VA: 0x18073AC50
	public bool get_vertical() { }

	// RVA: 0x11251F0 Offset: 0x11237F0 VA: 0x1811251F0
	public void set_vertical(bool value) { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public ScrollRectEx.MovementType get_movementType() { }

	// RVA: 0x10B8D50 Offset: 0x10B7350 VA: 0x1810B8D50
	public void set_movementType(ScrollRectEx.MovementType value) { }

	// RVA: 0x6BB9D0 Offset: 0x6B9FD0 VA: 0x1806BB9D0
	public float get_elasticity() { }

	// RVA: 0x4E6370 Offset: 0x4E4970 VA: 0x1804E6370
	public void set_elasticity(float value) { }

	// RVA: 0xBA2210 Offset: 0xBA0810 VA: 0x180BA2210
	public bool get_inertia() { }

	// RVA: 0xE73A20 Offset: 0xE72020 VA: 0x180E73A20
	public void set_inertia(bool value) { }

	// RVA: 0x10B8B50 Offset: 0x10B7150 VA: 0x1810B8B50
	public float get_decelerationRate() { }

	// RVA: 0x10B8BF0 Offset: 0x10B71F0 VA: 0x1810B8BF0
	public void set_decelerationRate(float value) { }

	// RVA: 0xA22070 Offset: 0xA20670 VA: 0x180A22070
	public float get_scrollSensitivity() { }

	// RVA: 0x522320 Offset: 0x520920 VA: 0x180522320
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public RectTransform get_viewport() { }

	// RVA: 0x1125200 Offset: 0x1123800 VA: 0x181125200
	public void set_viewport(RectTransform value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x1124E80 Offset: 0x1123480 VA: 0x181124E80
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1125070 Offset: 0x1123670 VA: 0x181125070
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	public ScrollRectEx.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x1124E70 Offset: 0x1123470 VA: 0x181124E70
	public void set_horizontalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	// RVA: 0x574330 Offset: 0x572930 VA: 0x180574330
	public ScrollRectEx.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x1125060 Offset: 0x1123660 VA: 0x181125060
	public void set_verticalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	// RVA: 0x6C0AE0 Offset: 0x6BF0E0 VA: 0x1806C0AE0
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x1124E60 Offset: 0x1123460 VA: 0x181124E60
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x1124D50 Offset: 0x1123350 VA: 0x181124D50
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x1125050 Offset: 0x1123650 VA: 0x181125050
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public ScrollRectEx.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	public void set_onValueChanged(ScrollRectEx.ScrollRectEvent value) { }

	// RVA: 0x1124D60 Offset: 0x1123360 VA: 0x181124D60
	protected RectTransform get_viewRect() { }

	// RVA: 0x1124BC0 Offset: 0x11231C0 VA: 0x181124BC0
	public Vector2 get_velocity() { }

	// RVA: 0x1125040 Offset: 0x1123640 VA: 0x181125040
	public void set_velocity(Vector2 value) { }

	// RVA: 0x1124AA0 Offset: 0x11230A0 VA: 0x181124AA0
	private RectTransform get_rectTransform() { }

	// RVA: 0x1124760 Offset: 0x1122D60 VA: 0x181124760
	protected void .ctor() { }

	// RVA: 0x1122650 Offset: 0x1120C50 VA: 0x181122650 Slot: 29
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1123A50 Offset: 0x1122050 VA: 0x181123A50
	private void UpdateCachedData() { }

	// RVA: 0x11221A0 Offset: 0x11207A0 VA: 0x1811221A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1121CC0 Offset: 0x11202C0 VA: 0x181121CC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x11212C0 Offset: 0x111F8C0 VA: 0x1811212C0 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x1120EF0 Offset: 0x111F4F0 VA: 0x181120EF0
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x11235F0 Offset: 0x1121BF0 VA: 0x1811235F0 Slot: 30
	public virtual void StopMovement() { }

	// RVA: 0x1122400 Offset: 0x1120A00 VA: 0x181122400 Slot: 31
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x1122350 Offset: 0x1120950 VA: 0x181122350 Slot: 32
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1121B40 Offset: 0x1120140 VA: 0x181121B40 Slot: 33
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1122320 Offset: 0x1120920 VA: 0x181122320 Slot: 34
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1121ED0 Offset: 0x11204D0 VA: 0x181121ED0 Slot: 35
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1122790 Offset: 0x1120D90 VA: 0x181122790 Slot: 36
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x1121330 Offset: 0x111F930 VA: 0x181121330 Slot: 37
	protected virtual void LateUpdate() { }

	// RVA: 0x1123E60 Offset: 0x1122460 VA: 0x181123E60
	private void UpdatePrevData() { }

	// RVA: 0x11244C0 Offset: 0x1122AC0 VA: 0x1811244C0
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x1124A50 Offset: 0x1123050 VA: 0x181124A50
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x1125000 Offset: 0x1123600 VA: 0x181125000
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x1124930 Offset: 0x1122F30 VA: 0x181124930
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x11229F0 Offset: 0x1120FF0 VA: 0x1811229F0
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x1124BE0 Offset: 0x11231E0 VA: 0x181124BE0
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x11235E0 Offset: 0x1121BE0 VA: 0x1811235E0
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x11229F0 Offset: 0x1120FF0 VA: 0x1811229F0
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x11235E0 Offset: 0x1121BE0 VA: 0x1811235E0
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x1123300 Offset: 0x1121900 VA: 0x181123300
	private void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x11226F0 Offset: 0x1120CF0 VA: 0x1811226F0
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x11223F0 Offset: 0x11209F0 VA: 0x1811223F0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x11248C0 Offset: 0x1122EC0 VA: 0x1811248C0
	private bool get_hScrollingNeeded() { }

	// RVA: 0x1124B40 Offset: 0x1123140 VA: 0x181124B40
	private bool get_vScrollingNeeded() { }

	// RVA: 0x1122A00 Offset: 0x1121000 VA: 0x181122A00 Slot: 38
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1123160 Offset: 0x1121760 VA: 0x181123160 Slot: 39
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1124340 Offset: 0x1122940 VA: 0x181124340
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x1123F50 Offset: 0x1122550 VA: 0x181123F50
	private void UpdateScrollbarLayout() { }

	// RVA: 0x1123660 Offset: 0x1121C60 VA: 0x181123660
	private void UpdateBounds() { }

	// RVA: 0x1120F60 Offset: 0x111F560 VA: 0x181120F60
	private Bounds GetBounds() { }

	// RVA: 0x1120970 Offset: 0x111EF70 VA: 0x181120970
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x1122970 Offset: 0x1120F70 VA: 0x181122970
	protected void SetDirty() { }

	// RVA: 0x11228C0 Offset: 0x1120EC0 VA: 0x1811228C0
	protected void SetDirtyCaching() { }

	// RVA: 0x1120BE0 Offset: 0x111F1E0 VA: 0x181120BE0
	public void CenterOnPosition(Vector2 pos) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 24
	public void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 25
	public void GraphicUpdateComplete() { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 23
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

	// RVA: 0x1120930 Offset: 0x111EF30 VA: 0x181120930
	public void .ctor() { }

}

