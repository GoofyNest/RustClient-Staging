public class BaseNavigator : BaseMonoBehaviour // TypeDefIndex: 8945
{	[ServerVar] // RVA: 0xC5470 Offset: 0xC4870 VA: 0x1800C5470
	public static float maxStepUpDistance; // 0x0
	[ServerVar] // RVA: 0xC5540 Offset: 0xC4940 VA: 0x1800C5540
	public static int baseNavMovementFrameInterval; // 0x4
	[ServerVar] // RVA: 0xC56D0 Offset: 0xC4AD0 VA: 0x1800C56D0
	public static float stuckTriggerDuration; // 0x8
	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static float navTypeHeightOffset; // 0xC
	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static float navTypeDistance; // 0x10
	[HeaderAttribute] // RVA: 0xC58A0 Offset: 0xC4CA0 VA: 0x1800C58A0
	public bool CanNavigateMounted; // 0x18
	public bool CanUseNavMesh; // 0x19
	public bool CanUseAStar; // 0x1A
	public bool CanUseBaseNav; // 0x1B
	public bool CanUseCustomNav; // 0x1C
	public float StoppingDistance; // 0x20
	public string DefaultArea; // 0x28
	[HeaderAttribute] // RVA: 0xC5A30 Offset: 0xC4E30 VA: 0x1800C5A30
	public bool TriggerStuckEvent; // 0x30
	public float StuckDistance; // 0x34
	[HeaderAttribute] // RVA: 0xC5A60 Offset: 0xC4E60 VA: 0x1800C5A60
	public float Speed; // 0x38
	public float Acceleration; // 0x3C
	public float TurnSpeed; // 0x40
	[HeaderAttribute] // RVA: 0xC5C90 Offset: 0xC5090 VA: 0x1800C5C90
	public float SlowestSpeedFraction; // 0x44
	public float SlowSpeedFraction; // 0x48
	public float NormalSpeedFraction; // 0x4C
	public float FastSpeedFraction; // 0x50
	public float LowHealthSpeedReductionTriggerFraction; // 0x54
	public float LowHealthMaxSpeedFraction; // 0x58
	public float SwimmingSpeedMultiplier; // 0x5C
	[HeaderAttribute] // RVA: 0xC5CF0 Offset: 0xC50F0 VA: 0x1800C5CF0
	public float BestMovementPointMaxDistance; // 0x60
	public float BestCoverPointMaxDistance; // 0x64
	public float BestRoamPointMaxDistance; // 0x68
	public float MaxRoamDistanceFromHome; // 0x6C
	[HeaderAttribute] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public float MaxWaterDepth; // 0x70
	public bool SpeedBasedAvoidancePriority; // 0x74
	private NavMeshPath path; // 0x78
	private NavMeshQueryFilter navMeshQueryFilter; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AIMovePointPath <Path>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BasePath <AStarGraph>k__BackingField; // 0x98
	private int defaultAreaMask; // 0xA0
	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public TerrainBiome.Enum biomePreference; // 0xA4
	public bool UseBiomePreference; // 0xA8
	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public TerrainTopology.Enum topologyPreference; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private NavMeshAgent <Agent>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BaseCombatEntity <BaseEntity>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Vector3 <Destination>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BaseNavigator.NavigationType <CurrentNavigationType>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BaseNavigator.NavigationType <LastUsedNavigationType>k__BackingField; // 0xD0

	public AIMovePointPath Path { get; set; }
	public BasePath AStarGraph { get; set; }
	public NavMeshAgent Agent { get; set; }
	public BaseCombatEntity BaseEntity { get; set; }
	public Vector3 Destination { get; set; }
	public virtual bool IsOnNavMeshLink { get; }
	public bool Moving { get; }
	public BaseNavigator.NavigationType CurrentNavigationType { get; set; }
	public BaseNavigator.NavigationType LastUsedNavigationType { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public AIMovePointPath get_Path() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_Path(AIMovePointPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public BasePath get_AStarGraph() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_AStarGraph(BasePath value) { }

	public int TopologyPreference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public NavMeshAgent get_Agent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Agent(NavMeshAgent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public BaseCombatEntity get_BaseEntity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_BaseEntity(BaseCombatEntity value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Vector3 get_Destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected void set_Destination(Vector3 value) { }

	public virtual bool get_IsOnNavMeshLink() { }

	public bool get_Moving() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public BaseNavigator.NavigationType get_CurrentNavigationType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_CurrentNavigationType(BaseNavigator.NavigationType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public BaseNavigator.NavigationType get_LastUsedNavigationType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_LastUsedNavigationType(BaseNavigator.NavigationType value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum BaseNavigator.NavigationType // TypeDefIndex: 8946
{	public int value__; // 0x0
	public const BaseNavigator.NavigationType None = 0;
	public const BaseNavigator.NavigationType NavMesh = 1;
	public const BaseNavigator.NavigationType AStar = 2;
	public const BaseNavigator.NavigationType Custom = 3;
	public const BaseNavigator.NavigationType Base = 4;

}

public enum BaseNavigator.NavigationSpeed // TypeDefIndex: 8947
{	public int value__; // 0x0
	public const BaseNavigator.NavigationSpeed Slowest = 0;
	public const BaseNavigator.NavigationSpeed Slow = 1;
	public const BaseNavigator.NavigationSpeed Normal = 2;
	public const BaseNavigator.NavigationSpeed Fast = 3;

}

