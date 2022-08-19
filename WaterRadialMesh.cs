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

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_IsInitialized() { }

	// RVA: 0xC1B940 Offset: 0xC19F40 VA: 0x180C1B940
	public void Initialize(int vertexCount) { }

	// RVA: 0xC1AB50 Offset: 0xC19150 VA: 0x180C1AB50
	public void Destroy() { }

	// RVA: 0xC1AA70 Offset: 0xC19070 VA: 0x180C1AA70
	private Mesh CreateMesh(string name, Vector3[] vertices, int[] indices) { }

	// RVA: 0xC1AC30 Offset: 0xC19230 VA: 0x180C1AC30
	private Mesh[] GenerateMeshes(int vertexCount, bool volume = False) { }

	// RVA: 0xC1B970 Offset: 0xC19F70 VA: 0x180C1B970
	private Vector3 RaycastPlane(Camera camera, float planeHeight, Vector3 pos) { }

	// RVA: 0xC1A280 Offset: 0xC18880 VA: 0x180C1A280
	public Matrix4x4 ComputeLocalToWorldMatrix(Camera camera, float oceanWaterLevel) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

