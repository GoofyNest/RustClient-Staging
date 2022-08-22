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

	// RVA: 0x114F820 Offset: 0x114DE20 VA: 0x18114F820 Slot: 5
	public override void PostSetup() { }

	// RVA: 0x114E2E0 Offset: 0x114C8E0 VA: 0x18114E2E0
	public void Clear() { }

	// RVA: -1 Offset: -1
	public T FindClosest<T>(List<T> list, Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0720 Offset: 0xBDED20 VA: 0x180BE0720
	|-TerrainPath.FindClosest<DungeonBaseInfo>
	|-TerrainPath.FindClosest<DungeonGridInfo>
	|-TerrainPath.FindClosest<MonumentInfo>
	|-TerrainPath.FindClosest<object>
	*/

	// RVA: 0x114E5B0 Offset: 0x114CBB0 VA: 0x18114E5B0
	public static int[,] CreatePowerlineCostmap(ref uint seed) { }

	// RVA: 0x114EC00 Offset: 0x114D200 VA: 0x18114EC00
	public static int[,] CreateRoadCostmap(ref uint seed) { }

	// RVA: 0x114E8D0 Offset: 0x114CED0 VA: 0x18114E8D0
	public static int[,] CreateRailCostmap(ref uint seed) { }

	// RVA: 0x114E370 Offset: 0x114C970 VA: 0x18114E370
	public static int[,] CreateBoatCostmap(float depth) { }

	// RVA: 0x114E1B0 Offset: 0x114C7B0 VA: 0x18114E1B0
	public void AddWire(PowerlineNode node) { }

	// RVA: 0x114F080 Offset: 0x114D680 VA: 0x18114F080
	public void CreateWires() { }

	// RVA: 0x114EF50 Offset: 0x114D550 VA: 0x18114EF50
	private void CreateWire(string name, List<GameObject> objects, GameObjectRef wirePrefab) { }

	// RVA: 0x114F5E0 Offset: 0x114DBE0 VA: 0x18114F5E0
	public MonumentInfo FindMonumentWithBoundsOverlap(Vector3 position) { }

	// RVA: 0x114FC60 Offset: 0x114E260 VA: 0x18114FC60
	public void .ctor() { }

}

