public class GameManager // TypeDefIndex: 9880
{	// Fields
	public static GameManager client; // 0x0
	internal PrefabPreProcess preProcessed; // 0x10
	internal PrefabPoolCollection pool; // 0x18
	private bool Clientside; // 0x20
	private bool Serverside; // 0x21

	// Methods

	// RVA: 0x757220 Offset: 0x755820 VA: 0x180757220
	public void Reset() { }

	// RVA: 0x757570 Offset: 0x755B70 VA: 0x180757570
	public void .ctor(bool clientside, bool serverside) { }

	// RVA: 0x756E50 Offset: 0x755450 VA: 0x180756E50
	public GameObject FindPrefab(uint prefabID) { }

	// RVA: 0x756C40 Offset: 0x755240 VA: 0x180756C40
	public GameObject FindPrefab(BaseEntity ent) { }

	// RVA: 0x756CE0 Offset: 0x7552E0 VA: 0x180756CE0
	public GameObject FindPrefab(string strPrefab) { }

	// RVA: 0x7564B0 Offset: 0x754AB0 VA: 0x1807564B0
	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	// RVA: 0x7563E0 Offset: 0x7549E0 VA: 0x1807563E0
	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: 0x7565C0 Offset: 0x754BC0 VA: 0x1807565C0
	public GameObject CreatePrefab(string strPrefab, bool active = True) { }

	// RVA: 0x7566F0 Offset: 0x754CF0 VA: 0x1807566F0
	public GameObject CreatePrefab(string strPrefab, Transform parent, bool active = True) { }

	// RVA: 0x756190 Offset: 0x754790 VA: 0x180756190
	public BaseEntity CreateEntity(string strPrefab, Vector3 pos, Quaternion rot, bool startActive = True) { }

	// RVA: 0x756EE0 Offset: 0x7554E0 VA: 0x180756EE0
	private GameObject Instantiate(string strPrefab, Vector3 pos, Quaternion rot) { }

	// RVA: 0x756B30 Offset: 0x755130 VA: 0x180756B30
	public static void Destroy(Component component, float delay = 0) { }

	// RVA: 0x756A20 Offset: 0x755020 VA: 0x180756A20
	public static void Destroy(GameObject instance, float delay = 0) { }

	// RVA: 0x756830 Offset: 0x754E30 VA: 0x180756830
	public static void DestroyImmediate(Component component, bool allowDestroyingAssets = False) { }

	// RVA: 0x756940 Offset: 0x754F40 VA: 0x180756940
	public static void DestroyImmediate(GameObject instance, bool allowDestroyingAssets = False) { }

	// RVA: 0x757240 Offset: 0x755840 VA: 0x180757240
	public void Retire(GameObject instance) { }

	// RVA: 0x757480 Offset: 0x755A80 VA: 0x180757480
	private static void .cctor() { }

}

