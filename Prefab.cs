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

	// RVA: 0x9A6F70 Offset: 0x9A5570 VA: 0x1809A6F70
	public void .ctor(string name, GameObject prefab, GameManager manager, PrefabAttribute.Library attribute) { }

	// RVA: 0x9A71F0 Offset: 0x9A57F0 VA: 0x1809A71F0
	public static GameObject op_Implicit(Prefab prefab) { }

	// RVA: 0x9A65A0 Offset: 0x9A4BA0 VA: 0x1809A65A0 Slot: 4
	public int CompareTo(Prefab that) { }

	// RVA: 0x9A5DE0 Offset: 0x9A43E0 VA: 0x1809A5DE0
	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, TerrainAnchorMode mode, SpawnFilter filter) { }

	// RVA: 0x9A5D00 Offset: 0x9A4300 VA: 0x1809A5D00
	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A5ED0 Offset: 0x9A44D0 VA: 0x1809A5ED0
	public bool ApplyTerrainChecks(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A5FD0 Offset: 0x9A45D0 VA: 0x1809A5FD0
	public bool ApplyTerrainFilters(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A60D0 Offset: 0x9A46D0 VA: 0x1809A60D0
	public void ApplyTerrainModifiers(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A61C0 Offset: 0x9A47C0 VA: 0x1809A61C0
	public void ApplyTerrainPlacements(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A62B0 Offset: 0x9A48B0 VA: 0x1809A62B0
	public bool ApplyWaterChecks(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A5B40 Offset: 0x9A4140 VA: 0x1809A5B40
	public void ApplyDecorComponents(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	// RVA: 0x9A6500 Offset: 0x9A4B00 VA: 0x1809A6500
	public bool CheckEnvironmentVolumes(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	// RVA: 0x9A63A0 Offset: 0x9A49A0 VA: 0x1809A63A0
	public bool CheckEnvironmentVolumesInsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	// RVA: 0x9A6450 Offset: 0x9A4A50 VA: 0x1809A6450
	public bool CheckEnvironmentVolumesOutsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	// RVA: 0x9A5BF0 Offset: 0x9A41F0 VA: 0x1809A5BF0
	public void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	// RVA: 0x9A6ED0 Offset: 0x9A54D0 VA: 0x1809A6ED0
	public GameObject Spawn(Transform transform, bool active = True) { }

	// RVA: 0x9A6F10 Offset: 0x9A5510 VA: 0x1809A6F10
	public GameObject Spawn(Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: 0x9A6E50 Offset: 0x9A5450 VA: 0x1809A6E50
	public GameObject Spawn(Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	// RVA: 0x9A6DF0 Offset: 0x9A53F0 VA: 0x1809A6DF0
	public BaseEntity SpawnEntity(Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T> Load<T>(uint id, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125EA80 Offset: 0x125D080 VA: 0x18125EA80
	|-Prefab.Load<MonumentInfo>
	|-Prefab.Load<object>
	*/

	// RVA: 0x9A6C70 Offset: 0x9A5270 VA: 0x1809A6C70
	public static Prefab Load(uint id, GameManager manager, PrefabAttribute.Library attribute) { }

	// RVA: 0x9A6AB0 Offset: 0x9A50B0 VA: 0x1809A6AB0
	public static Prefab[] Load(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T>[] Load<T>(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E790 Offset: 0x125CD90 VA: 0x18125E790
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
	|-RVA: 0x125E800 Offset: 0x125CE00 VA: 0x18125E800
	|-Prefab.Load<object>
	*/

	// RVA: 0x9A6980 Offset: 0x9A4F80 VA: 0x1809A6980
	public static Prefab LoadRandom(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T> LoadRandom<T>(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E620 Offset: 0x125CC20 VA: 0x18125E620
	|-Prefab.LoadRandom<object>
	*/

	// RVA: 0x9A70D0 Offset: 0x9A56D0 VA: 0x1809A70D0
	public static PrefabAttribute.Library get_DefaultAttribute() { }

	// RVA: 0x9A7190 Offset: 0x9A5790 VA: 0x1809A7190
	public static GameManager get_DefaultManager() { }

	// RVA: 0x9A66E0 Offset: 0x9A4CE0 VA: 0x1809A66E0
	private static string[] FindPrefabNames(string strPrefab, bool useProbabilities = False) { }

}

