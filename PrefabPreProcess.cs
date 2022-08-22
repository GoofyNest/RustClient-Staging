public class PrefabPreProcess : IPrefabProcessor // TypeDefIndex: 9975
{	// Fields
	public static Type[] clientsideOnlyTypes; // 0x0
	public static Type[] serversideOnlyTypes; // 0x8
	public bool isClientside; // 0x10
	public bool isServerside; // 0x11
	public bool isBundling; // 0x12
	internal Dictionary<string, GameObject> prefabList; // 0x18
	private List<Component> destroyList; // 0x20
	private List<GameObject> cleanupList; // 0x28

	// Methods

	// RVA: 0x9A5C80 Offset: 0x9A4280 VA: 0x1809A5C80
	public void .ctor(bool clientside, bool serverside, bool bundling = False) { }

	// RVA: 0x9A2DC0 Offset: 0x9A13C0 VA: 0x1809A2DC0
	public GameObject Find(string strPrefab) { }

	// RVA: 0x9A3300 Offset: 0x9A1900 VA: 0x1809A3300
	public bool NeedsProcessing(GameObject go) { }

	// RVA: 0x9A3600 Offset: 0x9A1C00 VA: 0x1809A3600
	public void ProcessObject(string name, GameObject go, bool resetLocalTransform = True) { }

	// RVA: 0x9A43B0 Offset: 0x9A29B0 VA: 0x1809A43B0
	public void Process(string name, GameObject go) { }

	// RVA: 0x9A3210 Offset: 0x9A1810 VA: 0x1809A3210
	public void Invalidate(string name) { }

	// RVA: 0x9A2EA0 Offset: 0x9A14A0 VA: 0x1809A2EA0
	public GameObject GetHierarchyGroup() { }

	// RVA: 0x9A2640 Offset: 0x9A0C40 VA: 0x1809A2640
	public void AddPrefab(string name, GameObject go) { }

	// RVA: 0x9A26C0 Offset: 0x9A0CC0 VA: 0x1809A26C0
	private void DestroyComponents(Type t, GameObject go, bool client, bool server) { }

	// RVA: 0x9A4AD0 Offset: 0x9A30D0 VA: 0x1809A4AD0
	private bool ShouldExclude(Transform transform) { }

	// RVA: -1 Offset: -1
	private bool HasComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E5B0 Offset: 0x125CBB0 VA: 0x18125E5B0
	|-PrefabPreProcess.HasComponents<IClientComponentEx>
	|-PrefabPreProcess.HasComponents<IEditorComponent>
	|-PrefabPreProcess.HasComponents<IPrefabPostProcess>
	|-PrefabPreProcess.HasComponents<IPrefabPreProcess>
	|-PrefabPreProcess.HasComponents<IServerComponentEx>
	|-PrefabPreProcess.HasComponents<object>
	*/

	// RVA: 0x9A2F80 Offset: 0x9A1580 VA: 0x1809A2F80
	private bool HasComponents(Transform transform, Type t) { }

	// RVA: -1 Offset: -1
	public List<T> FindComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AF930 Offset: 0x12ADF30 VA: 0x1812AF930
	|-PrefabPreProcess.FindComponents<IClientComponentEx>
	|-PrefabPreProcess.FindComponents<IPrefabPostProcess>
	|-PrefabPreProcess.FindComponents<IPrefabPreProcess>
	|-PrefabPreProcess.FindComponents<IServerComponentEx>
	|-PrefabPreProcess.FindComponents<object>
	|-PrefabPreProcess.FindComponents<MeshCollider>
	|-PrefabPreProcess.FindComponents<Transform>
	*/

	// RVA: -1 Offset: -1
	public void FindComponents<T>(Transform transform, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFEA90 Offset: 0xCFD090 VA: 0x180CFEA90
	|-PrefabPreProcess.FindComponents<object>
	*/

	// RVA: 0x9A2A90 Offset: 0x9A1090 VA: 0x1809A2A90
	public List<Component> FindComponents(Transform transform, Type t) { }

	// RVA: 0x9A2B20 Offset: 0x9A1120 VA: 0x1809A2B20
	public void FindComponents(Transform transform, List<Component> list, Type t) { }

	// RVA: 0x9A45A0 Offset: 0x9A2BA0 VA: 0x1809A45A0 Slot: 4
	public void RemoveComponent(Component c) { }

	// RVA: 0x9A4630 Offset: 0x9A2C30 VA: 0x1809A4630
	public void RemoveComponents(GameObject gameObj) { }

	// RVA: 0x9A35A0 Offset: 0x9A1BA0 VA: 0x1809A35A0 Slot: 5
	public void NominateForDeletion(GameObject gameObj) { }

	// RVA: 0x9A4730 Offset: 0x9A2D30 VA: 0x1809A4730
	private void RunCleanupQueue() { }

	// RVA: 0x9A2950 Offset: 0x9A0F50 VA: 0x1809A2950
	private void DoCleanup(GameObject go) { }

	// RVA: 0x9A4B50 Offset: 0x9A3150 VA: 0x1809A4B50
	private static void .cctor() { }

}

private sealed class PrefabPreProcess.<>c__DisplayClass8_0 // TypeDefIndex: 9976
{	// Fields
	public PrefabPreProcess <>4__this; // 0x10
	public GameObject go; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9A95C0 Offset: 0x9A7BC0 VA: 0x1809A95C0
	internal bool <NeedsProcessing>b__0(Type type) { }

	// RVA: 0x9A95C0 Offset: 0x9A7BC0 VA: 0x1809A95C0
	internal bool <NeedsProcessing>b__1(Type type) { }

}

