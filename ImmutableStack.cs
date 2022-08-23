private sealed class ImmutableStack.EmptyStack<T> : IImmutableStack<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 4799
{	public int Count { get; }


	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x511990 Offset: 0x50FF90 VA: 0x180511990
	|-ImmutableStack.EmptyStack<object>.get_Count
	*/

	public IImmutableStack<T> Push(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645580 Offset: 0x1643B80 VA: 0x181645580
	|-ImmutableStack.EmptyStack<object>.Push
	*/

	public IImmutableStack<T> Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645520 Offset: 0x1643B20 VA: 0x181645520
	|-ImmutableStack.EmptyStack<object>.Pop
	*/

	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16454C0 Offset: 0x1643AC0 VA: 0x1816454C0
	|-ImmutableStack.EmptyStack<object>.Peek
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD5550 Offset: 0xD4950 VA: 0x1800D5550
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645460 Offset: 0x1643A60 VA: 0x181645460
	|-ImmutableStack.EmptyStack<object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645600 Offset: 0x1643C00 VA: 0x181645600
	|-ImmutableStack.EmptyStack<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-ImmutableStack.EmptyStack<object>..ctor
	*/

}

private sealed class ImmutableStack.EmptyStack.<GetEnumerator>d__5<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4800
{	private int <>1__state; // 0x0
	private T <>2__current; // 0x0

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FF30 Offset: 0x164E530 VA: 0x18164FF30
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CEB80 Offset: 0x13CD180 VA: 0x1813CEB80
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650630 Offset: 0x164EC30 VA: 0x181650630
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.IEnumerator.get_Current
	*/

}

private sealed class ImmutableStack.<GetEnumerator>d__13<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4801
{	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ImmutableStack<T> <>4__this; // 0x0
	private IImmutableStack<T> <stack>5__2; // 0x0

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FF30 Offset: 0x164E530 VA: 0x18164FF30
	|-ImmutableStack.<GetEnumerator>d__13<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FD80 Offset: 0x164E380 VA: 0x18164FD80
	|-ImmutableStack.<GetEnumerator>d__13<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FEE0 Offset: 0x164E4E0 VA: 0x18164FEE0
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.IEnumerator.get_Current
	*/

}

