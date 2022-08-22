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

	// RVA: 0xA121D0 Offset: 0xA107D0 VA: 0x180A121D0
	public void UpdateTick() { }

	// RVA: 0xA11BC0 Offset: 0xA101C0 VA: 0x180A11BC0
	public void StopAll() { }

	// RVA: 0xA11300 Offset: 0xA0F900 VA: 0x180A11300
	public void PlayDamageSounds() { }

	// RVA: 0xA11CC0 Offset: 0xA102C0 VA: 0x180A11CC0
	public void StopDamageSounds() { }

	// RVA: 0xA114F0 Offset: 0xA0FAF0 VA: 0x180A114F0
	public void PlayThrottleSwitchSound() { }

	// RVA: 0xA112A0 Offset: 0xA0F8A0 VA: 0x180A112A0
	public void PlayCouplingChangedBeep() { }

	// RVA: 0xA11490 Offset: 0xA0FA90 VA: 0x180A11490
	public void PlayLinedUpToUnloadBeep() { }

	// RVA: 0xA11550 Offset: 0xA0FB50 VA: 0x180A11550
	public void PlayUnLinedUpToUnloadBeep() { }

	// RVA: 0xA11620 Offset: 0xA0FC20 VA: 0x180A11620
	public void SetForEngineState(VehicleEngineController.EngineState<TrainEngine> newState) { }

	// RVA: 0xA11430 Offset: 0xA0FA30 VA: 0x180A11430
	public void PlayLightsToggleSound() { }

	// RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	public void SetBrakeSound(bool braking) { }

	// RVA: 0xA117C0 Offset: 0xA0FDC0 VA: 0x180A117C0
	public void SetHornState(bool on) { }

	// RVA: 0xA11F10 Offset: 0xA10510 VA: 0x180A11F10
	private void StopMovementLoops() { }

	// RVA: 0xA12120 Offset: 0xA10720 VA: 0x180A12120
	private void StopTurnLoops() { }

	// RVA: 0xA11D70 Offset: 0xA10370 VA: 0x180A11D70
	private void StopEngineSounds(bool withinEngineSoundDist) { }

	// RVA: 0xA11A10 Offset: 0xA10010 VA: 0x180A11A10
	private void StartEngineSounds(bool withinEngineSoundDist) { }

	// RVA: 0xA132B0 Offset: 0xA118B0 VA: 0x180A132B0
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

	// RVA: 0xA08280 Offset: 0xA06880 VA: 0x180A08280
	public void .ctor() { }

}

