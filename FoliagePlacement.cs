public class FoliagePlacement : ScriptableObject // TypeDefIndex: 9877
{	[HeaderAttribute] // RVA: 0xA3730 Offset: 0xA2B30 VA: 0x1800A3730
	public float Density; // 0x18
	[HeaderAttribute] // RVA: 0xA3810 Offset: 0xA2C10 VA: 0x1800A3810
	public SpawnFilter Filter; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xA38E0 Offset: 0xA2CE0 VA: 0x1800A38E0
	public float FilterCutoff; // 0x28
	public float FilterFade; // 0x2C
	[FormerlySerializedAsAttribute] // RVA: 0xA3A30 Offset: 0xA2E30 VA: 0x1800A3A30
	public float FilterScaling; // 0x30
	[HeaderAttribute] // RVA: 0xA3B90 Offset: 0xA2F90 VA: 0x1800A3B90
	public float RandomScaling; // 0x34
	[HeaderAttribute] // RVA: 0xA3C20 Offset: 0xA3020 VA: 0x1800A3C20
	[MinMaxAttribute] // RVA: 0xA3C20 Offset: 0xA3020 VA: 0x1800A3C20
	public MinMax Range; // 0x38
	public float RangeFade; // 0x40
	[HeaderAttribute] // RVA: 0xA3DB0 Offset: 0xA31B0 VA: 0x1800A3DB0
	[RangeAttribute] // RVA: 0xA3DB0 Offset: 0xA31B0 VA: 0x1800A3DB0
	public float DistanceDensity; // 0x44
	[RangeAttribute] // RVA: 0xA3E70 Offset: 0xA3270 VA: 0x1800A3E70
	public float DistanceScaling; // 0x48
	[HeaderAttribute] // RVA: 0xA3F90 Offset: 0xA3390 VA: 0x1800A3F90
	public Material material; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xA40F0 Offset: 0xA34F0 VA: 0x1800A40F0
	public Mesh mesh0; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0xA40F0 Offset: 0xA34F0 VA: 0x1800A40F0
	public Mesh mesh1; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0xA40F0 Offset: 0xA34F0 VA: 0x1800A40F0
	public Mesh mesh2; // 0x68
	public const int lods = 5;
	public const int octaves = 1;
	public const float frequency = 0,05;
	public const float amplitude = 0,5;
	public const float offset = 0,5;


	public void Init() { }

	public bool CheckBatch(Vector3 pivot, float size) { }

	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	public void .ctor() { }

}

