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

	// RVA: 0x928CA0 Offset: 0x9272A0 VA: 0x180928CA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x92B450 Offset: 0x929A50 VA: 0x18092B450 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x92A2E0 Offset: 0x9288E0 VA: 0x18092A2E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x579950 Offset: 0x577F50 VA: 0x180579950
	public bool IsForSale() { }

	// RVA: 0x9287D0 Offset: 0x926DD0 VA: 0x1809287D0 Slot: 194
	public virtual bool CanOpenStorage(BasePlayer player) { }

	// RVA: 0x929B70 Offset: 0x928170 VA: 0x180929B70
	public void LoadContainer(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.Description] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.Icon] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	// RVA: 0x92A0A0 Offset: 0x9286A0 VA: 0x18092A0A0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x929F80 Offset: 0x928580 VA: 0x180929F80
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x92AD40 Offset: 0x929340 VA: 0x18092AD40 Slot: 195
	public virtual bool ShouldShowLootMenus() { }

	// RVA: 0x928C60 Offset: 0x927260 VA: 0x180928C60
	public float GetBreathingDelay() { }

	// RVA: 0x8CEC20 Offset: 0x8CD220 VA: 0x1808CEC20
	public bool IsLeading() { }

	// RVA: 0x92AE90 Offset: 0x929490 VA: 0x18092AE90
	public static float UnitsToKPH(float unitsPerSecond) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x929C60 Offset: 0x928260 VA: 0x180929C60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x92AEB0 Offset: 0x9294B0 VA: 0x18092AEB0
	public void UpdateBreathingRate() { }

	// RVA: 0x92AB60 Offset: 0x929160 VA: 0x18092AB60 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x92ADD0 Offset: 0x9293D0 VA: 0x18092ADD0
	public void SprintSoundPlay() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92AE00 Offset: 0x929400 VA: 0x18092AE00
	public void Stand(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x928BE0 Offset: 0x9271E0 VA: 0x180928BE0
	public void Eat(BaseEntity.RPCMessage msg) { }

	// RVA: 0x928AA0 Offset: 0x9270A0 VA: 0x180928AA0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.Description] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.Icon] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_TooHeavy(BasePlayer player) { }

	// RVA: 0x929B40 Offset: 0x928140 VA: 0x180929B40
	public bool Menu_TooHeavy_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.Description] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.Icon] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	// RVA: 0x92A1B0 Offset: 0x9287B0 VA: 0x18092A1B0
	public void Menu_Ride(BasePlayer player) { }

	// RVA: 0x92A0E0 Offset: 0x9286E0 VA: 0x18092A0E0
	public bool Menu_Ride_ShowIf(BasePlayer player) { }

	// RVA: 0x928830 Offset: 0x926E30 VA: 0x180928830
	private bool CanPlayerSeeSaddlePoint(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.Description] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.Icon] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	// RVA: 0x929F30 Offset: 0x928530 VA: 0x180929F30
	public void Menu_Lead(BasePlayer player) { }

	// RVA: 0x929E90 Offset: 0x928490 VA: 0x180929E90
	public bool Menu_Lead_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.Description] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.Icon] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	// RVA: 0x92A290 Offset: 0x928890 VA: 0x18092A290
	public void Menu_StopLead(BasePlayer player) { }

	// RVA: 0x92A1F0 Offset: 0x9287F0 VA: 0x18092A1F0
	public bool Menu_StopLead_ShowIf(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 196
	public virtual bool RideMenuVisible() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.Description] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.Icon] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	// RVA: 0x929E50 Offset: 0x928450 VA: 0x180929E50
	public void Menu_Claim(BasePlayer player) { }

	// RVA: 0x929D70 Offset: 0x928370 VA: 0x180929D70
	public bool Menu_Claim_ShowIf(BasePlayer player) { }

	// RVA: 0x92AB20 Offset: 0x929120 VA: 0x18092AB20
	public bool PlayerHasToken(BasePlayer player) { }

	// RVA: 0x929AD0 Offset: 0x9280D0 VA: 0x180929AD0
	public Item GetPurchaseToken(BasePlayer player) { }

	// RVA: 0x929B30 Offset: 0x928130 VA: 0x180929B30 Slot: 197
	public virtual float GetWalkSpeed() { }

	// RVA: 0x929B20 Offset: 0x928120 VA: 0x180929B20 Slot: 198
	public virtual float GetTrotSpeed() { }

	// RVA: 0x929B10 Offset: 0x928110 VA: 0x180929B10 Slot: 199
	public virtual float GetRunSpeed() { }

	// RVA: 0x929B40 Offset: 0x928140 VA: 0x180929B40
	public bool IsPlayerTooHeavy(BasePlayer player) { }

	// RVA: 0x92B060 Offset: 0x929660 VA: 0x18092B060
	public void .ctor() { }

	// RVA: 0x92B020 Offset: 0x929620 VA: 0x18092B020
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

