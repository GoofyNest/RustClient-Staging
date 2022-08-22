public class FoliageRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9878
{	// Fields
	public Material material; // 0x18
	public Mesh LOD0; // 0x20
	public Mesh LOD1; // 0x28
	private FoliageGroup batchGroup; // 0x30
	private MeshInstance batchInstance; // 0x38

	// Methods

	// RVA: 0x7501C0 Offset: 0x74E7C0 VA: 0x1807501C0
	protected void OnEnable() { }

	// RVA: 0x750150 Offset: 0x74E750 VA: 0x180750150
	protected void OnDisable() { }

	// RVA: 0x74FE40 Offset: 0x74E440 VA: 0x18074FE40
	public void Add() { }

	// RVA: 0x7501F0 Offset: 0x74E7F0 VA: 0x1807501F0
	public void Remove() { }

	// RVA: 0x7501D0 Offset: 0x74E7D0 VA: 0x1807501D0
	public void Refresh() { }

	// RVA: 0x74FD90 Offset: 0x74E390 VA: 0x18074FD90
	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

