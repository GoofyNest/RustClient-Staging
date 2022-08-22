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

	// RVA: 0x1A8C9E0 Offset: 0x1A8AFE0 VA: 0x181A8C9E0
	private void Update() { }

	// RVA: 0x1A8C4F0 Offset: 0x1A8AAF0 VA: 0x181A8C4F0
	private void StartMovementLoop() { }

	// RVA: 0x1A8C860 Offset: 0x1A8AE60 VA: 0x181A8C860
	private void StopMovementLoop() { }

	// RVA: 0x1A8C3B0 Offset: 0x1A8A9B0 VA: 0x181A8C3B0
	private void StartFrictionLoop() { }

	// RVA: 0x1A8C7B0 Offset: 0x1A8ADB0 VA: 0x181A8C7B0
	private void StopFrictionLoop() { }

	// RVA: 0x1A8C660 Offset: 0x1A8AC60 VA: 0x181A8C660
	private void StartSparksLoop() { }

	// RVA: 0x1A8C920 Offset: 0x1A8AF20 VA: 0x181A8C920
	private void StopSparksLoop() { }

	// RVA: 0x1188900 Offset: 0x1186F00 VA: 0x181188900
	public void EnableSparksAudio(bool sparksEnabled) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

