public class MeshColliderLookup // TypeDefIndex: 9158
{	// Fields
	public MeshColliderLookup.LookupGroup src; // 0x10
	public MeshColliderLookup.LookupGroup dst; // 0x18

	// Methods

	// RVA: 0x961080 Offset: 0x95F680 VA: 0x180961080
	public void Apply() { }

	// RVA: 0x960EB0 Offset: 0x95F4B0 VA: 0x180960EB0
	public void Add(MeshColliderInstance instance) { }

	// RVA: 0x961110 Offset: 0x95F710 VA: 0x180961110
	public MeshColliderLookup.LookupEntry Get(int index) { }

	// RVA: 0x961200 Offset: 0x95F800 VA: 0x180961200
	public void .ctor() { }

}

public class MeshColliderLookup.LookupGroup // TypeDefIndex: 9159
{	// Fields
	public List<MeshColliderLookup.LookupEntry> data; // 0x10
	public List<int> indices; // 0x18

	// Methods

	// RVA: 0x958460 Offset: 0x956A60 VA: 0x180958460
	public void Clear() { }

	// RVA: 0x958210 Offset: 0x956810 VA: 0x180958210
	public void Add(MeshColliderInstance instance) { }

	// RVA: 0x958570 Offset: 0x956B70 VA: 0x180958570
	public MeshColliderLookup.LookupEntry Get(int index) { }

	// RVA: 0x9586C0 Offset: 0x956CC0 VA: 0x1809586C0
	public void .ctor() { }

}

public struct MeshColliderLookup.LookupEntry // TypeDefIndex: 9160
{	// Fields
	public Transform transform; // 0x0
	public Rigidbody rigidbody; // 0x8
	public Collider collider; // 0x10
	public OBB bounds; // 0x18

	// Methods

	// RVA: 0xFA860 Offset: 0xF9C60 VA: 0x1800FA860
	public void .ctor(MeshColliderInstance instance) { }

}

