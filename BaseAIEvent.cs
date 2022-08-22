public class BaseAIEvent // TypeDefIndex: 9393
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AIEventType <EventType>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <TriggerStateContainerID>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseAIEvent.ExecuteRate <Rate>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <ShouldExecute>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Result>k__BackingField; // 0x1D
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Inverted>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <OutputEntityMemorySlot>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <InputEntityMemorySlot>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseEntity <Owner>k__BackingField; // 0x30
	private float executeTimer; // 0x38
	protected float deltaTime; // 0x3C

	// Properties
	public AIEventType EventType { get; set; }
	public int TriggerStateContainerID { get; set; }
	public BaseAIEvent.ExecuteRate Rate { get; set; }
	public float ExecutionRate { get; }
	public bool ShouldExecute { get; set; }
	public bool Result { get; set; }
	public bool Inverted { get; set; }
	public int OutputEntityMemorySlot { get; set; }
	public bool ShouldSetOutputEntityMemory { get; }
	public int InputEntityMemorySlot { get; set; }
	public int ID { get; set; }
	public BaseEntity Owner { get; set; }
	public bool HasValidTriggerState { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public AIEventType get_EventType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_EventType(AIEventType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_TriggerStateContainerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	private void set_TriggerStateContainerID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public BaseAIEvent.ExecuteRate get_Rate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	protected void set_Rate(BaseAIEvent.ExecuteRate value) { }

	// RVA: 0x7D0BB0 Offset: 0x7CF1B0 VA: 0x1807D0BB0
	public float get_ExecutionRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C30 Offset: 0x7CF230 VA: 0x1807D0C30
	public bool get_ShouldExecute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0CA0 Offset: 0x7CF2A0 VA: 0x1807D0CA0
	protected void set_ShouldExecute(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C20 Offset: 0x7CF220 VA: 0x1807D0C20
	public bool get_Result() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C90 Offset: 0x7CF290 VA: 0x1807D0C90
	protected void set_Result(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C10 Offset: 0x7CF210 VA: 0x1807D0C10
	public bool get_Inverted() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C70 Offset: 0x7CF270 VA: 0x1807D0C70
	private void set_Inverted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_OutputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	protected void set_OutputEntityMemorySlot(int value) { }

	// RVA: 0x7D0C40 Offset: 0x7CF240 VA: 0x1807D0C40
	public bool get_ShouldSetOutputEntityMemory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	protected void set_InputEntityMemorySlot(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	protected void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public BaseEntity get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_Owner(BaseEntity value) { }

	// RVA: 0x7D0BF0 Offset: 0x7CF1F0 VA: 0x1807D0BF0
	public bool get_HasValidTriggerState() { }

	// RVA: 0x7D0B70 Offset: 0x7CF170 VA: 0x1807D0B70
	public void .ctor(AIEventType type) { }

	// RVA: 0x7D0910 Offset: 0x7CEF10 VA: 0x1807D0910 Slot: 4
	public virtual void Init(AIEventData data, BaseEntity owner) { }

	// RVA: 0x7D0960 Offset: 0x7CEF60 VA: 0x1807D0960 Slot: 5
	public virtual void Init(int triggerStateContainer, int id, BaseEntity owner, int inputMemorySlot, int outputMemorySlot, bool inverted) { }

	// RVA: 0x7D0A30 Offset: 0x7CF030 VA: 0x1807D0A30 Slot: 6
	public virtual AIEventData ToProto() { }

	// RVA: 0x7D09B0 Offset: 0x7CEFB0 VA: 0x1807D09B0 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x7D09C0 Offset: 0x7CEFC0 VA: 0x1807D09C0
	public void Tick(float deltaTime, IAIEventListener listener) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

	// RVA: 0x7D09A0 Offset: 0x7CEFA0 VA: 0x1807D09A0 Slot: 9
	public virtual void PostExecute() { }

	// RVA: 0x7D0AB0 Offset: 0x7CF0B0 VA: 0x1807D0AB0
	public void TriggerStateChange(IAIEventListener listener, int sourceEventID) { }

	// RVA: 0x7D0490 Offset: 0x7CEA90 VA: 0x1807D0490
	public static BaseAIEvent CreateEvent(AIEventType eventType) { }

}

public enum BaseAIEvent.ExecuteRate // TypeDefIndex: 9394
{	// Fields
	public int value__; // 0x0
	public const BaseAIEvent.ExecuteRate Slow = 0;
	public const BaseAIEvent.ExecuteRate Normal = 1;
	public const BaseAIEvent.ExecuteRate Fast = 2;
	public const BaseAIEvent.ExecuteRate VeryFast = 3;

}

