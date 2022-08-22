public class TerrainPath : TerrainExtension // TypeDefIndex: 10428
{	// Fields
	internal List<PathList> Roads; // 0x30
	internal List<PathList> Rails; // 0x38
	internal List<PathList> Rivers; // 0x40
	internal List<PathList> Powerlines; // 0x48
	internal List<LandmarkInfo> Landmarks; // 0x50
	internal List<MonumentInfo> Monuments; // 0x58
	internal List<RiverInfo> RiverObjs; // 0x60
	internal List<LakeInfo> LakeObjs; // 0x68
	internal GameObject DungeonGridRoot; // 0x70
	internal List<DungeonGridInfo> DungeonGridEntrances; // 0x78
	internal List<DungeonGridCell> DungeonGridCells; // 0x80
	internal GameObject DungeonBaseRoot; // 0x88
	internal List<DungeonBaseInfo> DungeonBaseEntrances; // 0x90
	internal List<Vector3> OceanPatrolClose; // 0x98
	internal List<Vector3> OceanPatrolFar; // 0xA0
	private Dictionary<string, List<PowerlineNode>> wires; // 0xA8

	// Methods

	// RVA: 0x1150290 Offset: 0x114E890 VA: 0x181150290 Slot: 5
	public override void PostSetup() { }

	// RVA: 0x114ED50 Offset: 0x114D350 VA: 0x18114ED50
	public void Clear() { }

	// RVA: -1 Offset: -1
	public T FindClosest<T>(List<T> list, Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0BF0 Offset: 0xBDF1F0 VA: 0x180BE0BF0
	|-TerrainPath.FindClosest<DungeonBaseInfo>
	|-TerrainPath.FindClosest<DungeonGridInfo>
	|-TerrainPath.FindClosest<MonumentInfo>
	|-TerrainPath.FindClosest<object>
	*/

	// RVA: 0x114F020 Offset: 0x114D620 VA: 0x18114F020
	public static int[,] CreatePowerlineCostmap(ref uint seed) { }

	// RVA: 0x114F670 Offset: 0x114DC70 VA: 0x18114F670
	public static int[,] CreateRoadCostmap(ref uint seed) { }

	// RVA: 0x114F340 Offset: 0x114D940 VA: 0x18114F340
	public static int[,] CreateRailCostmap(ref uint seed) { }

	// RVA: 0x114EDE0 Offset: 0x114D3E0 VA: 0x18114EDE0
	public static int[,] CreateBoatCostmap(float depth) { }

	// RVA: 0x114EC20 Offset: 0x114D220 VA: 0x18114EC20
	public void AddWire(PowerlineNode node) { }

	// RVA: 0x114FAF0 Offset: 0x114E0F0 VA: 0x18114FAF0
	public void CreateWires() { }

	// RVA: 0x114F9C0 Offset: 0x114DFC0 VA: 0x18114F9C0
	private void CreateWire(string name, List<GameObject> objects, GameObjectRef wirePrefab) { }

	// RVA: 0x1150050 Offset: 0x114E650 VA: 0x181150050
	public MonumentInfo FindMonumentWithBoundsOverlap(Vector3 position) { }

	// RVA: 0x11506D0 Offset: 0x114ECD0 VA: 0x1811506D0
	public void .ctor() { }

}

