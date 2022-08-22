public class ESPCanvas : MonoBehaviour // TypeDefIndex: 12005
{	// Fields
	[TooltipAttribute] // RVA: 0xCB310 Offset: 0xCA710 VA: 0x1800CB310
	public int MaxElements; // 0x18
	[TooltipAttribute] // RVA: 0xCB3C0 Offset: 0xCA7C0 VA: 0x1800CB3C0
	public float RefreshRate; // 0x1C
	[TooltipAttribute] // RVA: 0xCB510 Offset: 0xCA910 VA: 0x1800CB510
	public ESPPlayerInfo Source; // 0x20
	[TooltipAttribute] // RVA: 0xCB6D0 Offset: 0xCAAD0 VA: 0x1800CB6D0
	public float MaxDistance; // 0x28
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static float OverrideMaxDisplayDistance; // 0x0
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool DisableOcclusionChecks; // 0x4
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool ShowHealth; // 0x5
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool ColourCodeTeams; // 0x6
	protected ESPPlayerInfo[] Elements; // 0x30
	protected RealTimeSince timeSinceRefreshed; // 0x38
	private static int lastCheckedZoomFrame; // 0x8
	private static bool cachedUsingZoomItem; // 0xC

	// Methods

	// RVA: 0x783200 Offset: 0x781800 VA: 0x180783200
	public void Awake() { }

	// RVA: 0x783B00 Offset: 0x782100 VA: 0x180783B00
	public void Update() { }

	// RVA: 0x783950 Offset: 0x781F50 VA: 0x180783950
	private bool StartWatching(BasePlayer entity) { }

	// RVA: 0x7835A0 Offset: 0x781BA0 VA: 0x1807835A0
	public bool ShouldShow(BasePlayer ent) { }

	// RVA: 0x7832C0 Offset: 0x7818C0 VA: 0x1807832C0
	public static bool IsUsingZoomItem() { }

	// RVA: 0x783CD0 Offset: 0x7822D0 VA: 0x180783CD0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

