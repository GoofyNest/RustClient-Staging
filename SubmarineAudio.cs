public class SubmarineAudio : MonoBehaviour // TypeDefIndex: 9761
{	// Fields
	[HeaderAttribute] // RVA: 0x87DD0 Offset: 0x871D0 VA: 0x180087DD0
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

	// Methods

	// RVA: 0x7BEBD0 Offset: 0x7BD1D0 VA: 0x1807BEBD0
	protected void Awake() { }

	// RVA: 0x7BFE00 Offset: 0x7BE400 VA: 0x1807BFE00
	public void UpdateTick(BaseSubmarine submarine, bool playerIsInside, float speed, float curSubDepthY) { }

	// RVA: 0x7BEC20 Offset: 0x7BD220 VA: 0x1807BEC20
	public void EndAllSounds() { }

	// RVA: 0x7BEDF0 Offset: 0x7BD3F0 VA: 0x1807BEDF0
	public void PlayEngineStartFailSound() { }

	// RVA: 0x7BECD0 Offset: 0x7BD2D0 VA: 0x1807BECD0
	public void PlayAmmoFlagRaise() { }

	// RVA: 0x7BEC80 Offset: 0x7BD280 VA: 0x1807BEC80
	public void PlayAmmoFlagLower() { }

	// RVA: 0x7BEF40 Offset: 0x7BD540 VA: 0x1807BEF40
	public void PlaySonarBlipSound() { }

	// RVA: 0x7BEF90 Offset: 0x7BD590 VA: 0x1807BEF90
	public void PlayTorpedoFireFailedSound() { }

	// RVA: 0x7C09A0 Offset: 0x7BEFA0 VA: 0x1807C09A0
	private bool WithinEngineSoundDistance() { }

	// RVA: 0x7BF110 Offset: 0x7BD710 VA: 0x1807BF110
	private void StartEngineSounds() { }

	// RVA: 0x7BF8C0 Offset: 0x7BDEC0 VA: 0x1807BF8C0
	private void StopEngineSounds() { }

	// RVA: 0x7BF410 Offset: 0x7BDA10 VA: 0x1807BF410
	private void StartInteriorActiveAmbience() { }

	// RVA: 0x7BFAA0 Offset: 0x7BE0A0 VA: 0x1807BFAA0
	private void StopInteriorActiveAmbience() { }

	// RVA: 0x7BEFE0 Offset: 0x7BD5E0 VA: 0x1807BEFE0
	private void StartClimbOrDiveSounds() { }

	// RVA: 0x7BF810 Offset: 0x7BDE10 VA: 0x1807BF810
	private void StopClimbOrDiveSounds() { }

	// RVA: 0x7BED20 Offset: 0x7BD320 VA: 0x1807BED20
	private void PlayEmergeSubmergeSounds(float curSubDepthY) { }

	// RVA: 0x7BEE40 Offset: 0x7BD440 VA: 0x1807BEE40
	private void PlayInteriorSteeringSounds(BaseSubmarine submarine) { }

	// RVA: 0x7BF540 Offset: 0x7BDB40 VA: 0x1807BF540
	private void StartUnderwaterLoop(float waterFactor) { }

	// RVA: 0x7BFB50 Offset: 0x7BE150 VA: 0x1807BFB50
	private void StopUnderwaterLoop() { }

	// RVA: 0x7BFCD0 Offset: 0x7BE2D0 VA: 0x1807BFCD0
	private void UpdateSurfaceWaterSounds(float speed, float curSubDepthY) { }

	// RVA: 0x7BF6B0 Offset: 0x7BDCB0 VA: 0x1807BF6B0
	private void StartUnderwaterMovementSounds() { }

	// RVA: 0x7BFC10 Offset: 0x7BE210 VA: 0x1807BFC10
	private void StopUnderwaterMovementSounds() { }

	// RVA: 0x7BF2E0 Offset: 0x7BD8E0 VA: 0x1807BF2E0
	private void StartHeavyDamageSparkSound() { }

	// RVA: 0x7BF9F0 Offset: 0x7BDFF0 VA: 0x1807BF9F0
	private void StopHeavyDamageSparkSound() { }

	// RVA: 0x7C0A50 Offset: 0x7BF050 VA: 0x1807C0A50
	public void .ctor() { }

}

