public class BaseNPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6295
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int flags; // 0x14

	// Methods

	// RVA: 0x2000400 Offset: 0x1FFEA00 VA: 0x182000400
	public static void ResetToPool(BaseNPC instance) { }

	// RVA: 0x2000480 Offset: 0x1FFEA80 VA: 0x182000480
	public void ResetToPool() { }

	// RVA: 0x20002D0 Offset: 0x1FFE8D0 VA: 0x1820002D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(BaseNPC instance) { }

	// RVA: 0x1FFF950 Offset: 0x1FFDF50 VA: 0x181FFF950
	public BaseNPC Copy() { }

	// RVA: 0x2000250 Offset: 0x1FFE850 VA: 0x182000250
	public static BaseNPC Deserialize(Stream stream) { }

	// RVA: 0x1FFF9C0 Offset: 0x1FFDFC0 VA: 0x181FFF9C0
	public static BaseNPC DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFFC60 Offset: 0x1FFE260 VA: 0x181FFFC60
	public static BaseNPC DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFFEF0 Offset: 0x1FFE4F0 VA: 0x181FFFEF0
	public static BaseNPC Deserialize(byte[] buffer) { }

	// RVA: 0x20003C0 Offset: 0x1FFE9C0 VA: 0x1820003C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2000950 Offset: 0x1FFEF50 VA: 0x182000950 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2000A20 Offset: 0x1FFF020 VA: 0x182000A20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseNPC previous) { }

	// RVA: 0x20003E0 Offset: 0x1FFE9E0 VA: 0x1820003E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2000010 Offset: 0x1FFE610 VA: 0x182000010
	public static BaseNPC Deserialize(byte[] buffer, BaseNPC instance, bool isDelta = False) { }

	// RVA: 0x2000110 Offset: 0x1FFE710 VA: 0x182000110
	public static BaseNPC Deserialize(Stream stream, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFFA40 Offset: 0x1FFE040 VA: 0x181FFFA40
	public static BaseNPC DeserializeLengthDelimited(Stream stream, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFFCF0 Offset: 0x1FFE2F0 VA: 0x181FFFCF0
	public static BaseNPC DeserializeLength(Stream stream, int length, BaseNPC instance, bool isDelta) { }

	// RVA: 0x2000500 Offset: 0x1FFEB00 VA: 0x182000500
	public static void SerializeDelta(Stream stream, BaseNPC instance, BaseNPC previous) { }

	// RVA: 0x2000870 Offset: 0x1FFEE70 VA: 0x182000870
	public static void Serialize(Stream stream, BaseNPC instance) { }

	// RVA: 0x2000940 Offset: 0x1FFEF40 VA: 0x182000940
	public byte[] ToProtoBytes() { }

	// RVA: 0x2000950 Offset: 0x1FFEF50 VA: 0x182000950
	public void ToProto(Stream stream) { }

	// RVA: 0x20006C0 Offset: 0x1FFECC0 VA: 0x1820006C0
	public static byte[] SerializeToBytes(BaseNPC instance) { }

	// RVA: 0x2000610 Offset: 0x1FFEC10 VA: 0x182000610
	public static void SerializeLengthDelimited(Stream stream, BaseNPC instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class BaseNpc : BaseCombatEntity // TypeDefIndex: 8525
{	// Fields
	public int agentTypeIndex; // 0x240
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

	// Properties
	public static List<BaseNpc> VisibleNpcList { get; }
	public bool IsSitting { get; set; }
	public bool IsChasing { get; set; }
	public bool IsSleeping { get; set; }
	public override bool IsNpc { get; }

	// Methods

	// RVA: 0xA50130 Offset: 0xA4E730 VA: 0x180A50130 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA510A0 Offset: 0xA4F6A0 VA: 0x180A510A0
	public int TopologyPreference() { }

	// RVA: 0xA4FF90 Offset: 0xA4E590 VA: 0x180A4FF90 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0xA50B40 Offset: 0xA4F140 VA: 0x180A50B40 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA4FCD0 Offset: 0xA4E2D0 VA: 0x180A4FCD0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA4FE60 Offset: 0xA4E460 VA: 0x180A4FE60 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xA4FAE0 Offset: 0xA4E0E0 VA: 0x180A4FAE0
	public static void ClientCycle(float deltaTime) { }

	// RVA: 0xA50080 Offset: 0xA4E680 VA: 0x180A50080 Slot: 89
	public override void MakeVisible() { }

	// RVA: 0xA4FDC0 Offset: 0xA4E3C0 VA: 0x180A4FDC0
	protected void ClientUpdate() { }

	// RVA: 0xA51C40 Offset: 0xA50240 VA: 0x180A51C40
	public static List<BaseNpc> get_VisibleNpcList() { }

	// RVA: 0xA4F9C0 Offset: 0xA4DFC0 VA: 0x180A4F9C0
	public static void ClearVisibility() { }

	// RVA: 0xA50F30 Offset: 0xA4F530 VA: 0x180A50F30
	public static void RegisterForVisibility(BaseNpc npc) { }

	// RVA: 0xA510B0 Offset: 0xA4F6B0 VA: 0x180A510B0
	public static void UnregisterFromVisibility(BaseNpc npc) { }

	// RVA: 0xA50FE0 Offset: 0xA4F5E0 VA: 0x180A50FE0 Slot: 60
	public override void SetNetworkRotation(Quaternion rot) { }

	// RVA: 0xA50020 Offset: 0xA4E620 VA: 0x180A50020 Slot: 25
	public override Quaternion GetNetworkRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4FF30 Offset: 0xA4E530 VA: 0x180A4FF30 Slot: 145
	public virtual void Eat(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4F960 Offset: 0xA4DF60 VA: 0x180A4F960 Slot: 146
	public virtual void Attack(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA51020 Offset: 0xA4F620 VA: 0x180A51020 Slot: 147
	public virtual void Startled(Vector3 position) { }

	// RVA: 0xA50070 Offset: 0xA4E670 VA: 0x180A50070
	public bool HasAiFlag(BaseNpc.AiFlags f) { }

	// RVA: 0xA50FC0 Offset: 0xA4F5C0 VA: 0x180A50FC0
	public void SetAiFlag(BaseNpc.AiFlags f, bool set) { }

	// RVA: 0xA51C20 Offset: 0xA50220 VA: 0x180A51C20
	public bool get_IsSitting() { }

	// RVA: 0xA51CC0 Offset: 0xA502C0 VA: 0x180A51CC0
	public void set_IsSitting(bool value) { }

	// RVA: 0xA51C10 Offset: 0xA50210 VA: 0x180A51C10
	public bool get_IsChasing() { }

	// RVA: 0xA51CA0 Offset: 0xA502A0 VA: 0x180A51CA0
	public void set_IsChasing(bool value) { }

	// RVA: 0xA51C30 Offset: 0xA50230 VA: 0x180A51C30
	public bool get_IsSleeping() { }

	// RVA: 0xA51CE0 Offset: 0xA502E0 VA: 0x180A51CE0
	public void set_IsSleeping(bool value) { }

	// RVA: 0xA51500 Offset: 0xA4FB00 VA: 0x180A51500
	public static void UpdateNpcVisibilities() { }

	// RVA: 0xA51080 Offset: 0xA4F680 VA: 0x180A51080
	private float TimeSinceSeen() { }

	// RVA: 0xA50FF0 Offset: 0xA4F5F0 VA: 0x180A50FF0
	private void SetNextVisThink(float addTime) { }

	// RVA: 0xA51B10 Offset: 0xA50110 VA: 0x180A51B10
	private bool WantsVisUpdate() { }

	// RVA: 0xA51140 Offset: 0xA4F740 VA: 0x180A51140 Slot: 90
	protected override void UpdateCullingSpheres() { }

	// RVA: 0xA51620 Offset: 0xA4FC20 VA: 0x180A51620
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0xA50C40 Offset: 0xA4F240 VA: 0x180A50C40 Slot: 92
	protected override void OnVisibilityChanged(bool visible) { }

	// RVA: 0xA51720 Offset: 0xA4FD20 VA: 0x180A51720
	private void VisUpdate() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x9249B0 Offset: 0x922FB0 VA: 0x1809249B0 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA51B90 Offset: 0xA50190 VA: 0x180A51B90
	public void .ctor() { }

	// RVA: 0xA51B30 Offset: 0xA50130 VA: 0x180A51B30
	private static void .cctor() { }

}

public enum BaseNpc.AiFlags // TypeDefIndex: 8526
{	// Fields
	public int value__; // 0x0
	public const BaseNpc.AiFlags Sitting = 2;
	public const BaseNpc.AiFlags Chasing = 4;
	public const BaseNpc.AiFlags Sleeping = 8;

}

public struct BaseNpc.AiStatistics // TypeDefIndex: 8527
{	// Fields
	[TooltipAttribute] // RVA: 0xA35E0 Offset: 0xA29E0 VA: 0x1800A35E0
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
{	// Fields
	public int value__; // 0x0
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

