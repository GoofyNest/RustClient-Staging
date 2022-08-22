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

	// RVA: 0x74A880 Offset: 0x748E80 VA: 0x18074A880
	public void .ctor(FoliageGrid grid, Vector3 position) { }

	// RVA: 0x749DE0 Offset: 0x7483E0 VA: 0x180749DE0
	private void Init() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2670 Offset: 0xA1A70 VA: 0x1800A2670
	// RVA: 0x749D70 Offset: 0x748370 VA: 0x180749D70
	private IEnumerator InitAsync() { }

	// RVA: 0x74A260 Offset: 0x748860 VA: 0x18074A260
	public bool NeedsRefresh() { }

	// RVA: 0x74A130 Offset: 0x748730 VA: 0x18074A130
	public int MeshCount() { }

	// RVA: 0x749520 Offset: 0x747B20 VA: 0x180749520
	public int BatchedMeshCount() { }

	// RVA: 0x74A6F0 Offset: 0x748CF0 VA: 0x18074A6F0
	public int VertexCount() { }

	// RVA: 0x74A390 Offset: 0x748990 VA: 0x18074A390
	public void Refresh(bool force = False) { }

	[IteratorStateMachineAttribute] // RVA: 0xA2700 Offset: 0xA1B00 VA: 0x1800A2700
	// RVA: 0x74A320 Offset: 0x748920 VA: 0x18074A320
	public IEnumerator RefreshAsync() { }

	// RVA: 0x749650 Offset: 0x747C50 VA: 0x180749650
	private float CalculateLOD() { }

	// RVA: 0x749B00 Offset: 0x748100 VA: 0x180749B00
	public FoliageGroup FindBatchGroup(Material material) { }

	// RVA: 0x749920 Offset: 0x747F20 VA: 0x180749920
	private FoliageGroup CreateFoliageGroup(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	// RVA: 0x749AA0 Offset: 0x7480A0 VA: 0x180749AA0
	private void DestroyFoliageGroup(ref FoliageGroup grp) { }

	// RVA: 0x74A820 Offset: 0x748E20 VA: 0x18074A820
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

	// RVA: 0x762D10 Offset: 0x761310 VA: 0x180762D10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x762E60 Offset: 0x761460 VA: 0x180762E60 Slot: 8
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

	// RVA: 0x762EB0 Offset: 0x7614B0 VA: 0x180762EB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x763750 Offset: 0x761D50 VA: 0x180763750 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

