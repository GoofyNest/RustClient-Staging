public class SubmarineAudio : MonoBehaviour // TypeDefIndex: 9761
{	// Fields
	[HeaderAttribute] // RVA: 0x87D60 Offset: 0x87160 VA: 0x180087D60
	[SerializeField] // RVA: 0x87D60 Offset: 0x87160 VA: 0x180087D60
	private SoundDefinition engineStartSound; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition engineStopSound; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition engineStartFailSound; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition engineLoopSound; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AnimationCurve engineLoopPitchCurve; // 0x38
	[HeaderAttribute] // RVA: 0x88490 Offset: 0x87890 VA: 0x180088490
	[SerializeField] // RVA: 0x88490 Offset: 0x87890 VA: 0x180088490
	private SoundDefinition underwaterLoopDef; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition underwaterMovementLoopDef; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BlendedSoundLoops surfaceWaterLoops; // 0x50
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float surfaceWaterSoundsMaxSpeed; // 0x58
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition waterEmergeSoundDef; // 0x60
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition waterSubmergeSoundDef; // 0x68
	[HeaderAttribute] // RVA: 0x93780 Offset: 0x92B80 VA: 0x180093780
	[SerializeField] // RVA: 0x93780 Offset: 0x92B80 VA: 0x180093780
	private SoundDefinition activeLoopDef; // 0x70
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition footPedalSoundDef; // 0x78
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform footPedalSoundPos; // 0x80
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition steeringWheelSoundDef; // 0x88
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform steeringWheelSoundPos; // 0x90
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition heavyDamageSparksDef; // 0x98
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform heavyDamageSparksPos; // 0xA0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition flagRaise; // 0xA8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition flagLower; // 0xB0
	[HeaderAttribute] // RVA: 0x93D20 Offset: 0x93120 VA: 0x180093D20
	[SerializeField] // RVA: 0x93D20 Offset: 0x93120 VA: 0x180093D20
	private SoundDefinition climbOrDiveLoopSound; // 0xB8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundDefinition sonarBlipSound; // 0xC0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x7A06C0 Offset: 0x79ECC0 VA: 0x1807A06C0
	protected void Awake() { }

	// RVA: 0x7A18F0 Offset: 0x79FEF0 VA: 0x1807A18F0
	public void UpdateTick(BaseSubmarine submarine, bool playerIsInside, float speed, float curSubDepthY) { }

	// RVA: 0x7A0710 Offset: 0x79ED10 VA: 0x1807A0710
	public void EndAllSounds() { }

	// RVA: 0x7A08E0 Offset: 0x79EEE0 VA: 0x1807A08E0
	public void PlayEngineStartFailSound() { }

	// RVA: 0x7A07C0 Offset: 0x79EDC0 VA: 0x1807A07C0
	public void PlayAmmoFlagRaise() { }

	// RVA: 0x7A0770 Offset: 0x79ED70 VA: 0x1807A0770
	public void PlayAmmoFlagLower() { }

	// RVA: 0x7A0A30 Offset: 0x79F030 VA: 0x1807A0A30
	public void PlaySonarBlipSound() { }

	// RVA: 0x7A0A80 Offset: 0x79F080 VA: 0x1807A0A80
	public void PlayTorpedoFireFailedSound() { }

	// RVA: 0x7A2490 Offset: 0x7A0A90 VA: 0x1807A2490
	private bool WithinEngineSoundDistance() { }

	// RVA: 0x7A0C00 Offset: 0x79F200 VA: 0x1807A0C00
	private void StartEngineSounds() { }

	// RVA: 0x7A13B0 Offset: 0x79F9B0 VA: 0x1807A13B0
	private void StopEngineSounds() { }

	// RVA: 0x7A0F00 Offset: 0x79F500 VA: 0x1807A0F00
	private void StartInteriorActiveAmbience() { }

	// RVA: 0x7A1590 Offset: 0x79FB90 VA: 0x1807A1590
	private void StopInteriorActiveAmbience() { }

	// RVA: 0x7A0AD0 Offset: 0x79F0D0 VA: 0x1807A0AD0
	private void StartClimbOrDiveSounds() { }

	// RVA: 0x7A1300 Offset: 0x79F900 VA: 0x1807A1300
	private void StopClimbOrDiveSounds() { }

	// RVA: 0x7A0810 Offset: 0x79EE10 VA: 0x1807A0810
	private void PlayEmergeSubmergeSounds(float curSubDepthY) { }

	// RVA: 0x7A0930 Offset: 0x79EF30 VA: 0x1807A0930
	private void PlayInteriorSteeringSounds(BaseSubmarine submarine) { }

	// RVA: 0x7A1030 Offset: 0x79F630 VA: 0x1807A1030
	private void StartUnderwaterLoop(float waterFactor) { }

	// RVA: 0x7A1640 Offset: 0x79FC40 VA: 0x1807A1640
	private void StopUnderwaterLoop() { }

	// RVA: 0x7A17C0 Offset: 0x79FDC0 VA: 0x1807A17C0
	private void UpdateSurfaceWaterSounds(float speed, float curSubDepthY) { }

	// RVA: 0x7A11A0 Offset: 0x79F7A0 VA: 0x1807A11A0
	private void StartUnderwaterMovementSounds() { }

	// RVA: 0x7A1700 Offset: 0x79FD00 VA: 0x1807A1700
	private void StopUnderwaterMovementSounds() { }

	// RVA: 0x7A0DD0 Offset: 0x79F3D0 VA: 0x1807A0DD0
	private void StartHeavyDamageSparkSound() { }

	// RVA: 0x7A14E0 Offset: 0x79FAE0 VA: 0x1807A14E0
	private void StopHeavyDamageSparkSound() { }

	// RVA: 0x7A2540 Offset: 0x7A0B40 VA: 0x1807A2540
	public void .ctor() { }

}

