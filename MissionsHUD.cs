public class MissionsHUD : SingletonComponent<MissionsHUD> // TypeDefIndex: 11184
{	// Fields
	public SoundDefinition listComplete; // 0x18
	public SoundDefinition itemComplete; // 0x20
	public SoundDefinition popup; // 0x28
	public Canvas Canvas; // 0x30
	public Text titleText; // 0x38
	public GameObject timerObject; // 0x40
	public RustText timerText; // 0x48
	private MissionsHUDToDo[] items; // 0x50
	private bool blockOpenSound; // 0x58
	private float nextTextUpdateTime; // 0x5C

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x76AE90 Offset: 0x769490 VA: 0x18076AE90
	public bool get_IsOpen() { }

	// RVA: 0x76A430 Offset: 0x768A30 VA: 0x18076A430
	public void OnEnable() { }

	// RVA: 0x769D10 Offset: 0x768310 VA: 0x180769D10
	private void ClientConnected() { }

	// RVA: 0x76A530 Offset: 0x768B30 VA: 0x18076A530
	public void Reset() { }

	// RVA: 0x769D20 Offset: 0x768320 VA: 0x180769D20
	public static void ClientMissionUpdate() { }

	// RVA: 0x769DF0 Offset: 0x7683F0 VA: 0x180769DF0
	public void ForceUpdate() { }

	// RVA: 0x76A990 Offset: 0x768F90 VA: 0x18076A990
	public void UpdateTimeText() { }

	// RVA: 0x76AE20 Offset: 0x769420 VA: 0x18076AE20
	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x9EC10 Offset: 0x9E010 VA: 0x18009EC10
	// RVA: 0x76A920 Offset: 0x768F20 VA: 0x18076A920
	private IEnumerator Think() { }

	// RVA: 0x76A5B0 Offset: 0x768BB0 VA: 0x18076A5B0
	public bool ShouldShow() { }

	// RVA: 0x769FA0 Offset: 0x7685A0 VA: 0x180769FA0
	public void Hide() { }

	// RVA: 0x76A750 Offset: 0x768D50 VA: 0x18076A750
	private void Show() { }

	// RVA: 0x76A120 Offset: 0x768720 VA: 0x18076A120
	public void Initialize() { }

	// RVA: 0x76A490 Offset: 0x768A90 VA: 0x18076A490
	public void OnItemComplete() { }

	// RVA: 0x7699B0 Offset: 0x767FB0 VA: 0x1807699B0
	public void CheckForListComplete() { }

	// RVA: 0x513E50 Offset: 0x512450 VA: 0x180513E50
	public void BlockNextOpenSound() { }

	// RVA: 0x76AE30 Offset: 0x769430 VA: 0x18076AE30
	public void .ctor() { }

}

private sealed class MissionsHUD.<Think>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11185
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MissionsHUD <>4__this; // 0x20

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

	// RVA: 0x77F5D0 Offset: 0x77DBD0 VA: 0x18077F5D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77F6B0 Offset: 0x77DCB0 VA: 0x18077F6B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

