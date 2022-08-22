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
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	private void set_EventType(AIEventType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public int get_TriggerStateContainerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C980 Offset: 0x57AF80 VA: 0x18057C980
	private void set_TriggerStateContainerID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public BaseAIEvent.ExecuteRate get_Rate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	protected void set_Rate(BaseAIEvent.ExecuteRate value) { }

	// RVA: 0x79C5E0 Offset: 0x79ABE0 VA: 0x18079C5E0
	public float get_ExecutionRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C660 Offset: 0x79AC60 VA: 0x18079C660
	public bool get_ShouldExecute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6D0 Offset: 0x79ACD0 VA: 0x18079C6D0
	protected void set_ShouldExecute(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C650 Offset: 0x79AC50 VA: 0x18079C650
	public bool get_Result() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6C0 Offset: 0x79ACC0 VA: 0x18079C6C0
	protected void set_Result(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C640 Offset: 0x79AC40 VA: 0x18079C640
	public bool get_Inverted() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6A0 Offset: 0x79ACA0 VA: 0x18079C6A0
	private void set_Inverted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_OutputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	protected void set_OutputEntityMemorySlot(int value) { }

	// RVA: 0x79C670 Offset: 0x79AC70 VA: 0x18079C670
	public bool get_ShouldSetOutputEntityMemory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	protected void set_InputEntityMemorySlot(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	protected void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public BaseEntity get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_Owner(BaseEntity value) { }

	// RVA: 0x79C620 Offset: 0x79AC20 VA: 0x18079C620
	public bool get_HasValidTriggerState() { }

	// RVA: 0x79C5A0 Offset: 0x79ABA0 VA: 0x18079C5A0
	public void .ctor(AIEventType type) { }

	// RVA: 0x79C340 Offset: 0x79A940 VA: 0x18079C340 Slot: 4
	public virtual void Init(AIEventData data, BaseEntity owner) { }

	// RVA: 0x79C390 Offset: 0x79A990 VA: 0x18079C390 Slot: 5
	public virtual void Init(int triggerStateContainer, int id, BaseEntity owner, int inputMemorySlot, int outputMemorySlot, bool inverted) { }

	// RVA: 0x79C460 Offset: 0x79AA60 VA: 0x18079C460 Slot: 6
	public virtual AIEventData ToProto() { }

	// RVA: 0x79C3E0 Offset: 0x79A9E0 VA: 0x18079C3E0 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x79C3F0 Offset: 0x79A9F0 VA: 0x18079C3F0
	public void Tick(float deltaTime, IAIEventListener listener) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

	// RVA: 0x79C3D0 Offset: 0x79A9D0 VA: 0x18079C3D0 Slot: 9
	public virtual void PostExecute() { }

	// RVA: 0x79C4E0 Offset: 0x79AAE0 VA: 0x18079C4E0
	public void TriggerStateChange(IAIEventListener listener, int sourceEventID) { }

	// RVA: 0x79BEC0 Offset: 0x79A4C0 VA: 0x18079BEC0
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

