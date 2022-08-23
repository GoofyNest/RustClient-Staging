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
	|-RVA: 0x1FADD30 Offset: 0x1FAC330 VA: 0x181FADD30
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>..ctor
	|
	|-RVA: 0x1FADC60 Offset: 0x1FAC260 VA: 0x181FADC60
	|-ConcurrentQueue.Segment<object>..ctor
	*/

	internal int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EBE70 Offset: 0x9EA470 VA: 0x1809EBE70
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_Capacity
	|-ConcurrentQueue.Segment<object>.get_Capacity
	*/

	internal int get_FreezeOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FADE00 Offset: 0x1FAC400 VA: 0x181FADE00
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_FreezeOffset
	|-ConcurrentQueue.Segment<object>.get_FreezeOffset
	*/

	internal void EnsureFrozenForEnqueues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD290 Offset: 0x1FAB890 VA: 0x181FAD290
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.EnsureFrozenForEnqueues
	|-ConcurrentQueue.Segment<object>.EnsureFrozenForEnqueues
	*/

	public bool TryDequeue(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD500 Offset: 0x1FABB00 VA: 0x181FAD500
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryDequeue
	|
	|-RVA: 0x1FAD330 Offset: 0x1FAB930 VA: 0x181FAD330
	|-ConcurrentQueue.Segment<object>.TryDequeue
	*/

	public bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD980 Offset: 0x1FABF80 VA: 0x181FAD980
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryPeek
	|
	|-RVA: 0x1FADAF0 Offset: 0x1FAC0F0 VA: 0x181FADAF0
	|-ConcurrentQueue.Segment<object>.TryPeek
	*/

	public bool TryEnqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAD6F0 Offset: 0x1FABCF0 VA: 0x181FAD6F0
	|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryEnqueue
	|
	|-RVA: 0x1FAD840 Offset: 0x1FABE40 VA: 0x181FAD840
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
	|-RVA: 0x164FF30 Offset: 0x164E530 VA: 0x18164FF30
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
	|-RVA: 0x1FADE20 Offset: 0x1FAC420 VA: 0x181FADE20
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.MoveNext
	|
	|-RVA: 0x1FAE1E0 Offset: 0x1FAC7E0 VA: 0x181FAE1E0
	|-ConcurrentQueue.<Enumerate>d__27<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB11B00 Offset: 0xB10100 VA: 0x180B11B00
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FAE570 Offset: 0x1FACB70 VA: 0x181FAE570
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1FAE5C0 Offset: 0x1FACBC0 VA: 0x181FAE5C0
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650530 Offset: 0x164EB30 VA: 0x181650530
	|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.get_Current
	*/

}

