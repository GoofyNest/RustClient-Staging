public class TrainEngineAudio : MonoBehaviour // TypeDefIndex: 9772
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TrainEngine trainEngine; // 0x18
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform cockpitSoundPosition; // 0x20
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform hornSoundPosition; // 0x28
	[HeaderAttribute] // RVA: 0x87EA0 Offset: 0x872A0 VA: 0x180087EA0
	[SerializeField] // RVA: 0x87EA0 Offset: 0x872A0 VA: 0x180087EA0
	private SoundDefinition engineStartSound; // 0x30
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition engineStopSound; // 0x38
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition engineActiveLoopDef; // 0x40
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AnimationCurve engineActiveLoopPitchCurve; // 0x48
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float engineActiveLoopChangeSpeed; // 0x50
	private Sound engineActiveLoop; // 0x58
	private SoundModulation.Modulator engineActiveLoopPitch; // 0x60
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BlendedLoopEngineSound engineLoops; // 0x68
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TrainEngineAudio.EngineReflection[] engineReflections; // 0x70
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private LayerMask reflectionLayerMask; // 0x78
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float reflectionMaxDistance; // 0x7C
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float reflectionGainChangeSpeed; // 0x80
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float reflectionPositionChangeSpeed; // 0x84
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float reflectionRayOffset; // 0x88
	[HeaderAttribute] // RVA: 0x96930 Offset: 0x95D30 VA: 0x180096930
	[SerializeField] // RVA: 0x96930 Offset: 0x95D30 VA: 0x180096930
	private SoundDefinition hornLoop; // 0x90
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition hornStart; // 0x98
	[HeaderAttribute] // RVA: 0x93F00 Offset: 0x93300 VA: 0x180093F00
	[SerializeField] // RVA: 0x93F00 Offset: 0x93300 VA: 0x180093F00
	private SoundDefinition lightsToggleSound; // 0xA0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition proximityAlertDef; // 0xA8
	private Sound proximityAlertSound; // 0xB0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition movementStartDef; // 0xB8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition movementStopDef; // 0xC0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition movementLoopDef; // 0xC8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AnimationCurve movementLoopGainCurve; // 0xD0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float movementChangeOneshotDebounce; // 0xD8
	private Sound movementLoop; // 0xE0
	private SoundModulation.Modulator movementLoopGain; // 0xE8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition turnLoopDef; // 0xF0
	private Sound turnLoop; // 0xF8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition trackClatterLoopDef; // 0x100
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AnimationCurve trackClatterGainCurve; // 0x108
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AnimationCurve trackClatterPitchCurve; // 0x110
	private Sound trackClatterLoop; // 0x118
	private SoundModulation.Modulator trackClatterGain; // 0x120
	private SoundModulation.Modulator trackClatterPitch; // 0x128
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition damagedLoopDef; // 0x130
	private Sound damagedLoop; // 0x138
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition changeThrottleDef; // 0x140
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition changeCouplingDef; // 0x148
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition unloadableStartDef; // 0x150
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition unloadableEndDef; // 0x158
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundPlayer brakeSound; // 0x160
	private Nullable<VehicleEngineController.EngineState<TrainEngine>> engineState; // 0x168
	private float lastMovementChangeOneshot; // 0x170
	private Sound activeHorn; // 0x178


	public void UpdateTick() { }

	public void StopAll() { }

	public void PlayDamageSounds() { }

	public void StopDamageSounds() { }

	public void PlayThrottleSwitchSound() { }

	public void PlayCouplingChangedBeep() { }

	public void PlayLinedUpToUnloadBeep() { }

	public void PlayUnLinedUpToUnloadBeep() { }

	public void SetForEngineState(VehicleEngineController.EngineState<TrainEngine> newState) { }

	public void PlayLightsToggleSound() { }

	public void SetBrakeSound(bool braking) { }

	public void SetHornState(bool on) { }

	private void StopMovementLoops() { }

	private void StopTurnLoops() { }

	private void StopEngineSounds(bool withinEngineSoundDist) { }

	private void StartEngineSounds(bool withinEngineSoundDist) { }

	public void .ctor() { }

}

public class TrainEngineAudio.EngineReflection // TypeDefIndex: 9773
{	public Vector3 direction; // 0x10
	public Vector3 offset; // 0x1C
	public SoundDefinition soundDef; // 0x28
	public Sound sound; // 0x30
	public SoundModulation.Modulator pitchMod; // 0x38
	public SoundModulation.Modulator gainMod; // 0x40
	public float distance; // 0x48


	public void .ctor() { }

}

