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
	// RVA: 0x5C33C0 Offset: 0x5C19C0 VA: 0x1805C33C0
	protected float get_CameraDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C35A0 Offset: 0x5C1BA0 VA: 0x1805C35A0
	private void set_CameraDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA6AA0 Offset: 0xCA50A0 VA: 0x180CA6AA0
	protected bool get_inWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA6AC0 Offset: 0xCA50C0 VA: 0x180CA6AC0
	private void set_inWater(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract EngineAudioSet get_EngineAudioSet();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void set_EngineAudioSet(EngineAudioSet value);

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA6A90 Offset: 0xCA5090 VA: 0x180CA6A90
	public float get_engineRpm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA6AB0 Offset: 0xCA50B0 VA: 0x180CA6AB0
	private void set_engineRpm(float value) { }

	// RVA: 0xCA5BF0 Offset: 0xCA41F0 VA: 0x180CA5BF0 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0xCA5C20 Offset: 0xCA4220 VA: 0x180CA5C20 Slot: 7
	public virtual void ClientTick() { }

	// RVA: 0xCA6180 Offset: 0xCA4780 VA: 0x180CA6180 Slot: 8
	public virtual void OnClientTickStopped() { }

	// RVA: -1 Offset: -1
	public void OnEngineStateChanged<T>(VehicleEngineController.EngineState<T> newState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1573100 Offset: 0x1571700 VA: 0x181573100
	|-GroundVehicleAudio.OnEngineStateChanged<GroundVehicle>
	|-GroundVehicleAudio.OnEngineStateChanged<object>
	*/

	// RVA: 0xCA6230 Offset: 0xCA4830 VA: 0x180CA6230
	public void PlayLightsToggleSound() { }

	// RVA: 0xCA61E0 Offset: 0xCA47E0 VA: 0x180CA61E0
	public void PlayEngineStartFailSound() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract int GetNumEngines();

	// RVA: 0xCA6280 Offset: 0xCA4880 VA: 0x180CA6280
	private void StartEngineSounds() { }

	// RVA: 0xCA6410 Offset: 0xCA4A10 VA: 0x180CA6410
	private void StopEngineSounds() { }

	// RVA: 0xCA6890 Offset: 0xCA4E90 VA: 0x180CA6890
	private void UpdateWaterSounds() { }

	// RVA: 0xCA6630 Offset: 0xCA4C30 VA: 0x180CA6630
	private void UpdateEngineSounds() { }

	// RVA: 0xCA6150 Offset: 0xCA4750 VA: 0x180CA6150
	private float GetWheelRPM() { }

	// RVA: 0xCA5D50 Offset: 0xCA4350 VA: 0x180CA5D50
	private float GetEngineRPM() { }

	// RVA: 0xCA6440 Offset: 0xCA4A40 VA: 0x180CA6440
	private void UpdateBrakeSounds() { }

	// RVA: 0xCA6370 Offset: 0xCA4970 VA: 0x180CA6370
	private void StopBrakeSound() { }

	// RVA: 0xCA5BF0 Offset: 0xCA41F0 VA: 0x180CA5BF0
	private void StopWaterSounds() { }

	// RVA: 0xCA6A70 Offset: 0xCA5070 VA: 0x180CA6A70
	protected void .ctor() { }

}

