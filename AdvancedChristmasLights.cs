public class AdvancedChristmasLights : IOEntity // TypeDefIndex: 8301
{	// Fields
	private Option __menuOption_Menu_Lightmode_Chasing; // 0x288
	private Option __menuOption_Menu_Lightmode_Fade; // 0x2E0
	private Option __menuOption_Menu_Lightmode_Flashing; // 0x338
	private Option __menuOption_Menu_Lightmode_SlowGlow; // 0x390
	private Option __menuOption_Menu_Lightmode_SteadyOn; // 0x3E8
	public GameObjectRef bulbPrefab; // 0x440
	public LineRenderer lineRenderer; // 0x448
	public List<AdvancedChristmasLights.pointEntry> points; // 0x450
	public List<BaseBulb> bulbs; // 0x458
	public float bulbSpacing; // 0x460
	public float wireThickness; // 0x464
	public Transform wireEmission; // 0x468
	public AdvancedChristmasLights.AnimationType animationStyle; // 0x470
	public RendererLOD _lod; // 0x478
	[TooltipAttribute] // RVA: 0xACC90 Offset: 0xAC090 VA: 0x1800ACC90
	public float lengthToPowerRatio; // 0x480
	private bool finalized; // 0x484
	private int lengthUsed; // 0x488
	private int oldAnimationStyle; // 0x48C
	private int oldPointCount; // 0x490

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAA00F0 Offset: 0xA9E6F0 VA: 0x180AA00F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAA1FF0 Offset: 0xAA05F0 VA: 0x180AA1FF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAA10D0 Offset: 0xA9F6D0 VA: 0x180AA10D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAA0090 Offset: 0xA9E690 VA: 0x180AA0090
	public void ClearPoints() { }

	// RVA: 0xAA00E0 Offset: 0xA9E6E0 VA: 0x180AA00E0
	public void FinishEditing() { }

	// RVA: 0xAA0C00 Offset: 0xA9F200 VA: 0x180AA0C00
	public bool IsFinalized() { }

	// RVA: 0xA9FFA0 Offset: 0xA9E5A0 VA: 0x180A9FFA0
	public void AddPoint(Vector3 newPoint, Vector3 newNormal) { }

	// RVA: 0x6F3610 Offset: 0x6F1C10 VA: 0x1806F3610 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAA0C20 Offset: 0xA9F220 VA: 0x180AA0C20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAA11C0 Offset: 0xA9F7C0 VA: 0x180AA11C0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xAA1DB0 Offset: 0xAA03B0 VA: 0x180AA1DB0
	public void UpdateBulbs() { }

	// RVA: 0xAA1C80 Offset: 0xAA0280 VA: 0x180AA1C80 Slot: 159
	public virtual void SetBulbsOn(bool wantsOn) { }

	// RVA: 0xAA1ED0 Offset: 0xAA04D0 VA: 0x180AA1ED0
	public void UpdateCulling() { }

	// RVA: 0xAA1280 Offset: 0xA9F880 VA: 0x180AA1280
	public void RegenerateLights() { }

	[BaseEntity.Menu] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.Description] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.Icon] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.ShowIf] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	// RVA: 0xAA1070 Offset: 0xA9F670 VA: 0x180AA1070
	public void Menu_Lightmode_SteadyOn(BasePlayer player) { }

	// RVA: 0xAA1060 Offset: 0xA9F660 VA: 0x180AA1060
	public bool Menu_Lightmode_SteadyOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.Description] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.Icon] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.ShowIf] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	// RVA: 0xAA0FC0 Offset: 0xA9F5C0 VA: 0x180AA0FC0
	public void Menu_Lightmode_Flashing(BasePlayer player) { }

	// RVA: 0xAA0FB0 Offset: 0xA9F5B0 VA: 0x180AA0FB0
	public bool Menu_Lightmode_Flashing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.Description] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.Icon] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.ShowIf] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	// RVA: 0xAA0F00 Offset: 0xA9F500 VA: 0x180AA0F00
	public void Menu_Lightmode_Chasing(BasePlayer player) { }

	// RVA: 0xAA0EF0 Offset: 0xA9F4F0 VA: 0x180AA0EF0
	public bool Menu_Lightmode_Chasing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.Description] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.Icon] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.ShowIf] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	// RVA: 0xAA0F60 Offset: 0xA9F560 VA: 0x180AA0F60
	public void Menu_Lightmode_Fade(BasePlayer player) { }

	// RVA: 0xAA0F50 Offset: 0xA9F550 VA: 0x180AA0F50
	public bool Menu_Lightmode_Fade_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.Description] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.Icon] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	// RVA: 0xAA1010 Offset: 0xA9F610 VA: 0x180AA1010
	public void Menu_Lightmode_SlowGlow(BasePlayer player) { }

	// RVA: 0xAA10C0 Offset: 0xA9F6C0 VA: 0x180AA10C0
	public bool Menu_Lightmode_slowglow_ShowIf(BasePlayer player) { }

	// RVA: 0xAA0C10 Offset: 0xA9F210 VA: 0x180AA0C10
	public bool IsStyle(AdvancedChristmasLights.AnimationType testType) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool CanPlayerManipulate(BasePlayer player) { }

	// RVA: 0xAA1F00 Offset: 0xAA0500 VA: 0x180AA1F00
	public void .ctor() { }

}

public struct AdvancedChristmasLights.pointEntry // TypeDefIndex: 8302
{	// Fields
	public Vector3 point; // 0x0
	public Vector3 normal; // 0xC

}

public enum AdvancedChristmasLights.AnimationType // TypeDefIndex: 8303
{	// Fields
	public int value__; // 0x0
	public const AdvancedChristmasLights.AnimationType ON = 1;
	public const AdvancedChristmasLights.AnimationType FLASHING = 2;
	public const AdvancedChristmasLights.AnimationType CHASING = 3;
	public const AdvancedChristmasLights.AnimationType FADE = 4;
	public const AdvancedChristmasLights.AnimationType SLOWGLOW = 6;

}

