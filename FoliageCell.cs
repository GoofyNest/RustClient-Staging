public class FoliageCell // TypeDefIndex: 9868
{	// Fields
	private static readonly ListHashSet<FoliagePlacement> EmptyPlacements; // 0x0
	public Vector3 position; // 0x10
	public FoliageGrid grid; // 0x20
	public bool interrupt; // 0x28
	public float lod; // 0x2C
	public uint seed; // 0x30
	private ListHashSet<FoliagePlacement> placements; // 0x38
	private ListDictionary<FoliageKey, FoliageGroup> batches; // 0x40
	private Action initAsyncAction; // 0x48

	// Methods

	// RVA: 0x74A770 Offset: 0x748D70 VA: 0x18074A770
	public void .ctor(FoliageGrid grid, Vector3 position) { }

	// RVA: 0x749CD0 Offset: 0x7482D0 VA: 0x180749CD0
	private void Init() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2670 Offset: 0xA1A70 VA: 0x1800A2670
	// RVA: 0x749C60 Offset: 0x748260 VA: 0x180749C60
	private IEnumerator InitAsync() { }

	// RVA: 0x74A150 Offset: 0x748750 VA: 0x18074A150
	public bool NeedsRefresh() { }

	// RVA: 0x74A020 Offset: 0x748620 VA: 0x18074A020
	public int MeshCount() { }

	// RVA: 0x749410 Offset: 0x747A10 VA: 0x180749410
	public int BatchedMeshCount() { }

	// RVA: 0x74A5E0 Offset: 0x748BE0 VA: 0x18074A5E0
	public int VertexCount() { }

	// RVA: 0x74A280 Offset: 0x748880 VA: 0x18074A280
	public void Refresh(bool force = False) { }

	[IteratorStateMachineAttribute] // RVA: 0xA2700 Offset: 0xA1B00 VA: 0x1800A2700
	// RVA: 0x74A210 Offset: 0x748810 VA: 0x18074A210
	public IEnumerator RefreshAsync() { }

	// RVA: 0x749540 Offset: 0x747B40 VA: 0x180749540
	private float CalculateLOD() { }

	// RVA: 0x7499F0 Offset: 0x747FF0 VA: 0x1807499F0
	public FoliageGroup FindBatchGroup(Material material) { }

	// RVA: 0x749810 Offset: 0x747E10 VA: 0x180749810
	private FoliageGroup CreateFoliageGroup(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	// RVA: 0x749990 Offset: 0x747F90 VA: 0x180749990
	private void DestroyFoliageGroup(ref FoliageGroup grp) { }

	// RVA: 0x74A710 Offset: 0x748D10 VA: 0x18074A710
	private static void .cctor() { }

}

private sealed class FoliageCell.<InitAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9869
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageCell <>4__this; // 0x20
	private IEnumerator <enumerator>5__2; // 0x28

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

	// RVA: 0x762C00 Offset: 0x761200 VA: 0x180762C00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x762D50 Offset: 0x761350 VA: 0x180762D50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FoliageCell.<RefreshAsync>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9870
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageCell <>4__this; // 0x20
	private BufferList<FoliageGroup> <batchGroups>5__2; // 0x28
	private IEnumerator <enumerator>5__3; // 0x30
	private int <i>5__4; // 0x38
	private FoliageGroup <batchGroup>5__5; // 0x40
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

	// RVA: 0x762DA0 Offset: 0x7613A0 VA: 0x180762DA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x763640 Offset: 0x761C40 VA: 0x180763640 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

