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

	// RVA: 0x7EAFB0 Offset: 0x7E95B0 VA: 0x1807EAFB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7ED300 Offset: 0x7EB900 VA: 0x1807ED300
	public BaseFishingRod.CatchState get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7ED380 Offset: 0x7EB980 VA: 0x1807ED380
	private void set_CurrentState(BaseFishingRod.CatchState value) { }

	// RVA: 0x7ED310 Offset: 0x7EB910 VA: 0x1807ED310
	public static bool get_ShowLureFailError() { }

	// RVA: 0x7EA250 Offset: 0x7E8850 VA: 0x1807EA250 Slot: 138
	public override void OnInput() { }

	// RVA: 0x7E9EC0 Offset: 0x7E84C0 VA: 0x1807E9EC0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7EC930 Offset: 0x7EAF30 VA: 0x1807EC930
	private void UpdateLineRenderer() { }

	// RVA: 0x7ECD30 Offset: 0x7EB330 VA: 0x1807ECD30
	private void UpdateSounds(bool onLine, float strainAmount) { }

	// RVA: 0x7E9510 Offset: 0x7E7B10 VA: 0x1807E9510
	private Vector3 GetCurrentCastArcTarget(BasePlayer ply) { }

	// RVA: 0x7E9A20 Offset: 0x7E8020 VA: 0x1807E9A20
	private Vector3 GetWorldSpaceLineRendererStartPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	// RVA: 0x7E9730 Offset: 0x7E7D30 VA: 0x1807E9730
	private Vector3 GetRodCatchPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	// RVA: 0x7E9D60 Offset: 0x7E8360 VA: 0x1807E9D60 Slot: 151
	public override bool HeldEntityBlocksMovement(InputState state) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E8470 Offset: 0x7E6A70 VA: 0x1807E8470
	private void Client_ReceiveCastPoint(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E8050 Offset: 0x7E6650 VA: 0x1807E8050
	private void Client_HookedSomething(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E8770 Offset: 0x7E6D70 VA: 0x1807E8770
	private void Client_UpdateFishState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E80F0 Offset: 0x7E66F0 VA: 0x1807E80F0
	private void Client_OnCaughtFish(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E8590 Offset: 0x7E6B90 VA: 0x1807E8590
	private void Client_ResetLine(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7EC3C0 Offset: 0x7EA9C0 VA: 0x1807EC3C0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x7EC4A0 Offset: 0x7EAAA0 VA: 0x1807EC4A0 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x7EA180 Offset: 0x7E8780 VA: 0x1807EA180 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x7EC5C0 Offset: 0x7EABC0 VA: 0x1807EC5C0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7E9E20 Offset: 0x7E8420 VA: 0x1807E9E20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7E8040 Offset: 0x7E6640 VA: 0x1807E8040 Slot: 155
	public override bool BlocksGestures() { }

	// RVA: 0x7E7ED0 Offset: 0x7E64D0 VA: 0x1807E7ED0
	private bool AllowPullInDirection(Vector3 worldDirection, Vector3 bobberPosition) { }

	// RVA: 0x7E87E0 Offset: 0x7E6DE0 VA: 0x1807E87E0
	private bool EvaluateFishingPosition(ref Vector3 pos, BasePlayer ply, out BaseFishingRod.FailReason reason, out WaterBody waterBody) { }

	// RVA: 0x7E96B0 Offset: 0x7E7CB0 VA: 0x1807E96B0
	private Item GetCurrentLure() { }

	// RVA: 0x7E9D10 Offset: 0x7E8310 VA: 0x1807E9D10
	private bool HasReelInInput(InputState state) { }

	// RVA: 0x7ED210 Offset: 0x7EB810 VA: 0x1807ED210
	public void .ctor() { }

	// RVA: 0x7ED120 Offset: 0x7EB720 VA: 0x1807ED120
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

