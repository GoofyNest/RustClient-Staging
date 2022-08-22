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

	// RVA: 0x76AE90 Offset: 0x769490 VA: 0x18076AE90
	public bool get_IsOpen() { }

	// RVA: 0xA9A120 Offset: 0xA98720 VA: 0x180A9A120
	public void OnEnable() { }

	// RVA: 0xA99D60 Offset: 0xA98360 VA: 0x180A99D60
	private void ClientConnected() { }

	// RVA: 0xA9A220 Offset: 0xA98820 VA: 0x180A9A220
	public void Reset() { }

	[IteratorStateMachineAttribute] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	// RVA: 0xA9A860 Offset: 0xA98E60 VA: 0x180A9A860
	private IEnumerator Think() { }

	// RVA: 0xA9A2A0 Offset: 0xA988A0 VA: 0x180A9A2A0
	public bool ShouldShow() { }

	// RVA: 0xA99D70 Offset: 0xA98370 VA: 0x180A99D70
	public void Hide() { }

	// RVA: 0xA9A4E0 Offset: 0xA98AE0 VA: 0x180A9A4E0
	private void Show() { }

	// RVA: 0xA99EF0 Offset: 0xA984F0 VA: 0x180A99EF0
	public void Initialize() { }

	// RVA: 0xA9A6B0 Offset: 0xA98CB0 VA: 0x180A9A6B0
	private void SwitchToGroup(AchievementGroup group) { }

	// RVA: 0xA9A180 Offset: 0xA98780 VA: 0x180A9A180
	public void OnItemComplete() { }

	// RVA: 0xA99A00 Offset: 0xA98000 VA: 0x180A99A00
	public void CheckForListComplete() { }

	// RVA: 0xA999F0 Offset: 0xA97FF0 VA: 0x180A999F0
	public void BlockNextOpenSound() { }

	// RVA: 0xA9A8D0 Offset: 0xA98ED0 VA: 0x180A9A8D0
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

	// RVA: 0xAAB560 Offset: 0xAA9B60 VA: 0x180AAB560 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAAB640 Offset: 0xAA9C40 VA: 0x180AAB640 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

