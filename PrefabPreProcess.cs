public class PrefabPreProcess : IPrefabProcessor // TypeDefIndex: 9975
{	public static Type[] clientsideOnlyTypes; // 0x0
	public static Type[] serversideOnlyTypes; // 0x8
	public bool isClientside; // 0x10
	public bool isServerside; // 0x11
	public bool isBundling; // 0x12
	internal Dictionary<string, GameObject> prefabList; // 0x18
	private List<Component> destroyList; // 0x20
	private List<GameObject> cleanupList; // 0x28


	public void .ctor(bool clientside, bool serverside, bool bundling = False) { }

	public GameObject Find(string strPrefab) { }

	public bool NeedsProcessing(GameObject go) { }

	public void ProcessObject(string name, GameObject go, bool resetLocalTransform = True) { }

	public void Process(string name, GameObject go) { }

	public void Invalidate(string name) { }

	public GameObject GetHierarchyGroup() { }

	public void AddPrefab(string name, GameObject go) { }

	private void DestroyComponents(Type t, GameObject go, bool client, bool server) { }

	private bool ShouldExclude(Transform transform) { }

	private bool HasComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125EC50 Offset: 0x125D250 VA: 0x18125EC50
	|-PrefabPreProcess.HasComponents<IClientComponentEx>
	|-PrefabPreProcess.HasComponents<IEditorComponent>
	|-PrefabPreProcess.HasComponents<IPrefabPostProcess>
	|-PrefabPreProcess.HasComponents<IPrefabPreProcess>
	|-PrefabPreProcess.HasComponents<IServerComponentEx>
	|-PrefabPreProcess.HasComponents<object>
	*/

	private bool HasComponents(Transform transform, Type t) { }

	public List<T> FindComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AFFD0 Offset: 0x12AE5D0 VA: 0x1812AFFD0
	|-PrefabPreProcess.FindComponents<IClientComponentEx>
	|-PrefabPreProcess.FindComponents<IPrefabPostProcess>
	|-PrefabPreProcess.FindComponents<IPrefabPreProcess>
	|-PrefabPreProcess.FindComponents<IServerComponentEx>
	|-PrefabPreProcess.FindComponents<object>
	|-PrefabPreProcess.FindComponents<MeshCollider>
	|-PrefabPreProcess.FindComponents<Transform>
	*/

	public void FindComponents<T>(Transform transform, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFEF30 Offset: 0xCFD530 VA: 0x180CFEF30
	|-PrefabPreProcess.FindComponents<object>
	*/

	public List<Component> FindComponents(Transform transform, Type t) { }

	public void FindComponents(Transform transform, List<Component> list, Type t) { }

	public void RemoveComponent(Component c) { }

	public void RemoveComponents(GameObject gameObj) { }

	public void NominateForDeletion(GameObject gameObj) { }

	private void RunCleanupQueue() { }

	private void DoCleanup(GameObject go) { }

	private static void .cctor() { }

}

private sealed class PrefabPreProcess.<>c__DisplayClass8_0 // TypeDefIndex: 9976
{	public PrefabPreProcess <>4__this; // 0x10
	public GameObject go; // 0x18


	public void .ctor() { }

	internal bool <NeedsProcessing>b__0(Type type) { }

	internal bool <NeedsProcessing>b__1(Type type) { }

}

