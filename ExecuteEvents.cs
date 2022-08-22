public static class ExecuteEvents // TypeDefIndex: 5076
{	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x80
	private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3C50 Offset: 0x15A2250 VA: 0x1815A3C50
	|-ExecuteEvents.ValidateEventData<object>
	|-ExecuteEvents.ValidateEventData<AxisEventData>
	|-ExecuteEvents.ValidateEventData<PointerEventData>
	*/

	// RVA: 0x10C4DF0 Offset: 0x10C33F0 VA: 0x1810C4DF0
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4EE0 Offset: 0x10C34E0 VA: 0x1810C4EE0
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5140 Offset: 0x10C3740 VA: 0x1810C5140
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C51D0 Offset: 0x10C37D0 VA: 0x1810C51D0
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4AC0 Offset: 0x10C30C0 VA: 0x1810C4AC0
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4D60 Offset: 0x10C3360 VA: 0x1810C4D60
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4B50 Offset: 0x10C3150 VA: 0x1810C4B50
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4C40 Offset: 0x10C3240 VA: 0x1810C4C40
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5050 Offset: 0x10C3650 VA: 0x1810C5050
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4CD0 Offset: 0x10C32D0 VA: 0x1810C4CD0
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5260 Offset: 0x10C3860 VA: 0x1810C5260
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4E80 Offset: 0x10C3480 VA: 0x1810C4E80
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C50E0 Offset: 0x10C36E0 VA: 0x1810C50E0
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4BE0 Offset: 0x10C31E0 VA: 0x1810C4BE0
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4F70 Offset: 0x10C3570 VA: 0x1810C4F70
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4A60 Offset: 0x10C3060 VA: 0x1810C4A60
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C52F0 Offset: 0x10C38F0 VA: 0x1810C52F0
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5FA0 Offset: 0x10C45A0 VA: 0x1810C5FA0
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x10C6060 Offset: 0x10C4660 VA: 0x1810C6060
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x10C5F40 Offset: 0x10C4540 VA: 0x1810C5F40
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x10C6120 Offset: 0x10C4720 VA: 0x1810C6120
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x10C5E80 Offset: 0x10C4480 VA: 0x1810C5E80
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x10C5D60 Offset: 0x10C4360 VA: 0x1810C5D60
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x10C5A60 Offset: 0x10C4060 VA: 0x1810C5A60
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x10C5B80 Offset: 0x10C4180 VA: 0x1810C5B80
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x10C5CA0 Offset: 0x10C42A0 VA: 0x1810C5CA0
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x10C5BE0 Offset: 0x10C41E0 VA: 0x1810C5BE0
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x10C61E0 Offset: 0x10C47E0 VA: 0x1810C61E0
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x10C6300 Offset: 0x10C4900 VA: 0x1810C6300
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x10C6240 Offset: 0x10C4840 VA: 0x1810C6240
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x10C5B20 Offset: 0x10C4120 VA: 0x1810C5B20
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x10C5E20 Offset: 0x10C4420 VA: 0x1810C5E20
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x10C62A0 Offset: 0x10C48A0 VA: 0x1810C62A0
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x10C5AC0 Offset: 0x10C40C0 VA: 0x1810C5AC0
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x10C5350 Offset: 0x10C3950 VA: 0x1810C5350
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF21B0 Offset: 0xBF07B0 VA: 0x180BF21B0
	|-ExecuteEvents.Execute<object>
	|-ExecuteEvents.Execute<IBeginDragHandler>
	|-ExecuteEvents.Execute<ICancelHandler>
	|-ExecuteEvents.Execute<IDeselectHandler>
	|-ExecuteEvents.Execute<IDragHandler>
	|-ExecuteEvents.Execute<IEndDragHandler>
	|-ExecuteEvents.Execute<IInitializePotentialDragHandler>
	|-ExecuteEvents.Execute<IMoveHandler>
	|-ExecuteEvents.Execute<IPointerClickHandler>
	|-ExecuteEvents.Execute<IPointerEnterHandler>
	|-ExecuteEvents.Execute<IPointerExitHandler>
	|-ExecuteEvents.Execute<IPointerUpHandler>
	|-ExecuteEvents.Execute<ISelectHandler>
	|-ExecuteEvents.Execute<ISubmitHandler>
	|-ExecuteEvents.Execute<IUpdateSelectedHandler>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38200 Offset: 0x1A36800 VA: 0x181A38200
	|-ExecuteEvents.ExecuteHierarchy<object>
	|-ExecuteEvents.ExecuteHierarchy<IDropHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>
	|-ExecuteEvents.ExecuteHierarchy<IScrollHandler>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF24D0 Offset: 0xBF0AD0 VA: 0x180BF24D0
	|-ExecuteEvents.ShouldSendToComponent<object>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD3B0 Offset: 0x5CB9B0 VA: 0x1805CD3B0
	|-ExecuteEvents.GetEventList<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF20D0 Offset: 0xBF06D0 VA: 0x180BF20D0
	|-ExecuteEvents.CanHandleEvent<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38380 Offset: 0x1A36980 VA: 0x181A38380
	|-ExecuteEvents.GetEventHandler<object>
	|-ExecuteEvents.GetEventHandler<IDragHandler>
	|-ExecuteEvents.GetEventHandler<IPointerClickHandler>
	|-ExecuteEvents.GetEventHandler<IScrollHandler>
	|-ExecuteEvents.GetEventHandler<ISelectHandler>
	*/

	// RVA: 0x10C54D0 Offset: 0x10C3AD0 VA: 0x1810C54D0
	private static void .cctor() { }

}

public sealed class ExecuteEvents.EventFunction<T1> : MulticastDelegate // TypeDefIndex: 5077
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-ExecuteEvents.EventFunction<object>..ctor
	|-ExecuteEvents.EventFunction<IBeginDragHandler>..ctor
	|-ExecuteEvents.EventFunction<ICancelHandler>..ctor
	|-ExecuteEvents.EventFunction<IDeselectHandler>..ctor
	|-ExecuteEvents.EventFunction<IDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IDropHandler>..ctor
	|-ExecuteEvents.EventFunction<IEndDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IInitializePotentialDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IMoveHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerClickHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerDownHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerEnterHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerExitHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerUpHandler>..ctor
	|-ExecuteEvents.EventFunction<IScrollHandler>..ctor
	|-ExecuteEvents.EventFunction<ISelectHandler>..ctor
	|-ExecuteEvents.EventFunction<ISubmitHandler>..ctor
	|-ExecuteEvents.EventFunction<IUpdateSelectedHandler>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880
	|-ExecuteEvents.EventFunction<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840
	|-ExecuteEvents.EventFunction<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-ExecuteEvents.EventFunction<object>.EndInvoke
	*/

}

private sealed class ExecuteEvents.<>c // TypeDefIndex: 5078
{	// Fields
	public static readonly ExecuteEvents.<>c <>9; // 0x2B111E0

	// Methods

	// RVA: 0x10CF070 Offset: 0x10CD670 VA: 0x1810CF070
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10CF020 Offset: 0x10CD620 VA: 0x1810CF020
	internal void <.cctor>b__79_0(List<IEventSystemHandler> l) { }

}

