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
	|-RVA: 0x15A3990 Offset: 0x15A1F90 VA: 0x1815A3990
	|-ExecuteEvents.ValidateEventData<object>
	|-ExecuteEvents.ValidateEventData<AxisEventData>
	|-ExecuteEvents.ValidateEventData<PointerEventData>
	*/

	// RVA: 0x10C4B30 Offset: 0x10C3130 VA: 0x1810C4B30
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4C20 Offset: 0x10C3220 VA: 0x1810C4C20
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4E80 Offset: 0x10C3480 VA: 0x1810C4E80
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4F10 Offset: 0x10C3510 VA: 0x1810C4F10
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4800 Offset: 0x10C2E00 VA: 0x1810C4800
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4AA0 Offset: 0x10C30A0 VA: 0x1810C4AA0
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4890 Offset: 0x10C2E90 VA: 0x1810C4890
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4980 Offset: 0x10C2F80 VA: 0x1810C4980
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4D90 Offset: 0x10C3390 VA: 0x1810C4D90
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4A10 Offset: 0x10C3010 VA: 0x1810C4A10
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4FA0 Offset: 0x10C35A0 VA: 0x1810C4FA0
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4BC0 Offset: 0x10C31C0 VA: 0x1810C4BC0
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4E20 Offset: 0x10C3420 VA: 0x1810C4E20
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4920 Offset: 0x10C2F20 VA: 0x1810C4920
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C4CB0 Offset: 0x10C32B0 VA: 0x1810C4CB0
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C47A0 Offset: 0x10C2DA0 VA: 0x1810C47A0
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5030 Offset: 0x10C3630 VA: 0x1810C5030
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5CE0 Offset: 0x10C42E0 VA: 0x1810C5CE0
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x10C5DA0 Offset: 0x10C43A0 VA: 0x1810C5DA0
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x10C5C80 Offset: 0x10C4280 VA: 0x1810C5C80
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x10C5E60 Offset: 0x10C4460 VA: 0x1810C5E60
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x10C5BC0 Offset: 0x10C41C0 VA: 0x1810C5BC0
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x10C5AA0 Offset: 0x10C40A0 VA: 0x1810C5AA0
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x10C57A0 Offset: 0x10C3DA0 VA: 0x1810C57A0
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x10C58C0 Offset: 0x10C3EC0 VA: 0x1810C58C0
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x10C59E0 Offset: 0x10C3FE0 VA: 0x1810C59E0
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x10C5920 Offset: 0x10C3F20 VA: 0x1810C5920
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x10C5F20 Offset: 0x10C4520 VA: 0x1810C5F20
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x10C6040 Offset: 0x10C4640 VA: 0x1810C6040
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x10C5F80 Offset: 0x10C4580 VA: 0x1810C5F80
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x10C5860 Offset: 0x10C3E60 VA: 0x1810C5860
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x10C5B60 Offset: 0x10C4160 VA: 0x1810C5B60
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x10C5FE0 Offset: 0x10C45E0 VA: 0x1810C5FE0
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x10C5800 Offset: 0x10C3E00 VA: 0x1810C5800
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x10C5090 Offset: 0x10C3690 VA: 0x1810C5090
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1EF0 Offset: 0xBF04F0 VA: 0x180BF1EF0
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
	|-RVA: 0x1A37F80 Offset: 0x1A36580 VA: 0x181A37F80
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
	|-RVA: 0xBF2210 Offset: 0xBF0810 VA: 0x180BF2210
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
	|-RVA: 0xBF1E10 Offset: 0xBF0410 VA: 0x180BF1E10
	|-ExecuteEvents.CanHandleEvent<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38100 Offset: 0x1A36700 VA: 0x181A38100
	|-ExecuteEvents.GetEventHandler<object>
	|-ExecuteEvents.GetEventHandler<IDragHandler>
	|-ExecuteEvents.GetEventHandler<IPointerClickHandler>
	|-ExecuteEvents.GetEventHandler<IScrollHandler>
	|-ExecuteEvents.GetEventHandler<ISelectHandler>
	*/

	// RVA: 0x10C5210 Offset: 0x10C3810 VA: 0x1810C5210
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
	|-RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0
	|-ExecuteEvents.EventFunction<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580
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
	public static readonly ExecuteEvents.<>c <>9; // 0x2B11180

	// Methods

	// RVA: 0x10CEDB0 Offset: 0x10CD3B0 VA: 0x1810CEDB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10CED60 Offset: 0x10CD360 VA: 0x1810CED60
	internal void <.cctor>b__79_0(List<IEventSystemHandler> l) { }

}

