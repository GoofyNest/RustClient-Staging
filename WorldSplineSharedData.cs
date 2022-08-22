public class WorldSplineSharedData : ScriptableObject // TypeDefIndex: 11415
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<WorldSplineData> dataList; // 0x18
	public static WorldSplineSharedData instance; // 0x0
	private static string[] worldSplineFolders; // 0x8

	// Methods

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x98480 Offset: 0x97880 VA: 0x180098480
	// RVA: 0x1A89450 Offset: 0x1A87A50 VA: 0x181A89450
	private static void Init() { }

	// RVA: 0x1A894D0 Offset: 0x1A87AD0 VA: 0x181A894D0
	public static bool TryGetDataFor(WorldSpline worldSpline, out WorldSplineData data) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

	// RVA: 0x1A89690 Offset: 0x1A87C90 VA: 0x181A89690
	private static void .cctor() { }

}

