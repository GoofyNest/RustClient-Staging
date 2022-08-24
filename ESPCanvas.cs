public class ESPCanvas : MonoBehaviour // TypeDefIndex: 12009
{	[TooltipAttribute] // RVA: 0xCB000 Offset: 0xCA400 VA: 0x1800CB000
	public int MaxElements; // 0x18
	[TooltipAttribute] // RVA: 0xCB060 Offset: 0xCA460 VA: 0x1800CB060
	public float RefreshRate; // 0x1C
	[TooltipAttribute] // RVA: 0xCB130 Offset: 0xCA530 VA: 0x1800CB130
	public ESPPlayerInfo Source; // 0x20
	[TooltipAttribute] // RVA: 0xCB1E0 Offset: 0xCA5E0 VA: 0x1800CB1E0
	public float MaxDistance; // 0x28
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static float OverrideMaxDisplayDistance; // 0x0
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static bool DisableOcclusionChecks; // 0x4
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static bool ShowHealth; // 0x5
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
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

