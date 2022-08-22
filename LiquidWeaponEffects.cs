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

	// RVA: 0x4F4EA0 Offset: 0x4F34A0 VA: 0x1804F4EA0
	public void Init(BasePlayer player, float currentRange, float maxRange) { }

	// RVA: 0x4F5260 Offset: 0x4F3860 VA: 0x1804F5260
	public void SetWaterLevel(float fraction, bool instant) { }

	// RVA: 0x4F5250 Offset: 0x4F3850 VA: 0x1804F5250
	public void SetPressureFraction(float pressure) { }

	// RVA: 0x4F5CE0 Offset: 0x4F42E0 VA: 0x1804F5CE0
	private void Update() { }

	// RVA: 0x4F4EF0 Offset: 0x4F34F0 VA: 0x1804F4EF0
	public void OnDisable() { }

	// RVA: 0x4F5310 Offset: 0x4F3910 VA: 0x1804F5310
	public void StartEmission() { }

	// RVA: 0x4F59F0 Offset: 0x4F3FF0 VA: 0x1804F59F0
	public void StopEmission(float delay) { }

	// RVA: 0x4F5960 Offset: 0x4F3F60 VA: 0x1804F5960
	private void StopEmissionCo() { }

	// RVA: 0x4F48D0 Offset: 0x4F2ED0 VA: 0x1804F48D0
	private void FixedUpdate() { }

	// RVA: 0x4F47F0 Offset: 0x4F2DF0 VA: 0x1804F47F0
	private void DoSplash(Vector3 point, Vector3 direction) { }

	// RVA: 0x4F4F90 Offset: 0x4F3590 VA: 0x1804F4F90
	private void OnDrawGizmos() { }

	// RVA: 0x4F55A0 Offset: 0x4F3BA0 VA: 0x1804F55A0
	public void StartShootSounds() { }

	// RVA: 0x4F5B40 Offset: 0x4F4140 VA: 0x1804F5B40
	public void StopShootSounds() { }

	// RVA: 0x4F5C90 Offset: 0x4F4290 VA: 0x1804F5C90
	private void UpdateShootSounds() { }

	// RVA: 0x4F53C0 Offset: 0x4F39C0 VA: 0x1804F53C0
	private void StartImpactSounds(Vector3 position) { }

	// RVA: 0x4F5A80 Offset: 0x4F4080 VA: 0x1804F5A80
	private void StopImpactSounds() { }

	// RVA: 0x4F5190 Offset: 0x4F3790 VA: 0x1804F5190
	private void RepositionImpactSounds(Vector3 position) { }

	// RVA: 0x4F5F30 Offset: 0x4F4530 VA: 0x1804F5F30
	public void .ctor() { }

}

