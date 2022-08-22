public class TimerAIEvent : BaseAIEvent // TypeDefIndex: 9416
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <DurationMin>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <DurationMax>k__BackingField; // 0x44
	protected float currentDuration; // 0x48
	protected float elapsedDuration; // 0x4C

	// Properties
	public float DurationMin { get; set; }
	public float DurationMax { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_DurationMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	public void set_DurationMin(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8055F0 Offset: 0x803BF0 VA: 0x1808055F0
	public float get_DurationMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88ABA0 Offset: 0x8891A0 VA: 0x18088ABA0
	public void set_DurationMax(float value) { }

	// RVA: 0x88AB80 Offset: 0x889180 VA: 0x18088AB80
	public void .ctor() { }

	// RVA: 0x88AA40 Offset: 0x889040 VA: 0x18088AA40 Slot: 4
	public override void Init(AIEventData data, BaseEntity owner) { }

	// RVA: 0x88AAD0 Offset: 0x8890D0 VA: 0x18088AAD0 Slot: 6
	public override AIEventData ToProto() { }

	// RVA: 0x88AA90 Offset: 0x889090 VA: 0x18088AA90 Slot: 7
	public override void Reset() { }

	// RVA: 0x88AA10 Offset: 0x889010 VA: 0x18088AA10 Slot: 8
	public override void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

}

