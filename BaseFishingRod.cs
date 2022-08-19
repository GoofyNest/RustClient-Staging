public class BaseFishingRod : HeldEntity // TypeDefIndex: 8513
{	// Fields
	public GameObjectRef FishingBobberRef; // 0x1F8
	public float FishCatchDistance; // 0x200
	public LineRenderer ReelLineRenderer; // 0x208
	public Transform LineRendererWorldStartPos; // 0x210
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BaseFishingRod.CatchState <CurrentState>k__BackingField; // 0x218
	private BaseFishingRod.FishState currentFishState; // 0x21C
	private EntityRef<FishingBobber> currentBobber; // 0x220
	public float ConditionLossOnSuccess; // 0x230
	public float ConditionLossOnFail; // 0x234
	public float GlobalStrainSpeedMultiplier; // 0x238
	public float MaxCastDistance; // 0x23C
	public const BaseEntity.Flags Straining = 128;
	public ItemModFishable ForceFish; // 0x240
	public static BaseEntity.Flags PullingLeftFlag; // 0x0
	public static BaseEntity.Flags PullingRightFlag; // 0x4
	public static BaseEntity.Flags ReelingInFlag; // 0x8
	public GameObjectRef BobberPreview; // 0x248
	public SoundDefinition onLineSoundDef; // 0x250
	public SoundDefinition strainSoundDef; // 0x258
	public AnimationCurve strainGainCurve; // 0x260
	public SoundDefinition tensionBreakSoundDef; // 0x268
	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	public static bool ShowUI; // 0xC
	private Vector3[] lineRendererPositionsArray; // 0x270
	private Vector3[] lineRendererResultArray; // 0x278
	private float[] lineRendererSlack; // 0x280
	private float clientStrainAmountNormalised; // 0x288
	private TimeUntil canCancel; // 0x28C
	private FishingRodViewmodel rodViewModel; // 0x290
	private BobberPreview spawnedPreview; // 0x298
	private static int FailedCatch_Param; // 0x10
	private static int CaughtFish_Param; // 0x14
	private static int ReelingIn_Param; // 0x18
	private static int IsFishing_Param; // 0x1C
	private bool aimAnimationReady; // 0x2A0
	private static TimeSince lastLureFail; // 0x20
	public static TimeSince lastLineReset; // 0x24
	public static BaseFishingRod.FailReason lastFailReason; // 0x28
	private Sound onLineSound; // 0x2A8
	private Sound strainSound; // 0x2B0
	private SoundModulation.Modulator strainGainMod; // 0x2B8
	private TimeUntil consumingBackMovement; // 0x2C0
	private TimeSince reelInAnimTimer; // 0x2C4

	// Properties
	public BaseFishingRod.CatchState CurrentState { get; set; }
	public static bool ShowLureFailError { get; }

	// Methods

	// RVA: 0x7EAEA0 Offset: 0x7E94A0 VA: 0x1807EAEA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7ED1F0 Offset: 0x7EB7F0 VA: 0x1807ED1F0
	public BaseFishingRod.CatchState get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7ED270 Offset: 0x7EB870 VA: 0x1807ED270
	private void set_CurrentState(BaseFishingRod.CatchState value) { }

	// RVA: 0x7ED200 Offset: 0x7EB800 VA: 0x1807ED200
	public static bool get_ShowLureFailError() { }

	// RVA: 0x7EA140 Offset: 0x7E8740 VA: 0x1807EA140 Slot: 138
	public override void OnInput() { }

	// RVA: 0x7E9DB0 Offset: 0x7E83B0 VA: 0x1807E9DB0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7EC820 Offset: 0x7EAE20 VA: 0x1807EC820
	private void UpdateLineRenderer() { }

	// RVA: 0x7ECC20 Offset: 0x7EB220 VA: 0x1807ECC20
	private void UpdateSounds(bool onLine, float strainAmount) { }

	// RVA: 0x7E9400 Offset: 0x7E7A00 VA: 0x1807E9400
	private Vector3 GetCurrentCastArcTarget(BasePlayer ply) { }

	// RVA: 0x7E9910 Offset: 0x7E7F10 VA: 0x1807E9910
	private Vector3 GetWorldSpaceLineRendererStartPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	// RVA: 0x7E9620 Offset: 0x7E7C20 VA: 0x1807E9620
	private Vector3 GetRodCatchPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	// RVA: 0x7E9C50 Offset: 0x7E8250 VA: 0x1807E9C50 Slot: 151
	public override bool HeldEntityBlocksMovement(InputState state) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E8360 Offset: 0x7E6960 VA: 0x1807E8360
	private void Client_ReceiveCastPoint(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E7F40 Offset: 0x7E6540 VA: 0x1807E7F40
	private void Client_HookedSomething(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E8660 Offset: 0x7E6C60 VA: 0x1807E8660
	private void Client_UpdateFishState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E7FE0 Offset: 0x7E65E0 VA: 0x1807E7FE0
	private void Client_OnCaughtFish(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E8480 Offset: 0x7E6A80 VA: 0x1807E8480
	private void Client_ResetLine(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7EC2B0 Offset: 0x7EA8B0 VA: 0x1807EC2B0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x7EC390 Offset: 0x7EA990 VA: 0x1807EC390 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x7EA070 Offset: 0x7E8670 VA: 0x1807EA070 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x7EC4B0 Offset: 0x7EAAB0 VA: 0x1807EC4B0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7E9D10 Offset: 0x7E8310 VA: 0x1807E9D10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7E7F30 Offset: 0x7E6530 VA: 0x1807E7F30 Slot: 155
	public override bool BlocksGestures() { }

	// RVA: 0x7E7DC0 Offset: 0x7E63C0 VA: 0x1807E7DC0
	private bool AllowPullInDirection(Vector3 worldDirection, Vector3 bobberPosition) { }

	// RVA: 0x7E86D0 Offset: 0x7E6CD0 VA: 0x1807E86D0
	private bool EvaluateFishingPosition(ref Vector3 pos, BasePlayer ply, out BaseFishingRod.FailReason reason, out WaterBody waterBody) { }

	// RVA: 0x7E95A0 Offset: 0x7E7BA0 VA: 0x1807E95A0
	private Item GetCurrentLure() { }

	// RVA: 0x7E9C00 Offset: 0x7E8200 VA: 0x1807E9C00
	private bool HasReelInInput(InputState state) { }

	// RVA: 0x7ED100 Offset: 0x7EB700 VA: 0x1807ED100
	public void .ctor() { }

	// RVA: 0x7ED010 Offset: 0x7EB610 VA: 0x1807ED010
	private static void .cctor() { }

}

public enum BaseFishingRod.CatchState // TypeDefIndex: 8514
{	// Fields
	public int value__; // 0x0
	public const BaseFishingRod.CatchState None = 0;
	public const BaseFishingRod.CatchState Aiming = 1;
	public const BaseFishingRod.CatchState Waiting = 2;
	public const BaseFishingRod.CatchState Catching = 3;
	public const BaseFishingRod.CatchState Caught = 4;

}

public enum BaseFishingRod.FishState // TypeDefIndex: 8515
{	// Fields
	public int value__; // 0x0
	public const BaseFishingRod.FishState PullingLeft = 1;
	public const BaseFishingRod.FishState PullingRight = 2;
	public const BaseFishingRod.FishState PullingBack = 4;

}

public enum BaseFishingRod.FailReason // TypeDefIndex: 8516
{	// Fields
	public int value__; // 0x0
	public const BaseFishingRod.FailReason UserRequested = 0;
	public const BaseFishingRod.FailReason BadAngle = 1;
	public const BaseFishingRod.FailReason TensionBreak = 2;
	public const BaseFishingRod.FailReason Unequipped = 3;
	public const BaseFishingRod.FailReason TimeOut = 4;
	public const BaseFishingRod.FailReason Success = 5;
	public const BaseFishingRod.FailReason NoWaterFound = 6;
	public const BaseFishingRod.FailReason Obstructed = 7;
	public const BaseFishingRod.FailReason NoLure = 8;
	public const BaseFishingRod.FailReason TooShallow = 9;
	public const BaseFishingRod.FailReason TooClose = 10;
	public const BaseFishingRod.FailReason TooFarAway = 11;
	public const BaseFishingRod.FailReason PlayerMoved = 12;

}

