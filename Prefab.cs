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

	// RVA: 0x9A7720 Offset: 0x9A5D20 VA: 0x1809A7720
	public void .ctor(string name, GameObject prefab, GameManager manager, PrefabAttribute.Library attribute) { }

	// RVA: 0x9A79A0 Offset: 0x9A5FA0 VA: 0x1809A79A0
	public static GameObject op_Implicit(Prefab prefab) { }

	// RVA: 0x9A6D50 Offset: 0x9A5350 VA: 0x1809A6D50 Slot: 4
	public int CompareTo(Prefab that) { }

	// RVA: 0x9A6590 Offset: 0x9A4B90 VA: 0x1809A6590
	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, TerrainAnchorMode mode, SpawnFilter filter) { }

	// RVA: 0x9A64B0 Offset: 0x9A4AB0 VA: 0x1809A64B0
	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A6680 Offset: 0x9A4C80 VA: 0x1809A6680
	public bool ApplyTerrainChecks(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A6780 Offset: 0x9A4D80 VA: 0x1809A6780
	public bool ApplyTerrainFilters(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9A6880 Offset: 0x9A4E80 VA: 0x1809A6880
	public void ApplyTerrainModifiers(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A6970 Offset: 0x9A4F70 VA: 0x1809A6970
	public void ApplyTerrainPlacements(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A6A60 Offset: 0x9A5060 VA: 0x1809A6A60
	public bool ApplyWaterChecks(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9A62F0 Offset: 0x9A48F0 VA: 0x1809A62F0
	public void ApplyDecorComponents(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	// RVA: 0x9A6CB0 Offset: 0x9A52B0 VA: 0x1809A6CB0
	public bool CheckEnvironmentVolumes(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	// RVA: 0x9A6B50 Offset: 0x9A5150 VA: 0x1809A6B50
	public bool CheckEnvironmentVolumesInsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	// RVA: 0x9A6C00 Offset: 0x9A5200 VA: 0x1809A6C00
	public bool CheckEnvironmentVolumesOutsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	// RVA: 0x9A63A0 Offset: 0x9A49A0 VA: 0x1809A63A0
	public void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	// RVA: 0x9A7680 Offset: 0x9A5C80 VA: 0x1809A7680
	public GameObject Spawn(Transform transform, bool active = True) { }

	// RVA: 0x9A76C0 Offset: 0x9A5CC0 VA: 0x1809A76C0
	public GameObject Spawn(Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: 0x9A7600 Offset: 0x9A5C00 VA: 0x1809A7600
	public GameObject Spawn(Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	// RVA: 0x9A75A0 Offset: 0x9A5BA0 VA: 0x1809A75A0
	public BaseEntity SpawnEntity(Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T> Load<T>(uint id, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F3E0 Offset: 0x125D9E0 VA: 0x18125F3E0
	|-Prefab.Load<MonumentInfo>
	|-Prefab.Load<object>
	*/

	// RVA: 0x9A7420 Offset: 0x9A5A20 VA: 0x1809A7420
	public static Prefab Load(uint id, GameManager manager, PrefabAttribute.Library attribute) { }

	// RVA: 0x9A7260 Offset: 0x9A5860 VA: 0x1809A7260
	public static Prefab[] Load(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
	public static Prefab<T>[] Load<T>(string[] names, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F160 Offset: 0x125D760 VA: 0x18125F160
	|-Prefab.Load<object>
	*/

	// RVA: 0x9A7130 Offset: 0x9A5730 VA: 0x1809A7130
	public static Prefab LoadRandom(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T> LoadRandom<T>(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125EF80 Offset: 0x125D580 VA: 0x18125EF80
	|-Prefab.LoadRandom<object>
	*/

	// RVA: 0x9A7880 Offset: 0x9A5E80 VA: 0x1809A7880
	public static PrefabAttribute.Library get_DefaultAttribute() { }

	// RVA: 0x9A7940 Offset: 0x9A5F40 VA: 0x1809A7940
	public static GameManager get_DefaultManager() { }

	// RVA: 0x9A6E90 Offset: 0x9A5490 VA: 0x1809A6E90
	private static string[] FindPrefabNames(string strPrefab, bool useProbabilities = False) { }

}

