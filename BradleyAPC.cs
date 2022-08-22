public class BradleyAPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6342
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float engineThrottle; // 0x14
	public float throttleLeft; // 0x18
	public float throttleRight; // 0x1C
	public Vector3 mainGunVec; // 0x20
	public Vector3 topTurretVec; // 0x2C
	public Vector3 rearGunVec; // 0x38
	public Vector3 leftSideGun1; // 0x44
	public Vector3 leftSideGun2; // 0x50
	public Vector3 rightSideGun1; // 0x5C
	public Vector3 rightSideGun2; // 0x68

	// Methods

	// RVA: 0x1F6F5B0 Offset: 0x1F6DBB0 VA: 0x181F6F5B0
	public static void ResetToPool(BradleyAPC instance) { }

	// RVA: 0x1F6F6D0 Offset: 0x1F6DCD0 VA: 0x181F6F6D0
	public void ResetToPool() { }

	// RVA: 0x1F6F080 Offset: 0x1F6D680 VA: 0x181F6F080 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F6D620 Offset: 0x1F6BC20 VA: 0x181F6D620
	public void CopyTo(BradleyAPC instance) { }

	// RVA: 0x1F6D6C0 Offset: 0x1F6BCC0 VA: 0x181F6D6C0
	public BradleyAPC Copy() { }

	// RVA: 0x1F6E990 Offset: 0x1F6CF90 VA: 0x181F6E990
	public static BradleyAPC Deserialize(Stream stream) { }

	// RVA: 0x1F6D7B0 Offset: 0x1F6BDB0 VA: 0x181F6D7B0
	public static BradleyAPC DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6E070 Offset: 0x1F6C670 VA: 0x181F6E070
	public static BradleyAPC DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6E530 Offset: 0x1F6CB30 VA: 0x181F6E530
	public static BradleyAPC Deserialize(byte[] buffer) { }

	// RVA: 0x1F6F230 Offset: 0x1F6D830 VA: 0x181F6F230
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F70BA0 Offset: 0x1F6F1A0 VA: 0x181F70BA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F70BC0 Offset: 0x1F6F1C0 VA: 0x181F70BC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BradleyAPC previous) { }

	// RVA: 0x1F6F590 Offset: 0x1F6DB90 VA: 0x181F6F590 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6E100 Offset: 0x1F6C700 VA: 0x181F6E100
	public static BradleyAPC Deserialize(byte[] buffer, BradleyAPC instance, bool isDelta = False) { }

	// RVA: 0x1F6ED20 Offset: 0x1F6D320 VA: 0x181F6ED20
	public static BradleyAPC Deserialize(Stream stream, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F6D830 Offset: 0x1F6BE30 VA: 0x181F6D830
	public static BradleyAPC DeserializeLengthDelimited(Stream stream, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F6DC60 Offset: 0x1F6C260 VA: 0x181F6DC60
	public static BradleyAPC DeserializeLength(Stream stream, int length, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F6F7F0 Offset: 0x1F6DDF0 VA: 0x181F6F7F0
	public static void SerializeDelta(Stream stream, BradleyAPC instance, BradleyAPC previous) { }

	// RVA: 0x1F70510 Offset: 0x1F6EB10 VA: 0x181F70510
	public static void Serialize(Stream stream, BradleyAPC instance) { }

	// RVA: 0x1F70B90 Offset: 0x1F6F190 VA: 0x181F70B90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F70BA0 Offset: 0x1F6F1A0 VA: 0x181F70BA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F70400 Offset: 0x1F6EA00 VA: 0x181F70400
	public static byte[] SerializeToBytes(BradleyAPC instance) { }

	// RVA: 0x1F70350 Offset: 0x1F6E950 VA: 0x181F70350
	public static void SerializeLengthDelimited(Stream stream, BradleyAPC instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class BradleyAPC : BaseCombatEntity // TypeDefIndex: 8536
{	// Fields
	[HeaderAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public BlendedLoopEngineSound engineSound; // 0x240
	public SoundDefinition treadLoopDef; // 0x248
	public AnimationCurve treadGainCurve; // 0x250
	public AnimationCurve treadPitchCurve; // 0x258
	public AnimationCurve treadFreqCurve; // 0x260
	private Sound treadLoop; // 0x268
	private SoundModulation.Modulator treadGain; // 0x270
	private SoundModulation.Modulator treadPitch; // 0x278
	public SoundDefinition chasisLurchSoundDef; // 0x280
	public float chasisLurchAngleDelta; // 0x288
	public float chasisLurchSpeedDelta; // 0x28C
	private float lastAngle; // 0x290
	private float lastSpeed; // 0x294
	public SoundDefinition turretTurnLoopDef; // 0x298
	public float turretLoopGainSpeed; // 0x2A0
	public float turretLoopPitchSpeed; // 0x2A4
	public float turretLoopMinAngleDelta; // 0x2A8
	public float turretLoopMaxAngleDelta; // 0x2AC
	public float turretLoopPitchMin; // 0x2B0
	public float turretLoopPitchMax; // 0x2B4
	public float turretLoopGainThreshold; // 0x2B8
	private Sound turretTurnLoop; // 0x2C0
	private SoundModulation.Modulator turretTurnLoopGain; // 0x2C8
	private SoundModulation.Modulator turretTurnLoopPitch; // 0x2D0
	public float enginePitch; // 0x2D8
	public float rpmMultiplier; // 0x2DC
	private TreadAnimator treadAnimator; // 0x2E0
	private float lastTurretAngle; // 0x2E8
	[HeaderAttribute] // RVA: 0xA7E50 Offset: 0xA7250 VA: 0x1800A7E50
	public List<Vector3> currentPath; // 0x2F0
	public int currentPathIndex; // 0x2F8
	public bool pathLooping; // 0x2FC
	[HeaderAttribute] // RVA: 0x788B0 Offset: 0x77CB0 VA: 0x1800788B0
	public float viewDistance; // 0x300
	public float searchRange; // 0x304
	public float searchFrequency; // 0x308
	public float memoryDuration; // 0x30C
	public static float sightUpdateRate; // 0x0
	public List<BradleyAPC.TargetInfo> targetList; // 0x310
	[HeaderAttribute] // RVA: 0xA7ED0 Offset: 0xA72D0 VA: 0x1800A7ED0
	public float coaxFireRate; // 0x318
	public int coaxBurstLength; // 0x31C
	public float coaxAimCone; // 0x320
	public float bulletDamage; // 0x324
	[HeaderAttribute] // RVA: 0xA7F70 Offset: 0xA7370 VA: 0x1800A7F70
	public float topTurretFireRate; // 0x328
	public GameObjectRef gun_fire_effect; // 0x330
	public GameObjectRef bulletEffect; // 0x338
	private float lastLateUpdate; // 0x340
	[HeaderAttribute] // RVA: 0x84BA0 Offset: 0x83FA0 VA: 0x180084BA0
	public WheelCollider[] leftWheels; // 0x348
	public WheelCollider[] rightWheels; // 0x350
	[HeaderAttribute] // RVA: 0xA8080 Offset: 0xA7480 VA: 0x1800A8080
	public float moveForceMax; // 0x358
	public float brakeForce; // 0x35C
	public float turnForce; // 0x360
	public float sideStiffnessMax; // 0x364
	public float sideStiffnessMin; // 0x368
	public Transform centerOfMass; // 0x370
	public float stoppingDist; // 0x378
	[HeaderAttribute] // RVA: 0xA94B0 Offset: 0xA88B0 VA: 0x1800A94B0
	public float throttle; // 0x37C
	public float turning; // 0x380
	public float rightThrottle; // 0x384
	public float leftThrottle; // 0x388
	public bool brake; // 0x38C
	[HeaderAttribute] // RVA: 0xA9550 Offset: 0xA8950 VA: 0x1800A9550
	public Rigidbody myRigidBody; // 0x390
	public Collider myCollider; // 0x398
	public Vector3 destination; // 0x3A0
	private Vector3 finalDestination; // 0x3AC
	public Transform followTest; // 0x3B8
	public TriggerHurtEx impactDamager; // 0x3C0
	[HeaderAttribute] // RVA: 0x8AD80 Offset: 0x8A180 VA: 0x18008AD80
	public Transform mainTurretEyePos; // 0x3C8
	public Transform mainTurret; // 0x3D0
	public Transform CannonPitch; // 0x3D8
	public Transform CannonMuzzle; // 0x3E0
	public Transform coaxPitch; // 0x3E8
	public Transform coaxMuzzle; // 0x3F0
	public Transform topTurretEyePos; // 0x3F8
	public Transform topTurretYaw; // 0x400
	public Transform topTurretPitch; // 0x408
	public Transform topTurretMuzzle; // 0x410
	private Vector3 turretAimVector; // 0x418
	private Vector3 desiredAimVector; // 0x424
	private Vector3 topTurretAimVector; // 0x430
	private Vector3 desiredTopTurretAimVector; // 0x43C
	[HeaderAttribute] // RVA: 0x787C0 Offset: 0x77BC0 VA: 0x1800787C0
	public GameObjectRef explosionEffect; // 0x448
	public GameObjectRef servergibs; // 0x450
	public GameObjectRef fireBall; // 0x458
	public GameObjectRef crateToDrop; // 0x460
	public GameObjectRef debrisFieldMarker; // 0x468
	[HeaderAttribute] // RVA: 0x83090 Offset: 0x82490 VA: 0x180083090
	public int maxCratesToSpawn; // 0x470
	public int patrolPathIndex; // 0x474
	public BasePath patrolPath; // 0x478
	public bool DoAI; // 0x480
	public GameObjectRef mainCannonMuzzleFlash; // 0x488
	public GameObjectRef mainCannonProjectile; // 0x490
	public float recoilScale; // 0x498
	public NavMeshPath navMeshPath; // 0x4A0
	public int navMeshPathIndex; // 0x4A8

	// Methods

	// RVA: 0x51F710 Offset: 0x51DD10 VA: 0x18051F710 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x51F210 Offset: 0x51D810 VA: 0x18051F210
	public void InitializeClientsideEffects() { }

	// RVA: 0x51FB60 Offset: 0x51E160 VA: 0x18051FB60
	public void ShutdownClientsideEffects() { }

	// RVA: 0x51FD00 Offset: 0x51E300 VA: 0x18051FD00
	public void UpdateSounds() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x51EAB0 Offset: 0x51D0B0 VA: 0x18051EAB0
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x51E730 Offset: 0x51CD30 VA: 0x18051E730
	public void AimWeaponAt(Transform weaponYaw, Transform weaponPitch, Vector3 direction, float minPitch = -360, float maxPitch = 360, float maxYaw = 360, Transform parentOverride) { }

	// RVA: 0x51F300 Offset: 0x51D900 VA: 0x18051F300
	public void LateUpdate() { }

	// RVA: 0x51F630 Offset: 0x51DC30 VA: 0x18051F630 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x51EF70 Offset: 0x51D570 VA: 0x18051EF70 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x51F070 Offset: 0x51D670 VA: 0x18051F070 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x520970 Offset: 0x51EF70 VA: 0x180520970
	public void .ctor() { }

	// RVA: 0x520930 Offset: 0x51EF30 VA: 0x180520930
	private static void .cctor() { }

}

public class BradleyAPC.TargetInfo : Pool.IPooled // TypeDefIndex: 8537
{	// Fields
	public float damageReceivedFrom; // 0x10
	public BaseEntity entity; // 0x18
	public float lastSeenTime; // 0x20
	public Vector3 lastSeenPosition; // 0x24

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x522D90 Offset: 0x521390 VA: 0x180522D90 Slot: 4
	public void EnterPool() { }

	// RVA: 0x523230 Offset: 0x521830 VA: 0x180523230
	public void Setup(BaseEntity ent, float time) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x522E10 Offset: 0x521410 VA: 0x180522E10
	public float GetPriorityScore(BradleyAPC apc) { }

	// RVA: 0x523180 Offset: 0x521780 VA: 0x180523180
	public bool IsVisible() { }

	// RVA: 0x523120 Offset: 0x521720 VA: 0x180523120
	public bool IsValid() { }

}

