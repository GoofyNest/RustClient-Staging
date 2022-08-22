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

	// RVA: 0x74BE50 Offset: 0x74A450 VA: 0x18074BE50 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x74BEB0 Offset: 0x74A4B0 VA: 0x18074BEB0 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x74B8D0 Offset: 0x749ED0 VA: 0x18074B8D0
	protected void Awake() { }

	// RVA: 0x74BB80 Offset: 0x74A180 VA: 0x18074BB80
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x74B4A0 Offset: 0x749AA0 VA: 0x18074B4A0
	public void Add(MeshInstance instance) { }

	// RVA: 0x74B5E0 Offset: 0x749BE0 VA: 0x18074B5E0 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x74B990 Offset: 0x749F90 VA: 0x18074B990 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x74BB00 Offset: 0x74A100 VA: 0x18074BB00 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x74B6F0 Offset: 0x749CF0 VA: 0x18074B6F0 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x74BCF0 Offset: 0x74A2F0 VA: 0x18074BCF0 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x74B9F0 Offset: 0x749FF0 VA: 0x18074B9F0 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

