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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FEF0 Offset: 0x164E4F0 VA: 0x18164FEF0
	|-CircularBuffer.<GetEnumerator>d__26<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895460 Offset: 0x1893A60 VA: 0x181895460
	|-CircularBuffer.<GetEnumerator>d__26<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895750 Offset: 0x1893D50 VA: 0x181895750
	|-CircularBuffer.<GetEnumerator>d__26<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895700 Offset: 0x1893D00 VA: 0x181895700
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-CircularBuffer.<GetItems>d__15<byte>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-CircularBuffer.<GetItems>d__15<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	|-RVA: 0x16506D0 Offset: 0x164ECD0 VA: 0x1816506D0
	|-CircularBuffer.<GetItems>d__15<byte>.MoveNext
	|
	|-RVA: 0x1650640 Offset: 0x164EC40 VA: 0x181650640
	|-CircularBuffer.<GetItems>d__15<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650950 Offset: 0x164EF50 VA: 0x181650950
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1650900 Offset: 0x164EF00 VA: 0x181650900
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16509A0 Offset: 0x164EFA0 VA: 0x1816509A0
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650810 Offset: 0x164EE10 VA: 0x181650810
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1650750 Offset: 0x164ED50 VA: 0x181650750
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16508D0 Offset: 0x164EED0 VA: 0x1816508D0
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerable.GetEnumerator
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

