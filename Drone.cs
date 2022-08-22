public class Drone : RemoteControlEntity // TypeDefIndex: 8689
{	// Fields
	[HeaderAttribute] // RVA: 0xBB9A0 Offset: 0xBADA0 VA: 0x1800BB9A0
	public Rigidbody body; // 0x2B0
	public bool killInWater; // 0x2B8
	public bool enableGrounding; // 0x2B9
	public bool keepAboveTerrain; // 0x2BA
	public float groundTraceDist; // 0x2BC
	public float altitudeAcceleration; // 0x2C0
	public float movementAcceleration; // 0x2C4
	public float yawSpeed; // 0x2C8
	public float uprightSpeed; // 0x2CC
	public float uprightPrediction; // 0x2D0
	public float uprightDot; // 0x2D4
	public float leanWeight; // 0x2D8
	public float leanMaxVelocity; // 0x2DC
	public float hurtVelocityThreshold; // 0x2E0
	public float hurtDamagePower; // 0x2E4
	public float collisionDisableTime; // 0x2E8
	[HeaderAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public SoundDefinition movementLoopSoundDef; // 0x2F0
	public SoundDefinition movementStartSoundDef; // 0x2F8
	public SoundDefinition movementStopSoundDef; // 0x300
	public AnimationCurve movementLoopPitchCurve; // 0x308
	private Sound movementLoopSound; // 0x310
	private SoundModulation.Modulator movementLoopPitch; // 0x318

	// Properties
	public override bool RequiresMouse { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 157
	public override bool get_RequiresMouse() { }

	// RVA: 0xAB1660 Offset: 0xAAFC60 VA: 0x180AB1660 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xAB1720 Offset: 0xAAFD20 VA: 0x180AB1720 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xAB17F0 Offset: 0xAAFDF0 VA: 0x180AB17F0
	private void PlayMovementStopSound() { }

	// RVA: 0xAB1BB0 Offset: 0xAB01B0 VA: 0x180AB1BB0
	private void UpdateSounds() { }

	// RVA: 0xAB1940 Offset: 0xAAFF40 VA: 0x180AB1940
	private void SetMovementLoopSound(SoundDefinition targetDef) { }

	// RVA: 0xAB1D70 Offset: 0xAB0370 VA: 0x180AB1D70
	public void .ctor() { }

}

private struct Drone.DroneInputState // TypeDefIndex: 8690
{	// Fields
	public Vector3 movement; // 0x0
	public float throttle; // 0xC
	public float pitch; // 0x10
	public float yaw; // 0x14

	// Methods

	// RVA: 0xFC560 Offset: 0xFB960 VA: 0x1800FC560
	public void Reset() { }

}

