public class TrainEngineAudio : TrainCarAudio // TypeDefIndex: 9772
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TrainEngine trainEngine; // 0xA0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform cockpitSoundPosition; // 0xA8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform hornSoundPosition; // 0xB0
	[HeaderAttribute] // RVA: 0x87E60 Offset: 0x87260 VA: 0x180087E60
	[SerializeField] // RVA: 0x87E60 Offset: 0x87260 VA: 0x180087E60
	private SoundDefinition engineStartSound; // 0xB8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition engineStopSound; // 0xC0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition engineActiveLoopDef; // 0xC8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private AnimationCurve engineActiveLoopPitchCurve; // 0xD0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float engineActiveLoopChangeSpeed; // 0xD8
	private Sound engineActiveLoop; // 0xE0
	private SoundModulation.Modulator engineActiveLoopPitch; // 0xE8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BlendedLoopEngineSound engineLoops; // 0xF0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TrainEngineAudio.EngineReflection[] engineReflections; // 0xF8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private LayerMask reflectionLayerMask; // 0x100
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float reflectionMaxDistance; // 0x104
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float reflectionGainChangeSpeed; // 0x108
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float reflectionPositionChangeSpeed; // 0x10C
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float reflectionRayOffset; // 0x110
	[HeaderAttribute] // RVA: 0x96A60 Offset: 0x95E60 VA: 0x180096A60
	[SerializeField] // RVA: 0x96A60 Offset: 0x95E60 VA: 0x180096A60
	private SoundDefinition hornLoop; // 0x118
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition hornStart; // 0x120
	[HeaderAttribute] // RVA: 0x93F00 Offset: 0x93300 VA: 0x180093F00
	[SerializeField] // RVA: 0x93F00 Offset: 0x93300 VA: 0x180093F00
	private SoundDefinition lightsToggleSound; // 0x128
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition proximityAlertDef; // 0x130
	private Sound proximityAlertSound; // 0x138
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition damagedLoopDef; // 0x140
	private Sound damagedLoop; // 0x148
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition changeThrottleDef; // 0x150
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition changeCouplingDef; // 0x158
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition unloadableStartDef; // 0x160
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition unloadableEndDef; // 0x168
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundPlayer brakeSound; // 0x170
	private Nullable<VehicleEngineController.EngineState<TrainEngine>> engineState; // 0x178
	private Sound activeHorn; // 0x180


	public override void UpdateTick() { }

	public override void StopAll() { }

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

