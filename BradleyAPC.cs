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

	// RVA: 0x1F6EAD0 Offset: 0x1F6D0D0 VA: 0x181F6EAD0
	public static void ResetToPool(BradleyAPC instance) { }

	// RVA: 0x1F6EBF0 Offset: 0x1F6D1F0 VA: 0x181F6EBF0
	public void ResetToPool() { }

	// RVA: 0x1F6E5A0 Offset: 0x1F6CBA0 VA: 0x181F6E5A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F6CB40 Offset: 0x1F6B140 VA: 0x181F6CB40
	public void CopyTo(BradleyAPC instance) { }

	// RVA: 0x1F6CBE0 Offset: 0x1F6B1E0 VA: 0x181F6CBE0
	public BradleyAPC Copy() { }

	// RVA: 0x1F6DEB0 Offset: 0x1F6C4B0 VA: 0x181F6DEB0
	public static BradleyAPC Deserialize(Stream stream) { }

	// RVA: 0x1F6CCD0 Offset: 0x1F6B2D0 VA: 0x181F6CCD0
	public static BradleyAPC DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6D590 Offset: 0x1F6BB90 VA: 0x181F6D590
	public static BradleyAPC DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6DA50 Offset: 0x1F6C050 VA: 0x181F6DA50
	public static BradleyAPC Deserialize(byte[] buffer) { }

	// RVA: 0x1F6E750 Offset: 0x1F6CD50 VA: 0x181F6E750
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F700C0 Offset: 0x1F6E6C0 VA: 0x181F700C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F700E0 Offset: 0x1F6E6E0 VA: 0x181F700E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BradleyAPC previous) { }

	// RVA: 0x1F6EAB0 Offset: 0x1F6D0B0 VA: 0x181F6EAB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6D620 Offset: 0x1F6BC20 VA: 0x181F6D620
	public static BradleyAPC Deserialize(byte[] buffer, BradleyAPC instance, bool isDelta = False) { }

	// RVA: 0x1F6E240 Offset: 0x1F6C840 VA: 0x181F6E240
	public static BradleyAPC Deserialize(Stream stream, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F6CD50 Offset: 0x1F6B350 VA: 0x181F6CD50
	public static BradleyAPC DeserializeLengthDelimited(Stream stream, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F6D180 Offset: 0x1F6B780 VA: 0x181F6D180
	public static BradleyAPC DeserializeLength(Stream stream, int length, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F6ED10 Offset: 0x1F6D310 VA: 0x181F6ED10
	public static void SerializeDelta(Stream stream, BradleyAPC instance, BradleyAPC previous) { }

	// RVA: 0x1F6FA30 Offset: 0x1F6E030 VA: 0x181F6FA30
	public static void Serialize(Stream stream, BradleyAPC instance) { }

	// RVA: 0x1F700B0 Offset: 0x1F6E6B0 VA: 0x181F700B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F700C0 Offset: 0x1F6E6C0 VA: 0x181F700C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6F920 Offset: 0x1F6DF20 VA: 0x181F6F920
	public static byte[] SerializeToBytes(BradleyAPC instance) { }

	// RVA: 0x1F6F870 Offset: 0x1F6DE70 VA: 0x181F6F870
	public static void SerializeLengthDelimited(Stream stream, BradleyAPC instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x51F780 Offset: 0x51DD80 VA: 0x18051F780 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x51F280 Offset: 0x51D880 VA: 0x18051F280
	public void InitializeClientsideEffects() { }

	// RVA: 0x51FBD0 Offset: 0x51E1D0 VA: 0x18051FBD0
	public void ShutdownClientsideEffects() { }

	// RVA: 0x51FD70 Offset: 0x51E370 VA: 0x18051FD70
	public void UpdateSounds() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x51EB20 Offset: 0x51D120 VA: 0x18051EB20
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x51E7A0 Offset: 0x51CDA0 VA: 0x18051E7A0
	public void AimWeaponAt(Transform weaponYaw, Transform weaponPitch, Vector3 direction, float minPitch = -360, float maxPitch = 360, float maxYaw = 360, Transform parentOverride) { }

	// RVA: 0x51F370 Offset: 0x51D970 VA: 0x18051F370
	public void LateUpdate() { }

	// RVA: 0x51F6A0 Offset: 0x51DCA0 VA: 0x18051F6A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x51EFE0 Offset: 0x51D5E0 VA: 0x18051EFE0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x51F0E0 Offset: 0x51D6E0 VA: 0x18051F0E0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x5209E0 Offset: 0x51EFE0 VA: 0x1805209E0
	public void .ctor() { }

	// RVA: 0x5209A0 Offset: 0x51EFA0 VA: 0x1805209A0
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

	// RVA: 0x522E00 Offset: 0x521400 VA: 0x180522E00 Slot: 4
	public void EnterPool() { }

	// RVA: 0x5232A0 Offset: 0x5218A0 VA: 0x1805232A0
	public void Setup(BaseEntity ent, float time) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x522E80 Offset: 0x521480 VA: 0x180522E80
	public float GetPriorityScore(BradleyAPC apc) { }

	// RVA: 0x5231F0 Offset: 0x5217F0 VA: 0x1805231F0
	public bool IsVisible() { }

	// RVA: 0x523190 Offset: 0x521790 VA: 0x180523190
	public bool IsValid() { }

}

