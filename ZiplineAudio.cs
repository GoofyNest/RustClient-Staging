public class ZiplineAudio : MonoBehaviour // TypeDefIndex: 8670
{	// Fields
	public ZiplineMountable zipline; // 0x18
	public SoundDefinition movementLoopDef; // 0x20
	public SoundDefinition frictionLoopDef; // 0x28
	public SoundDefinition sparksLoopDef; // 0x30
	public AnimationCurve movementGainCurve; // 0x38
	public AnimationCurve movementPitchCurve; // 0x40
	public AnimationCurve frictionGainCurve; // 0x48
	public AnimationCurve sparksGainCurve; // 0x50
	private Sound movementLoop; // 0x58
	private SoundModulation.Modulator movementLoopGain; // 0x60
	private SoundModulation.Modulator movementLoopPitch; // 0x68
	private Sound frictionLoop; // 0x70
	private SoundModulation.Modulator frictionLoopGain; // 0x78
	private Sound sparksLoop; // 0x80
	private SoundModulation.Modulator sparksLoopGain; // 0x88
	private bool sparksActive; // 0x90

	// Methods

	// RVA: 0x1AA2AB0 Offset: 0x1AA10B0 VA: 0x181AA2AB0
	private void Update() { }

	// RVA: 0x1AA25C0 Offset: 0x1AA0BC0 VA: 0x181AA25C0
	private void StartMovementLoop() { }

	// RVA: 0x1AA2930 Offset: 0x1AA0F30 VA: 0x181AA2930
	private void StopMovementLoop() { }

	// RVA: 0x1AA2480 Offset: 0x1AA0A80 VA: 0x181AA2480
	private void StartFrictionLoop() { }

	// RVA: 0x1AA2880 Offset: 0x1AA0E80 VA: 0x181AA2880
	private void StopFrictionLoop() { }

	// RVA: 0x1AA2730 Offset: 0x1AA0D30 VA: 0x181AA2730
	private void StartSparksLoop() { }

	// RVA: 0x1AA29F0 Offset: 0x1AA0FF0 VA: 0x181AA29F0
	private void StopSparksLoop() { }

	// RVA: 0x1188640 Offset: 0x1186C40 VA: 0x181188640
	public void EnableSparksAudio(bool sparksEnabled) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

