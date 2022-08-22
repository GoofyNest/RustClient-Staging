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

	// RVA: 0x74F2B0 Offset: 0x74D8B0 VA: 0x18074F2B0
	public float get_Size() { }

	// RVA: 0x74F280 Offset: 0x74D880 VA: 0x18074F280
	public Vector3 get_Position() { }

	// RVA: 0x74F230 Offset: 0x74D830 VA: 0x18074F230
	public int get_Count() { }

	// RVA: 0x74EA40 Offset: 0x74D040 VA: 0x18074EA40
	public void Initialize(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	// RVA: 0x74E940 Offset: 0x74CF40 VA: 0x18074E940 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x74DF60 Offset: 0x74C560 VA: 0x18074DF60
	public void Add(FoliageRenderer renderer) { }

	// RVA: 0x74ECC0 Offset: 0x74D2C0 VA: 0x18074ECC0
	public void Remove(FoliageRenderer renderer) { }

	// RVA: 0x74DFC0 Offset: 0x74C5C0 VA: 0x18074DFC0
	public void Add(FoliagePlacement placement) { }

	// RVA: 0x74EC60 Offset: 0x74D260 VA: 0x18074EC60
	public void Remove(FoliagePlacement placement) { }

	// RVA: 0x74E020 Offset: 0x74C620 VA: 0x18074E020
	public void Add(MeshInstance instance) { }

	// RVA: 0x74EE20 Offset: 0x74D420 VA: 0x18074EE20
	public void UpdateData() { }

	// RVA: 0x74E5E0 Offset: 0x74CBE0 VA: 0x18074E5E0
	public void CreateBatches() { }

	// RVA: 0x74EBC0 Offset: 0x74D1C0 VA: 0x18074EBC0
	public void RefreshBatches() { }

	// RVA: 0x74E090 Offset: 0x74C690 VA: 0x18074E090
	public void ApplyBatches() { }

	// RVA: 0x74E790 Offset: 0x74CD90 VA: 0x18074E790
	public void DisplayBatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xA31D0 Offset: 0xA25D0 VA: 0x1800A31D0
	// RVA: 0x74EDB0 Offset: 0x74D3B0 VA: 0x18074EDB0
	public IEnumerator UpdateDataAsync() { }

	[IteratorStateMachineAttribute] // RVA: 0xA3370 Offset: 0xA2770 VA: 0x1800A3370
	// RVA: 0x74EB50 Offset: 0x74D150 VA: 0x18074EB50
	public IEnumerator RefreshBatchesAsync() { }

	// RVA: 0x74ED20 Offset: 0x74D320 VA: 0x18074ED20
	public void Start() { }

	// RVA: 0x74E830 Offset: 0x74CE30 VA: 0x18074E830
	public void End() { }

	// RVA: 0x74E320 Offset: 0x74C920 VA: 0x18074E320
	public void Clear() { }

	// RVA: 0x74E1E0 Offset: 0x74C7E0 VA: 0x18074E1E0
	public void Cancel() { }

	// RVA: 0x74EAA0 Offset: 0x74D0A0 VA: 0x18074EAA0
	public int MeshCount() { }

	// RVA: 0x74E130 Offset: 0x74C730 VA: 0x18074E130
	public int BatchedMeshCount() { }

	// RVA: 0x74F020 Offset: 0x74D620 VA: 0x18074F020
	public int VertexCount() { }

	// RVA: 0x74E460 Offset: 0x74CA60 VA: 0x18074E460
	public FoliageGridBatch CreateBatch() { }

	// RVA: 0x74F0D0 Offset: 0x74D6D0 VA: 0x18074F0D0
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

	// RVA: 0x764760 Offset: 0x762D60 VA: 0x180764760 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7648B0 Offset: 0x762EB0 VA: 0x1807648B0 Slot: 8
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

	// RVA: 0x7636F0 Offset: 0x761CF0 VA: 0x1807636F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x763840 Offset: 0x761E40 VA: 0x180763840 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

