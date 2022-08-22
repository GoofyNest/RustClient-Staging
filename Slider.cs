public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 5007
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_FillRect; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_HandleRect; // 0xF0
	[SpaceAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	[SerializeField] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	private Slider.Direction m_Direction; // 0xF8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_MinValue; // 0xFC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_MaxValue; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_WholeNumbers; // 0x104
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_Value; // 0x108
	[SpaceAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	[SerializeField] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
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

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public RectTransform get_fillRect() { }

	// RVA: 0x171FEF0 Offset: 0x171E4F0 VA: 0x18171FEF0
	public void set_fillRect(RectTransform value) { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public RectTransform get_handleRect() { }

	// RVA: 0x171FF60 Offset: 0x171E560 VA: 0x18171FF60
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x107AB30 Offset: 0x1079130 VA: 0x18107AB30
	public Slider.Direction get_direction() { }

	// RVA: 0x171FE90 Offset: 0x171E490 VA: 0x18171FE90
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x11D61C0 Offset: 0x11D47C0 VA: 0x1811D61C0
	public float get_minValue() { }

	// RVA: 0x1720050 Offset: 0x171E650 VA: 0x181720050
	public void set_minValue(float value) { }

	// RVA: 0x7B27E0 Offset: 0x7B0DE0 VA: 0x1807B27E0
	public float get_maxValue() { }

	// RVA: 0x171FFD0 Offset: 0x171E5D0 VA: 0x18171FFD0
	public void set_maxValue(float value) { }

	// RVA: 0x112FBE0 Offset: 0x112E1E0 VA: 0x18112FBE0
	public bool get_wholeNumbers() { }

	// RVA: 0x17201A0 Offset: 0x171E7A0 VA: 0x1817201A0
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x171FE10 Offset: 0x171E410 VA: 0x18171FE10 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x1720180 Offset: 0x171E780 VA: 0x181720180 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x171F0D0 Offset: 0x171D6D0 VA: 0x18171F0D0 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x171FCC0 Offset: 0x171E2C0 VA: 0x18171FCC0
	public float get_normalizedValue() { }

	// RVA: 0x17200D0 Offset: 0x171E6D0 VA: 0x1817200D0
	public void set_normalizedValue(float value) { }

	// RVA: 0x88D560 Offset: 0x88BB60 VA: 0x18088D560
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x88D9B0 Offset: 0x88BFB0 VA: 0x18088D9B0
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x171FDE0 Offset: 0x171E3E0 VA: 0x18171FDE0
	private float get_stepSize() { }

	// RVA: 0x171FBD0 Offset: 0x171E1D0 VA: 0x18171FBD0
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x171E9C0 Offset: 0x171CFC0 VA: 0x18171E9C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x171E910 Offset: 0x171CF10 VA: 0x18171E910 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x171FBB0 Offset: 0x171E1B0 VA: 0x18171FBB0 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x171E6C0 Offset: 0x171CCC0 VA: 0x18171E6C0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x171F1A0 Offset: 0x171D7A0 VA: 0x18171F1A0
	private void UpdateCachedReferences() { }

	// RVA: 0x171E540 Offset: 0x171CB40 VA: 0x18171E540
	private float ClampValue(float input) { }

	// RVA: 0x171F0F0 Offset: 0x171D6F0 VA: 0x18171F0F0 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x171EF00 Offset: 0x171D500 VA: 0x18171EF00 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x171FCB0 Offset: 0x171E2B0 VA: 0x18171FCB0
	private Slider.Axis get_axis() { }

	// RVA: 0x171FDC0 Offset: 0x171E3C0 VA: 0x18171FDC0
	private bool get_reverseValue() { }

	// RVA: 0x171F880 Offset: 0x171DE80 VA: 0x18171F880
	private void UpdateVisuals() { }

	// RVA: 0x171F530 Offset: 0x171DB30 VA: 0x18171F530
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x1719710 Offset: 0x1717D10 VA: 0x181719710
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x171ECC0 Offset: 0x171D2C0 VA: 0x18171ECC0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x171E940 Offset: 0x171CF40 VA: 0x18171E940 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x171EA10 Offset: 0x171D010 VA: 0x18171EA10 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x171E630 Offset: 0x171CC30 VA: 0x18171E630 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x171E660 Offset: 0x171CC60 VA: 0x18171E660 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x171E690 Offset: 0x171CC90 VA: 0x18171E690 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x171E600 Offset: 0x171CC00 VA: 0x18171E600 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0xFCFBF0 Offset: 0xFCE1F0 VA: 0x180FCFBF0 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x171EF40 Offset: 0x171D540 VA: 0x18171EF40
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 42
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

	// RVA: 0x2244CC0 Offset: 0x22432C0 VA: 0x182244CC0
	public void .ctor() { }

}

private enum Slider.Axis // TypeDefIndex: 5010
{	// Fields
	public int value__; // 0x0
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;

}

