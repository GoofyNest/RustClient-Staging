public class GenerateRailLayout : ProceduralComponent // TypeDefIndex: 10486
{	// Fields
	public const float Width = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 32;
	public const float RandomScale = 1;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private static Quaternion rot90; // 0x3120
	private const int MaxDepth = 250000;

	// Methods

	// RVA: 0xC59730 Offset: 0xC57D30 VA: 0x180C59730
	private PathList CreateSegment(int number, Vector3[] points) { }

	// RVA: 0xC59820 Offset: 0xC57E20 VA: 0x180C59820 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x57BC40 Offset: 0x57A240 VA: 0x18057BC40
	public void .ctor() { }

	// RVA: 0xC5B3A0 Offset: 0xC599A0 VA: 0x180C5B3A0
	private static void .cctor() { }

}

private class GenerateRailLayout.PathNode // TypeDefIndex: 10487
{	// Fields
	public MonumentInfo monument; // 0x10
	public TerrainPathConnect target; // 0x18
	public PathFinder.Node node; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class GenerateRailLayout.PathSegment // TypeDefIndex: 10488
{	// Fields
	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18
	public TerrainPathConnect origin; // 0x20
	public TerrainPathConnect target; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class GenerateRailLayout.<>c__DisplayClass13_0 // TypeDefIndex: 10489
{	// Fields
	public PathList rail; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCA74B0 Offset: 0xCA5AB0 VA: 0x180CA74B0
	internal float <Process>b__0(int i) { }

}

