public class RendererCell : Pool.IPooled // TypeDefIndex: 9917
{	// Fields
	public Vector3 position; // 0x10
	public RendererGrid grid; // 0x20
	public bool interrupt; // 0x28
	public bool isInPool; // 0x29
	public float Timestamp; // 0x2C
	private ListDictionary<RendererKey, RendererGroup> batches; // 0x30

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x94E640 Offset: 0x94CC40 VA: 0x18094E640
	public int get_Count() { }

	// RVA: 0x94DFD0 Offset: 0x94C5D0 VA: 0x18094DFD0
	public void Initialize(RendererGrid grid, Vector3 position) { }

	// RVA: 0x94E1B0 Offset: 0x94C7B0 VA: 0x18094E1B0
	public bool NeedsRefresh() { }

	// RVA: 0x94E090 Offset: 0x94C690 VA: 0x18094E090
	public int MeshCount() { }

	// RVA: 0x94DA90 Offset: 0x94C090 VA: 0x18094DA90
	public int BatchedMeshCount() { }

	// RVA: 0x94E4B0 Offset: 0x94CAB0 VA: 0x18094E4B0
	public int VertexCount() { }

	// RVA: 0x94E2D0 Offset: 0x94C8D0 VA: 0x18094E2D0
	public void Refresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xA7D10 Offset: 0xA7110 VA: 0x1800A7D10
	// RVA: 0x94E260 Offset: 0x94C860 VA: 0x18094E260
	public IEnumerator RefreshAsync() { }

	// RVA: 0x94DE10 Offset: 0x94C410 VA: 0x18094DE10
	public RendererGroup FindBatchGroup(RendererBatch renderer) { }

	// RVA: 0x94DBB0 Offset: 0x94C1B0 VA: 0x18094DBB0
	private RendererGroup CreateRendererGroup(RendererGrid grid, RendererCell cell, RendererKey key) { }

	// RVA: 0x94DC70 Offset: 0x94C270 VA: 0x18094DC70
	private void DestroyRendererGroup(ref RendererGroup grp) { }

	// RVA: 0x94DCD0 Offset: 0x94C2D0 VA: 0x18094DCD0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x94E010 Offset: 0x94C610 VA: 0x18094E010 Slot: 5
	public void LeavePool() { }

	// RVA: 0x94E5D0 Offset: 0x94CBD0 VA: 0x18094E5D0
	public void .ctor() { }

}

private sealed class RendererCell.<RefreshAsync>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9918
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RendererCell <>4__this; // 0x20
	private BufferList<RendererGroup> <batchGroups>5__2; // 0x28
	private int <i>5__3; // 0x30
	private IEnumerator <enumerator>5__4; // 0x38
	private RendererGroup <batchGroup>5__5; // 0x40
	private int <j>5__6; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x956380 Offset: 0x954980 VA: 0x180956380 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x956D60 Offset: 0x955360 VA: 0x180956D60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

