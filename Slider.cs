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

	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	public RectTransform get_fillRect() { }

	// RVA: 0x1726AD0 Offset: 0x17250D0 VA: 0x181726AD0
	public void set_fillRect(RectTransform value) { }

	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20
	public RectTransform get_handleRect() { }

	// RVA: 0x1726B40 Offset: 0x1725140 VA: 0x181726B40
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x107A0C0 Offset: 0x10786C0 VA: 0x18107A0C0
	public Slider.Direction get_direction() { }

	// RVA: 0x1726A70 Offset: 0x1725070 VA: 0x181726A70
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x11D5B20 Offset: 0x11D4120 VA: 0x1811D5B20
	public float get_minValue() { }

	// RVA: 0x1726C30 Offset: 0x1725230 VA: 0x181726C30
	public void set_minValue(float value) { }

	// RVA: 0x7E6EC0 Offset: 0x7E54C0 VA: 0x1807E6EC0
	public float get_maxValue() { }

	// RVA: 0x1726BB0 Offset: 0x17251B0 VA: 0x181726BB0
	public void set_maxValue(float value) { }

	// RVA: 0x112F170 Offset: 0x112D770 VA: 0x18112F170
	public bool get_wholeNumbers() { }

	// RVA: 0x1726D80 Offset: 0x1725380 VA: 0x181726D80
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x17269F0 Offset: 0x1724FF0 VA: 0x1817269F0 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x1726D60 Offset: 0x1725360 VA: 0x181726D60 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x1725CB0 Offset: 0x17242B0 VA: 0x181725CB0 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x17268A0 Offset: 0x1724EA0 VA: 0x1817268A0
	public float get_normalizedValue() { }

	// RVA: 0x1726CB0 Offset: 0x17252B0 VA: 0x181726CB0
	public void set_normalizedValue(float value) { }

	// RVA: 0x871E40 Offset: 0x870440 VA: 0x180871E40
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x872290 Offset: 0x870890 VA: 0x180872290
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x17269C0 Offset: 0x1724FC0 VA: 0x1817269C0
	private float get_stepSize() { }

	// RVA: 0x17267B0 Offset: 0x1724DB0 VA: 0x1817267B0
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x17255A0 Offset: 0x1723BA0 VA: 0x1817255A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x17254F0 Offset: 0x1723AF0 VA: 0x1817254F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1726790 Offset: 0x1724D90 VA: 0x181726790 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x17252A0 Offset: 0x17238A0 VA: 0x1817252A0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1725D80 Offset: 0x1724380 VA: 0x181725D80
	private void UpdateCachedReferences() { }

	// RVA: 0x1725120 Offset: 0x1723720 VA: 0x181725120
	private float ClampValue(float input) { }

	// RVA: 0x1725CD0 Offset: 0x17242D0 VA: 0x181725CD0 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x1725AE0 Offset: 0x17240E0 VA: 0x181725AE0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1726890 Offset: 0x1724E90 VA: 0x181726890
	private Slider.Axis get_axis() { }

	// RVA: 0x17269A0 Offset: 0x1724FA0 VA: 0x1817269A0
	private bool get_reverseValue() { }

	// RVA: 0x1726460 Offset: 0x1724A60 VA: 0x181726460
	private void UpdateVisuals() { }

	// RVA: 0x1726110 Offset: 0x1724710 VA: 0x181726110
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x17202D0 Offset: 0x171E8D0 VA: 0x1817202D0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x17258A0 Offset: 0x1723EA0 VA: 0x1817258A0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1725520 Offset: 0x1723B20 VA: 0x181725520 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x17255F0 Offset: 0x1723BF0 VA: 0x1817255F0 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1725210 Offset: 0x1723810 VA: 0x181725210 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1725240 Offset: 0x1723840 VA: 0x181725240 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x1725270 Offset: 0x1723870 VA: 0x181725270 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x17251E0 Offset: 0x17237E0 VA: 0x1817251E0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0xFCF150 Offset: 0xFCD750 VA: 0x180FCF150 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1725B20 Offset: 0x1724120 VA: 0x181725B20
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 42
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

	// RVA: 0x22444A0 Offset: 0x2242AA0 VA: 0x1822444A0
	public void .ctor() { }

}

private enum Slider.Axis // TypeDefIndex: 5010
{	// Fields
	public int value__; // 0x0
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;

}

