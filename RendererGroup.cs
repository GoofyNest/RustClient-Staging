public class RendererGroup : Pool.IPooled // TypeDefIndex: 9921
{	// Fields
	public bool Invalidated; // 0x10
	public bool NeedsRefresh; // 0x11
	public bool Processing; // 0x12
	public bool Preserving; // 0x13
	public ListHashSet<RendererBatch> Renderers; // 0x18
	public List<RendererBatch> TempRenderers; // 0x20
	public List<MeshRendererBatch> Batches; // 0x28
	public List<MeshRendererBatch> TempBatches; // 0x30
	public List<MeshRendererInstance> TempInstances; // 0x38
	private RendererGrid grid; // 0x40
	private RendererCell cell; // 0x48
	private RendererKey key; // 0x50
	private Action updateData; // 0x60
	private Action refreshBatches; // 0x68

	// Properties
	public float Size { get; }
	public Vector3 Position { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x950AC0 Offset: 0x94F0C0 VA: 0x180950AC0
	public float get_Size() { }

	// RVA: 0x950A90 Offset: 0x94F090 VA: 0x180950A90
	public Vector3 get_Position() { }

	// RVA: 0x950A40 Offset: 0x94F040 VA: 0x180950A40
	public int get_Count() { }

	// RVA: 0x950140 Offset: 0x94E740 VA: 0x180950140
	public void Initialize(RendererGrid grid, RendererCell cell, RendererKey key) { }

	// RVA: 0x950070 Offset: 0x94E670 VA: 0x180950070 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x94F490 Offset: 0x94DA90 VA: 0x18094F490
	public void Add(RendererBatch renderer) { }

	// RVA: 0x950470 Offset: 0x94EA70 VA: 0x180950470
	public void Remove(RendererBatch renderer) { }

	// RVA: 0x9501A0 Offset: 0x94E7A0 VA: 0x1809501A0
	public void Invalidate() { }

	// RVA: 0x94F4F0 Offset: 0x94DAF0 VA: 0x18094F4F0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x950600 Offset: 0x94EC00 VA: 0x180950600
	public void UpdateData() { }

	// RVA: 0x94FB10 Offset: 0x94E110 VA: 0x18094FB10
	public void CreateBatches() { }

	// RVA: 0x9503C0 Offset: 0x94E9C0 VA: 0x1809503C0
	public void RefreshBatches() { }

	// RVA: 0x94F5C0 Offset: 0x94DBC0 VA: 0x18094F5C0
	public void ApplyBatches() { }

	// RVA: 0x94FD70 Offset: 0x94E370 VA: 0x18094FD70
	public void DisplayBatches() { }

	// RVA: 0x950550 Offset: 0x94EB50 VA: 0x180950550
	public IEnumerator UpdateDataAsync() { }

	// RVA: 0x950310 Offset: 0x94E910 VA: 0x180950310
	public IEnumerator RefreshBatchesAsync() { }

	// RVA: 0x9504D0 Offset: 0x94EAD0 VA: 0x1809504D0
	public void Start() { }

	// RVA: 0x94FE20 Offset: 0x94E420 VA: 0x18094FE20
	public void End() { }

	// RVA: 0x94F860 Offset: 0x94DE60 VA: 0x18094F860
	public void Clear() { }

	// RVA: 0x94F720 Offset: 0x94DD20 VA: 0x18094F720
	public void Cancel() { }

	// RVA: 0x950260 Offset: 0x94E860 VA: 0x180950260
	public int MeshCount() { }

	// RVA: 0x94F670 Offset: 0x94DC70 VA: 0x18094F670
	public int BatchedMeshCount() { }

	// RVA: 0x950860 Offset: 0x94EE60 VA: 0x180950860
	public int VertexCount() { }

	// RVA: 0x94F9A0 Offset: 0x94DFA0 VA: 0x18094F9A0
	public MeshRendererBatch CreateBatch() { }

	// RVA: 0x950910 Offset: 0x94EF10 VA: 0x180950910
	public void .ctor() { }

}

