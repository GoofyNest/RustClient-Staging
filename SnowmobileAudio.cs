public class SnowmobileAudio : GroundVehicleAudio // TypeDefIndex: 9757
{	// Fields
	[HeaderAttribute] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
	[SerializeField] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
	private EngineAudioSet engineAudioSet; // 0x98
	[HeaderAttribute] // RVA: 0x8FE80 Offset: 0x8F280 VA: 0x18008FE80
	[SerializeField] // RVA: 0x8FE80 Offset: 0x8F280 VA: 0x18008FE80
	private AnimationCurve skiGainCurve; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition skiSlideSoundDef; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition skiSlideSnowSoundDef; // 0xB0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition skiSlideSandSoundDef; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition skiSlideGrassSoundDef; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition skiSlideWaterSoundDef; // 0xC8
	[HeaderAttribute] // RVA: 0x90440 Offset: 0x8F840 VA: 0x180090440
	[SerializeField] // RVA: 0x90440 Offset: 0x8F840 VA: 0x180090440
	private AnimationCurve movementGainCurve; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementLoopDef; // 0xD8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suspensionLurchSoundDef; // 0xE0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float suspensionLurchMinExtensionDelta; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310 Slot: 4
	protected override EngineAudioSet get_EngineAudioSet() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	// RVA: 0x5B15C0 Offset: 0x5AFBC0 VA: 0x1805B15C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x5B1660 Offset: 0x5AFC60 VA: 0x1805B1660 Slot: 7
	public override void ClientTick() { }

	// RVA: 0x5B1B10 Offset: 0x5B0110 VA: 0x1805B1B10
	private void UpdateMovementLoop(float speedRatio) { }

	// RVA: 0x5B18A0 Offset: 0x5AFEA0 VA: 0x1805B18A0
	private void StopMovementLoop() { }

	// RVA: 0x5B1D30 Offset: 0x5B0330 VA: 0x1805B1D30
	private void UpdateSkiSound(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData, float speedRatio) { }

	// RVA: 0x5B1A30 Offset: 0x5B0030 VA: 0x1805B1A30
	public void StopSkiAudio() { }

	// RVA: 0x5B1960 Offset: 0x5AFF60 VA: 0x1805B1960
	public void StopSkiAudio(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5B2120 Offset: 0x5B0720 VA: 0x1805B2120
	private void UpdateSuspensionSounds() { }

	// RVA: 0x5B1880 Offset: 0x5AFE80 VA: 0x1805B1880 Slot: 8
	public override void OnClientTickStopped() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 9
	protected override int GetNumEngines() { }

	// RVA: 0x5B2470 Offset: 0x5B0A70 VA: 0x1805B2470
	public void .ctor() { }

}

