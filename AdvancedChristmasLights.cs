public class AdvancedChristmasLights : IOEntity // TypeDefIndex: 8301
{	private Option __menuOption_Menu_Lightmode_Chasing; // 0x288
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
	[TooltipAttribute] // RVA: 0xACDA0 Offset: 0xAC1A0 VA: 0x1800ACDA0
	public float lengthToPowerRatio; // 0x480
	private bool finalized; // 0x484
	private int lengthUsed; // 0x488
	private int oldAnimationStyle; // 0x48C
	private int oldPointCount; // 0x490

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void ClearPoints() { }

	public void FinishEditing() { }

	public bool IsFinalized() { }

	public void AddPoint(Vector3 newPoint, Vector3 newNormal) { }

	public override int ConsumptionAmount() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void PostNetworkUpdate() { }

	public void UpdateBulbs() { }

	public virtual void SetBulbsOn(bool wantsOn) { }

	public void UpdateCulling() { }

	public void RegenerateLights() { }

	[BaseEntity.Menu] // RVA: 0xACE40 Offset: 0xAC240 VA: 0x1800ACE40
	[BaseEntity.Menu.Description] // RVA: 0xACE40 Offset: 0xAC240 VA: 0x1800ACE40
	[BaseEntity.Menu.Icon] // RVA: 0xACE40 Offset: 0xAC240 VA: 0x1800ACE40
	[BaseEntity.Menu.ShowIf] // RVA: 0xACE40 Offset: 0xAC240 VA: 0x1800ACE40
	public void Menu_Lightmode_SteadyOn(BasePlayer player) { }

	public bool Menu_Lightmode_SteadyOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAD110 Offset: 0xAC510 VA: 0x1800AD110
	[BaseEntity.Menu.Description] // RVA: 0xAD110 Offset: 0xAC510 VA: 0x1800AD110
	[BaseEntity.Menu.Icon] // RVA: 0xAD110 Offset: 0xAC510 VA: 0x1800AD110
	[BaseEntity.Menu.ShowIf] // RVA: 0xAD110 Offset: 0xAC510 VA: 0x1800AD110
	public void Menu_Lightmode_Flashing(BasePlayer player) { }

	public bool Menu_Lightmode_Flashing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	[BaseEntity.Menu.Description] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	[BaseEntity.Menu.Icon] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	[BaseEntity.Menu.ShowIf] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	public void Menu_Lightmode_Chasing(BasePlayer player) { }

	public bool Menu_Lightmode_Chasing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAFF20 Offset: 0xAF320 VA: 0x1800AFF20
	[BaseEntity.Menu.Description] // RVA: 0xAFF20 Offset: 0xAF320 VA: 0x1800AFF20
	[BaseEntity.Menu.Icon] // RVA: 0xAFF20 Offset: 0xAF320 VA: 0x1800AFF20
	[BaseEntity.Menu.ShowIf] // RVA: 0xAFF20 Offset: 0xAF320 VA: 0x1800AFF20
	public void Menu_Lightmode_Fade(BasePlayer player) { }

	public bool Menu_Lightmode_Fade_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB0120 Offset: 0xAF520 VA: 0x1800B0120
	[BaseEntity.Menu.Description] // RVA: 0xB0120 Offset: 0xAF520 VA: 0x1800B0120
	[BaseEntity.Menu.Icon] // RVA: 0xB0120 Offset: 0xAF520 VA: 0x1800B0120
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0120 Offset: 0xAF520 VA: 0x1800B0120
	public void Menu_Lightmode_SlowGlow(BasePlayer player) { }

	public bool Menu_Lightmode_slowglow_ShowIf(BasePlayer player) { }

	public bool IsStyle(AdvancedChristmasLights.AnimationType testType) { }

	public bool CanPlayerManipulate(BasePlayer player) { }

	public void .ctor() { }

}

public struct AdvancedChristmasLights.pointEntry // TypeDefIndex: 8302
{	public Vector3 point; // 0x0
	public Vector3 normal; // 0xC

}

public enum AdvancedChristmasLights.AnimationType // TypeDefIndex: 8303
{	public int value__; // 0x0
	public const AdvancedChristmasLights.AnimationType ON = 1;
	public const AdvancedChristmasLights.AnimationType FLASHING = 2;
	public const AdvancedChristmasLights.AnimationType CHASING = 3;
	public const AdvancedChristmasLights.AnimationType FADE = 4;
	public const AdvancedChristmasLights.AnimationType SLOWGLOW = 6;

}

