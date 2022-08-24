public struct Scene // TypeDefIndex: 3655
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int m_Handle; // 0x0

	public int handle { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int buildIndex { get; }
	public int rootCount { get; }


	[StaticAccessorAttribute] // RVA: 0xE19A0 Offset: 0xE0DA0 VA: 0x1800E19A0
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE19A0 Offset: 0xE0DA0 VA: 0x1800E19A0
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE19A0 Offset: 0xE0DA0 VA: 0x1800E19A0
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE19A0 Offset: 0xE0DA0 VA: 0x1800E19A0
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE19A0 Offset: 0xE0DA0 VA: 0x1800E19A0
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE19A0 Offset: 0xE0DA0 VA: 0x1800E19A0
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	public int get_handle() { }

	public bool IsValid() { }

	public string get_name() { }

	public bool get_isLoaded() { }

	public int get_buildIndex() { }

	public int get_rootCount() { }

	public GameObject[] GetRootGameObjects() { }

	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

}

