public class BaseAIBrain : EntityComponent<BaseEntity>, IPet, IAISleepable, IAIDesign, IAIGroupable, IAIEventListener // TypeDefIndex: 8490
{	// Fields
	public bool UseQueuedMovementUpdates; // 0x20
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseAIBrain.BasicAIState <CurrentState>k__BackingField; // 0x70
	public Vector3 mainInterestPoint; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AIThinkMode <ThinkMode>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Age>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AIBrainSenses <Senses>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BasePathFinder <PathFinder>k__BackingField; // 0x98
	public bool UseAIDesign; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AIEvents <Events>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AIDesign <AIDesign>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BasePlayer <DesigningPlayer>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BasePlayer <OwningPlayer>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsGroupLeader>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsGrouped>k__BackingField; // 0xC9
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IAIGroupable <GroupLeader>k__BackingField; // 0xD0
	public bool Pet; // 0xD8
	private List<IAIGroupable> groupMembers; // 0xE0
	[HeaderAttribute] // RVA: 0x9E690 Offset: 0x9DA90 VA: 0x18009E690
	public bool CanUseHealingItems; // 0xE8
	public float HealChance; // 0xEC
	public float HealBelowHealthFraction; // 0xF0

	// Properties
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

	// Methods

	// RVA: 0x79BA70 Offset: 0x79A070 VA: 0x18079BA70 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x79BA60 Offset: 0x79A060 VA: 0x18079BA60 Slot: 10
	public bool IsPet() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public void SetPetOwner(BasePlayer player) { }

	// RVA: 0x79B970 Offset: 0x799F70 VA: 0x18079B970 Slot: 12
	public bool IsOwnedBy(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public bool IssuePetCommand(PetCommandType cmd, int param, Nullable<Ray> ray) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public BaseAIBrain.BasicAIState get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	private void set_CurrentState(BaseAIBrain.BasicAIState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE30 Offset: 0x79A430 VA: 0x18079BE30
	public AIThinkMode get_ThinkMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BEB0 Offset: 0x79A4B0 VA: 0x18079BEB0
	protected void set_ThinkMode(AIThinkMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDC0 Offset: 0x79A3C0 VA: 0x18079BDC0
	public float get_Age() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79B830 Offset: 0x799E30 VA: 0x18079B830
	private void set_Age(float value) { }

	// RVA: 0x79B830 Offset: 0x799E30 VA: 0x18079B830
	public void ForceSetAge(float age) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public AIBrainSenses get_Senses() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	private void set_Senses(AIBrainSenses value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public BasePathFinder get_PathFinder() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	protected void set_PathFinder(BasePathFinder value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public AIEvents get_Events() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE60 Offset: 0x79A460 VA: 0x18079BE60
	private void set_Events(AIEvents value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	public AIDesign get_AIDesign() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE40 Offset: 0x79A440 VA: 0x18079BE40
	private void set_AIDesign(AIDesign value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public BasePlayer get_DesigningPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	private void set_DesigningPlayer(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public BasePlayer get_OwningPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BEA0 Offset: 0x79A4A0 VA: 0x18079BEA0
	private void set_OwningPlayer(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE00 Offset: 0x79A400 VA: 0x18079BE00
	public bool get_IsGroupLeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE80 Offset: 0x79A480 VA: 0x18079BE80
	private void set_IsGroupLeader(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE10 Offset: 0x79A410 VA: 0x18079BE10
	public bool get_IsGrouped() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE90 Offset: 0x79A490 VA: 0x18079BE90
	private void set_IsGrouped(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	public IAIGroupable get_GroupLeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE70 Offset: 0x79A470 VA: 0x18079BE70
	private void set_GroupLeader(IAIGroupable value) { }

	// RVA: 0x79B840 Offset: 0x799E40 VA: 0x18079B840 Slot: 14
	private bool IAIDesign.CanPlayerDesignAI(BasePlayer player) { }

	// RVA: 0x79BB60 Offset: 0x79A160 VA: 0x18079BB60
	private bool PlayerCanDesignAI(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public void EventTriggeredStateChange(int newStateContainerID, int sourceEventID) { }

	// RVA: 0x79BC90 Offset: 0x79A290 VA: 0x18079BC90
	public void .ctor() { }

}

public class BaseAIBrain.BasicAIState // TypeDefIndex: 8491
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

