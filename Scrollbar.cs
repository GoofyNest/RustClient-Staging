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

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public RectTransform get_handleRect() { }

	// RVA: 0x171ADB0 Offset: 0x17193B0 VA: 0x18171ADB0
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x107AB00 Offset: 0x1079100 VA: 0x18107AB00
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x171AD50 Offset: 0x1719350 VA: 0x18171AD50
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x171AB40 Offset: 0x1719140 VA: 0x18171AB40
	protected void .ctor() { }

	// RVA: 0x171ACA0 Offset: 0x17192A0 VA: 0x18171ACA0
	public float get_value() { }

	// RVA: 0x171AF20 Offset: 0x1719520 VA: 0x18171AF20
	public void set_value(float value) { }

	// RVA: 0x171A300 Offset: 0x1718900 VA: 0x18171A300 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x112CE10 Offset: 0x112B410 VA: 0x18112CE10
	public float get_size() { }

	// RVA: 0x171AE90 Offset: 0x1719490 VA: 0x18171AE90
	public void set_size(float value) { }

	// RVA: 0x107AB40 Offset: 0x1079140 VA: 0x18107AB40
	public int get_numberOfSteps() { }

	// RVA: 0x171AE20 Offset: 0x1719420 VA: 0x18171AE20
	public void set_numberOfSteps(int value) { }

	// RVA: 0xA2B0D0 Offset: 0xA296D0 VA: 0x180A2B0D0
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0xA2B3D0 Offset: 0xA299D0 VA: 0x180A2B3D0
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x171AC70 Offset: 0x1719270 VA: 0x18171AC70
	private float get_stepSize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1719B60 Offset: 0x1718160 VA: 0x181719B60 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1719A60 Offset: 0x1718060 VA: 0x181719A60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x171AB20 Offset: 0x1719120 VA: 0x18171AB20 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x171A450 Offset: 0x1718A50 VA: 0x18171A450
	private void UpdateCachedReferences() { }

	// RVA: 0x171A310 Offset: 0x1718910 VA: 0x18171A310
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x171A130 Offset: 0x1718730 VA: 0x18171A130 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x171AC40 Offset: 0x1719240 VA: 0x18171AC40
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x171AC50 Offset: 0x1719250 VA: 0x18171AC50
	private bool get_reverseValue() { }

	// RVA: 0x171A930 Offset: 0x1718F30 VA: 0x18171A930
	private void UpdateVisuals() { }

	// RVA: 0x171A560 Offset: 0x1718B60 VA: 0x18171A560
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x1719530 Offset: 0x1717B30 VA: 0x181719530
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x1719710 Offset: 0x1717D10 VA: 0x181719710
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1719780 Offset: 0x1717D80 VA: 0x181719780 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1719A90 Offset: 0x1718090 VA: 0x181719A90 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1719FA0 Offset: 0x17185A0 VA: 0x181719FA0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x7A490 Offset: 0x79890 VA: 0x18007A490
	// RVA: 0x17194A0 Offset: 0x1717AA0 VA: 0x1817194A0
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x171A0B0 Offset: 0x17186B0 VA: 0x18171A0B0 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1719C70 Offset: 0x1718270 VA: 0x181719C70 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1719680 Offset: 0x1717C80 VA: 0x181719680 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x17196B0 Offset: 0x1717CB0 VA: 0x1817196B0 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x17196E0 Offset: 0x1717CE0 VA: 0x1817196E0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1719650 Offset: 0x1717C50 VA: 0x181719650 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0xFCFBF0 Offset: 0xFCE1F0 VA: 0x180FCFBF0 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x171A170 Offset: 0x1718770 VA: 0x18171A170
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 43
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

	// RVA: 0x1714670 Offset: 0x1712C70 VA: 0x181714670
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

	// RVA: 0x1720400 Offset: 0x171EA00 VA: 0x181720400 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1720640 Offset: 0x171EC40 VA: 0x181720640 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

