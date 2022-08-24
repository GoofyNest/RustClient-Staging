public class PlaceMonumentsRoadside : ProceduralComponent // TypeDefIndex: 10555
{	public SpawnFilter Filter; // 0x28
	public string ResourceFolder; // 0x30
	public int TargetCount; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	public int MinDistanceSameType; // 0x3C
	public int MinDistanceDifferentType; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xDA090 Offset: 0xD9490 VA: 0x1800DA090
	public int MinWorldSize; // 0x44
	[TooltipAttribute] // RVA: 0xDA2C0 Offset: 0xD96C0 VA: 0x1800DA2C0
	public PlaceMonumentsRoadside.DistanceMode DistanceSameType; // 0x48
	[TooltipAttribute] // RVA: 0xDA340 Offset: 0xD9740 VA: 0x1800DA340
	public PlaceMonumentsRoadside.DistanceMode DistanceDifferentType; // 0x4C
	public PlaceMonumentsRoadside.RoadMode RoadType; // 0x50
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private static Quaternion rot90; // 0x0


	public override void Process(uint seed) { }

	private PlaceMonumentsRoadside.DistanceInfo GetDistanceInfo(List<PlaceMonumentsRoadside.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct PlaceMonumentsRoadside.SpawnInfo // TypeDefIndex: 10556
{	public Prefab<MonumentInfo> prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

private class PlaceMonumentsRoadside.SpawnInfoGroup // TypeDefIndex: 10557
{	public bool processed; // 0x10
	public Prefab<MonumentInfo> prefab; // 0x18
	public List<PlaceMonumentsRoadside.SpawnInfo> candidates; // 0x20


	public void .ctor() { }

}

private struct PlaceMonumentsRoadside.DistanceInfo // TypeDefIndex: 10558
{	public float minDistanceSameType; // 0x0
	public float maxDistanceSameType; // 0x4
	public float minDistanceDifferentType; // 0x8
	public float maxDistanceDifferentType; // 0xC

}

public enum PlaceMonumentsRoadside.DistanceMode // TypeDefIndex: 10559
{	public int value__; // 0x0
	public const PlaceMonumentsRoadside.DistanceMode Any = 0;
	public const PlaceMonumentsRoadside.DistanceMode Min = 1;
	public const PlaceMonumentsRoadside.DistanceMode Max = 2;

}

public enum PlaceMonumentsRoadside.RoadMode // TypeDefIndex: 10560
{	public int value__; // 0x0
	public const PlaceMonumentsRoadside.RoadMode SideRoadOrRingRoad = 0;
	public const PlaceMonumentsRoadside.RoadMode SideRoad = 1;
	public const PlaceMonumentsRoadside.RoadMode RingRoad = 2;
	public const PlaceMonumentsRoadside.RoadMode SideRoadOrDesireTrail = 3;
	public const PlaceMonumentsRoadside.RoadMode DesireTrail = 4;

}

private sealed class PlaceMonumentsRoadside.<>c // TypeDefIndex: 10561
{	public static readonly PlaceMonumentsRoadside.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Process>b__17_0(string folder) { }

}

