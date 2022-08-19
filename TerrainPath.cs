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

	// RVA: 0x114F560 Offset: 0x114DB60 VA: 0x18114F560 Slot: 5
	public override void PostSetup() { }

	// RVA: 0x114E020 Offset: 0x114C620 VA: 0x18114E020
	public void Clear() { }

	// RVA: -1 Offset: -1
	public T FindClosest<T>(List<T> list, Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0460 Offset: 0xBDEA60 VA: 0x180BE0460
	|-TerrainPath.FindClosest<DungeonBaseInfo>
	|-TerrainPath.FindClosest<DungeonGridInfo>
	|-TerrainPath.FindClosest<MonumentInfo>
	|-TerrainPath.FindClosest<object>
	*/

	// RVA: 0x114E2F0 Offset: 0x114C8F0 VA: 0x18114E2F0
	public static int[,] CreatePowerlineCostmap(ref uint seed) { }

	// RVA: 0x114E940 Offset: 0x114CF40 VA: 0x18114E940
	public static int[,] CreateRoadCostmap(ref uint seed) { }

	// RVA: 0x114E610 Offset: 0x114CC10 VA: 0x18114E610
	public static int[,] CreateRailCostmap(ref uint seed) { }

	// RVA: 0x114E0B0 Offset: 0x114C6B0 VA: 0x18114E0B0
	public static int[,] CreateBoatCostmap(float depth) { }

	// RVA: 0x114DEF0 Offset: 0x114C4F0 VA: 0x18114DEF0
	public void AddWire(PowerlineNode node) { }

	// RVA: 0x114EDC0 Offset: 0x114D3C0 VA: 0x18114EDC0
	public void CreateWires() { }

	// RVA: 0x114EC90 Offset: 0x114D290 VA: 0x18114EC90
	private void CreateWire(string name, List<GameObject> objects, GameObjectRef wirePrefab) { }

	// RVA: 0x114F320 Offset: 0x114D920 VA: 0x18114F320
	public MonumentInfo FindMonumentWithBoundsOverlap(Vector3 position) { }

	// RVA: 0x114F9A0 Offset: 0x114DFA0 VA: 0x18114F9A0
	public void .ctor() { }

}

