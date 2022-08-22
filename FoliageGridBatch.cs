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

	// RVA: 0x74BF00 Offset: 0x74A500 VA: 0x18074BF00 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x74BF60 Offset: 0x74A560 VA: 0x18074BF60 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x74B980 Offset: 0x749F80 VA: 0x18074B980
	protected void Awake() { }

	// RVA: 0x74BC30 Offset: 0x74A230 VA: 0x18074BC30
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x74B550 Offset: 0x749B50 VA: 0x18074B550
	public void Add(MeshInstance instance) { }

	// RVA: 0x74B690 Offset: 0x749C90 VA: 0x18074B690 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x74BA40 Offset: 0x74A040 VA: 0x18074BA40 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x74BBB0 Offset: 0x74A1B0 VA: 0x18074BBB0 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x74B7A0 Offset: 0x749DA0 VA: 0x18074B7A0 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x74BDA0 Offset: 0x74A3A0 VA: 0x18074BDA0 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x74BAA0 Offset: 0x74A0A0 VA: 0x18074BAA0 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

