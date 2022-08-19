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

	// RVA: 0x76AD80 Offset: 0x769380 VA: 0x18076AD80
	public bool get_IsOpen() { }

	// RVA: 0x76A320 Offset: 0x768920 VA: 0x18076A320
	public void OnEnable() { }

	// RVA: 0x769C00 Offset: 0x768200 VA: 0x180769C00
	private void ClientConnected() { }

	// RVA: 0x76A420 Offset: 0x768A20 VA: 0x18076A420
	public void Reset() { }

	// RVA: 0x769C10 Offset: 0x768210 VA: 0x180769C10
	public static void ClientMissionUpdate() { }

	// RVA: 0x769CE0 Offset: 0x7682E0 VA: 0x180769CE0
	public void ForceUpdate() { }

	// RVA: 0x76A880 Offset: 0x768E80 VA: 0x18076A880
	public void UpdateTimeText() { }

	// RVA: 0x76AD10 Offset: 0x769310 VA: 0x18076AD10
	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x9EB80 Offset: 0x9DF80 VA: 0x18009EB80
	// RVA: 0x76A810 Offset: 0x768E10 VA: 0x18076A810
	private IEnumerator Think() { }

	// RVA: 0x76A4A0 Offset: 0x768AA0 VA: 0x18076A4A0
	public bool ShouldShow() { }

	// RVA: 0x769E90 Offset: 0x768490 VA: 0x180769E90
	public void Hide() { }

	// RVA: 0x76A640 Offset: 0x768C40 VA: 0x18076A640
	private void Show() { }

	// RVA: 0x76A010 Offset: 0x768610 VA: 0x18076A010
	public void Initialize() { }

	// RVA: 0x76A380 Offset: 0x768980 VA: 0x18076A380
	public void OnItemComplete() { }

	// RVA: 0x7698A0 Offset: 0x767EA0 VA: 0x1807698A0
	public void CheckForListComplete() { }

	// RVA: 0x513E50 Offset: 0x512450 VA: 0x180513E50
	public void BlockNextOpenSound() { }

	// RVA: 0x76AD20 Offset: 0x769320 VA: 0x18076AD20
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x77F4C0 Offset: 0x77DAC0 VA: 0x18077F4C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x77F5A0 Offset: 0x77DBA0 VA: 0x18077F5A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

