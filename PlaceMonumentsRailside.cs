public class PlaceMonumentsRailside : ProceduralComponent // TypeDefIndex: 10545
{	// Fields
	public SpawnFilter Filter; // 0x28
	public string ResourceFolder; // 0x30
	public int TargetCount; // 0x38
	public int PositionOffset; // 0x3C
	public int TangentInterval; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xDA270 Offset: 0xD9670 VA: 0x1800DA270
	public int MinDistanceSameType; // 0x44
	public int MinDistanceDifferentType; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0xDA320 Offset: 0xD9720 VA: 0x1800DA320
	public int MinWorldSize; // 0x4C
	[TooltipAttribute] // RVA: 0xDA610 Offset: 0xD9A10 VA: 0x1800DA610
	public PlaceMonumentsRailside.DistanceMode DistanceSameType; // 0x50
	[TooltipAttribute] // RVA: 0xDA6F0 Offset: 0xD9AF0 VA: 0x1800DA6F0
	public PlaceMonumentsRailside.DistanceMode DistanceDifferentType; // 0x54
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private static Quaternion rot90; // 0x0

	// Methods

	// RVA: 0x912A30 Offset: 0x911030 VA: 0x180912A30 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x911FC0 Offset: 0x9105C0 VA: 0x180911FC0
	private PlaceMonumentsRailside.DistanceInfo GetDistanceInfo(List<PlaceMonumentsRailside.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale) { }

	// RVA: 0x914620 Offset: 0x912C20 VA: 0x180914620
	public void .ctor() { }

	// RVA: 0x9145A0 Offset: 0x912BA0 VA: 0x1809145A0
	private static void .cctor() { }

}

private struct PlaceMonumentsRailside.SpawnInfo // TypeDefIndex: 10546
{	// Fields
	public Prefab<MonumentInfo> prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

private class PlaceMonumentsRailside.SpawnInfoGroup // TypeDefIndex: 10547
{	// Fields
	public bool processed; // 0x10
	public Prefab<MonumentInfo> prefab; // 0x18
	public List<PlaceMonumentsRailside.SpawnInfo> candidates; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct PlaceMonumentsRailside.DistanceInfo // TypeDefIndex: 10548
{	// Fields
	public float minDistanceSameType; // 0x0
	public float maxDistanceSameType; // 0x4
	public float minDistanceDifferentType; // 0x8
	public float maxDistanceDifferentType; // 0xC

}

public enum PlaceMonumentsRailside.DistanceMode // TypeDefIndex: 10549
{	// Fields
	public int value__; // 0x0
	public const PlaceMonumentsRailside.DistanceMode Any = 0;
	public const PlaceMonumentsRailside.DistanceMode Min = 1;
	public const PlaceMonumentsRailside.DistanceMode Max = 2;

}

private sealed class PlaceMonumentsRailside.<>c // TypeDefIndex: 10550
{	// Fields
	public static readonly PlaceMonumentsRailside.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x920CC0 Offset: 0x91F2C0 VA: 0x180920CC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x920860 Offset: 0x91EE60 VA: 0x180920860
	internal string <Process>b__17_0(string folder) { }

}

