public class flamethrowerFire : MonoBehaviour // TypeDefIndex: 11467
{	// Fields
	public ParticleSystem pilotLightFX; // 0x18
	public ParticleSystem[] flameFX; // 0x20
	public FlameJet jet; // 0x28
	public AudioSource oneShotSound; // 0x30
	public AudioSource loopSound; // 0x38
	public AudioClip pilotlightIdle; // 0x40
	public AudioClip flameLoop; // 0x48
	public AudioClip flameStart; // 0x50
	public flamethrowerState flameState; // 0x58
	private flamethrowerState previousflameState; // 0x5C

	// Methods

	// RVA: 0x1A909B0 Offset: 0x1A8EFB0 VA: 0x181A909B0
	public void PilotLightOn() { }

	// RVA: 0x1A90A30 Offset: 0x1A8F030 VA: 0x181A90A30
	public void SetFlameStatus(bool status) { }

	// RVA: 0x1A90AA0 Offset: 0x1A8F0A0 VA: 0x181A90AA0
	public void ShutOff() { }

	// RVA: 0x1A90930 Offset: 0x1A8EF30 VA: 0x181A90930
	public void FlameOn() { }

	// RVA: 0x1A90B20 Offset: 0x1A8F120 VA: 0x181A90B20
	private void Start() { }

	// RVA: 0x1A90B30 Offset: 0x1A8F130 VA: 0x181A90B30
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

