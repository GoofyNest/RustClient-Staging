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

	// RVA: 0xA9FE30 Offset: 0xA9E430 VA: 0x180A9FE30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAA1D30 Offset: 0xAA0330 VA: 0x180AA1D30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAA0E10 Offset: 0xA9F410 VA: 0x180AA0E10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA9FDD0 Offset: 0xA9E3D0 VA: 0x180A9FDD0
	public void ClearPoints() { }

	// RVA: 0xA9FE20 Offset: 0xA9E420 VA: 0x180A9FE20
	public void FinishEditing() { }

	// RVA: 0xAA0940 Offset: 0xA9EF40 VA: 0x180AA0940
	public bool IsFinalized() { }

	// RVA: 0xA9FCE0 Offset: 0xA9E2E0 VA: 0x180A9FCE0
	public void AddPoint(Vector3 newPoint, Vector3 newNormal) { }

	// RVA: 0x6F3500 Offset: 0x6F1B00 VA: 0x1806F3500 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAA0960 Offset: 0xA9EF60 VA: 0x180AA0960 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAA0F00 Offset: 0xA9F500 VA: 0x180AA0F00 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xAA1AF0 Offset: 0xAA00F0 VA: 0x180AA1AF0
	public void UpdateBulbs() { }

	// RVA: 0xAA19C0 Offset: 0xA9FFC0 VA: 0x180AA19C0 Slot: 159
	public virtual void SetBulbsOn(bool wantsOn) { }

	// RVA: 0xAA1C10 Offset: 0xAA0210 VA: 0x180AA1C10
	public void UpdateCulling() { }

	// RVA: 0xAA0FC0 Offset: 0xA9F5C0 VA: 0x180AA0FC0
	public void RegenerateLights() { }

	[BaseEntity.Menu] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.Description] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.Icon] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[BaseEntity.Menu.ShowIf] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	// RVA: 0xAA0DB0 Offset: 0xA9F3B0 VA: 0x180AA0DB0
	public void Menu_Lightmode_SteadyOn(BasePlayer player) { }

	// RVA: 0xAA0DA0 Offset: 0xA9F3A0 VA: 0x180AA0DA0
	public bool Menu_Lightmode_SteadyOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.Description] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.Icon] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	[BaseEntity.Menu.ShowIf] // RVA: 0xAD030 Offset: 0xAC430 VA: 0x1800AD030
	// RVA: 0xAA0D00 Offset: 0xA9F300 VA: 0x180AA0D00
	public void Menu_Lightmode_Flashing(BasePlayer player) { }

	// RVA: 0xAA0CF0 Offset: 0xA9F2F0 VA: 0x180AA0CF0
	public bool Menu_Lightmode_Flashing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.Description] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.Icon] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	[BaseEntity.Menu.ShowIf] // RVA: 0xAE850 Offset: 0xADC50 VA: 0x1800AE850
	// RVA: 0xAA0C40 Offset: 0xA9F240 VA: 0x180AA0C40
	public void Menu_Lightmode_Chasing(BasePlayer player) { }

	// RVA: 0xAA0C30 Offset: 0xA9F230 VA: 0x180AA0C30
	public bool Menu_Lightmode_Chasing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.Description] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.Icon] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	[BaseEntity.Menu.ShowIf] // RVA: 0xAFE70 Offset: 0xAF270 VA: 0x1800AFE70
	// RVA: 0xAA0CA0 Offset: 0xA9F2A0 VA: 0x180AA0CA0
	public void Menu_Lightmode_Fade(BasePlayer player) { }

	// RVA: 0xAA0C90 Offset: 0xA9F290 VA: 0x180AA0C90
	public bool Menu_Lightmode_Fade_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.Description] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.Icon] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0070 Offset: 0xAF470 VA: 0x1800B0070
	// RVA: 0xAA0D50 Offset: 0xA9F350 VA: 0x180AA0D50
	public void Menu_Lightmode_SlowGlow(BasePlayer player) { }

	// RVA: 0xAA0E00 Offset: 0xA9F400 VA: 0x180AA0E00
	public bool Menu_Lightmode_slowglow_ShowIf(BasePlayer player) { }

	// RVA: 0xAA0950 Offset: 0xA9EF50 VA: 0x180AA0950
	public bool IsStyle(AdvancedChristmasLights.AnimationType testType) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool CanPlayerManipulate(BasePlayer player) { }

	// RVA: 0xAA1C40 Offset: 0xAA0240 VA: 0x180AA1C40
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

