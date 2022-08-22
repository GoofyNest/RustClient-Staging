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

	// RVA: 0x9510E0 Offset: 0x94F6E0 VA: 0x1809510E0
	public float get_Size() { }

	// RVA: 0x9510B0 Offset: 0x94F6B0 VA: 0x1809510B0
	public Vector3 get_Position() { }

	// RVA: 0x951060 Offset: 0x94F660 VA: 0x180951060
	public int get_Count() { }

	// RVA: 0x950760 Offset: 0x94ED60 VA: 0x180950760
	public void Initialize(RendererGrid grid, RendererCell cell, RendererKey key) { }

	// RVA: 0x950690 Offset: 0x94EC90 VA: 0x180950690 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x94FAB0 Offset: 0x94E0B0 VA: 0x18094FAB0
	public void Add(RendererBatch renderer) { }

	// RVA: 0x950A90 Offset: 0x94F090 VA: 0x180950A90
	public void Remove(RendererBatch renderer) { }

	// RVA: 0x9507C0 Offset: 0x94EDC0 VA: 0x1809507C0
	public void Invalidate() { }

	// RVA: 0x94FB10 Offset: 0x94E110 VA: 0x18094FB10
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x950C20 Offset: 0x94F220 VA: 0x180950C20
	public void UpdateData() { }

	// RVA: 0x950130 Offset: 0x94E730 VA: 0x180950130
	public void CreateBatches() { }

	// RVA: 0x9509E0 Offset: 0x94EFE0 VA: 0x1809509E0
	public void RefreshBatches() { }

	// RVA: 0x94FBE0 Offset: 0x94E1E0 VA: 0x18094FBE0
	public void ApplyBatches() { }

	// RVA: 0x950390 Offset: 0x94E990 VA: 0x180950390
	public void DisplayBatches() { }

	// RVA: 0x950B70 Offset: 0x94F170 VA: 0x180950B70
	public IEnumerator UpdateDataAsync() { }

	// RVA: 0x950930 Offset: 0x94EF30 VA: 0x180950930
	public IEnumerator RefreshBatchesAsync() { }

	// RVA: 0x950AF0 Offset: 0x94F0F0 VA: 0x180950AF0
	public void Start() { }

	// RVA: 0x950440 Offset: 0x94EA40 VA: 0x180950440
	public void End() { }

	// RVA: 0x94FE80 Offset: 0x94E480 VA: 0x18094FE80
	public void Clear() { }

	// RVA: 0x94FD40 Offset: 0x94E340 VA: 0x18094FD40
	public void Cancel() { }

	// RVA: 0x950880 Offset: 0x94EE80 VA: 0x180950880
	public int MeshCount() { }

	// RVA: 0x94FC90 Offset: 0x94E290 VA: 0x18094FC90
	public int BatchedMeshCount() { }

	// RVA: 0x950E80 Offset: 0x94F480 VA: 0x180950E80
	public int VertexCount() { }

	// RVA: 0x94FFC0 Offset: 0x94E5C0 VA: 0x18094FFC0
	public MeshRendererBatch CreateBatch() { }

	// RVA: 0x950F30 Offset: 0x94F530 VA: 0x180950F30
	public void .ctor() { }

}

