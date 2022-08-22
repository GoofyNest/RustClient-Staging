public static class TerrainSplat // TypeDefIndex: 7783
{	// Fields
	public const int COUNT = 8;
	public const int EVERYTHING = -1;
	public const int NOTHING = 0;
	public const int DIRT = 1;
	public const int SNOW = 2;
	public const int SAND = 4;
	public const int ROCK = 8;
	public const int GRASS = 16;
	public const int FOREST = 32;
	public const int STONES = 64;
	public const int GRAVEL = 128;
	public const int DIRT_IDX = 0;
	public const int SNOW_IDX = 1;
	public const int SAND_IDX = 2;
	public const int ROCK_IDX = 3;
	public const int GRASS_IDX = 4;
	public const int FOREST_IDX = 5;
	public const int STONES_IDX = 6;
	public const int GRAVEL_IDX = 7;
	private static Dictionary<int, int> type2index; // 0x2B10510

	// Methods

	// RVA: 0x2304620 Offset: 0x2302C20 VA: 0x182304620
	public static int TypeToIndex(int id) { }

	// RVA: 0x768290 Offset: 0x766890 VA: 0x180768290
	public static int IndexToType(int idx) { }

	// RVA: 0x23046A0 Offset: 0x2302CA0 VA: 0x1823046A0
	private static void .cctor() { }

}

public enum TerrainSplat.Enum // TypeDefIndex: 7784
{	// Fields
	public int value__; // 0x0
	public const TerrainSplat.Enum Dirt = 1;
	public const TerrainSplat.Enum Snow = 2;
	public const TerrainSplat.Enum Sand = 4;
	public const TerrainSplat.Enum Rock = 8;
	public const TerrainSplat.Enum Grass = 16;
	public const TerrainSplat.Enum Forest = 32;
	public const TerrainSplat.Enum Stones = 64;
	public const TerrainSplat.Enum Gravel = 128;

}

