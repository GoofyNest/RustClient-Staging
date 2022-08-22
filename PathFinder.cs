public class PathFinder // TypeDefIndex: 11395
{	// Fields
	private int[,] costmap; // 0x10
	private int[,] visited; // 0x18
	private PathFinder.Point[] neighbors; // 0x20
	private bool directional; // 0x28
	public PathFinder.Point PushPoint; // 0x2C
	public int PushRadius; // 0x34
	public int PushDistance; // 0x38
	public int PushMultiplier; // 0x3C
	private static PathFinder.Point[] mooreNeighbors; // 0x0
	private static PathFinder.Point[] neumannNeighbors; // 0x8

	// Methods

	// RVA: 0x860C10 Offset: 0x85F210 VA: 0x180860C10
	public void .ctor(int[,] costmap, bool diagonals = True, bool directional = True) { }

	// RVA: 0x8605B0 Offset: 0x85EBB0 VA: 0x1808605B0
	public int GetResolution(int index) { }

	// RVA: 0x860590 Offset: 0x85EB90 VA: 0x180860590
	public PathFinder.Node FindPath(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	// RVA: 0x8600B0 Offset: 0x85E6B0 VA: 0x1808600B0
	private PathFinder.Node FindPathReversed(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	// RVA: 0x85FB10 Offset: 0x85E110 VA: 0x18085FB10
	public PathFinder.Node FindPathDirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x8604F0 Offset: 0x85EAF0 VA: 0x1808604F0
	public PathFinder.Node FindPathUndirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x85FBA0 Offset: 0x85E1A0 VA: 0x18085FBA0
	private PathFinder.Node FindPathReversed(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x85F760 Offset: 0x85DD60 VA: 0x18085F760
	public PathFinder.Node FindClosestWalkable(PathFinder.Point start, int depth = 2147483647) { }

	// RVA: 0x860890 Offset: 0x85EE90 VA: 0x180860890
	public bool IsWalkable(PathFinder.Point point) { }

	// RVA: 0x860740 Offset: 0x85ED40 VA: 0x180860740
	public bool IsWalkableWithNeighbours(PathFinder.Point point) { }

	// RVA: 0x860900 Offset: 0x85EF00 VA: 0x180860900
	public PathFinder.Node Reverse(PathFinder.Node start) { }

	// RVA: 0x85FAF0 Offset: 0x85E0F0 VA: 0x18085FAF0
	public PathFinder.Node FindEnd(PathFinder.Node start) { }

	// RVA: 0x85F510 Offset: 0x85DB10 VA: 0x18085F510
	public int Cost(PathFinder.Point a) { }

	// RVA: 0x85F640 Offset: 0x85DC40 VA: 0x18085F640
	public int Cost(PathFinder.Point a, PathFinder.Node neighbour) { }

	// RVA: 0x8605F0 Offset: 0x85EBF0 VA: 0x1808605F0
	public int Heuristic(PathFinder.Point a) { }

	// RVA: 0x8605D0 Offset: 0x85EBD0 VA: 0x1808605D0
	public int Heuristic(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x860660 Offset: 0x85EC60 VA: 0x180860660
	public int Heuristic(PathFinder.Point a, List<PathFinder.Point> b) { }

	// RVA: 0x85F6D0 Offset: 0x85DCD0 VA: 0x18085F6D0
	public float Distance(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x860960 Offset: 0x85EF60 VA: 0x180860960
	private static void .cctor() { }

}

public struct PathFinder.Point : IEquatable<PathFinder.Point> // TypeDefIndex: 11396
{	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int x, int y) { }

	// RVA: 0x8753D0 Offset: 0x8739D0 VA: 0x1808753D0
	public static PathFinder.Point op_Addition(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x875470 Offset: 0x873A70 VA: 0x180875470
	public static PathFinder.Point op_Subtraction(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x875450 Offset: 0x873A50 VA: 0x180875450
	public static PathFinder.Point op_Multiply(PathFinder.Point p, int i) { }

	// RVA: 0x8753F0 Offset: 0x8739F0 VA: 0x1808753F0
	public static PathFinder.Point op_Division(PathFinder.Point p, int i) { }

	// RVA: 0x875410 Offset: 0x873A10 VA: 0x180875410
	public static bool op_Equality(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x875430 Offset: 0x873A30 VA: 0x180875430
	public static bool op_Inequality(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0xF94C0 Offset: 0xF88C0 VA: 0x1800F94C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF9410 Offset: 0xF8810 VA: 0x1800F9410 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF94A0 Offset: 0xF88A0 VA: 0x1800F94A0 Slot: 4
	public bool Equals(PathFinder.Point other) { }

}

public class PathFinder.Node : IMinHeapNode<PathFinder.Node>, ILinkedListNode<PathFinder.Node> // TypeDefIndex: 11397
{	// Fields
	public PathFinder.Point point; // 0x10
	public int cost; // 0x18
	public int heuristic; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PathFinder.Node <next>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PathFinder.Node <child>k__BackingField; // 0x28

	// Properties
	public PathFinder.Node next { get; set; }
	public PathFinder.Node child { get; set; }
	public int order { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 7
	public PathFinder.Node get_next() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 8
	public void set_next(PathFinder.Node value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 4
	public PathFinder.Node get_child() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450 Slot: 5
	public void set_child(PathFinder.Node value) { }

	// RVA: 0x79B650 Offset: 0x799C50 VA: 0x18079B650 Slot: 6
	public int get_order() { }

	// RVA: 0x8595B0 Offset: 0x857BB0 VA: 0x1808595B0
	public void .ctor(PathFinder.Point point, int cost, int heuristic, PathFinder.Node next) { }

}

