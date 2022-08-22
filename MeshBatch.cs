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
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_NeedsRefresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	private void set_NeedsRefresh(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00
	private void set_Count(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_BatchedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	private void set_BatchedCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public int get_VertexCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
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

	// RVA: 0x95FA50 Offset: 0x95E050 VA: 0x18095FA50
	public int get_AvailableVertices() { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	public void Alloc() { }

	// RVA: 0x95F940 Offset: 0x95DF40 VA: 0x18095F940
	public void Free() { }

	// RVA: 0x95FA30 Offset: 0x95E030 VA: 0x18095FA30
	public void Refresh() { }

	// RVA: 0x95F8F0 Offset: 0x95DEF0 VA: 0x18095F8F0
	public void Apply() { }

	// RVA: 0x95F910 Offset: 0x95DF10 VA: 0x18095F910
	public void Display() { }

	// RVA: 0x95F960 Offset: 0x95DF60 VA: 0x18095F960
	public void Invalidate() { }

	// RVA: 0x95F8E0 Offset: 0x95DEE0 VA: 0x18095F8E0
	protected void AddVertices(int vertices) { }

	// RVA: 0x95FA20 Offset: 0x95E020 VA: 0x18095FA20
	protected void OnEnable() { }

	// RVA: 0x95F990 Offset: 0x95DF90 VA: 0x18095F990
	protected void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

