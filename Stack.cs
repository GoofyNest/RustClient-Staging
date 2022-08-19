public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1423
{
// Namespace: System.Collections
[DebuggerDisplayAttribute] // RVA: 0xEA180 Offset: 0xE9580 VA: 0x1800EA180
[DebuggerTypeProxyAttribute] // RVA: 0xEA180 Offset: 0xE9580 VA: 0x1800EA180
[ComVisibleAttribute] // RVA: 0xEA180 Offset: 0xE9580 VA: 0x1800EA180
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

	// RVA: 0x146B3F0 Offset: 0x14699F0 VA: 0x18146B3F0
	public void .ctor() { }

	// RVA: 0x146B450 Offset: 0x1469A50 VA: 0x18146B450
	public void .ctor(int initialCapacity) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x146B510 Offset: 0x1469B10 VA: 0x18146B510 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x146ACA0 Offset: 0x14692A0 VA: 0x18146ACA0 Slot: 11
	public virtual void Clear() { }

	// RVA: 0x146ACD0 Offset: 0x14692D0 VA: 0x18146ACD0 Slot: 12
	public virtual object Clone() { }

	// RVA: 0x146ADF0 Offset: 0x14693F0 VA: 0x18146ADF0 Slot: 13
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x146B0B0 Offset: 0x14696B0 VA: 0x18146B0B0 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x146B150 Offset: 0x1469750 VA: 0x18146B150 Slot: 15
	public virtual object Peek() { }

	// RVA: 0x146B200 Offset: 0x1469800 VA: 0x18146B200 Slot: 16
	public virtual object Pop() { }

	// RVA: 0x146B2D0 Offset: 0x14698D0 VA: 0x18146B2D0 Slot: 17
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

	// RVA: 0x146AB60 Offset: 0x1469160 VA: 0x18146AB60
	internal void .ctor(Stack stack) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 7
	public object Clone() { }

	// RVA: 0x146A970 Offset: 0x1468F70 VA: 0x18146A970 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x146ABD0 Offset: 0x14691D0 VA: 0x18146ABD0 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x146AAC0 Offset: 0x14690C0 VA: 0x18146AAC0 Slot: 10
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
	|-RVA: 0x22F6E0 Offset: 0x22EAE0 VA: 0x18022F6E0
	|-Stack.Enumerator<KeyValuePair<int, int>>..ctor
	|-Stack.Enumerator<IntPtr>..ctor
	|-Stack.Enumerator<object>..ctor
	|-Stack.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x22F7E0 Offset: 0x22EBE0 VA: 0x18022F7E0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x22F780 Offset: 0x22EB80 VA: 0x18022F780
	|-Stack.Enumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x22F730 Offset: 0x22EB30 VA: 0x18022F730
	|-Stack.Enumerator<EventDispatcher.DispatchContext>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22E940 Offset: 0x22DD40 VA: 0x18022E940
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
	|-RVA: 0x22EBB0 Offset: 0x22DFB0 VA: 0x18022EBB0
	|-Stack.Enumerator<Poolable>.MoveNext
	|-Stack.Enumerator<object>.MoveNext
	|-Stack.Enumerator<Object>.MoveNext
	|
	|-RVA: 0x22ECD0 Offset: 0x22E0D0 VA: 0x18022ECD0
	|-Stack.Enumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x22EAA0 Offset: 0x22DEA0 VA: 0x18022EAA0
	|-Stack.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x22EDE0 Offset: 0x22E1E0 VA: 0x18022EDE0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.MoveNext
	|
	|-RVA: 0x22E960 Offset: 0x22DD60 VA: 0x18022E960
	|-Stack.Enumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x22EDF0 Offset: 0x22E1F0 VA: 0x18022EDF0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.MoveNext
	|
	|-RVA: 0x22E950 Offset: 0x22DD50 VA: 0x18022E950
	|-Stack.Enumerator<Vector2>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F9F0 Offset: 0x22EDF0 VA: 0x18022F9F0
	|-Stack.Enumerator<Poolable>.get_Current
	|-Stack.Enumerator<Object>.get_Current
	|-Stack.Enumerator<object>.get_Current
	|
	|-RVA: 0x22F960 Offset: 0x22ED60 VA: 0x18022F960
	|-Stack.Enumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x22F890 Offset: 0x22EC90 VA: 0x18022F890
	|-Stack.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x22F910 Offset: 0x22ED10 VA: 0x18022F910
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.get_Current
	|
	|-RVA: 0x22F830 Offset: 0x22EC30 VA: 0x18022F830
	|-Stack.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x22F8D0 Offset: 0x22ECD0 VA: 0x18022F8D0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.get_Current
	|
	|-RVA: 0x22F9A0 Offset: 0x22EDA0 VA: 0x18022F9A0
	|-Stack.Enumerator<Vector2>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F670 Offset: 0x22EA70 VA: 0x18022F670
	|-Stack.Enumerator<KeyValuePair<int, int>>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F6A0 Offset: 0x22EAA0 VA: 0x18022F6A0
	|-Stack.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F6D0 Offset: 0x22EAD0 VA: 0x18022F6D0
	|-Stack.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F680 Offset: 0x22EA80 VA: 0x18022F680
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F6C0 Offset: 0x22EAC0 VA: 0x18022F6C0
	|-Stack.Enumerator<Matrix4x4>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F690 Offset: 0x22EA90 VA: 0x18022F690
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F6B0 Offset: 0x22EAB0 VA: 0x18022F6B0
	|-Stack.Enumerator<Vector2>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F320 Offset: 0x22E720 VA: 0x18022F320
	|-Stack.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F5C0 Offset: 0x22E9C0 VA: 0x18022F5C0
	|-Stack.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F560 Offset: 0x22E960 VA: 0x18022F560
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F1A0 Offset: 0x22E5A0 VA: 0x18022F1A0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F3D0 Offset: 0x22E7D0 VA: 0x18022F3D0
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F270 Offset: 0x22E670 VA: 0x18022F270
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F4A0 Offset: 0x22E8A0 VA: 0x18022F4A0
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22EF00 Offset: 0x22E300 VA: 0x18022EF00
	|-Stack.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22F0A0 Offset: 0x22E4A0 VA: 0x18022F0A0
	|-Stack.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EE00 Offset: 0x22E200 VA: 0x18022EE00
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EF80 Offset: 0x22E380 VA: 0x18022EF80
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22F010 Offset: 0x22E410 VA: 0x18022F010
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22F120 Offset: 0x22E520 VA: 0x18022F120
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EE80 Offset: 0x22E280 VA: 0x18022EE80
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	*/

}

