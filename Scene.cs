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
	// RVA: 0x19A1FE0 Offset: 0x19A05E0 VA: 0x1819A1FE0
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19A1C80 Offset: 0x19A0280 VA: 0x1819A1C80
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19A1C40 Offset: 0x19A0240 VA: 0x1819A1C40
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19A1C00 Offset: 0x19A0200 VA: 0x1819A1C00
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19A1CC0 Offset: 0x19A02C0 VA: 0x1819A1CC0
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE1900 Offset: 0xE0D00 VA: 0x1800E1900
	// RVA: 0x19A1D00 Offset: 0x19A0300 VA: 0x1819A1D00
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0
	public int get_handle() { }

	// RVA: 0x21DF70 Offset: 0x21D370 VA: 0x18021DF70
	public bool IsValid() { }

	// RVA: 0x21E030 Offset: 0x21D430 VA: 0x18021E030
	public string get_name() { }

	// RVA: 0x21DFF0 Offset: 0x21D3F0 VA: 0x18021DFF0
	public bool get_isLoaded() { }

	// RVA: 0x21DFB0 Offset: 0x21D3B0 VA: 0x18021DFB0
	public int get_buildIndex() { }

	// RVA: 0x21E070 Offset: 0x21D470 VA: 0x18021E070
	public int get_rootCount() { }

	// RVA: 0x21DEB0 Offset: 0x21D2B0 VA: 0x18021DEB0
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x21DF60 Offset: 0x21D360 VA: 0x18021DF60
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21DE30 Offset: 0x21D230 VA: 0x18021DE30 Slot: 0
	public override bool Equals(object other) { }

}

