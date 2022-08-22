public class MeshRendererBatch : MeshBatch // TypeDefIndex: 11390
{	// Fields
	private Vector3 position; // 0x28
	private Mesh meshBatch; // 0x38
	private MeshFilter meshFilter; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private MeshRendererData meshData; // 0x50
	private MeshRendererGroup meshGroup; // 0x58
	private MeshRendererLookup meshLookup; // 0x60

	// Properties
	public override int VertexCapacity { get; }
	public override int VertexCutoff { get; }

	// Methods

	// RVA: 0x9687B0 Offset: 0x966DB0 VA: 0x1809687B0 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x968810 Offset: 0x966E10 VA: 0x180968810 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x968010 Offset: 0x966610 VA: 0x180968010
	protected void Awake() { }

	// RVA: 0x74BB80 Offset: 0x74A180 VA: 0x18074BB80
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x967CE0 Offset: 0x9662E0 VA: 0x180967CE0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x967E60 Offset: 0x966460 VA: 0x180967E60 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x968230 Offset: 0x966830 VA: 0x180968230 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x968430 Offset: 0x966A30 VA: 0x180968430 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x967EC0 Offset: 0x9664C0 VA: 0x180967EC0 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x968590 Offset: 0x966B90 VA: 0x180968590 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x968290 Offset: 0x966890 VA: 0x180968290 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

