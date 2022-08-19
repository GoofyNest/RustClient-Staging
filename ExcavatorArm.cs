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
	[HeaderAttribute] // RVA: 0xDDB10 Offset: 0xDCF10 VA: 0x1800DDB10
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

	// RVA: 0x8CC240 Offset: 0x8CA840 VA: 0x1808CC240 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8CDB00 Offset: 0x8CC100 VA: 0x1808CDB00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8CD3B0 Offset: 0x8CB9B0 VA: 0x1808CD3B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool IsPowered() { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430
	public bool IsMining() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x8CD550 Offset: 0x8CBB50 VA: 0x1808CD550 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8CD640 Offset: 0x8CBC40 VA: 0x1808CD640
	public void SetLightStatus(bool wantsOn) { }

	// RVA: 0x8CD680 Offset: 0x8CBC80 VA: 0x1808CD680
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDEF30 Offset: 0xDE330 VA: 0x1800DEF30
	[BaseEntity.Menu.Description] // RVA: 0xDEF30 Offset: 0xDE330 VA: 0x1800DEF30
	[BaseEntity.Menu.Icon] // RVA: 0xDEF30 Offset: 0xDE330 VA: 0x1800DEF30
	[BaseEntity.Menu.ShowIf] // RVA: 0xDEF30 Offset: 0xDE330 VA: 0x1800DEF30
	// RVA: 0x8CCCB0 Offset: 0x8CB2B0 VA: 0x1808CCCB0
	public void Menu_TargetHQM(BasePlayer player) { }

	// RVA: 0x8CCBF0 Offset: 0x8CB1F0 VA: 0x1808CCBF0
	public bool Menu_TargetHQM_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF140 Offset: 0xDE540 VA: 0x1800DF140
	[BaseEntity.Menu.Description] // RVA: 0xDF140 Offset: 0xDE540 VA: 0x1800DF140
	[BaseEntity.Menu.Icon] // RVA: 0xDF140 Offset: 0xDE540 VA: 0x1800DF140
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF140 Offset: 0xDE540 VA: 0x1800DF140
	// RVA: 0x8CD280 Offset: 0x8CB880 VA: 0x1808CD280
	public void Menu_TargetSulfur(BasePlayer player) { }

	// RVA: 0x8CD1C0 Offset: 0x8CB7C0 VA: 0x1808CD1C0
	public bool Menu_TargetSulfur_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF440 Offset: 0xDE840 VA: 0x1800DF440
	[BaseEntity.Menu.Description] // RVA: 0xDF440 Offset: 0xDE840 VA: 0x1800DF440
	[BaseEntity.Menu.Icon] // RVA: 0xDF440 Offset: 0xDE840 VA: 0x1800DF440
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF440 Offset: 0xDE840 VA: 0x1800DF440
	// RVA: 0x8CD090 Offset: 0x8CB690 VA: 0x1808CD090
	public void Menu_TargetStone(BasePlayer player) { }

	// RVA: 0x8CCFD0 Offset: 0x8CB5D0 VA: 0x1808CCFD0
	public bool Menu_TargetStone_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF670 Offset: 0xDEA70 VA: 0x1800DF670
	[BaseEntity.Menu.Description] // RVA: 0xDF670 Offset: 0xDEA70 VA: 0x1800DF670
	[BaseEntity.Menu.Icon] // RVA: 0xDF670 Offset: 0xDEA70 VA: 0x1800DF670
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF670 Offset: 0xDEA70 VA: 0x1800DF670
	// RVA: 0x8CCEA0 Offset: 0x8CB4A0 VA: 0x1808CCEA0
	public void Menu_TargetMetal(BasePlayer player) { }

	// RVA: 0x8CCDE0 Offset: 0x8CB3E0 VA: 0x1808CCDE0
	public bool Menu_TargetMetal_ShowIf(BasePlayer player) { }

	// RVA: 0x8CD4A0 Offset: 0x8CBAA0 VA: 0x1808CD4A0
	private void PlayMiningStartButtonSound(Vector3 position) { }

	// RVA: 0x8CDA70 Offset: 0x8CC070 VA: 0x1808CDA70
	public void .ctor() { }

}

