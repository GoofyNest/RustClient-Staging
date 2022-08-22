public class WaterRadialMesh // TypeDefIndex: 10618
{	// Fields
	private const float AlignmentGranularity = 1;
	private const float MaxHorizontalDisplacement = 1;
	private Mesh[] meshes; // 0x10
	private bool initialized; // 0x18

	// Properties
	public Mesh[] Meshes { get; }
	public bool IsInitialized { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Mesh[] get_Meshes() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_IsInitialized() { }

	// RVA: 0xC1BC00 Offset: 0xC1A200 VA: 0x180C1BC00
	public void Initialize(int vertexCount) { }

	// RVA: 0xC1AE10 Offset: 0xC19410 VA: 0x180C1AE10
	public void Destroy() { }

	// RVA: 0xC1AD30 Offset: 0xC19330 VA: 0x180C1AD30
	private Mesh CreateMesh(string name, Vector3[] vertices, int[] indices) { }

	// RVA: 0xC1AEF0 Offset: 0xC194F0 VA: 0x180C1AEF0
	private Mesh[] GenerateMeshes(int vertexCount, bool volume = False) { }

	// RVA: 0xC1BC30 Offset: 0xC1A230 VA: 0x180C1BC30
	private Vector3 RaycastPlane(Camera camera, float planeHeight, Vector3 pos) { }

	// RVA: 0xC1A540 Offset: 0xC18B40 VA: 0x180C1A540
	public Matrix4x4 ComputeLocalToWorldMatrix(Camera camera, float oceanWaterLevel) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

