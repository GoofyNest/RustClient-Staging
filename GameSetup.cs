public class GameSetup : MonoBehaviour // TypeDefIndex: 9888
{	// Fields
	public static bool RunOnce; // 0x0
	public bool startServer; // 0x18
	public string clientConnectCommand; // 0x20
	public bool loadMenu; // 0x28
	public bool loadLevel; // 0x29
	public string loadLevelScene; // 0x30
	public bool loadSave; // 0x38
	public string loadSaveFile; // 0x40

	// Methods

	// RVA: 0x75C550 Offset: 0x75AB50 VA: 0x18075C550
	protected void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0xA4B30 Offset: 0xA3F30 VA: 0x1800A4B30
	// RVA: 0x75C9E0 Offset: 0x75AFE0 VA: 0x18075C9E0
	private IEnumerator DoGameSetup() { }

	// RVA: 0x75C7F0 Offset: 0x75ADF0 VA: 0x18075C7F0
	private void ClientJoin() { }

	// RVA: 0x75CA50 Offset: 0x75B050 VA: 0x18075CA50
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class GameSetup.<DoGameSetup>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9889
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameSetup <>4__this; // 0x20

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

	// RVA: 0x7626F0 Offset: 0x760CF0 VA: 0x1807626F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x762BB0 Offset: 0x7611B0 VA: 0x180762BB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

