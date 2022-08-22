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

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Mesh[] get_Meshes() { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_IsInitialized() { }

	// RVA: 0xC1C0D0 Offset: 0xC1A6D0 VA: 0x180C1C0D0
	public void Initialize(int vertexCount) { }

	// RVA: 0xC1B2E0 Offset: 0xC198E0 VA: 0x180C1B2E0
	public void Destroy() { }

	// RVA: 0xC1B200 Offset: 0xC19800 VA: 0x180C1B200
	private Mesh CreateMesh(string name, Vector3[] vertices, int[] indices) { }

	// RVA: 0xC1B3C0 Offset: 0xC199C0 VA: 0x180C1B3C0
	private Mesh[] GenerateMeshes(int vertexCount, bool volume = False) { }

	// RVA: 0xC1C100 Offset: 0xC1A700 VA: 0x180C1C100
	private Vector3 RaycastPlane(Camera camera, float planeHeight, Vector3 pos) { }

	// RVA: 0xC1AA10 Offset: 0xC19010 VA: 0x180C1AA10
	public Matrix4x4 ComputeLocalToWorldMatrix(Camera camera, float oceanWaterLevel) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

