public class TrainCarAudio : MonoBehaviour // TypeDefIndex: 9768
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TrainCar trainCar; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition movementStartDef; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition movementStopDef; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition movementLoopDef; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AnimationCurve movementLoopGainCurve; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float movementChangeOneshotDebounce; // 0x40
	private Sound movementLoop; // 0x48
	private SoundModulation.Modulator movementLoopGain; // 0x50
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition turnLoopDef; // 0x58
	private Sound turnLoop; // 0x60
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition trackClatterLoopDef; // 0x68
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AnimationCurve trackClatterGainCurve; // 0x70
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AnimationCurve trackClatterPitchCurve; // 0x78
	private Sound trackClatterLoop; // 0x80
	private SoundModulation.Modulator trackClatterGain; // 0x88
	private SoundModulation.Modulator trackClatterPitch; // 0x90
	private float lastMovementChangeOneshot; // 0x98

	// Methods

	// RVA: 0xA0B6E0 Offset: 0xA09CE0 VA: 0x180A0B6E0
	public void UpdateTick() { }

	// RVA: 0xA0B430 Offset: 0xA09A30 VA: 0x180A0B430
	public void StopAll() { }

	// RVA: 0xA0B450 Offset: 0xA09A50 VA: 0x180A0B450
	private void StopMovementLoops() { }

	// RVA: 0xA0B640 Offset: 0xA09C40 VA: 0x180A0B640
	private void StopTurnLoops() { }

	// RVA: 0xA0BCB0 Offset: 0xA0A2B0 VA: 0x180A0BCB0
	public void .ctor() { }

}

