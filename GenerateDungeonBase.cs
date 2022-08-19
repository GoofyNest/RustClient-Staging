public class GenerateDungeonBase : ProceduralComponent // TypeDefIndex: 10456
{	// Fields
	public string EntranceFolder; // 0x28
	public string LinkFolder; // 0x30
	public string EndFolder; // 0x38
	public string TransitionFolder; // 0x40
	public InfrastructureType ConnectionType; // 0x48
	private static Vector3 VolumeExtrudePositive; // 0x0
	private static Vector3 VolumeExtrudeNegative; // 0xC
	private const int MaxCount = 2147483647;
	private const int MaxDepth = 3;
	private const int MaxFloor = 2;
	private List<GenerateDungeonBase.DungeonSegment> segmentsTotal; // 0x50
	private Quaternion[] horizontalRotations; // 0x58
	private Quaternion[] pillarRotations; // 0x60
	private Quaternion[] verticalRotations; // 0x68

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0xC4E350 Offset: 0xC4C950 VA: 0x180C4E350 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0xC4B2E0 Offset: 0xC498E0 VA: 0x180C4B2E0
	private Quaternion[] GetRotationList(DungeonBaseSocketType type) { }

	// RVA: 0xC4B300 Offset: 0xC49900 VA: 0x180C4B300
	private int GetSocketFloor(DungeonBaseSocketType type) { }

	// RVA: 0xC4C650 Offset: 0xC4AC50 VA: 0x180C4C650
	private bool IsFullyOccupied(List<GenerateDungeonBase.DungeonSegment> segments, GenerateDungeonBase.DungeonSegment segment) { }

	// RVA: 0xC4CB80 Offset: 0xC4B180 VA: 0x180C4CB80
	private bool NeighbourMatches(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseTransition transition, Vector3 transitionPos, Quaternion transitionRot) { }

	// RVA: 0xC4EE30 Offset: 0xC4D430 VA: 0x180C4EE30
	private int SocketMatches(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link, Vector3 linkPos, Quaternion linkRot) { }

	// RVA: 0xC4C700 Offset: 0xC4AD00 VA: 0x180C4C700
	private bool IsOccupied(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseSocket socket, Vector3 socketPos, Quaternion socketRot) { }

	// RVA: 0xC4B0C0 Offset: 0xC496C0 VA: 0x180C4B0C0
	private int CountLocal(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link) { }

	// RVA: 0xC4AD10 Offset: 0xC49310 VA: 0x180C4AD10
	private int CountGlobal(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link) { }

	// RVA: 0xC4B310 Offset: 0xC49910 VA: 0x180C4B310
	private bool IsBlocked(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link, Vector3 linkPos, Quaternion linkRot) { }

	// RVA: 0xC4D140 Offset: 0xC4B740 VA: 0x180C4D140
	private void PlaceSegments(ref uint seed, int count, int budget, int floors, bool attachToFemale, bool attachToMale, List<GenerateDungeonBase.DungeonSegment> segments, Prefab<DungeonBaseLink>[] prefabs) { }

	// RVA: 0xC4D7F0 Offset: 0xC4BDF0 VA: 0x180C4D7F0
	private void PlaceTransitions(ref uint seed, List<GenerateDungeonBase.DungeonSegment> segments, Prefab<DungeonBaseTransition>[] prefabs) { }

	// RVA: 0xC4DC60 Offset: 0xC4C260 VA: 0x180C4DC60
	private bool Place(ref uint seed, List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseSocket targetSocket, Vector3 targetPos, Quaternion targetRot, Prefab<DungeonBaseLink> prefab, Quaternion[] rotations, out DungeonBaseSocket linkSocket, out Vector3 linkPos, out Quaternion linkRot, out int linkScore) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void SetupAI() { }

	// RVA: 0xC4F5A0 Offset: 0xC4DBA0 VA: 0x180C4F5A0
	public void .ctor() { }

	// RVA: 0xC4F4B0 Offset: 0xC4DAB0 VA: 0x180C4F4B0
	private static void .cctor() { }

}

private class GenerateDungeonBase.DungeonSegment // TypeDefIndex: 10457
{	// Fields
	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C
	public Prefab prefab; // 0x30
	public DungeonBaseLink link; // 0x38
	public int score; // 0x40
	public int cost; // 0x44
	public int floor; // 0x48

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_0 // TypeDefIndex: 10458
{	// Fields
	public GenerateDungeonBase.DungeonSegment segmentStart; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC63D60 Offset: 0xC62360 VA: 0x180C63D60
	internal float <Process>b__0(GenerateDungeonBase.DungeonSegment x) { }

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_1 // TypeDefIndex: 10459
{	// Fields
	public GenerateDungeonBase.DungeonSegment segmentEnd; // 0x10
	public GenerateDungeonBase.<>c__DisplayClass14_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC63E40 Offset: 0xC62440 VA: 0x180C63E40
	internal float <Process>b__1(GenerateDungeonBase.DungeonSegment x) { }

}

