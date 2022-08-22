public class FoliageGridMeshData // TypeDefIndex: 11372
{	// Fields
	public List<FoliageGridMeshData.FoliageVertex> vertices; // 0x10
	public List<int> triangles; // 0x18
	public Bounds bounds; // 0x20

	// Methods

	// RVA: 0x74C680 Offset: 0x74AC80 VA: 0x18074C680
	public void Alloc() { }

	// RVA: 0x74CFC0 Offset: 0x74B5C0 VA: 0x18074CFC0
	public void Free() { }

	// RVA: 0x74C860 Offset: 0x74AE60 VA: 0x18074C860
	public void Clear() { }

	// RVA: 0x74C8C0 Offset: 0x74AEC0 VA: 0x18074C8C0
	public void Combine(MeshGroup meshGroup) { }

	// RVA: 0x74C740 Offset: 0x74AD40 VA: 0x18074C740
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

	// RVA: 0x7504B0 Offset: 0x74EAB0 VA: 0x1807504B0
	private static void .cctor() { }

}

