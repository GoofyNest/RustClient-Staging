public static class CoroutineEx // TypeDefIndex: 11699
{	public static WaitForEndOfFrame waitForEndOfFrame; // 0x0
	public static WaitForFixedUpdate waitForFixedUpdate; // 0x8
	private static Dictionary<float, WaitForSeconds> waitForSecondsBuffer; // 0x10


	public static WaitForSeconds waitForSeconds(float seconds) { }

	public static WaitForSecondsRealtimeEx waitForSecondsRealtime(float seconds) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1A50 Offset: 0xD0E50 VA: 0x1800D1A50
	public static IEnumerator Combine(IEnumerator[] coroutines) { }

	private static void .cctor() { }

}

private sealed class CoroutineEx.<Combine>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11700
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public IEnumerator[] coroutines; // 0x20

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

