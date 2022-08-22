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

	// RVA: 0x67E7B0 Offset: 0x67CDB0 VA: 0x18067E7B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x67E6B0 Offset: 0x67CCB0 VA: 0x18067E6B0
	public void OnPaddled(BaseEntity.RPCMessage msg) { }

	// RVA: 0x67DF10 Offset: 0x67C510 VA: 0x18067DF10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x67DFA0 Offset: 0x67C5A0 VA: 0x18067DFA0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x67ED60 Offset: 0x67D360 VA: 0x18067ED60 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x67E570 Offset: 0x67CB70 VA: 0x18067E570 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x67DB40 Offset: 0x67C140 VA: 0x18067DB40
	public void AnimationSplashEvent(string splashType, BasePlayer forPlayer) { }

	// RVA: 0x67E080 Offset: 0x67C680 VA: 0x18067E080
	private string GetEffectPath(bool forward) { }

	// RVA: 0x67E260 Offset: 0x67C860 VA: 0x18067E260
	private int GetPlayerSeat_Client(BasePlayer p) { }

	// RVA: 0x67DE20 Offset: 0x67C420 VA: 0x18067DE20 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x67ECC0 Offset: 0x67D2C0 VA: 0x18067ECC0
	private bool ShowPushMenu(BasePlayer player) { }

	// RVA: 0x67F2F0 Offset: 0x67D8F0 VA: 0x18067F2F0
	private void UpdateSounds() { }

	// RVA: 0x67E030 Offset: 0x67C630 VA: 0x18067E030 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x67E470 Offset: 0x67CA70 VA: 0x18067E470
	public bool IsPlayerHoldingPaddle(BasePlayer player) { }

	// RVA: 0x67E0F0 Offset: 0x67C6F0 VA: 0x18067E0F0
	private Vector3 GetPaddlePoint(int index, Kayak.PaddleDirection direction) { }

	// RVA: 0x67E400 Offset: 0x67CA00 VA: 0x18067E400
	private bool IsInWater() { }

	// RVA: 0x67F3F0 Offset: 0x67D9F0 VA: 0x18067F3F0
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

