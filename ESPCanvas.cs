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

	// RVA: 0x7831A0 Offset: 0x7817A0 VA: 0x1807831A0
	public void Awake() { }

	// RVA: 0x783AA0 Offset: 0x7820A0 VA: 0x180783AA0
	public void Update() { }

	// RVA: 0x7838F0 Offset: 0x781EF0 VA: 0x1807838F0
	private bool StartWatching(BasePlayer entity) { }

	// RVA: 0x783540 Offset: 0x781B40 VA: 0x180783540
	public bool ShouldShow(BasePlayer ent) { }

	// RVA: 0x783260 Offset: 0x781860 VA: 0x180783260
	public static bool IsUsingZoomItem() { }

	// RVA: 0x783C70 Offset: 0x782270 VA: 0x180783C70
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

