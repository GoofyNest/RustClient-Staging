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

	// RVA: 0x950BD0 Offset: 0x94F1D0 VA: 0x180950BD0
	public float get_Size() { }

	// RVA: 0x950BA0 Offset: 0x94F1A0 VA: 0x180950BA0
	public Vector3 get_Position() { }

	// RVA: 0x950B50 Offset: 0x94F150 VA: 0x180950B50
	public int get_Count() { }

	// RVA: 0x950250 Offset: 0x94E850 VA: 0x180950250
	public void Initialize(RendererGrid grid, RendererCell cell, RendererKey key) { }

	// RVA: 0x950180 Offset: 0x94E780 VA: 0x180950180 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x94F5A0 Offset: 0x94DBA0 VA: 0x18094F5A0
	public void Add(RendererBatch renderer) { }

	// RVA: 0x950580 Offset: 0x94EB80 VA: 0x180950580
	public void Remove(RendererBatch renderer) { }

	// RVA: 0x9502B0 Offset: 0x94E8B0 VA: 0x1809502B0
	public void Invalidate() { }

	// RVA: 0x94F600 Offset: 0x94DC00 VA: 0x18094F600
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x950710 Offset: 0x94ED10 VA: 0x180950710
	public void UpdateData() { }

	// RVA: 0x94FC20 Offset: 0x94E220 VA: 0x18094FC20
	public void CreateBatches() { }

	// RVA: 0x9504D0 Offset: 0x94EAD0 VA: 0x1809504D0
	public void RefreshBatches() { }

	// RVA: 0x94F6D0 Offset: 0x94DCD0 VA: 0x18094F6D0
	public void ApplyBatches() { }

	// RVA: 0x94FE80 Offset: 0x94E480 VA: 0x18094FE80
	public void DisplayBatches() { }

	// RVA: 0x950660 Offset: 0x94EC60 VA: 0x180950660
	public IEnumerator UpdateDataAsync() { }

	// RVA: 0x950420 Offset: 0x94EA20 VA: 0x180950420
	public IEnumerator RefreshBatchesAsync() { }

	// RVA: 0x9505E0 Offset: 0x94EBE0 VA: 0x1809505E0
	public void Start() { }

	// RVA: 0x94FF30 Offset: 0x94E530 VA: 0x18094FF30
	public void End() { }

	// RVA: 0x94F970 Offset: 0x94DF70 VA: 0x18094F970
	public void Clear() { }

	// RVA: 0x94F830 Offset: 0x94DE30 VA: 0x18094F830
	public void Cancel() { }

	// RVA: 0x950370 Offset: 0x94E970 VA: 0x180950370
	public int MeshCount() { }

	// RVA: 0x94F780 Offset: 0x94DD80 VA: 0x18094F780
	public int BatchedMeshCount() { }

	// RVA: 0x950970 Offset: 0x94EF70 VA: 0x180950970
	public int VertexCount() { }

	// RVA: 0x94FAB0 Offset: 0x94E0B0 VA: 0x18094FAB0
	public MeshRendererBatch CreateBatch() { }

	// RVA: 0x950A20 Offset: 0x94F020 VA: 0x180950A20
	public void .ctor() { }

}

