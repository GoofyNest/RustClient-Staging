public class BaseStateUI : MonoBehaviour // TypeDefIndex: 10790
{	// Fields
	public Dropdown DropdownInputMemorySlot; // 0x18
	public Transform PrefabAddNewEvent; // 0x20
	public Transform PrefabTimerEvent; // 0x28
	public Transform PrefabPlayerDetectedEvent; // 0x30
	public Transform PrefabStateErrorEvent; // 0x38
	public Transform PrefabStateFinishedEvent; // 0x40
	public Transform PrefabAttackedEvent; // 0x48
	public Transform PrefabInAttackRangeEvent; // 0x50
	public Transform PrefabHealthBelowEvent; // 0x58
	public Transform PrefabInRangeEvent; // 0x60
	public Transform PrefabPerformedAttackEvent; // 0x68
	public Transform PrefabTirednessAboveEvent; // 0x70
	public Transform PrefabHungerAboveEvent; // 0x78
	public Transform PrefabThreatDetectevEvent; // 0x80
	public Transform PrefabTargetDetectevEvent; // 0x88
	public Transform PrefabAmmoBelowEvent; // 0x90
	public Transform PrefabBestTargetDetectedEvent; // 0x98
	public Transform PrefabIsVisibleEvent; // 0xA0
	public Transform PrefabAttackTickEvent; // 0xA8
	public Transform PrefabIsMountedEvent; // 0xB0
	public Transform PrefabAndEvent; // 0xB8
	public Transform PrefabChanceEvent; // 0xC0
	public Transform PrefabTargetLostEvent; // 0xC8
	public Transform PrefabTimeSinceThreatEvent; // 0xD0
	public Transform PrefabOnPositionMemorySetEvent; // 0xD8
	public Transform PrefabAggressionTimerEvent; // 0xE0
	public Transform PrefabReloadingEvent; // 0xE8
	public Transform PrefabInRangeOfHomeEvent; // 0xF0
	public RustText TextStateName; // 0xF8
	public Transform EventContainer; // 0x100
	public ScrollRect Scroll; // 0x108
	public AIState StateType; // 0x110
	public int StateContainerID; // 0x114
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <InputEntityMemorySlot>k__BackingField; // 0x118
	private Transform addNewEventButton; // 0x120

	// Properties
	public int InputEntityMemorySlot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92DA50 Offset: 0x92C050 VA: 0x18092DA50
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92DA60 Offset: 0x92C060 VA: 0x18092DA60
	private void set_InputEntityMemorySlot(int value) { }

	// RVA: 0x92CEB0 Offset: 0x92B4B0 VA: 0x18092CEB0 Slot: 4
	public virtual void Init(AIState stateType, int stateContainerID) { }

	// RVA: 0x92C7E0 Offset: 0x92ADE0 VA: 0x18092C7E0
	public void ClearEvents() { }

	// RVA: 0x92C480 Offset: 0x92AA80 VA: 0x18092C480
	public BaseEventUI AddNewEvent(AIEventType eventType) { }

	// RVA: 0x92D350 Offset: 0x92B950 VA: 0x18092D350
	public void PingTriggeringEvent(int id) { }

	// RVA: 0x92CC50 Offset: 0x92B250 VA: 0x18092CC50
	private BaseEventUI GetEvent(int id) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C310 Offset: 0x7B710 VA: 0x18007C310
	// RVA: 0x92D8B0 Offset: 0x92BEB0 VA: 0x18092D8B0
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x92D0A0 Offset: 0x92B6A0 VA: 0x18092D0A0
	public void Load(AIStateContainer container) { }

	// RVA: 0x92D920 Offset: 0x92BF20 VA: 0x18092D920
	public void SetActiveDebugState(bool flag) { }

	// RVA: 0x92D570 Offset: 0x92BB70 VA: 0x18092D570 Slot: 5
	public virtual AIStateContainer Save() { }

	// RVA: 0x92CB10 Offset: 0x92B110 VA: 0x18092CB10
	private Transform GetEventPrefab(AIEventType eventType) { }

	// RVA: 0x92C370 Offset: 0x92A970 VA: 0x18092C370
	private void AddNewEventButton() { }

	// RVA: 0x92CA40 Offset: 0x92B040 VA: 0x18092CA40
	public void DeleteStateClicked() { }

	// RVA: 0x92C9D0 Offset: 0x92AFD0 VA: 0x18092C9D0
	public void DeleteEvent(BaseEventUI eventUI) { }

	// RVA: 0x92D2F0 Offset: 0x92B8F0 VA: 0x18092D2F0
	public void MoveEventUp(BaseEventUI eventUI) { }

	// RVA: 0x92D260 Offset: 0x92B860 VA: 0x18092D260
	public void MoveEventDown(BaseEventUI eventUI) { }

	// RVA: 0x92DA30 Offset: 0x92C030 VA: 0x18092DA30
	public void .ctor() { }

}

private sealed class BaseStateUI.<ScrollToBottom>d__43 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10791
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BaseStateUI <>4__this; // 0x20

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

	// RVA: 0x93AF00 Offset: 0x939500 VA: 0x18093AF00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93B010 Offset: 0x939610 VA: 0x18093B010 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

