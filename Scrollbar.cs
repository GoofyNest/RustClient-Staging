public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 4998
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RectTransform m_HandleRect; // 0xE8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Scrollbar.Direction m_Direction; // 0xF0
	[RangeAttribute] // RVA: 0x79B00 Offset: 0x78F00 VA: 0x180079B00
	[SerializeField] // RVA: 0x79B00 Offset: 0x78F00 VA: 0x180079B00
	private float m_Value; // 0xF4
	[RangeAttribute] // RVA: 0x79B00 Offset: 0x78F00 VA: 0x180079B00
	[SerializeField] // RVA: 0x79B00 Offset: 0x78F00 VA: 0x180079B00
	private float m_Size; // 0xF8
	[RangeAttribute] // RVA: 0x7A000 Offset: 0x79400 VA: 0x18007A000
	[SerializeField] // RVA: 0x7A000 Offset: 0x79400 VA: 0x18007A000
	private int m_NumberOfSteps; // 0xFC
	[SpaceAttribute] // RVA: 0x7A290 Offset: 0x79690 VA: 0x18007A290
	[SerializeField] // RVA: 0x7A290 Offset: 0x79690 VA: 0x18007A290
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

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public RectTransform get_handleRect() { }

	// RVA: 0x17216B0 Offset: 0x171FCB0 VA: 0x1817216B0
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1079DD0 Offset: 0x10783D0 VA: 0x181079DD0
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x1721650 Offset: 0x171FC50 VA: 0x181721650
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x1721440 Offset: 0x171FA40 VA: 0x181721440
	protected void .ctor() { }

	// RVA: 0x17215A0 Offset: 0x171FBA0 VA: 0x1817215A0
	public float get_value() { }

	// RVA: 0x1721820 Offset: 0x171FE20 VA: 0x181721820
	public void set_value(float value) { }

	// RVA: 0x1720C00 Offset: 0x171F200 VA: 0x181720C00 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x112C0E0 Offset: 0x112A6E0 VA: 0x18112C0E0
	public float get_size() { }

	// RVA: 0x1721790 Offset: 0x171FD90 VA: 0x181721790
	public void set_size(float value) { }

	// RVA: 0x1079E10 Offset: 0x1078410 VA: 0x181079E10
	public int get_numberOfSteps() { }

	// RVA: 0x1721720 Offset: 0x171FD20 VA: 0x181721720
	public void set_numberOfSteps(int value) { }

	// RVA: 0xA2A920 Offset: 0xA28F20 VA: 0x180A2A920
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0xA2AC20 Offset: 0xA29220 VA: 0x180A2AC20
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x1721570 Offset: 0x171FB70 VA: 0x181721570
	private float get_stepSize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1720460 Offset: 0x171EA60 VA: 0x181720460 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1720360 Offset: 0x171E960 VA: 0x181720360 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1721420 Offset: 0x171FA20 VA: 0x181721420 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x1720D50 Offset: 0x171F350 VA: 0x181720D50
	private void UpdateCachedReferences() { }

	// RVA: 0x1720C10 Offset: 0x171F210 VA: 0x181720C10
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x1720A30 Offset: 0x171F030 VA: 0x181720A30 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1721540 Offset: 0x171FB40 VA: 0x181721540
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x1721550 Offset: 0x171FB50 VA: 0x181721550
	private bool get_reverseValue() { }

	// RVA: 0x1721230 Offset: 0x171F830 VA: 0x181721230
	private void UpdateVisuals() { }

	// RVA: 0x1720E60 Offset: 0x171F460 VA: 0x181720E60
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x171FE30 Offset: 0x171E430 VA: 0x18171FE30
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x1720010 Offset: 0x171E610 VA: 0x181720010
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1720080 Offset: 0x171E680 VA: 0x181720080 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1720390 Offset: 0x171E990 VA: 0x181720390 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x17208A0 Offset: 0x171EEA0 VA: 0x1817208A0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x7A3F0 Offset: 0x797F0 VA: 0x18007A3F0
	// RVA: 0x171FDA0 Offset: 0x171E3A0 VA: 0x18171FDA0
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x17209B0 Offset: 0x171EFB0 VA: 0x1817209B0 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1720570 Offset: 0x171EB70 VA: 0x181720570 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x171FF80 Offset: 0x171E580 VA: 0x18171FF80 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x171FFB0 Offset: 0x171E5B0 VA: 0x18171FFB0 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x171FFE0 Offset: 0x171E5E0 VA: 0x18171FFE0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x171FF50 Offset: 0x171E550 VA: 0x18171FF50 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0xFCEE90 Offset: 0xFCD490 VA: 0x180FCEE90 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1720A70 Offset: 0x171F070 VA: 0x181720A70
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 43
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

	// RVA: 0x171AF60 Offset: 0x1719560 VA: 0x18171AF60
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1726D20 Offset: 0x1725320 VA: 0x181726D20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1726F60 Offset: 0x1725560 VA: 0x181726F60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

