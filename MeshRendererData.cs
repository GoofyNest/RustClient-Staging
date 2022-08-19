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

	// RVA: 0x968260 Offset: 0x966860 VA: 0x180968260
	public void Alloc() { }

	// RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700
	public void Free() { }

	// RVA: 0x968820 Offset: 0x966E20 VA: 0x180968820
	public void Clear() { }

	// RVA: 0x9684A0 Offset: 0x966AA0 VA: 0x1809684A0
	public void Apply(Mesh mesh) { }

	// RVA: 0x968900 Offset: 0x966F00 VA: 0x180968900
	public void Combine(MeshRendererGroup meshGroup) { }

	// RVA: 0x968F60 Offset: 0x967560 VA: 0x180968F60
	public void Combine(MeshRendererGroup meshGroup, MeshRendererLookup rendererLookup) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

