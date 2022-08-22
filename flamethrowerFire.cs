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

	// RVA: 0x1A7D480 Offset: 0x1A7BA80 VA: 0x181A7D480
	public void PilotLightOn() { }

	// RVA: 0x1A7D500 Offset: 0x1A7BB00 VA: 0x181A7D500
	public void SetFlameStatus(bool status) { }

	// RVA: 0x1A7D570 Offset: 0x1A7BB70 VA: 0x181A7D570
	public void ShutOff() { }

	// RVA: 0x1A7D400 Offset: 0x1A7BA00 VA: 0x181A7D400
	public void FlameOn() { }

	// RVA: 0x1A7D5F0 Offset: 0x1A7BBF0 VA: 0x181A7D5F0
	private void Start() { }

	// RVA: 0x1A7D600 Offset: 0x1A7BC00 VA: 0x181A7D600
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

