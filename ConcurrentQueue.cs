private sealed class ConcurrentQueue.Segment<T> // TypeDefIndex: 1437
{	// Fields
	internal readonly ConcurrentQueue.Segment.Slot<T>[] _slots; // 0x0
	internal readonly int _slotsMask; // 0x0
	internal PaddedHeadAndTail _headAndTail; // 0x0
	internal bool _preservedForObservation; // 0x0
	internal bool _frozenForEnqueues; // 0x0
	internal ConcurrentQueue.Segment<T> _nextSegment; // 0x0

	// Properties
	internal int Capacity { get; }
	internal int FreezeOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int boundedLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FADCF0 Offset: 0x1FAC2F0 VA: 0x181FADCF0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>..ctor
	|
	|-RVA: 0x1FADC20 Offset: 0x1FAC220 VA: 0x181FADC20
	|-ConcurrentQueue.Segment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EBD30 Offset: 0x9EA330 VA: 0x1809EBD30
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_Capacity
	|-ConcurrentQueue.Segment<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	internal int get_FreezeOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FADDC0 Offset: 0x1FAC3C0 VA: 0x181FADDC0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_FreezeOffset
	|-ConcurrentQueue.Segment<object>.get_FreezeOffset
	*/

	// RVA: -1 Offset: -1
	internal void EnsureFrozenForEnqueues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD250 Offset: 0x1FAB850 VA: 0x181FAD250
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.EnsureFrozenForEnqueues
	|-ConcurrentQueue.Segment<object>.EnsureFrozenForEnqueues
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD4C0 Offset: 0x1FABAC0 VA: 0x181FAD4C0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryDequeue
	|
	|-RVA: 0x1FAD2F0 Offset: 0x1FAB8F0 VA: 0x181FAD2F0
	|-ConcurrentQueue.Segment<object>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD940 Offset: 0x1FABF40 VA: 0x181FAD940
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryPeek
	|
	|-RVA: 0x1FADAB0 Offset: 0x1FAC0B0 VA: 0x181FADAB0
	|-ConcurrentQueue.Segment<object>.TryPeek
	*/

	// RVA: -1 Offset: -1
	public bool TryEnqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD6B0 Offset: 0x1FABCB0 VA: 0x181FAD6B0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryEnqueue
	|
	|-RVA: 0x1FAD800 Offset: 0x1FABE00 VA: 0x181FAD800
	|-ConcurrentQueue.Segment<object>.TryEnqueue
	*/

}

internal struct ConcurrentQueue.Segment.Slot<T> // TypeDefIndex: 1438
{	// Fields
	public T Item; // 0x0
	public int SequenceNumber; // 0x0

}

private sealed class ConcurrentQueue.<Enumerate>d__27<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1439
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ConcurrentQueue.Segment<T> head; // 0x0
	public ConcurrentQueue.Segment<T> tail; // 0x0
	public int tailTail; // 0x0
	public int headHead; // 0x0
	public ConcurrentQueue<T> <>4__this; // 0x0
	private int <i>5__1; // 0x0
	private int <headTail>5__2; // 0x0
	private int <i>5__3; // 0x0
	private int <i>5__4; // 0x0
	private ConcurrentQueue.Segment<T> <s>5__5; // 0x0
	private int <i>5__6; // 0x0
	private int <sTail>5__7; // 0x0
	private int <i>5__8; // 0x0

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
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>..ctor
	|-ConcurrentQueue.<Enumerate>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FADDE0 Offset: 0x1FAC3E0 VA: 0x181FADDE0
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.MoveNext
	|
	|-RVA: 0x1FAE1A0 Offset: 0x1FAC7A0 VA: 0x181FAE1A0
	|-ConcurrentQueue.<Enumerate>d__27<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAE530 Offset: 0x1FACB30 VA: 0x181FAE530
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1FAE580 Offset: 0x1FACB80 VA: 0x181FAE580
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16504F0 Offset: 0x164EAF0 VA: 0x1816504F0
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.get_Current
	*/

}

