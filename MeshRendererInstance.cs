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

	// RVA: 0xFABA0 Offset: 0xF9FA0 VA: 0x1800FABA0
	public Mesh get_mesh() { }

	// RVA: 0xFABC0 Offset: 0xF9FC0 VA: 0x1800FABC0
	public void set_mesh(Mesh value) { }

}

