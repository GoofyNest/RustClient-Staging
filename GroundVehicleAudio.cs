public abstract class GroundVehicleAudio : MonoBehaviour, IClientComponent // TypeDefIndex: 9712
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected GroundVehicle groundVehicle; // 0x18
	[HeaderAttribute] // RVA: 0x87EA0 Offset: 0x872A0 VA: 0x180087EA0
	[SerializeField] // RVA: 0x87EA0 Offset: 0x872A0 VA: 0x180087EA0
	private SoundDefinition engineStartSound; // 0x20
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition engineStopSound; // 0x28
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition engineStartFailSound; // 0x30
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BlendedLoopEngineSound blendedEngineLoops; // 0x38
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float wheelRatioMultiplier; // 0x40
	[HeaderAttribute] // RVA: 0x885C0 Offset: 0x879C0 VA: 0x1800885C0
	[SerializeField] // RVA: 0x885C0 Offset: 0x879C0 VA: 0x1800885C0
	private SoundDefinition waterSplashSoundDef; // 0x48
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BlendedSoundLoops waterLoops; // 0x50
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float waterSoundsMaxSpeed; // 0x58
	[HeaderAttribute] // RVA: 0x88C30 Offset: 0x88030 VA: 0x180088C30
	[SerializeField] // RVA: 0x88C30 Offset: 0x88030 VA: 0x180088C30
	private SoundDefinition brakeSoundDef; // 0x60
	[HeaderAttribute] // RVA: 0x88D40 Offset: 0x88140 VA: 0x180088D40
	[SerializeField] // RVA: 0x88D40 Offset: 0x88140 VA: 0x180088D40
	private SoundDefinition lightsToggleSound; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <CameraDistance>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <inWater>k__BackingField; // 0x74
	private Sound brakeSound; // 0x78
	private bool wasInWater; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected float get_CameraDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_CameraDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected bool get_inWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_inWater(bool value) { }

	protected abstract EngineAudioSet get_EngineAudioSet();

	protected abstract void set_EngineAudioSet(EngineAudioSet value);

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_engineRpm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_engineRpm(float value) { }

	protected virtual void Awake() { }

	public virtual void ClientTick() { }

	public virtual void OnClientTickStopped() { }

	public void OnEngineStateChanged<T>(VehicleEngineController.EngineState<T> newState) { }
	/* GenericInstMethod :
	|
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

