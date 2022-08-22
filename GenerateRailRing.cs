public class GenerateRailRing : ProceduralComponent // TypeDefIndex: 10491
{	// Fields
	public const float Width = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 32;
	public const float RandomScale = 1;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private const int MaxDepth = 250000;
	public int MinWorldSize; // 0x28

	// Methods

	// RVA: 0xC8DB30 Offset: 0xC8C130 VA: 0x180C8DB30 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x57BBD0 Offset: 0x57A1D0 VA: 0x18057BBD0
	public void .ctor() { }

}

private class GenerateRailRing.RingNode // TypeDefIndex: 10492
{	// Fields
	public int attempts; // 0x10
	public PathFinder.Point position; // 0x14
	public PathFinder.Point direction; // 0x1C
	public GenerateRailRing.RingNode next; // 0x28
	public GenerateRailRing.RingNode prev; // 0x30
	public PathFinder.Node path; // 0x38

	// Methods

	// RVA: 0xCA7A70 Offset: 0xCA6070 VA: 0x180CA7A70
	public void .ctor(int pos_x, int pos_y, int dir_x, int dir_y, int stepcount) { }

}

