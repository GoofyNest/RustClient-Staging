public class BaseNavigator : BaseMonoBehaviour // TypeDefIndex: 8945
{	// Fields
	[ServerVar] // RVA: 0xC5360 Offset: 0xC4760 VA: 0x1800C5360
	public static float maxStepUpDistance; // 0x0
	[ServerVar] // RVA: 0xC5420 Offset: 0xC4820 VA: 0x1800C5420
	public static int baseNavMovementFrameInterval; // 0x4
	[ServerVar] // RVA: 0xC55C0 Offset: 0xC49C0 VA: 0x1800C55C0
	public static float stuckTriggerDuration; // 0x8
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float navTypeHeightOffset; // 0xC
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float navTypeDistance; // 0x10
	[HeaderAttribute] // RVA: 0xC5760 Offset: 0xC4B60 VA: 0x1800C5760
	public bool CanNavigateMounted; // 0x18
	public bool CanUseNavMesh; // 0x19
	public bool CanUseAStar; // 0x1A
	public bool CanUseBaseNav; // 0x1B
	public bool CanUseCustomNav; // 0x1C
	public float StoppingDistance; // 0x20
	public string DefaultArea; // 0x28
	[HeaderAttribute] // RVA: 0xC58F0 Offset: 0xC4CF0 VA: 0x1800C58F0
	public bool TriggerStuckEvent; // 0x30
	public float StuckDistance; // 0x34
	[HeaderAttribute] // RVA: 0xC5950 Offset: 0xC4D50 VA: 0x1800C5950
	public float Speed; // 0x38
	public float Acceleration; // 0x3C
	public float TurnSpeed; // 0x40
	[HeaderAttribute] // RVA: 0xC5B80 Offset: 0xC4F80 VA: 0x1800C5B80
	public float SlowestSpeedFraction; // 0x44
	public float SlowSpeedFraction; // 0x48
	public float NormalSpeedFraction; // 0x4C
	public float FastSpeedFraction; // 0x50
	public float LowHealthSpeedReductionTriggerFraction; // 0x54
	public float LowHealthMaxSpeedFraction; // 0x58
	public float SwimmingSpeedMultiplier; // 0x5C
	[HeaderAttribute] // RVA: 0xC5BB0 Offset: 0xC4FB0 VA: 0x1800C5BB0
	public float BestMovementPointMaxDistance; // 0x60
	public float BestCoverPointMaxDistance; // 0x64
	public float BestRoamPointMaxDistance; // 0x68
	public float MaxRoamDistanceFromHome; // 0x6C
	[HeaderAttribute] // RVA: 0x71EA0 Offset: 0x712A0 VA: 0x180071EA0
	public float MaxWaterDepth; // 0x70
	public bool SpeedBasedAvoidancePriority; // 0x74
	private NavMeshPath path; // 0x78
	private NavMeshQueryFilter navMeshQueryFilter; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AIMovePointPath <Path>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BasePath <AStarGraph>k__BackingField; // 0x98
	private int defaultAreaMask; // 0xA0
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainBiome.Enum biomePreference; // 0xA4
	public bool UseBiomePreference; // 0xA8
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum topologyPreference; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private NavMeshAgent <Agent>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseCombatEntity <BaseEntity>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <Destination>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseNavigator.NavigationType <CurrentNavigationType>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseNavigator.NavigationType <LastUsedNavigationType>k__BackingField; // 0xD0

	// Properties
	public AIMovePointPath Path { get; set; }
	public BasePath AStarGraph { get; set; }
	public NavMeshAgent Agent { get; set; }
	public BaseCombatEntity BaseEntity { get; set; }
	public Vector3 Destination { get; set; }
	public virtual bool IsOnNavMeshLink { get; }
	public bool Moving { get; }
	public BaseNavigator.NavigationType CurrentNavigationType { get; set; }
	public BaseNavigator.NavigationType LastUsedNavigationType { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public AIMovePointPath get_Path() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	public void set_Path(AIMovePointPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public BasePath get_AStarGraph() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	public void set_AStarGraph(BasePath value) { }

	// RVA: 0xA4D2E0 Offset: 0xA4B8E0 VA: 0x180A4D2E0
	public int TopologyPreference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0
	public NavMeshAgent get_Agent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D4E0 Offset: 0xA4BAE0 VA: 0x180A4D4E0
	private void set_Agent(NavMeshAgent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	public BaseCombatEntity get_BaseEntity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D4F0 Offset: 0xA4BAF0 VA: 0x180A4D4F0
	private void set_BaseEntity(BaseCombatEntity value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D460 Offset: 0xA4BA60 VA: 0x180A4D460
	public Vector3 get_Destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D510 Offset: 0xA4BB10 VA: 0x180A4D510
	protected void set_Destination(Vector3 value) { }

	// RVA: 0xA4D480 Offset: 0xA4BA80 VA: 0x180A4D480 Slot: 6
	public virtual bool get_IsOnNavMeshLink() { }

	// RVA: 0xA4D4D0 Offset: 0xA4BAD0 VA: 0x180A4D4D0
	public bool get_Moving() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D450 Offset: 0xA4BA50 VA: 0x180A4D450
	public BaseNavigator.NavigationType get_CurrentNavigationType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D500 Offset: 0xA4BB00 VA: 0x180A4D500
	private void set_CurrentNavigationType(BaseNavigator.NavigationType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x887A60 Offset: 0x886060 VA: 0x180887A60
	public BaseNavigator.NavigationType get_LastUsedNavigationType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7426F0 Offset: 0x740CF0 VA: 0x1807426F0
	private void set_LastUsedNavigationType(BaseNavigator.NavigationType value) { }

	// RVA: 0xA4D380 Offset: 0xA4B980 VA: 0x180A4D380
	public void .ctor() { }

	// RVA: 0xA4D2F0 Offset: 0xA4B8F0 VA: 0x180A4D2F0
	private static void .cctor() { }

}

public enum BaseNavigator.NavigationType // TypeDefIndex: 8946
{	// Fields
	public int value__; // 0x0
	public const BaseNavigator.NavigationType None = 0;
	public const BaseNavigator.NavigationType NavMesh = 1;
	public const BaseNavigator.NavigationType AStar = 2;
	public const BaseNavigator.NavigationType Custom = 3;
	public const BaseNavigator.NavigationType Base = 4;

}

public enum BaseNavigator.NavigationSpeed // TypeDefIndex: 8947
{	// Fields
	public int value__; // 0x0
	public const BaseNavigator.NavigationSpeed Slowest = 0;
	public const BaseNavigator.NavigationSpeed Slow = 1;
	public const BaseNavigator.NavigationSpeed Normal = 2;
	public const BaseNavigator.NavigationSpeed Fast = 3;

}

