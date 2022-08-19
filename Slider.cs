public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 5007
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RectTransform m_FillRect; // 0xE8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RectTransform m_HandleRect; // 0xF0
	[SpaceAttribute] // RVA: 0x7CC70 Offset: 0x7C070 VA: 0x18007CC70
	[SerializeField] // RVA: 0x7CC70 Offset: 0x7C070 VA: 0x18007CC70
	private Slider.Direction m_Direction; // 0xF8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_MinValue; // 0xFC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_MaxValue; // 0x100
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_WholeNumbers; // 0x104
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_Value; // 0x108
	[SpaceAttribute] // RVA: 0x7CC70 Offset: 0x7C070 VA: 0x18007CC70
	[SerializeField] // RVA: 0x7CC70 Offset: 0x7C070 VA: 0x18007CC70
	private Slider.SliderEvent m_OnValueChanged; // 0x110
	private Image m_FillImage; // 0x118
	private Transform m_FillTransform; // 0x120
	private RectTransform m_FillContainerRect; // 0x128
	private Transform m_HandleTransform; // 0x130
	private RectTransform m_HandleContainerRect; // 0x138
	private Vector2 m_Offset; // 0x140
	private DrivenRectTransformTracker m_Tracker; // 0x148
	private bool m_DelayedUpdateVisuals; // 0x149

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public RectTransform get_fillRect() { }

	// RVA: 0x1726810 Offset: 0x1724E10 VA: 0x181726810
	public void set_fillRect(RectTransform value) { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public RectTransform get_handleRect() { }

	// RVA: 0x1726880 Offset: 0x1724E80 VA: 0x181726880
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1079E00 Offset: 0x1078400 VA: 0x181079E00
	public Slider.Direction get_direction() { }

	// RVA: 0x17267B0 Offset: 0x1724DB0 VA: 0x1817267B0
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x11D5860 Offset: 0x11D3E60 VA: 0x1811D5860
	public float get_minValue() { }

	// RVA: 0x1726970 Offset: 0x1724F70 VA: 0x181726970
	public void set_minValue(float value) { }

	// RVA: 0x7E6DB0 Offset: 0x7E53B0 VA: 0x1807E6DB0
	public float get_maxValue() { }

	// RVA: 0x17268F0 Offset: 0x1724EF0 VA: 0x1817268F0
	public void set_maxValue(float value) { }

	// RVA: 0x112EEB0 Offset: 0x112D4B0 VA: 0x18112EEB0
	public bool get_wholeNumbers() { }

	// RVA: 0x1726AC0 Offset: 0x17250C0 VA: 0x181726AC0
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x1726730 Offset: 0x1724D30 VA: 0x181726730 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x1726AA0 Offset: 0x17250A0 VA: 0x181726AA0 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x17259F0 Offset: 0x1723FF0 VA: 0x1817259F0 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x17265E0 Offset: 0x1724BE0 VA: 0x1817265E0
	public float get_normalizedValue() { }

	// RVA: 0x17269F0 Offset: 0x1724FF0 VA: 0x1817269F0
	public void set_normalizedValue(float value) { }

	// RVA: 0x871D30 Offset: 0x870330 VA: 0x180871D30
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x872180 Offset: 0x870780 VA: 0x180872180
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x1726700 Offset: 0x1724D00 VA: 0x181726700
	private float get_stepSize() { }

	// RVA: 0x17264F0 Offset: 0x1724AF0 VA: 0x1817264F0
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x17252E0 Offset: 0x17238E0 VA: 0x1817252E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1725230 Offset: 0x1723830 VA: 0x181725230 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17264D0 Offset: 0x1724AD0 VA: 0x1817264D0 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x1724FE0 Offset: 0x17235E0 VA: 0x181724FE0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1725AC0 Offset: 0x17240C0 VA: 0x181725AC0
	private void UpdateCachedReferences() { }

	// RVA: 0x1724E60 Offset: 0x1723460 VA: 0x181724E60
	private float ClampValue(float input) { }

	// RVA: 0x1725A10 Offset: 0x1724010 VA: 0x181725A10 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x1725820 Offset: 0x1723E20 VA: 0x181725820 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x17265D0 Offset: 0x1724BD0 VA: 0x1817265D0
	private Slider.Axis get_axis() { }

	// RVA: 0x17266E0 Offset: 0x1724CE0 VA: 0x1817266E0
	private bool get_reverseValue() { }

	// RVA: 0x17261A0 Offset: 0x17247A0 VA: 0x1817261A0
	private void UpdateVisuals() { }

	// RVA: 0x1725E50 Offset: 0x1724450 VA: 0x181725E50
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x1720010 Offset: 0x171E610 VA: 0x181720010
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x17255E0 Offset: 0x1723BE0 VA: 0x1817255E0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1725260 Offset: 0x1723860 VA: 0x181725260 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1725330 Offset: 0x1723930 VA: 0x181725330 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1724F50 Offset: 0x1723550 VA: 0x181724F50 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1724F80 Offset: 0x1723580 VA: 0x181724F80 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x1724FB0 Offset: 0x17235B0 VA: 0x181724FB0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1724F20 Offset: 0x1723520 VA: 0x181724F20 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0xFCEE90 Offset: 0xFCD490 VA: 0x180FCEE90 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1725860 Offset: 0x1723E60 VA: 0x181725860
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Slider.Direction // TypeDefIndex: 5008
{	// Fields
	public int value__; // 0x0
	public const Slider.Direction LeftToRight = 0;
	public const Slider.Direction RightToLeft = 1;
	public const Slider.Direction BottomToTop = 2;
	public const Slider.Direction TopToBottom = 3;

}

public class Slider.SliderEvent : UnityEvent<float> // TypeDefIndex: 5009
{	// Methods

	// RVA: 0x22443A0 Offset: 0x22429A0 VA: 0x1822443A0
	public void .ctor() { }

}

private enum Slider.Axis // TypeDefIndex: 5010
{	// Fields
	public int value__; // 0x0
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;

}

