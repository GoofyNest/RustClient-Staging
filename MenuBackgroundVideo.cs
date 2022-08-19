public class MenuBackgroundVideo : SingletonComponent<MenuBackgroundVideo> // TypeDefIndex: 11122
{	// Fields
	private string[] videos; // 0x18
	private int index; // 0x20
	private bool errored; // 0x24

	// Methods

	// RVA: 0x95DC30 Offset: 0x95C230 VA: 0x18095DC30 Slot: 6
	protected override void Awake() { }

	// RVA: 0x95E140 Offset: 0x95C740 VA: 0x18095E140
	private void OnVideoError(VideoPlayer source, string message) { }

	// RVA: 0x95DCE0 Offset: 0x95C2E0 VA: 0x18095DCE0
	public void LoadVideoList() { }

	// RVA: 0x95E1C0 Offset: 0x95C7C0 VA: 0x18095E1C0
	public void Update() { }

	// RVA: 0x95DEF0 Offset: 0x95C4F0 VA: 0x18095DEF0
	private void NextVideo() { }

	[IteratorStateMachineAttribute] // RVA: 0x98440 Offset: 0x97840 VA: 0x180098440
	// RVA: 0x95E150 Offset: 0x95C750 VA: 0x18095E150
	internal IEnumerator ReadyVideo() { }

	// RVA: 0x95E210 Offset: 0x95C810 VA: 0x18095E210
	public void .ctor() { }

}

private sealed class MenuBackgroundVideo.<>c // TypeDefIndex: 11123
{	// Fields
	public static readonly MenuBackgroundVideo.<>c <>9; // 0x0
	public static Func<string, bool> <>9__5_0; // 0x8
	public static Func<string, Guid> <>9__5_1; // 0x10
	public static Func<string, bool> <>9__7_0; // 0x18

	// Methods

	// RVA: 0x970B00 Offset: 0x96F100 VA: 0x180970B00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x970980 Offset: 0x96EF80 VA: 0x180970980
	internal bool <LoadVideoList>b__5_0(string x) { }

	// RVA: 0x9709F0 Offset: 0x96EFF0 VA: 0x1809709F0
	internal Guid <LoadVideoList>b__5_1(string x) { }

	// RVA: 0x970A50 Offset: 0x96F050 VA: 0x180970A50
	internal bool <NextVideo>b__7_0(string x) { }

}

private sealed class MenuBackgroundVideo.<ReadyVideo>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11124
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MenuBackgroundVideo <>4__this; // 0x20
	private VideoPlayer <player>5__2; // 0x28

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

	// RVA: 0x970840 Offset: 0x96EE40 VA: 0x180970840 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x970910 Offset: 0x96EF10 VA: 0x180970910 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

