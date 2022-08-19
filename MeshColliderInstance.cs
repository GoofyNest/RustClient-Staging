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

	// RVA: 0xFAA40 Offset: 0xF9E40 VA: 0x1800FAA40
	public Mesh get_mesh() { }

	// RVA: 0xFAA60 Offset: 0xF9E60 VA: 0x1800FAA60
	public void set_mesh(Mesh value) { }

}

