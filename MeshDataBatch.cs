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

	// RVA: 0x961DA0 Offset: 0x9603A0 VA: 0x180961DA0 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x961E00 Offset: 0x960400 VA: 0x180961E00 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x9618E0 Offset: 0x95FEE0 VA: 0x1809618E0
	protected void Awake() { }

	// RVA: 0x74BB80 Offset: 0x74A180 VA: 0x18074BB80
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x961670 Offset: 0x95FC70 VA: 0x180961670
	public void Add(MeshInstance instance) { }

	// RVA: 0x9617A0 Offset: 0x95FDA0 VA: 0x1809617A0 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x9619C0 Offset: 0x95FFC0 VA: 0x1809619C0 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x961B30 Offset: 0x960130 VA: 0x180961B30 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x961800 Offset: 0x95FE00 VA: 0x180961800 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x961C40 Offset: 0x960240 VA: 0x180961C40 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x961A20 Offset: 0x960020 VA: 0x180961A20 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

