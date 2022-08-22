public class BaseRidableAnimal : BaseVehicle // TypeDefIndex: 8347
{	private Option __menuOption_Menu_Claim; // 0x3B8
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

	public override bool HasMenuOptions { get; }
	public override bool IsNpc { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsForSale() { }

	public virtual bool CanOpenStorage(BasePlayer player) { }

	public void LoadContainer(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.Description] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.Icon] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5070 Offset: 0xC4470 VA: 0x1800C5070
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public virtual bool ShouldShowLootMenus() { }

	public float GetBreathingDelay() { }

	public bool IsLeading() { }

	public static float UnitsToKPH(float unitsPerSecond) { }

	public override bool get_IsNpc() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void UpdateBreathingRate() { }

	public override void PostNetworkUpdate() { }

	public void SprintSoundPlay() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void Stand(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void Eat(BaseEntity.RPCMessage msg) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.Description] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.Icon] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC54E0 Offset: 0xC48E0 VA: 0x1800C54E0
	public void Menu_TooHeavy(BasePlayer player) { }

	public bool Menu_TooHeavy_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.Description] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.Icon] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5790 Offset: 0xC4B90 VA: 0x1800C5790
	public void Menu_Ride(BasePlayer player) { }

	public bool Menu_Ride_ShowIf(BasePlayer player) { }

	private bool CanPlayerSeeSaddlePoint(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.Description] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.Icon] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5A70 Offset: 0xC4E70 VA: 0x1800C5A70
	public void Menu_Lead(BasePlayer player) { }

	public bool Menu_Lead_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.Description] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.Icon] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	public void Menu_StopLead(BasePlayer player) { }

	public bool Menu_StopLead_ShowIf(BasePlayer player) { }

	public virtual bool RideMenuVisible() { }

	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.Description] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.Icon] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5F60 Offset: 0xC5360 VA: 0x1800C5F60
	public void Menu_Claim(BasePlayer player) { }

	public bool Menu_Claim_ShowIf(BasePlayer player) { }

	public bool PlayerHasToken(BasePlayer player) { }

	public Item GetPurchaseToken(BasePlayer player) { }

	public virtual float GetWalkSpeed() { }

	public virtual float GetTrotSpeed() { }

	public virtual float GetRunSpeed() { }

	public bool IsPlayerTooHeavy(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum BaseRidableAnimal.RunState // TypeDefIndex: 8348
{	public int value__; // 0x0
	public const BaseRidableAnimal.RunState stopped = 1;
	public const BaseRidableAnimal.RunState walk = 2;
	public const BaseRidableAnimal.RunState run = 3;
	public const BaseRidableAnimal.RunState sprint = 4;
	public const BaseRidableAnimal.RunState LAST = 5;

}

