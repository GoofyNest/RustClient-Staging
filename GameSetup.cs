public class GameSetup : MonoBehaviour // TypeDefIndex: 9888
{	public static bool RunOnce; // 0x0
	public bool startServer; // 0x18
	public string clientConnectCommand; // 0x20
	public bool loadMenu; // 0x28
	public bool loadLevel; // 0x29
	public string loadLevelScene; // 0x30
	public bool loadSave; // 0x38
	public string loadSaveFile; // 0x40


	protected void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0xA4BC0 Offset: 0xA3FC0 VA: 0x1800A4BC0
	private IEnumerator DoGameSetup() { }

	private void ClientJoin() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class GameSetup.<DoGameSetup>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9889
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameSetup <>4__this; // 0x20

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

