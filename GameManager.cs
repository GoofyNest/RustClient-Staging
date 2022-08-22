public class GameManager // TypeDefIndex: 9880
{	// Fields
	public static GameManager client; // 0x0
	internal PrefabPreProcess preProcessed; // 0x10
	internal PrefabPoolCollection pool; // 0x18
	private bool Clientside; // 0x20
	private bool Serverside; // 0x21

	// Methods

	// RVA: 0x7572D0 Offset: 0x7558D0 VA: 0x1807572D0
	public void Reset() { }

	// RVA: 0x757620 Offset: 0x755C20 VA: 0x180757620
	public void .ctor(bool clientside, bool serverside) { }

	// RVA: 0x756F00 Offset: 0x755500 VA: 0x180756F00
	public GameObject FindPrefab(uint prefabID) { }

	// RVA: 0x756CF0 Offset: 0x7552F0 VA: 0x180756CF0
	public GameObject FindPrefab(BaseEntity ent) { }

	// RVA: 0x756D90 Offset: 0x755390 VA: 0x180756D90
	public GameObject FindPrefab(string strPrefab) { }

	// RVA: 0x756560 Offset: 0x754B60 VA: 0x180756560
	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	// RVA: 0x756490 Offset: 0x754A90 VA: 0x180756490
	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: 0x756670 Offset: 0x754C70 VA: 0x180756670
	public GameObject CreatePrefab(string strPrefab, bool active = True) { }

	// RVA: 0x7567A0 Offset: 0x754DA0 VA: 0x1807567A0
	public GameObject CreatePrefab(string strPrefab, Transform parent, bool active = True) { }

	// RVA: 0x756240 Offset: 0x754840 VA: 0x180756240
	public BaseEntity CreateEntity(string strPrefab, Vector3 pos, Quaternion rot, bool startActive = True) { }

	// RVA: 0x756F90 Offset: 0x755590 VA: 0x180756F90
	private GameObject Instantiate(string strPrefab, Vector3 pos, Quaternion rot) { }

	// RVA: 0x756BE0 Offset: 0x7551E0 VA: 0x180756BE0
	public static void Destroy(Component component, float delay = 0) { }

	// RVA: 0x756AD0 Offset: 0x7550D0 VA: 0x180756AD0
	public static void Destroy(GameObject instance, float delay = 0) { }

	// RVA: 0x7568E0 Offset: 0x754EE0 VA: 0x1807568E0
	public static void DestroyImmediate(Component component, bool allowDestroyingAssets = False) { }

	// RVA: 0x7569F0 Offset: 0x754FF0 VA: 0x1807569F0
	public static void DestroyImmediate(GameObject instance, bool allowDestroyingAssets = False) { }

	// RVA: 0x7572F0 Offset: 0x7558F0 VA: 0x1807572F0
	public void Retire(GameObject instance) { }

	// RVA: 0x757530 Offset: 0x755B30 VA: 0x180757530
	private static void .cctor() { }

}

