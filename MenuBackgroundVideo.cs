public class MenuBackgroundVideo : SingletonComponent<MenuBackgroundVideo> // TypeDefIndex: 11122
{	// Fields
	private string[] videos; // 0x18
	private int index; // 0x20
	private bool errored; // 0x24

	// Methods

	// RVA: 0x95E240 Offset: 0x95C840 VA: 0x18095E240 Slot: 6
	protected override void Awake() { }

	// RVA: 0x95E750 Offset: 0x95CD50 VA: 0x18095E750
	private void OnVideoError(VideoPlayer source, string message) { }

	// RVA: 0x95E2F0 Offset: 0x95C8F0 VA: 0x18095E2F0
	public void LoadVideoList() { }

	// RVA: 0x95E7D0 Offset: 0x95CDD0 VA: 0x18095E7D0
	public void Update() { }

	// RVA: 0x95E500 Offset: 0x95CB00 VA: 0x18095E500
	private void NextVideo() { }

	[IteratorStateMachineAttribute] // RVA: 0x98540 Offset: 0x97940 VA: 0x180098540
	// RVA: 0x95E760 Offset: 0x95CD60 VA: 0x18095E760
	internal IEnumerator ReadyVideo() { }

	// RVA: 0x95E820 Offset: 0x95CE20 VA: 0x18095E820
	public void .ctor() { }

}

private sealed class MenuBackgroundVideo.<>c // TypeDefIndex: 11123
{	// Fields
	public static readonly MenuBackgroundVideo.<>c <>9; // 0x0
	public static Func<string, bool> <>9__5_0; // 0x8
	public static Func<string, Guid> <>9__5_1; // 0x10
	public static Func<string, bool> <>9__7_0; // 0x18

	// Methods

	// RVA: 0x971110 Offset: 0x96F710 VA: 0x180971110
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x970F90 Offset: 0x96F590 VA: 0x180970F90
	internal bool <LoadVideoList>b__5_0(string x) { }

	// RVA: 0x971000 Offset: 0x96F600 VA: 0x180971000
	internal Guid <LoadVideoList>b__5_1(string x) { }

	// RVA: 0x971060 Offset: 0x96F660 VA: 0x180971060
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x970E50 Offset: 0x96F450 VA: 0x180970E50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x970F20 Offset: 0x96F520 VA: 0x180970F20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

