public class TerrainGenerator : SingletonComponent<TerrainGenerator> // TypeDefIndex: 10569
{	// Fields
	public TerrainConfig config; // 0x18
	private const float HeightMapRes = 1;
	private const float SplatMapRes = 0,5;
	private const float BaseMapRes = 0,01;

	// Methods

	// RVA: 0x1140C20 Offset: 0x113F220 VA: 0x181140C20
	public static int GetHeightMapRes() { }

	// RVA: 0x1140CC0 Offset: 0x113F2C0 VA: 0x181140CC0
	public static int GetSplatMapRes() { }

	// RVA: 0x1140B80 Offset: 0x113F180 VA: 0x181140B80
	public static int GetBaseMapRes() { }

	// RVA: 0x1140A20 Offset: 0x113F020 VA: 0x181140A20
	public GameObject CreateTerrain() { }

	// RVA: 0x1140340 Offset: 0x113E940 VA: 0x181140340
	public GameObject CreateTerrain(int heightmapResolution, int alphamapResolution) { }

	// RVA: 0x1140D60 Offset: 0x113F360 VA: 0x181140D60
	public void .ctor() { }

}

