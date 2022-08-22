public class BaseFishingRod : HeldEntity // TypeDefIndex: 8513
{	// Fields
	public GameObjectRef FishingBobberRef; // 0x1F8
	public float FishCatchDistance; // 0x200
	public LineRenderer ReelLineRenderer; // 0x208
	public Transform LineRendererWorldStartPos; // 0x210
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
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

	// RVA: 0x7B68D0 Offset: 0x7B4ED0 VA: 0x1807B68D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B8C20 Offset: 0x7B7220 VA: 0x1807B8C20
	public BaseFishingRod.CatchState get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B8CA0 Offset: 0x7B72A0 VA: 0x1807B8CA0
	private void set_CurrentState(BaseFishingRod.CatchState value) { }

	// RVA: 0x7B8C30 Offset: 0x7B7230 VA: 0x1807B8C30
	public static bool get_ShowLureFailError() { }

	// RVA: 0x7B5B70 Offset: 0x7B4170 VA: 0x1807B5B70 Slot: 138
	public override void OnInput() { }

	// RVA: 0x7B57E0 Offset: 0x7B3DE0 VA: 0x1807B57E0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7B8250 Offset: 0x7B6850 VA: 0x1807B8250
	private void UpdateLineRenderer() { }

	// RVA: 0x7B8650 Offset: 0x7B6C50 VA: 0x1807B8650
	private void UpdateSounds(bool onLine, float strainAmount) { }

	// RVA: 0x7B4E30 Offset: 0x7B3430 VA: 0x1807B4E30
	private Vector3 GetCurrentCastArcTarget(BasePlayer ply) { }

	// RVA: 0x7B5340 Offset: 0x7B3940 VA: 0x1807B5340
	private Vector3 GetWorldSpaceLineRendererStartPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	// RVA: 0x7B5050 Offset: 0x7B3650 VA: 0x1807B5050
	private Vector3 GetRodCatchPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	// RVA: 0x7B5680 Offset: 0x7B3C80 VA: 0x1807B5680 Slot: 151
	public override bool HeldEntityBlocksMovement(InputState state) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B3D90 Offset: 0x7B2390 VA: 0x1807B3D90
	private void Client_ReceiveCastPoint(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B3970 Offset: 0x7B1F70 VA: 0x1807B3970
	private void Client_HookedSomething(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B4090 Offset: 0x7B2690 VA: 0x1807B4090
	private void Client_UpdateFishState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B3A10 Offset: 0x7B2010 VA: 0x1807B3A10
	private void Client_OnCaughtFish(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B3EB0 Offset: 0x7B24B0 VA: 0x1807B3EB0
	private void Client_ResetLine(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7B7CE0 Offset: 0x7B62E0 VA: 0x1807B7CE0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x7B7DC0 Offset: 0x7B63C0 VA: 0x1807B7DC0 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x7B5AA0 Offset: 0x7B40A0 VA: 0x1807B5AA0 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x7B7EE0 Offset: 0x7B64E0 VA: 0x1807B7EE0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7B5740 Offset: 0x7B3D40 VA: 0x1807B5740 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7B3960 Offset: 0x7B1F60 VA: 0x1807B3960 Slot: 155
	public override bool BlocksGestures() { }

	// RVA: 0x7B37F0 Offset: 0x7B1DF0 VA: 0x1807B37F0
	private bool AllowPullInDirection(Vector3 worldDirection, Vector3 bobberPosition) { }

	// RVA: 0x7B4100 Offset: 0x7B2700 VA: 0x1807B4100
	private bool EvaluateFishingPosition(ref Vector3 pos, BasePlayer ply, out BaseFishingRod.FailReason reason, out WaterBody waterBody) { }

	// RVA: 0x7B4FD0 Offset: 0x7B35D0 VA: 0x1807B4FD0
	private Item GetCurrentLure() { }

	// RVA: 0x7B5630 Offset: 0x7B3C30 VA: 0x1807B5630
	private bool HasReelInInput(InputState state) { }

	// RVA: 0x7B8B30 Offset: 0x7B7130 VA: 0x1807B8B30
	public void .ctor() { }

	// RVA: 0x7B8A40 Offset: 0x7B7040 VA: 0x1807B8A40
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

