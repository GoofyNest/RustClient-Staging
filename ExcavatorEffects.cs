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

	// RVA: 0x8CDD60 Offset: 0x8CC360 VA: 0x1808CDD60
	public void Awake() { }

	// RVA: 0x8CDDC0 Offset: 0x8CC3C0 VA: 0x1808CDDC0
	public void OnDestroy() { }

	// RVA: 0x8CDE00 Offset: 0x8CC400 VA: 0x1808CDE00
	public void SetMining(bool isMining, bool force = False) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

