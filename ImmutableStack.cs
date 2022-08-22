private sealed class ImmutableStack.EmptyStack<T> : IImmutableStack<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 4799
{	public int Count { get; }


	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	|-ImmutableStack.EmptyStack<object>.get_Count
	*/

	public IImmutableStack<T> Push(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645540 Offset: 0x1643B40 VA: 0x181645540
	|-ImmutableStack.EmptyStack<object>.Push
	*/

	public IImmutableStack<T> Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16454E0 Offset: 0x1643AE0 VA: 0x1816454E0
	|-ImmutableStack.EmptyStack<object>.Pop
	*/

	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645480 Offset: 0x1643A80 VA: 0x181645480
	|-ImmutableStack.EmptyStack<object>.Peek
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD5550 Offset: 0xD4950 VA: 0x1800D5550
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645420 Offset: 0x1643A20 VA: 0x181645420
	|-ImmutableStack.EmptyStack<object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16455C0 Offset: 0x1643BC0 VA: 0x1816455C0
	|-ImmutableStack.EmptyStack<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
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
	|-RVA: 0x164FEF0 Offset: 0x164E4F0 VA: 0x18164FEF0
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
	|-RVA: 0x13CEB40 Offset: 0x13CD140 VA: 0x1813CEB40
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
	|-RVA: 0x16505F0 Offset: 0x164EBF0 VA: 0x1816505F0
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
	|-RVA: 0x164FEF0 Offset: 0x164E4F0 VA: 0x18164FEF0
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
	|-RVA: 0x164FD40 Offset: 0x164E340 VA: 0x18164FD40
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
	|-RVA: 0x164FEA0 Offset: 0x164E4A0 VA: 0x18164FEA0
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

