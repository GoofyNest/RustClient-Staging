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

	// RVA: 0x1A791F0 Offset: 0x1A777F0 VA: 0x181A791F0
	private void Update() { }

	// RVA: 0x1A78D00 Offset: 0x1A77300 VA: 0x181A78D00
	private void StartMovementLoop() { }

	// RVA: 0x1A79070 Offset: 0x1A77670 VA: 0x181A79070
	private void StopMovementLoop() { }

	// RVA: 0x1A78BC0 Offset: 0x1A771C0 VA: 0x181A78BC0
	private void StartFrictionLoop() { }

	// RVA: 0x1A78FC0 Offset: 0x1A775C0 VA: 0x181A78FC0
	private void StopFrictionLoop() { }

	// RVA: 0x1A78E70 Offset: 0x1A77470 VA: 0x181A78E70
	private void StartSparksLoop() { }

	// RVA: 0x1A79130 Offset: 0x1A77730 VA: 0x181A79130
	private void StopSparksLoop() { }

	// RVA: 0x118D220 Offset: 0x118B820 VA: 0x18118D220
	public void EnableSparksAudio(bool sparksEnabled) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

