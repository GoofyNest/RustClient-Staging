public abstract class GroundVehicleAudio : MonoBehaviour, IClientComponent // TypeDefIndex: 9712
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	protected float CameraDistance { get; set; }
	protected bool inWater { get; set; }
	protected abstract EngineAudioSet EngineAudioSet { get; set; }
	public float engineRpm { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float get_CameraDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_CameraDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool get_inWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_inWater(bool value) { }

	protected abstract EngineAudioSet get_EngineAudioSet();

	protected abstract void set_EngineAudioSet(EngineAudioSet value);

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_engineRpm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_engineRpm(float value) { }

	protected virtual void Awake() { }

	public virtual void ClientTick() { }

	public virtual void OnClientTickStopped() { }

	public void OnEngineStateChanged<T>(VehicleEngineController.EngineState<T> newState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15725D0 Offset: 0x1570BD0 VA: 0x1815725D0
	|-GroundVehicleAudio.OnEngineStateChanged<GroundVehicle>
	|-GroundVehicleAudio.OnEngineStateChanged<object>
	*/

	public void PlayLightsToggleSound() { }

	public void PlayEngineStartFailSound() { }

	protected abstract int GetNumEngines();

	private void StartEngineSounds() { }

	private void StopEngineSounds() { }

	private void UpdateWaterSounds() { }

	private void UpdateEngineSounds() { }

	private float GetWheelRPM() { }

	private float GetEngineRPM() { }

	private void UpdateBrakeSounds() { }

	private void StopBrakeSound() { }

	private void StopWaterSounds() { }

	protected void .ctor() { }

}

