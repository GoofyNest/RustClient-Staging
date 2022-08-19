public class TerrainMeta : MonoBehaviour // TypeDefIndex: 10425
{	// Fields
	public Terrain terrain; // 0x18
	public TerrainConfig config; // 0x20
	public TerrainMeta.PaintMode paint; // 0x28
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public TerrainMeta.PaintMode currentPaintMode; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainConfig <Config>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Terrain <Terrain>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Transform <Transform>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Vector3 <Position>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Vector3 <Size>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Vector3 <OneOverSize>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Vector3 <HighestPoint>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Vector3 <LowestPoint>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static float <LootAxisAngle>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static float <BiomeAxisAngle>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainData <Data>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainCollider <Collider>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainCollision <Collision>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainPhysics <Physics>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainColors <Colors>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainQuality <Quality>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainPath <Path>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainBiomeMap <BiomeMap>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainAlphaMap <AlphaMap>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainBlendMap <BlendMap>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainHeightMap <HeightMap>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainSplatMap <SplatMap>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainTopologyMap <TopologyMap>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainWaterMap <WaterMap>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainDistanceMap <DistanceMap>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static TerrainPlacementMap <PlacementMap>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BE50 Offset: 0x114A450 VA: 0x18114BE50
	public static TerrainConfig get_Config() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C5D0 Offset: 0x114ABD0 VA: 0x18114C5D0
	private static void set_Config(TerrainConfig value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C260 Offset: 0x114A860 VA: 0x18114C260
	public static Terrain get_Terrain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114CA80 Offset: 0x114B080 VA: 0x18114CA80
	private static void set_Terrain(Terrain value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C320 Offset: 0x114A920 VA: 0x18114C320
	public static Transform get_Transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114CB70 Offset: 0x114B170 VA: 0x18114CB70
	private static void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C140 Offset: 0x114A740 VA: 0x18114C140
	public static Vector3 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C940 Offset: 0x114AF40 VA: 0x18114C940
	private static void set_Position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C1D0 Offset: 0x114A7D0 VA: 0x18114C1D0
	public static Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C9E0 Offset: 0x114AFE0 VA: 0x18114C9E0
	private static void set_Size(Vector3 value) { }

	// RVA: 0x114BC50 Offset: 0x114A250 VA: 0x18114BC50
	public static Vector3 get_Center() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C030 Offset: 0x114A630 VA: 0x18114C030
	public static Vector3 get_OneOverSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C800 Offset: 0x114AE00 VA: 0x18114C800
	private static void set_OneOverSize(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BF50 Offset: 0x114A550 VA: 0x18114BF50
	public static Vector3 get_HighestPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C710 Offset: 0x114AD10 VA: 0x18114C710
	public static void set_HighestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BFE0 Offset: 0x114A5E0 VA: 0x18114BFE0
	public static Vector3 get_LowestPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C7B0 Offset: 0x114ADB0 VA: 0x18114C7B0
	public static void set_LowestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BFA0 Offset: 0x114A5A0 VA: 0x18114BFA0
	public static float get_LootAxisAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C760 Offset: 0x114AD60 VA: 0x18114C760
	private static void set_LootAxisAngle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BB90 Offset: 0x114A190 VA: 0x18114BB90
	public static float get_BiomeAxisAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C3F0 Offset: 0x114A9F0 VA: 0x18114C3F0
	private static void set_BiomeAxisAngle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BE90 Offset: 0x114A490 VA: 0x18114BE90
	public static TerrainData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C620 Offset: 0x114AC20 VA: 0x18114C620
	private static void set_Data(TerrainData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BD90 Offset: 0x114A390 VA: 0x18114BD90
	public static TerrainCollider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C4E0 Offset: 0x114AAE0 VA: 0x18114C4E0
	private static void set_Collider(TerrainCollider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BDD0 Offset: 0x114A3D0 VA: 0x18114BDD0
	public static TerrainCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C530 Offset: 0x114AB30 VA: 0x18114C530
	private static void set_Collision(TerrainCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C0C0 Offset: 0x114A6C0 VA: 0x18114C0C0
	public static TerrainPhysics get_Physics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C8A0 Offset: 0x114AEA0 VA: 0x18114C8A0
	private static void set_Physics(TerrainPhysics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BE10 Offset: 0x114A410 VA: 0x18114BE10
	public static TerrainColors get_Colors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C580 Offset: 0x114AB80 VA: 0x18114C580
	private static void set_Colors(TerrainColors value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C190 Offset: 0x114A790 VA: 0x18114C190
	public static TerrainQuality get_Quality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C990 Offset: 0x114AF90 VA: 0x18114C990
	private static void set_Quality(TerrainQuality value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C080 Offset: 0x114A680 VA: 0x18114C080
	public static TerrainPath get_Path() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C850 Offset: 0x114AE50 VA: 0x18114C850
	private static void set_Path(TerrainPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BBD0 Offset: 0x114A1D0 VA: 0x18114BBD0
	public static TerrainBiomeMap get_BiomeMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C440 Offset: 0x114AA40 VA: 0x18114C440
	private static void set_BiomeMap(TerrainBiomeMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BB50 Offset: 0x114A150 VA: 0x18114BB50
	public static TerrainAlphaMap get_AlphaMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C3A0 Offset: 0x114A9A0 VA: 0x18114C3A0
	private static void set_AlphaMap(TerrainAlphaMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BC10 Offset: 0x114A210 VA: 0x18114BC10
	public static TerrainBlendMap get_BlendMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C490 Offset: 0x114AA90 VA: 0x18114C490
	private static void set_BlendMap(TerrainBlendMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BF10 Offset: 0x114A510 VA: 0x18114BF10
	public static TerrainHeightMap get_HeightMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C6C0 Offset: 0x114ACC0 VA: 0x18114C6C0
	private static void set_HeightMap(TerrainHeightMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C220 Offset: 0x114A820 VA: 0x18114C220
	public static TerrainSplatMap get_SplatMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114CA30 Offset: 0x114B030 VA: 0x18114CA30
	private static void set_SplatMap(TerrainSplatMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C2E0 Offset: 0x114A8E0 VA: 0x18114C2E0
	public static TerrainTopologyMap get_TopologyMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114CB20 Offset: 0x114B120 VA: 0x18114CB20
	private static void set_TopologyMap(TerrainTopologyMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C360 Offset: 0x114A960 VA: 0x18114C360
	public static TerrainWaterMap get_WaterMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114CBC0 Offset: 0x114B1C0 VA: 0x18114CBC0
	private static void set_WaterMap(TerrainWaterMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114BED0 Offset: 0x114A4D0 VA: 0x18114BED0
	public static TerrainDistanceMap get_DistanceMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C670 Offset: 0x114AC70 VA: 0x18114C670
	private static void set_DistanceMap(TerrainDistanceMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C100 Offset: 0x114A700 VA: 0x18114C100
	public static TerrainPlacementMap get_PlacementMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C8F0 Offset: 0x114AEF0 VA: 0x18114C8F0
	private static void set_PlacementMap(TerrainPlacementMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114C2A0 Offset: 0x114A8A0 VA: 0x18114C2A0
	public static TerrainTexturing get_Texturing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x114CAD0 Offset: 0x114B0D0 VA: 0x18114CAD0
	private static void set_Texturing(TerrainTexturing value) { }

	// RVA: 0x114B260 Offset: 0x1149860 VA: 0x18114B260
	public static bool OutOfBounds(Vector3 worldPos) { }

	// RVA: 0x114B420 Offset: 0x1149A20 VA: 0x18114B420
	public static bool OutOfMargin(Vector3 worldPos) { }

	// RVA: 0x114B780 Offset: 0x1149D80 VA: 0x18114B780
	public static Vector3 RandomPointOffshore() { }

	// RVA: 0x114B060 Offset: 0x1149660 VA: 0x18114B060
	public static Vector3 Normalize(Vector3 worldPos) { }

	// RVA: 0x114AEB0 Offset: 0x11494B0 VA: 0x18114AEB0
	public static float NormalizeX(float x) { }

	// RVA: 0x114AF40 Offset: 0x1149540 VA: 0x18114AF40
	public static float NormalizeY(float y) { }

	// RVA: 0x114AFD0 Offset: 0x11495D0 VA: 0x18114AFD0
	public static float NormalizeZ(float z) { }

	// RVA: 0x1149EB0 Offset: 0x11484B0 VA: 0x181149EB0
	public static Vector3 Denormalize(Vector3 normPos) { }

	// RVA: 0x1149D00 Offset: 0x1148300 VA: 0x181149D00
	public static float DenormalizeX(float normX) { }

	// RVA: 0x1149D90 Offset: 0x1148390 VA: 0x181149D90
	public static float DenormalizeY(float normY) { }

	// RVA: 0x1149E20 Offset: 0x1148420 VA: 0x181149E20
	public static float DenormalizeZ(float normZ) { }

	// RVA: 0x1148B20 Offset: 0x1147120 VA: 0x181148B20
	protected void Awake() { }

	// RVA: 0x114A270 Offset: 0x1148870 VA: 0x18114A270
	public void Init(Terrain terrainOverride, TerrainConfig configOverride) { }

	// RVA: 0x114A0A0 Offset: 0x11486A0 VA: 0x18114A0A0
	public static void InitNoTerrain(bool createPath = False) { }

	// RVA: 0x114BAA0 Offset: 0x114A0A0 VA: 0x18114BAA0
	public void SetupComponents() { }

	// RVA: 0x114B6E0 Offset: 0x1149CE0 VA: 0x18114B6E0
	public void PostSetupComponents() { }

	// RVA: 0x1148B70 Offset: 0x1147170 VA: 0x181148B70
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

