public static class TerrainBiome // TypeDefIndex: 7781
{
// Namespace: 
public static class TerrainBiome // TypeDefIndex: 7781
	// Fields
	public const int COUNT = 4;
	public const int EVERYTHING = -1;
	public const int NOTHING = 0;
	public const int ARID = 1;
	public const int TEMPERATE = 2;
	public const int TUNDRA = 4;
	public const int ARCTIC = 8;
	public const int ARID_IDX = 0;
	public const int TEMPERATE_IDX = 1;
	public const int TUNDRA_IDX = 2;
	public const int ARCTIC_IDX = 3;
	private static Dictionary<int, int> type2index; // 0x205C

	// Methods

	// RVA: 0x23039F0 Offset: 0x2301FF0 VA: 0x1823039F0
	public static int TypeToIndex(int id) { }

	// RVA: 0x768230 Offset: 0x766830 VA: 0x180768230
	public static int IndexToType(int idx) { }

	// RVA: 0x2303A70 Offset: 0x2302070 VA: 0x182303A70
	private static void .cctor() { }

}

public enum TerrainBiome.Enum // TypeDefIndex: 7782
{	// Fields
	public int value__; // 0x0
	public const TerrainBiome.Enum Arid = 1;
	public const TerrainBiome.Enum Temperate = 2;
	public const TerrainBiome.Enum Tundra = 4;
	public const TerrainBiome.Enum Arctic = 8;

}

