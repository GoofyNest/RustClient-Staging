public struct Scene // TypeDefIndex: 3655
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int buildIndex { get; }
	public int rootCount { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19B4920 Offset: 0x19B2F20 VA: 0x1819B4920
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19B45C0 Offset: 0x19B2BC0 VA: 0x1819B45C0
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19B4580 Offset: 0x19B2B80 VA: 0x1819B4580
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19B4540 Offset: 0x19B2B40 VA: 0x1819B4540
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19B4600 Offset: 0x19B2C00 VA: 0x1819B4600
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19B4640 Offset: 0x19B2C40 VA: 0x1819B4640
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	public int get_handle() { }

	// RVA: 0x2229F0 Offset: 0x221DF0 VA: 0x1802229F0
	public bool IsValid() { }

	// RVA: 0x222AB0 Offset: 0x221EB0 VA: 0x180222AB0
	public string get_name() { }

	// RVA: 0x222A70 Offset: 0x221E70 VA: 0x180222A70
	public bool get_isLoaded() { }

	// RVA: 0x222A30 Offset: 0x221E30 VA: 0x180222A30
	public int get_buildIndex() { }

	// RVA: 0x222AF0 Offset: 0x221EF0 VA: 0x180222AF0
	public int get_rootCount() { }

	// RVA: 0x222930 Offset: 0x221D30 VA: 0x180222930
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x2229E0 Offset: 0x221DE0 VA: 0x1802229E0
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2228B0 Offset: 0x221CB0 VA: 0x1802228B0 Slot: 0
	public override bool Equals(object other) { }

}

