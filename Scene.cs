public struct Scene // TypeDefIndex: 3655
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_Handle; // 0x0

	public int handle { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int buildIndex { get; }
	public int rootCount { get; }


	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
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

