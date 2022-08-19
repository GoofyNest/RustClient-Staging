public class MeshColliderLookup // TypeDefIndex: 9158
{	// Fields
	public MeshColliderLookup.LookupGroup src; // 0x10
	public MeshColliderLookup.LookupGroup dst; // 0x18

	// Methods

	// RVA: 0x960A70 Offset: 0x95F070 VA: 0x180960A70
	public void Apply() { }

	// RVA: 0x9608A0 Offset: 0x95EEA0 VA: 0x1809608A0
	public void Add(MeshColliderInstance instance) { }

	// RVA: 0x960B00 Offset: 0x95F100 VA: 0x180960B00
	public MeshColliderLookup.LookupEntry Get(int index) { }

	// RVA: 0x960BF0 Offset: 0x95F1F0 VA: 0x180960BF0
	public void .ctor() { }

}

public class MeshColliderLookup.LookupGroup // TypeDefIndex: 9159
{	// Fields
	public List<MeshColliderLookup.LookupEntry> data; // 0x10
	public List<int> indices; // 0x18

	// Methods

	// RVA: 0x957E50 Offset: 0x956450 VA: 0x180957E50
	public void Clear() { }

	// RVA: 0x957C00 Offset: 0x956200 VA: 0x180957C00
	public void Add(MeshColliderInstance instance) { }

	// RVA: 0x957F60 Offset: 0x956560 VA: 0x180957F60
	public MeshColliderLookup.LookupEntry Get(int index) { }

	// RVA: 0x9580B0 Offset: 0x9566B0 VA: 0x1809580B0
	public void .ctor() { }

}

public struct MeshColliderLookup.LookupEntry // TypeDefIndex: 9160
{	// Fields
	public Transform transform; // 0x0
	public Rigidbody rigidbody; // 0x8
	public Collider collider; // 0x10
	public OBB bounds; // 0x18

	// Methods

	// RVA: 0xFA8E0 Offset: 0xF9CE0 VA: 0x1800FA8E0
	public void .ctor(MeshColliderInstance instance) { }

}

