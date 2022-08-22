public class WorldSplineSharedData : ScriptableObject // TypeDefIndex: 11415
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<WorldSplineData> dataList; // 0x18
	public static WorldSplineSharedData instance; // 0x0
	private static string[] worldSplineFolders; // 0x8


	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x98480 Offset: 0x97880 VA: 0x180098480
	private static void Init() { }

	public static bool TryGetDataFor(WorldSpline worldSpline, out WorldSplineData data) { }

	public void .ctor() { }

	private static void .cctor() { }

}

