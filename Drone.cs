public class Drone : RemoteControlEntity // TypeDefIndex: 8689
{	// Fields
	[HeaderAttribute] // RVA: 0xBB900 Offset: 0xBAD00 VA: 0x1800BB900
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
	[HeaderAttribute] // RVA: 0x8CC10 Offset: 0x8C010 VA: 0x18008CC10
	public SoundDefinition movementLoopSoundDef; // 0x2F0
	public SoundDefinition movementStartSoundDef; // 0x2F8
	public SoundDefinition movementStopSoundDef; // 0x300
	public AnimationCurve movementLoopPitchCurve; // 0x308
	private Sound movementLoopSound; // 0x310
	private SoundModulation.Modulator movementLoopPitch; // 0x318

	// Properties
	public override bool RequiresMouse { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 157
	public override bool get_RequiresMouse() { }

	// RVA: 0xAB0ED0 Offset: 0xAAF4D0 VA: 0x180AB0ED0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xAB0F90 Offset: 0xAAF590 VA: 0x180AB0F90 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xAB1060 Offset: 0xAAF660 VA: 0x180AB1060
	private void PlayMovementStopSound() { }

	// RVA: 0xAB1420 Offset: 0xAAFA20 VA: 0x180AB1420
	private void UpdateSounds() { }

	// RVA: 0xAB11B0 Offset: 0xAAF7B0 VA: 0x180AB11B0
	private void SetMovementLoopSound(SoundDefinition targetDef) { }

	// RVA: 0xAB15E0 Offset: 0xAAFBE0 VA: 0x180AB15E0
	public void .ctor() { }

}

private struct Drone.DroneInputState // TypeDefIndex: 8690
{	// Fields
	public Vector3 movement; // 0x0
	public float throttle; // 0xC
	public float pitch; // 0x10
	public float yaw; // 0x14

	// Methods

	// RVA: 0xFC5E0 Offset: 0xFB9E0 VA: 0x1800FC5E0
	public void Reset() { }

}
