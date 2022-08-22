public class TerrainGenerator : SingletonComponent<TerrainGenerator> // TypeDefIndex: 10569
{	// Fields
	public TerrainConfig config; // 0x18
	private const float HeightMapRes = 1;
	private const float SplatMapRes = 0,5;
	private const float BaseMapRes = 0,01;

	// Methods

	// RVA: 0x1141690 Offset: 0x113FC90 VA: 0x181141690
	public static int GetHeightMapRes() { }

	// RVA: 0x1141730 Offset: 0x113FD30 VA: 0x181141730
	public static int GetSplatMapRes() { }

	// RVA: 0x11415F0 Offset: 0x113FBF0 VA: 0x1811415F0
	public static int GetBaseMapRes() { }

	// RVA: 0x1141490 Offset: 0x113FA90 VA: 0x181141490
	public GameObject CreateTerrain() { }

	// RVA: 0x1140DB0 Offset: 0x113F3B0 VA: 0x181140DB0
	public GameObject CreateTerrain(int heightmapResolution, int alphamapResolution) { }

	// RVA: 0x11417D0 Offset: 0x113FDD0 VA: 0x1811417D0
	public void .ctor() { }

}

