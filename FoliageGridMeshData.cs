public class FoliageGridMeshData // TypeDefIndex: 11372
{	// Fields
	public List<FoliageGridMeshData.FoliageVertex> vertices; // 0x10
	public List<int> triangles; // 0x18
	public Bounds bounds; // 0x20

	// Methods

	// RVA: 0x74C5D0 Offset: 0x74ABD0 VA: 0x18074C5D0
	public void Alloc() { }

	// RVA: 0x74CF10 Offset: 0x74B510 VA: 0x18074CF10
	public void Free() { }

	// RVA: 0x74C7B0 Offset: 0x74ADB0 VA: 0x18074C7B0
	public void Clear() { }

	// RVA: 0x74C810 Offset: 0x74AE10 VA: 0x18074C810
	public void Combine(MeshGroup meshGroup) { }

	// RVA: 0x74C690 Offset: 0x74AC90 VA: 0x18074C690
	public void Apply(Mesh mesh) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public struct FoliageGridMeshData.FoliageVertex // TypeDefIndex: 11373
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector2 uv; // 0x2C
	public Vector4 uv2; // 0x34
	public static readonly VertexAttributeDescriptor[] VertexLayout; // 0x0

	// Methods

	// RVA: 0x750400 Offset: 0x74EA00 VA: 0x180750400
	private static void .cctor() { }

}

