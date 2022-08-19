public struct Scene // TypeDefIndex: 3655
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int buildIndex { get; }
	public int rootCount { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xE1830 Offset: 0xE0C30 VA: 0x1800E1830
	// RVA: 0x19B4960 Offset: 0x19B2F60 VA: 0x1819B4960
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1830 Offset: 0xE0C30 VA: 0x1800E1830
	// RVA: 0x19B4600 Offset: 0x19B2C00 VA: 0x1819B4600
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1830 Offset: 0xE0C30 VA: 0x1800E1830
	// RVA: 0x19B45C0 Offset: 0x19B2BC0 VA: 0x1819B45C0
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1830 Offset: 0xE0C30 VA: 0x1800E1830
	// RVA: 0x19B4580 Offset: 0x19B2B80 VA: 0x1819B4580
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1830 Offset: 0xE0C30 VA: 0x1800E1830
	// RVA: 0x19B4640 Offset: 0x19B2C40 VA: 0x1819B4640
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1830 Offset: 0xE0C30 VA: 0x1800E1830
	// RVA: 0x19B4680 Offset: 0x19B2C80 VA: 0x1819B4680
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_handle() { }

	// RVA: 0x222A70 Offset: 0x221E70 VA: 0x180222A70
	public bool IsValid() { }

	// RVA: 0x222B30 Offset: 0x221F30 VA: 0x180222B30
	public string get_name() { }

	// RVA: 0x222AF0 Offset: 0x221EF0 VA: 0x180222AF0
	public bool get_isLoaded() { }

	// RVA: 0x222AB0 Offset: 0x221EB0 VA: 0x180222AB0
	public int get_buildIndex() { }

	// RVA: 0x222B70 Offset: 0x221F70 VA: 0x180222B70
	public int get_rootCount() { }

	// RVA: 0x2229B0 Offset: 0x221DB0 VA: 0x1802229B0
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x222A60 Offset: 0x221E60 VA: 0x180222A60
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x222930 Offset: 0x221D30 VA: 0x180222930 Slot: 0
	public override bool Equals(object other) { }

}

