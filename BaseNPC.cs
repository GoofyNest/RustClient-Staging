public class BaseNPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6295
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int flags; // 0x14


	public static void ResetToPool(BaseNPC instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseNPC instance) { }

	public BaseNPC Copy() { }

	public static BaseNPC Deserialize(Stream stream) { }

	public static BaseNPC DeserializeLengthDelimited(Stream stream) { }

	public static BaseNPC DeserializeLength(Stream stream, int length) { }

	public static BaseNPC Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseNPC previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseNPC Deserialize(byte[] buffer, BaseNPC instance, bool isDelta = False) { }

	public static BaseNPC Deserialize(Stream stream, BaseNPC instance, bool isDelta) { }

	public static BaseNPC DeserializeLengthDelimited(Stream stream, BaseNPC instance, bool isDelta) { }

	public static BaseNPC DeserializeLength(Stream stream, int length, BaseNPC instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseNPC instance, BaseNPC previous) { }

	public static void Serialize(Stream stream, BaseNPC instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseNPC instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseNPC instance) { }

	public void .ctor() { }

}

public class BaseNpc : BaseCombatEntity // TypeDefIndex: 8525
{	public int agentTypeIndex; // 0x240
	public bool NewAI; // 0x244
	[SerializeField] // RVA: 0x93600 Offset: 0x92A00 VA: 0x180093600
	[InspectorFlagsAttribute] // RVA: 0x93600 Offset: 0x92A00 VA: 0x180093600
	public TerrainTopology.Enum topologyPreference; // 0x248
	public Quaternion NetworkRotation; // 0x24C
	private static List<BaseNpc> visibleNpcList; // 0x0
	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public BaseNpc.AiFlags aiFlags; // 0x25C
	[HeaderAttribute] // RVA: 0xA3030 Offset: 0xA2430 VA: 0x1800A3030
	public int ForgetUnseenEntityTime; // 0x260
	public float SensesTickRate; // 0x264
	private float nextVisThink; // 0x268
	private float lastTimeSeen; // 0x26C
	private Vector3 lastPosition; // 0x270
	[HeaderAttribute] // RVA: 0xA3100 Offset: 0xA2500 VA: 0x1800A3100
	public GameObjectRef CorpsePrefab; // 0x280
	public BaseNpc.AiStatistics Stats; // 0x288
	public Vector3 AttackOffset; // 0x338
	public float AttackDamage; // 0x344
	public DamageType AttackDamageType; // 0x348
	[TooltipAttribute] // RVA: 0xA3180 Offset: 0xA2580 VA: 0x1800A3180
	public float AttackCost; // 0x34C
	[TooltipAttribute] // RVA: 0xA3340 Offset: 0xA2740 VA: 0x1800A3340
	public float AttackRate; // 0x350
	[TooltipAttribute] // RVA: 0xA3410 Offset: 0xA2810 VA: 0x1800A3410
	public float AttackRange; // 0x354
	public NavMeshAgent NavAgent; // 0x358
	public LayerMask movementMask; // 0x360
	public float stuckDuration; // 0x364
	public float lastStuckTime; // 0x368
	public float idleDuration; // 0x36C

	public static List<BaseNpc> VisibleNpcList { get; }
	public bool IsSitting { get; set; }
	public bool IsChasing { get; set; }
	public bool IsSleeping { get; set; }
	public override bool IsNpc { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int TopologyPreference() { }

	public override float GetExtrapolationTime() { }

	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public static void ClientCycle(float deltaTime) { }

	public override void MakeVisible() { }

	protected void ClientUpdate() { }

	public static List<BaseNpc> get_VisibleNpcList() { }

	public static void ClearVisibility() { }

	public static void RegisterForVisibility(BaseNpc npc) { }

	public static void UnregisterFromVisibility(BaseNpc npc) { }

	public override void SetNetworkRotation(Quaternion rot) { }

	public override Quaternion GetNetworkRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public virtual void Eat(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public virtual void Attack(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public virtual void Startled(Vector3 position) { }

	public bool HasAiFlag(BaseNpc.AiFlags f) { }

	public void SetAiFlag(BaseNpc.AiFlags f, bool set) { }

	public bool get_IsSitting() { }

	public void set_IsSitting(bool value) { }

	public bool get_IsChasing() { }

	public void set_IsChasing(bool value) { }

	public bool get_IsSleeping() { }

	public void set_IsSleeping(bool value) { }

	public static void UpdateNpcVisibilities() { }

	private float TimeSinceSeen() { }

	private void SetNextVisThink(float addTime) { }

	private bool WantsVisUpdate() { }

	protected override void UpdateCullingSpheres() { }

	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	protected override void OnVisibilityChanged(bool visible) { }

	private void VisUpdate() { }

	public override bool get_IsNpc() { }

	public override float MaxVelocity() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum BaseNpc.AiFlags // TypeDefIndex: 8526
{	public int value__; // 0x0
	public const BaseNpc.AiFlags Sitting = 2;
	public const BaseNpc.AiFlags Chasing = 4;
	public const BaseNpc.AiFlags Sleeping = 8;

}

public struct BaseNpc.AiStatistics // TypeDefIndex: 8527
{	[TooltipAttribute] // RVA: 0xA3700 Offset: 0xA2B00 VA: 0x1800A3700
	[RangeAttribute] // RVA: 0xA3700 Offset: 0xA2B00 VA: 0x1800A3700
	public float Size; // 0x0
	[TooltipAttribute] // RVA: 0xA37E0 Offset: 0xA2BE0 VA: 0x1800A37E0
	public float Speed; // 0x4
	[TooltipAttribute] // RVA: 0xA3860 Offset: 0xA2C60 VA: 0x1800A3860
	public float Acceleration; // 0x8
	[TooltipAttribute] // RVA: 0xA3900 Offset: 0xA2D00 VA: 0x1800A3900
	public float TurnSpeed; // 0xC
	[TooltipAttribute] // RVA: 0xA39B0 Offset: 0xA2DB0 VA: 0x1800A39B0
	[RangeAttribute] // RVA: 0xA39B0 Offset: 0xA2DB0 VA: 0x1800A39B0
	public float Tolerance; // 0x10
	[TooltipAttribute] // RVA: 0xA3AE0 Offset: 0xA2EE0 VA: 0x1800A3AE0
	public float VisionRange; // 0x14
	[TooltipAttribute] // RVA: 0xA3B50 Offset: 0xA2F50 VA: 0x1800A3B50
	public float VisionCone; // 0x18
	[TooltipAttribute] // RVA: 0xA3C50 Offset: 0xA3050 VA: 0x1800A3C50
	public AnimationCurve DistanceVisibility; // 0x20
	[TooltipAttribute] // RVA: 0xA3CE0 Offset: 0xA30E0 VA: 0x1800A3CE0
	public float Hostility; // 0x28
	[TooltipAttribute] // RVA: 0xA3E10 Offset: 0xA3210 VA: 0x1800A3E10
	public float Defensiveness; // 0x2C
	[TooltipAttribute] // RVA: 0xA3EE0 Offset: 0xA32E0 VA: 0x1800A3EE0
	public float AggressionRange; // 0x30
	[TooltipAttribute] // RVA: 0xA3FE0 Offset: 0xA33E0 VA: 0x1800A3FE0
	public float DeaggroRange; // 0x34
	[TooltipAttribute] // RVA: 0xA4150 Offset: 0xA3550 VA: 0x1800A4150
	public float DeaggroChaseTime; // 0x38
	[TooltipAttribute] // RVA: 0xA42B0 Offset: 0xA36B0 VA: 0x1800A42B0
	public float DeaggroCooldown; // 0x3C
	[TooltipAttribute] // RVA: 0xA43B0 Offset: 0xA37B0 VA: 0x1800A43B0
	public float HealthThresholdForFleeing; // 0x40
	[TooltipAttribute] // RVA: 0xA44F0 Offset: 0xA38F0 VA: 0x1800A44F0
	public float HealthThresholdFleeChance; // 0x44
	[TooltipAttribute] // RVA: 0xA4640 Offset: 0xA3A40 VA: 0x1800A4640
	public float MinFleeRange; // 0x48
	[TooltipAttribute] // RVA: 0xA47B0 Offset: 0xA3BB0 VA: 0x1800A47B0
	public float MaxFleeRange; // 0x4C
	[TooltipAttribute] // RVA: 0xA49D0 Offset: 0xA3DD0 VA: 0x1800A49D0
	public float MaxFleeTime; // 0x50
	[TooltipAttribute] // RVA: 0xA4AC0 Offset: 0xA3EC0 VA: 0x1800A4AC0
	public float AfraidRange; // 0x54
	[TooltipAttribute] // RVA: 0xA4B80 Offset: 0xA3F80 VA: 0x1800A4B80
	public BaseNpc.AiStatistics.FamilyEnum Family; // 0x58
	[TooltipAttribute] // RVA: 0xA4D60 Offset: 0xA4160 VA: 0x1800A4D60
	public BaseNpc.AiStatistics.FamilyEnum[] IsAfraidOf; // 0x60
	[TooltipAttribute] // RVA: 0xA4D90 Offset: 0xA4190 VA: 0x1800A4D90
	public float MinRoamRange; // 0x68
	[TooltipAttribute] // RVA: 0xA4E90 Offset: 0xA4290 VA: 0x1800A4E90
	public float MaxRoamRange; // 0x6C
	[TooltipAttribute] // RVA: 0xA50B0 Offset: 0xA44B0 VA: 0x1800A50B0
	public float MinRoamDelay; // 0x70
	[TooltipAttribute] // RVA: 0xA5120 Offset: 0xA4520 VA: 0x1800A5120
	public float MaxRoamDelay; // 0x74
	[TooltipAttribute] // RVA: 0xA5230 Offset: 0xA4630 VA: 0x1800A5230
	public bool IsMobile; // 0x78
	[TooltipAttribute] // RVA: 0xA5300 Offset: 0xA4700 VA: 0x1800A5300
	public AnimationCurve RoamDelayDistribution; // 0x80
	[TooltipAttribute] // RVA: 0xA5470 Offset: 0xA4870 VA: 0x1800A5470
	public float AttackedMemoryTime; // 0x88
	[TooltipAttribute] // RVA: 0xA5600 Offset: 0xA4A00 VA: 0x1800A5600
	public float WakeupBlockMoveTime; // 0x8C
	[TooltipAttribute] // RVA: 0xA56C0 Offset: 0xA4AC0 VA: 0x1800A56C0
	public float MaxWaterDepth; // 0x90
	[TooltipAttribute] // RVA: 0xA5780 Offset: 0xA4B80 VA: 0x1800A5780
	public float WaterLevelNeck; // 0x94
	public float WaterLevelNeckOffset; // 0x98
	[TooltipAttribute] // RVA: 0xA5B60 Offset: 0xA4F60 VA: 0x1800A5B60
	public float CloseRange; // 0x9C
	[TooltipAttribute] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	public float MediumRange; // 0xA0
	[TooltipAttribute] // RVA: 0xA5CE0 Offset: 0xA50E0 VA: 0x1800A5CE0
	public float LongRange; // 0xA4
	[TooltipAttribute] // RVA: 0xA5DF0 Offset: 0xA51F0 VA: 0x1800A5DF0
	public float OutOfRangeOfSpawnPointTimeout; // 0xA8
	[TooltipAttribute] // RVA: 0xA5E60 Offset: 0xA5260 VA: 0x1800A5E60
	public bool OnlyAggroMarkedTargets; // 0xAC

}

public enum BaseNpc.AiStatistics.FamilyEnum // TypeDefIndex: 8528
{	public int value__; // 0x0
	public const BaseNpc.AiStatistics.FamilyEnum Bear = 0;
	public const BaseNpc.AiStatistics.FamilyEnum Wolf = 1;
	public const BaseNpc.AiStatistics.FamilyEnum Deer = 2;
	public const BaseNpc.AiStatistics.FamilyEnum Boar = 3;
	public const BaseNpc.AiStatistics.FamilyEnum Chicken = 4;
	public const BaseNpc.AiStatistics.FamilyEnum Horse = 5;
	public const BaseNpc.AiStatistics.FamilyEnum Zombie = 6;
	public const BaseNpc.AiStatistics.FamilyEnum Scientist = 7;
	public const BaseNpc.AiStatistics.FamilyEnum Murderer = 8;
	public const BaseNpc.AiStatistics.FamilyEnum Player = 9;

}

