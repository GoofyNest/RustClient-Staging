public class ExcavatorArm : BaseEntity // TypeDefIndex: 8390
{	// Fields
	private Option __menuOption_Menu_TargetHQM; // 0x168
	private Option __menuOption_Menu_TargetMetal; // 0x1C0
	private Option __menuOption_Menu_TargetStone; // 0x218
	private Option __menuOption_Menu_TargetSulfur; // 0x270
	public float yaw1; // 0x2C8
	public float yaw2; // 0x2CC
	public Transform wheel; // 0x2D0
	public float wheelSpeed; // 0x2D8
	public float turnSpeed; // 0x2DC
	public Transform miningOffset; // 0x2E0
	public GameObjectRef bounceEffect; // 0x2E8
	public LightGroupAtTime lights; // 0x2F0
	public Material conveyorMaterial; // 0x2F8
	public float beltSpeedMax; // 0x300
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public List<ExcavatorOutputPile> outputPiles; // 0x308
	public SoundDefinition miningStartButtonSoundDef; // 0x310
	[HeaderAttribute] // RVA: 0xDDB70 Offset: 0xDCF70 VA: 0x1800DDB70
	public ItemAmount[] resourcesToMine; // 0x318
	public float resourceProductionTickRate; // 0x320
	public float timeForFullResources; // 0x324
	private ItemAmount[] pendingResources; // 0x328
	private float wheelRotation; // 0x330
	private float nextBounceTime; // 0x334
	private float currentWheelTurnSpeed; // 0x338
	private float currentBeltSpeed; // 0x33C
	private float currentBeltOffset; // 0x340

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8CC350 Offset: 0x8CA950 VA: 0x1808CC350 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8CDC10 Offset: 0x8CC210 VA: 0x1808CDC10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8CD4C0 Offset: 0x8CBAC0 VA: 0x1808CD4C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool IsPowered() { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430
	public bool IsMining() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x8CD660 Offset: 0x8CBC60 VA: 0x1808CD660 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8CD750 Offset: 0x8CBD50 VA: 0x1808CD750
	public void SetLightStatus(bool wantsOn) { }

	// RVA: 0x8CD790 Offset: 0x8CBD90 VA: 0x1808CD790
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDEF90 Offset: 0xDE390 VA: 0x1800DEF90
	[BaseEntity.Menu.Description] // RVA: 0xDEF90 Offset: 0xDE390 VA: 0x1800DEF90
	[BaseEntity.Menu.Icon] // RVA: 0xDEF90 Offset: 0xDE390 VA: 0x1800DEF90
	[BaseEntity.Menu.ShowIf] // RVA: 0xDEF90 Offset: 0xDE390 VA: 0x1800DEF90
	// RVA: 0x8CCDC0 Offset: 0x8CB3C0 VA: 0x1808CCDC0
	public void Menu_TargetHQM(BasePlayer player) { }

	// RVA: 0x8CCD00 Offset: 0x8CB300 VA: 0x1808CCD00
	public bool Menu_TargetHQM_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF1B0 Offset: 0xDE5B0 VA: 0x1800DF1B0
	[BaseEntity.Menu.Description] // RVA: 0xDF1B0 Offset: 0xDE5B0 VA: 0x1800DF1B0
	[BaseEntity.Menu.Icon] // RVA: 0xDF1B0 Offset: 0xDE5B0 VA: 0x1800DF1B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF1B0 Offset: 0xDE5B0 VA: 0x1800DF1B0
	// RVA: 0x8CD390 Offset: 0x8CB990 VA: 0x1808CD390
	public void Menu_TargetSulfur(BasePlayer player) { }

	// RVA: 0x8CD2D0 Offset: 0x8CB8D0 VA: 0x1808CD2D0
	public bool Menu_TargetSulfur_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF4B0 Offset: 0xDE8B0 VA: 0x1800DF4B0
	[BaseEntity.Menu.Description] // RVA: 0xDF4B0 Offset: 0xDE8B0 VA: 0x1800DF4B0
	[BaseEntity.Menu.Icon] // RVA: 0xDF4B0 Offset: 0xDE8B0 VA: 0x1800DF4B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF4B0 Offset: 0xDE8B0 VA: 0x1800DF4B0
	// RVA: 0x8CD1A0 Offset: 0x8CB7A0 VA: 0x1808CD1A0
	public void Menu_TargetStone(BasePlayer player) { }

	// RVA: 0x8CD0E0 Offset: 0x8CB6E0 VA: 0x1808CD0E0
	public bool Menu_TargetStone_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF6F0 Offset: 0xDEAF0 VA: 0x1800DF6F0
	[BaseEntity.Menu.Description] // RVA: 0xDF6F0 Offset: 0xDEAF0 VA: 0x1800DF6F0
	[BaseEntity.Menu.Icon] // RVA: 0xDF6F0 Offset: 0xDEAF0 VA: 0x1800DF6F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF6F0 Offset: 0xDEAF0 VA: 0x1800DF6F0
	// RVA: 0x8CCFB0 Offset: 0x8CB5B0 VA: 0x1808CCFB0
	public void Menu_TargetMetal(BasePlayer player) { }

	// RVA: 0x8CCEF0 Offset: 0x8CB4F0 VA: 0x1808CCEF0
	public bool Menu_TargetMetal_ShowIf(BasePlayer player) { }

	// RVA: 0x8CD5B0 Offset: 0x8CBBB0 VA: 0x1808CD5B0
	private void PlayMiningStartButtonSound(Vector3 position) { }

	// RVA: 0x8CDB80 Offset: 0x8CC180 VA: 0x1808CDB80
	public void .ctor() { }

}

