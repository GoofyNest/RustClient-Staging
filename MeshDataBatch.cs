public class MeshDataBatch : MeshBatch // TypeDefIndex: 11389
{	// Fields
	private Vector3 position; // 0x28
	private Mesh meshBatch; // 0x38
	private MeshFilter meshFilter; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private MeshData meshData; // 0x50
	private MeshGroup meshGroup; // 0x58

	// Properties
	public override int VertexCapacity { get; }
	public override int VertexCutoff { get; }

	// Methods

	// RVA: 0x9618A0 Offset: 0x95FEA0 VA: 0x1809618A0 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x961900 Offset: 0x95FF00 VA: 0x180961900 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x9613E0 Offset: 0x95F9E0 VA: 0x1809613E0
	protected void Awake() { }

	// RVA: 0x74BC30 Offset: 0x74A230 VA: 0x18074BC30
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x961170 Offset: 0x95F770 VA: 0x180961170
	public void Add(MeshInstance instance) { }

	// RVA: 0x9612A0 Offset: 0x95F8A0 VA: 0x1809612A0 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x9614C0 Offset: 0x95FAC0 VA: 0x1809614C0 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x961630 Offset: 0x95FC30 VA: 0x180961630 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x961300 Offset: 0x95F900 VA: 0x180961300 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x961740 Offset: 0x95FD40 VA: 0x180961740 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x961520 Offset: 0x95FB20 VA: 0x180961520 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

