public class PlaceMonuments : ProceduralComponent // TypeDefIndex: 10537
{	// Fields
	public SpawnFilter Filter; // 0x28
	public string ResourceFolder; // 0x30
	public int TargetCount; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xDA270 Offset: 0xD9670 VA: 0x1800DA270
	public int MinDistanceSameType; // 0x3C
	public int MinDistanceDifferentType; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xDA320 Offset: 0xD9720 VA: 0x1800DA320
	public int MinWorldSize; // 0x44
	[TooltipAttribute] // RVA: 0xDA610 Offset: 0xD9A10 VA: 0x1800DA610
	public PlaceMonuments.DistanceMode DistanceSameType; // 0x48
	[TooltipAttribute] // RVA: 0xDA6F0 Offset: 0xD9AF0 VA: 0x1800DA6F0
	public PlaceMonuments.DistanceMode DistanceDifferentType; // 0x4C
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private const int Attempts = 10000;
	private const int MaxDepth = 100000;

	// Methods

	// RVA: 0x917D20 Offset: 0x916320 VA: 0x180917D20 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x917110 Offset: 0x915710 VA: 0x180917110
	private PlaceMonuments.DistanceInfo GetDistanceInfo(List<PlaceMonuments.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale, Vector3 dungeonPos) { }

	// RVA: 0x919490 Offset: 0x917A90 VA: 0x180919490
	public void .ctor() { }

}

private struct PlaceMonuments.SpawnInfo // TypeDefIndex: 10538
{	// Fields
	public Prefab<MonumentInfo> prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24
	public bool dungeonEntrance; // 0x30
	public Vector3 dungeonEntrancePos; // 0x34

}

private struct PlaceMonuments.DistanceInfo // TypeDefIndex: 10539
{	// Fields
	public float minDistanceSameType; // 0x0
	public float maxDistanceSameType; // 0x4
	public float minDistanceDifferentType; // 0x8
	public float maxDistanceDifferentType; // 0xC
	public float minDistanceDungeonEntrance; // 0x10
	public float maxDistanceDungeonEntrance; // 0x14

}

public enum PlaceMonuments.DistanceMode // TypeDefIndex: 10540
{	// Fields
	public int value__; // 0x0
	public const PlaceMonuments.DistanceMode Any = 0;
	public const PlaceMonuments.DistanceMode Min = 1;
	public const PlaceMonuments.DistanceMode Max = 2;

}

private sealed class PlaceMonuments.<>c // TypeDefIndex: 10541
{	// Fields
	public static readonly PlaceMonuments.<>c <>9; // 0x0
	public static Func<string, string> <>9__15_0; // 0x8

	// Methods

	// RVA: 0x921110 Offset: 0x91F710 VA: 0x180921110
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x920D20 Offset: 0x91F320 VA: 0x180920D20
	internal string <Process>b__15_0(string folder) { }

}

