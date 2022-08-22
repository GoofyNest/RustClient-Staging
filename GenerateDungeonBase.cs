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

	// RVA: 0xC4E610 Offset: 0xC4CC10 VA: 0x180C4E610 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0xC4B5A0 Offset: 0xC49BA0 VA: 0x180C4B5A0
	private Quaternion[] GetRotationList(DungeonBaseSocketType type) { }

	// RVA: 0xC4B5C0 Offset: 0xC49BC0 VA: 0x180C4B5C0
	private int GetSocketFloor(DungeonBaseSocketType type) { }

	// RVA: 0xC4C910 Offset: 0xC4AF10 VA: 0x180C4C910
	private bool IsFullyOccupied(List<GenerateDungeonBase.DungeonSegment> segments, GenerateDungeonBase.DungeonSegment segment) { }

	// RVA: 0xC4CE40 Offset: 0xC4B440 VA: 0x180C4CE40
	private bool NeighbourMatches(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseTransition transition, Vector3 transitionPos, Quaternion transitionRot) { }

	// RVA: 0xC4F0F0 Offset: 0xC4D6F0 VA: 0x180C4F0F0
	private int SocketMatches(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link, Vector3 linkPos, Quaternion linkRot) { }

	// RVA: 0xC4C9C0 Offset: 0xC4AFC0 VA: 0x180C4C9C0
	private bool IsOccupied(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseSocket socket, Vector3 socketPos, Quaternion socketRot) { }

	// RVA: 0xC4B380 Offset: 0xC49980 VA: 0x180C4B380
	private int CountLocal(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link) { }

	// RVA: 0xC4AFD0 Offset: 0xC495D0 VA: 0x180C4AFD0
	private int CountGlobal(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link) { }

	// RVA: 0xC4B5D0 Offset: 0xC49BD0 VA: 0x180C4B5D0
	private bool IsBlocked(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link, Vector3 linkPos, Quaternion linkRot) { }

	// RVA: 0xC4D400 Offset: 0xC4BA00 VA: 0x180C4D400
	private void PlaceSegments(ref uint seed, int count, int budget, int floors, bool attachToFemale, bool attachToMale, List<GenerateDungeonBase.DungeonSegment> segments, Prefab<DungeonBaseLink>[] prefabs) { }

	// RVA: 0xC4DAB0 Offset: 0xC4C0B0 VA: 0x180C4DAB0
	private void PlaceTransitions(ref uint seed, List<GenerateDungeonBase.DungeonSegment> segments, Prefab<DungeonBaseTransition>[] prefabs) { }

	// RVA: 0xC4DF20 Offset: 0xC4C520 VA: 0x180C4DF20
	private bool Place(ref uint seed, List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseSocket targetSocket, Vector3 targetPos, Quaternion targetRot, Prefab<DungeonBaseLink> prefab, Quaternion[] rotations, out DungeonBaseSocket linkSocket, out Vector3 linkPos, out Quaternion linkRot, out int linkScore) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void SetupAI() { }

	// RVA: 0xC4F860 Offset: 0xC4DE60 VA: 0x180C4F860
	public void .ctor() { }

	// RVA: 0xC4F770 Offset: 0xC4DD70 VA: 0x180C4F770
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

	// RVA: 0xC64020 Offset: 0xC62620 VA: 0x180C64020
	internal float <Process>b__0(GenerateDungeonBase.DungeonSegment x) { }

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_1 // TypeDefIndex: 10459
{	// Fields
	public GenerateDungeonBase.DungeonSegment segmentEnd; // 0x10
	public GenerateDungeonBase.<>c__DisplayClass14_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64100 Offset: 0xC62700 VA: 0x180C64100
	internal float <Process>b__1(GenerateDungeonBase.DungeonSegment x) { }

}

