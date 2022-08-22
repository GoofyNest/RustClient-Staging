public class GenerateDungeonGrid : ProceduralComponent // TypeDefIndex: 10460
{	// Fields
	public string TunnelFolder; // 0x28
	public string StationFolder; // 0x30
	public string TransitionFolder; // 0x38
	public string LinkFolder; // 0x40
	public InfrastructureType ConnectionType; // 0x48
	public int CellSize; // 0x4C
	public float LinkHeight; // 0x50
	public float LinkRadius; // 0x54
	public float LinkTransition; // 0x58
	private const int MaxDepth = 100000;

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0xC4FD10 Offset: 0xC4E310 VA: 0x180C4FD10 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0xC56360 Offset: 0xC54960 VA: 0x180C56360
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathNode // TypeDefIndex: 10461
{	// Fields
	public MonumentInfo monument; // 0x10
	public PathFinder.Node node; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathSegment // TypeDefIndex: 10462
{	// Fields
	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLink // TypeDefIndex: 10463
{	// Fields
	public GenerateDungeonGrid.PathLinkSide downwards; // 0x10
	public GenerateDungeonGrid.PathLinkSide upwards; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLinkSide // TypeDefIndex: 10464
{	// Fields
	public GenerateDungeonGrid.PathLinkSegment origin; // 0x10
	public List<GenerateDungeonGrid.PathLinkSegment> segments; // 0x18

	// Properties
	public GenerateDungeonGrid.PathLinkSegment prevSegment { get; }

	// Methods

	// RVA: 0xC5C5C0 Offset: 0xC5ABC0 VA: 0x180C5C5C0
	public GenerateDungeonGrid.PathLinkSegment get_prevSegment() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLinkSegment // TypeDefIndex: 10465
{	// Fields
	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C
	public Vector3 scale; // 0x2C
	public Prefab<DungeonGridLink> prefab; // 0x38
	public DungeonGridLink link; // 0x40

	// Properties
	public Transform downSocket { get; }
	public Transform upSocket { get; }
	public DungeonGridLinkType downType { get; }
	public DungeonGridLinkType upType { get; }

	// Methods

	// RVA: 0xC5C540 Offset: 0xC5AB40 VA: 0x180C5C540
	public Transform get_downSocket() { }

	// RVA: 0xC5C580 Offset: 0xC5AB80 VA: 0x180C5C580
	public Transform get_upSocket() { }

	// RVA: 0xC5C560 Offset: 0xC5AB60 VA: 0x180C5C560
	public DungeonGridLinkType get_downType() { }

	// RVA: 0xC5C5A0 Offset: 0xC5ABA0 VA: 0x180C5C5A0
	public DungeonGridLinkType get_upType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_0 // TypeDefIndex: 10466
{	// Fields
	public PathFinder pathFinder; // 0x0
	public List<GenerateDungeonGrid.PathNode> secondaryNodeList; // 0x8
	public List<GenerateDungeonGrid.PathNode> unconnectedNodeList; // 0x10
	public DungeonGridConnectionHash[,] hashmap; // 0x18

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_1 // TypeDefIndex: 10467
{	// Fields
	public DungeonGridInfo entrance; // 0x0

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_2 // TypeDefIndex: 10468
{	// Fields
	public PathFinder.Node stationNode; // 0x10
	public GenerateDungeonGrid <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC642F0 Offset: 0xC628F0 VA: 0x180C642F0
	internal void <Process>g__AddNode|1(int x, int y, ref GenerateDungeonGrid.<>c__DisplayClass17_0 , ref GenerateDungeonGrid.<>c__DisplayClass17_1 , ref GenerateDungeonGrid.<>c__DisplayClass17_3 ) { }

	// RVA: 0xC642B0 Offset: 0xC628B0 VA: 0x180C642B0
	internal bool <Process>b__2(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC642B0 Offset: 0xC628B0 VA: 0x180C642B0
	internal bool <Process>b__3(GenerateDungeonGrid.PathNode x) { }

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_3 // TypeDefIndex: 10469
{	// Fields
	public bool isStartPoint; // 0x0

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_4 // TypeDefIndex: 10470
{	// Fields
	public GenerateDungeonGrid.PathSegment segment; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64720 Offset: 0xC62D20 VA: 0x180C64720
	internal bool <Process>b__11(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64720 Offset: 0xC62D20 VA: 0x180C64720
	internal bool <Process>b__14(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_5 // TypeDefIndex: 10471
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC647B0 Offset: 0xC62DB0 VA: 0x180C647B0
	internal bool <Process>b__7(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64830 Offset: 0xC62E30 VA: 0x180C64830
	internal bool <Process>b__8(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_6 // TypeDefIndex: 10472
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64930 Offset: 0xC62F30 VA: 0x180C64930
	internal bool <Process>b__9(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC648B0 Offset: 0xC62EB0 VA: 0x180C648B0
	internal bool <Process>b__10(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_7 // TypeDefIndex: 10473
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC649B0 Offset: 0xC62FB0 VA: 0x180C649B0
	internal bool <Process>b__12(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64A30 Offset: 0xC63030 VA: 0x180C64A30
	internal bool <Process>b__13(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c // TypeDefIndex: 10474
{	// Fields
	public static readonly GenerateDungeonGrid.<>c <>9; // 0x0
	public static Func<Prefab<DungeonGridLink>, int> <>9__17_0; // 0x8
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_4; // 0x10
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_5; // 0x18
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_6; // 0x20

	// Methods

	// RVA: 0xC65220 Offset: 0xC63820 VA: 0x180C65220
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC63E80 Offset: 0xC62480 VA: 0x180C63E80
	internal int <Process>b__17_0(Prefab<DungeonGridLink> x) { }

	// RVA: 0xC63EA0 Offset: 0xC624A0 VA: 0x180C63EA0
	internal PathFinder.Point <Process>b__17_4(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC63EA0 Offset: 0xC624A0 VA: 0x180C63EA0
	internal PathFinder.Point <Process>b__17_5(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC63EA0 Offset: 0xC624A0 VA: 0x180C63EA0
	internal PathFinder.Point <Process>b__17_6(GenerateDungeonGrid.PathNode x) { }

}

