public class BaseAIBrain : EntityComponent<BaseEntity>, IPet, IAISleepable, IAIDesign, IAIGroupable, IAIEventListener // TypeDefIndex: 8490
{	public bool UseQueuedMovementUpdates; // 0x20
	public bool AllowedToSleep; // 0x21
	public AIDesignSO DefaultDesignSO; // 0x28
	public List<AIDesignSO> Designs; // 0x30
	public AIDesign InstanceSpecificDesign; // 0x38
	public float SenseRange; // 0x40
	public float AttackRangeMultiplier; // 0x44
	public float TargetLostRange; // 0x48
	public float VisionCone; // 0x4C
	public bool CheckVisionCone; // 0x50
	public bool CheckLOS; // 0x51
	public bool IgnoreNonVisionSneakers; // 0x52
	public float ListenRange; // 0x54
	public EntityType SenseTypes; // 0x58
	public bool HostileTargetsOnly; // 0x5C
	public bool IgnoreSafeZonePlayers; // 0x5D
	public int MaxGroupSize; // 0x60
	public float MemoryDuration; // 0x64
	public bool RefreshKnownLOS; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BaseAIBrain.BasicAIState <CurrentState>k__BackingField; // 0x70
	public Vector3 mainInterestPoint; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AIThinkMode <ThinkMode>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <Age>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AIBrainSenses <Senses>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BasePathFinder <PathFinder>k__BackingField; // 0x98
	public bool UseAIDesign; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AIEvents <Events>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AIDesign <AIDesign>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BasePlayer <DesigningPlayer>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BasePlayer <OwningPlayer>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <IsGroupLeader>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <IsGrouped>k__BackingField; // 0xC9
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private IAIGroupable <GroupLeader>k__BackingField; // 0xD0
	public bool Pet; // 0xD8
	private List<IAIGroupable> groupMembers; // 0xE0
	[HeaderAttribute] // RVA: 0x9E740 Offset: 0x9DB40 VA: 0x18009E740
	public bool CanUseHealingItems; // 0xE8
	public float HealChance; // 0xEC
	public float HealBelowHealthFraction; // 0xF0

	public BaseAIBrain.BasicAIState CurrentState { get; set; }
	public AIThinkMode ThinkMode { get; set; }
	public float Age { get; set; }
	public AIBrainSenses Senses { get; set; }
	public BasePathFinder PathFinder { get; set; }
	public AIEvents Events { get; set; }
	public AIDesign AIDesign { get; set; }
	public BasePlayer DesigningPlayer { get; set; }
	public BasePlayer OwningPlayer { get; set; }
	public bool IsGroupLeader { get; set; }
	public bool IsGrouped { get; set; }
	public IAIGroupable GroupLeader { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPet() { }

	public void SetPetOwner(BasePlayer player) { }

	public bool IsOwnedBy(BasePlayer player) { }

	public bool IssuePetCommand(PetCommandType cmd, int param, Nullable<Ray> ray) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public BaseAIBrain.BasicAIState get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_CurrentState(BaseAIBrain.BasicAIState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public AIThinkMode get_ThinkMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected void set_ThinkMode(AIThinkMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_Age() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Age(float value) { }

	public void ForceSetAge(float age) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public AIBrainSenses get_Senses() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Senses(AIBrainSenses value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public BasePathFinder get_PathFinder() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected void set_PathFinder(BasePathFinder value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public AIEvents get_Events() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Events(AIEvents value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public AIDesign get_AIDesign() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_AIDesign(AIDesign value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public BasePlayer get_DesigningPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_DesigningPlayer(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public BasePlayer get_OwningPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_OwningPlayer(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_IsGroupLeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_IsGroupLeader(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_IsGrouped() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_IsGrouped(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public IAIGroupable get_GroupLeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_GroupLeader(IAIGroupable value) { }

	private bool IAIDesign.CanPlayerDesignAI(BasePlayer player) { }

	private bool PlayerCanDesignAI(BasePlayer player) { }

	public void EventTriggeredStateChange(int newStateContainerID, int sourceEventID) { }

	public void .ctor() { }

}

public class BaseAIBrain.BasicAIState // TypeDefIndex: 8491
{
	public void .ctor() { }

}

