public class AdaptMeshToTerrain : MonoBehaviour // TypeDefIndex: 10638
{	// Fields
	public LayerMask LayerMask; // 0x18
	public float RayHeight; // 0x1C
	public float RayMaxDistance; // 0x20
	public float MinDisplacement; // 0x24
	public float MaxDisplacement; // 0x28
	[RangeAttribute] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	public int PlaneResolution; // 0x2C
	private const int LODCount = 3;
	private MeshFilter meshFilter; // 0x30
	private MeshRenderer meshRenderer; // 0x38
	private MeshCollider meshCollider; // 0x40
	private MeshLOD meshLOD; // 0x48
	private Mesh[] meshes; // 0x50
	private Mesh colliderMesh; // 0x58
	private static Dictionary<int, Mesh> referenceMeshes; // 0x0
	private MaterialPropertyBlock block; // 0x60

	// Methods

	// RVA: 0xA9BF30 Offset: 0xA9A530 VA: 0x180A9BF30
	private void CheckInitialize() { }

	// RVA: 0xA9BF10 Offset: 0xA9A510 VA: 0x180A9BF10
	private void Awake() { }

	// RVA: 0xA9CE40 Offset: 0xA9B440 VA: 0x180A9CE40
	private void OnEnable() { }

	// RVA: 0xA9CD00 Offset: 0xA9B300 VA: 0x180A9CD00
	private void OnDisable() { }

	// RVA: 0xA9CF80 Offset: 0xA9B580 VA: 0x180A9CF80
	private void SetMaterialPropertyBlock() { }

	// RVA: 0xA9CB30 Offset: 0xA9B130 VA: 0x180A9CB30
	private void DestroyMeshes() { }

	// RVA: 0xA9BFC0 Offset: 0xA9A5C0 VA: 0x180A9BFC0
	private void CheckReferenceMeshes() { }

	// RVA: 0xA9A670 Offset: 0xA98C70 VA: 0x180A9A670
	public void Adapt() { }

	// RVA: 0xA9C580 Offset: 0xA9AB80 VA: 0x180A9C580
	private Mesh CreatePlaneMesh(int resolution) { }

	// RVA: 0xA9D110 Offset: 0xA9B710 VA: 0x180A9D110
	public void .ctor() { }

	// RVA: 0xA9D0B0 Offset: 0xA9B6B0 VA: 0x180A9D0B0
	private static void .cctor() { }

}

