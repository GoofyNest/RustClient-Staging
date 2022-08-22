public class Kayak : BaseBoat, IPoolVehicle // TypeDefIndex: 8593
{	// Fields
	public ItemDefinition OarItem; // 0x438
	public float maxPaddleFrequency; // 0x440
	public float forwardPaddleForce; // 0x444
	public float multiDriverPaddleForceMultiplier; // 0x448
	public float rotatePaddleForce; // 0x44C
	public GameObjectRef forwardSplashEffect; // 0x450
	public GameObjectRef backSplashEffect; // 0x458
	public ParticleSystem moveSplashEffect; // 0x460
	public float animationLerpSpeed; // 0x468
	[HeaderAttribute] // RVA: 0x720C0 Offset: 0x714C0 VA: 0x1800720C0
	public BlendedSoundLoops waterLoops; // 0x470
	public float waterSoundSpeedDivisor; // 0x478
	public GameObjectRef pushLandEffect; // 0x480
	public GameObjectRef pushWaterEffect; // 0x488
	public PlayerModel.MountPoses noPaddlePose; // 0x490
	private TimeSince splashEffectCooldown; // 0x494
	private Kayak.PlayerAnimationState[] animationStates; // 0x498
	private float lastSoundUpdate; // 0x4A0

	// Methods

	// RVA: 0x67E820 Offset: 0x67CE20 VA: 0x18067E820 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x67E720 Offset: 0x67CD20 VA: 0x18067E720
	public void OnPaddled(BaseEntity.RPCMessage msg) { }

	// RVA: 0x67DF80 Offset: 0x67C580 VA: 0x18067DF80 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x67E010 Offset: 0x67C610 VA: 0x18067E010 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x67EDD0 Offset: 0x67D3D0 VA: 0x18067EDD0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x67E5E0 Offset: 0x67CBE0 VA: 0x18067E5E0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x67DBB0 Offset: 0x67C1B0 VA: 0x18067DBB0
	public void AnimationSplashEvent(string splashType, BasePlayer forPlayer) { }

	// RVA: 0x67E0F0 Offset: 0x67C6F0 VA: 0x18067E0F0
	private string GetEffectPath(bool forward) { }

	// RVA: 0x67E2D0 Offset: 0x67C8D0 VA: 0x18067E2D0
	private int GetPlayerSeat_Client(BasePlayer p) { }

	// RVA: 0x67DE90 Offset: 0x67C490 VA: 0x18067DE90 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x67ED30 Offset: 0x67D330 VA: 0x18067ED30
	private bool ShowPushMenu(BasePlayer player) { }

	// RVA: 0x67F360 Offset: 0x67D960 VA: 0x18067F360
	private void UpdateSounds() { }

	// RVA: 0x67E0A0 Offset: 0x67C6A0 VA: 0x18067E0A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x67E4E0 Offset: 0x67CAE0 VA: 0x18067E4E0
	public bool IsPlayerHoldingPaddle(BasePlayer player) { }

	// RVA: 0x67E160 Offset: 0x67C760 VA: 0x18067E160
	private Vector3 GetPaddlePoint(int index, Kayak.PaddleDirection direction) { }

	// RVA: 0x67E470 Offset: 0x67CA70 VA: 0x18067E470
	private bool IsInWater() { }

	// RVA: 0x67F460 Offset: 0x67DA60 VA: 0x18067F460
	public void .ctor() { }

}

private struct Kayak.PlayerAnimationState // TypeDefIndex: 8594
{	// Fields
	public Vector3 smoothedAnimDirection; // 0x0
	public TimeSince lastPaddle; // 0xC
	public Kayak.PaddleDirection lastPaddleDirection; // 0x10

}

private enum Kayak.PaddleDirection // TypeDefIndex: 8595
{	// Fields
	public int value__; // 0x0
	public const Kayak.PaddleDirection Left = 0;
	public const Kayak.PaddleDirection Right = 1;
	public const Kayak.PaddleDirection LeftBack = 2;
	public const Kayak.PaddleDirection RightBack = 3;

}

