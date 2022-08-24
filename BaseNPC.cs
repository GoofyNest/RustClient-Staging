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
	[SerializeField] // RVA: 0x934E0 Offset: 0x928E0 VA: 0x1800934E0
	[InspectorFlagsAttribute] // RVA: 0x934E0 Offset: 0x928E0 VA: 0x1800934E0
	public TerrainTopology.Enum topologyPreference; // 0x248
	public Quaternion NetworkRotation; // 0x24C
	private static List<BaseNpc> visibleNpcList; // 0x0
	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public BaseNpc.AiFlags aiFlags; // 0x25C
	[HeaderAttribute] // RVA: 0xA3070 Offset: 0xA2470 VA: 0x1800A3070
	public int ForgetUnseenEntityTime; // 0x260
	public float SensesTickRate; // 0x264
	private float nextVisThink; // 0x268
	private float lastTimeSeen; // 0x26C
	private Vector3 lastPosition; // 0x270
	[HeaderAttribute] // RVA: 0xA30F0 Offset: 0xA24F0 VA: 0x1800A30F0
	public GameObjectRef CorpsePrefab; // 0x280
	public BaseNpc.AiStatistics Stats; // 0x288
	public Vector3 AttackOffset; // 0x338
	public float AttackDamage; // 0x344
	public DamageType AttackDamageType; // 0x348
	[TooltipAttribute] // RVA: 0xA3170 Offset: 0xA2570 VA: 0x1800A3170
	public float AttackCost; // 0x34C
	[TooltipAttribute] // RVA: 0xA32A0 Offset: 0xA26A0 VA: 0x1800A32A0
	public float AttackRate; // 0x350
	[TooltipAttribute] // RVA: 0xA3370 Offset: 0xA2770 VA: 0x1800A3370
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
{	[TooltipAttribute] // RVA: 0xA3610 Offset: 0xA2A10 VA: 0x1800A3610
	[RangeAttribute] // RVA: 0xA3610 Offset: 0xA2A10 VA: 0x1800A3610
	public float Size; // 0x0
	[TooltipAttribute] // RVA: 0xA3760 Offset: 0xA2B60 VA: 0x1800A3760
	public float Speed; // 0x4
	[TooltipAttribute] // RVA: 0xA3840 Offset: 0xA2C40 VA: 0x1800A3840
	public float Acceleration; // 0x8
	[TooltipAttribute] // RVA: 0xA3910 Offset: 0xA2D10 VA: 0x1800A3910
	public float TurnSpeed; // 0xC
	[TooltipAttribute] // RVA: 0xA3A60 Offset: 0xA2E60 VA: 0x1800A3A60
	[RangeAttribute] // RVA: 0xA3A60 Offset: 0xA2E60 VA: 0x1800A3A60
	public float Tolerance; // 0x10
	[TooltipAttribute] // RVA: 0xA3BF0 Offset: 0xA2FF0 VA: 0x1800A3BF0
	public float VisionRange; // 0x14
	[TooltipAttribute] // RVA: 0xA3CC0 Offset: 0xA30C0 VA: 0x1800A3CC0
	public float VisionCone; // 0x18
	[TooltipAttribute] // RVA: 0xA3E10 Offset: 0xA3210 VA: 0x1800A3E10
	public AnimationCurve DistanceVisibility; // 0x20
	[TooltipAttribute] // RVA: 0xA3E40 Offset: 0xA3240 VA: 0x1800A3E40
	public float Hostility; // 0x28
	[TooltipAttribute] // RVA: 0xA3F60 Offset: 0xA3360 VA: 0x1800A3F60
	public float Defensiveness; // 0x2C
	[TooltipAttribute] // RVA: 0xA4090 Offset: 0xA3490 VA: 0x1800A4090
	public float AggressionRange; // 0x30
	[TooltipAttribute] // RVA: 0xA4180 Offset: 0xA3580 VA: 0x1800A4180
	public float DeaggroRange; // 0x34
	[TooltipAttribute] // RVA: 0xA42D0 Offset: 0xA36D0 VA: 0x1800A42D0
	public float DeaggroChaseTime; // 0x38
	[TooltipAttribute] // RVA: 0xA4410 Offset: 0xA3810 VA: 0x1800A4410
	public float DeaggroCooldown; // 0x3C
	[TooltipAttribute] // RVA: 0xA44D0 Offset: 0xA38D0 VA: 0x1800A44D0
	public float HealthThresholdForFleeing; // 0x40
	[TooltipAttribute] // RVA: 0xA4610 Offset: 0xA3A10 VA: 0x1800A4610
	public float HealthThresholdFleeChance; // 0x44
	[TooltipAttribute] // RVA: 0xA4770 Offset: 0xA3B70 VA: 0x1800A4770
	public float MinFleeRange; // 0x48
	[TooltipAttribute] // RVA: 0xA4810 Offset: 0xA3C10 VA: 0x1800A4810
	public float MaxFleeRange; // 0x4C
	[TooltipAttribute] // RVA: 0xA49A0 Offset: 0xA3DA0 VA: 0x1800A49A0
	public float MaxFleeTime; // 0x50
	[TooltipAttribute] // RVA: 0xA4A50 Offset: 0xA3E50 VA: 0x1800A4A50
	public float AfraidRange; // 0x54
	[TooltipAttribute] // RVA: 0xA4B20 Offset: 0xA3F20 VA: 0x1800A4B20
	public BaseNpc.AiStatistics.FamilyEnum Family; // 0x58
	[TooltipAttribute] // RVA: 0xA4D30 Offset: 0xA4130 VA: 0x1800A4D30
	public BaseNpc.AiStatistics.FamilyEnum[] IsAfraidOf; // 0x60
	[TooltipAttribute] // RVA: 0xA4D90 Offset: 0xA4190 VA: 0x1800A4D90
	public float MinRoamRange; // 0x68
	[TooltipAttribute] // RVA: 0xA4EC0 Offset: 0xA42C0 VA: 0x1800A4EC0
	public float MaxRoamRange; // 0x6C
	[TooltipAttribute] // RVA: 0xA5120 Offset: 0xA4520 VA: 0x1800A5120
	public float MinRoamDelay; // 0x70
	[TooltipAttribute] // RVA: 0xA51D0 Offset: 0xA45D0 VA: 0x1800A51D0
	public float MaxRoamDelay; // 0x74
	[TooltipAttribute] // RVA: 0xA5310 Offset: 0xA4710 VA: 0x1800A5310
	public bool IsMobile; // 0x78
	[TooltipAttribute] // RVA: 0xA53C0 Offset: 0xA47C0 VA: 0x1800A53C0
	public AnimationCurve RoamDelayDistribution; // 0x80
	[TooltipAttribute] // RVA: 0xA54B0 Offset: 0xA48B0 VA: 0x1800A54B0
	public float AttackedMemoryTime; // 0x88
	[TooltipAttribute] // RVA: 0xA5610 Offset: 0xA4A10 VA: 0x1800A5610
	public float WakeupBlockMoveTime; // 0x8C
	[TooltipAttribute] // RVA: 0xA5670 Offset: 0xA4A70 VA: 0x1800A5670
	public float MaxWaterDepth; // 0x90
	[TooltipAttribute] // RVA: 0xA56F0 Offset: 0xA4AF0 VA: 0x1800A56F0
	public float WaterLevelNeck; // 0x94
	public float WaterLevelNeckOffset; // 0x98
	[TooltipAttribute] // RVA: 0xA5A90 Offset: 0xA4E90 VA: 0x1800A5A90
	public float CloseRange; // 0x9C
	[TooltipAttribute] // RVA: 0xA5B20 Offset: 0xA4F20 VA: 0x1800A5B20
	public float MediumRange; // 0xA0
	[TooltipAttribute] // RVA: 0xA5C10 Offset: 0xA5010 VA: 0x1800A5C10
	public float LongRange; // 0xA4
	[TooltipAttribute] // RVA: 0xA5D20 Offset: 0xA5120 VA: 0x1800A5D20
	public float OutOfRangeOfSpawnPointTimeout; // 0xA8
	[TooltipAttribute] // RVA: 0xA5D90 Offset: 0xA5190 VA: 0x1800A5D90
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

