public class LiquidWeaponEffects : MonoBehaviour // TypeDefIndex: 9470
{	// Fields
	public ParticleSystem RootPS; // 0x18
	public ParticleSystem EmissionPS; // 0x20
	public ParticleSystem InnerEmissionPS; // 0x28
	public LiquidWobble Liquid; // 0x30
	[HeaderAttribute] // RVA: 0x71C70 Offset: 0x71070 VA: 0x180071C70
	public float MinPressureSpeed; // 0x38
	public float MaxPressureSpeed; // 0x3C
	public AnimationCurve PressureSpeedCurve; // 0x40
	public Vector2 StreamSize; // 0x48
	public AnimationCurve PressureSizeMultiplierCurve; // 0x50
	[HeaderAttribute] // RVA: 0x71D90 Offset: 0x71190 VA: 0x180071D90
	public float MinPressureInnerSpeed; // 0x58
	public float MaxPressureInnerSpeed; // 0x5C
	public AnimationCurve InnerPressureSpeedCurve; // 0x60
	public Vector2 InnerStreamSize; // 0x68
	public AnimationCurve InnerPressureSizeMultiplierCurve; // 0x70
	[HeaderAttribute] // RVA: 0x71EA0 Offset: 0x712A0 VA: 0x180071EA0
	public bool UseImpactSplashEffect; // 0x78
	public GameObjectRef ImpactSplashEffect; // 0x80
	public float ImpactSplashEffectInterval; // 0x88
	public float FillSpeed; // 0x8C
	private BasePlayer player; // 0x90
	private float maxRange; // 0x98
	private float currentRange; // 0x9C
	private float pressure; // 0xA0
	private float nextSplashTime; // 0xA4
	private float targetWaterLevel; // 0xA8
	[HeaderAttribute] // RVA: 0x720C0 Offset: 0x714C0 VA: 0x1800720C0
	public bool firstPersonSounds; // 0xAC
	public SoundDefinition shootStartSoundDef; // 0xB0
	public SoundDefinition shootLoopSoundDef; // 0xB8
	public SoundDefinition shootLowPressureLoopSoundDef; // 0xC0
	private Sound shootLoopSound; // 0xC8
	private Sound shootLowPressureLoopSound; // 0xD0
	private SoundModulation.Modulator shootLoopGainMod; // 0xD8
	private SoundModulation.Modulator shootLowPressureGainMod; // 0xE0
	public SoundDefinition impactStartSoundDef; // 0xE8
	public SoundDefinition impactLoopSoundDef; // 0xF0
	private Sound impactLoopSound; // 0xF8
	private bool impactStartPlayed; // 0x100
	private bool lastImpactHit; // 0x101
	private Vector3 lastImpactPosition; // 0x104
	private bool emitting; // 0x110

	// Methods

	// RVA: 0x4F4F10 Offset: 0x4F3510 VA: 0x1804F4F10
	public void Init(BasePlayer player, float currentRange, float maxRange) { }

	// RVA: 0x4F52D0 Offset: 0x4F38D0 VA: 0x1804F52D0
	public void SetWaterLevel(float fraction, bool instant) { }

	// RVA: 0x4F52C0 Offset: 0x4F38C0 VA: 0x1804F52C0
	public void SetPressureFraction(float pressure) { }

	// RVA: 0x4F5D50 Offset: 0x4F4350 VA: 0x1804F5D50
	private void Update() { }

	// RVA: 0x4F4F60 Offset: 0x4F3560 VA: 0x1804F4F60
	public void OnDisable() { }

	// RVA: 0x4F5380 Offset: 0x4F3980 VA: 0x1804F5380
	public void StartEmission() { }

	// RVA: 0x4F5A60 Offset: 0x4F4060 VA: 0x1804F5A60
	public void StopEmission(float delay) { }

	// RVA: 0x4F59D0 Offset: 0x4F3FD0 VA: 0x1804F59D0
	private void StopEmissionCo() { }

	// RVA: 0x4F4940 Offset: 0x4F2F40 VA: 0x1804F4940
	private void FixedUpdate() { }

	// RVA: 0x4F4860 Offset: 0x4F2E60 VA: 0x1804F4860
	private void DoSplash(Vector3 point, Vector3 direction) { }

	// RVA: 0x4F5000 Offset: 0x4F3600 VA: 0x1804F5000
	private void OnDrawGizmos() { }

	// RVA: 0x4F5610 Offset: 0x4F3C10 VA: 0x1804F5610
	public void StartShootSounds() { }

	// RVA: 0x4F5BB0 Offset: 0x4F41B0 VA: 0x1804F5BB0
	public void StopShootSounds() { }

	// RVA: 0x4F5D00 Offset: 0x4F4300 VA: 0x1804F5D00
	private void UpdateShootSounds() { }

	// RVA: 0x4F5430 Offset: 0x4F3A30 VA: 0x1804F5430
	private void StartImpactSounds(Vector3 position) { }

	// RVA: 0x4F5AF0 Offset: 0x4F40F0 VA: 0x1804F5AF0
	private void StopImpactSounds() { }

	// RVA: 0x4F5200 Offset: 0x4F3800 VA: 0x1804F5200
	private void RepositionImpactSounds(Vector3 position) { }

	// RVA: 0x4F5FA0 Offset: 0x4F45A0 VA: 0x1804F5FA0
	public void .ctor() { }

}

