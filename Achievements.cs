public class Achievements : SingletonComponent<Achievements> // TypeDefIndex: 10823
{	public SoundDefinition listComplete; // 0x18
	public SoundDefinition itemComplete; // 0x20
	public SoundDefinition popup; // 0x28
	public Canvas Canvas; // 0x30
	public Text titleText; // 0x38
	private AchievementTodo[] items; // 0x40
	private bool blockOpenSound; // 0x48

	public bool IsOpen { get; }


	public bool get_IsOpen() { }

	public void OnEnable() { }

	private void ClientConnected() { }

	public void Reset() { }

	[IteratorStateMachineAttribute] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	private IEnumerator Think() { }

	public bool ShouldShow() { }

	public void Hide() { }

	private void Show() { }

	public void Initialize() { }

	private void SwitchToGroup(AchievementGroup group) { }

	public void OnItemComplete() { }

	public void CheckForListComplete() { }

	public void BlockNextOpenSound() { }

	public void .ctor() { }

}

private sealed class Achievements.<Think>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10824
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Achievements <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

