public abstract class MeshBatch : MonoBehaviour // TypeDefIndex: 11388
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <NeedsRefresh>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Count>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <BatchedCount>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <VertexCount>k__BackingField; // 0x24

	// Properties
	public bool NeedsRefresh { get; set; }
	public int Count { get; set; }
	public int BatchedCount { get; set; }
	public int VertexCount { get; set; }
	public abstract int VertexCapacity { get; }
	public abstract int VertexCutoff { get; }
	public int AvailableVertices { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_NeedsRefresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	private void set_NeedsRefresh(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0
	private void set_Count(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_BatchedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	private void set_BatchedCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public int get_VertexCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	private void set_VertexCount(int value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void AllocMemory();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void FreeMemory();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void RefreshMesh();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void ApplyMesh();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void ToggleMesh(bool state);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnPooled();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_VertexCapacity();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_VertexCutoff();

	// RVA: 0x95F940 Offset: 0x95DF40 VA: 0x18095F940
	public int get_AvailableVertices() { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	public void Alloc() { }

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830
	public void Free() { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920
	public void Refresh() { }

	// RVA: 0x95F7E0 Offset: 0x95DDE0 VA: 0x18095F7E0
	public void Apply() { }

	// RVA: 0x95F800 Offset: 0x95DE00 VA: 0x18095F800
	public void Display() { }

	// RVA: 0x95F850 Offset: 0x95DE50 VA: 0x18095F850
	public void Invalidate() { }

	// RVA: 0x95F7D0 Offset: 0x95DDD0 VA: 0x18095F7D0
	protected void AddVertices(int vertices) { }

	// RVA: 0x95F910 Offset: 0x95DF10 VA: 0x18095F910
	protected void OnEnable() { }

	// RVA: 0x95F880 Offset: 0x95DE80 VA: 0x18095F880
	protected void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

