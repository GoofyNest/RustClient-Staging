public class FoliageGridBatch : MeshBatch // TypeDefIndex: 11374
{	// Fields
	private Vector3 position; // 0x28
	private Mesh meshBatch; // 0x38
	private MeshFilter meshFilter; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private FoliageGridMeshData meshData; // 0x50
	private MeshGroup meshGroup; // 0x58

	// Properties
	public override int VertexCapacity { get; }
	public override int VertexCutoff { get; }

	// Methods

	// RVA: 0x74BDF0 Offset: 0x74A3F0 VA: 0x18074BDF0 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x74BE50 Offset: 0x74A450 VA: 0x18074BE50 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x74B870 Offset: 0x749E70 VA: 0x18074B870
	protected void Awake() { }

	// RVA: 0x74BB20 Offset: 0x74A120 VA: 0x18074BB20
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x74B440 Offset: 0x749A40 VA: 0x18074B440
	public void Add(MeshInstance instance) { }

	// RVA: 0x74B580 Offset: 0x749B80 VA: 0x18074B580 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x74B930 Offset: 0x749F30 VA: 0x18074B930 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x74BAA0 Offset: 0x74A0A0 VA: 0x18074BAA0 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x74B690 Offset: 0x749C90 VA: 0x18074B690 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x74BC90 Offset: 0x74A290 VA: 0x18074BC90 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x74B990 Offset: 0x749F90 VA: 0x18074B990 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

