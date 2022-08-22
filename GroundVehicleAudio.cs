public abstract class GroundVehicleAudio : MonoBehaviour, IClientComponent // TypeDefIndex: 9712
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected GroundVehicle groundVehicle; // 0x18
	[HeaderAttribute] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
	[SerializeField] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
	private SoundDefinition engineStartSound; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition engineStopSound; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition engineStartFailSound; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BlendedLoopEngineSound blendedEngineLoops; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float wheelRatioMultiplier; // 0x40
	[HeaderAttribute] // RVA: 0x88500 Offset: 0x87900 VA: 0x180088500
	[SerializeField] // RVA: 0x88500 Offset: 0x87900 VA: 0x180088500
	private SoundDefinition waterSplashSoundDef; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BlendedSoundLoops waterLoops; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float waterSoundsMaxSpeed; // 0x58
	[HeaderAttribute] // RVA: 0x88AE0 Offset: 0x87EE0 VA: 0x180088AE0
	[SerializeField] // RVA: 0x88AE0 Offset: 0x87EE0 VA: 0x180088AE0
	private SoundDefinition brakeSoundDef; // 0x60
	[HeaderAttribute] // RVA: 0x88BF0 Offset: 0x87FF0 VA: 0x180088BF0
	[SerializeField] // RVA: 0x88BF0 Offset: 0x87FF0 VA: 0x180088BF0
	private SoundDefinition lightsToggleSound; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <CameraDistance>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <inWater>k__BackingField; // 0x74
	private Sound brakeSound; // 0x78
	private bool wasInWater; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <engineRpm>k__BackingField; // 0x84
	private float engineRpmDamp; // 0x88
	private float wheelsRpm; // 0x8C
	private const float WHEELS_RPM_CHANGE_RATE_LIMIT = 400;
	private int gear; // 0x90
	private int prevGear; // 0x94

	// Properties
	protected float CameraDistance { get; set; }
	protected bool inWater { get; set; }
	protected abstract EngineAudioSet EngineAudioSet { get; set; }
	public float engineRpm { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3350 Offset: 0x5C1950 VA: 0x1805C3350
	protected float get_CameraDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3530 Offset: 0x5C1B30 VA: 0x1805C3530
	private void set_CameraDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA7200 Offset: 0xCA5800 VA: 0x180CA7200
	protected bool get_inWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA7220 Offset: 0xCA5820 VA: 0x180CA7220
	private void set_inWater(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract EngineAudioSet get_EngineAudioSet();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void set_EngineAudioSet(EngineAudioSet value);

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA71F0 Offset: 0xCA57F0 VA: 0x180CA71F0
	public float get_engineRpm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA7210 Offset: 0xCA5810 VA: 0x180CA7210
	private void set_engineRpm(float value) { }

	// RVA: 0xCA6350 Offset: 0xCA4950 VA: 0x180CA6350 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0xCA6380 Offset: 0xCA4980 VA: 0x180CA6380 Slot: 7
	public virtual void ClientTick() { }

	// RVA: 0xCA68E0 Offset: 0xCA4EE0 VA: 0x180CA68E0 Slot: 8
	public virtual void OnClientTickStopped() { }

	// RVA: -1 Offset: -1
	public void OnEngineStateChanged<T>(VehicleEngineController.EngineState<T> newState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572490 Offset: 0x1570A90 VA: 0x181572490
	|-GroundVehicleAudio.OnEngineStateChanged<GroundVehicle>
	|-GroundVehicleAudio.OnEngineStateChanged<object>
	*/

	// RVA: 0xCA6990 Offset: 0xCA4F90 VA: 0x180CA6990
	public void PlayLightsToggleSound() { }

	// RVA: 0xCA6940 Offset: 0xCA4F40 VA: 0x180CA6940
	public void PlayEngineStartFailSound() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract int GetNumEngines();

	// RVA: 0xCA69E0 Offset: 0xCA4FE0 VA: 0x180CA69E0
	private void StartEngineSounds() { }

	// RVA: 0xCA6B70 Offset: 0xCA5170 VA: 0x180CA6B70
	private void StopEngineSounds() { }

	// RVA: 0xCA6FF0 Offset: 0xCA55F0 VA: 0x180CA6FF0
	private void UpdateWaterSounds() { }

	// RVA: 0xCA6D90 Offset: 0xCA5390 VA: 0x180CA6D90
	private void UpdateEngineSounds() { }

	// RVA: 0xCA68B0 Offset: 0xCA4EB0 VA: 0x180CA68B0
	private float GetWheelRPM() { }

	// RVA: 0xCA64B0 Offset: 0xCA4AB0 VA: 0x180CA64B0
	private float GetEngineRPM() { }

	// RVA: 0xCA6BA0 Offset: 0xCA51A0 VA: 0x180CA6BA0
	private void UpdateBrakeSounds() { }

	// RVA: 0xCA6AD0 Offset: 0xCA50D0 VA: 0x180CA6AD0
	private void StopBrakeSound() { }

	// RVA: 0xCA6350 Offset: 0xCA4950 VA: 0x180CA6350
	private void StopWaterSounds() { }

	// RVA: 0xCA71D0 Offset: 0xCA57D0 VA: 0x180CA71D0
	protected void .ctor() { }

}

