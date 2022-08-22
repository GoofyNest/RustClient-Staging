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
	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	protected void set_Rate(BaseAIEvent.ExecuteRate value) { }

	// RVA: 0x7D0CC0 Offset: 0x7CF2C0 VA: 0x1807D0CC0
	public float get_ExecutionRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D40 Offset: 0x7CF340 VA: 0x1807D0D40
	public bool get_ShouldExecute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0DB0 Offset: 0x7CF3B0 VA: 0x1807D0DB0
	protected void set_ShouldExecute(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D30 Offset: 0x7CF330 VA: 0x1807D0D30
	public bool get_Result() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0DA0 Offset: 0x7CF3A0 VA: 0x1807D0DA0
	protected void set_Result(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D20 Offset: 0x7CF320 VA: 0x1807D0D20
	public bool get_Inverted() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D80 Offset: 0x7CF380 VA: 0x1807D0D80
	private void set_Inverted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_OutputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	protected void set_OutputEntityMemorySlot(int value) { }

	// RVA: 0x7D0D50 Offset: 0x7CF350 VA: 0x1807D0D50
	public bool get_ShouldSetOutputEntityMemory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	protected void set_InputEntityMemorySlot(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	protected void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public BaseEntity get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_Owner(BaseEntity value) { }

	// RVA: 0x7D0D00 Offset: 0x7CF300 VA: 0x1807D0D00
	public bool get_HasValidTriggerState() { }

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void .ctor(AIEventType type) { }

	// RVA: 0x7D0A20 Offset: 0x7CF020 VA: 0x1807D0A20 Slot: 4
	public virtual void Init(AIEventData data, BaseEntity owner) { }

	// RVA: 0x7D0A70 Offset: 0x7CF070 VA: 0x1807D0A70 Slot: 5
	public virtual void Init(int triggerStateContainer, int id, BaseEntity owner, int inputMemorySlot, int outputMemorySlot, bool inverted) { }

	// RVA: 0x7D0B40 Offset: 0x7CF140 VA: 0x1807D0B40 Slot: 6
	public virtual AIEventData ToProto() { }

	// RVA: 0x7D0AC0 Offset: 0x7CF0C0 VA: 0x1807D0AC0 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x7D0AD0 Offset: 0x7CF0D0 VA: 0x1807D0AD0
	public void Tick(float deltaTime, IAIEventListener listener) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

	// RVA: 0x7D0AB0 Offset: 0x7CF0B0 VA: 0x1807D0AB0 Slot: 9
	public virtual void PostExecute() { }

	// RVA: 0x7D0BC0 Offset: 0x7CF1C0 VA: 0x1807D0BC0
	public void TriggerStateChange(IAIEventListener listener, int sourceEventID) { }

	// RVA: 0x7D05A0 Offset: 0x7CEBA0 VA: 0x1807D05A0
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

