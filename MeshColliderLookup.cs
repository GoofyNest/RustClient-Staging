public class MeshColliderLookup // TypeDefIndex: 9158
{	// Fields
	public MeshColliderLookup.LookupGroup src; // 0x10
	public MeshColliderLookup.LookupGroup dst; // 0x18

	// Methods

	// RVA: 0x960B80 Offset: 0x95F180 VA: 0x180960B80
	public void Apply() { }

	// RVA: 0x9609B0 Offset: 0x95EFB0 VA: 0x1809609B0
	public void Add(MeshColliderInstance instance) { }

	// RVA: 0x960C10 Offset: 0x95F210 VA: 0x180960C10
	public MeshColliderLookup.LookupEntry Get(int index) { }

	// RVA: 0x960D00 Offset: 0x95F300 VA: 0x180960D00
	public void .ctor() { }

}

public class MeshColliderLookup.LookupGroup // TypeDefIndex: 9159
{	// Fields
	public List<MeshColliderLookup.LookupEntry> data; // 0x10
	public List<int> indices; // 0x18

	// Methods

	// RVA: 0x957F60 Offset: 0x956560 VA: 0x180957F60
	public void Clear() { }

	// RVA: 0x957D10 Offset: 0x956310 VA: 0x180957D10
	public void Add(MeshColliderInstance instance) { }

	// RVA: 0x958070 Offset: 0x956670 VA: 0x180958070
	public MeshColliderLookup.LookupEntry Get(int index) { }

	// RVA: 0x9581C0 Offset: 0x9567C0 VA: 0x1809581C0
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

