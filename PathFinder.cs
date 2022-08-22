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

	// RVA: 0x87C370 Offset: 0x87A970 VA: 0x18087C370
	public void .ctor(int[,] costmap, bool diagonals = True, bool directional = True) { }

	// RVA: 0x87BD10 Offset: 0x87A310 VA: 0x18087BD10
	public int GetResolution(int index) { }

	// RVA: 0x87BCF0 Offset: 0x87A2F0 VA: 0x18087BCF0
	public PathFinder.Node FindPath(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	// RVA: 0x87B810 Offset: 0x879E10 VA: 0x18087B810
	private PathFinder.Node FindPathReversed(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	// RVA: 0x87B270 Offset: 0x879870 VA: 0x18087B270
	public PathFinder.Node FindPathDirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x87BC50 Offset: 0x87A250 VA: 0x18087BC50
	public PathFinder.Node FindPathUndirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x87B300 Offset: 0x879900 VA: 0x18087B300
	private PathFinder.Node FindPathReversed(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x87AEC0 Offset: 0x8794C0 VA: 0x18087AEC0
	public PathFinder.Node FindClosestWalkable(PathFinder.Point start, int depth = 2147483647) { }

	// RVA: 0x87BFF0 Offset: 0x87A5F0 VA: 0x18087BFF0
	public bool IsWalkable(PathFinder.Point point) { }

	// RVA: 0x87BEA0 Offset: 0x87A4A0 VA: 0x18087BEA0
	public bool IsWalkableWithNeighbours(PathFinder.Point point) { }

	// RVA: 0x87C060 Offset: 0x87A660 VA: 0x18087C060
	public PathFinder.Node Reverse(PathFinder.Node start) { }

	// RVA: 0x87B250 Offset: 0x879850 VA: 0x18087B250
	public PathFinder.Node FindEnd(PathFinder.Node start) { }

	// RVA: 0x87AC70 Offset: 0x879270 VA: 0x18087AC70
	public int Cost(PathFinder.Point a) { }

	// RVA: 0x87ADA0 Offset: 0x8793A0 VA: 0x18087ADA0
	public int Cost(PathFinder.Point a, PathFinder.Node neighbour) { }

	// RVA: 0x87BD50 Offset: 0x87A350 VA: 0x18087BD50
	public int Heuristic(PathFinder.Point a) { }

	// RVA: 0x87BD30 Offset: 0x87A330 VA: 0x18087BD30
	public int Heuristic(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x87BDC0 Offset: 0x87A3C0 VA: 0x18087BDC0
	public int Heuristic(PathFinder.Point a, List<PathFinder.Point> b) { }

	// RVA: 0x87AE30 Offset: 0x879430 VA: 0x18087AE30
	public float Distance(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x87C0C0 Offset: 0x87A6C0 VA: 0x18087C0C0
	private static void .cctor() { }

}

public struct PathFinder.Point : IEquatable<PathFinder.Point> // TypeDefIndex: 11396
{	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int x, int y) { }

	// RVA: 0x890AF0 Offset: 0x88F0F0 VA: 0x180890AF0
	public static PathFinder.Point op_Addition(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x890B90 Offset: 0x88F190 VA: 0x180890B90
	public static PathFinder.Point op_Subtraction(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x890B70 Offset: 0x88F170 VA: 0x180890B70
	public static PathFinder.Point op_Multiply(PathFinder.Point p, int i) { }

	// RVA: 0x890B10 Offset: 0x88F110 VA: 0x180890B10
	public static PathFinder.Point op_Division(PathFinder.Point p, int i) { }

	// RVA: 0x890B30 Offset: 0x88F130 VA: 0x180890B30
	public static bool op_Equality(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x890B50 Offset: 0x88F150 VA: 0x180890B50
	public static bool op_Inequality(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0xF9D10 Offset: 0xF9110 VA: 0x1800F9D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF9C60 Offset: 0xF9060 VA: 0x1800F9C60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF9CF0 Offset: 0xF90F0 VA: 0x1800F9CF0 Slot: 4
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
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 4
	public PathFinder.Node get_child() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0 Slot: 5
	public void set_child(PathFinder.Node value) { }

	// RVA: 0x79B560 Offset: 0x799B60 VA: 0x18079B560 Slot: 6
	public int get_order() { }

	// RVA: 0x874D10 Offset: 0x873310 VA: 0x180874D10
	public void .ctor(PathFinder.Point point, int cost, int heuristic, PathFinder.Node next) { }

}

