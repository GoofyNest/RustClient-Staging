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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0xC501E0 Offset: 0xC4E7E0 VA: 0x180C501E0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0xC56830 Offset: 0xC54E30 VA: 0x180C56830
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

	// RVA: 0xC5CA90 Offset: 0xC5B090 VA: 0x180C5CA90
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

	// RVA: 0xC5CA10 Offset: 0xC5B010 VA: 0x180C5CA10
	public Transform get_downSocket() { }

	// RVA: 0xC5CA50 Offset: 0xC5B050 VA: 0x180C5CA50
	public Transform get_upSocket() { }

	// RVA: 0xC5CA30 Offset: 0xC5B030 VA: 0x180C5CA30
	public DungeonGridLinkType get_downType() { }

	// RVA: 0xC5CA70 Offset: 0xC5B070 VA: 0x180C5CA70
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

	// RVA: 0xC647C0 Offset: 0xC62DC0 VA: 0x180C647C0
	internal void <Process>g__AddNode|1(int x, int y, ref GenerateDungeonGrid.<>c__DisplayClass17_0 , ref GenerateDungeonGrid.<>c__DisplayClass17_1 , ref GenerateDungeonGrid.<>c__DisplayClass17_3 ) { }

	// RVA: 0xC64780 Offset: 0xC62D80 VA: 0x180C64780
	internal bool <Process>b__2(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64780 Offset: 0xC62D80 VA: 0x180C64780
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

	// RVA: 0xC64BF0 Offset: 0xC631F0 VA: 0x180C64BF0
	internal bool <Process>b__11(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64BF0 Offset: 0xC631F0 VA: 0x180C64BF0
	internal bool <Process>b__14(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_5 // TypeDefIndex: 10471
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64C80 Offset: 0xC63280 VA: 0x180C64C80
	internal bool <Process>b__7(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64D00 Offset: 0xC63300 VA: 0x180C64D00
	internal bool <Process>b__8(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_6 // TypeDefIndex: 10472
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64E00 Offset: 0xC63400 VA: 0x180C64E00
	internal bool <Process>b__9(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64D80 Offset: 0xC63380 VA: 0x180C64D80
	internal bool <Process>b__10(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_7 // TypeDefIndex: 10473
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64E80 Offset: 0xC63480 VA: 0x180C64E80
	internal bool <Process>b__12(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64F00 Offset: 0xC63500 VA: 0x180C64F00
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

	// RVA: 0xC656F0 Offset: 0xC63CF0 VA: 0x180C656F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64350 Offset: 0xC62950 VA: 0x180C64350
	internal int <Process>b__17_0(Prefab<DungeonGridLink> x) { }

	// RVA: 0xC64370 Offset: 0xC62970 VA: 0x180C64370
	internal PathFinder.Point <Process>b__17_4(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64370 Offset: 0xC62970 VA: 0x180C64370
	internal PathFinder.Point <Process>b__17_5(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xC64370 Offset: 0xC62970 VA: 0x180C64370
	internal PathFinder.Point <Process>b__17_6(GenerateDungeonGrid.PathNode x) { }

}

