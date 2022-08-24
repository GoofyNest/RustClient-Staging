public class ESPCanvas : MonoBehaviour // TypeDefIndex: 12009
{	[TooltipAttribute] // RVA: 0xCB590 Offset: 0xCA990 VA: 0x1800CB590
	public int MaxElements; // 0x18
	[TooltipAttribute] // RVA: 0xCB740 Offset: 0xCAB40 VA: 0x1800CB740
	public float RefreshRate; // 0x1C
	[TooltipAttribute] // RVA: 0xCB850 Offset: 0xCAC50 VA: 0x1800CB850
	public ESPPlayerInfo Source; // 0x20
	[TooltipAttribute] // RVA: 0xCBB00 Offset: 0xCAF00 VA: 0x1800CBB00
	public float MaxDistance; // 0x28
	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static float OverrideMaxDisplayDistance; // 0x0
	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static bool DisableOcclusionChecks; // 0x4
	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static bool ShowHealth; // 0x5
	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static bool ColourCodeTeams; // 0x6
	protected ESPPlayerInfo[] Elements; // 0x30
	protected RealTimeSince timeSinceRefreshed; // 0x38
	private static int lastCheckedZoomFrame; // 0x8
	private static bool cachedUsingZoomItem; // 0xC


	public void Awake() { }

	public void Update() { }

	private bool StartWatching(BasePlayer entity) { }

	public bool ShouldShow(BasePlayer ent) { }

	public static bool IsUsingZoomItem() { }

	public void .ctor() { }

	private static void .cctor() { }

}

