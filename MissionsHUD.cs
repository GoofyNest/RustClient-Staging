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

	// RVA: 0x76ADE0 Offset: 0x7693E0 VA: 0x18076ADE0
	public bool get_IsOpen() { }

	// RVA: 0x76A380 Offset: 0x768980 VA: 0x18076A380
	public void OnEnable() { }

	// RVA: 0x769C60 Offset: 0x768260 VA: 0x180769C60
	private void ClientConnected() { }

	// RVA: 0x76A480 Offset: 0x768A80 VA: 0x18076A480
	public void Reset() { }

	// RVA: 0x769C70 Offset: 0x768270 VA: 0x180769C70
	public static void ClientMissionUpdate() { }

	// RVA: 0x769D40 Offset: 0x768340 VA: 0x180769D40
	public void ForceUpdate() { }

	// RVA: 0x76A8E0 Offset: 0x768EE0 VA: 0x18076A8E0
	public void UpdateTimeText() { }

	// RVA: 0x76AD70 Offset: 0x769370 VA: 0x18076AD70
	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x9EC10 Offset: 0x9E010 VA: 0x18009EC10
	// RVA: 0x76A870 Offset: 0x768E70 VA: 0x18076A870
	private IEnumerator Think() { }

	// RVA: 0x76A500 Offset: 0x768B00 VA: 0x18076A500
	public bool ShouldShow() { }

	// RVA: 0x769EF0 Offset: 0x7684F0 VA: 0x180769EF0
	public void Hide() { }

	// RVA: 0x76A6A0 Offset: 0x768CA0 VA: 0x18076A6A0
	private void Show() { }

	// RVA: 0x76A070 Offset: 0x768670 VA: 0x18076A070
	public void Initialize() { }

	// RVA: 0x76A3E0 Offset: 0x7689E0 VA: 0x18076A3E0
	public void OnItemComplete() { }

	// RVA: 0x769900 Offset: 0x767F00 VA: 0x180769900
	public void CheckForListComplete() { }

	// RVA: 0x513DE0 Offset: 0x5123E0 VA: 0x180513DE0
	public void BlockNextOpenSound() { }

	// RVA: 0x76AD80 Offset: 0x769380 VA: 0x18076AD80
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

	// RVA: 0x77F520 Offset: 0x77DB20 VA: 0x18077F520 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77F600 Offset: 0x77DC00 VA: 0x18077F600 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

