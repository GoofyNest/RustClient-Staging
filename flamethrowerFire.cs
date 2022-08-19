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

	// RVA: 0x1AA6D40 Offset: 0x1AA5340 VA: 0x181AA6D40
	public void PilotLightOn() { }

	// RVA: 0x1AA6DC0 Offset: 0x1AA53C0 VA: 0x181AA6DC0
	public void SetFlameStatus(bool status) { }

	// RVA: 0x1AA6E30 Offset: 0x1AA5430 VA: 0x181AA6E30
	public void ShutOff() { }

	// RVA: 0x1AA6CC0 Offset: 0x1AA52C0 VA: 0x181AA6CC0
	public void FlameOn() { }

	// RVA: 0x1AA6EB0 Offset: 0x1AA54B0 VA: 0x181AA6EB0
	private void Start() { }

	// RVA: 0x1AA6EC0 Offset: 0x1AA54C0 VA: 0x181AA6EC0
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

