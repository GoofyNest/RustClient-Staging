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

	// RVA: 0xC936B0 Offset: 0xC91CB0 VA: 0x180C936B0
	private PathList CreateSegment(int number, Vector3[] points) { }

	// RVA: 0xC93810 Offset: 0xC91E10 VA: 0x180C93810 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x57BBD0 Offset: 0x57A1D0 VA: 0x18057BBD0
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

	// RVA: 0xCA7D10 Offset: 0xCA6310 VA: 0x180CA7D10
	internal bool <Process>b__7(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7D10 Offset: 0xCA6310 VA: 0x180CA7D10
	internal bool <Process>b__10(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_1 // TypeDefIndex: 10510
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7DA0 Offset: 0xCA63A0 VA: 0x180CA7DA0
	internal bool <Process>b__3(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7E20 Offset: 0xCA6420 VA: 0x180CA7E20
	internal bool <Process>b__4(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_2 // TypeDefIndex: 10511
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7EA0 Offset: 0xCA64A0 VA: 0x180CA7EA0
	internal bool <Process>b__5(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7F20 Offset: 0xCA6520 VA: 0x180CA7F20
	internal bool <Process>b__6(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_3 // TypeDefIndex: 10512
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7FA0 Offset: 0xCA65A0 VA: 0x180CA7FA0
	internal bool <Process>b__8(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA8020 Offset: 0xCA6620 VA: 0x180CA8020
	internal bool <Process>b__9(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_4 // TypeDefIndex: 10513
{	// Fields
	public GenerateRoadLayout.PathNode target; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA80A0 Offset: 0xCA66A0 VA: 0x180CA80A0
	internal bool <Process>b__11(GenerateRoadLayout.PathSegment x) { }

}

private sealed class GenerateRoadLayout.<>c // TypeDefIndex: 10514
{	// Fields
	public static readonly GenerateRoadLayout.<>c <>9; // 0x0
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_0; // 0x8
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_1; // 0x10
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_2; // 0x18

	// Methods

	// RVA: 0xCA8590 Offset: 0xCA6B90 VA: 0x180CA8590
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA7B00 Offset: 0xCA6100 VA: 0x180CA7B00
	internal PathFinder.Point <Process>b__14_0(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7B00 Offset: 0xCA6100 VA: 0x180CA7B00
	internal PathFinder.Point <Process>b__14_1(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xCA7B00 Offset: 0xCA6100 VA: 0x180CA7B00
	internal PathFinder.Point <Process>b__14_2(GenerateRoadLayout.PathNode x) { }

}

