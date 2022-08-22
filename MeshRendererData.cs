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

	// RVA: 0x968370 Offset: 0x966970 VA: 0x180968370
	public void Alloc() { }

	// RVA: 0x969810 Offset: 0x967E10 VA: 0x180969810
	public void Free() { }

	// RVA: 0x968930 Offset: 0x966F30 VA: 0x180968930
	public void Clear() { }

	// RVA: 0x9685B0 Offset: 0x966BB0 VA: 0x1809685B0
	public void Apply(Mesh mesh) { }

	// RVA: 0x968A10 Offset: 0x967010 VA: 0x180968A10
	public void Combine(MeshRendererGroup meshGroup) { }

	// RVA: 0x969070 Offset: 0x967670 VA: 0x180969070
	public void Combine(MeshRendererGroup meshGroup, MeshRendererLookup rendererLookup) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

