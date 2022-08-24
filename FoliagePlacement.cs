public class FoliagePlacement : ScriptableObject // TypeDefIndex: 9877
{	[HeaderAttribute] // RVA: 0xA3C80 Offset: 0xA3080 VA: 0x1800A3C80
	public float Density; // 0x18
	[HeaderAttribute] // RVA: 0xA3D90 Offset: 0xA3190 VA: 0x1800A3D90
	public SpawnFilter Filter; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xA3EB0 Offset: 0xA32B0 VA: 0x1800A3EB0
	public float FilterCutoff; // 0x28
	public float FilterFade; // 0x2C
	[FormerlySerializedAsAttribute] // RVA: 0xA3FB0 Offset: 0xA33B0 VA: 0x1800A3FB0
	public float FilterScaling; // 0x30
	[HeaderAttribute] // RVA: 0xA4120 Offset: 0xA3520 VA: 0x1800A4120
	public float RandomScaling; // 0x34
	[HeaderAttribute] // RVA: 0xA41E0 Offset: 0xA35E0 VA: 0x1800A41E0
	[MinMaxAttribute] // RVA: 0xA41E0 Offset: 0xA35E0 VA: 0x1800A41E0
	public MinMax Range; // 0x38
	public float RangeFade; // 0x40
	[HeaderAttribute] // RVA: 0xA4350 Offset: 0xA3750 VA: 0x1800A4350
	[RangeAttribute] // RVA: 0xA4350 Offset: 0xA3750 VA: 0x1800A4350
	public float DistanceDensity; // 0x44
	[RangeAttribute] // RVA: 0xA45E0 Offset: 0xA39E0 VA: 0x1800A45E0
	public float DistanceScaling; // 0x48
	[HeaderAttribute] // RVA: 0xA4670 Offset: 0xA3A70 VA: 0x1800A4670
	public Material material; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xA47E0 Offset: 0xA3BE0 VA: 0x1800A47E0
	public Mesh mesh0; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0xA47E0 Offset: 0xA3BE0 VA: 0x1800A47E0
	public Mesh mesh1; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0xA47E0 Offset: 0xA3BE0 VA: 0x1800A47E0
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

