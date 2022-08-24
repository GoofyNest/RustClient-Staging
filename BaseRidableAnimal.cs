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
	[HeaderAttribute] // RVA: 0xC39E0 Offset: 0xC2DE0 VA: 0x1800C39E0
	public ItemDefinition purchaseToken; // 0x638
	public GameObjectRef eatEffect; // 0x640
	public GameObjectRef CorpsePrefab; // 0x648
	[HeaderAttribute] // RVA: 0xC3B00 Offset: 0xC2F00 VA: 0x1800C3B00
	public Transform animalFront; // 0x650
	public float obstacleDetectionRadius; // 0x658
	public float maxWaterDepth; // 0x65C
	public float roadSpeedBonus; // 0x660
	public float maxWallClimbSlope; // 0x664
	public float maxStepHeight; // 0x668
	public float maxStepDownHeight; // 0x66C
	[HeaderAttribute] // RVA: 0xC3BA0 Offset: 0xC2FA0 VA: 0x1800C3BA0
	public BaseRidableAnimal.RunState currentRunState; // 0x670
	public float walkSpeed; // 0x674
	public float trotSpeed; // 0x678
	public float runSpeed; // 0x67C
	public float turnSpeed; // 0x680
	public float maxSpeed; // 0x684
	public Transform[] groundSampleOffsets; // 0x688
	[HeaderAttribute] // RVA: 0xC4FE0 Offset: 0xC43E0 VA: 0x1800C4FE0
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
	[ServerVar] // RVA: 0xC50A0 Offset: 0xC44A0 VA: 0x1800C50A0
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

	[BaseEntity.Menu] // RVA: 0xC51A0 Offset: 0xC45A0 VA: 0x1800C51A0
	[BaseEntity.Menu.Description] // RVA: 0xC51A0 Offset: 0xC45A0 VA: 0x1800C51A0
	[BaseEntity.Menu.Icon] // RVA: 0xC51A0 Offset: 0xC45A0 VA: 0x1800C51A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC51A0 Offset: 0xC45A0 VA: 0x1800C51A0
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

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void Stand(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void Eat(BaseEntity.RPCMessage msg) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC55D0 Offset: 0xC49D0 VA: 0x1800C55D0
	[BaseEntity.Menu.Description] // RVA: 0xC55D0 Offset: 0xC49D0 VA: 0x1800C55D0
	[BaseEntity.Menu.Icon] // RVA: 0xC55D0 Offset: 0xC49D0 VA: 0x1800C55D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC55D0 Offset: 0xC49D0 VA: 0x1800C55D0
	public void Menu_TooHeavy(BasePlayer player) { }

	public bool Menu_TooHeavy_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC58D0 Offset: 0xC4CD0 VA: 0x1800C58D0
	[BaseEntity.Menu.Description] // RVA: 0xC58D0 Offset: 0xC4CD0 VA: 0x1800C58D0
	[BaseEntity.Menu.Icon] // RVA: 0xC58D0 Offset: 0xC4CD0 VA: 0x1800C58D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC58D0 Offset: 0xC4CD0 VA: 0x1800C58D0
	public void Menu_Ride(BasePlayer player) { }

	public bool Menu_Ride_ShowIf(BasePlayer player) { }

	private bool CanPlayerSeeSaddlePoint(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5BB0 Offset: 0xC4FB0 VA: 0x1800C5BB0
	[BaseEntity.Menu.Description] // RVA: 0xC5BB0 Offset: 0xC4FB0 VA: 0x1800C5BB0
	[BaseEntity.Menu.Icon] // RVA: 0xC5BB0 Offset: 0xC4FB0 VA: 0x1800C5BB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5BB0 Offset: 0xC4FB0 VA: 0x1800C5BB0
	public void Menu_Lead(BasePlayer player) { }

	public bool Menu_Lead_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5E20 Offset: 0xC5220 VA: 0x1800C5E20
	[BaseEntity.Menu.Description] // RVA: 0xC5E20 Offset: 0xC5220 VA: 0x1800C5E20
	[BaseEntity.Menu.Icon] // RVA: 0xC5E20 Offset: 0xC5220 VA: 0x1800C5E20
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5E20 Offset: 0xC5220 VA: 0x1800C5E20
	public void Menu_StopLead(BasePlayer player) { }

	public bool Menu_StopLead_ShowIf(BasePlayer player) { }

	public virtual bool RideMenuVisible() { }

	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC60D0 Offset: 0xC54D0 VA: 0x1800C60D0
	[BaseEntity.Menu.Description] // RVA: 0xC60D0 Offset: 0xC54D0 VA: 0x1800C60D0
	[BaseEntity.Menu.Icon] // RVA: 0xC60D0 Offset: 0xC54D0 VA: 0x1800C60D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC60D0 Offset: 0xC54D0 VA: 0x1800C60D0
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

