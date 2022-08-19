public class SnowmobileAudio : GroundVehicleAudio // TypeDefIndex: 9757
{	// Fields
	[HeaderAttribute] // RVA: 0x87D60 Offset: 0x87160 VA: 0x180087D60
	[SerializeField] // RVA: 0x87D60 Offset: 0x87160 VA: 0x180087D60
	private EngineAudioSet engineAudioSet; // 0x98
	[HeaderAttribute] // RVA: 0x8FE00 Offset: 0x8F200 VA: 0x18008FE00
	[SerializeField] // RVA: 0x8FE00 Offset: 0x8F200 VA: 0x18008FE00
	private AnimationCurve skiGainCurve; // 0xA0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition skiSlideSoundDef; // 0xA8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition skiSlideSnowSoundDef; // 0xB0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition skiSlideSandSoundDef; // 0xB8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition skiSlideGrassSoundDef; // 0xC0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition skiSlideWaterSoundDef; // 0xC8
	[HeaderAttribute] // RVA: 0x90370 Offset: 0x8F770 VA: 0x180090370
	[SerializeField] // RVA: 0x90370 Offset: 0x8F770 VA: 0x180090370
	private AnimationCurve movementGainCurve; // 0xD0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition movementLoopDef; // 0xD8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition suspensionLurchSoundDef; // 0xE0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float suspensionLurchMinExtensionDelta; // 0xE8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float suspensionLurchMinTimeBetweenSounds; // 0xEC
	private Snowmobile snowmobile; // 0xF0
	private Sound movementLoop; // 0xF8
	private SoundModulation.Modulator movementGainMod; // 0x100
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, float> prevWheelExtensionPercent; // 0x108
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, bool> wheelWasGrounded; // 0x110
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, float> lastSuspensionSoundPlayed; // 0x118

	// Properties
	protected override EngineAudioSet EngineAudioSet { get; set; }

	// Methods

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 4
	protected override EngineAudioSet get_EngineAudioSet() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	// RVA: 0x5B1630 Offset: 0x5AFC30 VA: 0x1805B1630 Slot: 6
	protected override void Awake() { }

	// RVA: 0x5B16D0 Offset: 0x5AFCD0 VA: 0x1805B16D0 Slot: 7
	public override void ClientTick() { }

	// RVA: 0x5B1B80 Offset: 0x5B0180 VA: 0x1805B1B80
	private void UpdateMovementLoop(float speedRatio) { }

	// RVA: 0x5B1910 Offset: 0x5AFF10 VA: 0x1805B1910
	private void StopMovementLoop() { }

	// RVA: 0x5B1DA0 Offset: 0x5B03A0 VA: 0x1805B1DA0
	private void UpdateSkiSound(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData, float speedRatio) { }

	// RVA: 0x5B1AA0 Offset: 0x5B00A0 VA: 0x1805B1AA0
	public void StopSkiAudio() { }

	// RVA: 0x5B19D0 Offset: 0x5AFFD0 VA: 0x1805B19D0
	public void StopSkiAudio(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5B2190 Offset: 0x5B0790 VA: 0x1805B2190
	private void UpdateSuspensionSounds() { }

	// RVA: 0x5B18F0 Offset: 0x5AFEF0 VA: 0x1805B18F0 Slot: 8
	public override void OnClientTickStopped() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 9
	protected override int GetNumEngines() { }

	// RVA: 0x5B24E0 Offset: 0x5B0AE0 VA: 0x1805B24E0
	public void .ctor() { }

}

