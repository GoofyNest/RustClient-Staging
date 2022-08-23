private sealed class ConcurrentQueue.Segment<T> // TypeDefIndex: 1437
{	internal readonly ConcurrentQueue.Segment.Slot<T>[] _slots; // 0x0
	internal readonly int _slotsMask; // 0x0
	internal PaddedHeadAndTail _headAndTail; // 0x0
	internal bool _preservedForObservation; // 0x0
	internal bool _frozenForEnqueues; // 0x0
	internal ConcurrentQueue.Segment<T> _nextSegment; // 0x0

	internal int Capacity { get; }
	internal int FreezeOffset { get; }


	public void .ctor(int boundedLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FADDF0 Offset: 0x1FAC3F0 VA: 0x181FADDF0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>..ctor
	|
	|-RVA: 0x1FADD20 Offset: 0x1FAC320 VA: 0x181FADD20
	|-ConcurrentQueue.Segment<object>..ctor
	*/

	internal int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EBE30 Offset: 0x9EA430 VA: 0x1809EBE30
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_Capacity
	|-ConcurrentQueue.Segment<object>.get_Capacity
	*/

	internal int get_FreezeOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FADEC0 Offset: 0x1FAC4C0 VA: 0x181FADEC0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_FreezeOffset
	|-ConcurrentQueue.Segment<object>.get_FreezeOffset
	*/

	internal void EnsureFrozenForEnqueues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD350 Offset: 0x1FAB950 VA: 0x181FAD350
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.EnsureFrozenForEnqueues
	|-ConcurrentQueue.Segment<object>.EnsureFrozenForEnqueues
	*/

	public bool TryDequeue(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD5C0 Offset: 0x1FABBC0 VA: 0x181FAD5C0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryDequeue
	|
	|-RVA: 0x1FAD3F0 Offset: 0x1FAB9F0 VA: 0x181FAD3F0
	|-ConcurrentQueue.Segment<object>.TryDequeue
	*/

	public bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FADA40 Offset: 0x1FAC040 VA: 0x181FADA40
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryPeek
	|
	|-RVA: 0x1FADBB0 Offset: 0x1FAC1B0 VA: 0x181FADBB0
	|-ConcurrentQueue.Segment<object>.TryPeek
	*/

	public bool TryEnqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD7B0 Offset: 0x1FABDB0 VA: 0x181FAD7B0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryEnqueue
	|
	|-RVA: 0x1FAD900 Offset: 0x1FABF00 VA: 0x181FAD900
	|-ConcurrentQueue.Segment<object>.TryEnqueue
	*/

}

internal struct ConcurrentQueue.Segment.Slot<T> // TypeDefIndex: 1438
{	public T Item; // 0x0
	public int SequenceNumber; // 0x0

}

private sealed class ConcurrentQueue.<Enumerate>d__27<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1439
{	private int <>1__state; // 0x0
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

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FFF0 Offset: 0x164E5F0 VA: 0x18164FFF0
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>..ctor
	|-ConcurrentQueue.<Enumerate>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FADEE0 Offset: 0x1FAC4E0 VA: 0x181FADEE0
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.MoveNext
	|
	|-RVA: 0x1FAE2A0 Offset: 0x1FAC8A0 VA: 0x181FAE2A0
	|-ConcurrentQueue.<Enumerate>d__27<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB11AC0 Offset: 0xB100C0 VA: 0x180B11AC0
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAE630 Offset: 0x1FACC30 VA: 0x181FAE630
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1FAE680 Offset: 0x1FACC80 VA: 0x181FAE680
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16505F0 Offset: 0x164EBF0 VA: 0x1816505F0
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.get_Current
	*/

}

