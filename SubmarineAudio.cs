public class SubmarineAudio : MonoBehaviour // TypeDefIndex: 9761
{	[HeaderAttribute] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
	[SerializeField] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
	private SoundDefinition engineStartSound; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition engineStopSound; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition engineStartFailSound; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition engineLoopSound; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve engineLoopPitchCurve; // 0x38
	[HeaderAttribute] // RVA: 0x88500 Offset: 0x87900 VA: 0x180088500
	[SerializeField] // RVA: 0x88500 Offset: 0x87900 VA: 0x180088500
	private SoundDefinition underwaterLoopDef; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition underwaterMovementLoopDef; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BlendedSoundLoops surfaceWaterLoops; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float surfaceWaterSoundsMaxSpeed; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition waterEmergeSoundDef; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition waterSubmergeSoundDef; // 0x68
	[HeaderAttribute] // RVA: 0x93890 Offset: 0x92C90 VA: 0x180093890
	[SerializeField] // RVA: 0x93890 Offset: 0x92C90 VA: 0x180093890
	private SoundDefinition activeLoopDef; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition footPedalSoundDef; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform footPedalSoundPos; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition steeringWheelSoundDef; // 0x88
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform steeringWheelSoundPos; // 0x90
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition heavyDamageSparksDef; // 0x98
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform heavyDamageSparksPos; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition flagRaise; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition flagLower; // 0xB0
	[HeaderAttribute] // RVA: 0x93E00 Offset: 0x93200 VA: 0x180093E00
	[SerializeField] // RVA: 0x93E00 Offset: 0x93200 VA: 0x180093E00
	private SoundDefinition climbOrDiveLoopSound; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition sonarBlipSound; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition torpedoFailedSound; // 0xC8
	private Sound engineLoop; // 0xD0
	private SoundModulation.Modulator engineLoopPitchMod; // 0xD8
	private Sound activeLoop; // 0xE0
	private Sound heavyDamageSparksLoop; // 0xE8
	private Sound underwaterLoop; // 0xF0
	private SoundModulation.Modulator underwaterGainMod; // 0xF8
	private Sound underwaterMovementLoop; // 0x100
	private SoundModulation.Modulator underwaterMovementGainMod; // 0x108
	private Sound climbOrDiveLoop; // 0x110
	private float engineSoundMaxDistSqr; // 0x118
	private float previousWaterDepth; // 0x11C
	private float previousRudderInput; // 0x120
	private float previousThrottleInput; // 0x124


	protected void Awake() { }

	public void UpdateTick(BaseSubmarine submarine, bool playerIsInside, float speed, float curSubDepthY) { }

	public void EndAllSounds() { }

	public void PlayEngineStartFailSound() { }

	public void PlayAmmoFlagRaise() { }

	public void PlayAmmoFlagLower() { }

	public void PlaySonarBlipSound() { }

	public void PlayTorpedoFireFailedSound() { }

	private bool WithinEngineSoundDistance() { }

	private void StartEngineSounds() { }

	private void StopEngineSounds() { }

	private void StartInteriorActiveAmbience() { }

	private void StopInteriorActiveAmbience() { }

	private void StartClimbOrDiveSounds() { }

	private void StopClimbOrDiveSounds() { }

	private void PlayEmergeSubmergeSounds(float curSubDepthY) { }

	private void PlayInteriorSteeringSounds(BaseSubmarine submarine) { }

	private void StartUnderwaterLoop(float waterFactor) { }

	private void StopUnderwaterLoop() { }

	private void UpdateSurfaceWaterSounds(float speed, float curSubDepthY) { }

	private void StartUnderwaterMovementSounds() { }

	private void StopUnderwaterMovementSounds() { }

	private void StartHeavyDamageSparkSound() { }

	private void StopHeavyDamageSparkSound() { }

	public void .ctor() { }

}

