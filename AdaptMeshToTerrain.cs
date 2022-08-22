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

	// RVA: 0xA9C1F0 Offset: 0xA9A7F0 VA: 0x180A9C1F0
	private void CheckInitialize() { }

	// RVA: 0xA9C1D0 Offset: 0xA9A7D0 VA: 0x180A9C1D0
	private void Awake() { }

	// RVA: 0xA9D100 Offset: 0xA9B700 VA: 0x180A9D100
	private void OnEnable() { }

	// RVA: 0xA9CFC0 Offset: 0xA9B5C0 VA: 0x180A9CFC0
	private void OnDisable() { }

	// RVA: 0xA9D240 Offset: 0xA9B840 VA: 0x180A9D240
	private void SetMaterialPropertyBlock() { }

	// RVA: 0xA9CDF0 Offset: 0xA9B3F0 VA: 0x180A9CDF0
	private void DestroyMeshes() { }

	// RVA: 0xA9C280 Offset: 0xA9A880 VA: 0x180A9C280
	private void CheckReferenceMeshes() { }

	// RVA: 0xA9A930 Offset: 0xA98F30 VA: 0x180A9A930
	public void Adapt() { }

	// RVA: 0xA9C840 Offset: 0xA9AE40 VA: 0x180A9C840
	private Mesh CreatePlaneMesh(int resolution) { }

	// RVA: 0xA9D3D0 Offset: 0xA9B9D0 VA: 0x180A9D3D0
	public void .ctor() { }

	// RVA: 0xA9D370 Offset: 0xA9B970 VA: 0x180A9D370
	private static void .cctor() { }

}

