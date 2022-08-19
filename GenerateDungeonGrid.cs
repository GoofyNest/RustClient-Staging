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

	// RVA: 0xC4FA50 Offset: 0xC4E050 VA: 0x180C4FA50 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0xC560A0 Offset: 0xC546A0 VA: 0x180C560A0
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

	// RVA: 0xC5C300 Offset: 0xC5A900 VA: 0x180C5C300
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

	// RVA: 0xC5C280 Offset: 0xC5A880 VA: 0x180C5C280
	public Transform get_downSocket() { }

	// RVA: 0xC5C2C0 Offset: 0xC5A8C0 VA: 0x180C5C2C0
	public Transform get_upSocket() { }

	// RVA: 0xC5C2A0 Offset: 0xC5A8A0 VA: 0x180C5C2A0
	public DungeonGridLinkType get_downType() { }

	// RVA: 0xC5C2E0 Offset: 0xC5A8E0 VA: 0x180C5C2E0
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

	// RVA: 0xC64030 Offset: 0xC62630 VA: 0x180C64030
	internal void <Process>g__AddNode|1(int x, int y, ref GenerateDungeonGrid.<>c__DisplayClass17_0 , ref GenerateDungeonGrid.<>c__DisplayClass17_1 , ref GenerateDungeonGrid.<>c__DisplayClass17_3 ) { }

	// RVA: 0xC63FF0 Offset: 0xC625F0 VA: 0x180C63FF0
	internal bool <Process>b__2(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC63FF0 Offset: 0xC625F0 VA: 0x180C63FF0
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

	// RVA: 0xC64460 Offset: 0xC62A60 VA: 0x180C64460
	internal bool <Process>b__11(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64460 Offset: 0xC62A60 VA: 0x180C64460
	internal bool <Process>b__14(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_5 // TypeDefIndex: 10471
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC644F0 Offset: 0xC62AF0 VA: 0x180C644F0
	internal bool <Process>b__7(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64570 Offset: 0xC62B70 VA: 0x180C64570
	internal bool <Process>b__8(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_6 // TypeDefIndex: 10472
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64670 Offset: 0xC62C70 VA: 0x180C64670
	internal bool <Process>b__9(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC645F0 Offset: 0xC62BF0 VA: 0x180C645F0
	internal bool <Process>b__10(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_7 // TypeDefIndex: 10473
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC646F0 Offset: 0xC62CF0 VA: 0x180C646F0
	internal bool <Process>b__12(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64770 Offset: 0xC62D70 VA: 0x180C64770
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

	// RVA: 0xC64F60 Offset: 0xC63560 VA: 0x180C64F60
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC63BC0 Offset: 0xC621C0 VA: 0x180C63BC0
	internal int <Process>b__17_0(Prefab<DungeonGridLink> x) { }

	// RVA: 0xC63BE0 Offset: 0xC621E0 VA: 0x180C63BE0
	internal PathFinder.Point <Process>b__17_4(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC63BE0 Offset: 0xC621E0 VA: 0x180C63BE0
	internal PathFinder.Point <Process>b__17_5(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC63BE0 Offset: 0xC621E0 VA: 0x180C63BE0
	internal PathFinder.Point <Process>b__17_6(GenerateDungeonGrid.PathNode x) { }

}

