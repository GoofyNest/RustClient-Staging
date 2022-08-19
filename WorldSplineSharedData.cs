public class WorldSplineSharedData : ScriptableObject // TypeDefIndex: 11415
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<WorldSplineData> dataList; // 0x18
	public static WorldSplineSharedData instance; // 0x0
	private static string[] worldSplineFolders; // 0x8

	// Methods

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x983F0 Offset: 0x977F0 VA: 0x1800983F0
	// RVA: 0x1A9F1D0 Offset: 0x1A9D7D0 VA: 0x181A9F1D0
	private static void Init() { }

	// RVA: 0x1A9F250 Offset: 0x1A9D850 VA: 0x181A9F250
	public static bool TryGetDataFor(WorldSpline worldSpline, out WorldSplineData data) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

	// RVA: 0x1A9F410 Offset: 0x1A9DA10 VA: 0x181A9F410
	private static void .cctor() { }

}

