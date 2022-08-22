public class TrainCarAudio : MonoBehaviour // TypeDefIndex: 9768
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainCar trainCar; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementStartDef; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementStopDef; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementLoopDef; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve movementLoopGainCurve; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float movementChangeOneshotDebounce; // 0x40
	private Sound movementLoop; // 0x48
	private SoundModulation.Modulator movementLoopGain; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition turnLoopDef; // 0x58
	private Sound turnLoop; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition trackClatterLoopDef; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve trackClatterGainCurve; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve trackClatterPitchCurve; // 0x78
	private Sound trackClatterLoop; // 0x80
	private SoundModulation.Modulator trackClatterGain; // 0x88
	private SoundModulation.Modulator trackClatterPitch; // 0x90
	private float lastMovementChangeOneshot; // 0x98

	// Methods

	// RVA: 0xA0B9A0 Offset: 0xA09FA0 VA: 0x180A0B9A0
	public void UpdateTick() { }

	// RVA: 0xA0B6F0 Offset: 0xA09CF0 VA: 0x180A0B6F0
	public void StopAll() { }

	// RVA: 0xA0B710 Offset: 0xA09D10 VA: 0x180A0B710
	private void StopMovementLoops() { }

	// RVA: 0xA0B900 Offset: 0xA09F00 VA: 0x180A0B900
	private void StopTurnLoops() { }

	// RVA: 0xA0BF70 Offset: 0xA0A570 VA: 0x180A0BF70
	public void .ctor() { }

}

