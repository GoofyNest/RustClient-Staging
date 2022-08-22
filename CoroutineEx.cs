public static class CoroutineEx // TypeDefIndex: 11699
{	// Fields
	public static WaitForEndOfFrame waitForEndOfFrame; // 0x0
	public static WaitForFixedUpdate waitForFixedUpdate; // 0x8
	private static Dictionary<float, WaitForSeconds> waitForSecondsBuffer; // 0x10

	// Methods

	// RVA: 0x9F8550 Offset: 0x9F6B50 VA: 0x1809F8550
	public static WaitForSeconds waitForSeconds(float seconds) { }

	// RVA: 0x9F84E0 Offset: 0x9F6AE0 VA: 0x1809F84E0
	public static WaitForSecondsRealtimeEx waitForSecondsRealtime(float seconds) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1A50 Offset: 0xD0E50 VA: 0x1800D1A50
	// RVA: 0x9F83A0 Offset: 0x9F69A0 VA: 0x1809F83A0
	public static IEnumerator Combine(IEnumerator[] coroutines) { }

	// RVA: 0x9F8410 Offset: 0x9F6A10 VA: 0x1809F8410
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

	// RVA: 0xA00540 Offset: 0x9FEB40 VA: 0x180A00540 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA00660 Offset: 0x9FEC60 VA: 0x180A00660 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

