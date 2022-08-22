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
	|-RVA: 0x1FAD210 Offset: 0x1FAB810 VA: 0x181FAD210
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>..ctor
	|
	|-RVA: 0x1FAD140 Offset: 0x1FAB740 VA: 0x181FAD140
	|-ConcurrentQueue.Segment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EB580 Offset: 0x9E9B80 VA: 0x1809EB580
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_Capacity
	|-ConcurrentQueue.Segment<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	internal int get_FreezeOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD2E0 Offset: 0x1FAB8E0 VA: 0x181FAD2E0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_FreezeOffset
	|-ConcurrentQueue.Segment<object>.get_FreezeOffset
	*/

	// RVA: -1 Offset: -1
	internal void EnsureFrozenForEnqueues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAC770 Offset: 0x1FAAD70 VA: 0x181FAC770
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.EnsureFrozenForEnqueues
	|-ConcurrentQueue.Segment<object>.EnsureFrozenForEnqueues
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAC9E0 Offset: 0x1FAAFE0 VA: 0x181FAC9E0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryDequeue
	|
	|-RVA: 0x1FAC810 Offset: 0x1FAAE10 VA: 0x181FAC810
	|-ConcurrentQueue.Segment<object>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FACE60 Offset: 0x1FAB460 VA: 0x181FACE60
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryPeek
	|
	|-RVA: 0x1FACFD0 Offset: 0x1FAB5D0 VA: 0x181FACFD0
	|-ConcurrentQueue.Segment<object>.TryPeek
	*/

	// RVA: -1 Offset: -1
	public bool TryEnqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FACBD0 Offset: 0x1FAB1D0 VA: 0x181FACBD0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryEnqueue
	|
	|-RVA: 0x1FACD20 Offset: 0x1FAB320 VA: 0x181FACD20
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
	|-RVA: 0x15E8E80 Offset: 0x15E7480 VA: 0x1815E8E80
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
	|-RVA: 0x1FAD300 Offset: 0x1FAB900 VA: 0x181FAD300
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.MoveNext
	|
	|-RVA: 0x1FAD6C0 Offset: 0x1FABCC0 VA: 0x181FAD6C0
	|-ConcurrentQueue.<Enumerate>d__27<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB11230 Offset: 0xB0F830 VA: 0x180B11230
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
	|-RVA: 0x1FADA50 Offset: 0x1FAC050 VA: 0x181FADA50
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1FADAA0 Offset: 0x1FAC0A0 VA: 0x181FADAA0
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FC390 Offset: 0x17FA990 VA: 0x1817FC390
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.get_Current
	*/

}

