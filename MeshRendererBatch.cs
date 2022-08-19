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

	// RVA: 0x9681A0 Offset: 0x9667A0 VA: 0x1809681A0 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x968200 Offset: 0x966800 VA: 0x180968200 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x967A00 Offset: 0x966000 VA: 0x180967A00
	protected void Awake() { }

	// RVA: 0x74BB20 Offset: 0x74A120 VA: 0x18074BB20
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x9676D0 Offset: 0x965CD0 VA: 0x1809676D0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x967850 Offset: 0x965E50 VA: 0x180967850 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x967C20 Offset: 0x966220 VA: 0x180967C20 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x967E20 Offset: 0x966420 VA: 0x180967E20 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x9678B0 Offset: 0x965EB0 VA: 0x1809678B0 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x967F80 Offset: 0x966580 VA: 0x180967F80 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x967C80 Offset: 0x966280 VA: 0x180967C80 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

