public class TimerAIEvent : BaseAIEvent // TypeDefIndex: 9416
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <DurationMin>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <DurationMax>k__BackingField; // 0x44
	protected float currentDuration; // 0x48
	protected float elapsedDuration; // 0x4C

	public float DurationMin { get; set; }
	public float DurationMax { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_DurationMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_DurationMin(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_DurationMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_DurationMax(float value) { }

	public void .ctor() { }

	public override void Init(AIEventData data, BaseEntity owner) { }

	public override AIEventData ToProto() { }

	public override void Reset() { }

	public override void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

}

