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

	// RVA: 0x9A6170 Offset: 0x9A4770 VA: 0x1809A6170
	public void .ctor(bool clientside, bool serverside, bool bundling = False) { }

	// RVA: 0x9A32B0 Offset: 0x9A18B0 VA: 0x1809A32B0
	public GameObject Find(string strPrefab) { }

	// RVA: 0x9A37F0 Offset: 0x9A1DF0 VA: 0x1809A37F0
	public bool NeedsProcessing(GameObject go) { }

	// RVA: 0x9A3AF0 Offset: 0x9A20F0 VA: 0x1809A3AF0
	public void ProcessObject(string name, GameObject go, bool resetLocalTransform = True) { }

	// RVA: 0x9A48A0 Offset: 0x9A2EA0 VA: 0x1809A48A0
	public void Process(string name, GameObject go) { }

	// RVA: 0x9A3700 Offset: 0x9A1D00 VA: 0x1809A3700
	public void Invalidate(string name) { }

	// RVA: 0x9A3390 Offset: 0x9A1990 VA: 0x1809A3390
	public GameObject GetHierarchyGroup() { }

	// RVA: 0x9A2B30 Offset: 0x9A1130 VA: 0x1809A2B30
	public void AddPrefab(string name, GameObject go) { }

	// RVA: 0x9A2BB0 Offset: 0x9A11B0 VA: 0x1809A2BB0
	private void DestroyComponents(Type t, GameObject go, bool client, bool server) { }

	// RVA: 0x9A4FC0 Offset: 0x9A35C0 VA: 0x1809A4FC0
	private bool ShouldExclude(Transform transform) { }

	// RVA: -1 Offset: -1
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

	// RVA: 0x9A3470 Offset: 0x9A1A70 VA: 0x1809A3470
	private bool HasComponents(Transform transform, Type t) { }

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
	public void FindComponents<T>(Transform transform, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFEF30 Offset: 0xCFD530 VA: 0x180CFEF30
	|-PrefabPreProcess.FindComponents<object>
	*/

	// RVA: 0x9A2F80 Offset: 0x9A1580 VA: 0x1809A2F80
	public List<Component> FindComponents(Transform transform, Type t) { }

	// RVA: 0x9A3010 Offset: 0x9A1610 VA: 0x1809A3010
	public void FindComponents(Transform transform, List<Component> list, Type t) { }

	// RVA: 0x9A4A90 Offset: 0x9A3090 VA: 0x1809A4A90 Slot: 4
	public void RemoveComponent(Component c) { }

	// RVA: 0x9A4B20 Offset: 0x9A3120 VA: 0x1809A4B20
	public void RemoveComponents(GameObject gameObj) { }

	// RVA: 0x9A3A90 Offset: 0x9A2090 VA: 0x1809A3A90 Slot: 5
	public void NominateForDeletion(GameObject gameObj) { }

	// RVA: 0x9A4C20 Offset: 0x9A3220 VA: 0x1809A4C20
	private void RunCleanupQueue() { }

	// RVA: 0x9A2E40 Offset: 0x9A1440 VA: 0x1809A2E40
	private void DoCleanup(GameObject go) { }

	// RVA: 0x9A5040 Offset: 0x9A3640 VA: 0x1809A5040
	private static void .cctor() { }

}

private sealed class PrefabPreProcess.<>c__DisplayClass8_0 // TypeDefIndex: 9976
{	// Fields
	public PrefabPreProcess <>4__this; // 0x10
	public GameObject go; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9A9AB0 Offset: 0x9A80B0 VA: 0x1809A9AB0
	internal bool <NeedsProcessing>b__0(Type type) { }

	// RVA: 0x9A9AB0 Offset: 0x9A80B0 VA: 0x1809A9AB0
	internal bool <NeedsProcessing>b__1(Type type) { }

}

