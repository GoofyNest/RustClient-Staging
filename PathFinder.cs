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

	// RVA: 0x860B00 Offset: 0x85F100 VA: 0x180860B00
	public void .ctor(int[,] costmap, bool diagonals = True, bool directional = True) { }

	// RVA: 0x8604A0 Offset: 0x85EAA0 VA: 0x1808604A0
	public int GetResolution(int index) { }

	// RVA: 0x860480 Offset: 0x85EA80 VA: 0x180860480
	public PathFinder.Node FindPath(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	// RVA: 0x85FFA0 Offset: 0x85E5A0 VA: 0x18085FFA0
	private PathFinder.Node FindPathReversed(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	// RVA: 0x85FA00 Offset: 0x85E000 VA: 0x18085FA00
	public PathFinder.Node FindPathDirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x8603E0 Offset: 0x85E9E0 VA: 0x1808603E0
	public PathFinder.Node FindPathUndirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x85FA90 Offset: 0x85E090 VA: 0x18085FA90
	private PathFinder.Node FindPathReversed(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x85F650 Offset: 0x85DC50 VA: 0x18085F650
	public PathFinder.Node FindClosestWalkable(PathFinder.Point start, int depth = 2147483647) { }

	// RVA: 0x860780 Offset: 0x85ED80 VA: 0x180860780
	public bool IsWalkable(PathFinder.Point point) { }

	// RVA: 0x860630 Offset: 0x85EC30 VA: 0x180860630
	public bool IsWalkableWithNeighbours(PathFinder.Point point) { }

	// RVA: 0x8607F0 Offset: 0x85EDF0 VA: 0x1808607F0
	public PathFinder.Node Reverse(PathFinder.Node start) { }

	// RVA: 0x85F9E0 Offset: 0x85DFE0 VA: 0x18085F9E0
	public PathFinder.Node FindEnd(PathFinder.Node start) { }

	// RVA: 0x85F400 Offset: 0x85DA00 VA: 0x18085F400
	public int Cost(PathFinder.Point a) { }

	// RVA: 0x85F530 Offset: 0x85DB30 VA: 0x18085F530
	public int Cost(PathFinder.Point a, PathFinder.Node neighbour) { }

	// RVA: 0x8604E0 Offset: 0x85EAE0 VA: 0x1808604E0
	public int Heuristic(PathFinder.Point a) { }

	// RVA: 0x8604C0 Offset: 0x85EAC0 VA: 0x1808604C0
	public int Heuristic(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x860550 Offset: 0x85EB50 VA: 0x180860550
	public int Heuristic(PathFinder.Point a, List<PathFinder.Point> b) { }

	// RVA: 0x85F5C0 Offset: 0x85DBC0 VA: 0x18085F5C0
	public float Distance(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x860850 Offset: 0x85EE50 VA: 0x180860850
	private static void .cctor() { }

}

public struct PathFinder.Point : IEquatable<PathFinder.Point> // TypeDefIndex: 11396
{	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int x, int y) { }

	// RVA: 0x8752C0 Offset: 0x8738C0 VA: 0x1808752C0
	public static PathFinder.Point op_Addition(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x875360 Offset: 0x873960 VA: 0x180875360
	public static PathFinder.Point op_Subtraction(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x875340 Offset: 0x873940 VA: 0x180875340
	public static PathFinder.Point op_Multiply(PathFinder.Point p, int i) { }

	// RVA: 0x8752E0 Offset: 0x8738E0 VA: 0x1808752E0
	public static PathFinder.Point op_Division(PathFinder.Point p, int i) { }

	// RVA: 0x875300 Offset: 0x873900 VA: 0x180875300
	public static bool op_Equality(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x875320 Offset: 0x873920 VA: 0x180875320
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
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 4
	public PathFinder.Node get_child() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340 Slot: 5
	public void set_child(PathFinder.Node value) { }

	// RVA: 0x79B540 Offset: 0x799B40 VA: 0x18079B540 Slot: 6
	public int get_order() { }

	// RVA: 0x8594A0 Offset: 0x857AA0 VA: 0x1808594A0
	public void .ctor(PathFinder.Point point, int cost, int heuristic, PathFinder.Node next) { }

}

