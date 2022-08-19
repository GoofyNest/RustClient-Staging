public class TerrainGenerator : SingletonComponent<TerrainGenerator> // TypeDefIndex: 10569
{	// Fields
	public TerrainConfig config; // 0x18
	private const float HeightMapRes = 1;
	private const float SplatMapRes = 0,5;
	private const float BaseMapRes = 0,01;

	// Methods

	// RVA: 0x1140960 Offset: 0x113EF60 VA: 0x181140960
	public static int GetHeightMapRes() { }

	// RVA: 0x1140A00 Offset: 0x113F000 VA: 0x181140A00
	public static int GetSplatMapRes() { }

	// RVA: 0x11408C0 Offset: 0x113EEC0 VA: 0x1811408C0
	public static int GetBaseMapRes() { }

	// RVA: 0x1140760 Offset: 0x113ED60 VA: 0x181140760
	public GameObject CreateTerrain() { }

	// RVA: 0x1140080 Offset: 0x113E680 VA: 0x181140080
	public GameObject CreateTerrain(int heightmapResolution, int alphamapResolution) { }

	// RVA: 0x1140AA0 Offset: 0x113F0A0 VA: 0x181140AA0
	public void .ctor() { }

}

