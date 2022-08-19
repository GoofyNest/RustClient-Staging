public class FireworkShell : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8272
{	// Fields
	public float fuseLengthMin; // 0x18
	public float fuseLengthMax; // 0x1C
	public float speedMin; // 0x20
	public float speedMax; // 0x24
	public ParticleSystem explodePFX; // 0x28
	public SoundPlayer explodeSound; // 0x30
	public float inaccuracyDegrees; // 0x38
	public LightEx explosionLight; // 0x40
	public float lifetime; // 0x48
	private float speed; // 0x4C
	protected bool exploded; // 0x50

	// Methods

	// RVA: 0x78A620 Offset: 0x788C20 VA: 0x18078A620 Slot: 6
	public virtual void Init(MortarFirework firework) { }

	// RVA: 0x78A940 Offset: 0x788F40 VA: 0x18078A940
	public void ToggleExplosionLight(bool wantsOn) { }

	// RVA: 0x78A9E0 Offset: 0x788FE0 VA: 0x18078A9E0 Slot: 7
	public virtual void Update() { }

	// RVA: 0x78A300 Offset: 0x788900 VA: 0x18078A300 Slot: 8
	public virtual void Cleanup() { }

	// RVA: 0x78A7D0 Offset: 0x788DD0 VA: 0x18078A7D0
	public float SoundDelayTime() { }

	// RVA: 0x78A7B0 Offset: 0x788DB0 VA: 0x18078A7B0
	public void PlaySound() { }

	// RVA: 0x78A390 Offset: 0x788990 VA: 0x18078A390 Slot: 9
	public virtual void Explode() { }

	// RVA: 0x78A2E0 Offset: 0x7888E0 VA: 0x18078A2E0 Slot: 10
	public virtual float CalculateFuseLength() { }

	// RVA: 0x78AC80 Offset: 0x789280 VA: 0x18078AC80
	public void .ctor() { }

}

