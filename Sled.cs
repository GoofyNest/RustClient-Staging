public class Sled : BaseVehicle, INotifyTrigger // TypeDefIndex: 8836
{	// Fields
	private const BaseEntity.Flags BrakeOn = 128;
	private const BaseEntity.Flags OnSnow = 256;
	private const BaseEntity.Flags IsGrounded = 512;
	private const BaseEntity.Flags OnSand = 1024;
	public PhysicMaterial BrakeMaterial; // 0x3B8
	public PhysicMaterial SnowMaterial; // 0x3C0
	public PhysicMaterial NonSnowMaterial; // 0x3C8
	public Transform CentreOfMassTransform; // 0x3D0
	public Collider[] PhysicsMaterialTargets; // 0x3D8
	public float InitialForceCutoff; // 0x3E0
	public float InitialForceIncreaseRate; // 0x3E4
	public float TurnForce; // 0x3E8
	public float DirectionMatchForce; // 0x3EC
	public float VerticalAdjustmentForce; // 0x3F0
	public float VerticalAdjustmentAngleThreshold; // 0x3F4
	public float NudgeCooldown; // 0x3F8
	public float NudgeForce; // 0x3FC
	public float MaxNudgeVelocity; // 0x400
	public const float DecayFrequency = 60;
	public float DecayAmount; // 0x404
	public ParticleSystemContainer TrailEffects; // 0x408
	public SoundDefinition enterSnowSoundDef; // 0x410
	public SoundDefinition snowSlideLoopSoundDef; // 0x418
	public SoundDefinition dirtSlideLoopSoundDef; // 0x420
	public AnimationCurve movementLoopGainCurve; // 0x428
	public AnimationCurve movementLoopPitchCurve; // 0x430
	private Sound movementLoopSound; // 0x438
	private SoundModulation.Modulator movementLoopGain; // 0x440
	private SoundModulation.Modulator movementLoopPitch; // 0x448
	private float speed; // 0x450
	private PhysicsEffects physEffects; // 0x458
	private bool shouldShowHelp; // 0x460
	private TimeSince showHelpTime; // 0x464

	// Properties
	public bool ShowHelpPrompt { get; }
	public override bool BlocksDoors { get; }

	// Methods

	// RVA: 0x5A66F0 Offset: 0x5A4CF0 VA: 0x1805A66F0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5A6A20 Offset: 0x5A5020 VA: 0x1805A6A20 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x5A66B0 Offset: 0x5A4CB0 VA: 0x1805A66B0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x5A65F0 Offset: 0x5A4BF0 VA: 0x1805A65F0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x5A6560 Offset: 0x5A4B60 VA: 0x1805A6560 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5A6DD0 Offset: 0x5A53D0 VA: 0x1805A6DD0
	private void UpdateSounds() { }

	// RVA: 0x5A6B50 Offset: 0x5A5150 VA: 0x1805A6B50
	private void SetMovementLoopSound(SoundDefinition targetDef) { }

	// RVA: 0x5A70A0 Offset: 0x5A56A0 VA: 0x1805A70A0
	public bool get_ShowHelpPrompt() { }

	// RVA: 0x5A6520 Offset: 0x5A4B20 VA: 0x1805A6520 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 194
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 195
	public void OnEmpty() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 185
	public override bool get_BlocksDoors() { }

	// RVA: 0x5A7030 Offset: 0x5A5630 VA: 0x1805A7030
	public void .ctor() { }

}

