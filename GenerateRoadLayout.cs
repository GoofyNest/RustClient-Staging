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

	// RVA: 0xC93210 Offset: 0xC91810 VA: 0x180C93210
	private PathList CreateSegment(int number, Vector3[] points) { }

	// RVA: 0xC93370 Offset: 0xC91970 VA: 0x180C93370 Slot: 5
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

	// RVA: 0xCA7870 Offset: 0xCA5E70 VA: 0x180CA7870
	internal bool <Process>b__7(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7870 Offset: 0xCA5E70 VA: 0x180CA7870
	internal bool <Process>b__10(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_1 // TypeDefIndex: 10510
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7900 Offset: 0xCA5F00 VA: 0x180CA7900
	internal bool <Process>b__3(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7980 Offset: 0xCA5F80 VA: 0x180CA7980
	internal bool <Process>b__4(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_2 // TypeDefIndex: 10511
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7A00 Offset: 0xCA6000 VA: 0x180CA7A00
	internal bool <Process>b__5(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7A80 Offset: 0xCA6080 VA: 0x180CA7A80
	internal bool <Process>b__6(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_3 // TypeDefIndex: 10512
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7B00 Offset: 0xCA6100 VA: 0x180CA7B00
	internal bool <Process>b__8(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7B80 Offset: 0xCA6180 VA: 0x180CA7B80
	internal bool <Process>b__9(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_4 // TypeDefIndex: 10513
{	// Fields
	public GenerateRoadLayout.PathNode target; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7C00 Offset: 0xCA6200 VA: 0x180CA7C00
	internal bool <Process>b__11(GenerateRoadLayout.PathSegment x) { }

}

private sealed class GenerateRoadLayout.<>c // TypeDefIndex: 10514
{	// Fields
	public static readonly GenerateRoadLayout.<>c <>9; // 0x0
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_0; // 0x8
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_1; // 0x10
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_2; // 0x18

	// Methods

	// RVA: 0xCA80F0 Offset: 0xCA66F0 VA: 0x180CA80F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7660 Offset: 0xCA5C60 VA: 0x180CA7660
	internal PathFinder.Point <Process>b__14_0(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7660 Offset: 0xCA5C60 VA: 0x180CA7660
	internal PathFinder.Point <Process>b__14_1(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7660 Offset: 0xCA5C60 VA: 0x180CA7660
	internal PathFinder.Point <Process>b__14_2(GenerateRoadLayout.PathNode x) { }

}

