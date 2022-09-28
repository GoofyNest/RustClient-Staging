public class GenerateRoadLayout : ProceduralComponent // TypeDefIndex: 12222
{
	public InfrastructureType RoadType; 
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


	private PathList CreateSegment(int number, Vector3[] points) { }

	public override void Process(uint seed) { }

	public void .ctor() { }

}

private class GenerateRoadLayout.PathNode // TypeDefIndex: 12223
{
	public MonumentInfo monument; 
	public TerrainPathConnect target; 
	public PathFinder.Node node; 


	public void .ctor() { }

}

private class GenerateRoadLayout.PathSegment // TypeDefIndex: 12224
{
	public PathFinder.Node start; 
	public PathFinder.Node end; 
	public TerrainPathConnect origin; 
	public TerrainPathConnect target; 


	public void .ctor() { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_0 // TypeDefIndex: 12225
{
	public GenerateRoadLayout.PathSegment segment; 


	public void .ctor() { }

	internal bool <Process>b__7(GenerateRoadLayout.PathNode x) { }

	internal bool <Process>b__10(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_1 // TypeDefIndex: 12226
{
	public GenerateRoadLayout.PathNode node; 


	public void .ctor() { }

	internal bool <Process>b__3(GenerateRoadLayout.PathNode x) { }

	internal bool <Process>b__4(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_2 // TypeDefIndex: 12227
{
	public GenerateRoadLayout.PathNode node; 


	public void .ctor() { }

	internal bool <Process>b__5(GenerateRoadLayout.PathNode x) { }

	internal bool <Process>b__6(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_3 // TypeDefIndex: 12228
{
	public GenerateRoadLayout.PathNode node; 


	public void .ctor() { }

	internal bool <Process>b__8(GenerateRoadLayout.PathNode x) { }

	internal bool <Process>b__9(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_4 // TypeDefIndex: 12229
{
	public GenerateRoadLayout.PathNode target; 


	public void .ctor() { }

	internal bool <Process>b__11(GenerateRoadLayout.PathSegment x) { }

}

private sealed class GenerateRoadLayout.<>c // TypeDefIndex: 12230
{
	public static readonly GenerateRoadLayout.<>c <>9; 
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_0; 
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_1; 
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_2; 


	private static void .cctor() { }

	public void .ctor() { }

	internal PathFinder.Point <Process>b__14_0(GenerateRoadLayout.PathNode x) { }

	internal PathFinder.Point <Process>b__14_1(GenerateRoadLayout.PathNode x) { }

	internal PathFinder.Point <Process>b__14_2(GenerateRoadLayout.PathNode x) { }

}

