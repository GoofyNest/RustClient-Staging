public class GameManager // TypeDefIndex: 9880
{	// Fields
	public static GameManager client; // 0x0
	internal PrefabPreProcess preProcessed; // 0x10
	internal PrefabPoolCollection pool; // 0x18
	private bool Clientside; // 0x20
	private bool Serverside; // 0x21

	// Methods

	// RVA: 0x7571C0 Offset: 0x7557C0 VA: 0x1807571C0
	public void Reset() { }

	// RVA: 0x757510 Offset: 0x755B10 VA: 0x180757510
	public void .ctor(bool clientside, bool serverside) { }

	// RVA: 0x756DF0 Offset: 0x7553F0 VA: 0x180756DF0
	public GameObject FindPrefab(uint prefabID) { }

	// RVA: 0x756BE0 Offset: 0x7551E0 VA: 0x180756BE0
	public GameObject FindPrefab(BaseEntity ent) { }

	// RVA: 0x756C80 Offset: 0x755280 VA: 0x180756C80
	public GameObject FindPrefab(string strPrefab) { }

	// RVA: 0x756450 Offset: 0x754A50 VA: 0x180756450
	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	// RVA: 0x756380 Offset: 0x754980 VA: 0x180756380
	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: 0x756560 Offset: 0x754B60 VA: 0x180756560
	public GameObject CreatePrefab(string strPrefab, bool active = True) { }

	// RVA: 0x756690 Offset: 0x754C90 VA: 0x180756690
	public GameObject CreatePrefab(string strPrefab, Transform parent, bool active = True) { }

	// RVA: 0x756130 Offset: 0x754730 VA: 0x180756130
	public BaseEntity CreateEntity(string strPrefab, Vector3 pos, Quaternion rot, bool startActive = True) { }

	// RVA: 0x756E80 Offset: 0x755480 VA: 0x180756E80
	private GameObject Instantiate(string strPrefab, Vector3 pos, Quaternion rot) { }

	// RVA: 0x756AD0 Offset: 0x7550D0 VA: 0x180756AD0
	public static void Destroy(Component component, float delay = 0) { }

	// RVA: 0x7569C0 Offset: 0x754FC0 VA: 0x1807569C0
	public static void Destroy(GameObject instance, float delay = 0) { }

	// RVA: 0x7567D0 Offset: 0x754DD0 VA: 0x1807567D0
	public static void DestroyImmediate(Component component, bool allowDestroyingAssets = False) { }

	// RVA: 0x7568E0 Offset: 0x754EE0 VA: 0x1807568E0
	public static void DestroyImmediate(GameObject instance, bool allowDestroyingAssets = False) { }

	// RVA: 0x7571E0 Offset: 0x7557E0 VA: 0x1807571E0
	public void Retire(GameObject instance) { }

	// RVA: 0x757420 Offset: 0x755A20 VA: 0x180757420
	private static void .cctor() { }

}

