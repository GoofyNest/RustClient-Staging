public class FoliagePlacement : ScriptableObject // TypeDefIndex: 9877
{	// Fields
	[HeaderAttribute] // RVA: 0xA3B40 Offset: 0xA2F40 VA: 0x1800A3B40
	public float Density; // 0x18
	[HeaderAttribute] // RVA: 0xA3BE0 Offset: 0xA2FE0 VA: 0x1800A3BE0
	public SpawnFilter Filter; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xA3CF0 Offset: 0xA30F0 VA: 0x1800A3CF0
	public float FilterCutoff; // 0x28
	public float FilterFade; // 0x2C
	[FormerlySerializedAsAttribute] // RVA: 0xA3E30 Offset: 0xA3230 VA: 0x1800A3E30
	public float FilterScaling; // 0x30
	[HeaderAttribute] // RVA: 0xA3F70 Offset: 0xA3370 VA: 0x1800A3F70
	public float RandomScaling; // 0x34
	[HeaderAttribute] // RVA: 0xA4060 Offset: 0xA3460 VA: 0x1800A4060
	[MinMaxAttribute] // RVA: 0xA4060 Offset: 0xA3460 VA: 0x1800A4060
	public MinMax Range; // 0x38
	public float RangeFade; // 0x40
	[HeaderAttribute] // RVA: 0xA41A0 Offset: 0xA35A0 VA: 0x1800A41A0
	[RangeAttribute] // RVA: 0xA41A0 Offset: 0xA35A0 VA: 0x1800A41A0
	public float DistanceDensity; // 0x44
	[RangeAttribute] // RVA: 0xA43E0 Offset: 0xA37E0 VA: 0x1800A43E0
	public float DistanceScaling; // 0x48
	[HeaderAttribute] // RVA: 0xA4530 Offset: 0xA3930 VA: 0x1800A4530
	public Material material; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xA4660 Offset: 0xA3A60 VA: 0x1800A4660
	public Mesh mesh0; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0xA4660 Offset: 0xA3A60 VA: 0x1800A4660
	public Mesh mesh1; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0xA4660 Offset: 0xA3A60 VA: 0x1800A4660
	public Mesh mesh2; // 0x68
	public const int lods = 5;
	public const int octaves = 1;
	public const float frequency = 0,05;
	public const float amplitude = 0,5;
	public const float offset = 0,5;

	// Methods

	// RVA: 0x74FC00 Offset: 0x74E200 VA: 0x18074FC00
	public void Init() { }

	// RVA: 0x74FA90 Offset: 0x74E090 VA: 0x18074FA90
	public bool CheckBatch(Vector3 pivot, float size) { }

	// RVA: 0x74F3B0 Offset: 0x74D9B0 VA: 0x18074F3B0
	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	// RVA: 0x74FC80 Offset: 0x74E280 VA: 0x18074FC80
	public void .ctor() { }

}
