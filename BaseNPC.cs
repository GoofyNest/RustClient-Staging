public class BaseNPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6295
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int flags; // 0x14

	// Methods

	// RVA: 0x1FFFBE0 Offset: 0x1FFE1E0 VA: 0x181FFFBE0
	public static void ResetToPool(BaseNPC instance) { }

	// RVA: 0x1FFFC60 Offset: 0x1FFE260 VA: 0x181FFFC60
	public void ResetToPool() { }

	// RVA: 0x1FFFAB0 Offset: 0x1FFE0B0 VA: 0x181FFFAB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(BaseNPC instance) { }

	// RVA: 0x1FFF130 Offset: 0x1FFD730 VA: 0x181FFF130
	public BaseNPC Copy() { }

	// RVA: 0x1FFFA30 Offset: 0x1FFE030 VA: 0x181FFFA30
	public static BaseNPC Deserialize(Stream stream) { }

	// RVA: 0x1FFF1A0 Offset: 0x1FFD7A0 VA: 0x181FFF1A0
	public static BaseNPC DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFF440 Offset: 0x1FFDA40 VA: 0x181FFF440
	public static BaseNPC DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFF6D0 Offset: 0x1FFDCD0 VA: 0x181FFF6D0
	public static BaseNPC Deserialize(byte[] buffer) { }

	// RVA: 0x1FFFBA0 Offset: 0x1FFE1A0 VA: 0x181FFFBA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2000130 Offset: 0x1FFE730 VA: 0x182000130 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2000200 Offset: 0x1FFE800 VA: 0x182000200 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseNPC previous) { }

	// RVA: 0x1FFFBC0 Offset: 0x1FFE1C0 VA: 0x181FFFBC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFF7F0 Offset: 0x1FFDDF0 VA: 0x181FFF7F0
	public static BaseNPC Deserialize(byte[] buffer, BaseNPC instance, bool isDelta = False) { }

	// RVA: 0x1FFF8F0 Offset: 0x1FFDEF0 VA: 0x181FFF8F0
	public static BaseNPC Deserialize(Stream stream, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFF220 Offset: 0x1FFD820 VA: 0x181FFF220
	public static BaseNPC DeserializeLengthDelimited(Stream stream, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFF4D0 Offset: 0x1FFDAD0 VA: 0x181FFF4D0
	public static BaseNPC DeserializeLength(Stream stream, int length, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFFCE0 Offset: 0x1FFE2E0 VA: 0x181FFFCE0
	public static void SerializeDelta(Stream stream, BaseNPC instance, BaseNPC previous) { }

	// RVA: 0x2000050 Offset: 0x1FFE650 VA: 0x182000050
	public static void Serialize(Stream stream, BaseNPC instance) { }

	// RVA: 0x2000120 Offset: 0x1FFE720 VA: 0x182000120
	public byte[] ToProtoBytes() { }

	// RVA: 0x2000130 Offset: 0x1FFE730 VA: 0x182000130
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFFEA0 Offset: 0x1FFE4A0 VA: 0x181FFFEA0
	public static byte[] SerializeToBytes(BaseNPC instance) { }

	// RVA: 0x1FFFDF0 Offset: 0x1FFE3F0 VA: 0x181FFFDF0
	public static void SerializeLengthDelimited(Stream stream, BaseNPC instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0xA4FC60 Offset: 0xA4E260 VA: 0x180A4FC60 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA50BD0 Offset: 0xA4F1D0 VA: 0x180A50BD0
	public int TopologyPreference() { }

	// RVA: 0xA4FAC0 Offset: 0xA4E0C0 VA: 0x180A4FAC0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0xA50670 Offset: 0xA4EC70 VA: 0x180A50670 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA4F800 Offset: 0xA4DE00 VA: 0x180A4F800 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA4F990 Offset: 0xA4DF90 VA: 0x180A4F990 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xA4F610 Offset: 0xA4DC10 VA: 0x180A4F610
	public static void ClientCycle(float deltaTime) { }

	// RVA: 0xA4FBB0 Offset: 0xA4E1B0 VA: 0x180A4FBB0 Slot: 89
	public override void MakeVisible() { }

	// RVA: 0xA4F8F0 Offset: 0xA4DEF0 VA: 0x180A4F8F0
	protected void ClientUpdate() { }

	// RVA: 0xA51770 Offset: 0xA4FD70 VA: 0x180A51770
	public static List<BaseNpc> get_VisibleNpcList() { }

	// RVA: 0xA4F4F0 Offset: 0xA4DAF0 VA: 0x180A4F4F0
	public static void ClearVisibility() { }

	// RVA: 0xA50A60 Offset: 0xA4F060 VA: 0x180A50A60
	public static void RegisterForVisibility(BaseNpc npc) { }

	// RVA: 0xA50BE0 Offset: 0xA4F1E0 VA: 0x180A50BE0
	public static void UnregisterFromVisibility(BaseNpc npc) { }

	// RVA: 0xA50B10 Offset: 0xA4F110 VA: 0x180A50B10 Slot: 60
	public override void SetNetworkRotation(Quaternion rot) { }

	// RVA: 0xA4FB50 Offset: 0xA4E150 VA: 0x180A4FB50 Slot: 25
	public override Quaternion GetNetworkRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4FA60 Offset: 0xA4E060 VA: 0x180A4FA60 Slot: 145
	public virtual void Eat(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4F490 Offset: 0xA4DA90 VA: 0x180A4F490 Slot: 146
	public virtual void Attack(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA50B50 Offset: 0xA4F150 VA: 0x180A50B50 Slot: 147
	public virtual void Startled(Vector3 position) { }

	// RVA: 0xA4FBA0 Offset: 0xA4E1A0 VA: 0x180A4FBA0
	public bool HasAiFlag(BaseNpc.AiFlags f) { }

	// RVA: 0xA50AF0 Offset: 0xA4F0F0 VA: 0x180A50AF0
	public void SetAiFlag(BaseNpc.AiFlags f, bool set) { }

	// RVA: 0xA51750 Offset: 0xA4FD50 VA: 0x180A51750
	public bool get_IsSitting() { }

	// RVA: 0xA517F0 Offset: 0xA4FDF0 VA: 0x180A517F0
	public void set_IsSitting(bool value) { }

	// RVA: 0xA51740 Offset: 0xA4FD40 VA: 0x180A51740
	public bool get_IsChasing() { }

	// RVA: 0xA517D0 Offset: 0xA4FDD0 VA: 0x180A517D0
	public void set_IsChasing(bool value) { }

	// RVA: 0xA51760 Offset: 0xA4FD60 VA: 0x180A51760
	public bool get_IsSleeping() { }

	// RVA: 0xA51810 Offset: 0xA4FE10 VA: 0x180A51810
	public void set_IsSleeping(bool value) { }

	// RVA: 0xA51030 Offset: 0xA4F630 VA: 0x180A51030
	public static void UpdateNpcVisibilities() { }

	// RVA: 0xA50BB0 Offset: 0xA4F1B0 VA: 0x180A50BB0
	private float TimeSinceSeen() { }

	// RVA: 0xA50B20 Offset: 0xA4F120 VA: 0x180A50B20
	private void SetNextVisThink(float addTime) { }

	// RVA: 0xA51640 Offset: 0xA4FC40 VA: 0x180A51640
	private bool WantsVisUpdate() { }

	// RVA: 0xA50C70 Offset: 0xA4F270 VA: 0x180A50C70 Slot: 90
	protected override void UpdateCullingSpheres() { }

	// RVA: 0xA51150 Offset: 0xA4F750 VA: 0x180A51150
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0xA50770 Offset: 0xA4ED70 VA: 0x180A50770 Slot: 92
	protected override void OnVisibilityChanged(bool visible) { }

	// RVA: 0xA51250 Offset: 0xA4F850 VA: 0x180A51250
	private void VisUpdate() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x9244A0 Offset: 0x922AA0 VA: 0x1809244A0 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA516C0 Offset: 0xA4FCC0 VA: 0x180A516C0
	public void .ctor() { }

	// RVA: 0xA51660 Offset: 0xA4FC60 VA: 0x180A51660
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

