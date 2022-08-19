public class GenerateRoadLayout : ProceduralComponent // TypeDefIndex: 10506
{	// Fields
	public InfrastructureType RoadType; // 0x28
	public const float RoadWidth = 10;
	public const float TrailWidth = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 8;
	public const float RandomScale = 0,75;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private const int MaxDepth = 100000;

	// Methods

	// RVA: 0xC92F50 Offset: 0xC91550 VA: 0x180C92F50
	private PathList CreateSegment(int number, Vector3[] points) { }

	// RVA: 0xC930B0 Offset: 0xC916B0 VA: 0x180C930B0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x57BC40 Offset: 0x57A240 VA: 0x18057BC40
	public void .ctor() { }

}

private class GenerateRoadLayout.PathNode // TypeDefIndex: 10507
{	// Fields
	public MonumentInfo monument; // 0x10
	public TerrainPathConnect target; // 0x18
	public PathFinder.Node node; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class GenerateRoadLayout.PathSegment // TypeDefIndex: 10508
{	// Fields
	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18
	public TerrainPathConnect origin; // 0x20
	public TerrainPathConnect target; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_0 // TypeDefIndex: 10509
{	// Fields
	public GenerateRoadLayout.PathSegment segment; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA75B0 Offset: 0xCA5BB0 VA: 0x180CA75B0
	internal bool <Process>b__7(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA75B0 Offset: 0xCA5BB0 VA: 0x180CA75B0
	internal bool <Process>b__10(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_1 // TypeDefIndex: 10510
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7640 Offset: 0xCA5C40 VA: 0x180CA7640
	internal bool <Process>b__3(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA76C0 Offset: 0xCA5CC0 VA: 0x180CA76C0
	internal bool <Process>b__4(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_2 // TypeDefIndex: 10511
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7740 Offset: 0xCA5D40 VA: 0x180CA7740
	internal bool <Process>b__5(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA77C0 Offset: 0xCA5DC0 VA: 0x180CA77C0
	internal bool <Process>b__6(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_3 // TypeDefIndex: 10512
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7840 Offset: 0xCA5E40 VA: 0x180CA7840
	internal bool <Process>b__8(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA78C0 Offset: 0xCA5EC0 VA: 0x180CA78C0
	internal bool <Process>b__9(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_4 // TypeDefIndex: 10513
{	// Fields
	public GenerateRoadLayout.PathNode target; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7940 Offset: 0xCA5F40 VA: 0x180CA7940
	internal bool <Process>b__11(GenerateRoadLayout.PathSegment x) { }

}

private sealed class GenerateRoadLayout.<>c // TypeDefIndex: 10514
{	// Fields
	public static readonly GenerateRoadLayout.<>c <>9; // 0x0
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_0; // 0x8
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_1; // 0x10
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_2; // 0x18

	// Methods

	// RVA: 0xCA7E30 Offset: 0xCA6430 VA: 0x180CA7E30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA73A0 Offset: 0xCA59A0 VA: 0x180CA73A0
	internal PathFinder.Point <Process>b__14_0(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA73A0 Offset: 0xCA59A0 VA: 0x180CA73A0
	internal PathFinder.Point <Process>b__14_1(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA73A0 Offset: 0xCA59A0 VA: 0x180CA73A0
	internal PathFinder.Point <Process>b__14_2(GenerateRoadLayout.PathNode x) { }

}

