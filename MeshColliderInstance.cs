public struct MeshColliderInstance // TypeDefIndex: 9157
{	// Fields
	public Transform transform; // 0x0
	public Rigidbody rigidbody; // 0x8
	public Collider collider; // 0x10
	public OBB bounds; // 0x18
	public Vector3 position; // 0x68
	public Quaternion rotation; // 0x74
	public Vector3 scale; // 0x84
	public MeshCache.Data data; // 0x90

	// Properties
	public Mesh mesh { get; set; }

	// Methods

	// RVA: 0xFA9C0 Offset: 0xF9DC0 VA: 0x1800FA9C0
	public Mesh get_mesh() { }

	// RVA: 0xFA9E0 Offset: 0xF9DE0 VA: 0x1800FA9E0
	public void set_mesh(Mesh value) { }

}

