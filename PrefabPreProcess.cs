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

	// RVA: 0x9A59C0 Offset: 0x9A3FC0 VA: 0x1809A59C0
	public void .ctor(bool clientside, bool serverside, bool bundling = False) { }

	// RVA: 0x9A2B00 Offset: 0x9A1100 VA: 0x1809A2B00
	public GameObject Find(string strPrefab) { }

	// RVA: 0x9A3040 Offset: 0x9A1640 VA: 0x1809A3040
	public bool NeedsProcessing(GameObject go) { }

	// RVA: 0x9A3340 Offset: 0x9A1940 VA: 0x1809A3340
	public void ProcessObject(string name, GameObject go, bool resetLocalTransform = True) { }

	// RVA: 0x9A40F0 Offset: 0x9A26F0 VA: 0x1809A40F0
	public void Process(string name, GameObject go) { }

	// RVA: 0x9A2F50 Offset: 0x9A1550 VA: 0x1809A2F50
	public void Invalidate(string name) { }

	// RVA: 0x9A2BE0 Offset: 0x9A11E0 VA: 0x1809A2BE0
	public GameObject GetHierarchyGroup() { }

	// RVA: 0x9A2380 Offset: 0x9A0980 VA: 0x1809A2380
	public void AddPrefab(string name, GameObject go) { }

	// RVA: 0x9A2400 Offset: 0x9A0A00 VA: 0x1809A2400
	private void DestroyComponents(Type t, GameObject go, bool client, bool server) { }

	// RVA: 0x9A4810 Offset: 0x9A2E10 VA: 0x1809A4810
	private bool ShouldExclude(Transform transform) { }

	// RVA: -1 Offset: -1
	private bool HasComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E2F0 Offset: 0x125C8F0 VA: 0x18125E2F0
	|-PrefabPreProcess.HasComponents<IClientComponentEx>
	|-PrefabPreProcess.HasComponents<IEditorComponent>
	|-PrefabPreProcess.HasComponents<IPrefabPostProcess>
	|-PrefabPreProcess.HasComponents<IPrefabPreProcess>
	|-PrefabPreProcess.HasComponents<IServerComponentEx>
	|-PrefabPreProcess.HasComponents<object>
	*/

	// RVA: 0x9A2CC0 Offset: 0x9A12C0 VA: 0x1809A2CC0
	private bool HasComponents(Transform transform, Type t) { }

	// RVA: -1 Offset: -1
	public List<T> FindComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AF670 Offset: 0x12ADC70 VA: 0x1812AF670
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
	|-RVA: 0xCFE7D0 Offset: 0xCFCDD0 VA: 0x180CFE7D0
	|-PrefabPreProcess.FindComponents<object>
	*/

	// RVA: 0x9A27D0 Offset: 0x9A0DD0 VA: 0x1809A27D0
	public List<Component> FindComponents(Transform transform, Type t) { }

	// RVA: 0x9A2860 Offset: 0x9A0E60 VA: 0x1809A2860
	public void FindComponents(Transform transform, List<Component> list, Type t) { }

	// RVA: 0x9A42E0 Offset: 0x9A28E0 VA: 0x1809A42E0 Slot: 4
	public void RemoveComponent(Component c) { }

	// RVA: 0x9A4370 Offset: 0x9A2970 VA: 0x1809A4370
	public void RemoveComponents(GameObject gameObj) { }

	// RVA: 0x9A32E0 Offset: 0x9A18E0 VA: 0x1809A32E0 Slot: 5
	public void NominateForDeletion(GameObject gameObj) { }

	// RVA: 0x9A4470 Offset: 0x9A2A70 VA: 0x1809A4470
	private void RunCleanupQueue() { }

	// RVA: 0x9A2690 Offset: 0x9A0C90 VA: 0x1809A2690
	private void DoCleanup(GameObject go) { }

	// RVA: 0x9A4890 Offset: 0x9A2E90 VA: 0x1809A4890
	private static void .cctor() { }

}

private sealed class PrefabPreProcess.<>c__DisplayClass8_0 // TypeDefIndex: 9976
{	// Fields
	public PrefabPreProcess <>4__this; // 0x10
	public GameObject go; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9A9300 Offset: 0x9A7900 VA: 0x1809A9300
	internal bool <NeedsProcessing>b__0(Type type) { }

	// RVA: 0x9A9300 Offset: 0x9A7900 VA: 0x1809A9300
	internal bool <NeedsProcessing>b__1(Type type) { }

}

