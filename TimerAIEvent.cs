public class TimerAIEvent : BaseAIEvent // TypeDefIndex: 9416
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <DurationMin>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <DurationMax>k__BackingField; // 0x44
	protected float currentDuration; // 0x48
	protected float elapsedDuration; // 0x4C

	// Properties
	public float DurationMin { get; set; }
	public float DurationMax { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_DurationMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	public void set_DurationMin(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8054E0 Offset: 0x803AE0 VA: 0x1808054E0
	public float get_DurationMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x88AA90 Offset: 0x889090 VA: 0x18088AA90
	public void set_DurationMax(float value) { }

	// RVA: 0x88AA70 Offset: 0x889070 VA: 0x18088AA70
	public void .ctor() { }

	// RVA: 0x88A930 Offset: 0x888F30 VA: 0x18088A930 Slot: 4
	public override void Init(AIEventData data, BaseEntity owner) { }

	// RVA: 0x88A9C0 Offset: 0x888FC0 VA: 0x18088A9C0 Slot: 6
	public override AIEventData ToProto() { }

	// RVA: 0x88A980 Offset: 0x888F80 VA: 0x18088A980 Slot: 7
	public override void Reset() { }

	// RVA: 0x88A900 Offset: 0x888F00 VA: 0x18088A900 Slot: 8
	public override void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

}

