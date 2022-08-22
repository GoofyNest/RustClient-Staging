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

	// RVA: 0x7A07D0 Offset: 0x79EDD0 VA: 0x1807A07D0
	protected void Awake() { }

	// RVA: 0x7A1A00 Offset: 0x7A0000 VA: 0x1807A1A00
	public void UpdateTick(BaseSubmarine submarine, bool playerIsInside, float speed, float curSubDepthY) { }

	// RVA: 0x7A0820 Offset: 0x79EE20 VA: 0x1807A0820
	public void EndAllSounds() { }

	// RVA: 0x7A09F0 Offset: 0x79EFF0 VA: 0x1807A09F0
	public void PlayEngineStartFailSound() { }

	// RVA: 0x7A08D0 Offset: 0x79EED0 VA: 0x1807A08D0
	public void PlayAmmoFlagRaise() { }

	// RVA: 0x7A0880 Offset: 0x79EE80 VA: 0x1807A0880
	public void PlayAmmoFlagLower() { }

	// RVA: 0x7A0B40 Offset: 0x79F140 VA: 0x1807A0B40
	public void PlaySonarBlipSound() { }

	// RVA: 0x7A0B90 Offset: 0x79F190 VA: 0x1807A0B90
	public void PlayTorpedoFireFailedSound() { }

	// RVA: 0x7A25A0 Offset: 0x7A0BA0 VA: 0x1807A25A0
	private bool WithinEngineSoundDistance() { }

	// RVA: 0x7A0D10 Offset: 0x79F310 VA: 0x1807A0D10
	private void StartEngineSounds() { }

	// RVA: 0x7A14C0 Offset: 0x79FAC0 VA: 0x1807A14C0
	private void StopEngineSounds() { }

	// RVA: 0x7A1010 Offset: 0x79F610 VA: 0x1807A1010
	private void StartInteriorActiveAmbience() { }

	// RVA: 0x7A16A0 Offset: 0x79FCA0 VA: 0x1807A16A0
	private void StopInteriorActiveAmbience() { }

	// RVA: 0x7A0BE0 Offset: 0x79F1E0 VA: 0x1807A0BE0
	private void StartClimbOrDiveSounds() { }

	// RVA: 0x7A1410 Offset: 0x79FA10 VA: 0x1807A1410
	private void StopClimbOrDiveSounds() { }

	// RVA: 0x7A0920 Offset: 0x79EF20 VA: 0x1807A0920
	private void PlayEmergeSubmergeSounds(float curSubDepthY) { }

	// RVA: 0x7A0A40 Offset: 0x79F040 VA: 0x1807A0A40
	private void PlayInteriorSteeringSounds(BaseSubmarine submarine) { }

	// RVA: 0x7A1140 Offset: 0x79F740 VA: 0x1807A1140
	private void StartUnderwaterLoop(float waterFactor) { }

	// RVA: 0x7A1750 Offset: 0x79FD50 VA: 0x1807A1750
	private void StopUnderwaterLoop() { }

	// RVA: 0x7A18D0 Offset: 0x79FED0 VA: 0x1807A18D0
	private void UpdateSurfaceWaterSounds(float speed, float curSubDepthY) { }

	// RVA: 0x7A12B0 Offset: 0x79F8B0 VA: 0x1807A12B0
	private void StartUnderwaterMovementSounds() { }

	// RVA: 0x7A1810 Offset: 0x79FE10 VA: 0x1807A1810
	private void StopUnderwaterMovementSounds() { }

	// RVA: 0x7A0EE0 Offset: 0x79F4E0 VA: 0x1807A0EE0
	private void StartHeavyDamageSparkSound() { }

	// RVA: 0x7A15F0 Offset: 0x79FBF0 VA: 0x1807A15F0
	private void StopHeavyDamageSparkSound() { }

	// RVA: 0x7A2650 Offset: 0x7A0C50 VA: 0x1807A2650
	public void .ctor() { }

}

