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
	|-RVA: 0x15A2D20 Offset: 0x15A1320 VA: 0x1815A2D20
	|-ExecuteEvents.ValidateEventData<object>
	|-ExecuteEvents.ValidateEventData<AxisEventData>
	|-ExecuteEvents.ValidateEventData<PointerEventData>
	*/

	// RVA: 0x10C5860 Offset: 0x10C3E60 VA: 0x1810C5860
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5950 Offset: 0x10C3F50 VA: 0x1810C5950
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5BB0 Offset: 0x10C41B0 VA: 0x1810C5BB0
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5C40 Offset: 0x10C4240 VA: 0x1810C5C40
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5530 Offset: 0x10C3B30 VA: 0x1810C5530
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C57D0 Offset: 0x10C3DD0 VA: 0x1810C57D0
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C55C0 Offset: 0x10C3BC0 VA: 0x1810C55C0
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C56B0 Offset: 0x10C3CB0 VA: 0x1810C56B0
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5AC0 Offset: 0x10C40C0 VA: 0x1810C5AC0
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5740 Offset: 0x10C3D40 VA: 0x1810C5740
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5CD0 Offset: 0x10C42D0 VA: 0x1810C5CD0
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C58F0 Offset: 0x10C3EF0 VA: 0x1810C58F0
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5B50 Offset: 0x10C4150 VA: 0x1810C5B50
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5650 Offset: 0x10C3C50 VA: 0x1810C5650
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C59E0 Offset: 0x10C3FE0 VA: 0x1810C59E0
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C54D0 Offset: 0x10C3AD0 VA: 0x1810C54D0
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C5D60 Offset: 0x10C4360 VA: 0x1810C5D60
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C6A10 Offset: 0x10C5010 VA: 0x1810C6A10
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x10C6AD0 Offset: 0x10C50D0 VA: 0x1810C6AD0
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x10C69B0 Offset: 0x10C4FB0 VA: 0x1810C69B0
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x10C6B90 Offset: 0x10C5190 VA: 0x1810C6B90
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x10C68F0 Offset: 0x10C4EF0 VA: 0x1810C68F0
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x10C67D0 Offset: 0x10C4DD0 VA: 0x1810C67D0
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x10C64D0 Offset: 0x10C4AD0 VA: 0x1810C64D0
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x10C65F0 Offset: 0x10C4BF0 VA: 0x1810C65F0
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x10C6710 Offset: 0x10C4D10 VA: 0x1810C6710
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x10C6650 Offset: 0x10C4C50 VA: 0x1810C6650
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x10C6C50 Offset: 0x10C5250 VA: 0x1810C6C50
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x10C6D70 Offset: 0x10C5370 VA: 0x1810C6D70
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x10C6CB0 Offset: 0x10C52B0 VA: 0x1810C6CB0
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x10C6590 Offset: 0x10C4B90 VA: 0x1810C6590
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x10C6890 Offset: 0x10C4E90 VA: 0x1810C6890
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x10C6D10 Offset: 0x10C5310 VA: 0x1810C6D10
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x10C6530 Offset: 0x10C4B30 VA: 0x1810C6530
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x10C5DC0 Offset: 0x10C43C0 VA: 0x1810C5DC0
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2680 Offset: 0xBF0C80 VA: 0x180BF2680
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
	|-RVA: 0x1A37920 Offset: 0x1A35F20 VA: 0x181A37920
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
	|-RVA: 0xBF29A0 Offset: 0xBF0FA0 VA: 0x180BF29A0
	|-ExecuteEvents.ShouldSendToComponent<object>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD340 Offset: 0x5CB940 VA: 0x1805CD340
	|-ExecuteEvents.GetEventList<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF25A0 Offset: 0xBF0BA0 VA: 0x180BF25A0
	|-ExecuteEvents.CanHandleEvent<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A37AA0 Offset: 0x1A360A0 VA: 0x181A37AA0
	|-ExecuteEvents.GetEventHandler<object>
	|-ExecuteEvents.GetEventHandler<IDragHandler>
	|-ExecuteEvents.GetEventHandler<IPointerClickHandler>
	|-ExecuteEvents.GetEventHandler<IScrollHandler>
	|-ExecuteEvents.GetEventHandler<ISelectHandler>
	*/

	// RVA: 0x10C5F40 Offset: 0x10C4540 VA: 0x1810C5F40
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
	|-RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50
	|-ExecuteEvents.EventFunction<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10
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
	public static readonly ExecuteEvents.<>c <>9; // 0x135DD

	// Methods

	// RVA: 0x10CFAE0 Offset: 0x10CE0E0 VA: 0x1810CFAE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10CFA90 Offset: 0x10CE090 VA: 0x1810CFA90
	internal void <.cctor>b__79_0(List<IEventSystemHandler> l) { }

}

