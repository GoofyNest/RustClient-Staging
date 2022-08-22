public class FoliageGroup : Pool.IPooled // TypeDefIndex: 9873
{	// Fields
	public float LOD; // 0x10
	public bool NeedsRefresh; // 0x14
	public bool Processing; // 0x15
	public bool Preserving; // 0x16
	public ListHashSet<FoliagePlacement> Placements; // 0x18
	public ListHashSet<FoliageRenderer> Renderers; // 0x20
	public List<FoliageRenderer> TempRenderers; // 0x28
	public List<FoliageGridBatch> Batches; // 0x30
	public List<FoliageGridBatch> TempBatches; // 0x38
	public List<MeshInstance> TempInstances; // 0x40
	private FoliageGrid grid; // 0x48
	private FoliageCell cell; // 0x50
	private FoliageKey key; // 0x58
	private Action updateData; // 0x60
	private Action refreshBatches; // 0x68

	// Properties
	public float Size { get; }
	public Vector3 Position { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x74F360 Offset: 0x74D960 VA: 0x18074F360
	public float get_Size() { }

	// RVA: 0x74F330 Offset: 0x74D930 VA: 0x18074F330
	public Vector3 get_Position() { }

	// RVA: 0x74F2E0 Offset: 0x74D8E0 VA: 0x18074F2E0
	public int get_Count() { }

	// RVA: 0x74EAF0 Offset: 0x74D0F0 VA: 0x18074EAF0
	public void Initialize(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	// RVA: 0x74E9F0 Offset: 0x74CFF0 VA: 0x18074E9F0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x74E010 Offset: 0x74C610 VA: 0x18074E010
	public void Add(FoliageRenderer renderer) { }

	// RVA: 0x74ED70 Offset: 0x74D370 VA: 0x18074ED70
	public void Remove(FoliageRenderer renderer) { }

	// RVA: 0x74E070 Offset: 0x74C670 VA: 0x18074E070
	public void Add(FoliagePlacement placement) { }

	// RVA: 0x74ED10 Offset: 0x74D310 VA: 0x18074ED10
	public void Remove(FoliagePlacement placement) { }

	// RVA: 0x74E0D0 Offset: 0x74C6D0 VA: 0x18074E0D0
	public void Add(MeshInstance instance) { }

	// RVA: 0x74EED0 Offset: 0x74D4D0 VA: 0x18074EED0
	public void UpdateData() { }

	// RVA: 0x74E690 Offset: 0x74CC90 VA: 0x18074E690
	public void CreateBatches() { }

	// RVA: 0x74EC70 Offset: 0x74D270 VA: 0x18074EC70
	public void RefreshBatches() { }

	// RVA: 0x74E140 Offset: 0x74C740 VA: 0x18074E140
	public void ApplyBatches() { }

	// RVA: 0x74E840 Offset: 0x74CE40 VA: 0x18074E840
	public void DisplayBatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xA31D0 Offset: 0xA25D0 VA: 0x1800A31D0
	// RVA: 0x74EE60 Offset: 0x74D460 VA: 0x18074EE60
	public IEnumerator UpdateDataAsync() { }

	[IteratorStateMachineAttribute] // RVA: 0xA3370 Offset: 0xA2770 VA: 0x1800A3370
	// RVA: 0x74EC00 Offset: 0x74D200 VA: 0x18074EC00
	public IEnumerator RefreshBatchesAsync() { }

	// RVA: 0x74EDD0 Offset: 0x74D3D0 VA: 0x18074EDD0
	public void Start() { }

	// RVA: 0x74E8E0 Offset: 0x74CEE0 VA: 0x18074E8E0
	public void End() { }

	// RVA: 0x74E3D0 Offset: 0x74C9D0 VA: 0x18074E3D0
	public void Clear() { }

	// RVA: 0x74E290 Offset: 0x74C890 VA: 0x18074E290
	public void Cancel() { }

	// RVA: 0x74EB50 Offset: 0x74D150 VA: 0x18074EB50
	public int MeshCount() { }

	// RVA: 0x74E1E0 Offset: 0x74C7E0 VA: 0x18074E1E0
	public int BatchedMeshCount() { }

	// RVA: 0x74F0D0 Offset: 0x74D6D0 VA: 0x18074F0D0
	public int VertexCount() { }

	// RVA: 0x74E510 Offset: 0x74CB10 VA: 0x18074E510
	public FoliageGridBatch CreateBatch() { }

	// RVA: 0x74F180 Offset: 0x74D780 VA: 0x18074F180
	public void .ctor() { }

}

private sealed class FoliageGroup.<UpdateDataAsync>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9874
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGroup <>4__this; // 0x20
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

	// RVA: 0x764810 Offset: 0x762E10 VA: 0x180764810 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x764960 Offset: 0x762F60 VA: 0x180764960 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FoliageGroup.<RefreshBatchesAsync>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9875
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGroup <>4__this; // 0x20
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

	// RVA: 0x7637A0 Offset: 0x761DA0 VA: 0x1807637A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7638F0 Offset: 0x761EF0 VA: 0x1807638F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

