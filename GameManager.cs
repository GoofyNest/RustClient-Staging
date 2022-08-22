public class GameManager // TypeDefIndex: 9880
{	public static GameManager client; // 0x0
	internal PrefabPreProcess preProcessed; // 0x10
	internal PrefabPoolCollection pool; // 0x18
	private bool Clientside; // 0x20
	private bool Serverside; // 0x21


	public void Reset() { }

	public void .ctor(bool clientside, bool serverside) { }

	public GameObject FindPrefab(uint prefabID) { }

	public GameObject FindPrefab(BaseEntity ent) { }

	public GameObject FindPrefab(string strPrefab) { }

	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, bool active = True) { }

	public GameObject CreatePrefab(string strPrefab, bool active = True) { }

	public GameObject CreatePrefab(string strPrefab, Transform parent, bool active = True) { }

	public BaseEntity CreateEntity(string strPrefab, Vector3 pos, Quaternion rot, bool startActive = True) { }

	private GameObject Instantiate(string strPrefab, Vector3 pos, Quaternion rot) { }

	public static void Destroy(Component component, float delay = 0) { }

	public static void Destroy(GameObject instance, float delay = 0) { }

	public static void DestroyImmediate(Component component, bool allowDestroyingAssets = False) { }

	public static void DestroyImmediate(GameObject instance, bool allowDestroyingAssets = False) { }

	public void Retire(GameObject instance) { }

	private static void .cctor() { }

}

