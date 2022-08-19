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

	// RVA: 0x961790 Offset: 0x95FD90 VA: 0x180961790 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x9617F0 Offset: 0x95FDF0 VA: 0x1809617F0 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x9612D0 Offset: 0x95F8D0 VA: 0x1809612D0
	protected void Awake() { }

	// RVA: 0x74BB20 Offset: 0x74A120 VA: 0x18074BB20
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x961060 Offset: 0x95F660 VA: 0x180961060
	public void Add(MeshInstance instance) { }

	// RVA: 0x961190 Offset: 0x95F790 VA: 0x180961190 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x9613B0 Offset: 0x95F9B0 VA: 0x1809613B0 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x961520 Offset: 0x95FB20 VA: 0x180961520 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x9611F0 Offset: 0x95F7F0 VA: 0x1809611F0 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x961630 Offset: 0x95FC30 VA: 0x180961630 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x961410 Offset: 0x95FA10 VA: 0x180961410 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

