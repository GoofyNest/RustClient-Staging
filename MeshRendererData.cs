public class MeshRendererData // TypeDefIndex: 9164
{	// Fields
	public List<int> triangles; // 0x10
	public List<Vector3> vertices; // 0x18
	public List<Vector3> normals; // 0x20
	public List<Vector4> tangents; // 0x28
	public List<Color32> colors32; // 0x30
	public List<Vector2> uv; // 0x38
	public List<Vector2> uv2; // 0x40
	public List<Vector4> positions; // 0x48

	// Methods

	// RVA: 0x968870 Offset: 0x966E70 VA: 0x180968870
	public void Alloc() { }

	// RVA: 0x969D10 Offset: 0x968310 VA: 0x180969D10
	public void Free() { }

	// RVA: 0x968E30 Offset: 0x967430 VA: 0x180968E30
	public void Clear() { }

	// RVA: 0x968AB0 Offset: 0x9670B0 VA: 0x180968AB0
	public void Apply(Mesh mesh) { }

	// RVA: 0x968F10 Offset: 0x967510 VA: 0x180968F10
	public void Combine(MeshRendererGroup meshGroup) { }

	// RVA: 0x969570 Offset: 0x967B70 VA: 0x180969570
	public void Combine(MeshRendererGroup meshGroup, MeshRendererLookup rendererLookup) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

