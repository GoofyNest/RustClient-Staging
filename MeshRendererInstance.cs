public struct MeshRendererInstance // TypeDefIndex: 9166
{	// Fields
	public Renderer renderer; // 0x0
	public OBB bounds; // 0x8
	public Vector3 position; // 0x58
	public Quaternion rotation; // 0x64
	public Vector3 scale; // 0x74
	public MeshCache.Data data; // 0x80

	// Properties
	public Mesh mesh { get; set; }

	// Methods

	// RVA: 0xFAB20 Offset: 0xF9F20 VA: 0x1800FAB20
	public Mesh get_mesh() { }

	// RVA: 0xFAB40 Offset: 0xF9F40 VA: 0x1800FAB40
	public void set_mesh(Mesh value) { }

}

