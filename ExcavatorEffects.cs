public class ExcavatorEffects : MonoBehaviour // TypeDefIndex: 9629
{	// Fields
	public static ExcavatorEffects instance; // 0x0
	public ParticleSystemContainer[] miningParticles; // 0x18
	public SoundPlayer[] miningSounds; // 0x20
	public SoundFollowCollider[] beltSounds; // 0x28
	public SoundPlayer[] miningStartSounds; // 0x30
	public GameObject[] ambientMetalRattles; // 0x38
	public bool wasMining; // 0x40

	// Methods

	// RVA: 0x8CE380 Offset: 0x8CC980 VA: 0x1808CE380
	public void Awake() { }

	// RVA: 0x8CE3E0 Offset: 0x8CC9E0 VA: 0x1808CE3E0
	public void OnDestroy() { }

	// RVA: 0x8CE420 Offset: 0x8CCA20 VA: 0x1808CE420
	public void SetMining(bool isMining, bool force = False) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

