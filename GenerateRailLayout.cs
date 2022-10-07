public class GenerateRailLayout : ProceduralComponent // TypeDefIndex: 12204
{
	public const float Width = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 32;
	public const float RandomScale = 1;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private static Quaternion rot90; 
	private const int MaxDepth = 250000;


	private PathList CreateSegment(int number, Vector3[] points) { }

	public override void Process(uint seed) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class GenerateRailLayout.PathNode // TypeDefIndex: 12205
{
	public MonumentInfo monument; 
	public TerrainPathConnect target; 
	public PathFinder.Node node; 


	public void .ctor() { }

}

private class GenerateRailLayout.PathSegment // TypeDefIndex: 12206
{
	public PathFinder.Node start; 
	public PathFinder.Node end; 
	public TerrainPathConnect origin; 
	public TerrainPathConnect target; 


	public void .ctor() { }

}

private sealed class GenerateRailLayout.<>c__DisplayClass13_0 // TypeDefIndex: 12207
{
	public PathList rail; 


	public void .ctor() { }

	internal float <Process>b__0(int i) { }

}

