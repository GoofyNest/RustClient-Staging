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

	// RVA: 0xAA05C0 Offset: 0xA9EBC0 VA: 0x180AA05C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAA24C0 Offset: 0xAA0AC0 VA: 0x180AA24C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAA15A0 Offset: 0xA9FBA0 VA: 0x180AA15A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAA0560 Offset: 0xA9EB60 VA: 0x180AA0560
	public void ClearPoints() { }

	// RVA: 0xAA05B0 Offset: 0xA9EBB0 VA: 0x180AA05B0
	public void FinishEditing() { }

	// RVA: 0xAA10D0 Offset: 0xA9F6D0 VA: 0x180AA10D0
	public bool IsFinalized() { }

	// RVA: 0xAA0470 Offset: 0xA9EA70 VA: 0x180AA0470
	public void AddPoint(Vector3 newPoint, Vector3 newNormal) { }

	// RVA: 0x6F35A0 Offset: 0x6F1BA0 VA: 0x1806F35A0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAA10F0 Offset: 0xA9F6F0 VA: 0x180AA10F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAA1690 Offset: 0xA9FC90 VA: 0x180AA1690 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xAA2280 Offset: 0xAA0880 VA: 0x180AA2280
	public void UpdateBulbs() { }

	// RVA: 0xAA2150 Offset: 0xAA0750 VA: 0x180AA2150 Slot: 159
	public virtual void SetBulbsOn(bool wantsOn) { }

	// RVA: 0xAA23A0 Offset: 0xAA09A0 VA: 0x180AA23A0
	public void UpdateCulling() { }

	// RVA: 0xAA1750 Offset: 0xA9FD50 VA: 0x180AA1750
	public void RegenerateLights() { }

	[BaseEntity.Menu] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.Description] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.Icon] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.ShowIf] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	// RVA: 0xAA1540 Offset: 0xA9FB40 VA: 0x180AA1540
	public void Menu_Lightmode_SteadyOn(BasePlayer player) { }

	// RVA: 0xAA1530 Offset: 0xA9FB30 VA: 0x180AA1530
	public bool Menu_Lightmode_SteadyOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.Description] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.Icon] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.ShowIf] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	// RVA: 0xAA1490 Offset: 0xA9FA90 VA: 0x180AA1490
	public void Menu_Lightmode_Flashing(BasePlayer player) { }

	// RVA: 0xAA1480 Offset: 0xA9FA80 VA: 0x180AA1480
	public bool Menu_Lightmode_Flashing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.Description] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.Icon] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.ShowIf] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	// RVA: 0xAA13D0 Offset: 0xA9F9D0 VA: 0x180AA13D0
	public void Menu_Lightmode_Chasing(BasePlayer player) { }

	// RVA: 0xAA13C0 Offset: 0xA9F9C0 VA: 0x180AA13C0
	public bool Menu_Lightmode_Chasing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.Description] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.Icon] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.ShowIf] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	// RVA: 0xAA1430 Offset: 0xA9FA30 VA: 0x180AA1430
	public void Menu_Lightmode_Fade(BasePlayer player) { }

	// RVA: 0xAA1420 Offset: 0xA9FA20 VA: 0x180AA1420
	public bool Menu_Lightmode_Fade_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.Description] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.Icon] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	// RVA: 0xAA14E0 Offset: 0xA9FAE0 VA: 0x180AA14E0
	public void Menu_Lightmode_SlowGlow(BasePlayer player) { }

	// RVA: 0xAA1590 Offset: 0xA9FB90 VA: 0x180AA1590
	public bool Menu_Lightmode_slowglow_ShowIf(BasePlayer player) { }

	// RVA: 0xAA10E0 Offset: 0xA9F6E0 VA: 0x180AA10E0
	public bool IsStyle(AdvancedChristmasLights.AnimationType testType) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool CanPlayerManipulate(BasePlayer player) { }

	// RVA: 0xAA23D0 Offset: 0xAA09D0 VA: 0x180AA23D0
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

