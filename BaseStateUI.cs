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
	// RVA: 0x92DF60 Offset: 0x92C560 VA: 0x18092DF60
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92DF70 Offset: 0x92C570 VA: 0x18092DF70
	private void set_InputEntityMemorySlot(int value) { }

	// RVA: 0x92D3C0 Offset: 0x92B9C0 VA: 0x18092D3C0 Slot: 4
	public virtual void Init(AIState stateType, int stateContainerID) { }

	// RVA: 0x92CCF0 Offset: 0x92B2F0 VA: 0x18092CCF0
	public void ClearEvents() { }

	// RVA: 0x92C990 Offset: 0x92AF90 VA: 0x18092C990
	public BaseEventUI AddNewEvent(AIEventType eventType) { }

	// RVA: 0x92D860 Offset: 0x92BE60 VA: 0x18092D860
	public void PingTriggeringEvent(int id) { }

	// RVA: 0x92D160 Offset: 0x92B760 VA: 0x18092D160
	private BaseEventUI GetEvent(int id) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C310 Offset: 0x7B710 VA: 0x18007C310
	// RVA: 0x92DDC0 Offset: 0x92C3C0 VA: 0x18092DDC0
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x92D5B0 Offset: 0x92BBB0 VA: 0x18092D5B0
	public void Load(AIStateContainer container) { }

	// RVA: 0x92DE30 Offset: 0x92C430 VA: 0x18092DE30
	public void SetActiveDebugState(bool flag) { }

	// RVA: 0x92DA80 Offset: 0x92C080 VA: 0x18092DA80 Slot: 5
	public virtual AIStateContainer Save() { }

	// RVA: 0x92D020 Offset: 0x92B620 VA: 0x18092D020
	private Transform GetEventPrefab(AIEventType eventType) { }

	// RVA: 0x92C880 Offset: 0x92AE80 VA: 0x18092C880
	private void AddNewEventButton() { }

	// RVA: 0x92CF50 Offset: 0x92B550 VA: 0x18092CF50
	public void DeleteStateClicked() { }

	// RVA: 0x92CEE0 Offset: 0x92B4E0 VA: 0x18092CEE0
	public void DeleteEvent(BaseEventUI eventUI) { }

	// RVA: 0x92D800 Offset: 0x92BE00 VA: 0x18092D800
	public void MoveEventUp(BaseEventUI eventUI) { }

	// RVA: 0x92D770 Offset: 0x92BD70 VA: 0x18092D770
	public void MoveEventDown(BaseEventUI eventUI) { }

	// RVA: 0x92DF40 Offset: 0x92C540 VA: 0x18092DF40
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

	// RVA: 0x93B410 Offset: 0x939A10 VA: 0x18093B410 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93B520 Offset: 0x939B20 VA: 0x18093B520 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

