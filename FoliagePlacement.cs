public class FoliagePlacement : ScriptableObject // TypeDefIndex: 9877
{	// Fields
	[HeaderAttribute] // RVA: 0xA3BD0 Offset: 0xA2FD0 VA: 0x1800A3BD0
	public float Density; // 0x18
	[HeaderAttribute] // RVA: 0xA3CF0 Offset: 0xA30F0 VA: 0x1800A3CF0
	public SpawnFilter Filter; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xA3E00 Offset: 0xA3200 VA: 0x1800A3E00
	public float FilterCutoff; // 0x28
	public float FilterFade; // 0x2C
	[FormerlySerializedAsAttribute] // RVA: 0xA3EC0 Offset: 0xA32C0 VA: 0x1800A3EC0
	public float FilterScaling; // 0x30
	[HeaderAttribute] // RVA: 0xA4000 Offset: 0xA3400 VA: 0x1800A4000
	public float RandomScaling; // 0x34
	[HeaderAttribute] // RVA: 0xA40F0 Offset: 0xA34F0 VA: 0x1800A40F0
	[MinMaxAttribute] // RVA: 0xA40F0 Offset: 0xA34F0 VA: 0x1800A40F0
	public MinMax Range; // 0x38
	public float RangeFade; // 0x40
	[HeaderAttribute] // RVA: 0xA4230 Offset: 0xA3630 VA: 0x1800A4230
	[RangeAttribute] // RVA: 0xA4230 Offset: 0xA3630 VA: 0x1800A4230
	public float DistanceDensity; // 0x44
	[RangeAttribute] // RVA: 0xA4560 Offset: 0xA3960 VA: 0x1800A4560
	public float DistanceScaling; // 0x48
	[HeaderAttribute] // RVA: 0xA45F0 Offset: 0xA39F0 VA: 0x1800A45F0
	public Material material; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xA4720 Offset: 0xA3B20 VA: 0x1800A4720
	public Mesh mesh0; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0xA4720 Offset: 0xA3B20 VA: 0x1800A4720
	public Mesh mesh1; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0xA4720 Offset: 0xA3B20 VA: 0x1800A4720
	public Mesh mesh2; // 0x68
	public const int lods = 5;
	public const int octaves = 1;
	public const float frequency = 0,05;
	public const float amplitude = 0,5;
	public const float offset = 0,5;

	// Methods

	// RVA: 0x74FC60 Offset: 0x74E260 VA: 0x18074FC60
	public void Init() { }

	// RVA: 0x74FAF0 Offset: 0x74E0F0 VA: 0x18074FAF0
	public bool CheckBatch(Vector3 pivot, float size) { }

	// RVA: 0x74F410 Offset: 0x74DA10 VA: 0x18074F410
	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	// RVA: 0x74FCE0 Offset: 0x74E2E0 VA: 0x18074FCE0
	public void .ctor() { }

}

