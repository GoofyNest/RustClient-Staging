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

	// RVA: 0xA9C6C0 Offset: 0xA9ACC0 VA: 0x180A9C6C0
	private void CheckInitialize() { }

	// RVA: 0xA9C6A0 Offset: 0xA9ACA0 VA: 0x180A9C6A0
	private void Awake() { }

	// RVA: 0xA9D5D0 Offset: 0xA9BBD0 VA: 0x180A9D5D0
	private void OnEnable() { }

	// RVA: 0xA9D490 Offset: 0xA9BA90 VA: 0x180A9D490
	private void OnDisable() { }

	// RVA: 0xA9D710 Offset: 0xA9BD10 VA: 0x180A9D710
	private void SetMaterialPropertyBlock() { }

	// RVA: 0xA9D2C0 Offset: 0xA9B8C0 VA: 0x180A9D2C0
	private void DestroyMeshes() { }

	// RVA: 0xA9C750 Offset: 0xA9AD50 VA: 0x180A9C750
	private void CheckReferenceMeshes() { }

	// RVA: 0xA9AE00 Offset: 0xA99400 VA: 0x180A9AE00
	public void Adapt() { }

	// RVA: 0xA9CD10 Offset: 0xA9B310 VA: 0x180A9CD10
	private Mesh CreatePlaneMesh(int resolution) { }

	// RVA: 0xA9D8A0 Offset: 0xA9BEA0 VA: 0x180A9D8A0
	public void .ctor() { }

	// RVA: 0xA9D840 Offset: 0xA9BE40 VA: 0x180A9D840
	private static void .cctor() { }

}

