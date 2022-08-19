public class BaseNPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6295
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int flags; // 0x14

	// Methods

	// RVA: 0x1FFFAE0 Offset: 0x1FFE0E0 VA: 0x181FFFAE0
	public static void ResetToPool(BaseNPC instance) { }

	// RVA: 0x1FFFB60 Offset: 0x1FFE160 VA: 0x181FFFB60
	public void ResetToPool() { }

	// RVA: 0x1FFF9B0 Offset: 0x1FFDFB0 VA: 0x181FFF9B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(BaseNPC instance) { }

	// RVA: 0x1FFF030 Offset: 0x1FFD630 VA: 0x181FFF030
	public BaseNPC Copy() { }

	// RVA: 0x1FFF930 Offset: 0x1FFDF30 VA: 0x181FFF930
	public static BaseNPC Deserialize(Stream stream) { }

	// RVA: 0x1FFF0A0 Offset: 0x1FFD6A0 VA: 0x181FFF0A0
	public static BaseNPC DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFF340 Offset: 0x1FFD940 VA: 0x181FFF340
	public static BaseNPC DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFF5D0 Offset: 0x1FFDBD0 VA: 0x181FFF5D0
	public static BaseNPC Deserialize(byte[] buffer) { }

	// RVA: 0x1FFFAA0 Offset: 0x1FFE0A0 VA: 0x181FFFAA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2000030 Offset: 0x1FFE630 VA: 0x182000030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2000100 Offset: 0x1FFE700 VA: 0x182000100 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseNPC previous) { }

	// RVA: 0x1FFFAC0 Offset: 0x1FFE0C0 VA: 0x181FFFAC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFF6F0 Offset: 0x1FFDCF0 VA: 0x181FFF6F0
	public static BaseNPC Deserialize(byte[] buffer, BaseNPC instance, bool isDelta = False) { }

	// RVA: 0x1FFF7F0 Offset: 0x1FFDDF0 VA: 0x181FFF7F0
	public static BaseNPC Deserialize(Stream stream, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFF120 Offset: 0x1FFD720 VA: 0x181FFF120
	public static BaseNPC DeserializeLengthDelimited(Stream stream, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFF3D0 Offset: 0x1FFD9D0 VA: 0x181FFF3D0
	public static BaseNPC DeserializeLength(Stream stream, int length, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFFBE0 Offset: 0x1FFE1E0 VA: 0x181FFFBE0
	public static void SerializeDelta(Stream stream, BaseNPC instance, BaseNPC previous) { }

	// RVA: 0x1FFFF50 Offset: 0x1FFE550 VA: 0x181FFFF50
	public static void Serialize(Stream stream, BaseNPC instance) { }

	// RVA: 0x2000020 Offset: 0x1FFE620 VA: 0x182000020
	public byte[] ToProtoBytes() { }

	// RVA: 0x2000030 Offset: 0x1FFE630 VA: 0x182000030
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFFDA0 Offset: 0x1FFE3A0 VA: 0x181FFFDA0
	public static byte[] SerializeToBytes(BaseNPC instance) { }

	// RVA: 0x1FFFCF0 Offset: 0x1FFE2F0 VA: 0x181FFFCF0
	public static void SerializeLengthDelimited(Stream stream, BaseNPC instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class BaseNpc : BaseCombatEntity // TypeDefIndex: 8525
{	// Fields
	public int agentTypeIndex; // 0x240
	public bool NewAI; // 0x244
	[SerializeField] // RVA: 0x93470 Offset: 0x92870 VA: 0x180093470
	[InspectorFlagsAttribute] // RVA: 0x93470 Offset: 0x92870 VA: 0x180093470
	public TerrainTopology.Enum topologyPreference; // 0x248
	public Quaternion NetworkRotation; // 0x24C
	private static List<BaseNpc> visibleNpcList; // 0x0
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public BaseNpc.AiFlags aiFlags; // 0x25C
	[HeaderAttribute] // RVA: 0xA2ED0 Offset: 0xA22D0 VA: 0x1800A2ED0
	public int ForgetUnseenEntityTime; // 0x260
	public float SensesTickRate; // 0x264
	private float nextVisThink; // 0x268
	private float lastTimeSeen; // 0x26C
	private Vector3 lastPosition; // 0x270
	[HeaderAttribute] // RVA: 0xA2F90 Offset: 0xA2390 VA: 0x1800A2F90
	public GameObjectRef CorpsePrefab; // 0x280
	public BaseNpc.AiStatistics Stats; // 0x288
	public Vector3 AttackOffset; // 0x338
	public float AttackDamage; // 0x344
	public DamageType AttackDamageType; // 0x348
	[TooltipAttribute] // RVA: 0xA3010 Offset: 0xA2410 VA: 0x1800A3010
	public float AttackCost; // 0x34C
	[TooltipAttribute] // RVA: 0xA3190 Offset: 0xA2590 VA: 0x1800A3190
	public float AttackRate; // 0x350
	[TooltipAttribute] // RVA: 0xA32B0 Offset: 0xA26B0 VA: 0x1800A32B0
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

	// RVA: 0xA4F9A0 Offset: 0xA4DFA0 VA: 0x180A4F9A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA50910 Offset: 0xA4EF10 VA: 0x180A50910
	public int TopologyPreference() { }

	// RVA: 0xA4F800 Offset: 0xA4DE00 VA: 0x180A4F800 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0xA503B0 Offset: 0xA4E9B0 VA: 0x180A503B0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA4F540 Offset: 0xA4DB40 VA: 0x180A4F540 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA4F6D0 Offset: 0xA4DCD0 VA: 0x180A4F6D0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xA4F350 Offset: 0xA4D950 VA: 0x180A4F350
	public static void ClientCycle(float deltaTime) { }

	// RVA: 0xA4F8F0 Offset: 0xA4DEF0 VA: 0x180A4F8F0 Slot: 89
	public override void MakeVisible() { }

	// RVA: 0xA4F630 Offset: 0xA4DC30 VA: 0x180A4F630
	protected void ClientUpdate() { }

	// RVA: 0xA514B0 Offset: 0xA4FAB0 VA: 0x180A514B0
	public static List<BaseNpc> get_VisibleNpcList() { }

	// RVA: 0xA4F230 Offset: 0xA4D830 VA: 0x180A4F230
	public static void ClearVisibility() { }

	// RVA: 0xA507A0 Offset: 0xA4EDA0 VA: 0x180A507A0
	public static void RegisterForVisibility(BaseNpc npc) { }

	// RVA: 0xA50920 Offset: 0xA4EF20 VA: 0x180A50920
	public static void UnregisterFromVisibility(BaseNpc npc) { }

	// RVA: 0xA50850 Offset: 0xA4EE50 VA: 0x180A50850 Slot: 60
	public override void SetNetworkRotation(Quaternion rot) { }

	// RVA: 0xA4F890 Offset: 0xA4DE90 VA: 0x180A4F890 Slot: 25
	public override Quaternion GetNetworkRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA4F7A0 Offset: 0xA4DDA0 VA: 0x180A4F7A0 Slot: 145
	public virtual void Eat(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA4F1D0 Offset: 0xA4D7D0 VA: 0x180A4F1D0 Slot: 146
	public virtual void Attack(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA50890 Offset: 0xA4EE90 VA: 0x180A50890 Slot: 147
	public virtual void Startled(Vector3 position) { }

	// RVA: 0xA4F8E0 Offset: 0xA4DEE0 VA: 0x180A4F8E0
	public bool HasAiFlag(BaseNpc.AiFlags f) { }

	// RVA: 0xA50830 Offset: 0xA4EE30 VA: 0x180A50830
	public void SetAiFlag(BaseNpc.AiFlags f, bool set) { }

	// RVA: 0xA51490 Offset: 0xA4FA90 VA: 0x180A51490
	public bool get_IsSitting() { }

	// RVA: 0xA51530 Offset: 0xA4FB30 VA: 0x180A51530
	public void set_IsSitting(bool value) { }

	// RVA: 0xA51480 Offset: 0xA4FA80 VA: 0x180A51480
	public bool get_IsChasing() { }

	// RVA: 0xA51510 Offset: 0xA4FB10 VA: 0x180A51510
	public void set_IsChasing(bool value) { }

	// RVA: 0xA514A0 Offset: 0xA4FAA0 VA: 0x180A514A0
	public bool get_IsSleeping() { }

	// RVA: 0xA51550 Offset: 0xA4FB50 VA: 0x180A51550
	public void set_IsSleeping(bool value) { }

	// RVA: 0xA50D70 Offset: 0xA4F370 VA: 0x180A50D70
	public static void UpdateNpcVisibilities() { }

	// RVA: 0xA508F0 Offset: 0xA4EEF0 VA: 0x180A508F0
	private float TimeSinceSeen() { }

	// RVA: 0xA50860 Offset: 0xA4EE60 VA: 0x180A50860
	private void SetNextVisThink(float addTime) { }

	// RVA: 0xA51380 Offset: 0xA4F980 VA: 0x180A51380
	private bool WantsVisUpdate() { }

	// RVA: 0xA509B0 Offset: 0xA4EFB0 VA: 0x180A509B0 Slot: 90
	protected override void UpdateCullingSpheres() { }

	// RVA: 0xA50E90 Offset: 0xA4F490 VA: 0x180A50E90
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0xA504B0 Offset: 0xA4EAB0 VA: 0x180A504B0 Slot: 92
	protected override void OnVisibilityChanged(bool visible) { }

	// RVA: 0xA50F90 Offset: 0xA4F590 VA: 0x180A50F90
	private void VisUpdate() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x924390 Offset: 0x922990 VA: 0x180924390 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA51400 Offset: 0xA4FA00 VA: 0x180A51400
	public void .ctor() { }

	// RVA: 0xA513A0 Offset: 0xA4F9A0 VA: 0x180A513A0
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
	[TooltipAttribute] // RVA: 0xA3550 Offset: 0xA2950 VA: 0x1800A3550
	[RangeAttribute] // RVA: 0xA3550 Offset: 0xA2950 VA: 0x1800A3550
	public float Size; // 0x0
	[TooltipAttribute] // RVA: 0xA3620 Offset: 0xA2A20 VA: 0x1800A3620
	public float Speed; // 0x4
	[TooltipAttribute] // RVA: 0xA36A0 Offset: 0xA2AA0 VA: 0x1800A36A0
	public float Acceleration; // 0x8
	[TooltipAttribute] // RVA: 0xA3750 Offset: 0xA2B50 VA: 0x1800A3750
	public float TurnSpeed; // 0xC
	[TooltipAttribute] // RVA: 0xA3800 Offset: 0xA2C00 VA: 0x1800A3800
	[RangeAttribute] // RVA: 0xA3800 Offset: 0xA2C00 VA: 0x1800A3800
	public float Tolerance; // 0x10
	[TooltipAttribute] // RVA: 0xA3930 Offset: 0xA2D30 VA: 0x1800A3930
	public float VisionRange; // 0x14
	[TooltipAttribute] // RVA: 0xA39D0 Offset: 0xA2DD0 VA: 0x1800A39D0
	public float VisionCone; // 0x18
	[TooltipAttribute] // RVA: 0xA3AD0 Offset: 0xA2ED0 VA: 0x1800A3AD0
	public AnimationCurve DistanceVisibility; // 0x20
	[TooltipAttribute] // RVA: 0xA3B70 Offset: 0xA2F70 VA: 0x1800A3B70
	public float Hostility; // 0x28
	[TooltipAttribute] // RVA: 0xA3CC0 Offset: 0xA30C0 VA: 0x1800A3CC0
	public float Defensiveness; // 0x2C
	[TooltipAttribute] // RVA: 0xA3DD0 Offset: 0xA31D0 VA: 0x1800A3DD0
	public float AggressionRange; // 0x30
	[TooltipAttribute] // RVA: 0xA3E60 Offset: 0xA3260 VA: 0x1800A3E60
	public float DeaggroRange; // 0x34
	[TooltipAttribute] // RVA: 0xA3FD0 Offset: 0xA33D0 VA: 0x1800A3FD0
	public float DeaggroChaseTime; // 0x38
	[TooltipAttribute] // RVA: 0xA4130 Offset: 0xA3530 VA: 0x1800A4130
	public float DeaggroCooldown; // 0x3C
	[TooltipAttribute] // RVA: 0xA4200 Offset: 0xA3600 VA: 0x1800A4200
	public float HealthThresholdForFleeing; // 0x40
	[TooltipAttribute] // RVA: 0xA4400 Offset: 0xA3800 VA: 0x1800A4400
	public float HealthThresholdFleeChance; // 0x44
	[TooltipAttribute] // RVA: 0xA45C0 Offset: 0xA39C0 VA: 0x1800A45C0
	public float MinFleeRange; // 0x48
	[TooltipAttribute] // RVA: 0xA46D0 Offset: 0xA3AD0 VA: 0x1800A46D0
	public float MaxFleeRange; // 0x4C
	[TooltipAttribute] // RVA: 0xA4860 Offset: 0xA3C60 VA: 0x1800A4860
	public float MaxFleeTime; // 0x50
	[TooltipAttribute] // RVA: 0xA48C0 Offset: 0xA3CC0 VA: 0x1800A48C0
	public float AfraidRange; // 0x54
	[TooltipAttribute] // RVA: 0xA49D0 Offset: 0xA3DD0 VA: 0x1800A49D0
	public BaseNpc.AiStatistics.FamilyEnum Family; // 0x58
	[TooltipAttribute] // RVA: 0xA4BE0 Offset: 0xA3FE0 VA: 0x1800A4BE0
	public BaseNpc.AiStatistics.FamilyEnum[] IsAfraidOf; // 0x60
	[TooltipAttribute] // RVA: 0xA4C10 Offset: 0xA4010 VA: 0x1800A4C10
	public float MinRoamRange; // 0x68
	[TooltipAttribute] // RVA: 0xA4CE0 Offset: 0xA40E0 VA: 0x1800A4CE0
	public float MaxRoamRange; // 0x6C
	[TooltipAttribute] // RVA: 0xA4F00 Offset: 0xA4300 VA: 0x1800A4F00
	public float MinRoamDelay; // 0x70
	[TooltipAttribute] // RVA: 0xA4FA0 Offset: 0xA43A0 VA: 0x1800A4FA0
	public float MaxRoamDelay; // 0x74
	[TooltipAttribute] // RVA: 0xA5120 Offset: 0xA4520 VA: 0x1800A5120
	public bool IsMobile; // 0x78
	[TooltipAttribute] // RVA: 0xA5200 Offset: 0xA4600 VA: 0x1800A5200
	public AnimationCurve RoamDelayDistribution; // 0x80
	[TooltipAttribute] // RVA: 0xA5320 Offset: 0xA4720 VA: 0x1800A5320
	public float AttackedMemoryTime; // 0x88
	[TooltipAttribute] // RVA: 0xA54C0 Offset: 0xA48C0 VA: 0x1800A54C0
	public float WakeupBlockMoveTime; // 0x8C
	[TooltipAttribute] // RVA: 0xA5590 Offset: 0xA4990 VA: 0x1800A5590
	public float MaxWaterDepth; // 0x90
	[TooltipAttribute] // RVA: 0xA55F0 Offset: 0xA49F0 VA: 0x1800A55F0
	public float WaterLevelNeck; // 0x94
	public float WaterLevelNeckOffset; // 0x98
	[TooltipAttribute] // RVA: 0xA59C0 Offset: 0xA4DC0 VA: 0x1800A59C0
	public float CloseRange; // 0x9C
	[TooltipAttribute] // RVA: 0xA5A70 Offset: 0xA4E70 VA: 0x1800A5A70
	public float MediumRange; // 0xA0
	[TooltipAttribute] // RVA: 0xA5B30 Offset: 0xA4F30 VA: 0x1800A5B30
	public float LongRange; // 0xA4
	[TooltipAttribute] // RVA: 0xA5C40 Offset: 0xA5040 VA: 0x1800A5C40
	public float OutOfRangeOfSpawnPointTimeout; // 0xA8
	[TooltipAttribute] // RVA: 0xA5CB0 Offset: 0xA50B0 VA: 0x1800A5CB0
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

