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
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[InspectorFlagsAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	public TerrainTopology.Enum topologyPreference; // 0x248
	public Quaternion NetworkRotation; // 0x24C
	private static List<BaseNpc> visibleNpcList; // 0x0
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public BaseNpc.AiFlags aiFlags; // 0x25C
	[HeaderAttribute] // RVA: 0xA2F60 Offset: 0xA2360 VA: 0x1800A2F60
	public int ForgetUnseenEntityTime; // 0x260
	public float SensesTickRate; // 0x264
	private float nextVisThink; // 0x268
	private float lastTimeSeen; // 0x26C
	private Vector3 lastPosition; // 0x270
	[HeaderAttribute] // RVA: 0xA3020 Offset: 0xA2420 VA: 0x1800A3020
	public GameObjectRef CorpsePrefab; // 0x280
	public BaseNpc.AiStatistics Stats; // 0x288
	public Vector3 AttackOffset; // 0x338
	public float AttackDamage; // 0x344
	public DamageType AttackDamageType; // 0x348
	[TooltipAttribute] // RVA: 0xA30A0 Offset: 0xA24A0 VA: 0x1800A30A0
	public float AttackCost; // 0x34C
	[TooltipAttribute] // RVA: 0xA3220 Offset: 0xA2620 VA: 0x1800A3220
	public float AttackRate; // 0x350
	[TooltipAttribute] // RVA: 0xA32F0 Offset: 0xA26F0 VA: 0x1800A32F0
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

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public virtual void Eat(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public virtual void Attack(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
{	[TooltipAttribute] // RVA: 0xA35E0 Offset: 0xA29E0 VA: 0x1800A35E0
	[RangeAttribute] // RVA: 0xA35E0 Offset: 0xA29E0 VA: 0x1800A35E0
	public float Size; // 0x0
	[TooltipAttribute] // RVA: 0xA3700 Offset: 0xA2B00 VA: 0x1800A3700
	public float Speed; // 0x4
	[TooltipAttribute] // RVA: 0xA3780 Offset: 0xA2B80 VA: 0x1800A3780
	public float Acceleration; // 0x8
	[TooltipAttribute] // RVA: 0xA37E0 Offset: 0xA2BE0 VA: 0x1800A37E0
	public float TurnSpeed; // 0xC
	[TooltipAttribute] // RVA: 0xA3890 Offset: 0xA2C90 VA: 0x1800A3890
	[RangeAttribute] // RVA: 0xA3890 Offset: 0xA2C90 VA: 0x1800A3890
	public float Tolerance; // 0x10
	[TooltipAttribute] // RVA: 0xA39C0 Offset: 0xA2DC0 VA: 0x1800A39C0
	public float VisionRange; // 0x14
	[TooltipAttribute] // RVA: 0xA3A30 Offset: 0xA2E30 VA: 0x1800A3A30
	public float VisionCone; // 0x18
	[TooltipAttribute] // RVA: 0xA3B60 Offset: 0xA2F60 VA: 0x1800A3B60
	public AnimationCurve DistanceVisibility; // 0x20
	[TooltipAttribute] // RVA: 0xA3C00 Offset: 0xA3000 VA: 0x1800A3C00
	public float Hostility; // 0x28
	[TooltipAttribute] // RVA: 0xA3DA0 Offset: 0xA31A0 VA: 0x1800A3DA0
	public float Defensiveness; // 0x2C
	[TooltipAttribute] // RVA: 0xA3E60 Offset: 0xA3260 VA: 0x1800A3E60
	public float AggressionRange; // 0x30
	[TooltipAttribute] // RVA: 0xA3EF0 Offset: 0xA32F0 VA: 0x1800A3EF0
	public float DeaggroRange; // 0x34
	[TooltipAttribute] // RVA: 0xA4060 Offset: 0xA3460 VA: 0x1800A4060
	public float DeaggroChaseTime; // 0x38
	[TooltipAttribute] // RVA: 0xA41C0 Offset: 0xA35C0 VA: 0x1800A41C0
	public float DeaggroCooldown; // 0x3C
	[TooltipAttribute] // RVA: 0xA4290 Offset: 0xA3690 VA: 0x1800A4290
	public float HealthThresholdForFleeing; // 0x40
	[TooltipAttribute] // RVA: 0xA43D0 Offset: 0xA37D0 VA: 0x1800A43D0
	public float HealthThresholdFleeChance; // 0x44
	[TooltipAttribute] // RVA: 0xA45C0 Offset: 0xA39C0 VA: 0x1800A45C0
	public float MinFleeRange; // 0x48
	[TooltipAttribute] // RVA: 0xA46F0 Offset: 0xA3AF0 VA: 0x1800A46F0
	public float MaxFleeRange; // 0x4C
	[TooltipAttribute] // RVA: 0xA48F0 Offset: 0xA3CF0 VA: 0x1800A48F0
	public float MaxFleeTime; // 0x50
	[TooltipAttribute] // RVA: 0xA49A0 Offset: 0xA3DA0 VA: 0x1800A49A0
	public float AfraidRange; // 0x54
	[TooltipAttribute] // RVA: 0xA4A60 Offset: 0xA3E60 VA: 0x1800A4A60
	public BaseNpc.AiStatistics.FamilyEnum Family; // 0x58
	[TooltipAttribute] // RVA: 0xA4C70 Offset: 0xA4070 VA: 0x1800A4C70
	public BaseNpc.AiStatistics.FamilyEnum[] IsAfraidOf; // 0x60
	[TooltipAttribute] // RVA: 0xA4CA0 Offset: 0xA40A0 VA: 0x1800A4CA0
	public float MinRoamRange; // 0x68
	[TooltipAttribute] // RVA: 0xA4D70 Offset: 0xA4170 VA: 0x1800A4D70
	public float MaxRoamRange; // 0x6C
	[TooltipAttribute] // RVA: 0xA4F90 Offset: 0xA4390 VA: 0x1800A4F90
	public float MinRoamDelay; // 0x70
	[TooltipAttribute] // RVA: 0xA5050 Offset: 0xA4450 VA: 0x1800A5050
	public float MaxRoamDelay; // 0x74
	[TooltipAttribute] // RVA: 0xA51B0 Offset: 0xA45B0 VA: 0x1800A51B0
	public bool IsMobile; // 0x78
	[TooltipAttribute] // RVA: 0xA5260 Offset: 0xA4660 VA: 0x1800A5260
	public AnimationCurve RoamDelayDistribution; // 0x80
	[TooltipAttribute] // RVA: 0xA53B0 Offset: 0xA47B0 VA: 0x1800A53B0
	public float AttackedMemoryTime; // 0x88
	[TooltipAttribute] // RVA: 0xA5550 Offset: 0xA4950 VA: 0x1800A5550
	public float WakeupBlockMoveTime; // 0x8C
	[TooltipAttribute] // RVA: 0xA5620 Offset: 0xA4A20 VA: 0x1800A5620
	public float MaxWaterDepth; // 0x90
	[TooltipAttribute] // RVA: 0xA56D0 Offset: 0xA4AD0 VA: 0x1800A56D0
	public float WaterLevelNeck; // 0x94
	public float WaterLevelNeckOffset; // 0x98
	[TooltipAttribute] // RVA: 0xA5AA0 Offset: 0xA4EA0 VA: 0x1800A5AA0
	public float CloseRange; // 0x9C
	[TooltipAttribute] // RVA: 0xA5B00 Offset: 0xA4F00 VA: 0x1800A5B00
	public float MediumRange; // 0xA0
	[TooltipAttribute] // RVA: 0xA5BC0 Offset: 0xA4FC0 VA: 0x1800A5BC0
	public float LongRange; // 0xA4
	[TooltipAttribute] // RVA: 0xA5CD0 Offset: 0xA50D0 VA: 0x1800A5CD0
	public float OutOfRangeOfSpawnPointTimeout; // 0xA8
	[TooltipAttribute] // RVA: 0xA5D40 Offset: 0xA5140 VA: 0x1800A5D40
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

