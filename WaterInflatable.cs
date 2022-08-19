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
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float handSplashOffset; // 0x3B8
	public float velocitySplashMultiplier; // 0x3BC
	public Vector3 modifyEyeOffset; // 0x3C0
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
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

	// RVA: 0xC13C30 Offset: 0xC12230 VA: 0x180C13C30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 171
	public override bool get_IsSummerDlcVehicle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC13BD0 Offset: 0xC121D0 VA: 0x180C13BD0
	public void OnPaddled(BaseEntity.RPCMessage msg) { }

	// RVA: 0xC14390 Offset: 0xC12990 VA: 0x180C14390 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0xC129D0 Offset: 0xC10FD0 VA: 0x180C129D0
	public void AnimationSplashEvent(string splashType, BasePlayer forPlayer) { }

	// RVA: 0xC12810 Offset: 0xC10E10 VA: 0x180C12810
	public void AnimationMovementSoundEvent(string type, BasePlayer forPlayer) { }

	// RVA: 0xC130E0 Offset: 0xC116E0 VA: 0x180C130E0
	private string GetEffectPath(WaterInflatable.ParticleType t) { }

	// RVA: 0xC133E0 Offset: 0xC119E0 VA: 0x180C133E0
	private bool GetWorldSpaceSplashLocation(string eventString, BasePlayer player, out Vector3 resultPoint, out WaterInflatable.ParticleType type) { }

	// RVA: 0xC12C60 Offset: 0xC11260 VA: 0x180C12C60
	private Vector3 ApplyHandOffset(Vector3 resultPoint) { }

	// RVA: 0xC13170 Offset: 0xC11770 VA: 0x180C13170 Slot: 148
	public override Transform GetEyeOverride() { }

	// RVA: 0xC12E60 Offset: 0xC11460 VA: 0x180C12E60 Slot: 178
	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xC13900 Offset: 0xC11F00 VA: 0x180C13900 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xC13A00 Offset: 0xC12000 VA: 0x180C13A00 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0xC12ED0 Offset: 0xC114D0 VA: 0x180C12ED0 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xC14090 Offset: 0xC12690 VA: 0x180C14090 Slot: 160
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0xC14610 Offset: 0xC12C10 VA: 0x180C14610
	private void UpdateSounds(Vector3 worldVelocity) { }

	// RVA: 0xC142E0 Offset: 0xC128E0 VA: 0x180C142E0
	private void ToggleMovingParticles(bool state) { }

	// RVA: 0xC13840 Offset: 0xC11E40 VA: 0x180C13840 Slot: 167
	public override Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	// RVA: 0xC137D0 Offset: 0xC11DD0 VA: 0x180C137D0 Slot: 168
	public override bool LockThirdPersonOffset(out Vector3 offset) { }

	// RVA: 0xC13770 Offset: 0xC11D70 VA: 0x180C13770
	private bool IsOutOfWaterClient() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 186
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 187
	public void OnEmpty() { }

	// RVA: 0xC146F0 Offset: 0xC12CF0 VA: 0x180C146F0
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

