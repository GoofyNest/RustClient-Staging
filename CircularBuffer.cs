private sealed class CircularBuffer.<GetEnumerator>d__26<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4832
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public CircularBuffer<T> <>4__this; // 0x0
	private IEnumerator<ArraySegment<T>> <>7__wrap1; // 0x0
	private ArraySegment<T> <segment>5__3; // 0x0
	private int <i>5__4; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8E80 Offset: 0x15E7480 VA: 0x1815E8E80
	|-CircularBuffer.<GetEnumerator>d__26<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B500 Offset: 0x1449B00 VA: 0x18144B500
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8B40 Offset: 0x15E7140 VA: 0x1815E8B40
	|-CircularBuffer.<GetEnumerator>d__26<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8E30 Offset: 0x15E7430 VA: 0x1815E8E30
	|-CircularBuffer.<GetEnumerator>d__26<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8DE0 Offset: 0x15E73E0 VA: 0x1815E8DE0
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.IEnumerator.get_Current
	*/

}

private sealed class CircularBuffer.<GetItems>d__15<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 7621
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private int start; // 0x0
	public int <>3__start; // 0x0
	public CircularBuffer<T> <>4__this; // 0x0
	private int end; // 0x0
	public int <>3__end; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B7C0 Offset: 0x1449DC0 VA: 0x18144B7C0
	|-CircularBuffer.<GetItems>d__15<byte>..ctor
	|
	|-RVA: 0x144B840 Offset: 0x1449E40 VA: 0x18144B840
	|-CircularBuffer.<GetItems>d__15<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-CircularBuffer.<GetItems>d__15<byte>.System.IDisposable.Dispose
	|-CircularBuffer.<GetItems>d__15<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FC570 Offset: 0x17FAB70 VA: 0x1817FC570
	|-CircularBuffer.<GetItems>d__15<byte>.MoveNext
	|
	|-RVA: 0x17FC4E0 Offset: 0x17FAAE0 VA: 0x1817FC4E0
	|-CircularBuffer.<GetItems>d__15<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA10E00 Offset: 0xA0F400 VA: 0x180A10E00
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FC7C0 Offset: 0x17FADC0 VA: 0x1817FC7C0
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x17FC770 Offset: 0x17FAD70 VA: 0x1817FC770
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FC810 Offset: 0x17FAE10 VA: 0x1817FC810
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FC6B0 Offset: 0x17FACB0 VA: 0x1817FC6B0
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x17FC5F0 Offset: 0x17FABF0 VA: 0x1817FC5F0
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760E40 Offset: 0x175F440 VA: 0x181760E40
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerable.GetEnumerator
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

