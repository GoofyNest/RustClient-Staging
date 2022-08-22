public class FoliageRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9878
{	// Fields
	public Material material; // 0x18
	public Mesh LOD0; // 0x20
	public Mesh LOD1; // 0x28
	private FoliageGroup batchGroup; // 0x30
	private MeshInstance batchInstance; // 0x38

	// Methods

	// RVA: 0x750270 Offset: 0x74E870 VA: 0x180750270
	protected void OnEnable() { }

	// RVA: 0x750200 Offset: 0x74E800 VA: 0x180750200
	protected void OnDisable() { }

	// RVA: 0x74FEF0 Offset: 0x74E4F0 VA: 0x18074FEF0
	public void Add() { }

	// RVA: 0x7502A0 Offset: 0x74E8A0 VA: 0x1807502A0
	public void Remove() { }

	// RVA: 0x750280 Offset: 0x74E880 VA: 0x180750280
	public void Refresh() { }

	// RVA: 0x74FE40 Offset: 0x74E440 VA: 0x18074FE40
	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

