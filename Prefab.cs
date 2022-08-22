public class Prefab : IComparable<Prefab> // TypeDefIndex: 9970
{	public uint ID; // 0x10
	public string Name; // 0x18
	public string Folder; // 0x20
	public GameObject Object; // 0x28
	public GameManager Manager; // 0x30
	public PrefabAttribute.Library Attribute; // 0x38
	public PrefabParameters Parameters; // 0x40

	public static PrefabAttribute.Library DefaultAttribute { get; }
	public static GameManager DefaultManager { get; }


	public void .ctor(string name, GameObject prefab, GameManager manager, PrefabAttribute.Library attribute) { }

	public static GameObject op_Implicit(Prefab prefab) { }

	public int CompareTo(Prefab that) { }

	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, TerrainAnchorMode mode, SpawnFilter filter) { }

	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	public bool ApplyTerrainChecks(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	public bool ApplyTerrainFilters(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	public void ApplyTerrainModifiers(Vector3 pos, Quaternion rot, Vector3 scale) { }

	public void ApplyTerrainPlacements(Vector3 pos, Quaternion rot, Vector3 scale) { }

	public bool ApplyWaterChecks(Vector3 pos, Quaternion rot, Vector3 scale) { }

	public void ApplyDecorComponents(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	public bool CheckEnvironmentVolumes(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	public bool CheckEnvironmentVolumesInsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	public bool CheckEnvironmentVolumesOutsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	public void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	public GameObject Spawn(Transform transform, bool active = True) { }

	public GameObject Spawn(Vector3 pos, Quaternion rot, bool active = True) { }

	public GameObject Spawn(Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	public BaseEntity SpawnEntity(Vector3 pos, Quaternion rot, bool active = True) { }

	public static Prefab<T> Load<T>(uint id, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F3E0 Offset: 0x125D9E0 VA: 0x18125F3E0
	|-Prefab.Load<MonumentInfo>
	|-Prefab.Load<object>
	*/

	public static Prefab Load(uint id, GameManager manager, PrefabAttribute.Library attribute) { }

	public static Prefab[] Load(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	public static Prefab<T>[] Load<T>(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F0F0 Offset: 0x125D6F0 VA: 0x18125F0F0
	|-Prefab.Load<DungeonBaseLink>
	|-Prefab.Load<DungeonBaseTransition>
	|-Prefab.Load<DungeonGridCell>
	|-Prefab.Load<DungeonGridLink>
	|-Prefab.Load<MonumentInfo>
	|-Prefab.Load<object>
	*/

	public static Prefab<T>[] Load<T>(string[] names, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F160 Offset: 0x125D760 VA: 0x18125F160
	|-Prefab.Load<object>
	*/

	public static Prefab LoadRandom(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	public static Prefab<T> LoadRandom<T>(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125EF80 Offset: 0x125D580 VA: 0x18125EF80
	|-Prefab.LoadRandom<object>
	*/

	public static PrefabAttribute.Library get_DefaultAttribute() { }

	public static GameManager get_DefaultManager() { }

	private static string[] FindPrefabNames(string strPrefab, bool useProbabilities = False) { }

}

