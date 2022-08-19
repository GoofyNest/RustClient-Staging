public class PlaceMonumentsRoadside : ProceduralComponent // TypeDefIndex: 10551
{	// Fields
	public SpawnFilter Filter; // 0x28
	public string ResourceFolder; // 0x30
	public int TargetCount; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xDA240 Offset: 0xD9640 VA: 0x1800DA240
	public int MinDistanceSameType; // 0x3C
	public int MinDistanceDifferentType; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xDA270 Offset: 0xD9670 VA: 0x1800DA270
	public int MinWorldSize; // 0x44
	[TooltipAttribute] // RVA: 0xDA4C0 Offset: 0xD98C0 VA: 0x1800DA4C0
	public PlaceMonumentsRoadside.DistanceMode DistanceSameType; // 0x48
	[TooltipAttribute] // RVA: 0xDA690 Offset: 0xD9A90 VA: 0x1800DA690
	public PlaceMonumentsRoadside.DistanceMode DistanceDifferentType; // 0x4C
	public PlaceMonumentsRoadside.RoadMode RoadType; // 0x50
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private static Quaternion rot90; // 0x0

	// Methods

	// RVA: 0x914FF0 Offset: 0x9135F0 VA: 0x180914FF0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x914580 Offset: 0x912B80 VA: 0x180914580
	private PlaceMonumentsRoadside.DistanceInfo GetDistanceInfo(List<PlaceMonumentsRoadside.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale) { }

	// RVA: 0x916A90 Offset: 0x915090 VA: 0x180916A90
	public void .ctor() { }

	// RVA: 0x916A10 Offset: 0x915010 VA: 0x180916A10
	private static void .cctor() { }

}

private struct PlaceMonumentsRoadside.SpawnInfo // TypeDefIndex: 10552
{	// Fields
	public Prefab<MonumentInfo> prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

private class PlaceMonumentsRoadside.SpawnInfoGroup // TypeDefIndex: 10553
{	// Fields
	public bool processed; // 0x10
	public Prefab<MonumentInfo> prefab; // 0x18
	public List<PlaceMonumentsRoadside.SpawnInfo> candidates; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct PlaceMonumentsRoadside.DistanceInfo // TypeDefIndex: 10554
{	// Fields
	public float minDistanceSameType; // 0x0
	public float maxDistanceSameType; // 0x4
	public float minDistanceDifferentType; // 0x8
	public float maxDistanceDifferentType; // 0xC

}

public enum PlaceMonumentsRoadside.DistanceMode // TypeDefIndex: 10555
{	// Fields
	public int value__; // 0x0
	public const PlaceMonumentsRoadside.DistanceMode Any = 0;
	public const PlaceMonumentsRoadside.DistanceMode Min = 1;
	public const PlaceMonumentsRoadside.DistanceMode Max = 2;

}

public enum PlaceMonumentsRoadside.RoadMode // TypeDefIndex: 10556
{	// Fields
	public int value__; // 0x0
	public const PlaceMonumentsRoadside.RoadMode SideRoadOrRingRoad = 0;
	public const PlaceMonumentsRoadside.RoadMode SideRoad = 1;
	public const PlaceMonumentsRoadside.RoadMode RingRoad = 2;
	public const PlaceMonumentsRoadside.RoadMode SideRoadOrDesireTrail = 3;
	public const PlaceMonumentsRoadside.RoadMode DesireTrail = 4;

}

private sealed class PlaceMonumentsRoadside.<>c // TypeDefIndex: 10557
{	// Fields
	public static readonly PlaceMonumentsRoadside.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x920B50 Offset: 0x91F150 VA: 0x180920B50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x920880 Offset: 0x91EE80 VA: 0x180920880
	internal string <Process>b__17_0(string folder) { }

}
