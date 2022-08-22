public class Prefab : IComparable<Prefab> // TypeDefIndex: 9970
{	// Fields
	public uint ID; // 0x10
	public string Name; // 0x18
	public string Folder; // 0x20
	public GameObject Object; // 0x28
	public GameManager Manager; // 0x30
	public PrefabAttribute.Library Attribute; // 0x38
	public PrefabParameters Parameters; // 0x40

	// Properties
	public static PrefabAttribute.Library DefaultAttribute { get; }
	public static GameManager DefaultManager { get; }

	// Methods

	// RVA: 0x9A7230 Offset: 0x9A5830 VA: 0x1809A7230
	public void .ctor(string name, GameObject prefab, GameManager manager, PrefabAttribute.Library attribute) { }

	// RVA: 0x9A74B0 Offset: 0x9A5AB0 VA: 0x1809A74B0
	public static GameObject op_Implicit(Prefab prefab) { }

	// RVA: 0x9A6860 Offset: 0x9A4E60 VA: 0x1809A6860 Slot: 4
	public int CompareTo(Prefab that) { }

	// RVA: 0x9A60A0 Offset: 0x9A46A0 VA: 0x1809A60A0
	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, TerrainAnchorMode mode, SpawnFilter filter) { }

	// RVA: 0x9A5FC0 Offset: 0x9A45C0 VA: 0x1809A5FC0
	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A6190 Offset: 0x9A4790 VA: 0x1809A6190
	public bool ApplyTerrainChecks(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A6290 Offset: 0x9A4890 VA: 0x1809A6290
	public bool ApplyTerrainFilters(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A6390 Offset: 0x9A4990 VA: 0x1809A6390
	public void ApplyTerrainModifiers(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A6480 Offset: 0x9A4A80 VA: 0x1809A6480
	public void ApplyTerrainPlacements(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A6570 Offset: 0x9A4B70 VA: 0x1809A6570
	public bool ApplyWaterChecks(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A5E00 Offset: 0x9A4400 VA: 0x1809A5E00
	public void ApplyDecorComponents(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	// RVA: 0x9A67C0 Offset: 0x9A4DC0 VA: 0x1809A67C0
	public bool CheckEnvironmentVolumes(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	// RVA: 0x9A6660 Offset: 0x9A4C60 VA: 0x1809A6660
	public bool CheckEnvironmentVolumesInsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	// RVA: 0x9A6710 Offset: 0x9A4D10 VA: 0x1809A6710
	public bool CheckEnvironmentVolumesOutsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	// RVA: 0x9A5EB0 Offset: 0x9A44B0 VA: 0x1809A5EB0
	public void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	// RVA: 0x9A7190 Offset: 0x9A5790 VA: 0x1809A7190
	public GameObject Spawn(Transform transform, bool active = True) { }

	// RVA: 0x9A71D0 Offset: 0x9A57D0 VA: 0x1809A71D0
	public GameObject Spawn(Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: 0x9A7110 Offset: 0x9A5710 VA: 0x1809A7110
	public GameObject Spawn(Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	// RVA: 0x9A70B0 Offset: 0x9A56B0 VA: 0x1809A70B0
	public BaseEntity SpawnEntity(Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T> Load<T>(uint id, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125ED40 Offset: 0x125D340 VA: 0x18125ED40
	|-Prefab.Load<MonumentInfo>
	|-Prefab.Load<object>
	*/

	// RVA: 0x9A6F30 Offset: 0x9A5530 VA: 0x1809A6F30
	public static Prefab Load(uint id, GameManager manager, PrefabAttribute.Library attribute) { }

	// RVA: 0x9A6D70 Offset: 0x9A5370 VA: 0x1809A6D70
	public static Prefab[] Load(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T>[] Load<T>(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125EA50 Offset: 0x125D050 VA: 0x18125EA50
	|-Prefab.Load<DungeonBaseLink>
	|-Prefab.Load<DungeonBaseTransition>
	|-Prefab.Load<DungeonGridCell>
	|-Prefab.Load<DungeonGridLink>
	|-Prefab.Load<MonumentInfo>
	|-Prefab.Load<object>
	*/

	// RVA: -1 Offset: -1
	public static Prefab<T>[] Load<T>(string[] names, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125EAC0 Offset: 0x125D0C0 VA: 0x18125EAC0
	|-Prefab.Load<object>
	*/

	// RVA: 0x9A6C40 Offset: 0x9A5240 VA: 0x1809A6C40
	public static Prefab LoadRandom(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T> LoadRandom<T>(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E8E0 Offset: 0x125CEE0 VA: 0x18125E8E0
	|-Prefab.LoadRandom<object>
	*/

	// RVA: 0x9A7390 Offset: 0x9A5990 VA: 0x1809A7390
	public static PrefabAttribute.Library get_DefaultAttribute() { }

	// RVA: 0x9A7450 Offset: 0x9A5A50 VA: 0x1809A7450
	public static GameManager get_DefaultManager() { }

	// RVA: 0x9A69A0 Offset: 0x9A4FA0 VA: 0x1809A69A0
	private static string[] FindPrefabNames(string strPrefab, bool useProbabilities = False) { }

}

