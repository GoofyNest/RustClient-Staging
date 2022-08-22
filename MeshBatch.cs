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
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_NeedsRefresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	private void set_NeedsRefresh(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000
	private void set_Count(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_BatchedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	private void set_BatchedCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public int get_VertexCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
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

	// RVA: 0x95FF50 Offset: 0x95E550 VA: 0x18095FF50
	public int get_AvailableVertices() { }

	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40
	public void Alloc() { }

	// RVA: 0x95FE40 Offset: 0x95E440 VA: 0x18095FE40
	public void Free() { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30
	public void Refresh() { }

	// RVA: 0x95FDF0 Offset: 0x95E3F0 VA: 0x18095FDF0
	public void Apply() { }

	// RVA: 0x95FE10 Offset: 0x95E410 VA: 0x18095FE10
	public void Display() { }

	// RVA: 0x95FE60 Offset: 0x95E460 VA: 0x18095FE60
	public void Invalidate() { }

	// RVA: 0x95FDE0 Offset: 0x95E3E0 VA: 0x18095FDE0
	protected void AddVertices(int vertices) { }

	// RVA: 0x95FF20 Offset: 0x95E520 VA: 0x18095FF20
	protected void OnEnable() { }

	// RVA: 0x95FE90 Offset: 0x95E490 VA: 0x18095FE90
	protected void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

