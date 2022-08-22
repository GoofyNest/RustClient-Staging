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

	// RVA: 0x74F250 Offset: 0x74D850 VA: 0x18074F250
	public float get_Size() { }

	// RVA: 0x74F220 Offset: 0x74D820 VA: 0x18074F220
	public Vector3 get_Position() { }

	// RVA: 0x74F1D0 Offset: 0x74D7D0 VA: 0x18074F1D0
	public int get_Count() { }

	// RVA: 0x74E9E0 Offset: 0x74CFE0 VA: 0x18074E9E0
	public void Initialize(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	// RVA: 0x74E8E0 Offset: 0x74CEE0 VA: 0x18074E8E0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x74DF00 Offset: 0x74C500 VA: 0x18074DF00
	public void Add(FoliageRenderer renderer) { }

	// RVA: 0x74EC60 Offset: 0x74D260 VA: 0x18074EC60
	public void Remove(FoliageRenderer renderer) { }

	// RVA: 0x74DF60 Offset: 0x74C560 VA: 0x18074DF60
	public void Add(FoliagePlacement placement) { }

	// RVA: 0x74EC00 Offset: 0x74D200 VA: 0x18074EC00
	public void Remove(FoliagePlacement placement) { }

	// RVA: 0x74DFC0 Offset: 0x74C5C0 VA: 0x18074DFC0
	public void Add(MeshInstance instance) { }

	// RVA: 0x74EDC0 Offset: 0x74D3C0 VA: 0x18074EDC0
	public void UpdateData() { }

	// RVA: 0x74E580 Offset: 0x74CB80 VA: 0x18074E580
	public void CreateBatches() { }

	// RVA: 0x74EB60 Offset: 0x74D160 VA: 0x18074EB60
	public void RefreshBatches() { }

	// RVA: 0x74E030 Offset: 0x74C630 VA: 0x18074E030
	public void ApplyBatches() { }

	// RVA: 0x74E730 Offset: 0x74CD30 VA: 0x18074E730
	public void DisplayBatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xA31D0 Offset: 0xA25D0 VA: 0x1800A31D0
	// RVA: 0x74ED50 Offset: 0x74D350 VA: 0x18074ED50
	public IEnumerator UpdateDataAsync() { }

	[IteratorStateMachineAttribute] // RVA: 0xA3370 Offset: 0xA2770 VA: 0x1800A3370
	// RVA: 0x74EAF0 Offset: 0x74D0F0 VA: 0x18074EAF0
	public IEnumerator RefreshBatchesAsync() { }

	// RVA: 0x74ECC0 Offset: 0x74D2C0 VA: 0x18074ECC0
	public void Start() { }

	// RVA: 0x74E7D0 Offset: 0x74CDD0 VA: 0x18074E7D0
	public void End() { }

	// RVA: 0x74E2C0 Offset: 0x74C8C0 VA: 0x18074E2C0
	public void Clear() { }

	// RVA: 0x74E180 Offset: 0x74C780 VA: 0x18074E180
	public void Cancel() { }

	// RVA: 0x74EA40 Offset: 0x74D040 VA: 0x18074EA40
	public int MeshCount() { }

	// RVA: 0x74E0D0 Offset: 0x74C6D0 VA: 0x18074E0D0
	public int BatchedMeshCount() { }

	// RVA: 0x74EFC0 Offset: 0x74D5C0 VA: 0x18074EFC0
	public int VertexCount() { }

	// RVA: 0x74E400 Offset: 0x74CA00 VA: 0x18074E400
	public FoliageGridBatch CreateBatch() { }

	// RVA: 0x74F070 Offset: 0x74D670 VA: 0x18074F070
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

	// RVA: 0x764700 Offset: 0x762D00 VA: 0x180764700 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x764850 Offset: 0x762E50 VA: 0x180764850 Slot: 8
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

	// RVA: 0x763690 Offset: 0x761C90 VA: 0x180763690 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7637E0 Offset: 0x761DE0 VA: 0x1807637E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

