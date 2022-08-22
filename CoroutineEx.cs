public static class CoroutineEx // TypeDefIndex: 11699
{	// Fields
	public static WaitForEndOfFrame waitForEndOfFrame; // 0x0
	public static WaitForFixedUpdate waitForFixedUpdate; // 0x8
	private static Dictionary<float, WaitForSeconds> waitForSecondsBuffer; // 0x10

	// Methods

	// RVA: 0x9F7DA0 Offset: 0x9F63A0 VA: 0x1809F7DA0
	public static WaitForSeconds waitForSeconds(float seconds) { }

	// RVA: 0x9F7D30 Offset: 0x9F6330 VA: 0x1809F7D30
	public static WaitForSecondsRealtimeEx waitForSecondsRealtime(float seconds) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1A50 Offset: 0xD0E50 VA: 0x1800D1A50
	// RVA: 0x9F7BF0 Offset: 0x9F61F0 VA: 0x1809F7BF0
	public static IEnumerator Combine(IEnumerator[] coroutines) { }

	// RVA: 0x9F7C60 Offset: 0x9F6260 VA: 0x1809F7C60
	private static void .cctor() { }

}

private sealed class CoroutineEx.<Combine>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11700
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public IEnumerator[] coroutines; // 0x20

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

	// RVA: 0x9FFD90 Offset: 0x9FE390 VA: 0x1809FFD90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FFEB0 Offset: 0x9FE4B0 VA: 0x1809FFEB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

