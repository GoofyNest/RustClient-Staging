public class PlaceMonuments : ProceduralComponent // TypeDefIndex: 10541
{	public SpawnFilter Filter; // 0x28
	public string ResourceFolder; // 0x30
	public int TargetCount; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	public int MinDistanceSameType; // 0x3C
	public int MinDistanceDifferentType; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xDA090 Offset: 0xD9490 VA: 0x1800DA090
	public int MinWorldSize; // 0x44
	[TooltipAttribute] // RVA: 0xDA2C0 Offset: 0xD96C0 VA: 0x1800DA2C0
	public PlaceMonuments.DistanceMode DistanceSameType; // 0x48
	[TooltipAttribute] // RVA: 0xDA340 Offset: 0xD9740 VA: 0x1800DA340
	public PlaceMonuments.DistanceMode DistanceDifferentType; // 0x4C
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private const int Attempts = 10000;
	private const int MaxDepth = 100000;


	public override void Process(uint seed) { }

	private PlaceMonuments.DistanceInfo GetDistanceInfo(List<PlaceMonuments.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale, Vector3 dungeonPos) { }

	public void .ctor() { }

}

private struct PlaceMonuments.SpawnInfo // TypeDefIndex: 10542
{	public Prefab<MonumentInfo> prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24
	public bool dungeonEntrance; // 0x30
	public Vector3 dungeonEntrancePos; // 0x34

}

private struct PlaceMonuments.DistanceInfo // TypeDefIndex: 10543
{	public float minDistanceSameType; // 0x0
	public float maxDistanceSameType; // 0x4
	public float minDistanceDifferentType; // 0x8
	public float maxDistanceDifferentType; // 0xC
	public float minDistanceDungeonEntrance; // 0x10
	public float maxDistanceDungeonEntrance; // 0x14

}

public enum PlaceMonuments.DistanceMode // TypeDefIndex: 10544
{	public int value__; // 0x0
	public const PlaceMonuments.DistanceMode Any = 0;
	public const PlaceMonuments.DistanceMode Min = 1;
	public const PlaceMonuments.DistanceMode Max = 2;

}

private sealed class PlaceMonuments.<>c // TypeDefIndex: 10545
{	public static readonly PlaceMonuments.<>c <>9; // 0x0
	public static Func<string, string> <>9__15_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Process>b__15_0(string folder) { }

}

