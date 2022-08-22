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
	// RVA: 0x92D940 Offset: 0x92BF40 VA: 0x18092D940
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92D950 Offset: 0x92BF50 VA: 0x18092D950
	private void set_InputEntityMemorySlot(int value) { }

	// RVA: 0x92CDA0 Offset: 0x92B3A0 VA: 0x18092CDA0 Slot: 4
	public virtual void Init(AIState stateType, int stateContainerID) { }

	// RVA: 0x92C6D0 Offset: 0x92ACD0 VA: 0x18092C6D0
	public void ClearEvents() { }

	// RVA: 0x92C370 Offset: 0x92A970 VA: 0x18092C370
	public BaseEventUI AddNewEvent(AIEventType eventType) { }

	// RVA: 0x92D240 Offset: 0x92B840 VA: 0x18092D240
	public void PingTriggeringEvent(int id) { }

	// RVA: 0x92CB40 Offset: 0x92B140 VA: 0x18092CB40
	private BaseEventUI GetEvent(int id) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C310 Offset: 0x7B710 VA: 0x18007C310
	// RVA: 0x92D7A0 Offset: 0x92BDA0 VA: 0x18092D7A0
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x92CF90 Offset: 0x92B590 VA: 0x18092CF90
	public void Load(AIStateContainer container) { }

	// RVA: 0x92D810 Offset: 0x92BE10 VA: 0x18092D810
	public void SetActiveDebugState(bool flag) { }

	// RVA: 0x92D460 Offset: 0x92BA60 VA: 0x18092D460 Slot: 5
	public virtual AIStateContainer Save() { }

	// RVA: 0x92CA00 Offset: 0x92B000 VA: 0x18092CA00
	private Transform GetEventPrefab(AIEventType eventType) { }

	// RVA: 0x92C260 Offset: 0x92A860 VA: 0x18092C260
	private void AddNewEventButton() { }

	// RVA: 0x92C930 Offset: 0x92AF30 VA: 0x18092C930
	public void DeleteStateClicked() { }

	// RVA: 0x92C8C0 Offset: 0x92AEC0 VA: 0x18092C8C0
	public void DeleteEvent(BaseEventUI eventUI) { }

	// RVA: 0x92D1E0 Offset: 0x92B7E0 VA: 0x18092D1E0
	public void MoveEventUp(BaseEventUI eventUI) { }

	// RVA: 0x92D150 Offset: 0x92B750 VA: 0x18092D150
	public void MoveEventDown(BaseEventUI eventUI) { }

	// RVA: 0x92D920 Offset: 0x92BF20 VA: 0x18092D920
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

	// RVA: 0x93ADF0 Offset: 0x9393F0 VA: 0x18093ADF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93AF00 Offset: 0x939500 VA: 0x18093AF00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

