public class TerrainMeta : MonoBehaviour // TypeDefIndex: 10425
{	// Fields
	public Terrain terrain; // 0x18
	public TerrainConfig config; // 0x20
	public TerrainMeta.PaintMode paint; // 0x28
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TerrainMeta.PaintMode currentPaintMode; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainConfig <Config>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Terrain <Terrain>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Transform <Transform>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Vector3 <Position>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Vector3 <Size>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Vector3 <OneOverSize>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Vector3 <HighestPoint>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Vector3 <LowestPoint>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static float <LootAxisAngle>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static float <BiomeAxisAngle>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainData <Data>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainCollider <Collider>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainCollision <Collision>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainPhysics <Physics>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainColors <Colors>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainQuality <Quality>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainPath <Path>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainBiomeMap <BiomeMap>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainAlphaMap <AlphaMap>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainBlendMap <BlendMap>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainHeightMap <HeightMap>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainSplatMap <SplatMap>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainTopologyMap <TopologyMap>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainWaterMap <WaterMap>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainDistanceMap <DistanceMap>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainPlacementMap <PlacementMap>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static TerrainTexturing <Texturing>k__BackingField; // 0xE0

	// Properties
	public static TerrainConfig Config { get; set; }
	public static Terrain Terrain { get; set; }
	public static Transform Transform { get; set; }
	public static Vector3 Position { get; set; }
	public static Vector3 Size { get; set; }
	public static Vector3 Center { get; }
	public static Vector3 OneOverSize { get; set; }
	public static Vector3 HighestPoint { get; set; }
	public static Vector3 LowestPoint { get; set; }
	public static float LootAxisAngle { get; set; }
	public static float BiomeAxisAngle { get; set; }
	public static TerrainData Data { get; set; }
	public static TerrainCollider Collider { get; set; }
	public static TerrainCollision Collision { get; set; }
	public static TerrainPhysics Physics { get; set; }
	public static TerrainColors Colors { get; set; }
	public static TerrainQuality Quality { get; set; }
	public static TerrainPath Path { get; set; }
	public static TerrainBiomeMap BiomeMap { get; set; }
	public static TerrainAlphaMap AlphaMap { get; set; }
	public static TerrainBlendMap BlendMap { get; set; }
	public static TerrainHeightMap HeightMap { get; set; }
	public static TerrainSplatMap SplatMap { get; set; }
	public static TerrainTopologyMap TopologyMap { get; set; }
	public static TerrainWaterMap WaterMap { get; set; }
	public static TerrainDistanceMap DistanceMap { get; set; }
	public static TerrainPlacementMap PlacementMap { get; set; }
	public static TerrainTexturing Texturing { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C110 Offset: 0x114A710 VA: 0x18114C110
	public static TerrainConfig get_Config() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C890 Offset: 0x114AE90 VA: 0x18114C890
	private static void set_Config(TerrainConfig value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C520 Offset: 0x114AB20 VA: 0x18114C520
	public static Terrain get_Terrain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CD40 Offset: 0x114B340 VA: 0x18114CD40
	private static void set_Terrain(Terrain value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C5E0 Offset: 0x114ABE0 VA: 0x18114C5E0
	public static Transform get_Transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CE30 Offset: 0x114B430 VA: 0x18114CE30
	private static void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C400 Offset: 0x114AA00 VA: 0x18114C400
	public static Vector3 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CC00 Offset: 0x114B200 VA: 0x18114CC00
	private static void set_Position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C490 Offset: 0x114AA90 VA: 0x18114C490
	public static Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CCA0 Offset: 0x114B2A0 VA: 0x18114CCA0
	private static void set_Size(Vector3 value) { }

	// RVA: 0x114BF10 Offset: 0x114A510 VA: 0x18114BF10
	public static Vector3 get_Center() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C2F0 Offset: 0x114A8F0 VA: 0x18114C2F0
	public static Vector3 get_OneOverSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CAC0 Offset: 0x114B0C0 VA: 0x18114CAC0
	private static void set_OneOverSize(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C210 Offset: 0x114A810 VA: 0x18114C210
	public static Vector3 get_HighestPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C9D0 Offset: 0x114AFD0 VA: 0x18114C9D0
	public static void set_HighestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C2A0 Offset: 0x114A8A0 VA: 0x18114C2A0
	public static Vector3 get_LowestPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CA70 Offset: 0x114B070 VA: 0x18114CA70
	public static void set_LowestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C260 Offset: 0x114A860 VA: 0x18114C260
	public static float get_LootAxisAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CA20 Offset: 0x114B020 VA: 0x18114CA20
	private static void set_LootAxisAngle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114BE50 Offset: 0x114A450 VA: 0x18114BE50
	public static float get_BiomeAxisAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C6B0 Offset: 0x114ACB0 VA: 0x18114C6B0
	private static void set_BiomeAxisAngle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C150 Offset: 0x114A750 VA: 0x18114C150
	public static TerrainData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C8E0 Offset: 0x114AEE0 VA: 0x18114C8E0
	private static void set_Data(TerrainData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C050 Offset: 0x114A650 VA: 0x18114C050
	public static TerrainCollider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C7A0 Offset: 0x114ADA0 VA: 0x18114C7A0
	private static void set_Collider(TerrainCollider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C090 Offset: 0x114A690 VA: 0x18114C090
	public static TerrainCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C7F0 Offset: 0x114ADF0 VA: 0x18114C7F0
	private static void set_Collision(TerrainCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C380 Offset: 0x114A980 VA: 0x18114C380
	public static TerrainPhysics get_Physics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CB60 Offset: 0x114B160 VA: 0x18114CB60
	private static void set_Physics(TerrainPhysics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C0D0 Offset: 0x114A6D0 VA: 0x18114C0D0
	public static TerrainColors get_Colors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C840 Offset: 0x114AE40 VA: 0x18114C840
	private static void set_Colors(TerrainColors value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C450 Offset: 0x114AA50 VA: 0x18114C450
	public static TerrainQuality get_Quality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CC50 Offset: 0x114B250 VA: 0x18114CC50
	private static void set_Quality(TerrainQuality value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C340 Offset: 0x114A940 VA: 0x18114C340
	public static TerrainPath get_Path() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CB10 Offset: 0x114B110 VA: 0x18114CB10
	private static void set_Path(TerrainPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114BE90 Offset: 0x114A490 VA: 0x18114BE90
	public static TerrainBiomeMap get_BiomeMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C700 Offset: 0x114AD00 VA: 0x18114C700
	private static void set_BiomeMap(TerrainBiomeMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114BE10 Offset: 0x114A410 VA: 0x18114BE10
	public static TerrainAlphaMap get_AlphaMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C660 Offset: 0x114AC60 VA: 0x18114C660
	private static void set_AlphaMap(TerrainAlphaMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114BED0 Offset: 0x114A4D0 VA: 0x18114BED0
	public static TerrainBlendMap get_BlendMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C750 Offset: 0x114AD50 VA: 0x18114C750
	private static void set_BlendMap(TerrainBlendMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C1D0 Offset: 0x114A7D0 VA: 0x18114C1D0
	public static TerrainHeightMap get_HeightMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C980 Offset: 0x114AF80 VA: 0x18114C980
	private static void set_HeightMap(TerrainHeightMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C4E0 Offset: 0x114AAE0 VA: 0x18114C4E0
	public static TerrainSplatMap get_SplatMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CCF0 Offset: 0x114B2F0 VA: 0x18114CCF0
	private static void set_SplatMap(TerrainSplatMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C5A0 Offset: 0x114ABA0 VA: 0x18114C5A0
	public static TerrainTopologyMap get_TopologyMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CDE0 Offset: 0x114B3E0 VA: 0x18114CDE0
	private static void set_TopologyMap(TerrainTopologyMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C620 Offset: 0x114AC20 VA: 0x18114C620
	public static TerrainWaterMap get_WaterMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CE80 Offset: 0x114B480 VA: 0x18114CE80
	private static void set_WaterMap(TerrainWaterMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C190 Offset: 0x114A790 VA: 0x18114C190
	public static TerrainDistanceMap get_DistanceMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C930 Offset: 0x114AF30 VA: 0x18114C930
	private static void set_DistanceMap(TerrainDistanceMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C3C0 Offset: 0x114A9C0 VA: 0x18114C3C0
	public static TerrainPlacementMap get_PlacementMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CBB0 Offset: 0x114B1B0 VA: 0x18114CBB0
	private static void set_PlacementMap(TerrainPlacementMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C560 Offset: 0x114AB60 VA: 0x18114C560
	public static TerrainTexturing get_Texturing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CD90 Offset: 0x114B390 VA: 0x18114CD90
	private static void set_Texturing(TerrainTexturing value) { }

	// RVA: 0x114B520 Offset: 0x1149B20 VA: 0x18114B520
	public static bool OutOfBounds(Vector3 worldPos) { }

	// RVA: 0x114B6E0 Offset: 0x1149CE0 VA: 0x18114B6E0
	public static bool OutOfMargin(Vector3 worldPos) { }

	// RVA: 0x114BA40 Offset: 0x114A040 VA: 0x18114BA40
	public static Vector3 RandomPointOffshore() { }

	// RVA: 0x114B320 Offset: 0x1149920 VA: 0x18114B320
	public static Vector3 Normalize(Vector3 worldPos) { }

	// RVA: 0x114B170 Offset: 0x1149770 VA: 0x18114B170
	public static float NormalizeX(float x) { }

	// RVA: 0x114B200 Offset: 0x1149800 VA: 0x18114B200
	public static float NormalizeY(float y) { }

	// RVA: 0x114B290 Offset: 0x1149890 VA: 0x18114B290
	public static float NormalizeZ(float z) { }

	// RVA: 0x114A170 Offset: 0x1148770 VA: 0x18114A170
	public static Vector3 Denormalize(Vector3 normPos) { }

	// RVA: 0x1149FC0 Offset: 0x11485C0 VA: 0x181149FC0
	public static float DenormalizeX(float normX) { }

	// RVA: 0x114A050 Offset: 0x1148650 VA: 0x18114A050
	public static float DenormalizeY(float normY) { }

	// RVA: 0x114A0E0 Offset: 0x11486E0 VA: 0x18114A0E0
	public static float DenormalizeZ(float normZ) { }

	// RVA: 0x1148DE0 Offset: 0x11473E0 VA: 0x181148DE0
	protected void Awake() { }

	// RVA: 0x114A530 Offset: 0x1148B30 VA: 0x18114A530
	public void Init(Terrain terrainOverride, TerrainConfig configOverride) { }

	// RVA: 0x114A360 Offset: 0x1148960 VA: 0x18114A360
	public static void InitNoTerrain(bool createPath = False) { }

	// RVA: 0x114BD60 Offset: 0x114A360 VA: 0x18114BD60
	public void SetupComponents() { }

	// RVA: 0x114B9A0 Offset: 0x1149FA0 VA: 0x18114B9A0
	public void PostSetupComponents() { }

	// RVA: 0x1148E30 Offset: 0x1147430 VA: 0x181148E30
	public void BindShaderProperties() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum TerrainMeta.PaintMode // TypeDefIndex: 10426
{	// Fields
	public int value__; // 0x0
	public const TerrainMeta.PaintMode None = 0;
	public const TerrainMeta.PaintMode Splats = 1;
	public const TerrainMeta.PaintMode Biomes = 2;
	public const TerrainMeta.PaintMode Alpha = 3;
	public const TerrainMeta.PaintMode Blend = 4;
	public const TerrainMeta.PaintMode Field = 5;
	public const TerrainMeta.PaintMode Cliff = 6;
	public const TerrainMeta.PaintMode Summit = 7;
	public const TerrainMeta.PaintMode Beachside = 8;
	public const TerrainMeta.PaintMode Beach = 9;
	public const TerrainMeta.PaintMode Forest = 10;
	public const TerrainMeta.PaintMode Forestside = 11;
	public const TerrainMeta.PaintMode Ocean = 12;
	public const TerrainMeta.PaintMode Oceanside = 13;
	public const TerrainMeta.PaintMode Decor = 14;
	public const TerrainMeta.PaintMode Monument = 15;
	public const TerrainMeta.PaintMode Road = 16;
	public const TerrainMeta.PaintMode Roadside = 17;
	public const TerrainMeta.PaintMode Bridge = 18;
	public const TerrainMeta.PaintMode River = 19;
	public const TerrainMeta.PaintMode Riverside = 20;
	public const TerrainMeta.PaintMode Lake = 21;
	public const TerrainMeta.PaintMode Lakeside = 22;
	public const TerrainMeta.PaintMode Offshore = 23;
	public const TerrainMeta.PaintMode Rail = 24;
	public const TerrainMeta.PaintMode Railside = 25;
	public const TerrainMeta.PaintMode Building = 26;
	public const TerrainMeta.PaintMode Cliffside = 27;
	public const TerrainMeta.PaintMode Mountain = 28;
	public const TerrainMeta.PaintMode Clutter = 29;
	public const TerrainMeta.PaintMode Alt = 30;
	public const TerrainMeta.PaintMode Tier0 = 31;
	public const TerrainMeta.PaintMode Tier1 = 32;
	public const TerrainMeta.PaintMode Tier2 = 33;
	public const TerrainMeta.PaintMode Mainland = 34;
	public const TerrainMeta.PaintMode Hilltop = 35;

}

