public class Achievements : SingletonComponent<Achievements> // TypeDefIndex: 10823
{	// Fields
	public SoundDefinition listComplete; // 0x18
	public SoundDefinition itemComplete; // 0x20
	public SoundDefinition popup; // 0x28
	public Canvas Canvas; // 0x30
	public Text titleText; // 0x38
	private AchievementTodo[] items; // 0x40
	private bool blockOpenSound; // 0x48

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x76AD80 Offset: 0x769380 VA: 0x18076AD80
	public bool get_IsOpen() { }

	// RVA: 0xA99E60 Offset: 0xA98460 VA: 0x180A99E60
	public void OnEnable() { }

	// RVA: 0xA99AA0 Offset: 0xA980A0 VA: 0x180A99AA0
	private void ClientConnected() { }

	// RVA: 0xA99F60 Offset: 0xA98560 VA: 0x180A99F60
	public void Reset() { }

	[IteratorStateMachineAttribute] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	// RVA: 0xA9A5A0 Offset: 0xA98BA0 VA: 0x180A9A5A0
	private IEnumerator Think() { }

	// RVA: 0xA99FE0 Offset: 0xA985E0 VA: 0x180A99FE0
	public bool ShouldShow() { }

	// RVA: 0xA99AB0 Offset: 0xA980B0 VA: 0x180A99AB0
	public void Hide() { }

	// RVA: 0xA9A220 Offset: 0xA98820 VA: 0x180A9A220
	private void Show() { }

	// RVA: 0xA99C30 Offset: 0xA98230 VA: 0x180A99C30
	public void Initialize() { }

	// RVA: 0xA9A3F0 Offset: 0xA989F0 VA: 0x180A9A3F0
	private void SwitchToGroup(AchievementGroup group) { }

	// RVA: 0xA99EC0 Offset: 0xA984C0 VA: 0x180A99EC0
	public void OnItemComplete() { }

	// RVA: 0xA99740 Offset: 0xA97D40 VA: 0x180A99740
	public void CheckForListComplete() { }

	// RVA: 0xA99730 Offset: 0xA97D30 VA: 0x180A99730
	public void BlockNextOpenSound() { }

	// RVA: 0xA9A610 Offset: 0xA98C10 VA: 0x180A9A610
	public void .ctor() { }

}

private sealed class Achievements.<Think>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10824
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Achievements <>4__this; // 0x20

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

	// RVA: 0xAAB2A0 Offset: 0xAA98A0 VA: 0x180AAB2A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAAB380 Offset: 0xAA9980 VA: 0x180AAB380 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

