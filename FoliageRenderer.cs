public class FoliageRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9878
{	// Fields
	public Material material; // 0x18
	public Mesh LOD0; // 0x20
	public Mesh LOD1; // 0x28
	private FoliageGroup batchGroup; // 0x30
	private MeshInstance batchInstance; // 0x38

	// Methods

	// RVA: 0x750160 Offset: 0x74E760 VA: 0x180750160
	protected void OnEnable() { }

	// RVA: 0x7500F0 Offset: 0x74E6F0 VA: 0x1807500F0
	protected void OnDisable() { }

	// RVA: 0x74FDE0 Offset: 0x74E3E0 VA: 0x18074FDE0
	public void Add() { }

	// RVA: 0x750190 Offset: 0x74E790 VA: 0x180750190
	public void Remove() { }

	// RVA: 0x750170 Offset: 0x74E770 VA: 0x180750170
	public void Refresh() { }

	// RVA: 0x74FD30 Offset: 0x74E330 VA: 0x18074FD30
	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

