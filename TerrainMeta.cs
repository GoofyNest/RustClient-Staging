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
	// RVA: 0x114CB80 Offset: 0x114B180 VA: 0x18114CB80
	public static TerrainConfig get_Config() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D300 Offset: 0x114B900 VA: 0x18114D300
	private static void set_Config(TerrainConfig value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CF90 Offset: 0x114B590 VA: 0x18114CF90
	public static Terrain get_Terrain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D7B0 Offset: 0x114BDB0 VA: 0x18114D7B0
	private static void set_Terrain(Terrain value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D050 Offset: 0x114B650 VA: 0x18114D050
	public static Transform get_Transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D8A0 Offset: 0x114BEA0 VA: 0x18114D8A0
	private static void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CE70 Offset: 0x114B470 VA: 0x18114CE70
	public static Vector3 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D670 Offset: 0x114BC70 VA: 0x18114D670
	private static void set_Position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CF00 Offset: 0x114B500 VA: 0x18114CF00
	public static Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D710 Offset: 0x114BD10 VA: 0x18114D710
	private static void set_Size(Vector3 value) { }

	// RVA: 0x114C980 Offset: 0x114AF80 VA: 0x18114C980
	public static Vector3 get_Center() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CD60 Offset: 0x114B360 VA: 0x18114CD60
	public static Vector3 get_OneOverSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D530 Offset: 0x114BB30 VA: 0x18114D530
	private static void set_OneOverSize(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CC80 Offset: 0x114B280 VA: 0x18114CC80
	public static Vector3 get_HighestPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D440 Offset: 0x114BA40 VA: 0x18114D440
	public static void set_HighestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CD10 Offset: 0x114B310 VA: 0x18114CD10
	public static Vector3 get_LowestPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D4E0 Offset: 0x114BAE0 VA: 0x18114D4E0
	public static void set_LowestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CCD0 Offset: 0x114B2D0 VA: 0x18114CCD0
	public static float get_LootAxisAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D490 Offset: 0x114BA90 VA: 0x18114D490
	private static void set_LootAxisAngle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C8C0 Offset: 0x114AEC0 VA: 0x18114C8C0
	public static float get_BiomeAxisAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D120 Offset: 0x114B720 VA: 0x18114D120
	private static void set_BiomeAxisAngle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CBC0 Offset: 0x114B1C0 VA: 0x18114CBC0
	public static TerrainData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D350 Offset: 0x114B950 VA: 0x18114D350
	private static void set_Data(TerrainData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CAC0 Offset: 0x114B0C0 VA: 0x18114CAC0
	public static TerrainCollider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D210 Offset: 0x114B810 VA: 0x18114D210
	private static void set_Collider(TerrainCollider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CB00 Offset: 0x114B100 VA: 0x18114CB00
	public static TerrainCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D260 Offset: 0x114B860 VA: 0x18114D260
	private static void set_Collision(TerrainCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CDF0 Offset: 0x114B3F0 VA: 0x18114CDF0
	public static TerrainPhysics get_Physics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D5D0 Offset: 0x114BBD0 VA: 0x18114D5D0
	private static void set_Physics(TerrainPhysics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CB40 Offset: 0x114B140 VA: 0x18114CB40
	public static TerrainColors get_Colors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D2B0 Offset: 0x114B8B0 VA: 0x18114D2B0
	private static void set_Colors(TerrainColors value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CEC0 Offset: 0x114B4C0 VA: 0x18114CEC0
	public static TerrainQuality get_Quality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D6C0 Offset: 0x114BCC0 VA: 0x18114D6C0
	private static void set_Quality(TerrainQuality value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CDB0 Offset: 0x114B3B0 VA: 0x18114CDB0
	public static TerrainPath get_Path() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D580 Offset: 0x114BB80 VA: 0x18114D580
	private static void set_Path(TerrainPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C900 Offset: 0x114AF00 VA: 0x18114C900
	public static TerrainBiomeMap get_BiomeMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D170 Offset: 0x114B770 VA: 0x18114D170
	private static void set_BiomeMap(TerrainBiomeMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C880 Offset: 0x114AE80 VA: 0x18114C880
	public static TerrainAlphaMap get_AlphaMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D0D0 Offset: 0x114B6D0 VA: 0x18114D0D0
	private static void set_AlphaMap(TerrainAlphaMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114C940 Offset: 0x114AF40 VA: 0x18114C940
	public static TerrainBlendMap get_BlendMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D1C0 Offset: 0x114B7C0 VA: 0x18114D1C0
	private static void set_BlendMap(TerrainBlendMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CC40 Offset: 0x114B240 VA: 0x18114CC40
	public static TerrainHeightMap get_HeightMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D3F0 Offset: 0x114B9F0 VA: 0x18114D3F0
	private static void set_HeightMap(TerrainHeightMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CF50 Offset: 0x114B550 VA: 0x18114CF50
	public static TerrainSplatMap get_SplatMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D760 Offset: 0x114BD60 VA: 0x18114D760
	private static void set_SplatMap(TerrainSplatMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D010 Offset: 0x114B610 VA: 0x18114D010
	public static TerrainTopologyMap get_TopologyMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D850 Offset: 0x114BE50 VA: 0x18114D850
	private static void set_TopologyMap(TerrainTopologyMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D090 Offset: 0x114B690 VA: 0x18114D090
	public static TerrainWaterMap get_WaterMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D8F0 Offset: 0x114BEF0 VA: 0x18114D8F0
	private static void set_WaterMap(TerrainWaterMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CC00 Offset: 0x114B200 VA: 0x18114CC00
	public static TerrainDistanceMap get_DistanceMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D3A0 Offset: 0x114B9A0 VA: 0x18114D3A0
	private static void set_DistanceMap(TerrainDistanceMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CE30 Offset: 0x114B430 VA: 0x18114CE30
	public static TerrainPlacementMap get_PlacementMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D620 Offset: 0x114BC20 VA: 0x18114D620
	private static void set_PlacementMap(TerrainPlacementMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114CFD0 Offset: 0x114B5D0 VA: 0x18114CFD0
	public static TerrainTexturing get_Texturing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x114D800 Offset: 0x114BE00 VA: 0x18114D800
	private static void set_Texturing(TerrainTexturing value) { }

	// RVA: 0x114BF90 Offset: 0x114A590 VA: 0x18114BF90
	public static bool OutOfBounds(Vector3 worldPos) { }

	// RVA: 0x114C150 Offset: 0x114A750 VA: 0x18114C150
	public static bool OutOfMargin(Vector3 worldPos) { }

	// RVA: 0x114C4B0 Offset: 0x114AAB0 VA: 0x18114C4B0
	public static Vector3 RandomPointOffshore() { }

	// RVA: 0x114BD90 Offset: 0x114A390 VA: 0x18114BD90
	public static Vector3 Normalize(Vector3 worldPos) { }

	// RVA: 0x114BBE0 Offset: 0x114A1E0 VA: 0x18114BBE0
	public static float NormalizeX(float x) { }

	// RVA: 0x114BC70 Offset: 0x114A270 VA: 0x18114BC70
	public static float NormalizeY(float y) { }

	// RVA: 0x114BD00 Offset: 0x114A300 VA: 0x18114BD00
	public static float NormalizeZ(float z) { }

	// RVA: 0x114ABE0 Offset: 0x11491E0 VA: 0x18114ABE0
	public static Vector3 Denormalize(Vector3 normPos) { }

	// RVA: 0x114AA30 Offset: 0x1149030 VA: 0x18114AA30
	public static float DenormalizeX(float normX) { }

	// RVA: 0x114AAC0 Offset: 0x11490C0 VA: 0x18114AAC0
	public static float DenormalizeY(float normY) { }

	// RVA: 0x114AB50 Offset: 0x1149150 VA: 0x18114AB50
	public static float DenormalizeZ(float normZ) { }

	// RVA: 0x1149850 Offset: 0x1147E50 VA: 0x181149850
	protected void Awake() { }

	// RVA: 0x114AFA0 Offset: 0x11495A0 VA: 0x18114AFA0
	public void Init(Terrain terrainOverride, TerrainConfig configOverride) { }

	// RVA: 0x114ADD0 Offset: 0x11493D0 VA: 0x18114ADD0
	public static void InitNoTerrain(bool createPath = False) { }

	// RVA: 0x114C7D0 Offset: 0x114ADD0 VA: 0x18114C7D0
	public void SetupComponents() { }

	// RVA: 0x114C410 Offset: 0x114AA10 VA: 0x18114C410
	public void PostSetupComponents() { }

	// RVA: 0x11498A0 Offset: 0x1147EA0 VA: 0x1811498A0
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

