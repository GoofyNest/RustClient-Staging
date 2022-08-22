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

	// RVA: 0x9682B0 Offset: 0x9668B0 VA: 0x1809682B0 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x968310 Offset: 0x966910 VA: 0x180968310 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x967B10 Offset: 0x966110 VA: 0x180967B10
	protected void Awake() { }

	// RVA: 0x74BC30 Offset: 0x74A230 VA: 0x18074BC30
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x9677E0 Offset: 0x965DE0 VA: 0x1809677E0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x967960 Offset: 0x965F60 VA: 0x180967960 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x967D30 Offset: 0x966330 VA: 0x180967D30 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x967F30 Offset: 0x966530 VA: 0x180967F30 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x9679C0 Offset: 0x965FC0 VA: 0x1809679C0 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x968090 Offset: 0x966690 VA: 0x180968090 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x967D90 Offset: 0x966390 VA: 0x180967D90 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

