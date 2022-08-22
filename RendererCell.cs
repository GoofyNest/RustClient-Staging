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

	// RVA: 0x94E750 Offset: 0x94CD50 VA: 0x18094E750
	public int get_Count() { }

	// RVA: 0x94E0E0 Offset: 0x94C6E0 VA: 0x18094E0E0
	public void Initialize(RendererGrid grid, Vector3 position) { }

	// RVA: 0x94E2C0 Offset: 0x94C8C0 VA: 0x18094E2C0
	public bool NeedsRefresh() { }

	// RVA: 0x94E1A0 Offset: 0x94C7A0 VA: 0x18094E1A0
	public int MeshCount() { }

	// RVA: 0x94DBA0 Offset: 0x94C1A0 VA: 0x18094DBA0
	public int BatchedMeshCount() { }

	// RVA: 0x94E5C0 Offset: 0x94CBC0 VA: 0x18094E5C0
	public int VertexCount() { }

	// RVA: 0x94E3E0 Offset: 0x94C9E0 VA: 0x18094E3E0
	public void Refresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xA7E00 Offset: 0xA7200 VA: 0x1800A7E00
	// RVA: 0x94E370 Offset: 0x94C970 VA: 0x18094E370
	public IEnumerator RefreshAsync() { }

	// RVA: 0x94DF20 Offset: 0x94C520 VA: 0x18094DF20
	public RendererGroup FindBatchGroup(RendererBatch renderer) { }

	// RVA: 0x94DCC0 Offset: 0x94C2C0 VA: 0x18094DCC0
	private RendererGroup CreateRendererGroup(RendererGrid grid, RendererCell cell, RendererKey key) { }

	// RVA: 0x94DD80 Offset: 0x94C380 VA: 0x18094DD80
	private void DestroyRendererGroup(ref RendererGroup grp) { }

	// RVA: 0x94DDE0 Offset: 0x94C3E0 VA: 0x18094DDE0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x94E120 Offset: 0x94C720 VA: 0x18094E120 Slot: 5
	public void LeavePool() { }

	// RVA: 0x94E6E0 Offset: 0x94CCE0 VA: 0x18094E6E0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x956490 Offset: 0x954A90 VA: 0x180956490 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x956E70 Offset: 0x955470 VA: 0x180956E70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

