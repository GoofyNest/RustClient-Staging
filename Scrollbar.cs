public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 4998
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_HandleRect; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Scrollbar.Direction m_Direction; // 0xF0
	[RangeAttribute] // RVA: 0x79E20 Offset: 0x79220 VA: 0x180079E20
	[SerializeField] // RVA: 0x79E20 Offset: 0x79220 VA: 0x180079E20
	private float m_Value; // 0xF4
	[RangeAttribute] // RVA: 0x79E20 Offset: 0x79220 VA: 0x180079E20
	[SerializeField] // RVA: 0x79E20 Offset: 0x79220 VA: 0x180079E20
	private float m_Size; // 0xF8
	[RangeAttribute] // RVA: 0x7A100 Offset: 0x79500 VA: 0x18007A100
	[SerializeField] // RVA: 0x7A100 Offset: 0x79500 VA: 0x18007A100
	private int m_NumberOfSteps; // 0xFC
	[SpaceAttribute] // RVA: 0x7A350 Offset: 0x79750 VA: 0x18007A350
	[SerializeField] // RVA: 0x7A350 Offset: 0x79750 VA: 0x18007A350
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x100
	private RectTransform m_ContainerRect; // 0x108
	private Vector2 m_Offset; // 0x110
	private DrivenRectTransformTracker m_Tracker; // 0x118
	private Coroutine m_PointerDownRepeat; // 0x120
	private bool isPointerDownAndNotDragging; // 0x128
	private bool m_DelayedUpdateVisuals; // 0x129

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	public RectTransform get_handleRect() { }

	// RVA: 0x1721970 Offset: 0x171FF70 VA: 0x181721970
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x107A090 Offset: 0x1078690 VA: 0x18107A090
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x1721910 Offset: 0x171FF10 VA: 0x181721910
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x1721700 Offset: 0x171FD00 VA: 0x181721700
	protected void .ctor() { }

	// RVA: 0x1721860 Offset: 0x171FE60 VA: 0x181721860
	public float get_value() { }

	// RVA: 0x1721AE0 Offset: 0x17200E0 VA: 0x181721AE0
	public void set_value(float value) { }

	// RVA: 0x1720EC0 Offset: 0x171F4C0 VA: 0x181720EC0 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x112C3A0 Offset: 0x112A9A0 VA: 0x18112C3A0
	public float get_size() { }

	// RVA: 0x1721A50 Offset: 0x1720050 VA: 0x181721A50
	public void set_size(float value) { }

	// RVA: 0x107A0D0 Offset: 0x10786D0 VA: 0x18107A0D0
	public int get_numberOfSteps() { }

	// RVA: 0x17219E0 Offset: 0x171FFE0 VA: 0x1817219E0
	public void set_numberOfSteps(int value) { }

	// RVA: 0xA2ABE0 Offset: 0xA291E0 VA: 0x180A2ABE0
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0xA2AEE0 Offset: 0xA294E0 VA: 0x180A2AEE0
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x1721830 Offset: 0x171FE30 VA: 0x181721830
	private float get_stepSize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1720720 Offset: 0x171ED20 VA: 0x181720720 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1720620 Offset: 0x171EC20 VA: 0x181720620 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17216E0 Offset: 0x171FCE0 VA: 0x1817216E0 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x1721010 Offset: 0x171F610 VA: 0x181721010
	private void UpdateCachedReferences() { }

	// RVA: 0x1720ED0 Offset: 0x171F4D0 VA: 0x181720ED0
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x1720CF0 Offset: 0x171F2F0 VA: 0x181720CF0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1721800 Offset: 0x171FE00 VA: 0x181721800
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x1721810 Offset: 0x171FE10 VA: 0x181721810
	private bool get_reverseValue() { }

	// RVA: 0x17214F0 Offset: 0x171FAF0 VA: 0x1817214F0
	private void UpdateVisuals() { }

	// RVA: 0x1721120 Offset: 0x171F720 VA: 0x181721120
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x17200F0 Offset: 0x171E6F0 VA: 0x1817200F0
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x17202D0 Offset: 0x171E8D0 VA: 0x1817202D0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1720340 Offset: 0x171E940 VA: 0x181720340 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1720650 Offset: 0x171EC50 VA: 0x181720650 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1720B60 Offset: 0x171F160 VA: 0x181720B60 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x7A490 Offset: 0x79890 VA: 0x18007A490
	// RVA: 0x1720060 Offset: 0x171E660 VA: 0x181720060
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x1720C70 Offset: 0x171F270 VA: 0x181720C70 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1720830 Offset: 0x171EE30 VA: 0x181720830 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1720240 Offset: 0x171E840 VA: 0x181720240 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1720270 Offset: 0x171E870 VA: 0x181720270 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x17202A0 Offset: 0x171E8A0 VA: 0x1817202A0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1720210 Offset: 0x171E810 VA: 0x181720210 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0xFCF150 Offset: 0xFCD750 VA: 0x180FCF150 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1720D30 Offset: 0x171F330 VA: 0x181720D30
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Scrollbar.Direction // TypeDefIndex: 4999
{	// Fields
	public int value__; // 0x0
	public const Scrollbar.Direction LeftToRight = 0;
	public const Scrollbar.Direction RightToLeft = 1;
	public const Scrollbar.Direction BottomToTop = 2;
	public const Scrollbar.Direction TopToBottom = 3;

}

public class Scrollbar.ScrollEvent : UnityEvent<float> // TypeDefIndex: 5000
{	// Methods

	// RVA: 0x171B220 Offset: 0x1719820 VA: 0x18171B220
	public void .ctor() { }

}

private enum Scrollbar.Axis // TypeDefIndex: 5001
{	// Fields
	public int value__; // 0x0
	public const Scrollbar.Axis Horizontal = 0;
	public const Scrollbar.Axis Vertical = 1;

}

private sealed class Scrollbar.<ClickRepeat>d__57 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5002
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1726FE0 Offset: 0x17255E0 VA: 0x181726FE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1727220 Offset: 0x1725820 VA: 0x181727220 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

