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

	// RVA: 0x76ADE0 Offset: 0x7693E0 VA: 0x18076ADE0
	public bool get_IsOpen() { }

	// RVA: 0xA9A5F0 Offset: 0xA98BF0 VA: 0x180A9A5F0
	public void OnEnable() { }

	// RVA: 0xA9A230 Offset: 0xA98830 VA: 0x180A9A230
	private void ClientConnected() { }

	// RVA: 0xA9A6F0 Offset: 0xA98CF0 VA: 0x180A9A6F0
	public void Reset() { }

	[IteratorStateMachineAttribute] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	// RVA: 0xA9AD30 Offset: 0xA99330 VA: 0x180A9AD30
	private IEnumerator Think() { }

	// RVA: 0xA9A770 Offset: 0xA98D70 VA: 0x180A9A770
	public bool ShouldShow() { }

	// RVA: 0xA9A240 Offset: 0xA98840 VA: 0x180A9A240
	public void Hide() { }

	// RVA: 0xA9A9B0 Offset: 0xA98FB0 VA: 0x180A9A9B0
	private void Show() { }

	// RVA: 0xA9A3C0 Offset: 0xA989C0 VA: 0x180A9A3C0
	public void Initialize() { }

	// RVA: 0xA9AB80 Offset: 0xA99180 VA: 0x180A9AB80
	private void SwitchToGroup(AchievementGroup group) { }

	// RVA: 0xA9A650 Offset: 0xA98C50 VA: 0x180A9A650
	public void OnItemComplete() { }

	// RVA: 0xA99ED0 Offset: 0xA984D0 VA: 0x180A99ED0
	public void CheckForListComplete() { }

	// RVA: 0xA99EC0 Offset: 0xA984C0 VA: 0x180A99EC0
	public void BlockNextOpenSound() { }

	// RVA: 0xA9ADA0 Offset: 0xA993A0 VA: 0x180A9ADA0
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

	// RVA: 0xAABA30 Offset: 0xAAA030 VA: 0x180AABA30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAABB10 Offset: 0xAAA110 VA: 0x180AABB10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

