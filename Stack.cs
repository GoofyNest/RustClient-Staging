public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1423
{
// Namespace: System.Collections
[DebuggerDisplayAttribute] // RVA: 0xEA140 Offset: 0xE9540 VA: 0x1800EA140
[DebuggerTypeProxyAttribute] // RVA: 0xEA140 Offset: 0xE9540 VA: 0x1800EA140
[ComVisibleAttribute] // RVA: 0xEA140 Offset: 0xE9540 VA: 0x1800EA140
[Serializable]
public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1423
	// Fields
	private object[] _array; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Count { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x146B6B0 Offset: 0x1469CB0 VA: 0x18146B6B0
	public void .ctor() { }

	// RVA: 0x146B710 Offset: 0x1469D10 VA: 0x18146B710
	public void .ctor(int initialCapacity) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x146B7D0 Offset: 0x1469DD0 VA: 0x18146B7D0 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x146AF60 Offset: 0x1469560 VA: 0x18146AF60 Slot: 11
	public virtual void Clear() { }

	// RVA: 0x146AF90 Offset: 0x1469590 VA: 0x18146AF90 Slot: 12
	public virtual object Clone() { }

	// RVA: 0x146B0B0 Offset: 0x14696B0 VA: 0x18146B0B0 Slot: 13
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x146B370 Offset: 0x1469970 VA: 0x18146B370 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x146B410 Offset: 0x1469A10 VA: 0x18146B410 Slot: 15
	public virtual object Peek() { }

	// RVA: 0x146B4C0 Offset: 0x1469AC0 VA: 0x18146B4C0 Slot: 16
	public virtual object Pop() { }

	// RVA: 0x146B590 Offset: 0x1469B90 VA: 0x18146B590 Slot: 17
	public virtual void Push(object obj) { }

}

private class Stack.StackEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1424
{	// Fields
	private Stack _stack; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x146AE20 Offset: 0x1469420 VA: 0x18146AE20
	internal void .ctor(Stack stack) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 7
	public object Clone() { }

	// RVA: 0x146AC30 Offset: 0x1469230 VA: 0x18146AC30 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x146AE90 Offset: 0x1469490 VA: 0x18146AE90 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x146AD80 Offset: 0x1469380 VA: 0x18146AD80 Slot: 10
	public virtual void Reset() { }

}

public struct Stack.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3153
{	// Fields
	private readonly Stack<T> _stack; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Stack<T> stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F660 Offset: 0x22EA60 VA: 0x18022F660
	|-Stack.Enumerator<KeyValuePair<int, int>>..ctor
	|-Stack.Enumerator<IntPtr>..ctor
	|-Stack.Enumerator<object>..ctor
	|-Stack.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x22F760 Offset: 0x22EB60 VA: 0x18022F760
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x22F700 Offset: 0x22EB00 VA: 0x18022F700
	|-Stack.Enumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x22F6B0 Offset: 0x22EAB0 VA: 0x18022F6B0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22E8C0 Offset: 0x22DCC0 VA: 0x18022E8C0
	|-Stack.Enumerator<Poolable>.Dispose
	|-Stack.Enumerator<KeyValuePair<int, int>>.Dispose
	|-Stack.Enumerator<IntPtr>.Dispose
	|-Stack.Enumerator<object>.Dispose
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.Dispose
	|-Stack.Enumerator<Matrix4x4>.Dispose
	|-Stack.Enumerator<Object>.Dispose
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.Dispose
	|-Stack.Enumerator<Vector2>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22EB30 Offset: 0x22DF30 VA: 0x18022EB30
	|-Stack.Enumerator<Poolable>.MoveNext
	|-Stack.Enumerator<object>.MoveNext
	|-Stack.Enumerator<Object>.MoveNext
	|
	|-RVA: 0x22EC50 Offset: 0x22E050 VA: 0x18022EC50
	|-Stack.Enumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x22EA20 Offset: 0x22DE20 VA: 0x18022EA20
	|-Stack.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x22ED60 Offset: 0x22E160 VA: 0x18022ED60
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.MoveNext
	|
	|-RVA: 0x22E8E0 Offset: 0x22DCE0 VA: 0x18022E8E0
	|-Stack.Enumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x22ED70 Offset: 0x22E170 VA: 0x18022ED70
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.MoveNext
	|
	|-RVA: 0x22E8D0 Offset: 0x22DCD0 VA: 0x18022E8D0
	|-Stack.Enumerator<Vector2>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F970 Offset: 0x22ED70 VA: 0x18022F970
	|-Stack.Enumerator<Poolable>.get_Current
	|-Stack.Enumerator<Object>.get_Current
	|-Stack.Enumerator<object>.get_Current
	|
	|-RVA: 0x22F8E0 Offset: 0x22ECE0 VA: 0x18022F8E0
	|-Stack.Enumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x22F810 Offset: 0x22EC10 VA: 0x18022F810
	|-Stack.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x22F890 Offset: 0x22EC90 VA: 0x18022F890
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.get_Current
	|
	|-RVA: 0x22F7B0 Offset: 0x22EBB0 VA: 0x18022F7B0
	|-Stack.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x22F850 Offset: 0x22EC50 VA: 0x18022F850
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.get_Current
	|
	|-RVA: 0x22F920 Offset: 0x22ED20 VA: 0x18022F920
	|-Stack.Enumerator<Vector2>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F5F0 Offset: 0x22E9F0 VA: 0x18022F5F0
	|-Stack.Enumerator<KeyValuePair<int, int>>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F620 Offset: 0x22EA20 VA: 0x18022F620
	|-Stack.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F650 Offset: 0x22EA50 VA: 0x18022F650
	|-Stack.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F600 Offset: 0x22EA00 VA: 0x18022F600
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F640 Offset: 0x22EA40 VA: 0x18022F640
	|-Stack.Enumerator<Matrix4x4>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F610 Offset: 0x22EA10 VA: 0x18022F610
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F630 Offset: 0x22EA30 VA: 0x18022F630
	|-Stack.Enumerator<Vector2>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F2A0 Offset: 0x22E6A0 VA: 0x18022F2A0
	|-Stack.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F540 Offset: 0x22E940 VA: 0x18022F540
	|-Stack.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F4E0 Offset: 0x22E8E0 VA: 0x18022F4E0
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F120 Offset: 0x22E520 VA: 0x18022F120
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F350 Offset: 0x22E750 VA: 0x18022F350
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F1F0 Offset: 0x22E5F0 VA: 0x18022F1F0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F420 Offset: 0x22E820 VA: 0x18022F420
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22EE80 Offset: 0x22E280 VA: 0x18022EE80
	|-Stack.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22F020 Offset: 0x22E420 VA: 0x18022F020
	|-Stack.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22ED80 Offset: 0x22E180 VA: 0x18022ED80
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EF00 Offset: 0x22E300 VA: 0x18022EF00
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EF90 Offset: 0x22E390 VA: 0x18022EF90
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22F0A0 Offset: 0x22E4A0 VA: 0x18022F0A0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EE00 Offset: 0x22E200 VA: 0x18022EE00
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	*/

}

