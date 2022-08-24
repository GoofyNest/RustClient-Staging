public class WorldSplineSharedData : ScriptableObject // TypeDefIndex: 11419
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private List<WorldSplineData> dataList; // 0x18
	public static WorldSplineSharedData instance; // 0x0
	private static string[] worldSplineFolders; // 0x8


	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x97E10 Offset: 0x97210 VA: 0x180097E10
	private static void Init() { }

	public static bool TryGetDataFor(WorldSpline worldSpline, out WorldSplineData data) { }

	public void .ctor() { }

	private static void .cctor() { }

}

