public class BaseRidableAnimal : BaseVehicle // TypeDefIndex: 8347
{	// Fields
	private Option __menuOption_Menu_Claim; // 0x3B8
	private Option __menuOption_Menu_Lead; // 0x410
	private Option __menuOption_Menu_Open; // 0x468
	private Option __menuOption_Menu_Ride; // 0x4C0
	private Option __menuOption_Menu_StopLead; // 0x518
	private Option __menuOption_Menu_TooHeavy; // 0x570
	public ItemDefinition onlyAllowedItem; // 0x5C8
	public ItemContainer.ContentsType allowedContents; // 0x5D0
	public int maxStackSize; // 0x5D4
	public int numSlots; // 0x5D8
	public string lootPanelName; // 0x5E0
	public bool needsBuildingPrivilegeToUse; // 0x5E8
	public bool isLootable; // 0x5E9
	protected ItemContainer inventory; // 0x5F0
	public const BaseEntity.Flags Flag_ForSale = 256;
	private Vector3 lastMoveDirection; // 0x5F8
	public GameObjectRef saddlePrefab; // 0x608
	public EntityRef saddleRef; // 0x610
	public Transform movementLOSOrigin; // 0x620
	public SoundPlayer sprintSounds; // 0x628
	public SoundPlayer largeWhinny; // 0x630
	public const BaseEntity.Flags Flag_Lead = 32768;
	public const BaseEntity.Flags Flag_HasRider = 2;
	[HeaderAttribute] // RVA: 0xC38B0 Offset: 0xC2CB0 VA: 0x1800C38B0
	public ItemDefinition purchaseToken; // 0x638
	public GameObjectRef eatEffect; // 0x640
	public GameObjectRef CorpsePrefab; // 0x648
	[HeaderAttribute] // RVA: 0xC39D0 Offset: 0xC2DD0 VA: 0x1800C39D0
	public Transform animalFront; // 0x650
	public float obstacleDetectionRadius; // 0x658
	public float maxWaterDepth; // 0x65C
	public float roadSpeedBonus; // 0x660
	public float maxWallClimbSlope; // 0x664
	public float maxStepHeight; // 0x668
	public float maxStepDownHeight; // 0x66C
	[HeaderAttribute] // RVA: 0xC3AD0 Offset: 0xC2ED0 VA: 0x1800C3AD0
	public BaseRidableAnimal.RunState currentRunState; // 0x670
	public float walkSpeed; // 0x674
	public float trotSpeed; // 0x678
	public float runSpeed; // 0x67C
	public float turnSpeed; // 0x680
	public float maxSpeed; // 0x684
	public Transform[] groundSampleOffsets; // 0x688
	[HeaderAttribute] // RVA: 0xC4F10 Offset: 0xC4310 VA: 0x1800C4F10
	public float staminaSeconds; // 0x690
	public float currentMaxStaminaSeconds; // 0x694
	public float maxStaminaSeconds; // 0x698
	public float staminaCoreLossRatio; // 0x69C
	public float staminaCoreSpeedBonus; // 0x6A0
	public float staminaReplenishRatioMoving; // 0x6A4
	public float staminaReplenishRatioStanding; // 0x6A8
	public float calorieToStaminaRatio; // 0x6AC
	public float hydrationToStaminaRatio; // 0x6B0
	public float maxStaminaCoreFromWater; // 0x6B4
	public bool debugMovement; // 0x6B8
	private const float normalOffsetDist = 0,15;
	private Vector3[] normalOffsets; // 0x6C0
	[ServerVar] // RVA: 0xC5000 Offset: 0xC4400 VA: 0x1800C5000
	public static float decayminutes; // 0x0
	public float currentSpeed; // 0x6C8
	public float desiredRotation; // 0x6CC
	public float animalPitchClamp; // 0x6D0
	public float animalRollClamp; // 0x6D4
	private float lastBreathingRate; // 0x6D8
	private float nextTokenCheckTime; // 0x6DC
	private bool lastTokenCheckResult; // 0x6E0

	// Properties
	public override bool HasMenuOptions { get; }
	public override bool IsNpc { get; }

	// Methods

	// RVA: 0x928790 Offset: 0x926D90 VA: 0x180928790 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x92AF40 Offset: 0x929540 VA: 0x18092AF40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x929DD0 Offset: 0x9283D0 VA: 0x180929DD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool IsForSale() { }

	// RVA: 0x9282C0 Offset: 0x9268C0 VA: 0x1809282C0 Slot: 194
	public virtual bool CanOpenStorage(BasePlayer player) { }

	// RVA: 0x929660 Offset: 0x927C60 VA: 0x180929660
	public void LoadContainer(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.Description] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.Icon] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	// RVA: 0x929B90 Offset: 0x928190 VA: 0x180929B90
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x929A70 Offset: 0x928070 VA: 0x180929A70
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x92A830 Offset: 0x928E30 VA: 0x18092A830 Slot: 195
	public virtual bool ShouldShowLootMenus() { }

	// RVA: 0x928750 Offset: 0x926D50 VA: 0x180928750
	public float GetBreathingDelay() { }

	// RVA: 0x8CE710 Offset: 0x8CCD10 VA: 0x1808CE710
	public bool IsLeading() { }

	// RVA: 0x92A980 Offset: 0x928F80 VA: 0x18092A980
	public static float UnitsToKPH(float unitsPerSecond) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x929750 Offset: 0x927D50 VA: 0x180929750 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x92A9A0 Offset: 0x928FA0 VA: 0x18092A9A0
	public void UpdateBreathingRate() { }

	// RVA: 0x92A650 Offset: 0x928C50 VA: 0x18092A650 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x92A8C0 Offset: 0x928EC0 VA: 0x18092A8C0
	public void SprintSoundPlay() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92A8F0 Offset: 0x928EF0 VA: 0x18092A8F0
	public void Stand(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9286D0 Offset: 0x926CD0 VA: 0x1809286D0
	public void Eat(BaseEntity.RPCMessage msg) { }

	// RVA: 0x928590 Offset: 0x926B90 VA: 0x180928590 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.Description] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.Icon] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_TooHeavy(BasePlayer player) { }

	// RVA: 0x929630 Offset: 0x927C30 VA: 0x180929630
	public bool Menu_TooHeavy_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.Description] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.Icon] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	// RVA: 0x929CA0 Offset: 0x9282A0 VA: 0x180929CA0
	public void Menu_Ride(BasePlayer player) { }

	// RVA: 0x929BD0 Offset: 0x9281D0 VA: 0x180929BD0
	public bool Menu_Ride_ShowIf(BasePlayer player) { }

	// RVA: 0x928320 Offset: 0x926920 VA: 0x180928320
	private bool CanPlayerSeeSaddlePoint(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.Description] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.Icon] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	// RVA: 0x929A20 Offset: 0x928020 VA: 0x180929A20
	public void Menu_Lead(BasePlayer player) { }

	// RVA: 0x929980 Offset: 0x927F80 VA: 0x180929980
	public bool Menu_Lead_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.Description] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.Icon] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	// RVA: 0x929D80 Offset: 0x928380 VA: 0x180929D80
	public void Menu_StopLead(BasePlayer player) { }

	// RVA: 0x929CE0 Offset: 0x9282E0 VA: 0x180929CE0
	public bool Menu_StopLead_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 196
	public virtual bool RideMenuVisible() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.Description] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.Icon] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	// RVA: 0x929940 Offset: 0x927F40 VA: 0x180929940
	public void Menu_Claim(BasePlayer player) { }

	// RVA: 0x929860 Offset: 0x927E60 VA: 0x180929860
	public bool Menu_Claim_ShowIf(BasePlayer player) { }

	// RVA: 0x92A610 Offset: 0x928C10 VA: 0x18092A610
	public bool PlayerHasToken(BasePlayer player) { }

	// RVA: 0x9295C0 Offset: 0x927BC0 VA: 0x1809295C0
	public Item GetPurchaseToken(BasePlayer player) { }

	// RVA: 0x929620 Offset: 0x927C20 VA: 0x180929620 Slot: 197
	public virtual float GetWalkSpeed() { }

	// RVA: 0x929610 Offset: 0x927C10 VA: 0x180929610 Slot: 198
	public virtual float GetTrotSpeed() { }

	// RVA: 0x929600 Offset: 0x927C00 VA: 0x180929600 Slot: 199
	public virtual float GetRunSpeed() { }

	// RVA: 0x929630 Offset: 0x927C30 VA: 0x180929630
	public bool IsPlayerTooHeavy(BasePlayer player) { }

	// RVA: 0x92AB50 Offset: 0x929150 VA: 0x18092AB50
	public void .ctor() { }

	// RVA: 0x92AB10 Offset: 0x929110 VA: 0x18092AB10
	private static void .cctor() { }

}

public enum BaseRidableAnimal.RunState // TypeDefIndex: 8348
{	// Fields
	public int value__; // 0x0
	public const BaseRidableAnimal.RunState stopped = 1;
	public const BaseRidableAnimal.RunState walk = 2;
	public const BaseRidableAnimal.RunState run = 3;
	public const BaseRidableAnimal.RunState sprint = 4;
	public const BaseRidableAnimal.RunState LAST = 5;

}

