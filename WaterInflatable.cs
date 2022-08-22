public class WaterInflatable : BaseMountable, IPoolVehicle, INotifyTrigger // TypeDefIndex: 8659
{	// Fields
	public Rigidbody rigidBody; // 0x320
	public Transform centerOfMass; // 0x328
	public float forwardPushForce; // 0x330
	public float rearPushForce; // 0x334
	public float rotationForce; // 0x338
	public float maxSpeed; // 0x33C
	public float maxPaddleFrequency; // 0x340
	public SoundDefinition paddleSfx; // 0x348
	public SoundDefinition smallPlayerMovementSound; // 0x350
	public SoundDefinition largePlayerMovementSound; // 0x358
	public BlendedSoundLoops waterLoops; // 0x360
	public float waterSoundSpeedDivisor; // 0x368
	public float additiveDownhillVelocity; // 0x36C
	public GameObjectRef handSplashForwardEffect; // 0x370
	public GameObjectRef handSplashBackEffect; // 0x378
	public GameObjectRef footSplashEffect; // 0x380
	public float animationLerpSpeed; // 0x388
	public Transform smoothedEyePosition; // 0x390
	public float smoothedEyeSpeed; // 0x398
	public Buoyancy buoyancy; // 0x3A0
	public bool driftTowardsIsland; // 0x3A8
	public GameObjectRef mountEffect; // 0x3B0
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float handSplashOffset; // 0x3B8
	public float velocitySplashMultiplier; // 0x3BC
	public Vector3 modifyEyeOffset; // 0x3C0
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float inheritVelocityMultiplier; // 0x3CC
	private TimeSince lastPaddle; // 0x3D0
	public ParticleSystem[] movingParticleSystems; // 0x3D8
	public float movingParticlesThreshold; // 0x3E0
	public Transform headSpaceCheckPosition; // 0x3E8
	public float headSpaceCheckRadius; // 0x3F0
	private WaterInflatable.PaddleDirection lastPaddleDirection; // 0x3F4
	private Vector3 smoothedAnimDirection; // 0x3F8
	private Vector3 smoothedEyePos; // 0x404
	private Quaternion smoothedEyeRot; // 0x410

	// Properties
	public override bool IsSummerDlcVehicle { get; }

	// Methods

	// RVA: 0xC143C0 Offset: 0xC129C0 VA: 0x180C143C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 171
	public override bool get_IsSummerDlcVehicle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC14360 Offset: 0xC12960 VA: 0x180C14360
	public void OnPaddled(BaseEntity.RPCMessage msg) { }

	// RVA: 0xC14B20 Offset: 0xC13120 VA: 0x180C14B20 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0xC13160 Offset: 0xC11760 VA: 0x180C13160
	public void AnimationSplashEvent(string splashType, BasePlayer forPlayer) { }

	// RVA: 0xC12FA0 Offset: 0xC115A0 VA: 0x180C12FA0
	public void AnimationMovementSoundEvent(string type, BasePlayer forPlayer) { }

	// RVA: 0xC13870 Offset: 0xC11E70 VA: 0x180C13870
	private string GetEffectPath(WaterInflatable.ParticleType t) { }

	// RVA: 0xC13B70 Offset: 0xC12170 VA: 0x180C13B70
	private bool GetWorldSpaceSplashLocation(string eventString, BasePlayer player, out Vector3 resultPoint, out WaterInflatable.ParticleType type) { }

	// RVA: 0xC133F0 Offset: 0xC119F0 VA: 0x180C133F0
	private Vector3 ApplyHandOffset(Vector3 resultPoint) { }

	// RVA: 0xC13900 Offset: 0xC11F00 VA: 0x180C13900 Slot: 148
	public override Transform GetEyeOverride() { }

	// RVA: 0xC135F0 Offset: 0xC11BF0 VA: 0x180C135F0 Slot: 178
	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xC14090 Offset: 0xC12690 VA: 0x180C14090 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xC14190 Offset: 0xC12790 VA: 0x180C14190 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0xC13660 Offset: 0xC11C60 VA: 0x180C13660 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xC14820 Offset: 0xC12E20 VA: 0x180C14820 Slot: 160
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0xC14DA0 Offset: 0xC133A0 VA: 0x180C14DA0
	private void UpdateSounds(Vector3 worldVelocity) { }

	// RVA: 0xC14A70 Offset: 0xC13070 VA: 0x180C14A70
	private void ToggleMovingParticles(bool state) { }

	// RVA: 0xC13FD0 Offset: 0xC125D0 VA: 0x180C13FD0 Slot: 167
	public override Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	// RVA: 0xC13F60 Offset: 0xC12560 VA: 0x180C13F60 Slot: 168
	public override bool LockThirdPersonOffset(out Vector3 offset) { }

	// RVA: 0xC13F00 Offset: 0xC12500 VA: 0x180C13F00
	private bool IsOutOfWaterClient() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 186
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 187
	public void OnEmpty() { }

	// RVA: 0xC14E80 Offset: 0xC13480 VA: 0x180C14E80
	public void .ctor() { }

}

private enum WaterInflatable.PaddleDirection // TypeDefIndex: 8660
{	// Fields
	public int value__; // 0x0
	public const WaterInflatable.PaddleDirection Forward = 0;
	public const WaterInflatable.PaddleDirection Left = 1;
	public const WaterInflatable.PaddleDirection Right = 2;
	public const WaterInflatable.PaddleDirection Back = 3;

}

private enum WaterInflatable.ParticleType // TypeDefIndex: 8661
{	// Fields
	public int value__; // 0x0
	public const WaterInflatable.ParticleType HandForward = 0;
	public const WaterInflatable.ParticleType HandBack = 1;
	public const WaterInflatable.ParticleType Foot = 2;

}

