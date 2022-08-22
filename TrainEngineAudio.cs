public class TrainEngineAudio : MonoBehaviour // TypeDefIndex: 9772
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainEngine trainEngine; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform cockpitSoundPosition; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform hornSoundPosition; // 0x28
	[HeaderAttribute] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
	[SerializeField] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
	private SoundDefinition engineStartSound; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition engineStopSound; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition engineActiveLoopDef; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve engineActiveLoopPitchCurve; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineActiveLoopChangeSpeed; // 0x50
	private Sound engineActiveLoop; // 0x58
	private SoundModulation.Modulator engineActiveLoopPitch; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BlendedLoopEngineSound engineLoops; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainEngineAudio.EngineReflection[] engineReflections; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private LayerMask reflectionLayerMask; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float reflectionMaxDistance; // 0x7C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float reflectionGainChangeSpeed; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float reflectionPositionChangeSpeed; // 0x84
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float reflectionRayOffset; // 0x88
	[HeaderAttribute] // RVA: 0x96880 Offset: 0x95C80 VA: 0x180096880
	[SerializeField] // RVA: 0x96880 Offset: 0x95C80 VA: 0x180096880
	private SoundDefinition hornLoop; // 0x90
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition hornStart; // 0x98
	[HeaderAttribute] // RVA: 0x93E00 Offset: 0x93200 VA: 0x180093E00
	[SerializeField] // RVA: 0x93E00 Offset: 0x93200 VA: 0x180093E00
	private SoundDefinition lightsToggleSound; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition proximityAlertDef; // 0xA8
	private Sound proximityAlertSound; // 0xB0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementStartDef; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementStopDef; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementLoopDef; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve movementLoopGainCurve; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float movementChangeOneshotDebounce; // 0xD8
	private Sound movementLoop; // 0xE0
	private SoundModulation.Modulator movementLoopGain; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition turnLoopDef; // 0xF0
	private Sound turnLoop; // 0xF8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition trackClatterLoopDef; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve trackClatterGainCurve; // 0x108
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve trackClatterPitchCurve; // 0x110
	private Sound trackClatterLoop; // 0x118
	private SoundModulation.Modulator trackClatterGain; // 0x120
	private SoundModulation.Modulator trackClatterPitch; // 0x128
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition damagedLoopDef; // 0x130
	private Sound damagedLoop; // 0x138
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition changeThrottleDef; // 0x140
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition changeCouplingDef; // 0x148
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition unloadableStartDef; // 0x150
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition unloadableEndDef; // 0x158
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundPlayer brakeSound; // 0x160
	private Nullable<VehicleEngineController.EngineState<TrainEngine>> engineState; // 0x168
	private float lastMovementChangeOneshot; // 0x170
	private Sound activeHorn; // 0x178

	// Methods

	// RVA: 0xA12980 Offset: 0xA10F80 VA: 0x180A12980
	public void UpdateTick() { }

	// RVA: 0xA12370 Offset: 0xA10970 VA: 0x180A12370
	public void StopAll() { }

	// RVA: 0xA11AB0 Offset: 0xA100B0 VA: 0x180A11AB0
	public void PlayDamageSounds() { }

	// RVA: 0xA12470 Offset: 0xA10A70 VA: 0x180A12470
	public void StopDamageSounds() { }

	// RVA: 0xA11CA0 Offset: 0xA102A0 VA: 0x180A11CA0
	public void PlayThrottleSwitchSound() { }

	// RVA: 0xA11A50 Offset: 0xA10050 VA: 0x180A11A50
	public void PlayCouplingChangedBeep() { }

	// RVA: 0xA11C40 Offset: 0xA10240 VA: 0x180A11C40
	public void PlayLinedUpToUnloadBeep() { }

	// RVA: 0xA11D00 Offset: 0xA10300 VA: 0x180A11D00
	public void PlayUnLinedUpToUnloadBeep() { }

	// RVA: 0xA11DD0 Offset: 0xA103D0 VA: 0x180A11DD0
	public void SetForEngineState(VehicleEngineController.EngineState<TrainEngine> newState) { }

	// RVA: 0xA11BE0 Offset: 0xA101E0 VA: 0x180A11BE0
	public void PlayLightsToggleSound() { }

	// RVA: 0xA11D60 Offset: 0xA10360 VA: 0x180A11D60
	public void SetBrakeSound(bool braking) { }

	// RVA: 0xA11F70 Offset: 0xA10570 VA: 0x180A11F70
	public void SetHornState(bool on) { }

	// RVA: 0xA126C0 Offset: 0xA10CC0 VA: 0x180A126C0
	private void StopMovementLoops() { }

	// RVA: 0xA128D0 Offset: 0xA10ED0 VA: 0x180A128D0
	private void StopTurnLoops() { }

	// RVA: 0xA12520 Offset: 0xA10B20 VA: 0x180A12520
	private void StopEngineSounds(bool withinEngineSoundDist) { }

	// RVA: 0xA121C0 Offset: 0xA107C0 VA: 0x180A121C0
	private void StartEngineSounds(bool withinEngineSoundDist) { }

	// RVA: 0xA13A60 Offset: 0xA12060 VA: 0x180A13A60
	public void .ctor() { }

}

public class TrainEngineAudio.EngineReflection // TypeDefIndex: 9773
{	// Fields
	public Vector3 direction; // 0x10
	public Vector3 offset; // 0x1C
	public SoundDefinition soundDef; // 0x28
	public Sound sound; // 0x30
	public SoundModulation.Modulator pitchMod; // 0x38
	public SoundModulation.Modulator gainMod; // 0x40
	public float distance; // 0x48

	// Methods

	// RVA: 0xA08A30 Offset: 0xA07030 VA: 0x180A08A30
	public void .ctor() { }

}

