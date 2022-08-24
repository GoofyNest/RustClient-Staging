public class SnowmobileAudio : GroundVehicleAudio // TypeDefIndex: 9757
{	[HeaderAttribute] // RVA: 0x87E60 Offset: 0x87260 VA: 0x180087E60
	[SerializeField] // RVA: 0x87E60 Offset: 0x87260 VA: 0x180087E60
	private EngineAudioSet engineAudioSet; // 0x98
	[HeaderAttribute] // RVA: 0x8FE70 Offset: 0x8F270 VA: 0x18008FE70
	[SerializeField] // RVA: 0x8FE70 Offset: 0x8F270 VA: 0x18008FE70
	private AnimationCurve skiGainCurve; // 0xA0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition skiSlideSoundDef; // 0xA8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition skiSlideSnowSoundDef; // 0xB0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition skiSlideSandSoundDef; // 0xB8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition skiSlideGrassSoundDef; // 0xC0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition skiSlideWaterSoundDef; // 0xC8
	[HeaderAttribute] // RVA: 0x90430 Offset: 0x8F830 VA: 0x180090430
	[SerializeField] // RVA: 0x90430 Offset: 0x8F830 VA: 0x180090430
	private AnimationCurve movementGainCurve; // 0xD0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition movementLoopDef; // 0xD8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suspensionLurchSoundDef; // 0xE0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float suspensionLurchMinExtensionDelta; // 0xE8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float suspensionLurchMinTimeBetweenSounds; // 0xEC
	private Snowmobile snowmobile; // 0xF0
	private Sound movementLoop; // 0xF8
	private SoundModulation.Modulator movementGainMod; // 0x100
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, float> prevWheelExtensionPercent; // 0x108
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, bool> wheelWasGrounded; // 0x110
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, float> lastSuspensionSoundPlayed; // 0x118

	protected override EngineAudioSet EngineAudioSet { get; set; }


	protected override EngineAudioSet get_EngineAudioSet() { }

	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	protected override void Awake() { }

	public override void ClientTick() { }

	private void UpdateMovementLoop(float speedRatio) { }

	private void StopMovementLoop() { }

	private void UpdateSkiSound(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData, float speedRatio) { }

	public void StopSkiAudio() { }

	public void StopSkiAudio(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	private void UpdateSuspensionSounds() { }

	public override void OnClientTickStopped() { }

	protected override int GetNumEngines() { }

	public void .ctor() { }

}

