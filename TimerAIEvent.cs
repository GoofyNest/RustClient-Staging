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
	// RVA: 0x533DF0 Offset: 0x5323F0 VA: 0x180533DF0
	public float get_DurationMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E00 Offset: 0x532400 VA: 0x180533E00
	public void set_DurationMin(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x805B80 Offset: 0x804180 VA: 0x180805B80
	public float get_DurationMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x86DEE0 Offset: 0x86C4E0 VA: 0x18086DEE0
	public void set_DurationMax(float value) { }

	// RVA: 0x86DEC0 Offset: 0x86C4C0 VA: 0x18086DEC0
	public void .ctor() { }

	// RVA: 0x86DD80 Offset: 0x86C380 VA: 0x18086DD80 Slot: 4
	public override void Init(AIEventData data, BaseEntity owner) { }

	// RVA: 0x86DE10 Offset: 0x86C410 VA: 0x18086DE10 Slot: 6
	public override AIEventData ToProto() { }

	// RVA: 0x86DDD0 Offset: 0x86C3D0 VA: 0x18086DDD0 Slot: 7
	public override void Reset() { }

	// RVA: 0x86DD50 Offset: 0x86C350 VA: 0x18086DD50 Slot: 8
	public override void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

}

