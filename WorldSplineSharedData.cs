public class WorldSplineSharedData : ScriptableObject // TypeDefIndex: 11415
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<WorldSplineData> dataList; // 0x18
	public static WorldSplineSharedData instance; // 0x0
	private static string[] worldSplineFolders; // 0x8

	// Methods

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x98480 Offset: 0x97880 VA: 0x180098480
	// RVA: 0x1A75C60 Offset: 0x1A74260 VA: 0x181A75C60
	private static void Init() { }

	// RVA: 0x1A75CE0 Offset: 0x1A742E0 VA: 0x181A75CE0
	public static bool TryGetDataFor(WorldSpline worldSpline, out WorldSplineData data) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

	// RVA: 0x1A75EA0 Offset: 0x1A744A0 VA: 0x181A75EA0
	private static void .cctor() { }

}

